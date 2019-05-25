using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi.View
{
    public partial class MedyaYukle : Form
    {
        public MedyaYukle()
        {
            InitializeComponent();
        }
        private SoruEkleme soruEkleme;
        private void MedyaYukle_Load(object sender, EventArgs e)
        {

        }

        public void setSoruEkleme(SoruEkleme soruEkleme)
        {
            this.soruEkleme = soruEkleme;
            this.icerikEkleme1.setSoruEkleme(soruEkleme,this);
        }
        
        private void ıcerikEkleme1_Load(object sender, EventArgs e)
        {

        }

        public void CloseWindow()
        {
            this.Dispose();
        }
    }
}
