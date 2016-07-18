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
    class KasiyerIslemleri
    {
        private int _kasiyerID;
        private int _kasiyerYetkiID;
        private string _kasiyerAd;
        private string _kasiyerSoyad;
        private string _tcKimlikNo;
        private DateTime _dogumTarihi;
        private string _telefon;
        private string _adres;
        private double _toplamSatis;
        private string _sifre;
        private string _eposta;
        private double _maas;
        private DateTime _gorevBaslangic;
        private DateTime _gorevBitis;

        #region Properties
        public int KasiyerID
        {
            get { return _kasiyerID; }
            set { _kasiyerID = value; }
        }
        public int KasiyerYetkiID
        {
            get { return _kasiyerYetkiID; }
            set { _kasiyerYetkiID = value; }
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
        public string TcKimlikNo
        {
            get { return _tcKimlikNo; }
            set { _tcKimlikNo = value; }
        }
        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set { _dogumTarihi = value; }
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
        public double ToplamSatis
        {
            get { return _toplamSatis; }
            set { _toplamSatis = value; }
        }
        public string Sifre
        {
            get { return _sifre; }
            set { _sifre = value; }
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

        public void KasiyerleriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Kasiyerler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["KasiyerID"].ToString());
                    liste.Items[i].SubItems.Add(dr["YetkiID"].ToString());
                    liste.Items[i].SubItems.Add(dr["KasiyerAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KasiyerSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["TCKimlikNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    liste.Items[i].SubItems.Add(dr["toplamSatis"].ToString());
                    liste.Items[i].SubItems.Add(dr["Sifre"].ToString());
                    liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                    liste.Items[i].SubItems.Add(dr["Maas"].ToString());
                    liste.Items[i].SubItems.Add(dr["GorevBaslangici"].ToString());
                    liste.Items[i].SubItems.Add(dr["GörevBitimi"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool KasiyerVarmi(string TCKimlikNo)
        {
            bool Varmi = false;
            SqlCommand comm = new SqlCommand("select Count(*) from Kasiyerler where Silindi=0 and TCKimlikNo=@TCKimlikNo", conn);
            comm.Parameters.Add("@TCKimlikNo", SqlDbType.VarChar).Value = TCKimlikNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            int Sonuc = Convert.ToInt32(comm.ExecuteScalar());
            if (Sonuc > 0)
            {
                Varmi = true;
            }
            conn.Close();
            return Varmi;
        }

        public bool KasiyerEkle(KasiyerIslemleri k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into Kasiyerler(YetkiID, KasiyerAd, KasiyerSoyad, TCKimlikNo, DogumTarihi, Telefon, Adres, Sifre, Eposta, Maas, GorevBaslangici)  values(@YetkiID, @KasiyerAd, @KasiyerSoyad, @TCKimlikNo, @DogumTarihi, @Telefon, @Adres, @Sifre, @Eposta, @Maas, @GorevBaslangici)", conn);
            comm.Parameters.Add("@YetkiID", SqlDbType.Int).Value = k._kasiyerYetkiID;
            comm.Parameters.Add("@KasiyerAd", SqlDbType.VarChar).Value = k._kasiyerAd;
            comm.Parameters.Add("@KasiyerSoyad", SqlDbType.VarChar).Value = k._kasiyerSoyad;
            comm.Parameters.Add("@TCKimlikNo", SqlDbType.VarChar).Value = k._tcKimlikNo;
            comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = k._dogumTarihi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = k._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k._adres;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = k._sifre;
            comm.Parameters.Add("@Eposta", SqlDbType.VarChar).Value = k._eposta;
            comm.Parameters.Add("@Maas", SqlDbType.Money).Value = k._maas;
            comm.Parameters.Add("@GorevBaslangici", SqlDbType.DateTime).Value = k._gorevBaslangic;
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

        public void KasiyerleriGetirByAdaGore(string AdaGore, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select * from Kasiyerler where Silindi=0 and KasiyerAd like @AdaGore + '%'", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["KasiyerID"].ToString());
                    liste.Items[i].SubItems.Add(dr["YetkiID"].ToString());
                    liste.Items[i].SubItems.Add(dr["KasiyerAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["KasiyerSoyad"].ToString());
                    liste.Items[i].SubItems.Add(dr["TCKimlikNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["DogumTarihi"].ToString());
                    liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                    liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                    liste.Items[i].SubItems.Add(dr["toplamSatis"].ToString());
                    liste.Items[i].SubItems.Add(dr["Sifre"].ToString());
                    liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                    liste.Items[i].SubItems.Add(dr["Maas"].ToString());
                    liste.Items[i].SubItems.Add(dr["GorevBaslangici"].ToString());
                    liste.Items[i].SubItems.Add(dr["GörevBitimi"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }

        public bool KasiyerGuncelle(KasiyerIslemleri k)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Kasiyerler set  YetkiID=@YetkiID, KasiyerAd=@KasiyerAd, KasiyerSoyad=@KasiyerSoyad, TCKimlikNo=@TCKimlikNo, DogumTarihi=@DogumTarihi, Telefon=@Telefon, Adres=@Adres, Sifre=@Sifre, Eposta=@Eposta, Maas=@Maas, GorevBaslangici=@GorevBaslangici  where KasiyerID=@KasiyerID", conn);

            comm.Parameters.Add("@YetkiID", SqlDbType.Int).Value = k._kasiyerYetkiID;
            comm.Parameters.Add("@KasiyerAd", SqlDbType.VarChar).Value = k._kasiyerAd;
            comm.Parameters.Add("@KasiyerSoyad", SqlDbType.VarChar).Value = k._kasiyerSoyad;
            comm.Parameters.Add("@TCKimlikNo", SqlDbType.VarChar).Value = k._tcKimlikNo;
            comm.Parameters.Add("@DogumTarihi", SqlDbType.DateTime).Value = k._dogumTarihi;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = k._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = k._adres;
            comm.Parameters.Add("@Sifre", SqlDbType.VarChar).Value = k._sifre;
            comm.Parameters.Add("@Eposta", SqlDbType.VarChar).Value = k._eposta;
            comm.Parameters.Add("@Maas", SqlDbType.Money).Value = k._maas;
            comm.Parameters.Add("@GorevBaslangici", SqlDbType.DateTime).Value = k._gorevBaslangic;
            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = k._kasiyerID; ;
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

        public bool KasiyerSil(int KasiyerID)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Kasiyerler set Silindi=1 where KasiyerID=@KasiyerID", conn);
            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = KasiyerID;
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

        public bool KasiyerVarmiTc(string Tc, int KasiyerID)
        {

            SqlCommand comm = new SqlCommand("select Count(*) from Kasiyerler where Silindi=0 and TCKimlikNo=@TCKimlikNo and KasiyerID!=@KasiyerID", conn);

            comm.Parameters.Add("@TCKimlikNo", SqlDbType.VarChar).Value = Tc;
            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = KasiyerID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteScalar());

            conn.Close();
            return Sonuc;
        }

        public void KasiyerSatisToplamaEkle(int KasiyerID, double ToplamTutar, DateTime Tarih)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("insert into KasiyerHareketler(KasiyerID,GunlukSatis,Tarih) values (@KasiyerID,@ToplamTutar,@Tarih)", conn);//bura bitti...

            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = KasiyerID;
            comm.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = ToplamTutar;
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Tarih;
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

        public void KasiyereToplamSatisEkle(int KasiyerID, double ToplamTutar)
        {
            bool Sonuc = false;
            SqlCommand comm = new SqlCommand("update Kasiyerler set ToplamSatis=ToplamSatis + @ToplamTutar where KasiyerID=@KasiyerID", conn);//bura bitti...

            comm.Parameters.Add("@KasiyerID", SqlDbType.Int).Value = KasiyerID;
            comm.Parameters.Add("@ToplamTutar", SqlDbType.Money).Value = ToplamTutar;
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
        public void KasiyerleriGetirBySatis(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select KasiyerHareketID,Convert(Date,Tarih,104) as Tarih,kh.KasiyerID, KasiyerAd,KasiyerSoyad,Telefon,Eposta,GunlukSatis from KasiyerHareketler kh inner join Kasiyerler k on kh.KasiyerID=k.KasiyerID where kh.Silindi=0 order by Tarih desc", conn);
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
                        liste.Items.Add(dr["KasiyerHareketID"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerID"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerSoyad"].ToString());
                        liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                        liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                        liste.Items[i].SubItems.Add(dr["GunlukSatis"].ToString());
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

        public void KasiyerleriGetirBySatisTarihlerArasi(DateTime IlkTarih, DateTime SonTarih, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select KasiyerHareketID,Convert(Date,Tarih,104) as Tarih,kh.KasiyerID, KasiyerAd,KasiyerSoyad,Telefon,Eposta,GunlukSatis from KasiyerHareketler kh inner join Kasiyerler k on kh.KasiyerID=k.KasiyerID where kh.Silindi=0 and Convert(Date,Tarih,104) Between Convert(Date,@Tarih1,104) and Convert(Date,@Tarih2,104) order by Tarih desc", conn);

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
                        liste.Items.Add(dr["KasiyerHareketID"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerID"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["KasiyerSoyad"].ToString());
                        liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                        liste.Items[i].SubItems.Add(dr["Eposta"].ToString());
                        liste.Items[i].SubItems.Add(dr["GunlukSatis"].ToString());
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
        public void KasiyerToplamSatisGoster(DateTime IlkTarih, DateTime SonTarih, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select KasiyerAd, KasiyerSoyad, sum(GunlukSatis) from KasiyerHareketler inner join Kasiyerler on KasiyerHareketler.KasiyerID=Kasiyerler.KasiyerID where KasiyerHareketler.Silindi=0 and CONVERT(varchar(20),Tarih,104) between CONVERT(varchar(20),@Tarih1,104) and CONVERT(varchar(20),@Tarih2,104) group by KasiyerAd,KasiyerSoyad", conn);
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
                        liste.Items.Add(dr[0].ToString());
                        liste.Items[i].SubItems.Add(dr[1].ToString());
                        liste.Items[i].SubItems.Add(dr[2].ToString());
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

        public void FirmalarıGetir(ListView liste)//Buraya yazdım ben ****************
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select FirmaNo,Unvan,Telefon,Bakiye from Firmalar  where Silindi=0", conn);
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
                        liste.Items.Add(dr["FirmaNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["Unvan"].ToString());
                        liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                        liste.Items[i].SubItems.Add(dr["Bakiye"].ToString());
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
        public void FirmalarıGetirBySatisTarihlerArasi(DateTime İlktarih, DateTime Sontarih, int FirmaNo, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select HareketID,Tarih,FirmaNo,Belge,Bakiye from FirmaHareketler  where Silindi=0 and FirmaNo=@FirmaNo and Convert(Date,Tarih,104) Between Convert(Date,@Tarih1,104) AND Convert(Date,@Tarih2,104)", conn);
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = İlktarih;
            comm.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Sontarih;
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
                        liste.Items.Add(dr["HareketID"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["FirmaNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["Belge"].ToString());
                        liste.Items[i].SubItems.Add(dr["Bakiye"].ToString());
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

        public void MusterileriGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select MusteriID,MusteriAd,Telefon,ToplamAlisveris from Musteriler  where Silindi=0", conn);
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
                        liste.Items.Add(dr["MusteriID"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                        liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                        liste.Items[i].SubItems.Add(dr["ToplamAlisveris"].ToString());
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

        public void MusterileriGetirBySatisTarihlerArasi(DateTime İlktarih, DateTime Sontarih, int FirmaNo, ListView liste)//*****Musteri hareketler olmadığı için bekliyor 
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select HareketID,Tarih,FirmaNo,Belge,Bakiye from FirmaHareketler  where Silindi=0 and FirmaNo=@FirmaNo and Tarih Between Convert(Date,@Tarih1,104) AND Convert(Date,@Tarih2,104)", conn);
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = İlktarih;
            comm.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Sontarih;
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
                        liste.Items.Add(dr["HareketID"].ToString());
                        liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                        liste.Items[i].SubItems.Add(dr["FirmaNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["Belge"].ToString());
                        liste.Items[i].SubItems.Add(dr["Bakiye"].ToString());
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
        public void MusteriGetirDetaylıSatıs(int AdaGore, DateTime İlktarih, DateTime Sontarih, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select Urunler.UrunBarkodNo,uh.MusteriID, m.MusteriAd, MusreriSoyad,UrunAd,Tarih,uh.Miktar,uh.BirimFiyat,ToplamTutar from UrunHareketler uh inner join Musteriler m on uh.MusteriID=m.MusteriID inner join Urunler on Urunler.UrunID=uh.UrunID where uh.Silindi=0 and m.MusteriID =@AdaGore and Tarih Between Convert(Date,@Tarih1,104) AND Convert(Date,@Tarih2,104)", conn);
            comm.Parameters.Add("@AdaGore", SqlDbType.Int).Value = AdaGore;
            comm.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = İlktarih;
            comm.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Sontarih;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr;
            try
            {
                dr = comm.ExecuteReader();
                int i = 0;
                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        liste.Items.Add(dr["UrunBarkodNo"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriID"].ToString());
                        liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString() + " " + dr["MusreriSoyad"].ToString());
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
        public void UrunleriGetirByFirmalaraGore(int kategoriID, ListView liste)
        {
            liste.Items.Clear();
            SqlCommand comm = new SqlCommand("select UrunBarkodNo,UrunAd,Miktar,AlisFiyati,KritikSeviye,UrunID from Urunler where Urunler.Silindi=0 and KategoriId=@KategoriID", conn);
            comm.Parameters.Add("@KategoriID", SqlDbType.Int).Value = kategoriID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    liste.Items.Add(dr["UrunBarkodNo"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunAd"].ToString());
                    liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                    liste.Items[i].SubItems.Add(dr["AlisFiyati"].ToString());
                    liste.Items[i].SubItems.Add(dr["KritikSeviye"].ToString());
                    liste.Items[i].SubItems.Add(dr["UrunID"].ToString());
                    i++;
                }
                dr.Close();
            }
            conn.Close();
        }
        public void FirmaByMalKabul(int FirmaNo, string Belge, int Bakiye, int UrunID)//Firma Hareketlere Ekleme
        {
            SqlCommand comm = new SqlCommand("insert into FirmaHareketler(Tarih,IslemTuru,FirmaNo,Belge,Bakiye,KasaHareketID,UrunHareketID) values (@Tarih,@IslemTuru,@FirmaNo,@Belge,@Bakiye,@KasaHareketID,@UrunHareketID)", conn);

            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = Convert.ToDateTime(DateTime.Now);
            comm.Parameters.Add("@IslemTuru", SqlDbType.VarChar).Value = "Alıs";
            comm.Parameters.Add("@FirmaNo", SqlDbType.Int).Value = FirmaNo;
            comm.Parameters.Add("@Belge", SqlDbType.VarChar).Value = Belge;
            comm.Parameters.Add("@Bakiye", SqlDbType.Money).Value = Bakiye;
            comm.Parameters.Add("@KasaHareketID", SqlDbType.Int).Value = 1;
            comm.Parameters.Add("@UrunHareketID", SqlDbType.Int).Value = UrunID;
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
        public SqlDbType sqlDbType { get; set; }
    }

}
