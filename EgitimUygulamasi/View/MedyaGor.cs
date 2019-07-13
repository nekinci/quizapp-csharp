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
            vlcPlayer1.SetMedia(_medya);
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
        }

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
        }

        private void vlcControl1_Enter(object sender, EventArgs e)
        {

        }
    }
}
