namespace SqlBackup_Yeni
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFtpKaydet = new System.Windows.Forms.Button();
            this.txtFtpSifre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFtpKAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFtpDir = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chFtpAyar = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnDriveBaglan = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMailKaydet = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKonum = new System.Windows.Forms.TextBox();
            this.btnZamanlayiciKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clbGunluk = new System.Windows.Forms.CheckedListBox();
            this.clbDatabase = new System.Windows.Forms.CheckedListBox();
            this.chAylik = new System.Windows.Forms.CheckBox();
            this.btnKonumSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYedekle = new System.Windows.Forms.Button();
            this.chZamanlayiciAyar = new System.Windows.Forms.CheckBox();
            this.clbHaftalik = new System.Windows.Forms.CheckedListBox();
            this.chHaftalik = new System.Windows.Forms.CheckBox();
            this.clbAylik = new System.Windows.Forms.CheckedListBox();
            this.chGunluk = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBaglanKes = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lisanslamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GunlukZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.HaftalikZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.AylikZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.DemoZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gizeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnFtpKaydet);
            this.groupBox2.Controls.Add(this.txtFtpSifre);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtFtpKAdi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFtpDir);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtHost);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chFtpAyar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 574);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(683, 262);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ftp Ayar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(384, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Örn : Deneme";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(367, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Örn : 192.168.1.1";
            // 
            // btnFtpKaydet
            // 
            this.btnFtpKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFtpKaydet.Enabled = false;
            this.btnFtpKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFtpKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFtpKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnFtpKaydet.Image")));
            this.btnFtpKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFtpKaydet.Location = new System.Drawing.Point(510, 107);
            this.btnFtpKaydet.Name = "btnFtpKaydet";
            this.btnFtpKaydet.Size = new System.Drawing.Size(142, 75);
            this.btnFtpKaydet.TabIndex = 20;
            this.btnFtpKaydet.Text = "Kaydet";
            this.btnFtpKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFtpKaydet.UseVisualStyleBackColor = true;
            this.btnFtpKaydet.Click += new System.EventHandler(this.btnFtpKaydet_Click);
            // 
            // txtFtpSifre
            // 
            this.txtFtpSifre.Enabled = false;
            this.txtFtpSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFtpSifre.Location = new System.Drawing.Point(126, 207);
            this.txtFtpSifre.Name = "txtFtpSifre";
            this.txtFtpSifre.Size = new System.Drawing.Size(355, 24);
            this.txtFtpSifre.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(80, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Şifre";
            // 
            // txtFtpKAdi
            // 
            this.txtFtpKAdi.Enabled = false;
            this.txtFtpKAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFtpKAdi.Location = new System.Drawing.Point(126, 161);
            this.txtFtpKAdi.Name = "txtFtpKAdi";
            this.txtFtpKAdi.Size = new System.Drawing.Size(355, 24);
            this.txtFtpKAdi.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(32, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 18);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kullanıcı Adı";
            // 
            // txtFtpDir
            // 
            this.txtFtpDir.Enabled = false;
            this.txtFtpDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFtpDir.Location = new System.Drawing.Point(126, 115);
            this.txtFtpDir.Name = "txtFtpDir";
            this.txtFtpDir.Size = new System.Drawing.Size(357, 24);
            this.txtFtpDir.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Klasör İsmi";
            // 
            // txtHost
            // 
            this.txtHost.Enabled = false;
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHost.Location = new System.Drawing.Point(126, 69);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(357, 24);
            this.txtHost.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(35, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Host Adresi";
            // 
            // chFtpAyar
            // 
            this.chFtpAyar.AutoSize = true;
            this.chFtpAyar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chFtpAyar.Location = new System.Drawing.Point(35, 33);
            this.chFtpAyar.Name = "chFtpAyar";
            this.chFtpAyar.Size = new System.Drawing.Size(186, 22);
            this.chFtpAyar.TabIndex = 23;
            this.chFtpAyar.Text = "Ftp Sunucusuna Kaydet";
            this.chFtpAyar.UseVisualStyleBackColor = true;
            this.chFtpAyar.CheckedChanged += new System.EventHandler(this.chFtpAyar_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnDriveBaglan);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.Location = new System.Drawing.Point(13, 273);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 140);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Google Drive";
            // 
            // btnDriveBaglan
            // 
            this.btnDriveBaglan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDriveBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDriveBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnDriveBaglan.Image")));
            this.btnDriveBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDriveBaglan.Location = new System.Drawing.Point(125, 54);
            this.btnDriveBaglan.Name = "btnDriveBaglan";
            this.btnDriveBaglan.Size = new System.Drawing.Size(195, 55);
            this.btnDriveBaglan.TabIndex = 20;
            this.btnDriveBaglan.Text = "Bağlan";
            this.btnDriveBaglan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDriveBaglan.UseVisualStyleBackColor = true;
            this.btnDriveBaglan.Click += new System.EventHandler(this.btnDriveBaglan_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "google-drive.png");
            this.ımageList1.Images.SetKeyName(1, "data.png");
            this.ımageList1.Images.SetKeyName(2, "Folder-icon.png");
            this.ımageList1.Images.SetKeyName(3, "enter.png");
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnMailKaydet);
            this.groupBox4.Controls.Add(this.txtMail);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(13, 419);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 149);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mail";
            // 
            // btnMailKaydet
            // 
            this.btnMailKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMailKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMailKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnMailKaydet.Image")));
            this.btnMailKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMailKaydet.Location = new System.Drawing.Point(456, 59);
            this.btnMailKaydet.Name = "btnMailKaydet";
            this.btnMailKaydet.Size = new System.Drawing.Size(195, 55);
            this.btnMailKaydet.TabIndex = 9;
            this.btnMailKaydet.Text = "Mail Kaydet";
            this.btnMailKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMailKaydet.UseVisualStyleBackColor = true;
            this.btnMailKaydet.Click += new System.EventHandler(this.btnMailKaydet_Click);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(17, 87);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(395, 27);
            this.txtMail.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bilgilendirilmek istediğiniz mail adresini giriniz\r\n";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtKonum);
            this.groupBox3.Controls.Add(this.btnZamanlayiciKaydet);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.clbGunluk);
            this.groupBox3.Controls.Add(this.clbDatabase);
            this.groupBox3.Controls.Add(this.chAylik);
            this.groupBox3.Controls.Add(this.btnKonumSec);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnYedekle);
            this.groupBox3.Controls.Add(this.chZamanlayiciAyar);
            this.groupBox3.Controls.Add(this.clbHaftalik);
            this.groupBox3.Controls.Add(this.chHaftalik);
            this.groupBox3.Controls.Add(this.clbAylik);
            this.groupBox3.Controls.Add(this.chGunluk);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(701, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(653, 693);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yedekleme";
            // 
            // txtKonum
            // 
            this.txtKonum.Enabled = false;
            this.txtKonum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKonum.Location = new System.Drawing.Point(18, 57);
            this.txtKonum.Name = "txtKonum";
            this.txtKonum.Size = new System.Drawing.Size(468, 27);
            this.txtKonum.TabIndex = 3;
            this.txtKonum.Text = "C:\\yedek";
            // 
            // btnZamanlayiciKaydet
            // 
            this.btnZamanlayiciKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZamanlayiciKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZamanlayiciKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnZamanlayiciKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnZamanlayiciKaydet.Image")));
            this.btnZamanlayiciKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZamanlayiciKaydet.Location = new System.Drawing.Point(468, 623);
            this.btnZamanlayiciKaydet.Name = "btnZamanlayiciKaydet";
            this.btnZamanlayiciKaydet.Size = new System.Drawing.Size(151, 55);
            this.btnZamanlayiciKaydet.TabIndex = 19;
            this.btnZamanlayiciKaydet.Text = "Kaydet";
            this.btnZamanlayiciKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZamanlayiciKaydet.UseVisualStyleBackColor = true;
            this.btnZamanlayiciKaydet.Visible = false;
            this.btnZamanlayiciKaydet.Click += new System.EventHandler(this.btnZamanlayiciKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dosya Konumu Seçiniz";
            // 
            // clbGunluk
            // 
            this.clbGunluk.BackColor = System.Drawing.Color.White;
            this.clbGunluk.FormattingEnabled = true;
            this.clbGunluk.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.clbGunluk.Location = new System.Drawing.Point(21, 402);
            this.clbGunluk.Name = "clbGunluk";
            this.clbGunluk.Size = new System.Drawing.Size(188, 202);
            this.clbGunluk.TabIndex = 13;
            this.clbGunluk.Visible = false;
            // 
            // clbDatabase
            // 
            this.clbDatabase.BackColor = System.Drawing.Color.White;
            this.clbDatabase.FormattingEnabled = true;
            this.clbDatabase.Location = new System.Drawing.Point(21, 119);
            this.clbDatabase.Name = "clbDatabase";
            this.clbDatabase.Size = new System.Drawing.Size(213, 180);
            this.clbDatabase.TabIndex = 8;
            // 
            // chAylik
            // 
            this.chAylik.AutoSize = true;
            this.chAylik.Location = new System.Drawing.Point(431, 367);
            this.chAylik.Name = "chAylik";
            this.chAylik.Size = new System.Drawing.Size(66, 24);
            this.chAylik.TabIndex = 18;
            this.chAylik.Text = "Aylık";
            this.chAylik.UseVisualStyleBackColor = true;
            this.chAylik.Visible = false;
            this.chAylik.CheckedChanged += new System.EventHandler(this.chAylik_CheckedChanged);
            // 
            // btnKonumSec
            // 
            this.btnKonumSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKonumSec.Enabled = false;
            this.btnKonumSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonumSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonumSec.Image = ((System.Drawing.Image)(resources.GetObject("btnKonumSec.Image")));
            this.btnKonumSec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKonumSec.Location = new System.Drawing.Point(511, 32);
            this.btnKonumSec.Name = "btnKonumSec";
            this.btnKonumSec.Size = new System.Drawing.Size(113, 51);
            this.btnKonumSec.TabIndex = 5;
            this.btnKonumSec.Text = "Seç";
            this.btnKonumSec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKonumSec.UseVisualStyleBackColor = true;
            this.btnKonumSec.Click += new System.EventHandler(this.btnKonumSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(260, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yedeklemek İstediğiniz Veritabanlarını Seçiniz";
            // 
            // btnYedekle
            // 
            this.btnYedekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekle.Enabled = false;
            this.btnYedekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYedekle.Image = ((System.Drawing.Image)(resources.GetObject("btnYedekle.Image")));
            this.btnYedekle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYedekle.Location = new System.Drawing.Point(468, 158);
            this.btnYedekle.Name = "btnYedekle";
            this.btnYedekle.Size = new System.Drawing.Size(151, 55);
            this.btnYedekle.TabIndex = 2;
            this.btnYedekle.Text = "Yedekle";
            this.btnYedekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYedekle.UseVisualStyleBackColor = true;
            this.btnYedekle.Click += new System.EventHandler(this.btnYedekle_Click);
            // 
            // chZamanlayiciAyar
            // 
            this.chZamanlayiciAyar.AutoSize = true;
            this.chZamanlayiciAyar.Enabled = false;
            this.chZamanlayiciAyar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chZamanlayiciAyar.Location = new System.Drawing.Point(21, 324);
            this.chZamanlayiciAyar.Name = "chZamanlayiciAyar";
            this.chZamanlayiciAyar.Size = new System.Drawing.Size(224, 24);
            this.chZamanlayiciAyar.TabIndex = 12;
            this.chZamanlayiciAyar.Text = "Yedekleme Zamanı Belirle";
            this.chZamanlayiciAyar.UseVisualStyleBackColor = true;
            this.chZamanlayiciAyar.CheckedChanged += new System.EventHandler(this.chZamanlayiciAyar_CheckedChanged);
            // 
            // clbHaftalik
            // 
            this.clbHaftalik.FormattingEnabled = true;
            this.clbHaftalik.Items.AddRange(new object[] {
            "Pazartesi",
            "Salı",
            "Çarşamba",
            "Perşembe",
            "Cuma",
            "Cumartesi",
            "Pazar"});
            this.clbHaftalik.Location = new System.Drawing.Point(225, 402);
            this.clbHaftalik.Name = "clbHaftalik";
            this.clbHaftalik.Size = new System.Drawing.Size(188, 202);
            this.clbHaftalik.TabIndex = 14;
            this.clbHaftalik.Visible = false;
            // 
            // chHaftalik
            // 
            this.chHaftalik.AutoSize = true;
            this.chHaftalik.Location = new System.Drawing.Point(225, 367);
            this.chHaftalik.Name = "chHaftalik";
            this.chHaftalik.Size = new System.Drawing.Size(88, 24);
            this.chHaftalik.TabIndex = 17;
            this.chHaftalik.Text = "Haftalık";
            this.chHaftalik.UseVisualStyleBackColor = true;
            this.chHaftalik.Visible = false;
            this.chHaftalik.CheckedChanged += new System.EventHandler(this.chHaftalik_CheckedChanged);
            // 
            // clbAylik
            // 
            this.clbAylik.FormattingEnabled = true;
            this.clbAylik.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.clbAylik.Location = new System.Drawing.Point(431, 402);
            this.clbAylik.Name = "clbAylik";
            this.clbAylik.Size = new System.Drawing.Size(188, 202);
            this.clbAylik.TabIndex = 15;
            this.clbAylik.Visible = false;
            // 
            // chGunluk
            // 
            this.chGunluk.AutoSize = true;
            this.chGunluk.Location = new System.Drawing.Point(21, 367);
            this.chGunluk.Name = "chGunluk";
            this.chGunluk.Size = new System.Drawing.Size(83, 24);
            this.chGunluk.TabIndex = 16;
            this.chGunluk.Text = "Gunluk";
            this.chGunluk.UseVisualStyleBackColor = true;
            this.chGunluk.Visible = false;
            this.chGunluk.CheckedChanged += new System.EventHandler(this.chGunluk_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBaglanKes);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullanici);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnBaglan);
            this.groupBox1.Controls.Add(this.txtDataSource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 232);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Bağlantısı";
            // 
            // btnBaglanKes
            // 
            this.btnBaglanKes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaglanKes.Enabled = false;
            this.btnBaglanKes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglanKes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglanKes.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglanKes.Image")));
            this.btnBaglanKes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaglanKes.Location = new System.Drawing.Point(425, 140);
            this.btnBaglanKes.Name = "btnBaglanKes";
            this.btnBaglanKes.Size = new System.Drawing.Size(214, 55);
            this.btnBaglanKes.TabIndex = 7;
            this.btnBaglanKes.Text = "Bağlantıyı Kes";
            this.btnBaglanKes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaglanKes.UseVisualStyleBackColor = true;
            this.btnBaglanKes.Click += new System.EventHandler(this.btnBaglanKes_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(22, 186);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(365, 27);
            this.txtSifre.TabIndex = 6;
            this.txtSifre.Text = "bkareeksi3ac";
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(22, 129);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(365, 27);
            this.txtKullanici.TabIndex = 5;
            this.txtKullanici.Text = "sa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Image = ((System.Drawing.Image)(resources.GetObject("btnBaglan.Image")));
            this.btnBaglan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaglan.Location = new System.Drawing.Point(425, 71);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(214, 55);
            this.btnBaglan.TabIndex = 2;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDataSource.Location = new System.Drawing.Point(22, 57);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(365, 27);
            this.txtDataSource.TabIndex = 1;
            this.txtDataSource.Text = "DESKTOP-57A1L0H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data Source";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lisanslamaToolStripMenuItem,
            this.hakkındaToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lisanslamaToolStripMenuItem
            // 
            this.lisanslamaToolStripMenuItem.Name = "lisanslamaToolStripMenuItem";
            this.lisanslamaToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.lisanslamaToolStripMenuItem.Text = "Lisanslama";
            this.lisanslamaToolStripMenuItem.Click += new System.EventHandler(this.lisanslamaToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkındaToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // GunlukZamanlayici
            // 
            this.GunlukZamanlayici.Tick += new System.EventHandler(this.GunlukZamanlayici_Tick);
            // 
            // HaftalikZamanlayici
            // 
            this.HaftalikZamanlayici.Tick += new System.EventHandler(this.HaftalikZamanlayici_Tick);
            // 
            // AylikZamanlayici
            // 
            this.AylikZamanlayici.Tick += new System.EventHandler(this.AylikZamanlayici_Tick);
            // 
            // DemoZamanlayici
            // 
            this.DemoZamanlayici.Tick += new System.EventHandler(this.DemoZamanlayici_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(635, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Veritabanı Yedekleme";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gosterToolStripMenuItem,
            this.gizeleToolStripMenuItem,
            this.kapatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 76);
            // 
            // gosterToolStripMenuItem
            // 
            this.gosterToolStripMenuItem.Name = "gosterToolStripMenuItem";
            this.gosterToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.gosterToolStripMenuItem.Text = "Goster";
            this.gosterToolStripMenuItem.Click += new System.EventHandler(this.gosterToolStripMenuItem_Click);
            // 
            // gizeleToolStripMenuItem
            // 
            this.gizeleToolStripMenuItem.Name = "gizeleToolStripMenuItem";
            this.gizeleToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.gizeleToolStripMenuItem.Text = "Gizle";
            this.gizeleToolStripMenuItem.Click += new System.EventHandler(this.gizeleToolStripMenuItem_Click);
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 844);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SqlBackup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnFtpKaydet;
        private System.Windows.Forms.TextBox txtFtpSifre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtFtpKAdi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFtpDir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chFtpAyar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDriveBaglan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKonum;
        private System.Windows.Forms.Button btnZamanlayiciKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbGunluk;
        private System.Windows.Forms.CheckedListBox clbDatabase;
        private System.Windows.Forms.CheckBox chAylik;
        private System.Windows.Forms.Button btnKonumSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYedekle;
        private System.Windows.Forms.CheckBox chZamanlayiciAyar;
        private System.Windows.Forms.CheckedListBox clbHaftalik;
        private System.Windows.Forms.CheckBox chHaftalik;
        private System.Windows.Forms.CheckedListBox clbAylik;
        private System.Windows.Forms.CheckBox chGunluk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaglanKes;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lisanslamaToolStripMenuItem;
        private System.Windows.Forms.Timer GunlukZamanlayici;
        private System.Windows.Forms.Timer HaftalikZamanlayici;
        private System.Windows.Forms.Timer AylikZamanlayici;
        private System.Windows.Forms.Timer DemoZamanlayici;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnMailKaydet;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gizeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
    }
}

