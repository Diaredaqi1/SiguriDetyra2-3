using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Xml;
using System.IO;
using System.Xml.Serialization;



namespace TcpSocket
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        RSACryptoServiceProvider obj = new RSACryptoServiceProvider();
        XmlDocument objXML = new XmlDocument();



        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tregister_Click(object sender, EventArgs e)
        {
            if (File.Exists("registerl.xml") == false)
            {
                XmlTextWriter xmltw = new XmlTextWriter("registerl.xml", Encoding.UTF8);
                xmltw.WriteStartElement("person");
                xmltw.Close();
            }
            objXML.Load("registerl.xml");
            string salt = new Random().Next(100000, 1000000).ToString();
            string password = pass1.Text;

            string saltedPass = salt + password;
            string SaltedHashPassword = Calculate(saltedPass);
            pass1.Text = SaltedHashPassword;


            XmlElement rootNode = objXML.DocumentElement;
            XmlElement IdNode = objXML.CreateElement("ID");
            XmlElement EmriNode = objXML.CreateElement("Emri");
            XmlElement MbiemriNode = objXML.CreateElement("Mbiemri");
            XmlElement PswNode = objXML.CreateElement("Password");

            IdNode.InnerText = id1.Text;
            EmriNode.InnerText = emri1.Text;
            MbiemriNode.InnerText = mbiemri1.Text;
            PswNode.InnerText = pass1.Text;

            rootNode.AppendChild(IdNode);
            rootNode.AppendChild(EmriNode);
            rootNode.AppendChild(MbiemriNode);
            rootNode.AppendChild(PswNode);


            if (id1.Text != "" && emri1.Text != "" && mbiemri1.Text != "" && pass1.Text != "")
            {
                objXML.Save("registerl.xml");
               
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private string Calculate(string saltedPass)
        {
            byte[] bytesaltedPass = Encoding.UTF8.GetBytes(saltedPass);
            SHA1CryptoServiceProvider objHash = new SHA1CryptoServiceProvider();
            byte[] byteSaltedHashPassword = objHash.ComputeHash(bytesaltedPass);

            return Convert.ToBase64String(byteSaltedHashPassword);
        }
    }
}
