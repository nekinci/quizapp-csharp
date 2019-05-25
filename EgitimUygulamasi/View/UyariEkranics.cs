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
    public partial class UyariEkranics : Form
    {
        public UyariEkranics(String message)
        {
            InitializeComponent();
            this.label1.Text = message;
        }

        private void UyariEkranics_Load(object sender, EventArgs e)
        {
            timer1.Interval = 50;
            timer1.Start();
        }
        int sayi = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sayi != 100)
            {
                this.Opacity -= 0.01;
                sayi++;
            }

            if (this.Opacity == 0)
            {
                timer1.Stop();
                this.Hide();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
