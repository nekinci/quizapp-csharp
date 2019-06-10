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

namespace EgitimUygulamasi.View
{
    public partial class SoruEkrani : UserControl
    {
        private QuestionScreen main;
        public SoruEkrani()
        {
            InitializeComponent();
        }

        public void setMain(QuestionScreen main)
        {
            this.main = main;
        }
        private int soru_id;
        private int sure;
        private int tmpsure;
        private bool KlasikSoru;
        private BirlesikSoru soru;
        public void SoruCek(BirlesikSoru soru)
        {
            this.Visible = true;
            this.soru = soru;

            sure = soru.soru.Sure;
            tmpsure = soru.soru.Sure;
            soru_id = soru.soru.ID;
            KlasikSoru = soru.soru.KlasikSoru;
            lblSoruBasligi.Text = soru.soru.SoruBasligi;

            if (KlasikSoru)
            {
                asecenegi.Visible = false;
                bsecenegi.Visible = false;
                csecenegi.Visible = false;
                dsecenegi.Visible = false;
                esecenegi.Visible = false;
                richTextBox1.Visible = true;
                btnKlasikCevap.Visible = true;
            }

            asecenegi.Text = soru.secenekler.ASecenegi;
            bsecenegi.Text = soru.secenekler.BSecenegi;
            csecenegi.Text = soru.secenekler.CSecenegi;
            dsecenegi.Text = soru.secenekler.DSecenegi;
            esecenegi.Text = soru.secenekler.ESecenegi;


            timer1.Interval = 1000;
            timer1.Start();
        }

        private void SoruEkrani_Load(object sender, EventArgs e)
        {

        }

        private void DogruCevap(string cevap)
        {
            timer1.Stop();
            MessageBox.Show("Doğru bildiniz!");
            SecenekleriKapat();

            Database.Update.PuanGuncelle(Session.KullaniciAdiAl(), SoruBilgileri.ZorlukSeviyesi, true, false);
            SoruSorulma s = new SoruSorulma();
            s.CalisanID = Database.Select.CalisanCekID(Session.KullaniciAdiAl());
            s.SoruID = soru_id;
            s.Tarih = DateTime.Now;
            s.Sure = tmpsure - sure;
            s.Cevap = cevap;

            if (!Database.Select.SorulmaKontrol(s))
                Database.Insert.SoruSoruldu(s);
            else
                Database.Update.SoruSoruldu(s);
        }

        private void SecenekleriKapat()
        {
            asecenegi.Enabled = false;
            bsecenegi.Enabled = false;
            csecenegi.Enabled = false;
            dsecenegi.Enabled = false;
            esecenegi.Enabled = false;
        }

        private void YanlisCevap(string cevap)
        {
            timer1.Stop();
            MessageBox.Show("Bilemediniz. Puanınız güncellenmiştir.");
            SecenekleriKapat();

            Database.Update.PuanGuncelle(Session.KullaniciAdiAl(), SoruBilgileri.ZorlukSeviyesi, false, false);
            SoruSorulma s = new SoruSorulma();
            s.CalisanID = Database.Select.CalisanCekID(Session.KullaniciAdiAl());
            s.SoruID = soru_id;
            s.Tarih = DateTime.Now;
            s.Sure = tmpsure - sure;
            s.Cevap = cevap;
            if (!Database.Select.SorulmaKontrol(s))
                Database.Insert.SoruSoruldu(s);
            else
                Database.Update.SoruSoruldu(s);

        }


        private void AnasayfayaDon()
        {
            this.main.AnasayfayaDon();
        }

