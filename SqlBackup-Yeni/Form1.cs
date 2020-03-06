using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using File = System.IO.File;

namespace SqlBackup_Yeni
{
    public partial class Form1 : Form
    {
        
        private SqlConnection con = new SqlConnection("Server=178.211.54.219;Database=atasayar_1362;Uid=atasayarsql;Password=Atasayar123!!;MultipleActiveResultSets=True");
        string connectionstring = "";
        
        List<string> databases = new List<string>();
        List<string> saatler = new List<string>();
        List<string> gunler = new List<string>();
        List<string> aylar = new List<string>();
        int demo_suresi = 30;
        string mailAdres = "";
        
        FileInfo fileInfo;
        string uzanti = ".bak";
        GoogleDrive gd = new GoogleDrive();
        TarihCek tc = new TarihCek();

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullanici.MaxLength = 30;
            txtSifre.MaxLength = 30;
            txtDataSource.MaxLength = 50;
            txtFtpDir.MaxLength = 30;
            txtFtpSifre.MaxLength = 30;
            txtHost.MaxLength = 30;
            txtMail.MaxLength = 50;
            txtSifre.PasswordChar = '*';
            GunlukZamanlayici.Interval = 60 * 1000;
            HaftalikZamanlayici.Interval = 24 * 3600 * 1000;
            AylikZamanlayici.Interval = 24 * 3600 * 1000;
            DemoZamanlayici.Interval = 24 * 3600 * 1000;

            DemoZamanlayici.Enabled = true;
            DemoZamanlayici.Start();

          

            string Mail_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "MailAdres.xml";
            if (File.Exists(Mail_dizini) == true)
            {
                XmlTextReader XmlOku = new XmlTextReader(Mail_dizini);
                while (XmlOku.Read())
                {
                    if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "mailAdres")
                    {
                        XmlOku.Read();
                        mailAdres = XmlOku.Value;
                        txtMail.Text = XmlOku.Value;
                    }
                }
                XmlOku.Close();
            }
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM atasayarsql.bLicance WHERE mail='" + KullanıcıBilgi.MailAdresi + "'", con);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);
            string gtarih = dt1.Rows[0][5].ToString();
            string btarih = dt1.Rows[0][4].ToString();
            TimeSpan zamanFarki = Convert.ToDateTime(btarih) - Convert.ToDateTime(gtarih);
            int gun = Convert.ToInt32(zamanFarki.TotalDays);

            if (gun == 30)
            {
                DateTime today = tc.GetNistTime();
                TimeSpan zamanFarki1 = today - Convert.ToDateTime(dt1.Rows[0][5].ToString());
                int kalansure = demo_suresi - Convert.ToInt32(zamanFarki1.TotalDays);
                this.Text = "SqlBackup      " + "Kalan Süre:  " + kalansure.ToString();

                if (kalansure <= 0)
                {
                    MessageBox.Show("Demo süreniz dolmuştur. Lütfen Lisans alınız!");
                    Application.Exit();
                }
            }
            else
            {
                this.Text = "SqlBackup      " +"Lisans";
                if(btarih == tc.GetNistTime().ToString())
                {
                    MessageBox.Show("Lisansınızın süresi dolmuştur!");
                    Application.Exit();
                }
            }

            string GunlukKonum = txtKonum.Text + "/" + "Gunluk";

            if (Directory.Exists(GunlukKonum) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(GunlukKonum);
                Directory.GetCreationTime(GunlukKonum);
            }
            string HaftalikKonum = txtKonum.Text + "/" + "Haftalık";

            if (Directory.Exists(HaftalikKonum) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(HaftalikKonum);
                Directory.GetCreationTime(HaftalikKonum);
            }
            string AylikKonum = txtKonum.Text + "/" + "Aylık";

            if (Directory.Exists(AylikKonum) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(AylikKonum);
                Directory.GetCreationTime(AylikKonum);
            }




