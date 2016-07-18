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
    public partial class MusteriSorgulama : Form
    {
        public MusteriSorgulama()
        {
            InitializeComponent();
        }
        Musteri m = new Musteri();
        private void MusteriSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 250;
           m.MusterileriGetir(lvMusteriler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama
(txtAdaGore.Text, txtSoyadaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtSoyadaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama
(txtAdaGore.Text, txtSoyadaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtTelefonaGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama
(txtAdaGore.Text, txtSoyadaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void txtAdreseGore_TextChanged(object sender, EventArgs e)
        {
            m.MusterileriGetirBySorgulama
(txtAdaGore.Text, txtSoyadaGore.Text, txtTelefonaGore.Text, txtAdreseGore.Text, lvMusteriler);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            Genel.musterino=Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
            Genel.musteri = lvMusteriler.SelectedItems[0].SubItems[2].Text + " " + lvMusteriler.SelectedItems[0].SubItems[3].Text;
            Genel.toplamharcama = Convert.ToDouble(lvMusteriler.SelectedItems[0].SubItems[8].Text);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
