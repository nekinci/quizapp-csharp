﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using EgitimUygulamasi.Model;
using System.Diagnostics;
using System.Windows.Forms;

namespace EgitimUygulamasi.Database
{
    class Insert
    {
        //Bu class veritabanına veri eklemek ile sorumludur.

        private static MySqlConnection _connection = new MySqlConnection(DatabaseInf.Veritabani);


        private Insert()
        {

        }


        public static void OdulCezaEkleme(OdulCezaModel model)
        {
            string sql = "insert into odulveceza values(0,'" + model.Ad + "','" + model.Tur + "','" + model.Aralik1 + "','" + model.Aralik2 + "')";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            int res = cmd.ExecuteNonQuery();


            if (res != -1)
                MessageBox.Show("Başarıyla kaydedildi.");
            else
                MessageBox.Show("Kaydedilirken bir sorunla karşılaşıldı.");
            _connection.Close();
        }
        public static void AdminEkleme(Admin admin)
        {
            string sql = "insert into admin values(0,'" + admin.Ad + "','" + admin.Soyad + "','" + admin.Email + "','" + admin.Kadi + "','" + admin.Sifre + "')";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
        public static void BildirimOlustur(Bildirim bildirim)
        {
            string query = "insert into bildirimler values(0," + bildirim.GonderenID + "," + bildirim.SoruID + "," + bildirim.CevapID + ",'" + bildirim.Tarih.ToString("yyyy-MM-dd") + "'," + bildirim.OkunduMu + "," + bildirim.GorulduMu + ")";
            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(query, _connection);

            int res = cmd.ExecuteNonQuery();

            _connection.Close();
        }


        public static void SoruSoruldu(SoruSorulma _var)
        {
            //Hiç kayıt yoksa ekleyecek ama kayıt varsa napcak? Cevap basit güncelleyecek ama nasıl? Bende merak ediyorum doğrusu ama dur bakalım hallolur bi şekilde.
            string sql = "insert into sorulmatarihleri values(0," + _var.SoruID + "," + _var.CalisanID + ",'" + _var.Tarih.ToString("yyyy-MM-dd") + "')";

            //Her şartta bu bilgileri veritabanına ekliyoruzki daha sonra istatistiki bir durum olursa diye.
            string sql1 = "insert into calisancevaplari values(0," + _var.SoruID + "," + _var.CalisanID + ",'" + _var.Tarih.ToString("yyyy-MM-dd") + "','" + _var.Sure + "','" + _var.Cevap + "')";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            cmd.ExecuteNonQuery();
            cmd.CommandText = sql1;
            cmd.ExecuteNonQuery();


            _connection.Close();
        }



        public static void CalisanEkleme(Calisan _calisan)
        {
            string sqlCommand = "insert into calisan values(0,'" + _calisan.Ad + "','" + _calisan.Soyad + "','" + _calisan.Mail + "','" + _calisan.Kadi + "','" + _calisan.Sifre + "') ";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlCommand, _connection);
            int a = cmd.ExecuteNonQuery();
            _connection.Close();
            _connection.Open();
            string sqlCommand1 = "insert into puanlar values(" + cmd.LastInsertedId + ",0)";
            MySqlCommand cmd1 = new MySqlCommand(sqlCommand1, _connection);
            int b = cmd1.ExecuteNonQuery();
            _connection.Close();

            if (a != -1 && b != -1)
                MessageBox.Show("Başarıyla eklendi");
            else
                MessageBox.Show("Yolunda gitmeyen birşeyler var, kayıt eklenemedi!");
        }

        public static void SoruEkleme(BirlesikSoru _soru)
        {
            string sql = "insert into sorular values(0," + _soru.soru.KategoriID + "," + _soru.soru.Sure + ",'" + _soru.soru.SoruBasligi + "','" + _soru.soru.ZorlukSeviyesi + "'," + _soru.soru.KlasikSoru + ")";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            int res = cmd.ExecuteNonQuery();
            _connection.Close();
            _connection.Open();
            string sql1 = "insert into sorumedyalari values (0,@soruid,@medyaid)";
            string query = "insert into secenekler values(@soruid,@asecenegi,@bsecenegi,@csecenegi,@dsecenegi,@esecenegi,@dogru)";
            MySqlCommand command = new MySqlCommand(query, _connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@soruid", cmd.LastInsertedId);
            command.Parameters.AddWithValue("@asecenegi", _soru.secenekler.ASecenegi);
            command.Parameters.AddWithValue("@bsecenegi", _soru.secenekler.BSecenegi);
            command.Parameters.AddWithValue("@csecenegi", _soru.secenekler.CSecenegi);
            command.Parameters.AddWithValue("@dsecenegi", _soru.secenekler.DSecenegi);
            command.Parameters.AddWithValue("@esecenegi", _soru.secenekler.ESecenegi);
            command.Parameters.AddWithValue("@dogru", _soru.secenekler.DogruCevap);

            MySqlCommand cmd1 = new MySqlCommand(sql1, _connection);
            cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@soruid", cmd.LastInsertedId);
            cmd1.Parameters.AddWithValue("@medyaid", _soru.soru.MedyaID);
            int res1 = command.ExecuteNonQuery();
            int res2 = 0;
            if (_soru.soru.MedyaID != -1)
            {
                res2 = cmd1.ExecuteNonQuery();
            }

            if(_soru.calisanlar.Count > 0)
            {
                foreach(var i in _soru.calisanlar)
                {
                    SoruCalisaniEkleme(i, cmd.LastInsertedId);
                }
            }


            _connection.Close();
            if (res != -1 && res1 != -1 && res2 != -1)
            {
                MessageBox.Show("Başarıyla kayıt edildi.");
            }
            else
            {
                MessageBox.Show("Kayıt edilemedi.");
            }
        }
        public static void KategoriEkleme(Model.Kategori _kategori)
        {
            string sqlCommand = "insert into kategoriler values(0,'" + _kategori.Ad + "','" + _kategori.Aciklama + "')";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sqlCommand, _connection);
            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            if (result != -1)
                MessageBox.Show("Başarıyla kaydedildi!");
            else
                MessageBox.Show("Kaydedilemedi.");
            return;
        }
        public static void SoruCalisaniEkleme(int calisanid,long soruid)
        {
            MySqlConnection conn = new MySqlConnection(DatabaseInf.Veritabani);
            conn.Open();
            string sql = "insert into calisansoru values(0,@soruid,@calisanid)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@soruid", soruid);
            cmd.Parameters.AddWithValue("@calisanid", calisanid);

            int res = cmd.ExecuteNonQuery();

            if (res == -1)
                MessageBox.Show("Bir şeyler yolunda gitmedi. Soru Çalışanı Ekleme.");

            conn.Close();

        }
        public static bool MedyaEkleme(Model.Medya _medya)
        {
            string sql = "insert into medya values(0,@kategoriid,@medyapath,@medyaismi)";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            cmd.Parameters.AddWithValue("@kategoriid", _medya.KategoriID);
            cmd.Parameters.AddWithValue("@medyapath", _medya.Path);
            cmd.Parameters.AddWithValue("@medyaismi", _medya.Ad);

            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            if (result != -1)
            {
                MessageBox.Show("Başarıyla eklendi.");
                return true;
            }
            else
            {
                MessageBox.Show("Eklenemedi.");
                return false;
            }

        }

        public static void CevapEkle(KlasikCevap cevap)
        {
            string sql = "insert into cevaplar values(0," + cevap.CalisanID + "," + cevap.SoruID + ",'" + cevap.Cevap + "','" + cevap.Tarih.ToString("yyyy-MM-dd") + "',0)";

            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);

            int res = cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
