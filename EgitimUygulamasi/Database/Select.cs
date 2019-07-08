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

        private static MySqlConnection _connection = new MySqlConnection(DatabaseInf.Veritabani);
        private Select() { }

        public static string SifremiUnuttum(string kadi, string mail)
        {
            string sql = "select *from admin where kadi = '" + kadi + "' and email = '" + mail + "'";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            string sifre = "Girilen bilgiler yanlis";
            if (reader.Read())
            {
                sifre = reader.GetString("sifre").ToString();
            }
            _connection.Close();
            return sifre;
        }
        public static OdulCeza OdulCezaCek()
        {
            string sql = "select *from odulceza";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            OdulCeza odulceza = new OdulCeza();
            if (reader.Read())
            {
                odulceza.ID = reader.GetInt32(0);
                odulceza.Ceza1 = reader.GetInt32(1);
                odulceza.Ceza2 = reader.GetInt32(2);
                odulceza.Odul1 = reader.GetInt32(3);
                odulceza.Odul2 = reader.GetInt32(4);

            }
            _connection.Close();
            return odulceza;
        }

        public static bool AdminVarmi()
        {
            string sql = "select *from admin";
            bool check = false;
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                check = true;
            _connection.Close();

            return check;

        }

        public static int LastInsertedCevap()
        {
            string sql = "select max(id) from cevaplar";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            int res = -1;
            if (reader.Read())
                res = reader.GetInt32(0);

            _connection.Close();
            return res;
        }
        public static List<Bildirim> BildirimleriCek()
        {
            List<Bildirim> bildirimler = new List<Bildirim>();
            string query = "select *from bildirimler";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Bildirim b = new Bildirim();
                b.ID = reader.GetInt32(0);
                b.GonderenID = reader.GetInt32(1);
                b.SoruID = reader.GetInt32(2);
                b.CevapID = reader.GetInt32(3);
                b.Tarih = reader.GetDateTime(4);
                b.OkunduMu = reader.GetBoolean(5);
                b.GorulduMu = reader.GetBoolean(6);
                bildirimler.Add(b);
            }
            _connection.Close();
            return bildirimler;
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

        public static List<Kategori> KategoriCek()
        {
            string sqlCommand = "select *from kategoriler";
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
            MySqlConnection _conn = new MySqlConnection(DatabaseInf.Veritabani);
            _conn.Open();
            string sqlCommand = "select sorular.id,sorular.soruBasligi,sorular.zorlukSeviyesi,sorular.sure, kategoriler.ad,secenekler.asecenegi,secenekler.bsecenegi, secenekler.csecenegi,secenekler.dsecenegi,secenekler.esecenegi,secenekler.dogru,medya.medya_path,sorular.klasiksoru from sorular inner join secenekler on sorular.id = secenekler.soru_id inner join kategoriler on kategoriler.id = sorular.kategori_id left join medya on medya.id = (select sorumedyalari.medya_id from sorumedyalari where sorular.id = sorumedyalari.soru_id)";
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

        public static DataTable odulveCezaCek()
        {
            DataTable dt = new DataTable();
            _connection.Open();
            string sql = "select odulveceza.id,odulveceza.ad,odulveceza.tur,odulveceza.aralik1,odulveceza.aralik2 from odulveceza";
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

            string query = "SELECT sorular.soruBasligi,sorular.sure,secenekler.*,sorular.id,sorular.klasiksoru FROM sorular,secenekler WHERE sorular.id = secenekler.soru_id AND sorular.zorlukSeviyesi = '" + zorluk_seviyesi + "' AND sorular.kategori_id =(SELECT kategoriler.id FROM kategoriler WHERE kategoriler.ad = '" + kategori_ad + "' ) AND sorular.id IN(SELECT sorulmatarihleri.soru_id FROM sorulmatarihleri WHERE sorulmatarihleri.soru_id = sorular.id AND sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + " AND DATEDIFF( CURRENT_DATE,sorulmatarihleri.tarih) >(SELECT ayarlar.deger FROM ayarlar WHERE ayarlar.id = 2))";

            string query1 = "SELECT sorular.soruBasligi, sorular.sure, secenekler.*,  sorular.id,sorular.klasiksoru FROM sorular, secenekler WHERE sorular.id = secenekler.soru_id AND sorular.zorlukSeviyesi = '" + zorluk_seviyesi + "' AND sorular.kategori_id =( SELECT kategoriler.id FROM kategoriler WHERE kategoriler.ad = '" + kategori_ad + "' ) AND sorular.id NOT IN( SELECT sorular.id FROM sorulmatarihleri WHERE sorulmatarihleri.soru_id = sorular.id AND sorulmatarihleri.calisan_id = " + Database.Select.CalisanCekID(Session.KullaniciAdiAl()) + " )";

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
                _soru.ID = Convert.ToInt32(reader.GetValue(9));
                _soru.KlasikSoru = reader.GetBoolean(10);
                BirlesikSoru soru = new BirlesikSoru();
                soru.soru = _soru;
                soru.secenekler = _secenekler;
                soru.medya = GetMedia(_soru.ID);
                soru.soru.MedyaID = soru.medya.ID;
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
                _soru.ID = Convert.ToInt32(reader1.GetValue(9));
                _soru.KlasikSoru = reader1.GetBoolean(10);
                BirlesikSoru soru = new BirlesikSoru();
                soru.soru = _soru;
                soru.secenekler = _secenekler;
                soru.medya = GetMedia(_soru.ID);
                soru.soru.MedyaID = soru.medya.ID;
                sorular.Add(soru);
            }
            _connection.Close();
            return sorular;
        }
        public static Medya GetMedia(int id)
        {
            Medya _medya = new Medya();
            string query = "select medya_id from sorumedyalari where sorumedyalari.soru_id = " + id;
            MySqlConnection _connection1 = new MySqlConnection(DatabaseInf.Veritabani);
            _connection1.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection1);
            MySqlDataReader reader = cmd.ExecuteReader();

            _medya.Path = "-1";
            _medya.ID = -1;
            _medya.Ad = "-1";
            _medya.KategoriID = -1;

            if (reader.Read())
            {
                _medya.ID = reader.GetInt32(0);
            }
            reader.Close();
            _connection1.Close();
            _connection1.Open();
            MySqlCommand cmd1 = new MySqlCommand("select * from medya where id = " + _medya.ID, _connection1);
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            if (reader1.Read())
            {
                _medya.KategoriID = reader1.GetInt32(1);
                _medya.Path = reader1.GetString(2);
                _medya.Ad = reader1.GetString(3);
            }
            _connection1.Close();
            return _medya;
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
            /*Medya _medya = new Medya();
            string query = "select * from medya where id = (select sorumedyalari from sorumedyalari where soru_id = "+id+")";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            _medya.Path = "-1";
            _medya.ID = -1;
            _medya.Ad = "-1";
            _medya.KategoriID = -1;

            if (reader.Read())
            {
                _medya.ID = Convert.ToInt32(reader.GetValue(0));
                _medya.KategoriID = Convert.ToInt32(reader.GetValue(1));
                _medya.Path = reader.GetValue(2).ToString();
                _medya.Ad = reader.GetValue(3).ToString();
            }

            _connection.Close();
            return _medya;*/

            return GetMedia(id);
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
            return reader.GetString(3);
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
        public static List<KlasikCevap> Cevaplar()
        {
            string sql = "select *from cevaplar";

            List<KlasikCevap> cevaplar = new List<KlasikCevap>();

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                KlasikCevap cevap = new KlasikCevap();
                cevap.ID = reader.GetInt32(0);
                cevap.CalisanID = reader.GetInt32(1);
                cevap.SoruID = reader.GetInt32(2);
                cevap.Cevap = reader.GetString(3);
                cevap.Tarih = reader.GetDateTime(4);
                cevap.Durum = reader.GetInt32(5);
                cevaplar.Add(cevap);
            }
            _connection.Close();
            return cevaplar;
        }

        public static List<Puan> Puanlar()
        {
            _connection.Open();

            string sql = "select *from puanlar";

            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();
            List<Puan> puanlar = new List<Puan>();
            while (reader.Read())
            {
                Puan puan = new Puan();
                puan.CalisanID = reader.GetInt32(0);
                puan.CalisanPuani = reader.GetInt32(1);
                puanlar.Add(puan);
            }

            _connection.Close();
            return puanlar;
        }

        public static List<CalisanCevaplari> CalisanCevaplari()
        {
            _connection.Open();
            string sql = "select *from calisancevaplari";

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            List<CalisanCevaplari> cevaplar = new List<CalisanCevaplari>();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CalisanCevaplari cevap = new CalisanCevaplari();
                cevap.ID = reader.GetInt32(0);
                cevap.SoruID = reader.GetInt32(1);
                cevap.CalisanID = reader.GetInt32(2);
                cevap.Tarih = reader.GetDateTime(3);
                cevap.Sure = reader.GetInt32(4);
                cevap.Cevap = reader.GetString(5);

                cevaplar.Add(cevap);
            }
            _connection.Close();
            return cevaplar;
        }

        public static List<BirlesikSoru> Sorular()
        {

            //Bu Metod sadece soruları çekmekle yükümlü Cevaplar veya Soruldumu kontrolünü sağlamaz. Sorulan sorulmayan tüm soruları çeker.
            // E günün birinde lazım olur tabi böyle şeyleri yapmak lazım.
            _connection.Open();
            string sql = "select *from sorular,secenekler where secenekler.soru_id = sorular.id";
            List<BirlesikSoru> sorular = new List<BirlesikSoru>();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Soru soru = new Soru();
                Secenekler secenekler = new Secenekler();

                soru.ID = reader.GetInt32(0);
                soru.KategoriID = reader.GetInt32(1);
                soru.Sure = reader.GetInt32(2);
                soru.SoruBasligi = reader.GetString(3);
                soru.ZorlukSeviyesi = reader.GetString(4);
                soru.KlasikSoru = reader.GetBoolean(5);

                secenekler.SoruID = reader.GetInt32(6);
                secenekler.ASecenegi = reader.GetString(7);
                secenekler.BSecenegi = reader.GetString(8);
                secenekler.CSecenegi = reader.GetString(9);
                secenekler.DSecenegi = reader.GetString(10);
                secenekler.ESecenegi = reader.GetString(11);
                secenekler.DogruCevap = reader.GetString(12);

                BirlesikSoru Soru = new BirlesikSoru();
                Soru.soru = soru;
                Soru.secenekler = secenekler;
                Soru.medya = GetMedia(soru.ID);

                sorular.Add(Soru);
            }
            _connection.Close();
            return sorular;
        }

        public static List<Medya> Medyalar()
        {
            string sql = "select *from medya";

            List<Medya> medyalar = new List<Medya>();

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Medya medya = new Medya();
                medya.ID = reader.GetInt32(0);
                medya.KategoriID = reader.GetInt32(1);
                medya.Path = reader.GetString(2);
                medya.Ad = reader.GetString(3);
                medyalar.Add(medya);
            }

            _connection.Close();
            return medyalar;
        }

        public static List<Kategori> Kategoriler()
        {
            string sql = "select *from kategoriler";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            List<Kategori> kategoriler = new List<Kategori>();

            while (reader.Read())
            {
                Kategori kategori = new Kategori();
                kategori.ID = reader.GetInt32(0);
                kategori.Ad = reader.GetString(1);
                kategori.Aciklama = reader.GetString(2);

                kategoriler.Add(kategori);
            }

            _connection.Close();

            return kategoriler;
        }


        public static Admin Admin()
        {
            string sql = "select *from admin";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            Admin admin = new Admin();
            if (reader.Read())
            {
                admin.ID = reader.GetInt32(0);
                admin.Ad = reader.GetString(1);
                admin.Soyad = reader.GetString(2);
                admin.Email = reader.GetString(3);
                admin.Kadi = reader.GetString(4);
                admin.Sifre = reader.GetString(5);
            }
            _connection.Close();

            return admin;
        }


        public static MainTema MainTema(int id)
        {
            MainTema tema = null;

            string sql = "select *from temamain where id = " + id;

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tema = new MainTema();
                tema.ID = reader.GetInt32(0);
                tema.SolMenuArka = reader.GetString(1);
                tema.SolMenuButon = reader.GetString(2);
                tema.SolMenuButonYazi = reader.GetString(3);
                tema.SolUstArka = reader.GetString(4);
                tema.SolUstOn = reader.GetString(5);
                tema.SagUstYazi = reader.GetString(6);
                tema.OturumuKapatArka = reader.GetString(7);
                tema.OturumuKapatOn = reader.GetString(8);
                tema.SagUstArka = reader.GetString(9);
                tema.ButonHover = reader.GetString(10);
            }
            _connection.Close();
            return tema;
        }

        public static LoginTema LoginTema(int id)
        {
            LoginTema tema = null;
            string sql = "select *from logintema where id = " + id;

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                tema = new LoginTema();

                tema.ID = reader.GetInt32(0);
                tema.LoginSabit = reader.GetBoolean(1);
                tema.SolArka = reader.GetString(2);
                tema.SolYazi = reader.GetString(3);
                tema.Sag = reader.GetString(4);
                tema.Yazi1 = reader.GetString(5);
                tema.Yazi2 = reader.GetString(6);
            }

            _connection.Close();

            return tema;
        }
    }
}
