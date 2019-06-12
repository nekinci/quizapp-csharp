using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimUygulamasi.Model;

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
            
            videoMedya.Ctlcontrols.stop();
            this.Visible = false;
            main.SoruGoster();
        }

        private void MedyaEkraniSoru_Load(object sender, EventArgs e)
        {

        }

        public void Goster(BirlesikSoru soru)
        {
            this.Visible = true;
            if (MedyaKontrol.ResimKontrol(soru.medya.Path))
            {
                pictureBox1.ImageLocation = soru.medya.Path;
                pictureBox1.Visible = true;
                videoMedya.Visible = false;
                videoMedya.URL = "";
                btnTamEkran.Visible = false;
                videoMedya.Ctlcontrols.stop();
            }
            if (MedyaKontrol.VideoKontrol(soru.medya.Path))
            {
                pictureBox1.Visible = false;
                pictureBox1.ImageLocation = "";
                videoMedya.URL = soru.medya.Path;
                videoMedya.Ctlcontrols.stop();
                videoMedya.Visible = true;
                btnTamEkran.Visible = true;
            }
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            if (videoMedya.playState == WMPLib.WMPPlayState.wmppsPlaying)
                videoMedya.fullScreen = true;
            else
                MessageBox.Show("Video başlatılmadan tam ekran yapamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
