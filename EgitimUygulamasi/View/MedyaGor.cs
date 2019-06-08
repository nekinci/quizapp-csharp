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

            if (MedyaKontrol.ResimKontrol(_medya.Path))
            {
                pictureBox1.ImageLocation = _medya.Path;
                pictureBox1.Visible = true;
                videoMedya.Visible = false;
                videoMedya.Ctlcontrols.stop();
                videoMedya.URL = "";
                btnTamEkran.Visible = false;
            }
            if (MedyaKontrol.VideoKontrol(_medya.Path))
            {
                pictureBox1.ImageLocation = "";
                pictureBox1.Visible = false;
                videoMedya.URL = _medya.Path;
                videoMedya.Visible = true;
                videoMedya.Ctlcontrols.stop();
                btnTamEkran.Visible = true;
            }
            medyaIsim.Text = _medya.Ad;
        }
        private void MedyaGor_Load(object sender, EventArgs e)
        {

        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            videoMedya.fullScreen = true;
        }
    }
}
