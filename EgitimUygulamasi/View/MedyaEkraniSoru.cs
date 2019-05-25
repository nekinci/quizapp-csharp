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
    public partial class MedyaEkraniSoru : UserControl
    {
        private QuestionScreen main;
        public MedyaEkraniSoru()
        {
            InitializeComponent();
        }

        public void setMain(QuestionScreen main)
        {
            this.main = main;
        }

        private void btnSoruyaGec_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void MedyaEkraniSoru_Load(object sender, EventArgs e)
        {

        }


    }
}
