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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            grbYetkili.Visible = false;
            grbPersonel.Visible = false;
            groupBox1.Visible = true;
            label2.Text = "Yetkili Ad";
            txtKullaniciAdi.Focus();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            grbYetkili.Visible = false;
            grbPersonel.Visible = false;
            groupBox1.Visible = true;
            label2.Text = "Kasiyer Ad";
            txtKullaniciAdi.Focus();
        }

        private void grbYetkili_Enter(object sender, EventArgs e)
        {
            grbYetkili.Visible = false;
            grbPersonel.Visible = false;
            groupBox1.Visible = true;
            label2.Text = "Yetkili Ad";
        }

        private void grbPersonel_Enter(object sender, EventArgs e)
        {
            grbYetkili.Visible = false;
            grbPersonel.Visible = false;
            groupBox1.Visible = true;
            label2.Text = "Kasiyer Ad";
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            grbYetkili.Visible = true;//giriş anında resimler direkt gelsin
            grbYetkili.Height = 180;
            grbYetkili.Width = 150;
            grbYetkili.Top = 50;
            grbYetkili.Left = 75;
            grbPersonel.Visible = true;
            grbPersonel.Height = 180;
            grbPersonel.Width = 150;
            grbPersonel.Top = 50;
            grbPersonel.Left = 270;
            groupBox1.Visible = false;

            txtKullaniciAdi.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grbYetkili.Visible = true;//giriş anında resimler direkt gelsin
            grbYetkili.Height = 180;
            grbYetkili.Width = 150;
            grbYetkili.Top = 50;
            grbYetkili.Left = 75;
            grbPersonel.Visible = true;
            grbPersonel.Height = 180;
            grbPersonel.Width = 150;
            grbPersonel.Top = 50;
            grbPersonel.Left = 270;
            groupBox1.Visible = false;
        }

        private void btnGırıs_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim() != "" && txtSifre.Text.Trim() != "")
            {
                if (label2.Text == "Yetkili Ad")
                {
                    YetkiGiris y = new YetkiGiris();
                    bool Sonuc = y.YoneticiGiris(txtKullaniciAdi.Text, txtSifre.Text);
                    if (Sonuc == false)
                    {
                        MessageBox.Show("Hatalı Kullanıcı adı veya şifre!");
                        txtKullaniciAdi.Focus();
                        txtSifre.Clear();
                    }
                    else
                    {
                        y.YoneticiGiris(y);
                        Genel.uyeadi = y.YoneticiAd + " " + y.YoneticiSoyad;
                        Genel.uyetipi = y.YetkiAd;
                        Genel.yoneticiid = y.YoneticiID;
                        this.Hide();
                        Yonetici yo = new Yonetici();
                        yo.ShowDialog();
                    }
                }
                else
                {
                    YetkiGiris y = new YetkiGiris();
                    bool Sonuc = y.KasiyerGiris(txtKullaniciAdi.Text, txtSifre.Text);
                    if (Sonuc == false)
                    {
                        MessageBox.Show("Hatalı Kullanıcı adı veya şifre!");
                        txtKullaniciAdi.Focus();
                        txtSifre.Clear();
                    }
                    else
                    {
                        y.KasiyerGiris(y, txtKullaniciAdi.Text, txtSifre.Text);
                        Genel.uyeadi = y.KasiyerAd + " " + y.KasiyerSoyad;
                        Genel.uyetipi = y.YetkiAd;
                        Genel.kasiyerid = y.KasiyerID;
                        this.Hide();
                        Kasiyer k = new Kasiyer();
                        k.ShowDialog();
                    }
                }
            }
            else { MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez'", "Dikkat Eksik Bilgi"); }
        }
    }
}