        private bool Onayliyormusunuz()
        {

            DialogResult result = MessageBox.Show("Son kararınız mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void asecenegi_Click(object sender, EventArgs e)
        {

            if (Onayliyormusunuz())
            {
                if (soru.secenekler.DogruCevap == "A")
                {
                    DogruCevap("A");
                }
                else
                {
                    YanlisCevap("A");
                }

                AnasayfayaDon();
            }
        }

        private void bsecenegi_Click(object sender, EventArgs e)
        {
            if (Onayliyormusunuz())
            {
                if (soru.secenekler.DogruCevap == "B")
                {
                    DogruCevap("B");
                }
                else
                {
                    YanlisCevap("B");
                }
                AnasayfayaDon();
            }

        }

        private void csecenegi_Click(object sender, EventArgs e)
        {
            if (Onayliyormusunuz())
            {
                if (soru.secenekler.DogruCevap == "C")
                {
                    DogruCevap("C");
                }
                else
                {
                    YanlisCevap("C");
                }
                AnasayfayaDon();
            }

        }

        private void dsecenegi_Click(object sender, EventArgs e)
        {
            if (Onayliyormusunuz())
            {
                if (soru.secenekler.DogruCevap == "D")
                {
                    DogruCevap("D");
                }
                else
                {
                    YanlisCevap("D");
                }
                AnasayfayaDon();
            }

        }

        private void esecenegi_Click(object sender, EventArgs e)
        {
            if (Onayliyormusunuz())
            {
                if (soru.secenekler.DogruCevap == "E")
                {
                    DogruCevap("E");
                }
                else
                {
                    YanlisCevap("E");
                }
                AnasayfayaDon();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure > 0)
            {
                sure--;
                lblSure.Text = "Süre : " + sure;
                Console.WriteLine("sayiyo1r");
                
            }
            else
            {
                Console.WriteLine("sayiyor");
                timer1.Stop();
                MessageBox.Show("Süreniz doldu. Bilemediniz.");
                SecenekleriKapat();
                if (soru.soru.KlasikSoru)
                {
                    KlasikCevap("\n\nSüre Doldu.--Bu mesaj sistem tarafından otomatik olarak oluşturulmuştur. "+DateTime.Now);
                }
                else
                    YanlisCevap("S");

                AnasayfayaDon();
            }
        }

        private void cekil_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (Database.Select.AyarCek().GeriCekilme == 1)
                result = MessageBox.Show("Çekilmek istediğinize emin misiniz? Eğer Soruyu cevaplamadan çıkarsanız puanınız düşecektir.", "Uyarı", MessageBoxButtons.YesNo);
            else
                result = MessageBox.Show("Çekilmek istediğinize emin misiniz? Eğer Soruyu cevaplamadan çıkarsanız puanınız düşmeyecektir.", "Uyarı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                SecenekleriKapat();
                cekil.Enabled = false;
                Database.Update.PuanGuncelle(Session.KullaniciAdiAl(), SoruBilgileri.ZorlukSeviyesi, false, true);

                SoruSorulma s = new SoruSorulma();
                s.CalisanID = Database.Select.CalisanCekID(Session.KullaniciAdiAl());
                s.SoruID = soru_id;
                s.Tarih = DateTime.Now;
                s.Sure = tmpsure - sure;
                s.Cevap = "G";
                if (!Database.Select.SorulmaKontrol(s))
                    Database.Insert.SoruSoruldu(s);
                else
                    Database.Update.SoruSoruldu(s);

                AnasayfayaDon();
            }



        }


        private void KlasikCevap(string cevaps)
        {
            timer1.Stop();
            int calisan_id = Database.Select.CalisanCekID(Session.KullaniciAdiAl());
            KlasikCevap cevap = new KlasikCevap();
            cevap.ID = 0;
            cevap.CalisanID = calisan_id;
            cevap.SoruID = soru_id;
            cevap.Cevap = richTextBox1.Text + " "+cevaps;
            cevap.Tarih = DateTime.Now;
            try
            {
                Database.Insert.CevapEkle(cevap);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!" + ex.Message);
                return;
            }

            Bildirim b = new Bildirim();
            b.ID = 0;
            b.OkunduMu = false;
            b.GonderenID = calisan_id;
            b.SoruID = soru_id;
            b.CevapID = Database.Select.LastInsertedCevap();
            b.Tarih = DateTime.Now;
            b.GorulduMu = false;
            Database.Insert.BildirimOlustur(b);

            SoruSorulma s = new SoruSorulma();
            s.CalisanID = calisan_id;
            s.SoruID = soru_id;
            s.Tarih = DateTime.Now;
            s.Sure = tmpsure - sure;
            s.Cevap = "K";
            if (!Database.Select.SorulmaKontrol(s))
                Database.Insert.SoruSoruldu(s);
            else
                Database.Update.SoruSoruldu(s);

            AnasayfayaDon();
        }
        private void btnKlasikCevap_Click(object sender, EventArgs e)
        {
            if (!Onayliyormusunuz())
                return;

            KlasikCevap("");
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MedyaGor medya = new MedyaGor();
            medya.setMedya(soru.medya);
            medya.Show();
        }
    }
}
