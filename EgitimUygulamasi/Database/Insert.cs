using MySql.Data.MySqlClient;
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

        private static MySqlConnection _connection = new MySqlConnection("Server=localhost;uid=root;database=egitim");


        private Insert()
        {

        }


        public static void CalisanEkleme(Calisan _calisan)
        {
            string sqlCommand = "insert into calisan values(0,'" + _calisan.Ad + "','" + _calisan.Soyad + "','"+_calisan.Mail+"','" + _calisan.Kadi + "','" + _calisan.Sifre + "') ";
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
            string sql = "insert into sorular values(0," + _soru.soru.KategoriID + "," + _soru.soru.MedyaID + "," + _soru.soru.Sure + ",'" + _soru.soru.SoruBasligi + "','" + _soru.soru.ZorlukSeviyesi + "')";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, _connection);
            int res = cmd.ExecuteNonQuery();
            _connection.Close();
            _connection.Open();
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
            int res1 = command.ExecuteNonQuery();
            _connection.Close();
            if (res != -1 && res1 != -1)
            {
                MessageBox.Show("Başarıyla kayıt edildi.");
            }
            else
            {
                MessageBox.Show("Kayıt edilemedi.");
            }

            //
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
            if(result != -1)
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


    }
}
