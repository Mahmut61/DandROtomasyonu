using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DandR
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void Raporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_D_RDataSet3.vw_FirmaRapor' table. You can move, or remove it, as needed.
            this.vw_FirmaRaporTableAdapter.Fill(this._D_RDataSet3.vw_FirmaRapor);
            // TODO: This line of code loads data into the '_D_RDataSet2.vw_KasiyerRapor' table. You can move, or remove it, as needed.
            this.vw_KasiyerRaporTableAdapter.Fill(this._D_RDataSet2.vw_KasiyerRapor);
            // TODO: This line of code loads data into the '_D_RDataSet1.KasaHareketler' table. You can move, or remove it, as needed.
            this.KasaHareketlerTableAdapter.Fill(this._D_RDataSet1.KasaHareketler);
            // TODO: This line of code loads data into the '_D_RDataSet.vw_MusteriRapor' table. You can move, or remove it, as needed.
            this.vw_MusteriRaporTableAdapter.Fill(this._D_RDataSet.vw_MusteriRapor);
            cbSecim.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

        private void cbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSecim.SelectedItem == "Kasa")
            {
                reportViewer2.Top = 100;
                reportViewer2.Left = 50;
                reportViewer2.Height = 500;
                reportViewer2.Width = 700;
                reportViewer2.Visible = true;
                reportViewer1.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;

            }
            else if (cbSecim.SelectedItem == "Müşteri")
            {
                reportViewer1.Top = 100;
                reportViewer1.Left = 50;
                reportViewer1.Height = 500;
                reportViewer1.Width = 700;
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
            }
            else if (cbSecim.SelectedItem == "Firma")
            {
                reportViewer4.Top = 100;
                reportViewer4.Left = 50;
                reportViewer4.Height = 500;
                reportViewer4.Width = 700;
                reportViewer4.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer1.Visible = false;
            }
            else if (cbSecim.SelectedItem == "Kasiyer")
            {
                reportViewer3.Top = 100;
                reportViewer3.Left = 50;
                reportViewer3.Height = 500;
                reportViewer3.Width = 700;
                reportViewer3.Visible = true;
                reportViewer2.Visible = false;
                reportViewer1.Visible = false;
                reportViewer4.Visible = false;
            }
        }

    }
}
