using DandR.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DandR
{
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        KasaHareketler ks = new KasaHareketler();
        bool acıkmı = false;
        private void Yonetici_Load(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = 250;
            slblKullanici.Text = Genel.uyeadi;
            slblYetki.Text = Genel.uyetipi;
            slblDate.Text = DateTime.Now.ToShortDateString();
            KasaHareketler ks = new KasaHareketler();
            ks.KasaHesapla(lblKasaTutari);
            Genel.KasaToplam = Convert.ToInt32(lblKasaTutari.Text);
            
        }

        private void tsCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormAcikMi(Form AcilacakForm)
        {

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    acıkmı = false;
                }
            }
            if (acıkmı == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else { AcilacakForm.Dispose(); }
        }

        private void tsKasiyer_Click(object sender, EventArgs e)
        {
            KasiyerEkleSorgula frm = new KasiyerEkleSorgula();
            frm.ShowDialog();
        }

        private void tsUrunSorgulama_Click(object sender, EventArgs e)
        {
            KasiyerSatisSorgulama frm = new KasiyerSatisSorgulama();
            frm.ShowDialog();
        }

        private void slblMesaj_Click(object sender, EventArgs e)
        {
            Notlar nt = new Notlar();
            nt.ShowDialog();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Kasaİslemleri ksIslem = new Kasaİslemleri();
            ksIslem.ShowDialog();
        }

        private void tsKasiyerSatislar_Click(object sender, EventArgs e)
        {
            FirmaOdeme frm = new FirmaOdeme();
            frm.ShowDialog();
            ks.KasaHesapla(lblKasaTutari);
            Genel.KasaToplam =Convert.ToInt32( lblKasaTutari.Text);

        }

        private void Yonetici_MouseMove(object sender, MouseEventArgs e)
        {
            //ks.KasaHesapla(lblKasaTutari);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Raporlama frm = new Raporlama();
            frm.ShowDialog();
        }
    }
}
