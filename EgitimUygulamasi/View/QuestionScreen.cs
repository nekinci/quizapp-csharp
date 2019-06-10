using EgitimUygulamasi.Model;
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
    public partial class QuestionScreen : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public QuestionScreen()
        {
            InitializeComponent();
            stepOneApp1.setMain(this);
            soruEkrani1.setMain(this);
            medyaEkraniSoru1.setMain(this);
            uiProfil1.setMain(this);
        }

        private void init()
        {
            this.uiProfil1 = new EgitimUygulamasi.View.UIProfil();
            this.medyaEkraniSoru1 = new EgitimUygulamasi.View.MedyaEkraniSoru();
            this.soruEkrani1 = new EgitimUygulamasi.View.SoruEkrani();
            this.stepOneApp1 = new EgitimUygulamasi.View.StepOneApp();

            this.medyaEkraniSoru1.BackColor = System.Drawing.Color.White;
            this.medyaEkraniSoru1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.medyaEkraniSoru1.Location = new System.Drawing.Point(0, 47);
            this.medyaEkraniSoru1.Name = "medyaEkraniSoru1";
            this.medyaEkraniSoru1.Size = new System.Drawing.Size(780, 490);
            this.medyaEkraniSoru1.TabIndex = 7;
            this.medyaEkraniSoru1.Visible = false;
            this.medyaEkraniSoru1.Load += new System.EventHandler(this.medyaEkraniSoru1_Load);

            this.soruEkrani1.BackColor = System.Drawing.Color.Cornsilk;
            this.soruEkrani1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soruEkrani1.Location = new System.Drawing.Point(0, 46);
            this.soruEkrani1.Name = "soruEkrani1";
            this.soruEkrani1.Size = new System.Drawing.Size(780, 491);
            this.soruEkrani1.TabIndex = 6;
            this.soruEkrani1.Visible = false;
            this.soruEkrani1.Load += new System.EventHandler(this.soruEkrani1_Load);
            // 
            // stepOneApp1
            // 
            this.stepOneApp1.BackColor = System.Drawing.Color.White;
            this.stepOneApp1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stepOneApp1.Location = new System.Drawing.Point(0, 46);
            this.stepOneApp1.Name = "stepOneApp1";
            this.stepOneApp1.Size = new System.Drawing.Size(780, 491);
            this.stepOneApp1.TabIndex = 5;
            this.stepOneApp1.Load += new System.EventHandler(this.stepOneApp1_Load);

            this.uiProfil1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiProfil1.Location = new System.Drawing.Point(0, 46);
            this.uiProfil1.Name = "uiProfil1";
            this.uiProfil1.Size = new System.Drawing.Size(780, 1);
            this.uiProfil1.TabIndex = 9;
            this.uiProfil1.Visible = false;

            this.uiProfil1.setMain(this);
            this.stepOneApp1.setMain(this);
            this.soruEkrani1.setMain(this);
            this.medyaEkraniSoru1.setMain(this);
        }


        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOturumuKapat_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            result = MessageBox.Show("Gerçekten oturumu kapatmak istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button3);

            if (result == DialogResult.Yes)
            {
                Session.OturumKapat();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
        List<Model.BirlesikSoru> sorular;
        int soruid;
        public void SoruAktarici(string kategori, string zorluk)
        {
            sorular = Database.Select.SorulariCek(kategori, zorluk);
            if (sorular.Count > 0)
            {
                soruid = new Random().Next(0, sorular.Count);

                BirlesikSoru soru = sorular.ElementAt(soruid);

                medyaEkraniSoru1.Goster(soru);
            }
            else
            {
                MessageBox.Show("Yeterli sayıda soru yüklenemedi.!");
                AnasayfayaDon();
            }
        }

        public void SoruGoster()
        {
            BirlesikSoru soru = sorular.ElementAt(soruid);
            soruEkrani1.SoruCek(soru);
        }

        private void stepOneApp1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AnasayfayaDon()
        {
            soruEkrani1.Visible = false;
            medyaEkraniSoru1.Visible = false;
            stepOneApp1.Visible = false;
            uiProfil1.Visible = false;
            init();
            this.Controls.Add(this.uiProfil1);
            this.Controls.Add(this.medyaEkraniSoru1);
            this.Controls.Add(this.soruEkrani1);
            this.Controls.Add(this.stepOneApp1);
            
            stepOneApp1.Visible = true;
        }

        private void soruEkrani1_Load(object sender, EventArgs e)
        {

        }

        private void medyaEkraniSoru1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void QuestionScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ButonDegistir();
        }

        public void ButonDegistir()
        {
            if (uiProfil1.Visible)
            {
                btnProfile.BackColor = Color.White;
                uiProfil1.Visible = false;
            }

            else
            {
                btnProfile.BackColor = Color.DarkCyan;
                uiProfil1.Visible = true;
            }
        }
    }
}
