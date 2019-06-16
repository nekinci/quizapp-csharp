using EgitimUygulamasi.Database;
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
    public partial class Login : Form
    {


        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            if (!Database.Select.AdminVarmi())
            {
                AdminKaydi kayit = new AdminKaydi();
                kayit.Show();
            }
            InitializeComponent();

            Model.LoginTema tema = Database.Select.LoginTema(1);

            if(tema != null)
            {
                if (tema.LoginSabit)
                {
                    timer1.Stop();
                    pnlSol.BackColor = ColorTranslator.FromHtml(tema.SolArka);
                    label1.ForeColor = ColorTranslator.FromHtml(tema.SolYazi);
                    label2.ForeColor = ColorTranslator.FromHtml(tema.SolYazi);
                }
                else
                {
                    timer1.Interval = 30;
                    timer1.Start();
                }

                panel2.BackColor = ColorTranslator.FromHtml(tema.Sag);
                label1.Text = tema.Yazi2;
                label2.Text = tema.Yazi1;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (cmbGirisTuru.SelectedIndex < 0)
            {
                MessageBox.Show("Giriş türü seçmediniz.");
            }
            else
            {
                if (cmbGirisTuru.SelectedIndex == 0)
                {
                    bool kontrol = Database.Select.KullaniciGirisKontrol(txtKullaniciAdi.Text, MD5Sifreleme.MD5Sifrele(txtSifre.Text));
                    if (kontrol)
                    {
                        Session.OturumAc(txtKullaniciAdi.Text);
                        this.Hide();
                        QuestionScreen qs = new QuestionScreen();
                        qs.Show();
                    }
                    else
                    {
                        MessageBox.Show("Girilen kullanıcı adı veya şifre hatalı");
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                    }
                }
                else
                {
                    bool kontrol = Database.Select.AdminGirisiKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                    if (kontrol)
                    {
                        Session.OturumAc(txtKullaniciAdi.Text);
                        this.Hide();
                        Main m = new Main();
                        m.Show();
                    }
                    else
                    {
                        MessageBox.Show("Girilen kullanıcı adı / veya şifre hatalı!");
                        txtKullaniciAdi.Clear();
                        txtSifre.Clear();
                    }

                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        int i = 0;
        int j = 0;
        int k = 0;
        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!flag)
            {
                if (i == 255 && j < 255)
                    j++;
                if (j == 255 && k < 255)
                    k++;
                if (i < 255)
                    i++;
            }
            else
            {
                if (i == 0 && j > 0)
                    j--;
                if (j == 0 && k > 0)
                    k--;
                if (i > 0)
                    i--;
            }
            if (i == 255 && j == 255 && k == 255)
                flag = true;
            if (i == 0 && j == 0 && k == 0)
                flag = false;
            pnlSol.BackColor = Color.FromArgb(0 + i, 0 + j, 0 + k);
            label1.ForeColor = Color.FromArgb(pnlSol.BackColor.ToArgb() ^ 0xffffff);
            label2.ForeColor = Color.FromArgb(pnlSol.BackColor.ToArgb() ^ 0xffffff);
        }


        private void pnlSol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap_Click(sender, e);
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbGirisTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGirisTuru_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbGirisTuru.SelectedIndex == 1)
            {
                materialFlatButton1.Visible = true;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            SifremiUnuttum s = new SifremiUnuttum();
            s.Show();
        }
    }
}
