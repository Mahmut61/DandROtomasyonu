namespace DandR
{
    partial class Notlar
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.dtpNotTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYeniNot = new System.Windows.Forms.Button();
            this.lbNotlar = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(380, 212);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 31);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtNot
            // 
            this.txtNot.Enabled = false;
            this.txtNot.Location = new System.Drawing.Point(351, 117);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(151, 79);
            this.txtNot.TabIndex = 8;
            // 
            // dtpNotTarih
            // 
            this.dtpNotTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNotTarih.Location = new System.Drawing.Point(351, 85);
            this.dtpNotTarih.MaxDate = new System.DateTime(2040, 1, 1, 0, 0, 0, 0);
            this.dtpNotTarih.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpNotTarih.Name = "dtpNotTarih";
            this.dtpNotTarih.Size = new System.Drawing.Size(151, 20);
            this.dtpNotTarih.TabIndex = 7;
            this.dtpNotTarih.ValueChanged += new System.EventHandler(this.dtpNotTarih_ValueChanged);
            // 
            // btnYeniNot
            // 
            this.btnYeniNot.Location = new System.Drawing.Point(380, 24);
            this.btnYeniNot.Name = "btnYeniNot";
            this.btnYeniNot.Size = new System.Drawing.Size(93, 31);
            this.btnYeniNot.TabIndex = 6;
            this.btnYeniNot.Text = "Yeni Not Ekle";
            this.btnYeniNot.UseVisualStyleBackColor = true;
            this.btnYeniNot.Click += new System.EventHandler(this.btnYeniNot_Click);
            // 
            // lbNotlar
            // 
            this.lbNotlar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbNotlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNotlar.FormattingEnabled = true;
            this.lbNotlar.ItemHeight = 15;
            this.lbNotlar.Location = new System.Drawing.Point(12, 21);
            this.lbNotlar.Name = "lbNotlar";
            this.lbNotlar.Size = new System.Drawing.Size(333, 244);
            this.lbNotlar.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kasiyer",
            "Yönetici"});
            this.comboBox1.Location = new System.Drawing.Point(372, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(506, 283);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.dtpNotTarih);
            this.Controls.Add(this.btnYeniNot);
            this.Controls.Add(this.lbNotlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.Notlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.DateTimePicker dtpNotTarih;
        private System.Windows.Forms.Button btnYeniNot;
        public System.Windows.Forms.ListBox lbNotlar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}