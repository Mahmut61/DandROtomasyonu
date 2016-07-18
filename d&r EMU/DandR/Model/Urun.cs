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
    class Urun
    {
        private int _urunID;
        private string _urunBarkodNo;
        private string _urunAd;
        private int _kategoriID;
        private string _aciklama;
        private string _tur;
        private string _yasGrubu;
        private int _miktar;
        private decimal _birimfiyat;
        private int _alisfiyat;
        private int _kritikSeviye;
        private string _ozet;
        private string _yazar;

        #region Properties
        public int UrunID
        {
            get { return _urunID; }
            set { _urunID = value; }
        }
        public string UrunBarkodNo
        {
            get { return _urunBarkodNo; }
            set { _urunBarkodNo = value; }
        }
        public string UrunAd
        {
            get { return _urunAd; }
            set { _urunAd = value; }
        }
        public int KategoriID
        {
            get { return _kategoriID; }
            set { _kategoriID = value; }
        }
        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        }
        public string Tur
        {
            get { return _tur; }
            set { _tur = value; }
        }
        public string YasGrubu
        {
            get { return _yasGrubu; }
            set { _yasGrubu = value; }
        }
        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }
        public decimal Birimfiyat
        {
            get { return _birimfiyat; }
            set { _birimfiyat = value; }
        }
        public int Alisfiyat
        {
            get { return _alisfiyat; }
            set { _alisfiyat = value; }
        }
        public int KritikSeviye
        {
            get { return _kritikSeviye; }
            set { _kritikSeviye = value; }
        }
        public string Ozet
        {
            get { return _ozet; }
            set { _ozet = value; }
        }
        public string Yazar
        {
            get { return _yazar; }
            set { _yazar = value; }
        }
        #endregion

        SqlConnection conn = new SqlConnection(Genel.connStr);

        public void UrunTurleriGetir(ComboBox liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Urunler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    liste.Items.Add(dr["Tür"].ToString());
                }
                dr.Close();
            }
            conn.Close();
        }
        public void UrunleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID,UrunBarkodNo,UrunAd,KategoriAd,Urunler.Aciklama,Tür,YasGrubu,Miktar,BirimFiyat,AlisFiyati,KritikSeviye,Ozet,Yazar,Urunler.KategoriID from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Varmi=1 and Urunler.Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    liste.Items[i].SubItems.Add(dr["Tür"].ToString());
                    liste.Items[i].SubItems.Add(dr["YasGrubu"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["AlisFiyati"].ToString());
                    liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yazar"].ToString());

                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public void UrunleriGetirByBarkodaGore(string BarkodaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID,UrunBarkodNo,UrunAd,KategoriAd,Urunler.Aciklama,Tür,YasGrubu,Miktar,BirimFiyat,AlisFiyati,KritikSeviye,Ozet,Yazar,Urunler.KategoriID from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Varmi=1 and Urunler.Silindi=0 and UrunBarkodNo like @BarkodaGore + '%'", conn);
            comm.Parameters.Add("@BarkodaGore", SqlDbType.VarChar).Value = BarkodaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    liste.Items[i].SubItems.Add(dr["Tür"].ToString());
                    liste.Items[i].SubItems.Add(dr["YasGrubu"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["AlisFiyati"].ToString());
                    liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yazar"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool UrunVarmi(string UrunBarkodNo, string UrunAd)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Urunler where Varmi=1 and Silindi=0 and UrunAd=@UrunAd and UrunBarkodNo=@UrunBarkodNo", conn);
            comm.Parameters.Add("@UrunBarkodNo", SqlDbType.VarChar).Value = UrunBarkodNo;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }

        public bool UrunVarmi(string UrunBarkodNo, string UrunAd, string UrunID)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Urunler where Varmi=1 and Silindi=0 and UrunAd=@UrunAd and UrunBarkodNo=@UrunBarkodNo and UrunID!=@UrunID", conn);
            comm.Parameters.Add("@UrunBarkodNo", SqlDbType.VarChar).Value = UrunBarkodNo;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = UrunAd;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = Convert.ToInt32(UrunID);
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sayisi = Convert.ToInt32(comm.ExecuteScalar());
            if (Sayisi > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }
        public bool UrunEkle(Urun u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Urunler(UrunBarkodNo,UrunAd,KategoriID,Aciklama,Tür,YasGrubu,Miktar,BirimFiyat,AlisFiyati,KritikSeviye,Ozet,Yazar)  values(@UrunBarkodNo,@UrunAd,@KategoriID,@Aciklama,@Tür,@YasGrubu,@Miktar,@BirimFiyat,@AlisFiyati,@KritikSeviye,@Ozet,@Yazar)", conn);
            comm.Parameters.Add("@UrunBarkodNo", SqlDbType.VarChar).Value = u._urunBarkodNo;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = u._kategoriID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
            comm.Parameters.Add("@Tür", SqlDbType.VarChar).Value = u._tur;
            comm.Parameters.Add("@YasGrubu", SqlDbType.VarChar).Value = u._yasGrubu;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = u._birimfiyat;
            comm.Parameters.Add("@AlisFiyati", SqlDbType.Int).Value = u._alisfiyat;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = u._ozet;
            comm.Parameters.Add("@Yazar", SqlDbType.VarChar).Value = u._yazar;
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
        public bool UrunGuncelle(Urun u)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Urunler set UrunBarkodNo=@UrunBarkodNo,UrunAd=@UrunAd,KategoriID=@KategoriID,Aciklama=@Aciklama,Tür=@Tür,YasGrubu=@YasGrubu,Miktar=@Miktar,BirimFiyat=@BirimFiyat,AlisFiyati=@AlisFiyati,KritikSeviye=@KritikSeviye,Ozet=@Ozet,Yazar=@Yazar where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunBarkodNo", SqlDbType.VarChar).Value = u._urunBarkodNo;
            comm.Parameters.Add("@UrunAd", SqlDbType.VarChar).Value = u._urunAd;
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = u._kategoriID;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = u._aciklama;
            comm.Parameters.Add("@Tür", SqlDbType.VarChar).Value = u._tur;
            comm.Parameters.Add("@YasGrubu", SqlDbType.VarChar).Value = u._yasGrubu;
            comm.Parameters.Add("@Miktar", SqlDbType.Int).Value = u._miktar;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = u._birimfiyat;
            comm.Parameters.Add("@AlisFiyati", SqlDbType.Int).Value = u._alisfiyat;
            comm.Parameters.Add("@KritikSeviye", SqlDbType.Int).Value = u._kritikSeviye;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = u._ozet;
            comm.Parameters.Add("@Yazar", SqlDbType.VarChar).Value = u._yazar;
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = u._urunID;
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
        public bool UrunSil(int UrunID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Urunler set Varmi=0, Silindi=1 where UrunID=@UrunID", conn);
            comm.Parameters.Add("@UrunID", SqlDbType.Int).Value = UrunID;
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

        public void UrunleriGetirByDetaySorgulama(string BarkodaGore, string AdaGore, string KategoriyeGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID,UrunBarkodNo,UrunAd,KategoriAd,Urunler.Aciklama,Tür,YasGrubu,Miktar,BirimFiyat,KritikSeviye,Ozet,Yazar,Urunler.KategoriID from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Varmi=1 and Urunler.Silindi=0 and UrunBarkodNo like @BarkodaGore + '%' and UrunAd like '%' +  @AdaGore + '%' and KategoriAd like @KategoriyeGore + '%'", conn);
            comm.Parameters.Add("@BarkodaGore", SqlDbType.VarChar).Value = BarkodaGore;
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            comm.Parameters.Add("@KategoriyeGore", SqlDbType.VarChar).Value = KategoriyeGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    liste.Items[i].SubItems.Add(dr["Tür"].ToString());
                    liste.Items[i].SubItems.Add(dr["YasGrubu"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yazar"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public void UrunleriGetirByDetaySorgulama2(string KategoriyeGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunID,UrunBarkodNo,UrunAd,KategoriAd,Urunler.Aciklama,Tür,YasGrubu,Miktar,BirimFiyat,KritikSeviye,Ozet,Yazar,Urunler.KategoriID from Urunler inner join Kategoriler on Urunler.KategoriID=Kategoriler.KategoriID where Varmi=1 and Urunler.Silindi=0 and KategoriAd=@KateAd", conn);
            comm.Parameters.Add("@KateAd", SqlDbType.VarChar).Value = KategoriyeGore;

            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunID"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunBarkodNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                    liste.Items[i].SubItems.Add(dr["Tür"].ToString());
                    liste.Items[i].SubItems.Add(dr["YasGrubu"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                    liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    liste.Items[i].SubItems.Add(dr["KategoriID"].ToString());
                    liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                    liste.Items[i].SubItems.Add(dr["Yazar"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
    }
}
