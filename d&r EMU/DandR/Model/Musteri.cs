using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace DandR.Model
{
    class Musteri
    {
        private int _musteriNo;
        private int _musteriYetkiID;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private DateTime _dogumTarihi;
        private string _eposta;
        private string _adres;
        private double _toplamAlisveris;


        #region Properties
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }
        public int MusteriYetkiID
        {
            get { return _musteriYetkiID; }
            set { _musteriYetkiID = value; }
        }
        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }
        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }
        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
        }
        public string Eposta
        {
            get { return _eposta; }
            set { _eposta = value; }
        }
        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public double ToplamAlisveris
        {
            get { return _toplamAlisveris; }
            set { _toplamAlisveris = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["MusteriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["YetkiID"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
                    liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    liste.Items[i].SubItems.Add(dr["ToplamAlisveris"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public bool MusteriVarmi(string Adi, string Soyadi, string Telefon)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Musteriler where Silindi=0 and MusteriAd=@Ad and MusreriSoyad=@Soyad and Telefon=@Telefon", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = Adi;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = Soyadi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }
        public bool MusteriEkle(Musteri m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Musteriler(YetkiID,MusteriAd,MusreriSoyad,DogumTarihi,Telefon,Adres,Eposta)  values(@YetkiID,@MusteriAd,@MusreriSoyad,@DogumTarihi,@Telefon,@Adres,@Eposta)", conn);
            comm.Parameters.Add("@YetkiID", SqlDbType.Int).Value = m._musteriYetkiID;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusreriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            comm.Parameters.Add("@Eposta", SqlDbType.VarChar).Value = m._eposta;
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
            return Sonuc;
        }
        public void MusterileriGetirByAdaGore(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0 and MusteriAd like @AdaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["MusteriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["YetkiID"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
                    liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    liste.Items[i].SubItems.Add(dr["ToplamAlisveris"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public bool MusteriGuncelle(Musteri m)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set YetkiID=@YetkiID,MusteriAd=@MusteriAd,MusreriSoyad=@MusreriSoyad,Telefon=@Telefon,DogumTarihi=@DogumTarihi,Eposta=@Eposta,Adres=@Adres where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@YetkiID", SqlDbType.Int).Value = m._musteriYetkiID;
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@MusreriSoyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = m._dogumTarihi;
            comm.Parameters.Add("@Eposta", SqlDbType.VarChar).Value = m._eposta;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = m._musteriNo;
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
            return Sonuc;
        }
        public bool MusteriSil(int MusteriID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Musteriler set Silindi=1 where MusteriID=@MusteriID", conn);
            comm.Parameters.Add("@MusteriID", SqlDbType.Int).Value = MusteriID;
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
            return Sonuc;
        }
        public void MusterileriGetirBySorgulama(string AdaGore, string SoyadaGore, string TelefonaGore, string AdreseGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0 and MusteriAd like @AdaGore + '%' and MusreriSoyad like @SoyadaGore + '%' and Telefon like  @TelefonaGore + '%' and Adres like + '%' +  @AdreseGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@SoyadaGore", SqlDbType.VarChar).Value = SoyadaGore;
            comm.Parameters.Add("@TelefonaGore", SqlDbType.VarChar).Value = TelefonaGore;
            comm.Parameters.Add("@AdreseGore", SqlDbType.VarChar).Value = AdreseGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["MusteriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["YetkiID"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["MusreriSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
                    liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    liste.Items[i].SubItems.Add(dr["ToplamAlisveris"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
    }
}
