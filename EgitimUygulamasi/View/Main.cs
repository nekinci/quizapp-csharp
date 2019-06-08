using EgitimUygulamasi.Database;
using EgitimUygulamasi.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimUygulamasi
{
    public partial class Main : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Main()
        {
            InitializeComponent();
            calisan1.setMain(this);
            calisanDuzenle1.setMain(this);
            kategoriDuzenleme1.setMain(this);
            kategoriEkleme1.setMain(this);
            soruDuzenleme1.setMain(this);
        }

        public void YenidenCiz()
        {
            soruDuzenleme1.yenidenCiz();
            kategoriDuzenleme1.yenidenCiz();
            calisanDuzenle1.yenidenCiz();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialCreate create = new InitialCreate();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void kategoriekle_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            kategoriEkleme1.Visible = true;
        }


        public void HepsiniGizle()
        {
            kategoriEkleme1.Visible = false;
            soruEkleme1.Visible = false;
            soruDuzenleme1.Visible = false;
            kategoriDuzenleme1.Visible = false;
            calisan1.Visible = false;
            calisanDuzenle1.Visible = false;
            ayarlar1.Visible = false;

        }

        private void soruekle_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            soruEkleme1.Visible = true;
        }

        private void soruduzenle_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            soruDuzenleme1.Visible = true;
        }

        private void soruDuzenleme1_Load(object sender, EventArgs e)
        {

        }

        private void kategoriduzenle_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            kategoriDuzenleme1.Visible = true;
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void calisanislemleri_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            calisan1.Visible = true;
        }

        private void calisanduzenle_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            calisanDuzenle1.Visible = true;
        }

        private void calisanDuzenle1_Load(object sender, EventArgs e)
        {

        }

        private void ayarlar_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            ayarlar1.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void board_Click(object sender, EventArgs e)
        {
        }
    }
}