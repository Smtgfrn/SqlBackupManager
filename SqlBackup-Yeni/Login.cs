using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SqlBackup_Yeni
{
    public partial class Login : Form
    {
        TarihCek tc = new TarihCek();
        public Login()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            txtSifre.PasswordChar = ('*');
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=178.211.54.219;Database=atasayar_1362;Uid=atasayarsql;Password=Atasayar123!!;MultipleActiveResultSets=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM atasayarsql.bLicance WHERE mail='" + txtMail.Text.Trim() + "' AND sifre='" + txtSifre.Text.Trim() + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);

            if(chHatirla.Checked && txtMail.Text != "" && txtSifre.Text != "")
            {
                if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Login.xml"))
                {
                    System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Login.xml");
                }
            
                    XmlTextWriter yaz = new XmlTextWriter("Login.xml", System.Text.UTF8Encoding.UTF8);
                    yaz.Formatting = Formatting.Indented;
                    string GuidKey = Guid.NewGuid().ToString();
                    try
                    {
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("KullaniciBilgi");

                        yaz.WriteElementString("Mail", txtMail.Text);
                        yaz.WriteElementString("Şifre", txtSifre.Text);
                    yaz.WriteEndElement();
                        yaz.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
            }
            if(chHatirla.Checked == false && txtMail.Text != "" && txtSifre.Text != "")
            {
                if (System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Login.xml"))
                {
                    System.IO.File.Delete(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Login.xml");
                }
            }
            
            if (dt.Rows.Count == 1)
            {
                con.Open();
                if (dt.Rows[0][5].ToString() == "")
                {
                    string kayıt = "Update atasayarsql.bLicance SET gtarih=@gtarih where mail='" + txtMail.Text.Trim() + "'";
                    SqlCommand komut = new SqlCommand(kayıt, con);
                    DateTime tarih = tc.GetNistTime();
                    komut.Parameters.AddWithValue("@gtarih", tarih);
                    komut.ExecuteNonQuery();
                }
                con.Close();
                KullanıcıBilgi.MailAdresi = txtMail.Text;
                this.Hide();
                new Form1().Show();
                
            }
            else
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre girdiniz!");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Lisans.xml"))
            {
                XmlTextWriter yaz = new XmlTextWriter("Lisans.xml", System.Text.UTF8Encoding.UTF8);
                yaz.Formatting = Formatting.Indented;
                string GuidKey = Guid.NewGuid().ToString();
                try
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("Lisans");

                    yaz.WriteElementString("ID", "1");
                    yaz.WriteElementString("GUID", GuidKey);

                    yaz.WriteEndElement();
                    yaz.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            string Login_Dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Login.xml";
            if (File.Exists(Login_Dizini) == true)
            {
                XmlTextReader XmlOku = new XmlTextReader(Login_Dizini);
                while (XmlOku.Read())
                {
                    if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "Mail")
                    {
                        XmlOku.Read();
                        txtMail.Text = XmlOku.Value;
                    }
                    if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "Şifre")
                    {
                        XmlOku.Read();
                        txtSifre.Text = XmlOku.Value;
                    }
                    chHatirla.Checked = true;
                }
                XmlOku.Close();

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
