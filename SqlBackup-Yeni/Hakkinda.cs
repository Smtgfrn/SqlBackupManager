using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlBackup_Yeni
{
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Hakkinda_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=178.211.54.219;Database=atasayar_1362;Uid=atasayarsql;Password=Atasayar123!!;MultipleActiveResultSets=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM atasayarsql.bLicance WHERE mail='" + KullanıcıBilgi.MailAdresi + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblFirma.Text = dt.Rows[0][6].ToString();
            string gtarih = dt.Rows[0][5].ToString();
            string btarih = dt.Rows[0][4].ToString();
            TimeSpan zamanFarki = Convert.ToDateTime(btarih)- Convert.ToDateTime(gtarih);
            int gun = Convert.ToInt32(zamanFarki.TotalDays);
            if(gun == 30)
            {
                lblLisansTur.Text = "Demo";
            }
            else
            {
                lblLisansTur.Text = "Lisanslı";
            }
            lblBTarih.Text = dt.Rows[0][4].ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                                                    