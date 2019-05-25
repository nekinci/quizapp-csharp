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
        public Login()
        {
            InitializeComponent();
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
                if ( cmbGirisTuru . SelectedIndex == 0)
                {
                    this.Hide();
                    QuestionScreen qs = new QuestionScreen();
                    qs.Show();
                }
                else
                {
                    bool kontrol = Database.Select.AdminGirisiKontrol(txtKullaniciAdi.Text, txtSifre.Text);
                    if (kontrol)
                    {
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
            timer1.Interval = 30;
            timer1.Start();
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
            label1.ForeColor = Color.FromArgb(pnlSol.BackColor.ToArgb()^0xffffff);
            label2.ForeColor = Color.FromArgb(pnlSol.BackColor.ToArgb() ^ 0xffffff);
        }

        private void pnlSol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
