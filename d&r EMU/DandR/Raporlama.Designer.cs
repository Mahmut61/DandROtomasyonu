namespace DandR
{
    partial class Raporlama
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cbSecim = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this._D_RDataSet = new DandR._D_RDataSet();
            this.vw_MusteriRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_MusteriRaporTableAdapter = new DandR._D_RDataSetTableAdapters.vw_MusteriRaporTableAdapter();
            this._D_RDataSet1 = new DandR._D_RDataSet1();
            this.KasaHareketlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KasaHareketlerTableAdapter = new DandR._D_RDataSet1TableAdapters.KasaHareketlerTableAdapter();
            this._D_RDataSet2 = new DandR._D_RDataSet2();
            this.vw_KasiyerRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_KasiyerRaporTableAdapter = new DandR._D_RDataSet2TableAdapters.vw_KasiyerRaporTableAdapter();
            this._D_RDataSet3 = new DandR._D_RDataSet3();
            this.vw_FirmaRaporBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_FirmaRaporTableAdapter = new DandR._D_RDataSet3TableAdapters.vw_FirmaRaporTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_MusteriRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_KasiyerRaporBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_FirmaRaporBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSecim
            // 
            this.cbSecim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSecim.FormattingEnabled = true;
            this.cbSecim.Items.AddRange(new object[] {
            "Kasa",
            "Müşteri",
            "Kasiyer",
            "Firma"});
            this.cbSecim.Location = new System.Drawing.Point(340, 39);
            this.cbSecim.Name = "cbSecim";
            this.cbSecim.Size = new System.Drawing.Size(121, 21);
            this.cbSecim.TabIndex = 0;
            this.cbSecim.SelectedIndexChanged += new System.EventHandler(this.cbSecim_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 82;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vw_MusteriRaporBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DandR.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(71, 11);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(171, 74);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Visible = false;
            // 
            // _D_RDataSet
            // 
            this._D_RDataSet.DataSetName = "_D_RDataSet";
            this._D_RDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_MusteriRaporBindingSource
            // 
            this.vw_MusteriRaporBindingSource.DataMember = "vw_MusteriRapor";
            this.vw_MusteriRaporBindingSource.DataSource = this._D_RDataSet;
            // 
            // vw_MusteriRaporTableAdapter
            // 
            this.vw_MusteriRaporTableAdapter.ClearBeforeFill = true;
            // 
            // _D_RDataSet1
            // 
            this._D_RDataSet1.DataSetName = "_D_RDataSet1";
            this._D_RDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KasaHareketlerBindingSource
            // 
            this.KasaHareketlerBindingSource.DataMember = "KasaHareketler";
            this.KasaHareketlerBindingSource.DataSource = this._D_RDataSet1;
            // 
            // KasaHareketlerTableAdapter
            // 
            this.KasaHareketlerTableAdapter.ClearBeforeFill = true;
            // 
            // _D_RDataSet2
            // 
            this._D_RDataSet2.DataSetName = "_D_RDataSet2";
            this._D_RDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_KasiyerRaporBindingSource
            // 
            this.vw_KasiyerRaporBindingSource.DataMember = "vw_KasiyerRapor";
            this.vw_KasiyerRaporBindingSource.DataSource = this._D_RDataSet2;
            // 
            // vw_KasiyerRaporTableAdapter
            // 
            this.vw_KasiyerRaporTableAdapter.ClearBeforeFill = true;
            // 
            // _D_RDataSet3
            // 
            this._D_RDataSet3.DataSetName = "_D_RDataSet3";
            this._D_RDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vw_FirmaRaporBindingSource
            // 
            this.vw_FirmaRaporBindingSource.DataMember = "vw_FirmaRapor";
            this.vw_FirmaRaporBindingSource.DataSource = this._D_RDataSet3;
            // 
            // vw_FirmaRaporTableAdapter
            // 
            this.vw_FirmaRaporTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.DocumentMapWidth = 68;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.KasaHareketlerBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "DandR.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(491, 11);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(201, 104);
            this.reportViewer2.TabIndex = 2;
            this.reportViewer2.Visible = false;
            // 
            // reportViewer3
            // 
            this.reportViewer3.DocumentMapWidth = 84;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.vw_KasiyerRaporBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "DandR.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(49, 136);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(193, 123);
            this.reportViewer3.TabIndex = 3;
            this.reportViewer3.Visible = false;
            // 
            // reportViewer4
            // 
            this.reportViewer4.DocumentMapWidth = 68;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.vw_FirmaRaporBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "DandR.Report4.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(503, 136);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.Size = new System.Drawing.Size(189, 153);
            this.reportViewer4.TabIndex = 4;
            this.reportViewer4.Visible = false;
            // 
            // Raporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 566);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cbSecim);
            this.Name = "Raporlama";
            this.Text = "Raporlama";
            this.Load += new System.EventHandler(this.Raporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_MusteriRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KasaHareketlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_KasiyerRaporBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._D_RDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vw_FirmaRaporBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSecim;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vw_MusteriRaporBindingSource;
        private _D_RDataSet _D_RDataSet;
        private _D_RDataSetTableAdapters.vw_MusteriRaporTableAdapter vw_MusteriRaporTableAdapter;
        private System.Windows.Forms.BindingSource KasaHareketlerBindingSource;
        private _D_RDataSet1 _D_RDataSet1;
        private _D_RDataSet1TableAdapters.KasaHareketlerTableAdapter KasaHareketlerTableAdapter;
        private System.Windows.Forms.BindingSource vw_KasiyerRaporBindingSource;
        private _D_RDataSet2 _D_RDataSet2;
        private _D_RDataSet2TableAdapters.vw_KasiyerRaporTableAdapter vw_KasiyerRaporTableAdapter;
        private System.Windows.Forms.BindingSource vw_FirmaRaporBindingSource;
        private _D_RDataSet3 _D_RDataSet3;
        private _D_RDataSet3TableAdapters.vw_FirmaRaporTableAdapter vw_FirmaRaporTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
    }
}