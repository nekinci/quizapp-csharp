using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    class SoruSorulma
    {
        public int ID { get; set; }
        public int SoruID { get; set; }
        public int CalisanID { get; set; }
        public DateTime Tarih { get; set; }
        public int Sure { get; set; }
        public string Cevap { get; set; }
    }
}
