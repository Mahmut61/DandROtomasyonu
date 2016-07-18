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
    public partial class KasiyerSatisSorgulama : Form
    {
        public KasiyerSatisSorgulama()
        {
            InitializeComponent();
        }
        double TTutar;
        KasiyerIslemleri ki = new KasiyerIslemleri();
        private void KasiyerSatisSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 100;
            this.Left = 250;

            ki.KasiyerleriGetirBySatis(lvKasiyerler);
            ki.KasiyerleriGetirBySatisTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value, lvKasiyerler);

            TTutar = 0;
            for (int i = 0; i < lvKasiyerler.Items.Count; i++)
            {
                TTutar += Convert.ToDouble(lvKasiyerler.Items[i].SubItems[7].Text);
            }

            txtToplamTutar.Text = TTutar.ToString();
            ki.KasiyerToplamSatisGoster(dtpIlkTarih.Value, dtpSonTarih.Value, lvKasiyerToplamSatis);
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            ki.KasiyerleriGetirBySatisTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value,lvKasiyerler);

            TTutar = 0;
            for (int i = 0; i < lvKasiyerler.Items.Count; i++)
            {
                TTutar += Convert.ToDouble(lvKasiyerler.Items[i].SubItems[7].Text);
            }
            txtToplamTutar.Text = TTutar.ToString();

            ki.KasiyerToplamSatisGoster(dtpIlkTarih.Value, dtpSonTarih.Value, lvKasiyerToplamSatis);
        }

        private void txtToplamTutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
