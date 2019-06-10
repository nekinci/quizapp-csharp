using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimUygulamasi.Model
{
    public class Bildirim
    {
        public int ID { get; set; }
        public int GonderenID { get; set; }
        public int SoruID { get; set; }
        public int CevapID { get; set; }
        public DateTime Tarih { get; set; }
        public bool OkunduMu { get; set; }
        public bool GorulduMu { get; set; }
    }
}
