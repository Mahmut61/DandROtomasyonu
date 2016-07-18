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
    public partial class Kasaİslemleri : Form
    {
        public Kasaİslemleri()
        {
            InitializeComponent();
        }
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        KasiyerIslemleri KsIslem = new KasiyerIslemleri();
        private void Kasaİslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 90;
            this.Left = 250;
            lvDetay.Visible = true;
            KsIslem.FirmalarıGetir(lvFirmalar);
            txtBugün.Text = DateTime.Now.ToShortDateString();
            dtpIslemTarihi.Text = DateTime.Now.ToShortDateString();
            txtBilgiTarihi.Text = DateTime.Now.ToShortDateString();
            cbIslemTurleri.SelectedItem = "Satış";
            if (rbFirmalar.Checked == true)
            {
                KsIslem.FirmalarıGetir(lvCariler);
            }
            else if (rbMusteriler.Checked == true)
            {
                KsIslem.MusterileriGetir(lvCariler);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            KsIslem.MusterileriGetir(lvCariler);
            lvDetay.Visible = false;
            lvdetayMusteri.Visible = true;
            //lvCariler.Columns[4].Width = 0;
            //lvCariler.Columns[9].Width = 0;
            //lvCariler.Columns[5].Width = 100;
            //lvCariler.Columns[8].Width = 100;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            KsIslem.FirmalarıGetir(lvCariler);
            lvDetay.Visible = true;
            lvdetayMusteri.Visible = false;
            //lvCariler.Columns[4].Width = 100;
            //lvCariler.Columns[9].Width = 100;
            //lvCariler.Columns[5].Width =0;
            //lvCariler.Columns[8].Width = 0;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            //lvCariler.Columns[4].Width = 100;
            //lvCariler.Columns[9].Width = 100;
            //lvCariler.Columns[5].Width = 100;
            //lvCariler.Columns[8].Width = 100;
        }

        private void MaliDurum_Click(object sender, EventArgs e)
        {
            KasaHareketler k = new KasaHareketler();
            k.FirmalariGetir(lvFirmalar);
            //k.UrunleriGetir(lvUrunler);
        }

        private void dtpIslemTarihi_ValueChanged(object sender, EventArgs e)
        {

            txtBilgiTarihi.Text = dtpIslemTarihi.Value.ToShortDateString();

            DateTime ilk = new DateTime();
            ilk = Convert.ToDateTime(txtBilgiTarihi.Text);
            DateTime son = new DateTime();
            son = Convert.ToDateTime(txtBugün.Text);
            int FirmaId = Convert.ToInt32(txtfirmaNo.Text);
            if (rbFirmalar.Checked == true)
            {

                KsIslem.FirmalarıGetirBySatisTarihlerArasi(ilk, son, FirmaId, lvDetay);
            }
            else if (rbMusteriler.Checked == true)
            {
                if (lvCariler.SelectedItems.Count > 0)
                {
                    int musteriId = Convert.ToInt32(lvCariler.SelectedItems[0].SubItems[0].Text);
                    KsIslem.MusteriGetirDetaylıSatıs(musteriId, ilk, son, lvdetayMusteri);
                }

            }

        }

        private void lvCariler_DoubleClick(object sender, EventArgs e)
        {
            DateTime ilk = new DateTime();
            ilk = Convert.ToDateTime(txtBilgiTarihi.Text);
            DateTime son = new DateTime();
            son = Convert.ToDateTime((txtBugün.Text));
            int FirmaID = Convert.ToInt32(lvCariler.SelectedItems[0].SubItems[0].Text);
            txtfirmaNo.Text = Convert.ToInt32(lvCariler.SelectedItems[0].SubItems[0].Text).ToString();
            if (rbFirmalar.Checked == true)
            {
                if (lvCariler.SelectedItems.Count > 0)
                {
                    KsIslem.FirmalarıGetirBySatisTarihlerArasi(ilk, son, FirmaID, lvDetay);
                }
            }
            else if (rbMusteriler.Checked == true)
            {
                int musteriId = Convert.ToInt32(lvCariler.SelectedItems[0].SubItems[0].Text);
                if (lvCariler.SelectedItems.Count > 0)
                {
                    KsIslem.MusteriGetirDetaylıSatıs(musteriId, ilk, son, lvdetayMusteri);
                }
            }
        }

        private void lvFirmalar_DoubleClick(object sender, EventArgs e)
        {
            if (lvFirmalar.SelectedItems.Count > 0)
            {
                int kategori = Convert.ToInt32((lvFirmalar.SelectedItems[0].SubItems[0].Text).ToString());
                KsIslem.UrunleriGetirByFirmalaraGore(kategori, lvUrunler);
                txtFirmaId.Text = (lvFirmalar.SelectedItems[0].SubItems[0].Text);
                txtFirmaAd.Text = (lvFirmalar.SelectedItems[0].SubItems[1].Text);
            }
            lvFirmalar.Enabled = false;
        }
        int i = 0;
        int toplamFiyat = 0;
        private void lvUrunler_DoubleClick(object sender, EventArgs e)
        {
            toplamFiyat = 0;
            int adet = Convert.ToInt32((txtadetUrun.Text));
            int fiyat = Convert.ToInt32((lvUrunler.SelectedItems[0].SubItems[3].Text));
            txtUrunAdi.Text = (lvUrunler.SelectedItems[0].SubItems[1].Text);
            txtAdet.Text = (lvUrunler.SelectedItems[0].SubItems[2].Text);
            txtUrunFiyat.Text = (lvUrunler.SelectedItems[0].SubItems[3].Text);
            lvSepetUrun.Items.Add(lvUrunler.SelectedItems[0].SubItems[5].Text);
            lvSepetUrun.Items[i].SubItems.Add(lvUrunler.SelectedItems[0].SubItems[1].Text);
            lvSepetUrun.Items[i].SubItems.Add(lvUrunler.SelectedItems[0].SubItems[3].Text);
            lvSepetUrun.Items[i].SubItems.Add(txtadetUrun.Text);
            lvSepetUrun.Items[i].SubItems.Add((adet * fiyat).ToString());

            i++;
            txtadetUrun.Text = "1";
            txtadetUrun.Focus();
            lvFirmalar.Enabled = false;
            for (int j = 0; j < lvSepetUrun.Items.Count; j++)
            {
                toplamFiyat += Convert.ToInt32(lvSepetUrun.Items[j].SubItems[4].Text);//***********************
            }
            txtToplamTutarUrun.Text = toplamFiyat.ToString();
        }

        private void txtUrunFiyat_TextChanged(object sender, EventArgs e)
        {


        }
        private void txtadetUrun_TextChanged(object sender, EventArgs e)
        {


            if (txtadetUrun.Text == "")
            { }
            if (txtadetUrun.Text != "")
            {
                int girenadet = Convert.ToInt32(txtadetUrun.Text.ToString());
                int a = lvSepetUrun.Items.Count;
                if (txtAdet.Text != "")
                {
                    toplamFiyat = 0;
                    for (int j = 0; j < lvSepetUrun.Items.Count; j++)
                    {
                        toplamFiyat += Convert.ToInt32(lvSepetUrun.Items[j].SubItems[4].Text);//***********************
                    }
                    txtToplamTutarUrun.Text = toplamFiyat.ToString();
                    lvSepetUrun.Items[a - 1].SubItems[3].Text = txtadetUrun.Text;


                } toplamFiyat = 0;
                int adet = Convert.ToInt32(lvSepetUrun.Items[a - 1].SubItems[3].Text);
                int birim = Convert.ToInt32(lvSepetUrun.Items[a - 1].SubItems[2].Text);
                lvSepetUrun.Items[a - 1].SubItems[4].Text = (adet * birim).ToString();
            }
            for (int j = 0; j < lvSepetUrun.Items.Count; j++)
            {
                toplamFiyat += Convert.ToInt32(lvSepetUrun.Items[j].SubItems[4].Text);//***********************
            }
            txtToplamTutarUrun.Text = toplamFiyat.ToString();
            toplamFiyat = 0;
        }


        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            lvSepetUrun.Items.Clear();
            i = 0;
            lvFirmalar.Enabled = true;
            txtToplamTutarUrun.Text = "0";
        }

        private void btnSilUrun_Click(object sender, EventArgs e)
        {
            if (lvSepetUrun.SelectedItems.Count > 0)
            {
                int silinenFiyat = Convert.ToInt32(lvSepetUrun.SelectedItems[0].SubItems[4].Text);
                lvSepetUrun.SelectedItems[0].Remove();
                i--;
                txtToplamTutarUrun.Text = ((Convert.ToInt32(txtToplamTutarUrun.Text)) - silinenFiyat).ToString();
            }
            else MessageBox.Show("Önce Bir Seçim Yapın...");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void lvSepetUrun_ItemActivate(object sender, EventArgs e)
        {

        }
        UrunSatislar u = new UrunSatislar();
        private void btnKaydetUrun_Click(object sender, EventArgs e)
        {
            if (txtBelge.Text.Trim() != "")
            {
                string BelgeNo = txtBelge.Text;
                int FirmaID = Convert.ToInt32(txtFirmaId.Text);
                if (lvSepetUrun.Items.Count > 0)
                {
                    for (int i = 0; i < lvSepetUrun.Items.Count; i++)
                    {
                        int UrunID = Convert.ToInt32(lvSepetUrun.Items[i].SubItems[0].Text);
                        int UrunToplamı = Convert.ToInt32(lvSepetUrun.Items[i].SubItems[4].Text);
                        int Adet = Convert.ToInt32(lvSepetUrun.Items[i].SubItems[3].Text);
                        KsIslem.FirmaByMalKabul(FirmaID, BelgeNo, UrunToplamı, UrunID);//int firmaId,string Belge,int Bakiye,int UrunId

                        u.FirmaSatısYapıldıStokGüncelle(UrunID, Adet);
                    }
                    KasaHareketler ks = new KasaHareketler();
                    ks.FirmaBakiyeGuncelle(FirmaID, Convert.ToInt32(txtToplamTutarUrun.Text));
                    MessageBox.Show("Urunler Eklendi...");
                    lvSepetUrun.Items.Clear();
                    lvUrunler.Items.Clear();
                    lvFirmalar.Visible = true;
                }
            }
            else { MessageBox.Show("Belge No girin!"); }
        }
    }
}
