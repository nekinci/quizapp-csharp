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
using YoutubeExplode;
using YoutubeExplode.Models.MediaStreams;
using System.Diagnostics;

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
        public async void SetMedia(Model.Medya medya)
        {
            vlcControl1.Visible = true;
            panel2.Visible = true;
            axVLCPlugin21.Visible = false;
            this.medya = medya;
            if (MedyaKontrol.ResimKontrol(medya.Path) && !medya.Path.StartsWith("http")) //TODO buraya bak.
            {
                vlcControl1.SetMedia(new FileInfo(@medya.Path));
                panel2.Visible = false;
                vlcControl1.Play();

            }
            else if (MedyaKontrol.VideoKontrol(medya.Path) && !medya.Path.StartsWith("http"))
            {
                vlcControl1.SetMedia(new FileInfo(@medya.Path));
                panel2.Visible = true;
                vlcControl1.Play();

            }
            else if (medya == null || medya.Path == null || medya.Path == "" || medya.Path == "-1")
            {
                MessageBox.Show("Medya boş veya hatalı!");
            }
            else
            { 
                _url = medya.Path;
                btnLink.Visible = true;
                if (YoutubeVideoID != String.Empty)
                {
                    var url = medya.Path;
                    var youtubeVidId = YoutubeClient.ParseVideoId(url);
                    var yt = new YoutubeClient();
                    var video = await yt.GetVideoMediaStreamInfosAsync(youtubeVidId);
                    var muxed = video.Muxed.WithHighestVideoQuality();

                    vlcControl1.SetMedia(new Uri(muxed.Url));
                    vlcControl1.Play();

                }
                else
                {
                    vlcControl1.Visible = false;
                    panel2.Visible = false;
                    axVLCPlugin21.Visible = true;
                    axVLCPlugin21.playlist.add(medya.Path);
                    axVLCPlugin21.playlist.play();
                }

            }
            
        }
        public void Stop()
        {
            vlcControl1.Stop();
            vlcControl1.VlcMediaPlayer.Stop();
            axVLCPlugin21.playlist.stop();
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

        private void vlcControl1_Click(object sender, EventArgs e)
        {

        }
        
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(_url);
        }
    }
}
