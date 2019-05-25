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

        public QuestionScreen()
        {
            InitializeComponent();
            stepOneApp1.setMain(this);
            soruEkrani1.setMain(this);
            medyaEkraniSoru1.setMain(this);
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
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        public void SoruAktarici(string kategori, string zorluk)
        {
            List<Model.BirlesikSoru> sorular = Database.Select.SorulariCek(kategori, zorluk);

        }

        private void stepOneApp1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void soruEkrani1_Load(object sender, EventArgs e)
        {

        }

        private void medyaEkraniSoru1_Load(object sender, EventArgs e)
        {

        }
    }
}
