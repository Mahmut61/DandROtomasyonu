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
    public partial class MusteriSatisSorgulama : Form
    {
        public MusteriSatisSorgulama()
        {
            InitializeComponent();
        }
        UrunSatislar us = new UrunSatislar();
        int TAdet;
        double TTutar;
        private void btnGetir_Click(object sender, EventArgs e)
        {
           
            us.SatislariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value,lvMusteriler);

            TAdet = 0;
            TTutar = 0;
            for (int i = 0; i < lvMusteriler.Items.Count; i++)
            {
                TAdet += Convert.ToInt32(lvMusteriler.Items[i].SubItems[8].Text);
                TTutar += Convert.ToDouble(lvMusteriler.Items[i].SubItems[10].Text);
            }

            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }

        private void MusteriSatisSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 250;
            
            us.SatislariGetir(lvMusteriler);
            us.SatislariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value, lvMusteriler);

            TAdet = 0;
            TTutar = 0;
            for (int i = 0; i < lvMusteriler.Items.Count; i++)
            {
                TAdet += Convert.ToInt32(lvMusteriler.Items[i].SubItems[8].Text);
                TTutar += Convert.ToDouble(lvMusteriler.Items[i].SubItems[10].Text);
            }

            txtToplamAdet.Text = TAdet.ToString();
            txtToplamTutar.Text = TTutar.ToString();
        }

        private void txtBarkodaGore_TextChanged(object sender, EventArgs e)
        {
            us.MusterileriGetirBySatisSorgulama
(txtBarkodaGore.Text,txtAdaGore.Text, txtSoyadaGore.Text,txtUrunAdaGore.Text, lvMusteriler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            us.MusterileriGetirBySatisSorgulama
(txtBarkodaGore.Text, txtAdaGore.Text, txtSoyadaGore.Text, txtUrunAdaGore.Text, lvMusteriler);
        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {
            us.MusterileriGetirBySatisSorgulama
(txtBarkodaGore.Text, txtAdaGore.Text, txtSoyadaGore.Text, txtUrunAdaGore.Text, lvMusteriler);
        }

        private void txtUrunAdaGore_TextChanged(object sender, EventArgs e)
        {
            us.MusterileriGetirBySatisSorgulama
(txtBarkodaGore.Text, txtAdaGore.Text, txtSoyadaGore.Text, txtUrunAdaGore.Text, lvMusteriler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
