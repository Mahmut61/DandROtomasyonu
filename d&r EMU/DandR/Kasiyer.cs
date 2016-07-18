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
    public partial class Kasiyer : Form
    {
        public Kasiyer()
        {
            InitializeComponent();
        }

        bool acıkmı = false;
        private void Kasiyer_Load(object sender, EventArgs e)
        {
            slblKullanici.Text = Genel.uyeadi;
            slblYetki.Text = Genel.uyetipi;
            slblDate.Text = DateTime.Now.ToShortDateString();
            

        }
        private void FormAcikMi(Form AcilacakForm)//Peş Peşe form açmaması için yazdık.
        {

            for (int i = 0; i < this.MdiChildren.Count(); i++)
            {
                if (AcilacakForm.Name == this.MdiChildren[i].Name)
                {
                    this.MdiChildren[i].Focus();
                    acıkmı = false;
                }
            }
            if (acıkmı == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else { AcilacakForm.Dispose(); }
        }

        private void tsMusteri_Click(object sender, EventArgs e)
        {

            Musteriler m = new Musteriler();
            m.ShowDialog();
        }

        private void tsMusteriSorgulama_Click(object sender, EventArgs e)
        {

            MusteriSorgulama frm = new MusteriSorgulama();
            frm.ShowDialog();
        }

        private void tsUrun_Click(object sender, EventArgs e)
        {

            Urunler frm = new Urunler();
            frm.ShowDialog();
        }

        private void tsUrunSorgulama_Click(object sender, EventArgs e)
        {

            UrunSorgulama frm = new UrunSorgulama();
            frm.ShowDialog();
        }

        private void tsUrunSatis_Click(object sender, EventArgs e)
        {

            UrunSatis frm = new UrunSatis();
            frm.ShowDialog();
        }

        private void tsCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void slblMesaj_Click(object sender, EventArgs e)
        {

            Notlar nt = new Notlar();
            nt.ShowDialog();
        }
            

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog crPencere = new ColorDialog();
            crPencere.ShowDialog();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            MusteriSatisSorgulama frm = new MusteriSatisSorgulama();
            frm.ShowDialog();
        }
    }
}
