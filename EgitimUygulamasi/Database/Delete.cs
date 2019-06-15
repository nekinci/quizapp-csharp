using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EgitimUygulamasi.Database
{
    class Delete
    {

        private static MySqlConnection _connection =
            new MySqlConnection(DatabaseInf.Veritabani);

        public static bool KategoriSil(int id)
        {
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from kategoriler where kategoriler.id = " + id, _connection);
            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            return result != -1;
        }

        public static bool CalisanSil(int id)
        {
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from calisan where calisan.id = " + id, _connection);
            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            return result != -1;
        }

        public static bool SoruSil(int id)
        {
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand("delete from sorular where sorular.id = " + id, _connection);
            int result = cmd.ExecuteNonQuery();
            _connection.Close();
            return result != -1;
        }

        public static bool MedyaSil(int id)
        {
            string query = "DELETE from medya where id = " + id;
            _connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, _connection);
            int res = cmd.ExecuteNonQuery();

            _connection.Close();
            if (res != -1)
                return true;
            return false;
        }
    }
}
