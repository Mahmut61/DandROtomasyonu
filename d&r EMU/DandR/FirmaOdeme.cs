using DandR.Model;
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
    public partial class FirmaOdeme : Form
    {
        public FirmaOdeme()
        {
            InitializeComponent();
        }
        Yonetici y = new Yonetici();
        KasaHareketler ks = new KasaHareketler();
        KasiyerIslemleri KsIslem = new KasiyerIslemleri();
        private void FirmaOdeme_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 250;
            KsIslem.FirmalarıGetir(lvFirmalarOdeme);

            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void lvFirmalarOdeme_DoubleClick(object sender, EventArgs e)
        {
            txtFirmaNo.Text = lvFirmalarOdeme.SelectedItems[0].SubItems[0].Text;
            txtUnvan.Text = lvFirmalarOdeme.SelectedItems[0].SubItems[1].Text;
            txtTelefon.Text = lvFirmalarOdeme.SelectedItems[0].SubItems[2].Text;
            txtToplamBakiye.Text = lvFirmalarOdeme.SelectedItems[0].SubItems[3].Text;
            txtOdemeTutari.ReadOnly = false;
            btnOde.Enabled = true;
            txtOdemeTutari.Focus();
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (Genel.KasaToplam > Convert.ToInt32(txtOdemeTutari.Text))
            {
                KasaHareketler kh = new KasaHareketler();
                kh.FirmaBakiyeGuncelleOde(Convert.ToInt32(txtFirmaNo.Text), Convert.ToDouble(txtOdemeTutari.Text));
                kh.KasabyOdeme(Convert.ToInt32(txtFirmaNo.Text), Convert.ToDouble(txtOdemeTutari.Text));
                KsIslem.FirmalarıGetir(lvFirmalarOdeme);
                MessageBox.Show("Ödeme Yapıldı.");

                //-------------------------------
                txtTarih.Text = DateTime.Now.ToShortDateString();
                kh.KasaTuru = "Merkez Kasa";
                kh.Tarih = Convert.ToDateTime(txtTarih.Text);
                kh.IslemTuru = "Ödeme";
                kh.FirmaAd = txtUnvan.Text;
                kh.KasiyerAd = "";
                kh.Parabirimi = "TL";
                kh.Belge = "";
                kh.Giren = 0;
                kh.Cikan = Convert.ToDouble(txtOdemeTutari.Text);
                kh.KasaHarekerEkle(kh);
                //-------------------------------

                ks.KasaHesapla(y.lblKasaTutari);
            }
            else { MessageBox.Show("Kasada Yeterli tutar yok!"); }
        }

        private void FirmaOdeme_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            ks.KasaHesapla(y.lblKasaTutari);
            y.lblKasaTutari.Text = Genel.KasaToplam.ToString();
            this.Close();
           
        }
    }
}
