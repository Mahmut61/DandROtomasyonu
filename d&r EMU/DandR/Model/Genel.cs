using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandR.Model
{
    class Genel
    {

        //public static string connStr = "Data Source=.;Initial Catalog=D&R;Integrated Security=True";
        //Mahmut
        public static string connStr = "Data Source=WISSEN43\\MSSQLYAZ8; Initial Catalog=D&R; uid=sa; pwd=123458";
        //public static string connStr = "Data Source=Pc; Initial Catalog=D&R; uid=sa; pwd=61";
        //umut
        //public static string connStr = "Data Source= WISSEN193\\MS_SQL_YAZ_8; Initial Catalog=D&R; uid=sa; pwd=123458";
       // public static string connStr = "Data Source= UMUT\\UMUT; Initial Catalog=D&R; uid=sa; pwd=1905";
        public static string uyetipi;
        public static string uyeadi;
        public static int yoneticiid;
        public static int kasiyerid;

        public static int musterino;
        public static string musteri;
        public static double  toplamharcama;
        public static int urunno;
        public static string urun;
        public static int stok;
        public static double fiyat;
        public static string caritipi;

        public static int KasaToplam;
    }
}
