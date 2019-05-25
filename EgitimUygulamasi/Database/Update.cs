using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EgitimUygulamasi.Database
{
    class Update
    {
        private static MySqlConnection _connection = new MySqlConnection("server=localhost;userid=root;database=egitim;");

        public static int SoruGuncelle(Model.Soru _soru, Model.Secenekler _secenekler)
        {
            string updateSQL = "Update sorular inner join secenekler on secenekler.soru_id = sorular.id set " +
                "sorular.medya_id = "+_soru.MedyaID+",sorular.kategori_id =" + _soru.KategoriID + ",  sorular.sure = " + _soru.Sure + ", soruBasligi = '" + _soru.SoruBasligi + "'" +
                " ,zorlukSeviyesi = '" + _soru.ZorlukSeviyesi + "',secenekler.asecenegi = '" + _secenekler.ASecenegi + "' ," +
                " secenekler.bsecenegi = '" + _secenekler.BSecenegi + "'" +
                " , secenekler.csecenegi = '" + _secenekler.CSecenegi + "' , secenekler.dsecenegi = '" + _secenekler.DSecenegi + "'," +
                " secenekler.esecenegi = '" + _secenekler.ESecenegi + "', secenekler.dogru = '" + _secenekler.DogruCevap + "' where sorular.id = " + _soru.ID + " and secenekler.soru_id = " + _soru.ID;

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

        public static bool KategoriGuncelle(Model.Kategori _kategori)
        {
            var updateSQL = "update kategoriler set ad = '"+_kategori.Ad+"', aciklama = '"+_kategori.Aciklama+"' where id = "+_kategori.ID+"";
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(updateSQL,_connection);
            int result = cmd.ExecuteNonQuery();

            if (result != -1)
                MessageBox.Show("Başarıyla güncellendi");
            else
                MessageBox.Show("Güncellenirken bir sorun oluştu!");
            return result != -1;
        }


        public static bool CalisanGuncelle(Model.Calisan calisan)
        {
            var updateSQL = "update calisan set ad = '" + calisan.Ad + "', soyad = '" + calisan.Soyad + "', kadi = '" + calisan.Kadi + "' ,mail = '"+calisan.Mail+"', sifre = '" + calisan.Sifre + "'";

            _connection.Open();

            MySqlCommand cmd = new MySqlCommand(updateSQL, _connection);
            int result = cmd.ExecuteNonQuery();

            if (result != -1)
                MessageBox.Show("Başarıyla güncellendi.");
            else
                MessageBox.Show("Güncellenemedi.");
            return result != -1;
        }
    }
}