            string gunluk_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "gunlukSaatleri.xml";
            if (File.Exists(gunluk_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;

                FileStream fs = new FileStream("gunlukSaatleri.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Gunluk");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {
                    for (int t = 0; t < xmlnode[i].ChildNodes.Count; t++)
                    {
                        saatler.Add(xmlnode[i].ChildNodes.Item(t).InnerText.Trim());
                    }
                }

                fs.Close();
            }
            string haftalik_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "haftalik.xml";
            if (File.Exists(haftalik_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;

                FileStream fs = new FileStream("haftalik.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Hafta");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {
                    for (int t = 0; t < xmlnode[i].ChildNodes.Count; t++)
                    {
                        gunler.Add(xmlnode[i].ChildNodes.Item(t).InnerText.Trim());
                    }
                }

                fs.Close();
            }
            string aylik_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "aylik.xml";
            if (File.Exists(aylik_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;

                FileStream fs = new FileStream("aylik.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Aylık");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {
                    for (int t = 0; t < xmlnode[i].ChildNodes.Count; t++)
                    {
                        aylar.Add(xmlnode[i].ChildNodes.Item(t).InnerText.Trim());
                    }
                }

                fs.Close();
            }

            if (File.Exists(gunluk_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                FileStream fs = new FileStream("gunlukSaatleri.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Gunluk");
                for (int j = 0; j <= xmlnode.Count - 1; j++)
                {

                    for (int k = 0; k < clbGunluk.Items.Count; k++)
                    {
                        for (int t = 0; t < xmlnode[j].ChildNodes.Count; t++)
                        {
                            if (clbGunluk.Items[k].ToString() == xmlnode[j].ChildNodes.Item(t).InnerText.Trim())
                            {
                                clbGunluk.SetItemChecked(k, true);
                            }
                        }
                    }
                }
                fs.Close();
            }

            if (File.Exists(haftalik_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                FileStream fs = new FileStream("haftalik.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Hafta");
                for (int j = 0; j <= xmlnode.Count - 1; j++)
                {

                    for (int k = 0; k < clbHaftalik.Items.Count; k++)
                    {
                        for (int t = 0; t < xmlnode[j].ChildNodes.Count; t++)
                        {
                            if (clbHaftalik.Items[k].ToString() == xmlnode[j].ChildNodes.Item(t).InnerText.Trim())
                            {
                                clbHaftalik.SetItemChecked(k, true);
                            }
                        }
                    }
                }
                fs.Close();
            }

            if (File.Exists(aylik_dizini) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;
                FileStream fs = new FileStream("aylik.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Aylık");
                for (int j = 0; j <= xmlnode.Count - 1; j++)
                {

                    for (int k = 0; k < clbAylik.Items.Count; k++)
                    {
                        for (int t = 0; t < xmlnode[j].ChildNodes.Count; t++)
                        {
                            if (clbAylik.Items[k].ToString() == xmlnode[j].ChildNodes.Item(t).InnerText.Trim())
                            {
                                clbAylik.SetItemChecked(k, true);
                            }
                        }
                    }
                }
                fs.Close();

            }
            string ftpServer_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "ftpServer.xml";
            if (File.Exists(ftpServer_dizini) == true)
            {
                XmlTextReader XmlOku = new XmlTextReader(ftpServer_dizini);
                while (XmlOku.Read())
                {
                    if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "hostName")
                    {
                        XmlOku.Read();
                        txtHost.Text = XmlOku.Value;
                    }
                    else if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "ftpDir")
                    {
                        XmlOku.Read();
                        txtFtpDir.Text = XmlOku.Value;
                    }
                    else if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "ftpKAdi")
                    {
                        XmlOku.Read();
                        txtFtpKAdi.Text = XmlOku.Value;
                    }
                    else if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "ftpSifre")
                    {
                        XmlOku.Read();
                        txtFtpSifre.Text = XmlOku.Value;
                    }
                }
                XmlOku.Close();

            }
            string Drive_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "driveBilgi.xml";
            if (File.Exists(Drive_dizini) == true)
            {
                gd.DriveLogin();
                btnDriveBaglan.Enabled = false;
            }
            string guid = "";
            string Lisans_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "Lisans.xml";
            if (File.Exists(Lisans_dizini) == true)
            {
                XmlTextReader XmlOku = new XmlTextReader(Lisans_dizini);
                while (XmlOku.Read())
                {
                    if (XmlOku.NodeType == XmlNodeType.Element && XmlOku.Name == "GUID")
                    {
                        XmlOku.Read();
                        guid = XmlOku.Value;
                    }
             
                }
                XmlOku.Close();

            }

            string GuidKey = "";
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM atasayarsql.bLicance WHERE mail='" + KullanıcıBilgi.MailAdresi+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][3].ToString() == "")
            {
                con.Open();
                GuidKey = Guid.NewGuid().ToString();
                string kayıt = "Update atasayarsql.bLicance SET cguid=@cguid where mail='" + KullanıcıBilgi.MailAdresi + "'";
                SqlCommand komut = new SqlCommand(kayıt, con);
                komut.Parameters.AddWithValue("@cguid", guid);
                komut.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                if(dt.Rows[0][3].ToString() != guid)
                {
                    MessageBox.Show("GUID Hatası!!!");
                    Application.Exit();
                }
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            if (txtKonum.Text == "")
            {
                MessageBox.Show("Lütfen Kaydetmek İstediğiniz Dosya Konumunu Seçiniz");
            }
            else
            {
                string[] dosyalar = Directory.GetFiles(txtKonum.Text, "*.*");
                foreach (string file in dosyalar)
                {
                    FileInfo fi = new FileInfo(file);
                    for (int i = 0; i < clbDatabase.CheckedItems.Count; i++)
                    {
                        if (fi.Name.StartsWith(clbDatabase.CheckedItems[i].ToString()))
                        {
                            if (fi.LastWriteTime < DateTime.Now.AddMilliseconds(-10))
                                fi.Delete();
                        }
                    }
                }

                MailMessage mesaj = new MailMessage();
                SmtpClient ıstemcı = new SmtpClient();
                ıstemcı.Credentials = new System.Net.NetworkCredential("atasayardeneme@gmail.com", "atasayar1234");
                ıstemcı.Port = 587;
                ıstemcı.Host = "smtp.gmail.com";
                ıstemcı.EnableSsl = true;

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {

                    conn.Open();
                    if (clbDatabase.CheckedItems.Count == 0 || txtMail.Text == "")
                    {
                        MessageBox.Show("Lütfen boş alan bırakmayınız!");
                    }
                    else
                    {
                        for (int i = 0; i < clbDatabase.CheckedItems.Count; i++)
                        {
                            string cmd = "BACKUP DATABASE [" + clbDatabase.CheckedItems[i].ToString() + "] TO DISK='" + txtKonum.Text + "\\" + clbDatabase.CheckedItems[i].ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak'";
                            using (SqlCommand command = new SqlCommand(cmd, conn))
                            {
                                if (conn.State != ConnectionState.Open)
                                {

                                    conn.Open();
                                }
                                command.CommandTimeout = 999999;
                                command.ExecuteNonQuery();
                                conn.Close();

                                string seciliDatabase = clbDatabase.CheckedItems[i].ToString();
                                string zipKonum = txtKonum.Text + "/" + seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                                string zipFile = zipKonum.ToString();
                                string fileName = txtKonum.Text + "/" + clbDatabase.CheckedItems[i].ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
                                string zipName = seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                                
                                using (ZipArchive zipArchive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
                                {
                                    FileInfo fi = new FileInfo(fileName);
                                    zipArchive.CreateEntryFromFile(fi.FullName, fi.Name, CompressionLevel.Optimal);
                                    zipArchive.Dispose();
                                }

                                foreach (string dosya in Directory.GetFiles(txtKonum.Text))
                                {

                                    fileInfo = new FileInfo(dosya);
                                    if (fileInfo.Extension == uzanti)
                                    {
                                        fileInfo.Delete();
                                    }
                                }

                                string dosyaAdi = seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                            }
                            conn.Close();
                            databases.Add(clbDatabase.CheckedItems[i].ToString());
                        }
                        DataSet ds = new DataSet("Veritabanlari");
                        DataTable dt = new DataTable("Veritabani");

                        dt.Columns.Add("Adi");

                        ds.Tables.Add(dt);

                        foreach (string veritabani in databases)
                        {
                            DataRow row = ds.Tables["Veritabani"].NewRow();
                            row["Adi"] = veritabani.ToString();
                            ds.Tables["Veritabani"].Rows.Add(row);

                        }
                        ds.WriteXml("Veritabanlari.xml");

                        MessageBox.Show("Yedekleme İşleminiz Başarıyla Gerçekleşmiştir.");
                        if(mailAdres != "")
                        {
                            mesaj.To.Add(mailAdres);
                            mesaj.From = new MailAddress("atasayardeneme@gmail.com");
                            mesaj.Subject = "Sql Backup";
                            mesaj.Body = "Veritabanı kaydetme işleminiz başarıyla gerçekleşmiştir.";
                            ıstemcı.Send(mesaj);
                        }
                    }

                }
                GunlukZamanlayici.Enabled = true;
                GunlukZamanlayici.Start();
                HaftalikZamanlayici.Enabled = true;
                HaftalikZamanlayici.Start();
                AylikZamanlayici.Enabled = true;
                AylikZamanlayici.Start();
            }
        }

        private void btnKonumSec_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtKonum.Text = dlg.SelectedPath;
            }
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            clbDatabase.Enabled = true;
            string DosyaYolu = "Veritabanlari" + ".xml";
            XmlTextReader oku = new XmlTextReader(DosyaYolu);
            List<string> seciliVeritabanlari = new List<string>();
            try
            {

                connectionstring = "Data Source = " + txtDataSource.Text + "; User Id = " + txtKullanici.Text + "; Password = " + txtSifre.Text + "";
                con = new SqlConnection(connectionstring);
                con.Open();
                List<string> veritabanlari = new List<string>();

                clbDatabase.ClearSelected();

                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases d where d.database_id>4", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            veritabanlari.Add(dr[0].ToString());
                        }
                    }
                }

                txtDataSource.Enabled = false;
                txtKullanici.Enabled = false;
                txtSifre.Enabled = false;
                btnBaglan.Enabled = false;
                btnBaglanKes.Enabled = true;
                btnYedekle.Enabled = true;
                btnKonumSec.Enabled = true;
                chZamanlayiciAyar.Enabled = true;
                con.Close();


                for (int i = 0; i < veritabanlari.Count; i++)
                {
                    clbDatabase.Items.Add(veritabanlari[i]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            if (File.Exists(DosyaYolu) == true)
            {
                XmlDataDocument xmldoc = new XmlDataDocument();
                XmlNodeList xmlnode;

                string str = null;
                FileStream fs = new FileStream("Veritabanlari.xml", FileMode.Open, FileAccess.Read);
                xmldoc.Load(fs);
                xmlnode = xmldoc.GetElementsByTagName("Veritabani");
                for (int i = 0; i <= xmlnode.Count - 1; i++)
                {

                    for (int j = 0; j < clbDatabase.Items.Count; j++)
                    {
                        if (clbDatabase.Items[j].ToString() == xmlnode[i].ChildNodes.Item(0).InnerText.Trim())
                        {
                            clbDatabase.SetItemChecked(j, true);
                        }
                    }
                }
                fs.Close();
            }

        }

        private void btnBaglanKes_Click(object sender, EventArgs e)
        {
            txtDataSource.Enabled = true;
            txtKullanici.Enabled = true;
            txtSifre.Enabled = true;
            clbDatabase.Enabled = false;
            btnBaglan.Enabled = true;
            btnBaglanKes.Enabled = false;
            btnYedekle.Enabled = false;
            btnKonumSec.Enabled = false;
            chZamanlayiciAyar.Enabled = false;

            txtDataSource.Text = "";
            txtKullanici.Text = "";
            txtSifre.Text = "";
            clbDatabase.Items.Clear();
        }
        private void Yedekle(string durum)
        {
            IList<Google.Apis.Drive.v3.Data.File> dosyaBilgiler = gd.GetFiles();
            //IList<Google.Apis.Drive.v3.Data.File> dosyaBilgiler = GetFiles();
            string sonKonum = txtKonum.Text + "/" + durum;
            string[] dosyalar = Directory.GetFiles(sonKonum, "*.*");
            foreach (string file in dosyalar)
            {
                FileInfo fi = new FileInfo(file);
                for (int i = 0; i < clbDatabase.CheckedItems.Count; i++)
                {
                    if (fi.Name.StartsWith(clbDatabase.CheckedItems[i].ToString()))
                    {
                        if (fi.LastWriteTime < DateTime.Now.AddMilliseconds(-10))
                            fi.Delete();
                    }
                }
            }
            if (btnDriveBaglan.Enabled == false)
            {
                if (dosyaBilgiler != null && dosyaBilgiler.Count > 0)
                {
                    foreach (var file in dosyaBilgiler)
                    {
                        for (int i = 0; i < clbDatabase.CheckedItems.Count; i++)
                        {
                            if (file.Name.StartsWith(durum + ":" + clbDatabase.CheckedItems[i].ToString()))
                            {
                                gd.DeleteFiles(file.Id);
                                //DeleteFiles(file.Id);
                            }
                        }
                    }

                }
                int sayac = 0;
                    
                if (dosyaBilgiler != null && dosyaBilgiler.Count > 0)
                {
                    foreach (var file in dosyaBilgiler)
                    {

                        if (file.Name == durum)
                        {
                            sayac++;
                        }
                    }
                }
                if (sayac == 0)
                {
                    gd.CreateDirectory(durum);
                    //CreateDirectory(durum);
                }
            }
            MailMessage mesaj = new MailMessage();
            SmtpClient ıstemcı = new SmtpClient();
            ıstemcı.Credentials = new System.Net.NetworkCredential("atasayardeneme@gmail.com", "atasayar1234");
            ıstemcı.Port = 587;
            ıstemcı.Host = "smtp.gmail.com";
            ıstemcı.EnableSsl = true;

            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                if (txtKonum.Text == "")
                {
                    MessageBox.Show("Lütfen Kaydetmek İstediğiniz Dosya Konumunu Seçiniz");

                }
                else
                {
                    for (int i = 0; i < clbDatabase.CheckedItems.Count; i++)
                    {
                        string cmd = "BACKUP DATABASE [" + clbDatabase.CheckedItems[i].ToString() + "] TO DISK='" + txtKonum.Text + "/" + durum + "\\" + clbDatabase.CheckedItems[i].ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak'";
                        using (SqlCommand command = new SqlCommand(cmd, conn))
                        {
                            if (conn.State != ConnectionState.Open)
                            {
                                conn.Open();
                            }
                            command.CommandTimeout = 999999;
                            command.ExecuteNonQuery();
                            conn.Close();
                            string seciliDatabase = clbDatabase.CheckedItems[i].ToString();
                            string zipKonum = txtKonum.Text + "/" + durum + "/" + seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                            string zipFile = zipKonum.ToString();
                            string fileName = txtKonum.Text + "/" + durum + "/" + clbDatabase.CheckedItems[i].ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";
                            string zipName = seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                            string dosyaAdi = seciliDatabase.ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".zip";
                            using (ZipArchive zipArchive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
                            {
                                FileInfo fi = new FileInfo(fileName);
                                zipArchive.CreateEntryFromFile(fi.FullName, fi.Name, CompressionLevel.Optimal);
                                zipArchive.Dispose();
                            }
                            string yeniKonum = txtKonum.Text + "/" + durum;
                            foreach (string dosya in Directory.GetFiles(yeniKonum))
                            {

                                fileInfo = new FileInfo(dosya);
                                if (fileInfo.Extension == uzanti)
                                {
                                    fileInfo.Delete();
                                }
                            }


                            if (chFtpAyar.Checked == true)
                            {
                                try
                                {
                                    FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create("ftp://" + txtHost.Text + "//" + txtFtpDir.Text + "/" + durum + "/" + dosyaAdi);
                                    request.Method = WebRequestMethods.Ftp.UploadFile;
                                    request.Credentials = new NetworkCredential(txtFtpKAdi.Text, txtFtpSifre.Text);
                                    request.UsePassive = true;
                                    request.UseBinary = true;
                                    request.KeepAlive = false;

                                    FileStream stream = File.OpenRead(zipFile);
                                    byte[] buffer = new byte[stream.Length];

                                    stream.Read(buffer, 0, buffer.Length);
                                    stream.Close();
                                    Stream reqStream = request.GetRequestStream();
                                    reqStream.Write(buffer, 0, buffer.Length);
                                    reqStream.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                            if (btnDriveBaglan.Enabled == false)
                            {
                                string dosyaAd = clbDatabase.CheckedItems[i].ToString() + "-" + DateTime.Now.ToString("yyyy-MM-dd") + ".bak";

                                if (dosyaBilgiler != null && dosyaBilgiler.Count > 0)
                                {
                                    foreach (var file in dosyaBilgiler)
                                    {

                                        if (file.Name == durum)
                                        {
                                            gd.UploadFiles(durum, zipKonum, dosyaAd, file.Id);
                                            //UploadFiles(durum, zipKonum, dosyaAd, file.Id);
                                        }
                                    }
                                }
                            }

                        }
                        conn.Close();
                        if (mailAdres != "")
                        {
                            mesaj.To.Add(mailAdres);
                            mesaj.From = new MailAddress("atasayardeneme@gmail.com");
                            mesaj.Subject = "Sql Backup";
                            mesaj.Body = durum + " veritabanı kaydetme işleminiz başarıyla gerçekleşmiştir.";
                            ıstemcı.Send(mesaj);
                        }
                    }
                }
            }
        }

        private void GunlukZamanlayici_Tick(object sender, EventArgs e)
        {
            foreach (string saat in saatler)
            {
                if (saat.ToString() == DateTime.Now.ToString("HH:mm"))
                    Yedekle("Gunluk");
            }
        }

        private void AylikZamanlayici_Tick(object sender, EventArgs e)
        {
            foreach (string ay in aylar)
            {
                if (ay.ToString() == DateTime.Now.ToString("MMMM") && DateTime.Now.ToString("dd") == "15")
                    Yedekle("Aylık");
            }
        }

        private void HaftalikZamanlayici_Tick(object sender, EventArgs e)
        {
            foreach (string gun in gunler)
            {
                if (gun.ToString() == DateTime.Now.ToString("dddd"))
                    Yedekle("Haftalık");
            }
        }

        private void chZamanlayiciAyar_CheckedChanged(object sender, EventArgs e)
        {
            if (chZamanlayiciAyar.Checked == true)
            {
                chGunluk.Visible = true;
                chHaftalik.Visible = true;
                chAylik.Visible = true;
                btnZamanlayiciKaydet.Visible = true;
                if (chGunluk.Checked == true)
                    clbGunluk.Visible = true;
                if (chHaftalik.Checked == true)
                    clbHaftalik.Visible = true;
                if (chAylik.Checked == true)
                    clbAylik.Visible = true;
            }
            else
            {
                chGunluk.Visible = false;
                chHaftalik.Visible = false;
                chAylik.Visible = false;
                btnZamanlayiciKaydet.Visible = false;
                clbGunluk.Visible = false;
                clbHaftalik.Visible = false;
                clbAylik.Visible = false;
            }
        }

        private void chGunluk_CheckedChanged(object sender, EventArgs e)
        {
            if (chGunluk.Checked == true)
            {
                clbGunluk.Visible = true;
            }
            else
            {
                clbGunluk.Visible = false;
            }
        }

        private void chHaftalik_CheckedChanged(object sender, EventArgs e)
        {
            if (chHaftalik.Checked == true)
            {
                clbHaftalik.Visible = true;
            }
            else
            {
                clbHaftalik.Visible = false;
            }
        }

        private void chAylik_CheckedChanged(object sender, EventArgs e)
        {
            if (chAylik.Checked == true)
            {
                clbAylik.Visible = true;
            }
            else
            {
                clbAylik.Visible = false;
            }
        }

        private void btnZamanlayiciKaydet_Click(object sender, EventArgs e)
        {
            if (chGunluk.Checked == true)
            {
                if (clbGunluk.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen günlük saat seçiniz!");
                }
                else
                {
                    XmlTextWriter yaz = new XmlTextWriter("gunlukSaatleri.xml", System.Text.UTF8Encoding.UTF8);
                    yaz.Formatting = Formatting.Indented;
                    try
                    {
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("Gunluk");
                        for (int i = 0; i < clbGunluk.CheckedItems.Count; i++)
                        {
                            yaz.WriteElementString("saat", clbGunluk.CheckedItems[i].ToString());
                        }
                        yaz.WriteEndElement();
                        yaz.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (chHaftalik.Checked == true)
            {
                if (clbHaftalik.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen haftalık gün seçiniz!");
                }
                else
                {
                    XmlTextWriter yaz = new XmlTextWriter("haftalik.xml", System.Text.UTF8Encoding.UTF8);
                    yaz.Formatting = Formatting.Indented;

                    try
                    {
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("Hafta");
                        for (int i = 0; i < clbHaftalik.CheckedItems.Count; i++)
                        {

                            yaz.WriteElementString("Gun", clbHaftalik.CheckedItems[i].ToString());
                        }
                        yaz.WriteEndElement();
                        yaz.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            if (chAylik.Checked == true)
            {
                if (clbAylik.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen haftalık gün seçiniz!");

                }
                else
                {
                    XmlTextWriter yaz = new XmlTextWriter("aylik.xml", System.Text.UTF8Encoding.UTF8);
                    yaz.Formatting = Formatting.Indented;

                    try
                    {
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("Aylık");
                        for (int i = 0; i < clbAylik.CheckedItems.Count; i++)
                        {

                            yaz.WriteElementString("Gun", clbAylik.CheckedItems[i].ToString());
                        }
                        yaz.WriteEndElement();
                        yaz.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
            MessageBox.Show("Kaydetme işleminiz başarıyla gerçekleşmiştir.");
        } 
        private void btnDriveBaglan_Click(object sender, EventArgs e)
        {
            try
            {
                gd.DriveLogin();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            XmlTextWriter yaz = new XmlTextWriter("driveBilgi.xml", System.Text.UTF8Encoding.UTF8);
            yaz.Formatting = Formatting.Indented;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "driveBilgi.xml"))
            {
                try
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("driveBilgi");

                    yaz.WriteElementString("Bilgi", "Bagli");
                    yaz.WriteEndElement();
                    yaz.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            btnDriveBaglan.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserCredential credential;
            using (var stream = new FileStream("client_secret.json"
                                               , FileMode.Open
                                               , FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                new[] { DriveService.Scope.Drive, DriveService.Scope.DriveFile },
                "LookIAmAUniqueUser",
                 CancellationToken.None,
                new FileDataStore(@"c:\datastore", true)
                ).Result;
            }
        }

        private void chFtpAyar_CheckedChanged(object sender, EventArgs e)
        {
            if (chFtpAyar.Checked == true)
            {
                txtFtpDir.Enabled = true;
                txtFtpKAdi.Enabled = true;
                txtFtpSifre.Enabled = true;
                txtHost.Enabled = true;
                btnFtpKaydet.Enabled = true;
            }
            else
            {
                txtFtpDir.Enabled = false;
                txtFtpKAdi.Enabled = false;
                txtFtpSifre.Enabled = false;
                txtHost.Enabled = false;
                btnFtpKaydet.Enabled = false;
            }
        }

        private void btnFtpKaydet_Click(object sender, EventArgs e)
        {
            XmlTextWriter yaz = new XmlTextWriter("ftpServer.xml", System.Text.UTF8Encoding.UTF8);
            yaz.Formatting = Formatting.Indented;

            if (txtHost.Text == "" || txtFtpKAdi.Text == "" || txtFtpSifre.Text == "" || txtFtpDir.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                try
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("ftpBilgi");

                    yaz.WriteElementString("hostName", txtHost.Text);
                    yaz.WriteElementString("ftpDir", txtFtpDir.Text);
                    yaz.WriteElementString("ftpKAdi", txtFtpKAdi.Text);
                    yaz.WriteElementString("ftpSifre", txtFtpSifre.Text);

                    yaz.WriteEndElement();
                    yaz.Close();
                    MessageBox.Show("Kaydetme işleminiz başarıyla gerçekleşmiştir.");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            FtpWebRequest FTP;
            try
            {
                string dizin = "ftp://" + txtHost.Text + "//" + txtFtpDir.Text + "/Gunluk";
                if (!File.Exists(dizin))
                {
                    FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(dizin));
                    FTP.UseBinary = true;
                    FTP.Credentials = new NetworkCredential("test", "1");
                    FTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    FtpWebResponse response1 = (FtpWebResponse)FTP.GetResponse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string dizin = "ftp://" + txtHost.Text + "//" + txtFtpDir.Text + "/Haftalık";
                if (!File.Exists(dizin))
                {
                    FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(dizin));
                    FTP.UseBinary = true;
                    FTP.Credentials = new NetworkCredential("test", "1");
                    FTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    FtpWebResponse response2 = (FtpWebResponse)FTP.GetResponse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string dizin = "ftp://" + txtHost.Text + "//" + txtFtpDir.Text + "/Aylık";
                if (!File.Exists(dizin))
                {
                    FTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(dizin));
                    FTP.UseBinary = true;
                    FTP.Credentials = new NetworkCredential("test", "1");
                    FTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    FtpWebResponse response3 = (FtpWebResponse)FTP.GetResponse();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void lisanslamaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Lisans lisans = new Lisans();
            lisans.ShowDialog();
        }

        private void DemoZamanlayici_Tick(object sender, EventArgs e)
        {

            
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM atasayarsql.bLicance WHERE mail='" + KullanıcıBilgi.MailAdresi + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           
            DateTime today = tc.GetNistTime();
            TimeSpan zamanFarki = today - Convert.ToDateTime(dt.Rows[0][5].ToString());
            int kalansure = demo_suresi - Convert.ToInt32(zamanFarki.TotalDays);
            this.Text = "SqlBackup      " + "Kalan Süre:  " + kalansure.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMailKaydet_Click(object sender, EventArgs e)
        {
          
            string EMAIL_PATTERN = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+.(com|org|net|edu|gov|mil|biz|info|mobi)(.[A-Z]{2})?$";
            Regex regex = new Regex(EMAIL_PATTERN, RegexOptions.IgnoreCase);
            if (txtMail.Text =="")
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız!");
            }
            else
            {
                if (regex.IsMatch(txtMail.Text))
                {
                    try
                    {
                        XmlTextWriter yaz = new XmlTextWriter("MailAdres.xml", System.Text.UTF8Encoding.UTF8);
                        yaz.Formatting = Formatting.Indented;
                        yaz.WriteStartDocument();
                        yaz.WriteStartElement("Mail");
                        yaz.WriteElementString("mailAdres", txtMail.Text);
                        yaz.WriteEndElement();
                        yaz.Close();
                        MessageBox.Show("Mail adresiniz başarıyla kaydedilmiştir.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen mail formatına uygun bir mail adresi giriniz!");
                }
               
            }
        }
        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.ShowDialog();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
            KullanıcıBilgi.MailAdresi = "";
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gizeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
