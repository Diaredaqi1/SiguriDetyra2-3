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

namespace TcpSocket
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        RSACryptoServiceProvider obj = new RSACryptoServiceProvider();
        XmlDocument objXML = new XmlDocument();

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnRuaj_Click_1(object sender, EventArgs e)
        {
            if (File.Exists("shpenzimet.xml") == false)
            {
                XmlTextWriter xmltw = new XmlTextWriter("shpenzimet.xml", Encoding.UTF8);
                xmltw.WriteStartElement("shfrytezuesi");
                xmltw.Close();
            }
            objXML.Load("shpenzimet.xml");

            string salt = new Random().Next(100000, 1000000).ToString();
            string password = tpass.Text;

            string saltedPass = salt + password;
            string SaltedHashPassword = Calculate(saltedPass);
            tpass.Text = SaltedHashPassword;


            XmlElement rootNode = objXML.DocumentElement;
            XmlElement IdNode = objXML.CreateElement("ID");
            XmlElement EmriNode = objXML.CreateElement("Emri");
            XmlElement MbiemriNode = objXML.CreateElement("Mbiemri");
            XmlElement PswNode = objXML.CreateElement("Password");
            XmlElement ShpenzimetNode = objXML.CreateElement("Shpenzimet");
            XmlElement LFaturaNode = objXML.CreateElement("LFatura");
            XmlElement VitiNode = objXML.CreateElement("Viti");
            XmlElement MuajiNode = objXML.CreateElement("Muaji");
            XmlElement VEuroNode = objXML.CreateElement("VEuro");
            XmlElement DyqaniNode = objXML.CreateElement("Dyqani");

            IdNode.InnerText = tid.Text;
            EmriNode.InnerText = temri.Text;
            MbiemriNode.InnerText = tmbiemri.Text;
            PswNode.InnerText = tpass.Text;
            LFaturaNode.InnerText = tfatura.Text;
            VitiNode.InnerText = tviti.Text;
            MuajiNode.InnerText = tmuaji.Text;
            VEuroNode.InnerText = teuro.Text;
            DyqaniNode.InnerText = tdyqani.Text;

            ShpenzimetNode.AppendChild(LFaturaNode);
            ShpenzimetNode.AppendChild(VitiNode);
            ShpenzimetNode.AppendChild(MuajiNode);
            ShpenzimetNode.AppendChild(VEuroNode);
            ShpenzimetNode.AppendChild(DyqaniNode);

            rootNode.AppendChild(IdNode);
            rootNode.AppendChild(EmriNode);
            rootNode.AppendChild(MbiemriNode);
            rootNode.AppendChild(PswNode);
            rootNode.AppendChild(ShpenzimetNode);

            objXML.Save("shpenzimet.xml");
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
