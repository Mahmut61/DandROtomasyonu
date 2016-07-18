namespace DandR
{
    partial class KasiyerSatisSorgulama
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
            this.lvKasiyerler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTarih = new System.Windows.Forms.GroupBox();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvKasiyerToplamSatis = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbTarih.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvKasiyerler
            // 
            this.lvKasiyerler.BackColor = System.Drawing.Color.Bisque;
            this.lvKasiyerler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader4});
            this.lvKasiyerler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvKasiyerler.FullRowSelect = true;
            this.lvKasiyerler.GridLines = true;
            this.lvKasiyerler.Location = new System.Drawing.Point(66, 102);
            this.lvKasiyerler.Name = "lvKasiyerler";
            this.lvKasiyerler.Size = new System.Drawing.Size(611, 260);
            this.lvKasiyerler.TabIndex = 7;
            this.lvKasiyerler.UseCompatibleStateImageBehavior = false;
            this.lvKasiyerler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KasiyerHareketID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "KasiyerID";
            this.columnHeader2.Width = 0;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kasiyer Adı";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kasiyer Soyadı";
            this.columnHeader6.Width = 92;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Telefon";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "E-Posta";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Günlük Satış";
            this.columnHeader4.Width = 139;
            // 
            // gbTarih
            // 
            this.gbTarih.Controls.Add(this.dtpIlkTarih);
            this.gbTarih.Controls.Add(this.dtpSonTarih);
            this.gbTarih.Controls.Add(this.label4);
            this.gbTarih.Controls.Add(this.btnGetir);
            this.gbTarih.Controls.Add(this.label6);
            this.gbTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTarih.Location = new System.Drawing.Point(56, 12);
            this.gbTarih.Name = "gbTarih";
            this.gbTarih.Size = new System.Drawing.Size(633, 51);
            this.gbTarih.TabIndex = 8;
            this.gbTarih.TabStop = false;
            this.gbTarih.Text = "Tarih";
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(78, 21);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(152, 22);
            this.dtpIlkTarih.TabIndex = 8;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(322, 20);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(152, 22);
            this.dtpSonTarih.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "İlk Tarih";
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(490, 18);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(131, 23);
            this.btnGetir.TabIndex = 10;
            this.btnGetir.Text = "Satışları Getir";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Son Tarih";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(350, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Toplam Günlük Satis:";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplamTutar.Location = new System.Drawing.Point(536, 380);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(106, 26);
            this.txtToplamTutar.TabIndex = 20;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtToplamTutar.TextChanged += new System.EventHandler(this.txtToplamTutar_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(712, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 29);
            this.button1.TabIndex = 68;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvKasiyerToplamSatis
            // 
            this.lvKasiyerToplamSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lvKasiyerToplamSatis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvKasiyerToplamSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvKasiyerToplamSatis.FullRowSelect = true;
            this.lvKasiyerToplamSatis.GridLines = true;
            this.lvKasiyerToplamSatis.Location = new System.Drawing.Point(66, 432);
            this.lvKasiyerToplamSatis.Name = "lvKasiyerToplamSatis";
            this.lvKasiyerToplamSatis.Size = new System.Drawing.Size(611, 150);
            this.lvKasiyerToplamSatis.TabIndex = 69;
            this.lvKasiyerToplamSatis.UseCompatibleStateImageBehavior = false;
            this.lvKasiyerToplamSatis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Kasiyer Ad";
            this.columnHeader9.Width = 131;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "KasiyerSoyad";
            this.columnHeader10.Width = 147;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ToplamSatis";
            this.columnHeader11.Width = 93;
            // 
            // KasiyerSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(765, 623);
            this.Controls.Add(this.lvKasiyerToplamSatis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.gbTarih);
            this.Controls.Add(this.lvKasiyerler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KasiyerSatisSorgulama";
            this.Text = "KasiyerSatisSorgulama";
            this.Load += new System.EventHandler(this.KasiyerSatisSorgulama_Load);
            this.gbTarih.ResumeLayout(false);
            this.gbTarih.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvKasiyerler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamTutar;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvKasiyerToplamSatis;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;

    }
}