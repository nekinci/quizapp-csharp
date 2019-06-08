using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EgitimUygulamasi.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EgitimUygulamasi.Database
{
    class Select
    {
        //Bu class'ın görevi veritabanından veri çekmektir.

        private Select()
        {

        }

        public static int CalisanCekID(string kadi)
        {
            string sql = "select id from calisan where kadi = '" + kadi + "'";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            int id = -1;
            if (reader.Read())
                id = reader.GetInt32(0);
               
            _connection.Close();

            return id;
        }
        public static Ayarlar AyarCek()
        {
            Ayarlar ayar = new Ayarlar();

            string sql = "select *from ayarlar";

            _connection.Open();
            MySqlCommand cmd
                = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            ayar.GeriCekilme = reader.GetInt32(2);
            reader.Read();
            ayar.GunSayisi = reader.GetInt32(2);
            reader.Read();
            ayar.YanlisCevap = reader.GetInt32(2);
            _connection.Close();
            return ayar;
        }
        private static MySqlConnection _connection = new MySqlConnection("server=localhost;userid=root;database=egitim");

        public static List<Kategori> KategoriCek()
        {
            String sqlCommand = "select *from kategoriler";
            Kategori _kategori = new Kategori();
            List<Kategori> kategoriler = new List<Kategori>();
            try
            {
                _connection.Open();
                MySqlCommand cmdKategoriler = new MySqlCommand(sqlCommand, _connection);
                MySqlDataReader readedData = cmdKategoriler.ExecuteReader();
                while (readedData.Read())
                {
                    _kategori = new Kategori();
                    _kategori.ID = readedData.GetInt32("id");
                    _kategori.Ad = readedData.GetString("ad");
                    _kategori.Aciklama = readedData.GetString("aciklama");
                    kategoriler.Add(_kategori);
                }

                _connection.Close();
                return kategoriler;
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);

                return null;
            }

        }

        public static DataTable sorulariCek()
        {
            DataTable dt;
            dt = new DataTable();
            MySqlConnection _conn = new MySqlConnection("server=localhost;database=egitim;userid=root");
            _conn.Open();
            string sqlCommand = "select sorular.id,sorular.soruBasligi,sorular.zorlukSeviyesi,sorular.sure, kategoriler.ad, " +
                "secenekler.asecenegi,secenekler.bsecenegi, secenekler.csecenegi," +
                "secenekler.dsecenegi,secenekler.esecenegi,secenekler.dogru,medya.medya_path from " +
                "sorular inner join secenekler on sorular.id = secenekler.soru_id " +
                "inner join kategoriler on kategoriler.id = sorular.kategori_id inner join medya on medya.id = sorular.medya_id";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, _conn);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }

        public static DataTable calisanlariCek()
        {
            DataTable dt = new DataTable();
            _connection.Open();
            string sql = "select calisan.id,calisan.ad,calisan.soyad,calisan.kadi,calisan.mail,puanlar.puan from calisan inner join puanlar on puanlar.calisan_id = calisan.id";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, _connection);
            da.Fill(dt);
            _connection.Close();
            return dt;
        }

        public static DataTable kategorileriCek()
        {
            DataTable dt;
            dt = new DataTable();
            _connection.Open();
            String sqlCommand = "select *from kategoriler";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlCommand, _connection);
            da.Fill(dt);
            _connection.Close();
            return dt;
        }

        public static bool AdminGirisiKontrol(string kadi, string sifre)
        {
            bool kontrol = false;
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("Select kadi,sifre from admin where kadi = '" + kadi + "' and sifre = '" + sifre + "'", _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                kontrol = true;
            _connection.Close();
            return kontrol;
        }

        public static bool SorulmaKontrol(SoruSorulma _var)
        {
            bool check = false;
            string sql = "select *from sorulmatarihleri where soru_id = " + _var.SoruID + " and calisan_id = " + _var.CalisanID;

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                check = true;

            _connection.Close();

            return check;
        }


        public static List<BirlesikSoru> SorulariCek(string kategori_ad, string zorluk_seviyesi)
        {
            List<BirlesikSoru> sorular = new List<BirlesikSoru>();
            string sql = "select sorular.soruBasligi,sorular.sure,secenekler.*,medya.medya_path,sorular.id from sorular inner join secenekler on secenekler.soru_id = sorular.id inner join medya on medya.id = sorular.medya_id where sorular.zorlukSeviyesi = '" + zorluk_seviyesi + "' and sorular.kategori_id = (select id from kategoriler where ad = '" + kategori_ad + "')";
            string query = "SELECT sorular.soruBasligi,sorular.sure,secenekler.*,medya.medya_path,sorular.id FROM sorular,secenekler,medya WHERE sorular.id = secenekler.soru_id AND sorular.medya_id = medya.id AND sorular.zorlukSeviyesi = '" + zorluk_seviyesi + "' AND sorular.kategori_id =(SELECT kategoriler.id FROM kategoriler WHERE kategoriler.ad = '" + kategori_ad + "' ) AND sorular.id IN(SELECT sorulmatarihleri.soru_id FROM sorulmatarihleri WHERE sorulmatarihleri.soru_id = sorular.id AND sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + " AND DATEDIFF( CURRENT_DATE,sorulmatarihleri.tarih) >(SELECT ayarlar.deger FROM ayarlar WHERE ayarlar.id = 2))";

            string query1 = "SELECT sorular.soruBasligi, sorular.sure, secenekler.*, medya.medya_path, sorular.id FROM sorular, secenekler, medya WHERE sorular.id = secenekler.soru_id AND sorular.medya_id = medya.id AND sorular.zorlukSeviyesi = '" + zorluk_seviyesi + "' AND sorular.kategori_id =( SELECT kategoriler.id FROM kategoriler WHERE kategoriler.ad = '" + kategori_ad + "' ) AND sorular.id NOT IN( SELECT sorular.id FROM sorulmatarihleri WHERE sorulmatarihleri.soru_id = sorular.id AND sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + " )";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            Soru _soru = new Soru();
            Secenekler _secenekler = new Secenekler();
            while (reader.Read())
            {
                _soru = new Soru();
                _secenekler = new Secenekler();
                Medya _medya = new Medya();
                _soru.SoruBasligi = reader.GetValue(0).ToString();
                _soru.Sure = Convert.ToInt32(reader.GetValue(1));

                _secenekler.ASecenegi = reader.GetValue(3).ToString();
                _secenekler.BSecenegi = reader.GetValue(4).ToString();
                _secenekler.CSecenegi = reader.GetValue(5).ToString();
                _secenekler.DSecenegi = reader.GetValue(6).ToString();
                _secenekler.ESecenegi = reader.GetValue(7).ToString();
                _secenekler.DogruCevap = reader.GetValue(8).ToString();
                _medya.Path = reader.GetValue(9).ToString();
                _soru.ID = Convert.ToInt32(reader.GetValue(10));
                BirlesikSoru soru = new BirlesikSoru();
                soru.soru = _soru;
                soru.secenekler = _secenekler;
                soru.medya = _medya;

                sorular.Add(soru);
            }
            reader.Close();
            _connection.Close();

            _connection.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, _connection);
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                _soru = new Soru();
                _secenekler = new Secenekler();
                Medya _medya = new Medya();
                _soru.SoruBasligi = reader1.GetValue(0).ToString();
                _soru.Sure = Convert.ToInt32(reader1.GetValue(1));

                _secenekler.ASecenegi = reader1.GetValue(3).ToString();
                _secenekler.BSecenegi = reader1.GetValue(4).ToString();
                _secenekler.CSecenegi = reader1.GetValue(5).ToString();
                _secenekler.DSecenegi = reader1.GetValue(6).ToString();
                _secenekler.ESecenegi = reader1.GetValue(7).ToString();
                _secenekler.DogruCevap = reader1.GetValue(8).ToString();
                _medya.Path = reader1.GetValue(9).ToString();
                _soru.ID = Convert.ToInt32(reader1.GetValue(10));
                BirlesikSoru soru = new BirlesikSoru();
                soru.soru = _soru;
                soru.secenekler = _secenekler;
                soru.medya = _medya;

                sorular.Add(soru);
            }
            _connection.Close();
            return sorular;
        }

        public static List<Medya> MedyaCek(int id)
        {
            List<Model.Medya> _medya = new List<Model.Medya>();
            string query = "select *from medya where kategori_id = " + id;
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            Medya medya;
            while (reader.Read())
            {
                medya = new Medya();
                medya.ID = Convert.ToInt32(reader.GetValue(0));
                medya.KategoriID = Convert.ToInt32(reader.GetValue(1));
                medya.Path = reader.GetValue(2).ToString();
                medya.Ad = reader.GetValue(3).ToString();
                _medya.Add(medya);
            }
            _connection.Close();
            return _medya;
        }

        public static Kategori KategoriCekMedya(int id)
        {
            Kategori _kategori = new Kategori();


            string query = "select * from kategoriler where id = (select kategori_id from sorular where id = " + id + ")";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            _kategori.ID = Convert.ToInt32(reader.GetValue(0));
            _kategori.Ad = reader.GetValue(1).ToString();
            _kategori.Aciklama = reader.GetValue(2).ToString();
            _connection.Close();
            return _kategori;
        }

        public static ZorlukPuanlari ZorlukPuanlari()
        {
            ZorlukPuanlari z;
            z = new ZorlukPuanlari();

            _connection.Open();

            string query = "select * from puanturleri";

            MySqlCommand cmd = new MySqlCommand(query, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            z.Kolay = reader.GetInt32(2);
            reader.Read();
            z.Orta = reader.GetInt32(2);
            reader.Read();
            z.Zor = reader.GetInt32(2);

            _connection.Close();
            return z;

        }

        public static List<Medya> MedyaCekForMedyaDegistir(int id)
        {
            List<Medya> _medyalar = new List<Medya>();
            string query = "select *from medya where kategori_id = (select kategori_id from sorular where id = " + id + ")";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Medya _medya = new Medya();
                _medya.ID = Convert.ToInt32(reader.GetValue(0));
                _medya.KategoriID = Convert.ToInt32(reader.GetValue(1));
                _medya.Path = reader.GetValue(2).ToString();
                _medya.Ad = reader.GetValue(3).ToString();
                _medyalar.Add(_medya);
            }
            _connection.Close();
            return _medyalar;
        }

        public static Medya MedyaCekForSoruDuzenleme(int id)
        {
            Medya _medya = new Medya();
            string query = "select * from medya where id = (select medya_id from sorular where id = " + id + ")";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            _medya.ID = Convert.ToInt32(reader.GetValue(0));
            _medya.KategoriID = Convert.ToInt32(reader.GetValue(1));
            _medya.Path = reader.GetValue(2).ToString();
            _medya.Ad = reader.GetValue(3).ToString();
            _connection.Close();
            return _medya;
        }

        public static List<Model.Medya> MedyaCekYeni(int id)
        {
            List<Medya> _medyalar = new List<Medya>();
            string query = "select * from medya where kategori_id = " + id;
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Medya _medya = new Medya();
                _medya.ID = Convert.ToInt32(reader.GetValue(0));
                _medya.KategoriID = Convert.ToInt32(reader.GetValue(1));
                _medya.Path = reader.GetValue(2).ToString();
                _medya.Ad = reader.GetValue(3).ToString();
                _medyalar.Add(_medya);
            }
            _connection.Close();
            return _medyalar;
        }

        public static Kategori KategoriCekTekli(int kategori_id)
        {
            string query = "select *from kategoriler where id = " + kategori_id;

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Kategori _kategori = new Kategori();

            _connection.Close();
            return _kategori;

        }

        public static string KullaniciAd(string kadi)
        {

            string query = "select ad from calisan where kadi = '" + kadi + "'";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Read();

            _connection.Close();
            return "Ali";
        }

        public static bool KullaniciGirisKontrol(string kadi, string sifre)
        {
            bool check = false;

            string query = "select * from calisan where kadi = '" + kadi + "' and sifre = '" + sifre + "'";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                check = true;
            _connection.Close();

            return check;
        }
        public static List<Kategori> GetCategories(string zorluk)
        {
            List<Kategori> _kategoriler = new List<Kategori>();
            string query = "select *from kategoriler where id in (select kategori_id from sorular where zorlukSeviyesi = '" + zorluk + "' and sorular.id in (select sorulmatarihleri.soru_id from sorulmatarihleri where sorulmatarihleri.soru_id = sorular.id and sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + " and datediff(CURRENT_DATE,sorulmatarihleri.tarih)>(select ayarlar.deger from ayarlar where ayarlar.id = 2)))";
            string query1 = "select *from kategoriler where id in (select kategori_id from sorular where zorlukSeviyesi = '" + zorluk + "' and sorular.id not in (select sorulmatarihleri.soru_id from sorulmatarihleri where sorulmatarihleri.soru_id = sorular.id and sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + "))";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Kategori _kategori = new Kategori();
                _kategori.ID = Convert.ToInt32(reader.GetValue(0));
                _kategori.Ad = reader.GetValue(1).ToString();
                _kategori.Aciklama = reader.GetValue(2).ToString();
                _kategoriler.Add(_kategori);
            }

            reader.Close();
            _connection.Close();

            _connection.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, _connection);
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            while (reader1.Read())
            {
                Kategori _kategori = new Kategori();
                _kategori.ID = Convert.ToInt32(reader1.GetValue(0));
                _kategori.Ad = reader1.GetValue(1).ToString();
                _kategori.Aciklama = reader1.GetValue(2).ToString();
                _kategoriler.Add(_kategori);
            }

            reader1.Close();
            _connection.Close();

            return _kategoriler;
        }

        public static List<Calisan> Calisanlar()
        {
            List<Calisan> calisanlar = new List<Calisan>();
            string query = "select * from calisan";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Calisan calisan = new Calisan();
                calisan.ID = reader.GetInt32(0);
                calisan.Ad = reader.GetString(1);
                calisan.Soyad = reader.GetString(2);
                calisan.Mail = reader.GetString(3);
                calisan.Kadi = reader.GetString(4);
                calisan.Sifre = reader.GetString(5);

                calisanlar.Add(calisan);
            }
            _connection.Close();
            return calisanlar;
        }
    }
}
