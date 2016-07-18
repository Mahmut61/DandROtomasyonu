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
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        } int i = 0;
        static int ToplamAdet = 0;
        static double ToplamTutar = 0;
        private void UrunSatis_Load(object sender, EventArgs e)
        {
            this.Top = 80;
            this.Left = 150;
            Urun u = new Urun();
            u.UrunleriGetir(lvUrunler);
            Kategoriler k = new Kategoriler();
            k.KategorileriGetir(cbKategoriler);
            txtKasiyerID.Text = Genel.kasiyerid.ToString();
            txtTarih.Text = DateTime.Now.ToShortDateString();

            cbKategoriler.Items.Insert(0, "Tüm Türler");
            cbKategoriler.SelectedIndex = 0;
        }

        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            TxtTemizle();
            txtAdet.ReadOnly = false;


            txtUrunNo.Text = lvUrunler.SelectedItems[0].SubItems[0].Text;
            txtBarkodNo.Text = lvUrunler.SelectedItems[0].SubItems[1].Text;
            txtUrunAd.Text = lvUrunler.SelectedItems[0].SubItems[2].Text;
            txtkategori.Text = lvUrunler.SelectedItems[0].SubItems[3].Text;
            //cbKategoriler.Text = lvUrunler.SelectedItems[0].SubItems[3].Text; // ** txt olduğu için patlarbunu koymasak tamamdır
            txtMiktar.Text = lvUrunler.SelectedItems[0].SubItems[7].Text;
            txtBirimFiyat.Text = lvUrunler.SelectedItems[0].SubItems[8].Text;
            txtKritikSeviye.Text = lvUrunler.SelectedItems[0].SubItems[9].Text;
            txtKategoriNo.Text = lvUrunler.SelectedItems[0].SubItems[10].Text;
            txtYazar.Text = lvUrunler.SelectedItems[0].SubItems[12].Text;

            //--------------------------------------------------------------------------
            txtFiyat.Text = lvUrunler.SelectedItems[0].SubItems[8].Text;


            lvSepet.Items.Add(lvUrunler.SelectedItems[0].SubItems[0].Text);
            lvSepet.Items[i].SubItems.Add(lvUrunler.SelectedItems[0].SubItems[2].Text);
            lvSepet.Items[i].SubItems.Add(lvUrunler.SelectedItems[0].SubItems[8].Text);
            lvSepet.Items[i].SubItems.Add(txtAdet.Text);
            lvSepet.Items[i].SubItems.Add(txtFiyat.Text);

            ToplamAdet += Convert.ToInt32(lvSepet.Items[i].SubItems[3].Text);
            ToplamTutar += Convert.ToDouble(lvSepet.Items[i].SubItems[4].Text);

            txtToplamAdet.Text = ToplamAdet.ToString();
            txtToplamTutar.Text = ToplamTutar.ToString();
            txtAdet.Text = "1";
            i++;
            txtAdet.Focus();
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkategori.Text = cbKategoriler.SelectedItem.ToString();

            if (cbKategoriler.SelectedItem == "Tüm Türler")
            {
                TxtTemizle();
                UrunleriGetir();
            }
            else if (cbKategoriler.SelectedItem != "Tüm Türler")
            {
                TxtTemizle();
                Urun u = new Urun();
                u.UrunleriGetirByDetaySorgulama2(cbKategoriler.SelectedItem.ToString(), lvUrunler);
            }
        }
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void UrunleriGetir()
        {
            string Kategori = "";
            if (cbKategoriler.SelectedItem.ToString() != "Tüm Türler")
            {
                Kategori = cbKategoriler.SelectedItem.ToString();
            }
            Urun u = new Urun();
            u.UrunleriGetirByDetaySorgulama(txtBarkodNo.Text, txtUrunAd.Text, Kategori, lvUrunler);

        }

        private void TxtTemizle()
        {
            txtUrunNo.Clear();
            txtBarkodNo.Clear();
            txtUrunAd.Clear();
            //cbKategoriler.Items.Clear();
            txtMiktar.Clear();
            txtBirimFiyat.Clear();
            txtKritikSeviye.Clear();
            txtKategoriNo.Clear();
            txtYazar.Clear();

        }

        private void txtBarkodNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUrunAd.Clear();
            //cbKategoriler.Items.Clear();
            txtMiktar.Clear();
            txtBirimFiyat.Clear();
            txtKritikSeviye.Clear();
            txtYazar.Clear();
            txtBarkodNo.Text = txtBarkodNo.Text;
            UrunleriGetir();

        }

        private void txtUrunAd_KeyPress(object sender, KeyPressEventArgs e)
        {


            //cbKategoriler.Items.Clear();
            txtMiktar.Clear();
            txtBirimFiyat.Clear();
            txtKritikSeviye.Clear();
            txtYazar.Clear();
            UrunleriGetir();
        }

        private void txtYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUrunNo.Clear();
            txtBarkodNo.Clear();
            txtUrunAd.Clear();
            //cbKategoriler.Items.Clear();
            txtMiktar.Clear();
            txtBirimFiyat.Clear();
            txtKritikSeviye.Clear();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            //txtUrunAd.Clear();
            ////cbKategoriler.Items.Clear();
            //txtMiktar.Clear();
            //txtBirimFiyat.Clear();
            //txtKritikSeviye.Clear();
            //txtYazar.Clear();
            //txtBarkodNo.Text = txtBarkodNo.Text;
            //UrunleriGetir();
        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {
            //cbKategoriler.Items.Clear();
            //txtMiktar.Clear();
            //txtBirimFiyat.Clear();
            //txtKritikSeviye.Clear();
            //txtYazar.Clear();
            //UrunleriGetir();
        }

        private void txtYazar_TextChanged(object sender, EventArgs e)
        {
            //txtUrunNo.Clear();
            //txtBarkodNo.Clear();
            //txtUrunAd.Clear();
            ////cbKategoriler.Items.Clear();
            //txtMiktar.Clear();
            //txtBirimFiyat.Clear();
            //txtKritikSeviye.Clear();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            MusteriSorgulama frm = new MusteriSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtMusteriAdiSoyadi.Text = Genel.musteri;
            txtMusteri.Text = Genel.musteri;
            txtMusteriNo.Text = Genel.musterino.ToString();
            txtToplamHarcama.Text = Genel.toplamharcama.ToString();

        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtAdet.Text == "")
            { }
            if (txtAdet.Text != "")
            {
                int girenadet = Convert.ToInt32(txtAdet.Text.ToString());
                int stokadet = Convert.ToInt32(txtMiktar.Text.ToString());
                if (girenadet > stokadet) { MessageBox.Show("Yeterli Stok Yok..."); }
                else
                {
                    int a = lvSepet.Items.Count;
                    //if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
                    //if (string.IsNullOrEmpty(txtFiyat.Text)) { txtFiyat.Text = "0"; txtFiyat.Select(0,                         txtFiyat.Text.Length); }//Bura hesaplanacak...
                    if (txtAdet.Text != "")
                    {
                        txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();

                        lvSepet.Items[a - 1].SubItems[3].Text = txtAdet.Text;
                        lvSepet.Items[a - 1].SubItems[4].Text = txtTutar.Text;
                        ToplamTutar = 0;
                        ToplamAdet = 0;
                        for (int i = 0; i < lvSepet.Items.Count; i++)
                        {
                            ToplamAdet += Convert.ToInt32(lvSepet.Items[i].SubItems[3].Text);
                            ToplamTutar += Convert.ToDouble(lvSepet.Items[i].SubItems[4].Text);

                        }
                        txtToplamAdet.Text = ToplamAdet.ToString();
                        txtToplamTutar.Text = ToplamTutar.ToString();
                    }

                }
            }

        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text)) { txtAdet.Text = "1"; txtAdet.Select(0, 2); }
            if (string.IsNullOrEmpty(txtFiyat.Text)) { txtFiyat.Text = "0"; txtFiyat.Select(0, txtFiyat.Text.Length); }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDouble(txtFiyat.Text)).ToString();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lvSepet.Items.Clear();
            i = 0;
            label17.Text = "0";
            txtToplamTutar.Text = "0";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lvSepet.SelectedItems.Count > 0)
            {
                int silinenadet = Convert.ToInt32(lvSepet.SelectedItems[0].SubItems[3].Text);
                double silinenFiyat = Convert.ToDouble(lvSepet.SelectedItems[0].SubItems[4].Text);
                
                
                label17.Text = ((Convert.ToInt32(label17.Text)) - silinenadet).ToString();
                txtToplamTutar.Text = ((Convert.ToInt32(txtToplamTutar.Text)) - silinenFiyat).ToString();
                lvSepet.SelectedItems[0].Remove();
                i--;
                
            }
            else MessageBox.Show("Önce Bir Seçim Yapın...");
            if (lvSepet.Items.Count == 0)
                {
                    i = 0;
                    ToplamAdet = 0;
                    ToplamTutar = 0;
                    txtToplamTutar.Text = "0";
                   
                }
        }

        private void btnKaydet_Click(object sender, EventArgs e)//bura bitti
        {
            if (txtUrunNo.Text.Trim() != "" && txtMusteriNo.Text.Trim() != "")
            {
                UrunSatislar us = new UrunSatislar();
                for (int j = 0; j < lvSepet.Items.Count; j++)
                {
                    int miktar = 0, UrunID = 0;
                    double birimfiyat = 0;
                    UrunID = Convert.ToInt32(lvSepet.Items[j].SubItems[0].Text);
                    //  MessageBox.Show(a.ToString());  // GELEN VERİLER MSJ OLARAK VERİR
                    miktar = Convert.ToInt32(lvSepet.Items[j].SubItems[3].Text);
                    //  MessageBox.Show(b.ToString());
                    birimfiyat = Convert.ToDouble(lvSepet.Items[j].SubItems[2].Text);

                    us.SatısYapıldıStokGüncelle(UrunID, miktar);//Stok Güncelleme

                    us.UrunID = UrunID;
                    us.MusteriID = Convert.ToInt32(txtMusteriNo.Text);
                    us.KasiterID = Convert.ToInt32(txtKasiyerID.Text);
                    us.IslemTuru = "Satış";
                    us.Tarih = Convert.ToDateTime(txtTarih.Text);
                    us.Miktar = miktar;
                    us.BirimFiyat = birimfiyat;
                    us.ToplamTutar = Convert.ToDouble(miktar * birimfiyat);

                    us.SatisEkle(us);//Satış Yapma
                }
                MessageBox.Show("Stok Güncellendi...");
                i = 0;
                lvSepet.Items.Clear();
                txtToplamAdet.Clear();
                txtToplamTutar.Clear();

                us.MusteriToplamAlisveris(Convert.ToInt32(txtMusteriNo.Text), ToplamTutar);//Müşteri Toplam Alisveris

                KasiyerIslemleri ki = new KasiyerIslemleri();
                ki.KasiyerSatisToplamaEkle(Convert.ToInt32(txtKasiyerID.Text), ToplamTutar, Convert.ToDateTime(txtTarih.Text));//Kasiyer Satis Guncelleme

                ki.KasiyereToplamSatisEkle(Convert.ToInt32(txtKasiyerID.Text), ToplamTutar);
                Urun u = new Urun();
                u.UrunleriGetir(lvUrunler);
                this.Refresh();

                //-------------------------------
                KasaHareketler kh = new KasaHareketler();
                kh.KasaTuru = "Merkez Kasa";
                kh.Tarih = Convert.ToDateTime(txtTarih.Text);
                kh.IslemTuru = "Tahsilat";
                kh.FirmaAd = "";
                kh.KasiyerAd = Genel.uyeadi.ToString();
                kh.Parabirimi = "TL";
                kh.Belge = "";
                kh.Giren = Convert.ToDouble(ToplamTutar);
                kh.Cikan = 0;

                kh.KasaHarekerEkle(kh);
                //-------------------------------
            }
            else { MessageBox.Show("Öncelikle müşteri ve film seçilmiş olmalıdır."); }

        }

        private void txtAdet_MouseClick(object sender, MouseEventArgs e)
        {
            txtAdet.Clear();
        }

        private void txtToplamAdet_TextChanged(object sender, EventArgs e)
        {
            label17.Text = txtToplamAdet.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sepete ekleme bittiyse [Kaydet] 'e basınız...");
        }
    }
}
