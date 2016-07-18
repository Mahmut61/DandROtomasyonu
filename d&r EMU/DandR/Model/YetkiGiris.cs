using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DandR.Model
{
    class YetkiGiris
    {
        private int _yoneticiID;
        private int _kasiyerID;
        private int _yetkiID;
        private string _yetkiAd;
        private string _yoneticiAd;
        private string _yoneticiSoyad;
        private string _kasiyerAd;
        private string _kasiyerSoyad;
        private int _tCKNo;
        private DateTime _tarih;
        private string _sifre;
        private string _telefon;
        private string _adres;
        private string _eposta;
        private double _maas;
        private double _toplamSatis;
        private DateTime _gorevBaslangic;
        private DateTime _gorevBitis;

        #region Properties
        public int YoneticiID
        {
            get { return _yoneticiID; }
            set { _yoneticiID = value; }
        }
        public int KasiyerID
        {
            get { return _kasiyerID; }
            set { _kasiyerID = value; }
        }
        public int YetkiID
        {
            get { return _yetkiID; }
            set { _yetkiID = value; }
        }
        public string YetkiAd
        {
            get { return _yetkiAd; }
            set { _yetkiAd = value; }
        }
        public string YoneticiAd
        {
            get { return _yoneticiAd; }
            set { _yoneticiAd = value; }
        }
        public string YoneticiSoyad
        {
            get { return _yoneticiSoyad; }
            set { _yoneticiSoyad = value; }
        }
        public string KasiyerAd
        {
            get { return _kasiyerAd; }
            set { _kasiyerAd = value; }
        }
        public string KasiyerSoyad
        {
            get { return _kasiyerSoyad; }
            set { _kasiyerSoyad = value; }
        }
        public int TCKNo
        {
            get { return _tCKNo; }
            set { _tCKNo = value; }
        }
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public string Eposta
        {
            get { return _eposta; }
            set { _eposta = value; }
        }
        public double Maas
        {
            get { return _maas; }
            set { _maas = value; }
        }
        public double ToplamSatis
        {
            get { return _toplamSatis; }
            set { _toplamSatis = value; }
        }
        public DateTime GorevBaslangic
        {
            get { return _gorevBaslangic; }
            set { _gorevBaslangic = value; }
        }
        public DateTime GorevBitis
        {
            get { return _gorevBitis; }
            set { _gorevBitis = value; }
        }
        
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public bool YoneticiGiris(string KullaniciAd,string KullaniciSifre)
        {
            bool GirdiMi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Yoneticiler where Silindi=0 and YoneticiAd=@YoneticiAd and Sifre=@Sifre", conn);
            comm.Parameters.Add("@YoneticiAd", SqlDbType.VarChar).Value = KullaniciAd;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = KullaniciSifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                GirdiMi = true;
            }
            conn.Close();
            return GirdiMi;
        }
        public void YoneticiGiris(YetkiGiris y)
        {
            SqlCommand comm = new SqlCommand("select YoneticiID,YoneticiAd,YoneticiSoyad,YetkiAd from Yoneticiler inner join Yetkiler on Yoneticiler.YetkiID=Yetkiler.YetkiID where Silindi=0", conn);
             if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        y._yetkiAd=dr["YetkiAd"].ToString();
                        y._yoneticiAd=dr["YoneticiAd"].ToString();
                        y._yoneticiSoyad = dr["YoneticiSoyad"].ToString();
                        y._yoneticiID = Convert.ToInt32(dr["YoneticiID"].ToString());
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
        public bool KasiyerGiris(string KullaniciAd, string KullaniciSifre)
        {
            bool GirdiMi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Kasiyerler where Silindi=0 and KasiyerAd=@KasiyerAd and Sifre=@Sifre", conn);
            comm.Parameters.Add("@KasiyerAd", SqlDbType.VarChar).Value = KullaniciAd;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = KullaniciSifre;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                GirdiMi = true;
            }
            conn.Close();
            return GirdiMi;
        }
        public void KasiyerGiris(YetkiGiris y, string KullaniciAd, string KullaniciSifre)
        {
            SqlCommand comm = new SqlCommand("select KasiyerID,KasiyerAd,KasiyerSoyad,YetkiAd,Sifre from Kasiyerler inner join Yetkiler on Kasiyerler.YetkiID=Yetkiler.YetkiID where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        y._yetkiAd = dr["YetkiAd"].ToString();
                        y._kasiyerAd = dr["KasiyerAd"].ToString();
                        y._kasiyerSoyad= dr["KasiyerSoyad"].ToString();
                        y._kasiyerID = Convert.ToInt32(dr["KasiyerID"].ToString());
                        if (KullaniciSifre==dr["Sifre"].ToString() && KullaniciAd==dr["KasiyerAd"].ToString())
                        {
                            break;
                        }
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
    }
}
