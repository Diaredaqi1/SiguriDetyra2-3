using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace TcpSocket
{
    
    public partial class Login : Form
    {
        //objekt -> xml
        XmlSerializer xs;
        List<PersonRegister> ls;
        public Login()
        {
            InitializeComponent();
            ls = new List<PersonRegister>();
            xs = new XmlSerializer(typeof(List<PersonRegister>));


        }



        RSACryptoServiceProvider obj = new RSACryptoServiceProvider();
        XmlDocument objXML = new XmlDocument();




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginb_Click(object sender, EventArgs e)
        {
           
            if (idbox.Text != "" && passbox.Text != "")
            {

                User u = new User();
                u.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   
        }

        private void sig_Click(object sender, EventArgs e)
        {
            if (idbox.Text != "" && passbox.Text != "")
            {
                objXML.Load("registerl.xml");
                SignedXml signedXml = new SignedXml(objXML);

                Reference referenca = new Reference();
                referenca.Uri = "";
                XmlDsigEnvelopedSignatureTransform xmlDsigEnvelopedSignitureTransform =
                    new XmlDsigEnvelopedSignatureTransform();
                referenca.AddTransform(xmlDsigEnvelopedSignitureTransform);

                signedXml.AddReference(referenca);
                KeyInfo ki = new KeyInfo();
                ki.AddClause(new RSAKeyValue(obj));

                signedXml.KeyInfo = ki;
                signedXml.SigningKey = obj;
                signedXml.ComputeSignature();

                XmlElement SignatureNode = signedXml.GetXml();
                XmlElement rootNode = objXML.DocumentElement;

                rootNode.AppendChild(SignatureNode);
                objXML.Save("SignedLogin.xml");
                MessageBox.Show("Login was signed");
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idbox.Text != "" && passbox.Text != "")
            {
                objXML.Load("SignedLogin.xml");
                SignedXml objSignedXml = new SignedXml(objXML);
                XmlNodeList signatureNodes = objXML.GetElementsByTagName("Signature");
                XmlElement signatureNode = (XmlElement)signatureNodes[0];
                objSignedXml.LoadXml(signatureNode);
                if (objSignedXml.CheckSignature() == true)
                {
                   MessageBox.Show("Signature is valid!");
                    FileStream fs = new FileStream("C:\\Users\\Diare\\Downloads\\TcpSocket-master\\TcpSocket-master\\TcpSocket\\bin\\Debug\\registerl.xml", FileMode.Open, FileAccess.Read);
                    ls = (List<PersonRegister>)xs.Deserialize(fs);
                    dataGridView1.DataSource = ls;
                    fs.Close();
                }
                else
                {

                    MessageBox.Show("Signature is not valid!");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
