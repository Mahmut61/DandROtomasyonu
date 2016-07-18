namespace DandR
{
    partial class Urunler
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
            this.lvUrunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtBarkodaGore = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grbStok = new System.Windows.Forms.GroupBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtKritikSeviye = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grbGenel = new System.Windows.Forms.GroupBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.btnYeniTur = new System.Windows.Forms.Button();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunNo = new System.Windows.Forms.TextBox();
            this.txtKategoriNo = new System.Windows.Forms.TextBox();
            this.cbKategoriler = new System.Windows.Forms.ComboBox();
            this.txtKategoriler = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grbKitap = new System.Windows.Forms.GroupBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbOyuncak = new System.Windows.Forms.GroupBox();
            this.txtYasGrubu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbStok.SuspendLayout();
            this.grbGenel.SuspendLayout();
            this.grbKitap.SuspendLayout();
            this.grbOyuncak.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvUrunler
            // 
            this.lvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader12,
            this.columnHeader10,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader11,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader13,
            this.columnHeader14});
            this.lvUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvUrunler.FullRowSelect = true;
            this.lvUrunler.GridLines = true;
            this.lvUrunler.Location = new System.Drawing.Point(480, 71);
            this.lvUrunler.Name = "lvUrunler";
            this.lvUrunler.Size = new System.Drawing.Size(542, 234);
            this.lvUrunler.TabIndex = 53;
            this.lvUrunler.UseCompatibleStateImageBehavior = false;
            this.lvUrunler.View = System.Windows.Forms.View.Details;
            this.lvUrunler.DoubleClick += new System.EventHandler(this.lvUrunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "UrunID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Barkod Numarası";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ad";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 77;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori Ad";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 82;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Açıklama";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 92;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Tur";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Yaş Grubu";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Miktar";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Birim Fiyat";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 68;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kritik Seviye";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 62;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "KategoriID";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 0;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Özet";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Yazar";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 0;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(924, 323);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(97, 40);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(776, 323);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(97, 40);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(628, 323);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(97, 40);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(480, 323);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(97, 40);
            this.btnYeni.TabIndex = 4;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtBarkodaGore
            // 
            this.txtBarkodaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodaGore.Location = new System.Drawing.Point(480, 42);
            this.txtBarkodaGore.Name = "txtBarkodaGore";
            this.txtBarkodaGore.Size = new System.Drawing.Size(237, 23);
            this.txtBarkodaGore.TabIndex = 8;
            this.txtBarkodaGore.TextChanged += new System.EventHandler(this.txtBarkodaGore_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(477, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(240, 20);
            this.label13.TabIndex = 59;
            this.label13.Text = "Barkon Numarasına Göre Arama";
            // 
            // grbStok
            // 
            this.grbStok.Controls.Add(this.txtAlisFiyati);
            this.grbStok.Controls.Add(this.label17);
            this.grbStok.Controls.Add(this.txtBirimFiyat);
            this.grbStok.Controls.Add(this.label16);
            this.grbStok.Controls.Add(this.txtAciklama);
            this.grbStok.Controls.Add(this.txtMiktar);
            this.grbStok.Controls.Add(this.txtKritikSeviye);
            this.grbStok.Controls.Add(this.label8);
            this.grbStok.Controls.Add(this.label5);
            this.grbStok.Controls.Add(this.label7);
            this.grbStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbStok.Location = new System.Drawing.Point(12, 345);
            this.grbStok.Name = "grbStok";
            this.grbStok.Size = new System.Drawing.Size(454, 217);
            this.grbStok.TabIndex = 3;
            this.grbStok.TabStop = false;
            this.grbStok.Text = "Stok Bilgi";
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(241, 108);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(82, 23);
            this.txtBirimFiyat.TabIndex = 2;
            this.txtBirimFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(39, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 67;
            this.label16.Text = "Birim Fiyat:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(241, 19);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(164, 50);
            this.txtAciklama.TabIndex = 0;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(241, 77);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(82, 23);
            this.txtMiktar.TabIndex = 1;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKritikSeviye
            // 
            this.txtKritikSeviye.Location = new System.Drawing.Point(241, 185);
            this.txtKritikSeviye.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKritikSeviye.Name = "txtKritikSeviye";
            this.txtKritikSeviye.Size = new System.Drawing.Size(82, 23);
            this.txtKritikSeviye.TabIndex = 3;
            this.txtKritikSeviye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stok(Miktar):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Açıklama:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Kritik Seviye";
            // 
            // grbGenel
            // 
            this.grbGenel.Controls.Add(this.cbTur);
            this.grbGenel.Controls.Add(this.btnYeniTur);
            this.grbGenel.Controls.Add(this.txtTur);
            this.grbGenel.Controls.Add(this.label4);
            this.grbGenel.Controls.Add(this.label11);
            this.grbGenel.Controls.Add(this.txtUrunAdi);
            this.grbGenel.Controls.Add(this.label1);
            this.grbGenel.Controls.Add(this.label12);
            this.grbGenel.Controls.Add(this.txtUrunNo);
            this.grbGenel.Controls.Add(this.txtKategoriNo);
            this.grbGenel.Controls.Add(this.cbKategoriler);
            this.grbGenel.Controls.Add(this.txtKategoriler);
            this.grbGenel.Controls.Add(this.txtBarkodNo);
            this.grbGenel.Controls.Add(this.label3);
            this.grbGenel.Controls.Add(this.label2);
            this.grbGenel.Controls.Add(this.label9);
            this.grbGenel.Controls.Add(this.label10);
            this.grbGenel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbGenel.Location = new System.Drawing.Point(12, 12);
            this.grbGenel.Name = "grbGenel";
            this.grbGenel.Size = new System.Drawing.Size(454, 159);
            this.grbGenel.TabIndex = 0;
            this.grbGenel.TabStop = false;
            this.grbGenel.Text = "Genel Bilgi";
            // 
            // cbTur
            // 
            this.cbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTur.DropDownWidth = 100;
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(380, 117);
            this.cbTur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(26, 24);
            this.cbTur.TabIndex = 70;
            this.cbTur.SelectedIndexChanged += new System.EventHandler(this.cbTur_SelectedIndexChanged);
            // 
            // btnYeniTur
            // 
            this.btnYeniTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniTur.Location = new System.Drawing.Point(3, 114);
            this.btnYeniTur.Name = "btnYeniTur";
            this.btnYeniTur.Size = new System.Drawing.Size(70, 31);
            this.btnYeniTur.TabIndex = 3;
            this.btnYeniTur.Text = "Yeni Tür";
            this.btnYeniTur.UseVisualStyleBackColor = true;
            this.btnYeniTur.Click += new System.EventHandler(this.btnYeniTur_Click);
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(241, 117);
            this.txtTur.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTur.Name = "txtTur";
            this.txtTur.ReadOnly = true;
            this.txtTur.Size = new System.Drawing.Size(139, 23);
            this.txtTur.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Türü:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(425, 120);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "*";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(241, 86);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(164, 23);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Urun Adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(425, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "*";
            // 
            // txtUrunNo
            // 
            this.txtUrunNo.Location = new System.Drawing.Point(5, 87);
            this.txtUrunNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUrunNo.Name = "txtUrunNo";
            this.txtUrunNo.ReadOnly = true;
            this.txtUrunNo.Size = new System.Drawing.Size(21, 23);
            this.txtUrunNo.TabIndex = 29;
            // 
            // txtKategoriNo
            // 
            this.txtKategoriNo.Location = new System.Drawing.Point(5, 28);
            this.txtKategoriNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKategoriNo.Name = "txtKategoriNo";
            this.txtKategoriNo.ReadOnly = true;
            this.txtKategoriNo.Size = new System.Drawing.Size(21, 23);
            this.txtKategoriNo.TabIndex = 30;
            // 
            // cbKategoriler
            // 
            this.cbKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriler.DropDownWidth = 100;
            this.cbKategoriler.FormattingEnabled = true;
            this.cbKategoriler.Location = new System.Drawing.Point(380, 24);
            this.cbKategoriler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbKategoriler.Name = "cbKategoriler";
            this.cbKategoriler.Size = new System.Drawing.Size(26, 24);
            this.cbKategoriler.TabIndex = 28;
            this.cbKategoriler.SelectedIndexChanged += new System.EventHandler(this.cbKategoriler_SelectedIndexChanged);
            // 
            // txtKategoriler
            // 
            this.txtKategoriler.Location = new System.Drawing.Point(241, 24);
            this.txtKategoriler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKategoriler.Name = "txtKategoriler";
            this.txtKategoriler.ReadOnly = true;
            this.txtKategoriler.Size = new System.Drawing.Size(139, 23);
            this.txtKategoriler.TabIndex = 22;
            this.txtKategoriler.TextChanged += new System.EventHandler(this.txtKategoriler_TextChanged);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(241, 55);
            this.txtBarkodNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(164, 23);
            this.txtBarkodNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Urun Türü:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Barkod Numarası:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(425, 65);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(425, 28);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "*";
            // 
            // grbKitap
            // 
            this.grbKitap.Controls.Add(this.txtOzet);
            this.grbKitap.Controls.Add(this.label14);
            this.grbKitap.Controls.Add(this.txtYazar);
            this.grbKitap.Controls.Add(this.label6);
            this.grbKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbKitap.Location = new System.Drawing.Point(12, 177);
            this.grbKitap.Name = "grbKitap";
            this.grbKitap.Size = new System.Drawing.Size(454, 95);
            this.grbKitap.TabIndex = 1;
            this.grbKitap.TabStop = false;
            this.grbKitap.Text = "Kitap";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(241, 45);
            this.txtOzet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(167, 23);
            this.txtOzet.TabIndex = 1;
            this.txtOzet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(35, 51);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 17);
            this.label14.TabIndex = 19;
            this.label14.Text = "Özet:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(241, 14);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(167, 23);
            this.txtYazar.TabIndex = 0;
            this.txtYazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Yazar:";
            // 
            // grbOyuncak
            // 
            this.grbOyuncak.Controls.Add(this.txtYasGrubu);
            this.grbOyuncak.Controls.Add(this.label15);
            this.grbOyuncak.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbOyuncak.Location = new System.Drawing.Point(12, 278);
            this.grbOyuncak.Name = "grbOyuncak";
            this.grbOyuncak.Size = new System.Drawing.Size(454, 62);
            this.grbOyuncak.TabIndex = 2;
            this.grbOyuncak.TabStop = false;
            this.grbOyuncak.Text = "Oyuncak ";
            // 
            // txtYasGrubu
            // 
            this.txtYasGrubu.Location = new System.Drawing.Point(241, 22);
            this.txtYasGrubu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtYasGrubu.Name = "txtYasGrubu";
            this.txtYasGrubu.Size = new System.Drawing.Size(165, 23);
            this.txtYasGrubu.TabIndex = 0;
            this.txtYasGrubu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 65;
            this.label15.Text = "Yaş Grubu";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(241, 146);
            this.txtAlisFiyati.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(82, 23);
            this.txtAlisFiyati.TabIndex = 68;
            this.txtAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(39, 149);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 17);
            this.label17.TabIndex = 69;
            this.label17.Text = "Alış Fiyat:";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Alış Fiyatı";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 591);
            this.Controls.Add(this.grbOyuncak);
            this.Controls.Add(this.grbKitap);
            this.Controls.Add(this.grbGenel);
            this.Controls.Add(this.grbStok);
            this.Controls.Add(this.txtBarkodaGore);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.grbStok.ResumeLayout(false);
            this.grbStok.PerformLayout();
            this.grbGenel.ResumeLayout(false);
            this.grbGenel.PerformLayout();
            this.grbKitap.ResumeLayout(false);
            this.grbKitap.PerformLayout();
            this.grbOyuncak.ResumeLayout(false);
            this.grbOyuncak.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUrunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtBarkodaGore;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox grbStok;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtKritikSeviye;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbGenel;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Button btnYeniTur;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUrunNo;
        private System.Windows.Forms.TextBox txtKategoriNo;
        private System.Windows.Forms.ComboBox cbKategoriler;
        private System.Windows.Forms.TextBox txtKategoriler;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grbKitap;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbOyuncak;
        private System.Windows.Forms.TextBox txtYasGrubu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}