using System.Threading;
using System.Windows.Forms;
using System.Text;
using System;
using System.Security.Cryptography;

namespace TcpSocket
{
    public partial class ClientForm : Form
    {
        private Client client;
        private static RSACryptoServiceProvider rsaServer = new RSACryptoServiceProvider();
        public ClientForm()
        {
            client = new Client(this);

            InitializeComponent();
        }
        private bool butt = false;


        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            BtnConnect.Enabled = false;
            BtnDisconnect.Enabled = true;
            TextBoxHostName.Enabled = false;
            TextBoxPort.Enabled = false;
            TextBoxName.Enabled = true;
            TextBoxMessage.Enabled = true;
            BtnSendMessage.Enabled = true;
            if(TextBoxHostName.Text !="" && TextBoxPort.Text != "")
            {
                client.Start(TextBoxHostName.Text, int.Parse(TextBoxPort.Text));
                butt = true;
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void BtnDisconnect_Click(object sender, System.EventArgs e)
        {
            Disconnect();
        }

        delegate void DisconnectCallback();
        public void Disconnect()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DisconnectCallback(Disconnect));
            }
            else
            {
                BtnConnect.Enabled = true;
                BtnDisconnect.Enabled = false;
                TextBoxHostName.Enabled = true;
                TextBoxPort.Enabled = true;
                TextBoxName.Enabled = false;
                TextBoxMessage.Enabled = false;
                BtnSendMessage.Enabled = false;

                client.Disconnect();
            }
        }

        private void BtnSendMessage_Click(object sender, System.EventArgs e)
        {
            client.SendMessage(TextBoxName.Text + ": " + TextBoxMessage.Text);
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
                ListBoxClientInformations.Items.Add(message);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (butt == true)
            {
                Register reg = new Register();
                reg.ShowDialog();
            }
            else
            {
                MessageBox.Show("First you have to connect with server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (butt == true)
            {

                Login log = new Login();
                log.ShowDialog();
            }
            else
            {
                MessageBox.Show("First you have to connect with server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        string DESEncrypt(string data)
        {
            DESCryptoServiceProvider DESalg = new DESCryptoServiceProvider();

            byte[] EncryptedData = MyDES.EncryptTextToMemory(data, DESalg.Key, DESalg.IV);

            byte[] RSAKey = RSA.RSAEncrypt(DESalg.Key, rsaServer.ExportParameters(false), false);

            return Convert.ToBase64String(DESalg.IV) + "*" + Convert.ToBase64String(RSAKey) + "*" + Convert.ToBase64String(EncryptedData);


        }


    }
}
