﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DandR.Model
{
    class Kategoriler
    {
        private int _kategoriNo;
        private string _kategoriAd;
        private string _aciklama;

        #region Properties
         public int KategoriNo
        {
            get { return _kategoriNo; }
            set { _kategoriNo = value; }
        }
        public string KategoriAd
        {
            get { return _kategoriAd; }
            set { _kategoriAd = value; }
        }
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void KategorileriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Kategoriler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Kategoriler k = new Kategoriler();
                    k._kategoriNo = Convert.ToInt32(dr["KategoriID"]);
                    k._kategoriAd = dr["KategoriAd"].ToString();
                    liste.Items.Add(k);
                }
                dr.Close();
            }
            conn.Close();
        }
        public override string ToString()
        {
            return _kategoriAd;
        }
    }
}
