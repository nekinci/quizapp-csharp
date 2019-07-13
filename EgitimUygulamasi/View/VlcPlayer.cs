using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;

namespace EgitimUygulamasi.View
{
    public partial class VlcPlayer : UserControl
    {
        private Model.Medya medya;
        public VlcPlayer()
        {
            InitializeComponent();
        }

        string _url;
        public string YoutubeVideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_url);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
        public void SetMedia(Model.Medya medya)
        {
            this.medya = medya;
            if (MedyaKontrol.ResimKontrol(medya.Path))
            {
                vlcControl1.SetMedia(medya.Path);
                panel2.Visible = false;
            }
            else if (MedyaKontrol.VideoKontrol(medya.Path))
            {
                vlcControl1.SetMedia(medya.Path);
            }
            else if (medya == null || medya.Path == null || medya.Path == "" || medya.Path == "-1")
            {
                MessageBox.Show("Medya boş veya hatalı!");
            }
            else
            {
                panel2.Visible = false;
                vlcControl1.SetMedia(new Uri("https://www.dailymotion.com/video/x7bm45u?playlist=x6ffqw").AbsoluteUri);

            }

            _url = "https://www.youtube.com/watch?v=85S_8suOpvs";
            // webBrowser2.DocumentText = String.Format("<meta http-equiv=\"X-UA Compatible \" Content = \"IE=Edge\" /><iframe width=\"100%\" height=\"315\" src=\"https://www.youtube.com/embed/{0}\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>",YoutubeVideoID);

            vlcControl1.VlcMediaPlayer.SetMedia(new Uri("http://download.blender.org/peach/bigbuckbunny_movies/big_buck_bunny_480p_surround-fix.avi"));
            vlcControl1.VlcMediaPlayer.Play();
        }
        public void Stop()
        {
            vlcControl1.Stop();
            vlcControl1.VlcMediaPlayer.Stop();
        }
        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;
            // Default installation path of VideoLAN.LibVLC.Windows
            e.VlcLibDirectory = new DirectoryInfo(Path.Combine(currentDirectory, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            vlcControl1.Play();//TODO
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            vlcControl1.Pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            vlcControl1.Stop();
        }
    }
}
