using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Forms;
using Vlc.DotNet.Core;

using Vlc.DotNet.Core.Interops;
namespace EgitimUygulamasi.View
{
    public partial class MedyaGor : Form
    {
        Model.Medya _medya;
        Assembly currentAssembly;
        string currentDirectory;
        DirectoryInfo libDirectory;

        public MedyaGor()
        {
            currentAssembly = Assembly.GetEntryAssembly();
            currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            libDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            InitializeComponent();

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        }


        public void setMedya(Model.Medya _medya)
        {
            this._medya = _medya;

            if (MedyaKontrol.ResimKontrol(_medya.Path))
            {
                pictureBox1.ImageLocation = _medya.Path;
                pictureBox1.Visible = true;
               // videoMedya.Visible = false;
                //videoMedya.Ctlcontrols.stop();
                //videoMedya.URL = "";
                btnTamEkran.Visible = false;
            }
            else if (MedyaKontrol.VideoKontrol(_medya.Path))
            {
                pictureBox1.ImageLocation = "";
                pictureBox1.Visible = false;
                videoMedya.URL = _medya.Path;
                videoMedya.Visible = true;
                videoMedya.Ctlcontrols.stop();
                btnTamEkran.Visible = true;
            }

            else
            {
               
            }
            
            vlcControl1.Play(new FileInfo(_medya.Path));

            medyaIsim.Text = _medya.Ad;
        }
        private void MedyaGor_Load(object sender, EventArgs e)
        {

        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
        }

        private void btnTamEkran_Click_1(object sender, EventArgs e)
        {
            if (videoMedya.playState == WMPLib.WMPPlayState.wmppsPlaying)
                videoMedya.fullScreen = true;
            else
                MessageBox.Show("Video başlatılmadan tam ekran yapamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
        }
    }
}
