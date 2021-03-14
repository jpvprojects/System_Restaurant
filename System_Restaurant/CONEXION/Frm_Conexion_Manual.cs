using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importar
using System.Xml;

namespace System_Restaurant.CONEXION
{
    public partial class Frm_Conexion_Manual : Form
    {

        LIBRERIAS.AES aes = new LIBRERIAS.AES();

        public Frm_Conexion_Manual()
        {
            InitializeComponent();
        }
        public void SaveToXml(Object dbcnString)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            root.Attributes[0].Value = Convert.ToString(dbcnString);
            XmlTextWriter writer = new XmlTextWriter("ConnectionString.xml",null);
            writer.Formatting = Formatting.Indented;
            doc.Save(writer);
            writer.Close();
        }

        string dbcnString;
        public void ReadFromXml()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ConnectionString.xml");
                XmlElement root = doc.DocumentElement;
                dbcnString = root.Attributes[0].Value;
                txt_cnString.Text = (aes.Decrypt(dbcnString, LIBRERIAS.Cls_Desencriptacion.appPwdUnique, int.Parse("256")));
            }
            catch (System.Security.Cryptography.CryptographicException ex)
            {
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Conexion_Manual_Load(object sender, EventArgs e)
        {
            ReadFromXml();
            
        }

        private void btn_encriptar_Click(object sender, EventArgs e)
        {
            SaveToXml(aes.Encrypt(txt_cnString.Text,LIBRERIAS.Cls_Desencriptacion.appPwdUnique, int.Parse("256") ) );
        }
    }
}
