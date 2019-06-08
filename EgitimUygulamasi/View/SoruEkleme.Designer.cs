namespace EgitimUygulamasi.View
{
    partial class SoruEkleme
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoruEkleme));
            this.imageLists = new System.Windows.Forms.ListBox();
            this.txtAra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnYukle = new MaterialSkin.Controls.MaterialRaisedButton();
            this.soru = new System.Windows.Forms.TabControl();
            this.sorupage = new System.Windows.Forms.TabPage();
            this.btnIlerle = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblSaniye = new MaterialSkin.Controls.MaterialLabel();
            this.cmbZorluk = new MetroFramework.Controls.MetroComboBox();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtSoruBasligi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSure = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.secenektab = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbDogru = new MetroFramework.Controls.MetroComboBox();
            this.txtE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtD = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkKlasik = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnTamEkran = new MaterialSkin.Controls.MaterialFlatButton();
            this.videoMedya = new AxWMPLib.AxWindowsMediaPlayer();
            this.soru.SuspendLayout();
            this.sorupage.SuspendLayout();
            this.secenektab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLists
            // 
            this.imageLists.FormattingEnabled = true;
            this.imageLists.Location = new System.Drawing.Point(10, 224);
            this.imageLists.Name = "imageLists";
            this.imageLists.Size = new System.Drawing.Size(223, 225);
            this.imageLists.TabIndex = 12;
            this.imageLists.SelectedIndexChanged += new System.EventHandler(this.imageLists_SelectedIndexChanged);
            // 
            // txtAra
            // 
            this.txtAra.Depth = 0;
            this.txtAra.Hint = "İçerik arayın";
            this.txtAra.Location = new System.Drawing.Point(10, 39);
            this.txtAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(169, 23);
            this.txtAra.TabIndex = 15;
            this.txtAra.UseSystemPasswordChar = false;
            // 
            // btnYukle
            // 
            this.btnYukle.Depth = 0;
            this.btnYukle.Location = new System.Drawing.Point(10, 455);
            this.btnYukle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Primary = true;
            this.btnYukle.Size = new System.Drawing.Size(223, 46);
            this.btnYukle.TabIndex = 14;
            this.btnYukle.Text = "Yeni İçerik Yükle";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // soru
            // 
            this.soru.Controls.Add(this.sorupage);
            this.soru.Controls.Add(this.secenektab);
            this.soru.ItemSize = new System.Drawing.Size(178, 18);
            this.soru.Location = new System.Drawing.Point(239, 68);
            this.soru.Multiline = true;
            this.soru.Name = "soru";
            this.soru.SelectedIndex = 0;
            this.soru.Size = new System.Drawing.Size(510, 430);
            this.soru.TabIndex = 0;
            // 
            // sorupage
            // 
            this.sorupage.BackColor = System.Drawing.Color.White;
            this.sorupage.Controls.Add(this.btnIlerle);
            this.sorupage.Controls.Add(this.lblSaniye);
            this.sorupage.Controls.Add(this.cmbZorluk);
            this.sorupage.Controls.Add(this.cmbKategori);
            this.sorupage.Controls.Add(this.txtSoruBasligi);
            this.sorupage.Controls.Add(this.txtSure);
            this.sorupage.Location = new System.Drawing.Point(4, 22);
            this.sorupage.Name = "sorupage";
            this.sorupage.Padding = new System.Windows.Forms.Padding(3);
            this.sorupage.Size = new System.Drawing.Size(502, 404);
            this.sorupage.TabIndex = 0;
            this.sorupage.Text = "Soru";
            // 
            // btnIlerle
            // 
            this.btnIlerle.AutoSize = true;
            this.btnIlerle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlerle.Depth = 0;
            this.btnIlerle.Location = new System.Drawing.Point(385, 263);
            this.btnIlerle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIlerle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIlerle.Name = "btnIlerle";
            this.btnIlerle.Primary = false;
            this.btnIlerle.Size = new System.Drawing.Size(55, 36);
            this.btnIlerle.TabIndex = 5;
            this.btnIlerle.Text = "ilerle";
            this.btnIlerle.UseVisualStyleBackColor = true;
            this.btnIlerle.Click += new System.EventHandler(this.btnIlerle_Click);
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.Depth = 0;
            this.lblSaniye.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSaniye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSaniye.Location = new System.Drawing.Point(415, 235);
            this.lblSaniye.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(25, 19);
            this.lblSaniye.TabIndex = 3;
            this.lblSaniye.Text = "sn";
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.ItemHeight = 23;
            this.cmbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorluk.Location = new System.Drawing.Point(75, 196);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.PromptText = "Zorluk Seviyesi seçin";
            this.cmbZorluk.Size = new System.Drawing.Size(365, 29);
            this.cmbZorluk.TabIndex = 3;
            this.cmbZorluk.TabStop = false;
            this.cmbZorluk.UseSelectable = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(75, 161);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori seçin";
            this.cmbKategori.Size = new System.Drawing.Size(365, 29);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.TabStop = false;
            this.cmbKategori.UseSelectable = true;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtSoruBasligi
            // 
            this.txtSoruBasligi.Depth = 0;
            this.txtSoruBasligi.Hint = "Soru Başlığı";
            this.txtSoruBasligi.Location = new System.Drawing.Point(75, 129);
            this.txtSoruBasligi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoruBasligi.Name = "txtSoruBasligi";
            this.txtSoruBasligi.PasswordChar = '\0';
            this.txtSoruBasligi.SelectedText = "";
            this.txtSoruBasligi.SelectionLength = 0;
            this.txtSoruBasligi.SelectionStart = 0;
            this.txtSoruBasligi.Size = new System.Drawing.Size(365, 23);
            this.txtSoruBasligi.TabIndex = 1;
            this.txtSoruBasligi.TabStop = false;
            this.txtSoruBasligi.UseSystemPasswordChar = false;
            // 
            // txtSure
            // 
            this.txtSure.Depth = 0;
            this.txtSure.Hint = "Süre";
            this.txtSure.Location = new System.Drawing.Point(79, 231);
            this.txtSure.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSure.Name = "txtSure";
            this.txtSure.PasswordChar = '\0';
            this.txtSure.SelectedText = "";
            this.txtSure.SelectionLength = 0;
            this.txtSure.SelectionStart = 0;
            this.txtSure.Size = new System.Drawing.Size(330, 23);
            this.txtSure.TabIndex = 4;
            this.txtSure.TabStop = false;
            this.txtSure.UseSystemPasswordChar = false;
            // 
            // secenektab
            // 
            this.secenektab.BackColor = System.Drawing.Color.White;
            this.secenektab.Controls.Add(this.materialFlatButton1);
            this.secenektab.Controls.Add(this.cmbDogru);
            this.secenektab.Controls.Add(this.txtE);
            this.secenektab.Controls.Add(this.txtD);
            this.secenektab.Controls.Add(this.txtC);
            this.secenektab.Controls.Add(this.txtB);
            this.secenektab.Controls.Add(this.txtA);
            this.secenektab.Location = new System.Drawing.Point(4, 22);
            this.secenektab.Name = "secenektab";
            this.secenektab.Padding = new System.Windows.Forms.Padding(3);
            this.secenektab.Size = new System.Drawing.Size(502, 404);
            this.secenektab.TabIndex = 1;
            this.secenektab.Text = "Seçenekler";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(374, 276);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.ItemHeight = 23;
            this.cmbDogru.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbDogru.Location = new System.Drawing.Point(72, 242);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.PromptText = "Doğru Seçeneği Seçin";
            this.cmbDogru.Size = new System.Drawing.Size(365, 29);
            this.cmbDogru.TabIndex = 11;
            this.cmbDogru.TabStop = false;
            this.cmbDogru.UseSelectable = true;
            this.cmbDogru.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // txtE
            // 
            this.txtE.Depth = 0;
            this.txtE.Hint = "E seçeneği";
            this.txtE.Location = new System.Drawing.Point(72, 212);
            this.txtE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtE.Name = "txtE";
            this.txtE.PasswordChar = '\0';
            this.txtE.SelectedText = "";
            this.txtE.SelectionLength = 0;
            this.txtE.SelectionStart = 0;
            this.txtE.Size = new System.Drawing.Size(365, 23);
            this.txtE.TabIndex = 10;
            this.txtE.TabStop = false;
            this.txtE.UseSystemPasswordChar = false;
            this.txtE.Click += new System.EventHandler(this.txtE_Click);
            // 
            // txtD
            // 
            this.txtD.Depth = 0;
            this.txtD.Hint = "D seçeneği";
            this.txtD.Location = new System.Drawing.Point(72, 183);
            this.txtD.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtD.Name = "txtD";
            this.txtD.PasswordChar = '\0';
            this.txtD.SelectedText = "";
            this.txtD.SelectionLength = 0;
            this.txtD.SelectionStart = 0;
            this.txtD.Size = new System.Drawing.Size(365, 23);
            this.txtD.TabIndex = 9;
            this.txtD.TabStop = false;
            this.txtD.UseSystemPasswordChar = false;
            this.txtD.Click += new System.EventHandler(this.txtD_Click);
            // 
            // txtC
            // 
            this.txtC.Depth = 0;
            this.txtC.Hint = "C seçeneği";
            this.txtC.Location = new System.Drawing.Point(72, 154);
            this.txtC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtC.Name = "txtC";
            this.txtC.PasswordChar = '\0';
            this.txtC.SelectedText = "";
            this.txtC.SelectionLength = 0;
            this.txtC.SelectionStart = 0;
            this.txtC.Size = new System.Drawing.Size(365, 23);
            this.txtC.TabIndex = 8;
            this.txtC.TabStop = false;
            this.txtC.UseSystemPasswordChar = false;
            this.txtC.Click += new System.EventHandler(this.txtC_Click);
            // 
            // txtB
            // 
            this.txtB.Depth = 0;
            this.txtB.Hint = "B seçeneği";
            this.txtB.Location = new System.Drawing.Point(72, 125);
            this.txtB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB.Name = "txtB";
            this.txtB.PasswordChar = '\0';
            this.txtB.SelectedText = "";
            this.txtB.SelectionLength = 0;
            this.txtB.SelectionStart = 0;
            this.txtB.Size = new System.Drawing.Size(365, 23);
            this.txtB.TabIndex = 7;
            this.txtB.TabStop = false;
            this.txtB.UseSystemPasswordChar = false;
            this.txtB.Click += new System.EventHandler(this.txtB_Click);
            // 
            // txtA
            // 
            this.txtA.Depth = 0;
            this.txtA.Hint = "A seçeneği";
            this.txtA.Location = new System.Drawing.Point(72, 96);
            this.txtA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtA.Name = "txtA";
            this.txtA.PasswordChar = '\0';
            this.txtA.SelectedText = "";
            this.txtA.SelectionLength = 0;
            this.txtA.SelectionStart = 0;
            this.txtA.Size = new System.Drawing.Size(365, 23);
            this.txtA.TabIndex = 6;
            this.txtA.TabStop = false;
            this.txtA.UseSystemPasswordChar = false;
            this.txtA.Click += new System.EventHandler(this.txtA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // checkKlasik
            // 
            this.checkKlasik.AutoSize = true;
            this.checkKlasik.Depth = 0;
            this.checkKlasik.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkKlasik.Location = new System.Drawing.Point(646, 57);
            this.checkKlasik.Margin = new System.Windows.Forms.Padding(0);
            this.checkKlasik.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkKlasik.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkKlasik.Name = "checkKlasik";
            this.checkKlasik.Ripple = true;
            this.checkKlasik.Size = new System.Drawing.Size(99, 30);
            this.checkKlasik.TabIndex = 16;
            this.checkKlasik.Text = "Klasik Soru";
            this.checkKlasik.UseVisualStyleBackColor = true;
            this.checkKlasik.CheckedChanged += new System.EventHandler(this.checkKlasik_CheckedChanged);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.AutoSize = true;
            this.btnTamEkran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTamEkran.Depth = 0;
            this.btnTamEkran.Location = new System.Drawing.Point(176, 30);
            this.btnTamEkran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamEkran.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Primary = false;
            this.btnTamEkran.Size = new System.Drawing.Size(89, 36);
            this.btnTamEkran.TabIndex = 17;
            this.btnTamEkran.Text = "tam ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Visible = false;
            this.btnTamEkran.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // videoMedya
            // 
            this.videoMedya.Enabled = true;
            this.videoMedya.Location = new System.Drawing.Point(10, 68);
            this.videoMedya.Name = "videoMedya";
            this.videoMedya.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoMedya.OcxState")));
            this.videoMedya.Size = new System.Drawing.Size(223, 150);
            this.videoMedya.TabIndex = 18;
            this.videoMedya.Visible = false;
            // 
            // SoruEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoMedya);
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.checkKlasik);
            this.Controls.Add(this.soru);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.imageLists);
            this.Name = "SoruEkleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.SoruEkleme_Load);
            this.soru.ResumeLayout(false);
            this.sorupage.ResumeLayout(false);
            this.sorupage.PerformLayout();
            this.secenektab.ResumeLayout(false);
            this.secenektab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox imageLists;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAra;
        private MaterialSkin.Controls.MaterialRaisedButton btnYukle;
        private System.Windows.Forms.TabControl soru;
        private System.Windows.Forms.TabPage sorupage;
        private System.Windows.Forms.TabPage secenektab;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSure;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MetroFramework.Controls.MetroComboBox cmbZorluk;
        private MaterialSkin.Controls.MaterialLabel lblSaniye;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoruBasligi;
        private MaterialSkin.Controls.MaterialFlatButton btnIlerle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtE;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtD;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtA;
        private MetroFramework.Controls.MetroComboBox cmbDogru;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCheckBox checkKlasik;
        private MaterialSkin.Controls.MaterialFlatButton btnTamEkran;
        private AxWMPLib.AxWindowsMediaPlayer videoMedya;
    }
}
