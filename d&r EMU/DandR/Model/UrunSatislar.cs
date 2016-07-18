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
    class UrunSatislar
    {
        private int _satisID;
        private int _urunID;
        private int _musteriID;
        private int _kasiterID;
        private string _islemTuru;
        private DateTime _tarih;
        private int _miktar;
        private double _birimFiyat;
        private double _toplamTutar;


        #region Properties
        public int SatisID
        {
            get { return _satisID; }
            set { _satisID = value; }
        }
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }
        public int MusteriID
        {
            get { return _musteriID; }
            set { _musteriID = value; }
        }
        public int KasiterID
        {
            get { return _kasiterID; }
            set { _kasiterID = value; }
        }
        public string IslemTuru
        {
            get { return _islemTuru; }
            set { _islemTuru = value; }
        }
        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }
        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }
        public double BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        }
        public double ToplamTutar
        {
            get { return _toplamTutar; }
            set { _toplamTutar = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);
        public void SatısYapıldıStokGüncelle(int Urunıd, int miktar)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Urunler set  Miktar=Miktar-@Miktar  where UrunID=@UrunID", conn);//bura bitti...

            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = miktar;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = Urunıd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
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
        public void FirmaSatısYapıldıStokGüncelle(int Urunid, int miktar)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Urunler set  Miktar=Miktar+@Miktar  where UrunID=@UrunID", conn);//bura bitti...

            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = miktar;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = Urunid;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
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
        public void SatisEkle(UrunSatislar us)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into UrunHareketler(UrunID,MusteriID,KasiyerID,IslemTuru,Tarih,Miktar,BirimFiyat,ToplamTutar)  values(@UrunID,@MusteriID,@KasiyerID,@IslemTuru,@Tarih,@Miktar,@BirimFiyat,@ToplamTutar)", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = us._urunID;
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = us._musteriID;
            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = us._kasiterID;
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = us._islemTuru;
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = us._tarih;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = us._miktar;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = us._birimFiyat;
            comm.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = us._toplamTutar;
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

        public void MusteriToplamAlisveris(int MusteriID, double ToplamAlisveris)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set  ToplamAlisveris=ToplamAlisveris+@ToplamAlisveris where MusteriID=@MusteriID and Silindi=0", conn);//bura bitti...

            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = MusteriID;
            comm.Parameters.Add("@ToplamAlisveris", SqlDbType.Money).Value = ToplamAlisveris;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
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
        public void SatislariGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SatisID,Convert(Date,Tarih,104) as Tarih,uh.UrunID,UrunBarkodNo,uh.MusteriID, MusteriAd, MusreriSoyad,UrunAd,uh.Miktar,uh.BirimFiyat,ToplamTutar from UrunHareketler uh inner join Musteriler m on uh.MusteriID=m.MusteriID inner join Urunler on Urunler.UrunID=uh.UrunID where uh.Silindi=0 order by Tarih desc", conn);
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
                        liste.Items.Add(dr["SatisID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriID"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                        liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["ToplamTutar"].ToString());
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
        public void SatislariGetirByTarihlerArasi(DateTime IlkTarih, DateTime SonTarih, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SatisID,Convert(Date,Tarih,104) as Tarih,uh.UrunID,UrunBarkodNo,uh.MusteriID, MusteriAd, MusreriSoyad,UrunAd,uh.Miktar,uh.BirimFiyat,ToplamTutar from UrunHareketler uh inner join Musteriler m on uh.MusteriID=m.MusteriID inner join Urunler on Urunler.UrunID=uh.UrunID where uh.Silindi=0 and Convert(Date,Tarih,104) Between Convert(Date,@Tarih1,104) and Convert(Date,@Tarih2,104) order by Tarih desc", conn);

            comm.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = IlkTarih;
            comm.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = SonTarih;

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
                        liste.Items.Add(dr["SatisID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriID"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                        liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["ToplamTutar"].ToString());
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

        public void MusterileriGetirBySatisSorgulama(string BarkodaGore, string AdaGore, string SoyadaGore, string UrunAdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select SatisID,Convert(Date,Tarih,104) as Tarih,uh.UrunID,UrunBarkodNo,uh.MusteriID, MusteriAd, MusreriSoyad,UrunAd,uh.Miktar,uh.BirimFiyat,ToplamTutar from UrunHareketler uh inner join Musteriler m on uh.MusteriID=m.MusteriID inner join Urunler on Urunler.UrunID=uh.UrunID where uh.Silindi=0 and UrunBarkodNo like @BarkodaGore + '%' and MusteriAd like + '%' + @AdaGore + '%' and MusreriSoyad like @SoyadaGore + '%' and UrunAd like + '%' + @UrunAdaGore + '%' order by Tarih desc", conn);

            comm.Parameters.Add("@BarkodaGore", SqlDbType.VarChar).Value = BarkodaGore;
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@SoyadaGore", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@UrunAdaGore", SqlDbType.VarChar).Value = UrunAdaGore;
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
                        liste.Items.Add(dr["SatisID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunID"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriID"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                        liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                        liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                        liste.Items[i].SubItems.Add(dr["ToplamTutar"].ToString());
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