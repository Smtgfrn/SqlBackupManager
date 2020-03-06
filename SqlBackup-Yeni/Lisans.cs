using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SqlBackup_Yeni
{
    public partial class Lisans : Form
    {
        public Lisans()
        {
            InitializeComponent();
        }

        private void Lisans_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server=178.211.54.219;Database=atasayar_1362;Uid=atasayarsql;Password=Atasayar123!!;MultipleActiveResultSets=True");
            con.Open();
            SqlCommand komut = new SqlCommand("Select * From atasayarsql.bLicance where mail='"+KullanıcıBilgi.MailAdresi+"'", con);
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                txtAktivasyon.Text = dr["cguid"].ToString();
            }
            con.Close();
            //string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Lisans.xml";
            //if (File.Exists(dosya_dizini) == true)
            //{
            //    XmlTextReader XmlOku = new XmlTextReader(dosya_dizini);
            //    while (XmlOku.Read())
            //    {
            //        if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "GUID")
            //        {
            //            XmlOku.Read();
            //            txtAktivasyon.Text = XmlOku.Value;
            //        }

            //    }
            //    XmlOku.Close();

            //}

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
