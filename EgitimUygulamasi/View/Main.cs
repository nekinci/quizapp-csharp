using EgitimUygulamasi.Database;
using EgitimUygulamasi.Model;
using EgitimUygulamasi.View;
using MaterialSkin.Controls;
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
        List<Bildirim> bildirimler = Database.Select.BildirimleriCek();
        List<Button> butonlar = new List<Button>();

        /* Bildirim gösterme Sınırı */
        private readonly int Sinir = 5;


        public Main()
        {
            InitializeComponent();
            calisan1.setMain(this);
            calisanDuzenle1.setMain(this);
            kategoriDuzenleme1.setMain(this);
            kategoriEkleme1.setMain(this);
            soruDuzenleme1.setMain(this);
            klasikCevaplar1.SetMain(this);
            soruEkleme1.setMain(this);
            profil1.set_Main(this);
            odulCeza1.setMain(this);
            ayarlar1.setMain(this);
            cezaOdulBelirleme1.setMain(this);

            if (bildirimler.FindAll(x => x.GorulduMu == false).Count > 0)
                btnBildirim.Image = Properties.Resources.bildirimvar;
            else
                btnBildirim.Image = Properties.Resources.bildirimyok;

            bildirimler = bildirimler.OrderByDescending(x => x.Tarih).ToList();
            foreach (var i in bildirimler.FindAll(x => x.OkunduMu == false).Take(Sinir))
            {
                UCBildirim bildirim = new UCBildirim();
                bildirim.Main = this;
                bildirim.SetBildirim(i);
                flowLayoutPanel1.Controls.Add(bildirim);
            }

            if (bildirimler.FindAll(x => x.OkunduMu == false).Count <= 0)
            {
                Label label = new Label();
                label.Text = "Okunmamış bildiriminiz yok.";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = false;
                label.Size = new Size(flowLayoutPanel1.Size.Width, 30);
                flowLayoutPanel1.Controls.Add(label);
            }

            MaterialFlatButton tumunugor = new MaterialFlatButton();
            tumunugor.Text = "Tümünü gör";
            tumunugor.Dock = DockStyle.Bottom;

            tumunugor.Click += Tumunugor_Click;
            flowLayoutPanel1.Controls.Add(tumunugor);
            butonlar.Add(board);
            butonlar.Add(kategoriduzenle);
            butonlar.Add(kategoriekle);
            butonlar.Add(soruekle);
            butonlar.Add(soruduzenle);
            butonlar.Add(calisanduzenle);
            butonlar.Add(calisanislemleri);
            butonlar.Add(ayarlar);
            butonlar.Add(temaayarlari);
            butonlar.Add(odulcezabelirle);
            MainTema tema = Database.Select.MainTema(1);

            if (tema != null)
            {
                foreach(var i in butonlar)
                {
                    i.BackColor = ColorTranslator.FromHtml(tema.SolMenuButon);
                    i.ForeColor = ColorTranslator.FromHtml(tema.SolMenuButonYazi);
                    i.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(tema.ButonHover);
                    i.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml(tema.ButonHover);
                }

                btnOturumuKapat.BackColor = ColorTranslator.FromHtml(tema.OturumuKapatArka);
                btnOturumuKapat.ForeColor = ColorTranslator.FromHtml(tema.OturumuKapatOn);
                pnlMenu.BackColor = ColorTranslator.FromHtml(tema.SolMenuArka);
                panel3.BackColor = ColorTranslator.FromHtml(tema.SolUstArka);
                label1.ForeColor = ColorTranslator.FromHtml(tema.SolUstOn);
                label2.ForeColor = ColorTranslator.FromHtml(tema.SagUstYazi);
                panel2.BackColor = ColorTranslator.FromHtml(tema.SagUstArka);
            }


        }

        private void Tumunugor_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = false;
            HepsiniGizle();
            klasikCevaplar1.Visible = true;
        }

        public void CevapGoster(KlasikCevap cevap)
        {
            flowLayoutPanel1.Visible = false;
            HepsiniGizle();
            klasikCevaplar1.Visible = true;
            klasikCevaplar1.SeciliCevap(cevap);
        }
        public void YenidenCiz()
        {
            soruDuzenleme1.yenidenCiz();
            soruEkleme1.yenidenCiz();
            kategoriDuzenleme1.yenidenCiz();
            calisanDuzenle1.yenidenCiz();
            klasikCevaplar1.yenidenCiz();
            board1.yenidenCiz();
            cezaOdulBelirleme1.yenidenCiz();
            odulCeza1.yenidenCiz();
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
            board1.Visible = false;
            profil1.Visible = false;
            kategoriEkleme1.Visible = false;
            soruEkleme1.Visible = false;
            soruDuzenleme1.Visible = false;
            kategoriDuzenleme1.Visible = false;
            calisan1.Visible = false;
            calisanDuzenle1.Visible = false;
            ayarlar1.Visible = false;
            klasikCevaplar1.Visible = false;
            odulCeza1.Visible = false;
            cezaOdulBelirleme1.Visible = false;
            flowLayoutPanel1.BringToFront();

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


        private void ayarlar_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            ayarlar1.Visible = true;
        }


        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var i in bildirimler.FindAll(x => !x.OkunduMu).Take(Sinir))
            {
                i.GorulduMu = true;
                Database.Update.BildirimGoruldu(i);
            }
            btnBildirim.Image = Properties.Resources.bildirimyok;
            flowLayoutPanel1.Visible = !flowLayoutPanel1.Visible;
        }

        private void ayarlar1_Load(object sender, EventArgs e)
        {

        }

        private void calisanDuzenle1_Load(object sender, EventArgs e)
        {

        }

        private void soruDuzenleme1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void klasikCevaplar1_Load(object sender, EventArgs e)
        {

        }

        private void uıProfil1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            profil1.Visible = !profil1.Visible;
        }

        private void temaayarlari_Click(object sender, EventArgs e)
        {
            TemaAyarlari tema = new TemaAyarlari();
            tema.Show();
        }

        private void board_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            board1.Visible = true;
        }

        private void odulceza_Click(object sender, EventArgs e)
        {
            HepsiniGizle();
            cezaOdulBelirleme1.Visible = true;
        }

        private void btnCikis_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
        }

        private void cezaOdulBelirleme1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HepsiniGizle();
            odulCeza1.Visible = true;
        }
    }
}