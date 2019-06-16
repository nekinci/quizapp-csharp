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
    public partial class TemaAyarlari : Form
    {
        private Model.MainTema tema1;
        private Model.LoginTema tema2;
        public TemaAyarlari()
        {
            InitializeComponent();
        }

        private void materialDivider4_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solmenuustbaslik.BackColor = colorDialog1.Color;
                tema1.SolUstArka = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void TemaAyarlari_Load(object sender, EventArgs e)
        {
            tema1 = Database.Select.MainTema(1);
            tema2 = Database.Select.LoginTema(1);
            if (tema1 == null || tema2 == null)
            {
                MessageBox.Show("Bir sorun oluştu tema ayarları yüklenemedi.");
                this.Dispose();
                return;
            }
            solmenuarka.BackColor = ColorTranslator.FromHtml(tema1.SolMenuArka);
            solmenubuton.BackColor = ColorTranslator.FromHtml(tema1.SolMenuButon);
            solmenubutonyazi.BackColor = ColorTranslator.FromHtml(tema1.SolMenuButonYazi);
            solmenuustbaslik.BackColor = ColorTranslator.FromHtml(tema1.SolUstArka);
            solmenuustbaslikyazi.BackColor = ColorTranslator.FromHtml(tema1.SolUstOn);
            sagustyazi.BackColor = ColorTranslator.FromHtml(tema1.SagUstYazi);
            sagustarka.BackColor = ColorTranslator.FromHtml(tema1.SagUstArka);
            oturumukapatarka.BackColor = ColorTranslator.FromHtml(tema1.OturumuKapatArka);
            oturumukapatyazi.BackColor = ColorTranslator.FromHtml(tema1.OturumuKapatOn);
            btnHoverr.BackColor = ColorTranslator.FromHtml(tema1.ButonHover);

            toggleLogin.Checked = tema2.LoginSabit;
            if (toggleLogin.Checked == false)
                panel1.Enabled = false;
            loginsag.BackColor = ColorTranslator.FromHtml(tema2.Sag);
            solloginarka.BackColor = ColorTranslator.FromHtml(tema2.SolArka);
            solloginyazi.BackColor = ColorTranslator.FromHtml(tema2.SolYazi);
            txtLogin1.Text = tema2.Yazi1;
            txtLogin2.Text = tema2.Yazi2;
        }

        private void btnSolArka_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solmenuarka.BackColor = colorDialog1.Color;
                tema1.SolMenuArka = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solmenubuton.BackColor = colorDialog1.Color;
                tema1.SolMenuButon = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSolYazi_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solmenubutonyazi.BackColor = colorDialog1.Color;
                tema1.SolMenuButonYazi = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSolBaslikYazi_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solmenuustbaslikyazi.BackColor = colorDialog1.Color;
                tema1.SolUstOn = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSagUstYazi_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                sagustyazi.BackColor = colorDialog1.Color;
                tema1.SagUstYazi = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnOturumuKapatArka_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                oturumukapatarka.BackColor = colorDialog1.Color;
                tema1.OturumuKapatArka = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnOturumuKapatOn_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                oturumukapatyazi.BackColor = colorDialog1.Color;
                tema1.OturumuKapatOn = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSagUstArka_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                sagustarka.BackColor = colorDialog1.Color;
                tema1.SagUstArka = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            tema1 = Database.Select.MainTema(2);
            tema1.ID = 1;

            if (Database.Update.MainTemaGuncelle(tema1))
                MessageBox.Show("Başarıyla güncellendi. Değişikliklerin etkin olabilmesi için uygulamayı yeniden başlatmalısınız.");
            else
                MessageBox.Show("Güncellenemedi.");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Database.Update.MainTemaGuncelle(tema1))
                MessageBox.Show("Başarıyla güncellendi. Değişikliklerin etkin olabilmesi için uygulamayı yeniden başlatmalısınız.");
            else
                MessageBox.Show("Güncellenemedi.");
        }

        private void btnLoginSolArka_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solloginarka.BackColor = colorDialog1.Color;
                tema2.SolArka = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnLoginSolYazi_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                solloginyazi.BackColor = colorDialog1.Color;
                tema2.SolYazi = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnSagArkaplan_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                loginsag.BackColor = colorDialog1.Color;
                tema2.Sag = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }

        private void btnKaydet1_Click(object sender, EventArgs e)
        {
            tema2.LoginSabit = toggleLogin.Checked;
            tema2.Yazi1 = txtLogin1.Text;
            tema2.Yazi2 = txtLogin2.Text;

            if (Database.Update.LoginTemaGuncelle(tema2))
                MessageBox.Show("Başarıyla güncellendi. Değişikliklerin etkin olabilmesi için uygulamayı yeniden başlatmalısınız.");
            else
                MessageBox.Show("Güncellenemedi.");
        }

        private void btnDefaultTema_Click(object sender, EventArgs e)
        {
            tema2 = Database.Select.LoginTema(2);
            tema2.ID = 1;

            if (Database.Update.LoginTemaGuncelle(tema2))
                MessageBox.Show("Başarıyla güncellendi. Değişikliklerin etkin olabilmesi için uygulamayı yeniden başlatmalısınız.");
            else
                MessageBox.Show("Güncellenemedi.");
        }

        private void toggleLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleLogin.Checked)
                panel1.Enabled = true;
            else
                panel1.Enabled = false;
        }

        private void btnHover_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnHoverr.BackColor = colorDialog1.Color;
                tema1.ButonHover = ColorTranslator.ToHtml(colorDialog1.Color);
            }
        }
    }
}
