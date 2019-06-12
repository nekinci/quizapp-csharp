using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimUygulamasi.Model;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EgitimUygulamasi.Database
{
    class Update
    {
        private static MySqlConnection _connection = new MySqlConnection("server=localhost;userid=root;database=egitim;");

        public static void SoruSoruldu(SoruSorulma _var)
        {
            //Hiç kayıt yoksa ekleyecek ama kayıt varsa napcak? Cevap basit güncelleyecek ama nasıl? Bende merak ediyorum doğrusu ama dur bakalım hallolur bi şekilde.
            string sql = "UPDATE sorulmatarihleri set tarih = '" + _var.Tarih.ToString("yyyy-MM-dd") + "' where soru_id = " + _var.SoruID + " and calisan_id = " + _var.CalisanID;

            //Her şartta bu bilgileri veritabanına ekliyoruzki daha sonra istatistiki bir durum olursa diye.
            string sql1 = "insert into calisancevaplari values(0," + _var.SoruID + "," + _var.CalisanID + ",'" + _var.Tarih.ToString("yyyy-MM-dd") + "','" + _var.Sure + "','" + _var.Cevap + "')";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql1;
            cmd.ExecuteNonQuery();


            _connection.Close();
        }
        public static void ZorlukPuaniGuncelle(Model.ZorlukPuanlari z)
        {
            int kolay = z.Kolay;
            int orta = z.Orta;
            int zor = z.Zor;

            string query = "UPDATE puanturleri set puan = " + kolay + " where id = 1";
            string query1 = "UPDATE puanturleri set puan = " + orta + " where id = 2";
            string query2 = "UPDATE puanturleri set puan = " + zor + " where id = 3";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, _connection);
            int result;
            result = cmd.ExecuteNonQuery();
            cmd.CommandText = query1;
            result = cmd.ExecuteNonQuery();
            cmd.CommandText = query2;
            result = cmd.ExecuteNonQuery();

            if (result != -1)
            {
                MessageBox.Show("Başarıyla kaydedildi.");
            }
            else
            {
                MessageBox.Show("Bir sorun oluştu.");
            }

            _connection.Close();
        }

        public static void AyarGuncelle(int sayi, int id)
        {

            string sql = "Update ayarlar set deger = " + sayi + " where id = " + id;
            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            int res = cmd.ExecuteNonQuery();

            if (res != -1)
                MessageBox.Show("Başarıyla güncellendi.");
            else
                MessageBox.Show("Bir sorun oluştu!");
            _connection.Close();

        }



        public static int SoruGuncelle(Model.Soru _soru, Model.Secenekler _secenekler)
        {
            string updateSQL = "Update sorular inner join secenekler on secenekler.soru_id = sorular.id set " +
                "sorular.medya_id = " + _soru.MedyaID + ",sorular.kategori_id =" + _soru.KategoriID + ",  sorular.sure = " + _soru.Sure + ", soruBasligi = '" + _soru.SoruBasligi + "'" +
                " ,zorlukSeviyesi = '" + _soru.ZorlukSeviyesi + "',secenekler.asecenegi = '" + _secenekler.ASecenegi + "' ," +
                " secenekler.bsecenegi = '" + _secenekler.BSecenegi + "'" +
                " , secenekler.csecenegi = '" + _secenekler.CSecenegi + "' , secenekler.dsecenegi = '" + _secenekler.DSecenegi + "'," +
                " secenekler.esecenegi = '" + _secenekler.ESecenegi + "', secenekler.dogru = '" + _secenekler.DogruCevap + "',sorular.klasiksoru=" + _soru.KlasikSoru + " where sorular.id = " + _soru.ID + " and secenekler.soru_id = " + _soru.ID;

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(updateSQL, _connection);
            int result = cmd.ExecuteNonQuery();

            if (result != -1)
                MessageBox.Show("Başarıyla Güncellendi");
            else
                MessageBox.Show("Güncellenemedi");
            _connection.Close();
            return result;
        }


        public static bool PuanGuncelle(string kadi, string tur, bool dogrumu, bool gericekil)
        {
            bool check = false;


            string SoruPuani = "select puan from puanturleri where kategori_tur = '" + tur + "'";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(SoruPuani, _connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            int puan = 0;


            if (reader.Read())
            {
                puan = reader.GetInt32(0);
            }
            if (!gericekil)
            {
                if (!dogrumu && Database.Select.AyarCek().YanlisCevap == 0) { puan = 0; }

                if (!dogrumu)
                {
                    puan = -1 * puan;
                }
            }
            else
            {
                if (Database.Select.AyarCek().GeriCekilme == 1)
                {
                    puan = puan * -1;
                }
                else
                {
                    puan = 0;
                }


            }
            _connection.Close();
            string query;
            _connection.Open();
            query = "UPDATE puanlar set puan = puan + " + puan + " where calisan_id = (select id from calisan where kadi = '" + kadi + "')";


            MySqlCommand cmd1 = new MySqlCommand(query, _connection);

            int i = cmd1.ExecuteNonQuery();
            if (i != -1)
                check = true;
            _connection.Close();
            return check;
        }

        public static bool KategoriGuncelle(Model.Kategori _kategori)
        {
            var updateSQL = "update kategoriler set ad = '" + _kategori.Ad + "', aciklama = '" + _kategori.Aciklama + "' where id = " + _kategori.ID + "";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(updateSQL, _connection);
            int result = cmd.ExecuteNonQuery();

            if (result != -1)
                MessageBox.Show("Başarıyla güncellendi");
            else
                MessageBox.Show("Güncellenirken bir sorun oluştu!");
            _connection.Close();
            return result != -1;
        }


        public static bool CalisanGuncelle(Model.Calisan calisan)
        {
            var updateSQL = "update calisan set ad = '" + calisan.Ad + "', soyad = '" + calisan.Soyad + "', kadi = '" + calisan.Kadi + "' ,mail = '" + calisan.Mail + "', sifre = '" + calisan.Sifre + "' where id = " + calisan.ID;

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(updateSQL, _connection);
            int result = cmd.ExecuteNonQuery();

            if (result != -1)
                MessageBox.Show("Başarıyla güncellendi.");
            else
                MessageBox.Show("Güncellenemedi.");
            _connection.Close();
            return result != -1;
        }

        public static bool CevapDurumu(int CevapID, int durum)
        {
            _connection.Open();

            string sql = "Update cevaplar set durum = " + durum + " where id = " + CevapID;
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            int res = cmd.ExecuteNonQuery();
            _connection.Close();
            return res != -1;
        }

        public static bool BildirimGoruldu(Bildirim bildirim)
        {
            _connection.Open();

            string sql = "Update bildirimler set goruldu_mu = " + bildirim.GorulduMu + " where id = " + bildirim.ID;

            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            int res = cmd.ExecuteNonQuery();
            _connection.Close();

            return res != -1;
        }

        public static bool BildirimOkundu(Bildirim bildirim)
        {
            _connection.Open();
            string sql = "Update bildirimler set okundumu = " + bildirim.OkunduMu + " where id = " + bildirim.ID;
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            int res = cmd.ExecuteNonQuery();
            _connection.Close();
            return res != -1;
        }

        public static bool AdminGuncelle(Admin admin)
        {
            string sql = "Update admin set ad = '" + admin.Ad + "', soyad = '" + admin.Soyad + "',email = '" + admin.Email + "',kadi = '" + admin.Kadi + "',sifre= '" + admin.Sifre + "' where id = " + admin.ID + "";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            int res = cmd.ExecuteNonQuery();
            _connection.Close();
            if (res != -1)
                MessageBox.Show("Başarıyla güncellendi.");
            else
                MessageBox.Show("Güncellenemedi.");
            return res != -1;
        }
    }
}
