namespace DandR
{
    partial class Kasiyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasiyer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.slblKullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblYetki = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblMesaj = new System.Windows.Forms.ToolStripStatusLabel();
            this.slblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsMusteri = new System.Windows.Forms.ToolStripButton();
            this.tsMusteriSorgulama = new System.Windows.Forms.ToolStripButton();
            this.tsUrun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUrunSorgulama = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.tsUrunSatis = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsCikis = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblKullanici,
            this.toolStripStatusLabel1,
            this.slblYetki,
            this.toolStripStatusLabel3,
            this.slblMesaj,
            this.slblDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 393);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(956, 37);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // slblKullanici
            // 
            this.slblKullanici.Name = "slblKullanici";
            this.slblKullanici.Size = new System.Drawing.Size(70, 17);
            this.slblKullanici.Text = "Umut Parlar";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "(";
            // 
            // slblYetki
            // 
            this.slblYetki.Name = "slblYetki";
            this.slblYetki.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel3.Text = ")";
            // 
            // slblMesaj
            // 
            this.slblMesaj.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slblMesaj.Image = ((System.Drawing.Image)(resources.GetObject("slblMesaj.Image")));
            this.slblMesaj.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.slblMesaj.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.slblMesaj.Name = "slblMesaj";
            this.slblMesaj.Size = new System.Drawing.Size(746, 32);
            this.slblMesaj.Spring = true;
            this.slblMesaj.Text = "Günün Notu";
            this.slblMesaj.Click += new System.EventHandler(this.slblMesaj_Click);
            // 
            // slblDate
            // 
            this.slblDate.Name = "slblDate";
            this.slblDate.Size = new System.Drawing.Size(79, 17);
            this.slblDate.Text = "28 Nisan 2016";
            // 
            // tsMusteri
            // 
            this.tsMusteri.BackColor = System.Drawing.Color.IndianRed;
            this.tsMusteri.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsMusteri.Image = ((System.Drawing.Image)(resources.GetObject("tsMusteri.Image")));
            this.tsMusteri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMusteri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMusteri.Name = "tsMusteri";
            this.tsMusteri.Size = new System.Drawing.Size(117, 36);
            this.tsMusteri.Text = "Müşteri";
            this.tsMusteri.Click += new System.EventHandler(this.tsMusteri_Click);
            // 
            // tsMusteriSorgulama
            // 
            this.tsMusteriSorgulama.BackColor = System.Drawing.SystemColors.Highlight;
            this.tsMusteriSorgulama.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsMusteriSorgulama.Image = ((System.Drawing.Image)(resources.GetObject("tsMusteriSorgulama.Image")));
            this.tsMusteriSorgulama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsMusteriSorgulama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsMusteriSorgulama.Name = "tsMusteriSorgulama";
            this.tsMusteriSorgulama.Size = new System.Drawing.Size(152, 36);
            this.tsMusteriSorgulama.Text = "Müşteri Bul";
            this.tsMusteriSorgulama.Click += new System.EventHandler(this.tsMusteriSorgulama_Click);
            // 
            // tsUrun
            // 
            this.tsUrun.BackColor = System.Drawing.Color.GreenYellow;
            this.tsUrun.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsUrun.Image = ((System.Drawing.Image)(resources.GetObject("tsUrun.Image")));
            this.tsUrun.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUrun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUrun.Name = "tsUrun";
            this.tsUrun.Size = new System.Drawing.Size(116, 36);
            this.tsUrun.Text = "Ürünler";
            this.tsUrun.Click += new System.EventHandler(this.tsUrun_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 39);
            // 
            // tsUrunSorgulama
            // 
            this.tsUrunSorgulama.BackColor = System.Drawing.Color.DarkGray;
            this.tsUrunSorgulama.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsUrunSorgulama.Image = ((System.Drawing.Image)(resources.GetObject("tsUrunSorgulama.Image")));
            this.tsUrunSorgulama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUrunSorgulama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUrunSorgulama.Name = "tsUrunSorgulama";
            this.tsUrunSorgulama.Size = new System.Drawing.Size(128, 36);
            this.tsUrunSorgulama.Text = "Ürün Bul";
            this.tsUrunSorgulama.Click += new System.EventHandler(this.tsUrunSorgulama_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 39);
            // 
            // tsUrunSatis
            // 
            this.tsUrunSatis.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tsUrunSatis.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsUrunSatis.Image = ((System.Drawing.Image)(resources.GetObject("tsUrunSatis.Image")));
            this.tsUrunSatis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsUrunSatis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUrunSatis.Name = "tsUrunSatis";
            this.tsUrunSatis.Size = new System.Drawing.Size(141, 36);
            this.tsUrunSatis.Text = "Ürün Satış";
            this.tsUrunSatis.Click += new System.EventHandler(this.tsUrunSatis_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUrunSatis,
            this.toolStripSeparator2,
            this.tsUrun,
            this.toolStripSeparator12,
            this.tsUrunSorgulama,
            this.toolStripSeparator15,
            this.tsMusteri,
            this.toolStripSeparator3,
            this.tsMusteriSorgulama,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripSeparator5,
            this.toolStripSeparator6,
            this.toolStripSeparator1,
            this.tsCikis});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(956, 39);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(165, 36);
            this.toolStripButton1.Text = "Satış Sorgula";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsCikis
            // 
            this.tsCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tsCikis.Image = ((System.Drawing.Image)(resources.GetObject("tsCikis.Image")));
            this.tsCikis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCikis.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.tsCikis.Name = "tsCikis";
            this.tsCikis.Size = new System.Drawing.Size(74, 36);
            this.tsCikis.Text = "Çıkış";
            this.tsCikis.Click += new System.EventHandler(this.tsCikis_Click);
            // 
            // Kasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 430);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Kasiyer";
            this.Text = "Kasiyer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Kasiyer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel slblKullanici;
        private System.Windows.Forms.ToolStripStatusLabel slblMesaj;
        private System.Windows.Forms.ToolStripStatusLabel slblDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel slblYetki;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripButton tsMusteri;
        private System.Windows.Forms.ToolStripButton tsMusteriSorgulama;
        private System.Windows.Forms.ToolStripButton tsUrun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsUrunSorgulama;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripButton tsUrunSatis;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsCikis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}