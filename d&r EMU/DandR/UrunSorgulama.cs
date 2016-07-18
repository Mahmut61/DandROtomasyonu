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
    public partial class UrunSorgulama : Form
    {
        public UrunSorgulama()
        {
            InitializeComponent();
        }

        private void UrunSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left =250;
            Urun u = new Urun();
            u.UrunleriGetir(lvUrunler);
            Kategoriler k = new Kategoriler();
            k.KategorileriGetir(cbKategoriler);

            cbKategoriler.Items.Insert(0, "Tüm Türler");
            cbKategoriler.SelectedIndex = 0;
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
           
                UrunleriGetir();
           
        }

        private void txtUrunAd_TextChanged(object sender, EventArgs e)
        {
           
                 UrunleriGetir();
           
           
        }

        private void cbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                UrunleriGetir();
           
            
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
    }
}
