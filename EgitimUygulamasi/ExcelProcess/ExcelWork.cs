using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace EgitimUygulamasi.ExcelProcess
{
    class ExcelWork
    {

        public static void VeriAl(string path)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.10.0; Data Source = C:\Users\Niyazi\Desktop\Kitap1.xls;");
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("select *from [Sayfa1$]", conn);

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }
        }

    }
}
