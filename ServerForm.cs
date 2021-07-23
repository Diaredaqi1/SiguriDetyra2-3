using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;

namespace TcpSocket
{
    public partial class ServerForm : Form
    {
        private Server server;

        public ServerForm()
        {
            server = new Server(this);

            InitializeComponent();
        }

        private void ServerForm_Load(object sender, System.EventArgs e)
        {
            new Thread(new ThreadStart(RunClientThread)).Start();
        }

        private void RunClientThread()
        {
            new ClientForm().ShowDialog();
        }

        private void BtnStartServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = false;
            BtnStopServer.Enabled = true;
            TextBoxPort.Enabled = false;

            server.Start(TextBoxHost.Text, int.Parse(TextBoxPort.Text));
        }

        private void BtnStopServer_Click(object sender, System.EventArgs e)
        {
            BtnStartServer.Enabled = true;
            BtnStopServer.Enabled = false;
            TextBoxPort.Enabled = true;

            server.Stop();
        }

        delegate void SetMessageCallback(string message);
        public void SetMessage(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new SetMessageCallback(SetMessage), message);
            }
            else
            {
                if (server.CanWrite())
                    ListServerInformations.Items.Add(message);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            x509Store.Open(OpenFlags.OpenExistingOnly);
            X509Certificate2Collection collectionCert = X509Certificate2UI.SelectFromCollection(x509Store.Certificates, "Choose certificate", "Choose certificate to sign", X509SelectionFlag.SingleSelection);
            X509Certificate2 certifikata = null;
            if (collectionCert[0].HasPrivateKey) {
                certifikata = collectionCert[0];
                MessageBox.Show("The choosen certificate belongs to " + certifikata.Subject);
            }
            
        }
    }
}
