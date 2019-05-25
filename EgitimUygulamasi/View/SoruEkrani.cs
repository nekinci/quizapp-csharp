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
    public partial class SoruEkrani : UserControl
    {
        private QuestionScreen main;
        public SoruEkrani()
        {
            InitializeComponent();
        }

        public void setMain(QuestionScreen main)
        {
            this.main = main;
        }
        private List<Model.BirlesikSoru> sorular;
        private int soruid;
        private int sure;
        public void SoruCek(List<Model.BirlesikSoru> sorular)
        {
            this.Visible = true;
            this.sorular = sorular;
        }

        private void SoruEkrani_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void asecenegi_Click(object sender, EventArgs e)
        {
            if (sorular.ElementAt(soruid).secenekler.DogruCevap == "A")
            {
                MessageBox.Show("Doğru bildiniz!");
            }
        }

        private void bsecenegi_Click(object sender, EventArgs e)
        {
            if (sorular.ElementAt(soruid).secenekler.DogruCevap == "B")
            {
                MessageBox.Show("Doğru bildiniz!");
            }
        }

        private void csecenegi_Click(object sender, EventArgs e)
        {
            if (sorular.ElementAt(soruid).secenekler.DogruCevap == "C")
            {
                MessageBox.Show("Doğru bildiniz!");
            }
        }

        private void dsecenegi_Click(object sender, EventArgs e)
        {
            if (sorular.ElementAt(soruid).secenekler.DogruCevap == "D")
            {
                MessageBox.Show("Doğru bildiniz!");
            }
        }

        private void esecenegi_Click(object sender, EventArgs e)
        {
            if (sorular.ElementAt(soruid).secenekler.DogruCevap == "E")
            {
                MessageBox.Show("Doğru bildiniz!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                lblSure.Text = "Süre : " + sure;
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
