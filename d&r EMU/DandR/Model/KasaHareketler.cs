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
    class KasaHareketler
    {
        private int _kasaID;
        private string _kasaTuru;
        private DateTime _tarih;
        private string _islemTuru;
        private string _firmaAd;
        private string _kasiyerAd;
        private string _parabirimi;
        private string _belge;
        private double _giren;
        private double _cikan;

        #region Properties
        public int KasaID
        {
            get { return _kasaID; }
            set { _kasaID = value; }
        }
        public string KasaTuru
        {
            get { return _kasaTuru; }
            set { _kasaTuru = value; }
        }
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }
        public string FirmaAd
        {
            get { return _firmaAd; }
            set { _firmaAd = value; }
        }
        public string KasiyerAd
        {
            get { return _kasiyerAd; }
            set { _kasiyerAd = value; }
        }
        public string Parabirimi
        {
            get { return _parabirimi; }
            set { _parabirimi = value; }
        }
        public string Belge
        {
            get { return _belge; }
            set { _belge = value; }
        }
        public double Giren
        {
            get { return _giren; }
            set { _giren = value; }
        }
        public double Cikan
        {
            get { return _cikan; }
            set { _cikan = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        DataSet ds = new DataSet();

        public void KasaHarekerEkle(KasaHareketler kh)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into KasaHareketler(KasaTuru,Tarih,IslemTuru,FirmaAd,KasiyerAd,ParaBirimi,Belge,Giren,Cikan) values(@KasaTuru,@Tarih,@IslemTuru,@FirmaAd,@KasiyerAd,@ParaBirimi,@Belge,@Giren,@Cikan) ", conn);
            comm.Parameters.Add("@KasaTuru", SqlDbType.VarChar).Value = kh._kasaTuru;
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = kh._tarih;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = kh._islemTuru;
            comm.Parameters.Add("@FirmaAd", SqlDbType.VarChar).Value = kh._firmaAd;
            comm.Parameters.Add("@KasiyerAd", SqlDbType.VarChar).Value = kh._kasiyerAd;
            comm.Parameters.Add("@ParaBirimi", SqlDbType.VarChar).Value = kh._parabirimi;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = kh._belge;
            comm.Parameters.Add("@Giren", SqlDbType.Money).Value = kh._giren;
            comm.Parameters.Add("@Cikan", SqlDbType.Money).Value = kh._cikan;
            if (conn.State == ConnectionState.Closed) { conn.Open(); }
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }
        }

        public void FirmalariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Firmalar where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
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

        public void UrunleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Urunler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
                        liste.Items[i].SubItems.Add(dr[3].ToString());
                        liste.Items[i].SubItems.Add(dr[4].ToString());
                        liste.Items[i].SubItems.Add(dr[5].ToString());
                        liste.Items[i].SubItems.Add(dr[6].ToString());
                        liste.Items[i].SubItems.Add(dr[7].ToString());
                        liste.Items[i].SubItems.Add(dr[8].ToString());
                        liste.Items[i].SubItems.Add(dr[9].ToString());
                        liste.Items[i].SubItems.Add(dr[10].ToString());
                        liste.Items[i].SubItems.Add(dr[11].ToString());
                        liste.Items[i].SubItems.Add(dr[12].ToString());
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

        public string caritur = "";
        public void CariToplamlariGuncelle(int CariNo, int Tutar)
        {
            bool Sonuc = false;
            if (Genel.caritipi == "Muşteri")
            {
                SqlCommand comm = new SqlCommand("Update Musteriler Set ToplamAlisveris = ToplamAlisveris + @Tutar MusteriID=@CariNo", conn);
                comm.Parameters.Add("@Tutar", SqlDbType.Int).Value = Tutar;
                comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                finally { conn.Close(); }

            }
            else if (Genel.caritipi == "Firma")
            {
                SqlCommand comm = new SqlCommand("Update Firmalar Set ToplamBorc = ToplamBorc + @Tutar where FirmaID=@CariNo", conn);
                comm.Parameters.Add("@Tutar", SqlDbType.Int).Value = Tutar;
                comm.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
                if (conn.State == ConnectionState.Closed) conn.Open();
                try
                {
                    Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                finally { conn.Close(); }

            }
        }
        public DataSet getir(int CariNo)
        {

            if (caritur == "Müşteriler")
            {
                ds.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select * from KasaHareketler where Silindi=0 and MusteriID=@CariNo", conn);
                da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
                try
                {
                    da.Fill(ds, "Musteriler");
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                return ds;
            }
            else
            {
                ds.Clear();
                SqlDataAdapter da = new SqlDataAdapter("select * from KasaHareketler where Silindi=0 and FirmaID=@CariNo", conn);
                da.SelectCommand.Parameters.Add("@CariNo", SqlDbType.Int).Value = CariNo;
                try
                {
                    da.Fill(ds, "Firmalar");
                }
                catch (SqlException ex)
                {
                    string hata = ex.Message;
                }
                return ds;
            }
        }
        public void FirmaBakiyeGuncelle(int FirmaNo, int ToplamBakiye)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Firmalar Set Bakiye = Bakiye + @ToplamBakiye where FirmaNo=@FirmaNo", conn);
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@ToplamBakiye", SqlDbType.Money).Value = ToplamBakiye;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
        public void FirmaBakiyeGuncelleOde(int FirmaNo, double ToplamBakiye)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("Update Firmalar Set Bakiye = Bakiye - @ToplamBakiye where FirmaNo=@FirmaNo", conn);
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@ToplamBakiye", SqlDbType.Money).Value = ToplamBakiye;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally { conn.Close(); }

        }
        public void KasabyOdeme(int FirmaNo, double Bakiye)//Firma Hareketlere Ekleme
        {
            SqlCommand comm = new SqlCommand("insert into FirmaHareketler(Tarih,IslemTuru,FirmaNo,Belge,Bakiye,KasaHareketID,UrunHareketID) values (@Tarih,@IslemTuru,@FirmaNo,@Belge,@Bakiye,@KasaHareketID,@UrunHareketID)", conn);

            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(DateTime.Now);
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = "Ödeme";
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = "DNREMU123";
            comm.Parameters.Add("@Bakiye", SqlDbType.Money).Value = Bakiye;
            comm.Parameters.Add("@KasaHareketID", SqlDbType.Int).Value = 1;
            comm.Parameters.Add("@UrunHareketID", SqlDbType.Int).Value = 0;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }
        public void KasaHesapla(Label liste)
        {
            int Sonuc=0;
            SqlCommand comm = new SqlCommand("select (sum(Giren)-sum(Cikan)) as AnaKasa from KasaHareketler where Silindi=0",conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc =Convert.ToInt32( comm.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            finally
            {
                liste.Text = Sonuc.ToString();
                conn.Close();
            }
        }
    }
}
