namespace DandR
{
    partial class Yonetici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetici));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblYetki = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblMesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsKasiyerSatislar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsKasiyer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUrunSorgulama = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCikis = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKasaTutari = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblKullanici,
            this.toolStripStatusLabel1,
            this.slblYetki,
            this.toolStripStatusLabel3,
            this.slblMesaj,
            this.slblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 460);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 37);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblKullanici
            // 
            this.slblKullanici.Name = "slblKullanici";
            this.slblKullanici.Size = new System.Drawing.Size(70, 32);
            this.slblKullanici.Text = "Umut Parlar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 32);
            this.toolStripStatusLabel1.Text = "(";
            // 
            // slblYetki
            // 
            this.slblYetki.Name = "slblYetki";
            this.slblYetki.Size = new System.Drawing.Size(0, 32);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 32);
            this.toolStripStatusLabel3.Text = ")";
            // 
            // slblMesaj
            // 
            this.slblMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slblMesaj.Image = ((System.Drawing.Image)(resources.GetObject("slblMesaj.Image")));
            this.slblMesaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.slblMesaj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.slblMesaj.Name = "slblMesaj";
            this.slblMesaj.Size = new System.Drawing.Size(714, 32);
            this.slblMesaj.Spring = true;
            this.slblMesaj.Text = "Günün Notu";
            this.slblMesaj.Click += new System.EventHandler(this.slblMesaj_Click);
            // 
            // slblDate
            // 
            this.slblDate.Name = "slblDate";
            this.slblDate.Size = new System.Drawing.Size(79, 32);
            this.slblDate.Text = "28 Nisan 2016";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsKasiyerSatislar,
            this.toolStripSeparator2,
            this.tsKasiyer,
            this.toolStripSeparator1,
            this.tsUrunSorgulama,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator12,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.tsCikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 55);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsKasiyerSatislar
            // 
            this.tsKasiyerSatislar.BackColor = System.Drawing.Color.Orange;
            this.tsKasiyerSatislar.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsKasiyerSatislar.Image = ((System.Drawing.Image)(resources.GetObject("tsKasiyerSatislar.Image")));
            this.tsKasiyerSatislar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsKasiyerSatislar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKasiyerSatislar.Name = "tsKasiyerSatislar";
            this.tsKasiyerSatislar.Size = new System.Drawing.Size(171, 52);
            this.tsKasiyerSatislar.Text = "Firma Ödeme";
            this.tsKasiyerSatislar.Click += new System.EventHandler(this.tsKasiyerSatislar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // tsKasiyer
            // 
            this.tsKasiyer.BackColor = System.Drawing.Color.GreenYellow;
            this.tsKasiyer.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsKasiyer.Image = ((System.Drawing.Image)(resources.GetObject("tsKasiyer.Image")));
            this.tsKasiyer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsKasiyer.Name = "tsKasiyer";
            this.tsKasiyer.Size = new System.Drawing.Size(96, 52);
            this.tsKasiyer.Text = "Kasiyer";
            this.tsKasiyer.Click += new System.EventHandler(this.tsKasiyer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // tsUrunSorgulama
            // 
            this.tsUrunSorgulama.BackColor = System.Drawing.Color.DarkGray;
            this.tsUrunSorgulama.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsUrunSorgulama.Image = ((System.Drawing.Image)(resources.GetObject("tsUrunSorgulama.Image")));
            this.tsUrunSorgulama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUrunSorgulama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUrunSorgulama.Name = "tsUrunSorgulama";
            this.tsUrunSorgulama.Size = new System.Drawing.Size(160, 52);
            this.tsUrunSorgulama.Text = "Kasiyer Satış";
            this.tsUrunSorgulama.Click += new System.EventHandler(this.tsUrunSorgulama_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Blue;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(188, 52);
            this.toolStripButton1.Text = "Kasa İşlemleri";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Tomato;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(160, 52);
            this.toolStripButton2.Text = "Raporlama";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // tsCikis
            // 
            this.tsCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsCikis.Image = ((System.Drawing.Image)(resources.GetObject("tsCikis.Image")));
            this.tsCikis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCikis.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsCikis.Name = "tsCikis";
            this.tsCikis.Size = new System.Drawing.Size(74, 52);
            this.tsCikis.Text = "Çıkış";
            this.tsCikis.Click += new System.EventHandler(this.tsCikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SlateGray;
            this.pictureBox1.Image = global::DandR.Properties.Resources.strongbox;
            this.pictureBox1.Location = new System.Drawing.Point(44, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // lblKasaTutari
            // 
            this.lblKasaTutari.AutoSize = true;
            this.lblKasaTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasaTutari.Location = new System.Drawing.Point(110, 220);
            this.lblKasaTutari.Name = "lblKasaTutari";
            this.lblKasaTutari.Size = new System.Drawing.Size(21, 24);
            this.lblKasaTutari.TabIndex = 13;
            this.lblKasaTutari.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.lblKasaTutari);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(439, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 255);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Kasa";
            // 
            // Yonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Yonetici";
            this.Text = "Yonetici";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Yonetici_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Yonetici_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblKullanici;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblYetki;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel slblMesaj;
        private System.Windows.Forms.ToolStripStatusLabel slblDate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsKasiyerSatislar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsKasiyer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsCikis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsUrunSorgulama;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblKasaTutari;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}