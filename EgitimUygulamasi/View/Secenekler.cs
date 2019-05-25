using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EgitimUygulamasi.Model;
using EgitimUygulamasi.Database;
using System.Diagnostics;
using MaterialSkin.Controls;

namespace EgitimUygulamasi.View
{
    public partial class Secenekler : UserControl
    {
        public Secenekler()
        {
            InitializeComponent();
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Model.Secenekler _secenekler = new Model.Secenekler();

            if (VerifyTexts())
            {
                _secenekler.ASecenegi = asecenegi.Text;
                _secenekler.BSecenegi = bsecenegi.Text;
                _secenekler.CSecenegi = csecenegi.Text;
                _secenekler.DSecenegi = dsecenegi.Text;
                _secenekler.ESecenegi = esecenegi.Text;
                _secenekler.DogruCevap = cmbDogruSecenekl.SelectedItem.ToString();

                KomponentTemizle();
            }
        }

        public bool VerifyTexts()
        {
            bool kontrol = true;
            string message = "";
            if(asecenegi.Text == "")
            {
                message += "A seçeneği girilmedi.\n";
                kontrol = false;
            }
            if(bsecenegi.Text == "")
            {
                message += "B seçeneği girilmedi.\n";
                kontrol = false;
            }

            if(csecenegi.Text == "")
            {
                message += "C seçeneği girilmedi.\n";
                kontrol = false;
            }
            if(dsecenegi.Text == "")
            {
                message += "D seçeneği girilmedi. \n";
                kontrol = false;
            }
            if(esecenegi.Text == "")
            {
                message += "E seçeneği girilmedi. \n";
                    kontrol = false;
            }
            if(cmbDogruSecenekl.SelectedIndex < 0)
            {
                message += "Doğru cevap belirtilmedi.";
                kontrol = false;
            }
            if (!kontrol)
                MessageBox.Show(message);

            return kontrol;
        }

        public void KomponentTemizle()
        {
            asecenegi.Clear();
            bsecenegi.Clear();
            csecenegi.Clear();
            dsecenegi.Clear();
            esecenegi.Clear();
            cmbDogruSecenekl.SelectedIndex = -1;
            
        }


        private void Secenekler_Load(object sender, EventArgs e)
        {
            
        }

        public void SoruCek(Soru _soru)
        {
            this._soru = _soru;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            KomponentTemizle();
        }
    }
}
