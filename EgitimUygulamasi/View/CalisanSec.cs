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
    public partial class CalisanSec : Form
    {
        private ICalisanSec main;

        public CalisanSec()
        {
            InitializeComponent();
        }

        class Tip { public int ID { get; set; } public string AdSoyad { get; set; } }
        public void SetMain(ICalisanSec main)
        {
            this.main = main;
            List<Model.Calisan> Calisanlar = Database.Select.Calisanlar();

            foreach (var i in Calisanlar)
            {
                listBox1.Items.Add(new Tip { ID = i.ID, AdSoyad = i.Ad + " " + i.Soyad + " " + i.Kadi });
            }
            listBox1.DisplayMember = "AdSoyad";
            listBox1.ValueMember = "ID";
        }

        private void CalisanSec_Load(object sender, EventArgs e)
        {

        }

        public void Sec()
        {
            List<int> CalisanIDs = new List<int>();
            foreach (var i in listBox1.SelectedItems)
            {
                var value = (Tip)i;
                CalisanIDs.Add(value.ID);
            }

            main.CalisanSecildi(CalisanIDs);
        }
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Sec();
            this.Dispose();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            HepsiniSec();
        }

        public void HepsiniSec()
        {
            for (var i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }
    }
}
