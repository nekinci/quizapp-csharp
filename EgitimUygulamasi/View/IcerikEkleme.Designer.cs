namespace EgitimUygulamasi.View
{
    partial class IcerikEkleme
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.sorupage = new System.Windows.Forms.TabPage();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtIsim = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDosya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.vlcPlayer1 = new EgitimUygulamasi.View.VlcPlayer();
            this.soru = new System.Windows.Forms.TabControl();
            this.urlpage = new System.Windows.Forms.TabPage();
            this.vlcPlayer2 = new EgitimUygulamasi.View.VlcPlayer();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbKategori1 = new MetroFramework.Controls.MetroComboBox();
            this.txtURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIsim1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sorupage.SuspendLayout();
            this.soru.SuspendLayout();
            this.urlpage.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sorupage
            // 
            this.sorupage.BackColor = System.Drawing.Color.White;
            this.sorupage.Controls.Add(this.vlcPlayer1);
            this.sorupage.Controls.Add(this.materialFlatButton3);
            this.sorupage.Controls.Add(this.materialFlatButton2);
            this.sorupage.Controls.Add(this.materialFlatButton1);
            this.sorupage.Controls.Add(this.cmbKategori);
            this.sorupage.Controls.Add(this.txtDosya);
            this.sorupage.Controls.Add(this.txtIsim);
            this.sorupage.Location = new System.Drawing.Point(4, 22);
            this.sorupage.Name = "sorupage";
            this.sorupage.Padding = new System.Windows.Forms.Padding(3);
            this.sorupage.Size = new System.Drawing.Size(656, 451);
            this.sorupage.TabIndex = 0;
            this.sorupage.Text = "Dosya ile Yükleme (Bilgisayardan)";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(164, 303);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori Seçin";
            this.cmbKategori.Size = new System.Drawing.Size(326, 29);
            this.cmbKategori.TabIndex = 20;
            this.cmbKategori.UseSelectable = true;
            // 
            // txtIsim
            // 
            this.txtIsim.Depth = 0;
            this.txtIsim.Hint = "Dosyayı nasıl isimlendirmek istersiniz?";
            this.txtIsim.Location = new System.Drawing.Point(164, 263);
            this.txtIsim.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PasswordChar = '\0';
            this.txtIsim.SelectedText = "";
            this.txtIsim.SelectionLength = 0;
            this.txtIsim.SelectionStart = 0;
            this.txtIsim.Size = new System.Drawing.Size(326, 23);
            this.txtIsim.TabIndex = 21;
            this.txtIsim.UseSystemPasswordChar = false;
            // 
            // txtDosya
            // 
            this.txtDosya.Depth = 0;
            this.txtDosya.Hint = "Yükleyeceğiniz dosyayı seçin";
            this.txtDosya.Location = new System.Drawing.Point(164, 354);
            this.txtDosya.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.PasswordChar = '\0';
            this.txtDosya.SelectedText = "";
            this.txtDosya.SelectionLength = 0;
            this.txtDosya.SelectionStart = 0;
            this.txtDosya.Size = new System.Drawing.Size(262, 23);
            this.txtDosya.TabIndex = 22;
            this.txtDosya.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(433, 346);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 23;
            this.materialFlatButton1.Text = "Gözat";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(377, 394);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(113, 36);
            this.materialFlatButton2.TabIndex = 24;
            this.materialFlatButton2.Text = "Yükle&Kaydet";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(296, 394);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton3.TabIndex = 25;
            this.materialFlatButton3.Text = "Geri Dön";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // vlcPlayer1
            // 
            this.vlcPlayer1.Location = new System.Drawing.Point(150, 15);
            this.vlcPlayer1.Name = "vlcPlayer1";
            this.vlcPlayer1.Size = new System.Drawing.Size(340, 231);
            this.vlcPlayer1.TabIndex = 26;
            // 
            // soru
            // 
            this.soru.Controls.Add(this.sorupage);
            this.soru.Controls.Add(this.urlpage);
            this.soru.ItemSize = new System.Drawing.Size(178, 18);
            this.soru.Location = new System.Drawing.Point(45, 24);
            this.soru.Multiline = true;
            this.soru.Name = "soru";
            this.soru.SelectedIndex = 0;
            this.soru.Size = new System.Drawing.Size(664, 477);
            this.soru.TabIndex = 20;
            // 
            // urlpage
            // 
            this.urlpage.BackColor = System.Drawing.Color.White;
            this.urlpage.Controls.Add(this.vlcPlayer2);
            this.urlpage.Controls.Add(this.materialFlatButton6);
            this.urlpage.Controls.Add(this.materialFlatButton7);
            this.urlpage.Controls.Add(this.cmbKategori1);
            this.urlpage.Controls.Add(this.txtURL);
            this.urlpage.Controls.Add(this.txtIsim1);
            this.urlpage.Location = new System.Drawing.Point(4, 22);
            this.urlpage.Name = "urlpage";
            this.urlpage.Padding = new System.Windows.Forms.Padding(3);
            this.urlpage.Size = new System.Drawing.Size(656, 451);
            this.urlpage.TabIndex = 2;
            this.urlpage.Text = "URL ile yükleme";
            this.urlpage.UseVisualStyleBackColor = true;
            this.urlpage.Click += new System.EventHandler(this.urlpage_Click);
            // 
            // vlcPlayer2
            // 
            this.vlcPlayer2.Location = new System.Drawing.Point(150, 15);
            this.vlcPlayer2.Name = "vlcPlayer2";
            this.vlcPlayer2.Size = new System.Drawing.Size(340, 231);
            this.vlcPlayer2.TabIndex = 26;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Location = new System.Drawing.Point(296, 394);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton6.TabIndex = 25;
            this.materialFlatButton6.Text = "Geri Dön";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Location = new System.Drawing.Point(377, 394);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(113, 36);
            this.materialFlatButton7.TabIndex = 24;
            this.materialFlatButton7.Text = "Yükle&Kaydet";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            this.materialFlatButton7.Click += new System.EventHandler(this.materialFlatButton7_Click);
            // 
            // cmbKategori1
            // 
            this.cmbKategori1.FormattingEnabled = true;
            this.cmbKategori1.ItemHeight = 23;
            this.cmbKategori1.Location = new System.Drawing.Point(164, 303);
            this.cmbKategori1.Name = "cmbKategori1";
            this.cmbKategori1.PromptText = "Kategori Seçin";
            this.cmbKategori1.Size = new System.Drawing.Size(326, 29);
            this.cmbKategori1.TabIndex = 20;
            this.cmbKategori1.UseSelectable = true;
            // 
            // txtURL
            // 
            this.txtURL.Depth = 0;
            this.txtURL.Hint = "Medya URL";
            this.txtURL.Location = new System.Drawing.Point(164, 354);
            this.txtURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.Size = new System.Drawing.Size(326, 23);
            this.txtURL.TabIndex = 22;
            this.txtURL.UseSystemPasswordChar = false;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // txtIsim1
            // 
            this.txtIsim1.Depth = 0;
            this.txtIsim1.Hint = "Dosyayı nasıl isimlendirmek istersiniz?";
            this.txtIsim1.Location = new System.Drawing.Point(164, 263);
            this.txtIsim1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIsim1.Name = "txtIsim1";
            this.txtIsim1.PasswordChar = '\0';
            this.txtIsim1.SelectedText = "";
            this.txtIsim1.SelectionLength = 0;
            this.txtIsim1.SelectionStart = 0;
            this.txtIsim1.Size = new System.Drawing.Size(326, 23);
            this.txtIsim1.TabIndex = 21;
            this.txtIsim1.UseSystemPasswordChar = false;
            // 
            // IcerikEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.soru);
            this.Name = "IcerikEkleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.IcerikEkleme_Load);
            this.sorupage.ResumeLayout(false);
            this.sorupage.PerformLayout();
            this.soru.ResumeLayout(false);
            this.urlpage.ResumeLayout(false);
            this.urlpage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage sorupage;
        private VlcPlayer vlcPlayer1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDosya;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIsim;
        private System.Windows.Forms.TabControl soru;
        private System.Windows.Forms.TabPage urlpage;
        private VlcPlayer vlcPlayer2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MetroFramework.Controls.MetroComboBox cmbKategori1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtURL;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIsim1;
    }
}
