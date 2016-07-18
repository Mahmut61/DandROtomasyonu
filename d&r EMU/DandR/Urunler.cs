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
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = 133;
            Kategoriler k = new Kategoriler();
            k.KategorileriGetir(cbKategoriler);
            Urun u = new Urun();
            txtTur.ReadOnly = true;
            u.UrunleriGetir(lvUrunler);
            u.UrunTurleriGetir(cbTur);
            cbTur.Enabled = true;
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategoriler k = (Kategoriler)cbKategoriler.SelectedItem;
            txtKategoriler.Text = k.KategoriAd;
            txtKategoriNo.Text = Convert.ToString(k.KategoriNo);
            txtBarkodNo.Focus();

            if (txtKategoriler.Text == "Kırtasiye")
            {
                grbKitap.Enabled = false;
                grbOyuncak.Enabled = false;
                lvUrunler.Columns[6].Width = 0;//yasgrubu
                lvUrunler.Columns[12].Width = 0;//ozet
                lvUrunler.Columns[13].Width = 0;//yazar gizlencek
            }
            else if (txtKategoriler.Text == "Oyuncak")
            {
                grbKitap.Enabled = false;
                grbOyuncak.Enabled = true;
                lvUrunler.Columns[6].Width = 60;//yasgrubu
                lvUrunler.Columns[12].Width = 0;//ozet
                lvUrunler.Columns[13].Width = 0;//yazar gizlencek
            }
            else if (txtKategoriler.Text == "Kitap")
            {
                grbKitap.Enabled = true;
                grbOyuncak.Enabled = false;
                lvUrunler.Columns[6].Width = 0;//yasgrubu
                lvUrunler.Columns[11].Width = 0;//yasgrubu
                lvUrunler.Columns[12].Width = 60;//ozet
                lvUrunler.Columns[13].Width = 100;//yazar gizlencek
            }
            txtBarkodNo.Focus();
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            txtUrunNo.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtBarkodNo.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtUrunAdi.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;
            txtKategoriler.Text = lvUrunler.SelectedItems[0].SubItems[3].Text;
            txtAciklama.Text = lvUrunler.SelectedItems[0].SubItems[4].Text;
            txtTur.Text = lvUrunler.SelectedItems[0].SubItems[5].Text;
            txtYasGrubu.Text = lvUrunler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvUrunler.SelectedItems[0].SubItems[7].Text;
            txtBirimFiyat.Text = lvUrunler.SelectedItems[0].SubItems[8].Text;
            txtAlisFiyati.Text = lvUrunler.SelectedItems[0].SubItems[9].Text;
            txtKritikSeviye.Text = lvUrunler.SelectedItems[0].SubItems[10].Text;
            txtKategoriNo.Text = lvUrunler.SelectedItems[0].SubItems[11].Text;
            txtOzet.Text = lvUrunler.SelectedItems[0].SubItems[12].Text;
            txtYazar.Text = lvUrunler.SelectedItems[0].SubItems[13].Text;
            cbKategoriler.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            txtBarkodNo.Focus();
        }

        private void cbTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTur.Text = cbTur.SelectedItem.ToString();
        }

        private void txtBarkodaGore_TextChanged(object sender, EventArgs e)
        {
            Urun u = new Urun();
            u.UrunleriGetirByBarkodaGore(txtBarkodaGore.Text, lvUrunler);
        }

        private void txtKategoriler_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriler.Text == "Kırtasiye")
            {
                grbKitap.Enabled = false;
                grbOyuncak.Enabled = false;
                lvUrunler.Columns[6].Width = 1;//yasgrubu
                lvUrunler.Columns[12].Width = 1;//ozet
                lvUrunler.Columns[13].Width = 1;//yazar gizlencek
            }
            else if (txtKategoriler.Text == "Oyuncak")
            {
                grbKitap.Enabled = false;
                grbOyuncak.Enabled = true;
                lvUrunler.Columns[6].Width = 60;//yasgrubu
                lvUrunler.Columns[12].Width = 1;//ozet
                lvUrunler.Columns[13].Width = 1;//yazar gizlencek
            }
            else if (txtKategoriler.Text == "Kitap")
            {
                grbKitap.Enabled = true;
                grbOyuncak.Enabled = false;
                lvUrunler.Columns[6].Width = 1;//yasgrubu
                lvUrunler.Columns[12].Width = 60;//ozet
                lvUrunler.Columns[13].Width = 100;//yazar gizlencek
            }
        }
        private void Temizle()
        {
            txtKategoriler.Clear();
            txtBarkodNo.Clear();
            txtUrunAdi.Clear();
            txtTur.Clear();
            txtYazar.Clear();
            txtYasGrubu.Clear();
            txtAciklama.Clear();
            txtBirimFiyat.Clear();
            txtAlisFiyati.Clear();
            txtMiktar.Clear();
            txtKritikSeviye.Clear();
            txtTur.ReadOnly = true;
            cbTur.Enabled = true;
            txtBarkodNo.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            cbKategoriler.Enabled = true;
            btnKaydet.Enabled = true;
            btnYeni.Enabled = false;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnYeniTur_Click(object sender, EventArgs e)
        {
            txtTur.ReadOnly = false;
            cbTur.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "")
            {
                Urun u = new Urun();
                bool Sonuc = u.UrunVarmi(txtBarkodNo.Text, txtUrunAdi.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Bu ürün önceden kayıtlı!");
                    txtBarkodNo.Focus();
                }
                else
                {

                    u.UrunBarkodNo = txtBarkodNo.Text;
                    u.KategoriID = Convert.ToInt32(txtKategoriNo.Text);
                    u.UrunAd = txtUrunAdi.Text;
                    u.Tur = txtTur.Text;
                    u.Yazar = txtYazar.Text;
                    u.Ozet = txtOzet.Text;
                    u.YasGrubu = txtYasGrubu.Text;
                    u.Aciklama = txtAciklama.Text;
                    u.Miktar = Convert.ToInt32(txtMiktar.Text);////string.format("{0:#,##0.00}", ...sayı........)
                    u.Birimfiyat = Convert.ToDecimal(string.Format("{0:#,##0.00}", txtBirimFiyat.Text));
                    u.Alisfiyat = Convert.ToInt32(txtAlisFiyati.Text);
                    u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                    if (u.UrunEkle(u))
                    {
                        MessageBox.Show("Urun Bilgileri eklendi.");
                        u.UrunleriGetir(lvUrunler);
                        u.UrunTurleriGetir(cbTur);
                        btnKaydet.Enabled = false;
                        btnYeni.Enabled = true;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Urun Eklemede sorunla karşılaşıldı!");
                        txtBarkodNo.Focus();
                    }
                }
            }
            else { MessageBox.Show("Barkod numarası,Urun Adı alanları boş geçilemez!", "Dikkat Eksik Bilgi"); }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Urun u = new Urun();
                bool Sonuc = u.UrunSil(Convert.ToInt32(txtUrunNo.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Ürün Bilgileri silindi.");
                    u.UrunleriGetir(lvUrunler);
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    Temizle();
                }
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text.Trim() != "" && txtUrunAdi.Text.Trim() != "")
            {
                Urun u = new Urun();
                bool Sonuc = u.UrunVarmi(txtBarkodNo.Text, txtUrunAdi.Text, txtUrunNo.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Bu film önceden kayıtlı!");
                    txtBarkodNo.Focus();
                }
                else
                {
                    u.UrunID = Convert.ToInt32(txtUrunNo.Text);
                    u.UrunBarkodNo = txtBarkodNo.Text;
                    u.KategoriID = Convert.ToInt32(txtKategoriNo.Text);
                    u.UrunAd = txtUrunAdi.Text;
                    u.Tur = txtTur.Text;
                    u.Yazar = txtYazar.Text;
                    u.Ozet = txtOzet.Text;
                    u.YasGrubu = txtYasGrubu.Text;
                    u.Aciklama = txtAciklama.Text;
                    u.Miktar = Convert.ToInt32(txtMiktar.Text);
                    u.Birimfiyat = Convert.ToDecimal(string.Format("{0:#,##0.00}", txtBirimFiyat.Text));
                    u.Alisfiyat = Convert.ToInt32(txtAlisFiyati.Text);
                    u.KritikSeviye = Convert.ToInt32(txtKritikSeviye.Text);
                    if (u.UrunGuncelle(u))
                    {
                        MessageBox.Show("Urun Bilgileri güncellendi.");
                        u.UrunleriGetir(lvUrunler);
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Urun Değiştirmede sorunla karşılaşıldı!");
                        txtBarkodNo.Focus();
                    }
                }
            }
            else { MessageBox.Show("Barkod numarası,Urun Adı alanları boş geçilemez!", "Dikkat Eksik Bilgi"); }
        }
    }
}
