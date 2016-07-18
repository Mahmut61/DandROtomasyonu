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
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Genel.connStr);

        private void Notlar_Load(object sender, EventArgs e)
        {
            this.Top = 400;
            this.Left = 450;
            lbNotlar.Items.Clear();
            NotCek();
            comboBox1.SelectedItem = "Kasiyer";
        }
        private void NotCek()//DateTime tarih ,ListBox liste
        {
            lbNotlar.Items.Clear();
            Notlar nt = new Notlar();
            SqlCommand Notlar = new SqlCommand("select Notlar from Notlar where YetkiID=2 and (CONVERT([varchar](20),Tarih,(104)))=(CONVERT([varchar](20),@Tarih,(104)))", conn);
            Notlar.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dtpNotTarih.Value.ToShortDateString();
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = Notlar.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        lbNotlar.Items.Add("Not" + (i + 1) + ": " + dr["Notlar"].ToString());
                        i++;
                    }
                    dr.Close();
                }
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }


        private void btnYeniNot_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();

            txtNot.Enabled = true;
            btnKaydet.Enabled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex ==0)
            {
                SqlCommand comm = new SqlCommand("insert into Notlar(YetkiID,YetkiAd,EklenenTarih,Tarih,Notlar) values(@YetkiID,@YetkiAd,@EklenenTarih,@Tarih,@Notlar)", conn);
                comm.Parameters.Add("@YetkiID", SqlDbType.VarChar).Value = "2";
                comm.Parameters.Add("@YetkiAd", SqlDbType.VarChar).Value = Genel.uyeadi;
                comm.Parameters.Add("@EklenenTarih", SqlDbType.DateTime).Value =DateTime.Now.ToShortDateString();
                comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dtpNotTarih.Value.ToShortDateString();
                comm.Parameters.Add("@Notlar", SqlDbType.VarChar).Value = txtNot.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kayıt Eklendi...");

                txtNot.Enabled = false;
                btnKaydet.Enabled = false;
            }
            else  if (comboBox1.SelectedIndex == 1)
            {
                SqlCommand comm = new SqlCommand("insert into Notlar(YetkiID,YetkiAd,EklenenTarih,Tarih,Notlar) values(@YetkiID,@YetkiAd,@EklenenTarih,@Tarih,@Notlar)", conn);
                comm.Parameters.Add("@YetkiID", SqlDbType.VarChar).Value = "1";
                comm.Parameters.Add("@YetkiAd", SqlDbType.VarChar).Value = Genel.uyeadi;
                comm.Parameters.Add("@EklenenTarih", SqlDbType.DateTime).Value = DateTime.Now.ToShortDateString();
                comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = dtpNotTarih.Value.ToShortDateString();
                comm.Parameters.Add("@Notlar", SqlDbType.VarChar).Value = txtNot.Text;
                if (conn.State == ConnectionState.Closed) conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Kayıt Eklendi...");

                txtNot.Enabled = false;
                btnKaydet.Enabled = false;
            }
        }

        private void dtpNotTarih_ValueChanged(object sender, EventArgs e)
        {
            NotCek();
        }
    }
}
