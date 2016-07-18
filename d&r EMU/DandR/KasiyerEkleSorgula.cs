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
    public partial class KasiyerEkleSorgula : Form
    {
        public KasiyerEkleSorgula()
        {
            InitializeComponent();
        }
        //Mahmut
        //string.format("{0:#,##0.00}", ...sayı........)
        private void KasiyerEkleSorgula_Load(object sender, EventArgs e)
        {
            this.Top = 150;
            this.Left = 150;
            txtYetkiID.Text = "2";
            KasiyerIslemleri k = new KasiyerIslemleri();
            k.KasiyerleriGetir(lvKasiyerler);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtKimlikNo.Text.Trim() != "")
            {
                KasiyerIslemleri k = new KasiyerIslemleri();
                if (k.KasiyerVarmi(txtKimlikNo.Text))
                {
                    MessageBox.Show("Girdiğiniz kasiyer zaten kayıtlı!");
                    txtAdi.Focus();
                }
                else
                {

                    k.KasiyerYetkiID = Convert.ToInt32(txtYetkiID.Text);
                    k.KasiyerAd = txtAdi.Text.ToUpper();
                    k.KasiyerSoyad = txtSoyadi.Text.ToUpper();
                    k.TcKimlikNo = txtKimlikNo.Text;
                    k.DogumTarihi = Convert.ToDateTime(txtTarih.Text);
                    k.Telefon = txtTelefon.Text;
                    k.Adres = txtAdres.Text;
                    k.Sifre = txtSifre.Text;
                    k.Eposta = txtEposta.Text;
                    k.Maas = Convert.ToDouble(txtMaas.Text);
                    k.GorevBaslangic = Convert.ToDateTime(txtBaslangic.Text);


                    if (k.KasiyerEkle(k))
                    {
                        MessageBox.Show("Kasiyer Bilgileri kaydedildi.");
                        k.KasiyerleriGetir(lvKasiyerler);
                        btnKaydet.Enabled = false;
                        groupBox1.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Kasiyer Eklemede sorunla karşılaşıldı!");
                        txtAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kasiyer Adı,Soyadı ve Kimlik Numarası alanları boş geçilemez!", "Dikkat Eksik Bilgi");
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtKimlikNo.Clear();
            txtTarih.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtSifre.Clear();
            txtEposta.Clear();
            txtMaas.Clear();
            txtBaslangic.Clear();
            txtAdi.Focus();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            txtBaslangic.Text = dtpBaslangic.Value.ToShortDateString();
        }

        private void lvKasiyerler_DoubleClick(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            txtKasiyerNo.Text = lvKasiyerler.SelectedItems[0].SubItems[0].Text;
            txtYetkiID.Text = lvKasiyerler.SelectedItems[0].SubItems[1].Text;
            txtAdi.Text = lvKasiyerler.SelectedItems[0].SubItems[2].Text;
            txtSoyadi.Text = lvKasiyerler.SelectedItems[0].SubItems[3].Text;
            txtKimlikNo.Text = lvKasiyerler.SelectedItems[0].SubItems[4].Text;
            txtTarih.Text = lvKasiyerler.SelectedItems[0].SubItems[5].Text;
            txtTelefon.Text = lvKasiyerler.SelectedItems[0].SubItems[6].Text;
            txtAdres.Text = lvKasiyerler.SelectedItems[0].SubItems[7].Text;
            txtSifre.Text = lvKasiyerler.SelectedItems[0].SubItems[9].Text;
            txtEposta.Text = lvKasiyerler.SelectedItems[0].SubItems[10].Text;
            txtMaas.Text = lvKasiyerler.SelectedItems[0].SubItems[11].Text;
            txtBaslangic.Text = lvKasiyerler.SelectedItems[0].SubItems[12].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdi.Focus();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            KasiyerIslemleri k = new KasiyerIslemleri();
            k.KasiyerleriGetirByAdaGore(txtAdaGore.Text, lvKasiyerler);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "")
            {
                KasiyerIslemleri k = new KasiyerIslemleri();
                if (k.KasiyerVarmiTc(txtKimlikNo.Text, Convert.ToInt32(txtKasiyerNo.Text)))
                {
                    MessageBox.Show("Aynı kasiyer kayıtlı!");
                }
                else
                {
                    k.KasiyerID = Convert.ToInt32(txtKasiyerNo.Text);
                    k.KasiyerYetkiID = Convert.ToInt32(txtYetkiID.Text);
                    k.KasiyerAd = txtAdi.Text.ToUpper();
                    k.KasiyerSoyad = txtSoyadi.Text.ToUpper();
                    k.TcKimlikNo = txtKimlikNo.Text;
                    k.DogumTarihi = Convert.ToDateTime(txtTarih.Text);
                    k.Telefon = txtTelefon.Text;
                    k.Adres = txtAdres.Text;
                    k.Sifre = txtSifre.Text;
                    k.Eposta = txtEposta.Text;
                    k.Maas = Convert.ToDouble(txtMaas.Text);
                    k.GorevBaslangic = Convert.ToDateTime(txtBaslangic.Text);

                    if (k.KasiyerGuncelle(k))
                    {
                        MessageBox.Show("Kasiyer Bilgileri Guncellendi.");
                        k.KasiyerleriGetir(lvKasiyerler);
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Kasiyer Bilgisi Güncellemede Sorunla Karşılaşıldı!");
                        txtAdi.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kasiyer Adı,Soyadı ve Kimlik Numarası alanları boş geçilemez!", "Dikkat Eksik Bilgi");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                KasiyerIslemleri k = new KasiyerIslemleri();
                bool Sonuc = k.KasiyerSil(Convert.ToInt32(txtKasiyerNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Kasiyer Bilgileri Silindi.");
                    k.KasiyerleriGetir(lvKasiyerler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
