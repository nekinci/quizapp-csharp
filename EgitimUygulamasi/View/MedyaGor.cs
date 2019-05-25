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
    public partial class MedyaGor : Form
    {
        Model.Medya _medya;
        public MedyaGor()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public void setMedya(Model.Medya _medya)
        {
            this._medya = _medya;

            pictureBox1.ImageLocation = _medya.Path;
            medyaIsim.Text = _medya.Ad;
        }
        private void MedyaGor_Load(object sender, EventArgs e)
        {

        }
    }
}
