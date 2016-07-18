namespace DandR
{
    partial class FirmaOdeme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvFirmalarOdeme = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtOdemeTutari = new System.Windows.Forms.TextBox();
            this.btnOde = new System.Windows.Forms.Button();
            this.txtFirmaNo = new System.Windows.Forms.TextBox();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtToplamBakiye = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Controls.Add(this.lvFirmalarOdeme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(339, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(624, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firmalar";
            // 
            // lvFirmalarOdeme
            // 
            this.lvFirmalarOdeme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvFirmalarOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvFirmalarOdeme.FullRowSelect = true;
            this.lvFirmalarOdeme.GridLines = true;
            this.lvFirmalarOdeme.Location = new System.Drawing.Point(17, 26);
            this.lvFirmalarOdeme.Margin = new System.Windows.Forms.Padding(4);
            this.lvFirmalarOdeme.Name = "lvFirmalarOdeme";
            this.lvFirmalarOdeme.Size = new System.Drawing.Size(597, 196);
            this.lvFirmalarOdeme.TabIndex = 168;
            this.lvFirmalarOdeme.UseCompatibleStateImageBehavior = false;
            this.lvFirmalarOdeme.View = System.Windows.Forms.View.Details;
            this.lvFirmalarOdeme.DoubleClick += new System.EventHandler(this.lvFirmalarOdeme_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 28;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ünvan";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telefon";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Toplam Bakiye";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 120;
            // 
            // txtOdemeTutari
            // 
            this.txtOdemeTutari.Location = new System.Drawing.Point(152, 248);
            this.txtOdemeTutari.Margin = new System.Windows.Forms.Padding(4);
            this.txtOdemeTutari.Name = "txtOdemeTutari";
            this.txtOdemeTutari.ReadOnly = true;
            this.txtOdemeTutari.Size = new System.Drawing.Size(148, 23);
            this.txtOdemeTutari.TabIndex = 2;
            // 
            // btnOde
            // 
            this.btnOde.Enabled = false;
            this.btnOde.Location = new System.Drawing.Point(181, 290);
            this.btnOde.Margin = new System.Windows.Forms.Padding(4);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(84, 28);
            this.btnOde.TabIndex = 3;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // txtFirmaNo
            // 
            this.txtFirmaNo.Location = new System.Drawing.Point(311, 144);
            this.txtFirmaNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirmaNo.Name = "txtFirmaNo";
            this.txtFirmaNo.ReadOnly = true;
            this.txtFirmaNo.Size = new System.Drawing.Size(19, 23);
            this.txtFirmaNo.TabIndex = 2;
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(152, 144);
            this.txtUnvan.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(148, 23);
            this.txtUnvan.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(152, 176);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(148, 23);
            this.txtTelefon.TabIndex = 2;
            // 
            // txtToplamBakiye
            // 
            this.txtToplamBakiye.Location = new System.Drawing.Point(152, 208);
            this.txtToplamBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtToplamBakiye.Name = "txtToplamBakiye";
            this.txtToplamBakiye.Size = new System.Drawing.Size(148, 23);
            this.txtToplamBakiye.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ünvan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam Bakiye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tarih";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(152, 95);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(148, 23);
            this.txtTarih.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ödenecek Tutar";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.IndianRed;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKapat.FlatAppearance.BorderSize = 3;
            this.btnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(934, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(52, 29);
            this.btnKapat.TabIndex = 69;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FirmaOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(989, 393);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.txtToplamBakiye);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.txtFirmaNo);
            this.Controls.Add(this.txtOdemeTutari);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FirmaOdeme";
            this.Text = "FirmaOdeme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FirmaOdeme_FormClosed);
            this.Load += new System.EventHandler(this.FirmaOdeme_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvFirmalarOdeme;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtOdemeTutari;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.TextBox txtFirmaNo;
        private System.Windows.Forms.TextBox txtUnvan;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtToplamBakiye;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnKapat;
    }
}