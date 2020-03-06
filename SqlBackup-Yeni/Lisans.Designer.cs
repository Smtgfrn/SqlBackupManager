namespace SqlBackup_Yeni
{
    partial class Lisans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lisans));
            this.label3 = new System.Windows.Forms.Label();
            this.btnLisans = new System.Windows.Forms.Button();
            this.txtLisans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAktivasyon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "PROGRAM AKTİVASYONU";
            // 
            // btnLisans
            // 
            this.btnLisans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLisans.Image = ((System.Drawing.Image)(resources.GetObject("btnLisans.Image")));
            this.btnLisans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLisans.Location = new System.Drawing.Point(201, 235);
            this.btnLisans.Name = "btnLisans";
            this.btnLisans.Size = new System.Drawing.Size(267, 68);
            this.btnLisans.TabIndex = 10;
            this.btnLisans.Text = "Lisansla";
            this.btnLisans.UseVisualStyleBackColor = true;
            // 
            // txtLisans
            // 
            this.txtLisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLisans.Location = new System.Drawing.Point(148, 186);
            this.txtLisans.Name = "txtLisans";
            this.txtLisans.Size = new System.Drawing.Size(362, 24);
            this.txtLisans.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(34, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lisans Anahtarı";
            // 
            // txtAktivasyon
            // 
            this.txtAktivasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAktivasyon.Location = new System.Drawing.Point(148, 139);
            this.txtAktivasyon.Name = "txtAktivasyon";
            this.txtAktivasyon.Size = new System.Drawing.Size(362, 24);
            this.txtAktivasyon.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aktivasyon Kodu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(507, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Lisans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 345);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLisans);
            this.Controls.Add(this.txtLisans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAktivasyon);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lisans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lisans";
            this.Load += new System.EventHandler(this.Lisans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLisans;
        private System.Windows.Forms.TextBox txtLisans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAktivasyon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}