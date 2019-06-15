using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class PuanProfil : UserControl
    {
        public PuanProfil()
        {
            InitializeComponent();
        }


        public void setValues(string isim,string puan)
        {
            label1.Text = isim;
            label2.Text = puan;
        }
    }
}
