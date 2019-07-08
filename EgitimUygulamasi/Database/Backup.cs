using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.Database
{
    class Backup
    {

        public static void Yedekle(string path)
        {
            using (MySqlConnection _connection = new MySqlConnection(DatabaseInf.Veritabani))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup backup = new MySqlBackup(cmd))
                    {
                        cmd.Connection = _connection;
                        _connection.Open();
                        backup.ExportToFile(path);
                        _connection.Close();
                        MessageBox.Show("Başarıyla kaydedildi.");

                    }
                }
            }
        }

        public static void GeriYukle(string path)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseInf.Veritabani))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(path);
                        conn.Close();
                        MessageBox.Show("Başarıyla yüklendi.");
                    }
                }
            }
        }
    }
}
