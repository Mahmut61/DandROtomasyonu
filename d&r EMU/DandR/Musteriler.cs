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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        
        

        private void Musteriler_Load(object sender, EventArgs e)
        {
            
            this.Top = 150;
            this.Left =150;
            txtYetkiID.Text = "3";
            Musteri m = new Musteri();
            m.MusterileriGetir(lvMusteriler);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                Musteri m = new Musteri();
                if (m.MusteriVarmi(txtAdi.Text, txtSoyadi.Text, txtTelefon.Text))
                {
                    MessageBox.Show("Girdiğiniz müşteri zaten kayıtlı!");
                    txtAdi.Focus();
                }
                else
                {
                    m.MusteriYetkiID = Convert.ToInt32(txtYetkiID.Text);
                    m.MusteriAd = txtAdi.Text.ToUpper();
                    m.MusteriSoyad = txtSoyadi.Text.ToUpper();
                    m.Telefon = txtTelefon.Text;
                    m.Adres = txtAdres.Text;
                    m.Eposta = txtEposta.Text;
                    m.DogumTarihi = Convert.ToDateTime(txtTarih.Text);
                    if (m.MusteriEkle(m))
                    {
                        MessageBox.Show("Müşteri Bilgileri kaydedildi.");
                        m.MusterileriGetir(lvMusteriler);
                        btnKaydet.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri Eklemede sorunla karşılaşıldı!");
                        txtAdi.Focus();
                    }
                }
            }
            else { MessageBox.Show("Müşteri Adı,Soyadı ve Telefon alanları boş geçilemez!", "Dikkat Eksik Bilgi"); }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtEposta.Clear();
            txtTarih.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            txtMusteriNo.Text = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            txtYetkiID.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;
            txtTarih.Text = lvMusteriler.SelectedItems[0].SubItems[5].Text;
            txtEposta.Text = lvMusteriler.SelectedItems[0].SubItems[6].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[7].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtAdi.Focus();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.MusterileriGetirByAdaGore(txtAdaGore.Text, lvMusteriler);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text.Trim() != "" && txtSoyadi.Text.Trim() != "" && txtTelefon.Text.Trim() != "")
            {
                Musteri m = new Musteri();
                m.MusteriNo = Convert.ToInt32(txtMusteriNo.Text);
                m.MusteriYetkiID = Convert.ToInt32(txtYetkiID.Text);
                m.MusteriAd = txtAdi.Text.ToUpper();
                m.MusteriSoyad = txtSoyadi.Text.ToUpper();
                m.Telefon = txtTelefon.Text;
                m.Adres = txtAdres.Text;
                m.Eposta = txtEposta.Text;
                m.DogumTarihi = Convert.ToDateTime(txtTarih.Text);
                if (m.MusteriGuncelle(m))
                {
                    MessageBox.Show("Müşteri Bilgileri güncellendi.");
                    m.MusterileriGetir(lvMusteriler);
                    btnKaydet.Enabled = false;
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Müşteri Güncellemede sorunla karşılaşıldı!");
                    txtAdi.Focus();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Musteri m = new Musteri();
                bool Sonuc = m.MusteriSil(Convert.ToInt32(txtMusteriNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Musteri Bilgileri silindi.");
                    m.MusterileriGetir(lvMusteriler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }

        private void Musteriler_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Musteriler_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kasiyer ks = new Kasiyer(); 
            this.Close();
 
        }
    }
}
