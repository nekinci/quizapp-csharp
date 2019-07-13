namespace EgitimUygulamasi.View
{
    partial class YeniMedya
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabURL = new System.Windows.Forms.TabControl();
            this.sorutab = new System.Windows.Forms.TabPage();
            this.btnKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBitir = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGozat = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDosya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtMedyaAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.vlcPlayer1 = new EgitimUygulamasi.View.VlcPlayer();
            this.taburl1 = new System.Windows.Forms.TabPage();
            this.vlcPlayer2 = new EgitimUygulamasi.View.VlcPlayer();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbKategori1 = new MetroFramework.Controls.MetroComboBox();
            this.txtIsim = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabURL.SuspendLayout();
            this.sorutab.SuspendLayout();
            this.taburl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabURL
            // 
            this.tabURL.Controls.Add(this.sorutab);
            this.tabURL.Controls.Add(this.taburl1);
            this.tabURL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabURL.Location = new System.Drawing.Point(12, 3);
            this.tabURL.Multiline = true;
            this.tabURL.Name = "tabURL";
            this.tabURL.SelectedIndex = 0;
            this.tabURL.Size = new System.Drawing.Size(362, 422);
            this.tabURL.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabURL.TabIndex = 6;
            // 
            // sorutab
            // 
            this.sorutab.AllowDrop = true;
            this.sorutab.BackColor = System.Drawing.Color.White;
            this.sorutab.Controls.Add(this.vlcPlayer1);
            this.sorutab.Controls.Add(this.btnKaydet);
            this.sorutab.Controls.Add(this.btnBitir);
            this.sorutab.Controls.Add(this.btnGozat);
            this.sorutab.Controls.Add(this.txtDosya);
            this.sorutab.Controls.Add(this.cmbKategori);
            this.sorutab.Controls.Add(this.txtMedyaAdi);
            this.sorutab.Location = new System.Drawing.Point(4, 26);
            this.sorutab.Name = "sorutab";
            this.sorutab.Padding = new System.Windows.Forms.Padding(3);
            this.sorutab.Size = new System.Drawing.Size(354, 392);
            this.sorutab.TabIndex = 0;
            this.sorutab.Text = "Dosya";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.Location = new System.Drawing.Point(146, 339);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Primary = false;
            this.btnKaydet.Size = new System.Drawing.Size(113, 36);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Yükle&Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.AutoSize = true;
            this.btnBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitir.Depth = 0;
            this.btnBitir.Location = new System.Drawing.Point(267, 339);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Primary = false;
            this.btnBitir.Size = new System.Drawing.Size(45, 36);
            this.btnBitir.TabIndex = 12;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnGozat
            // 
            this.btnGozat.AutoSize = true;
            this.btnGozat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGozat.Depth = 0;
            this.btnGozat.Location = new System.Drawing.Point(255, 305);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGozat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Primary = false;
            this.btnGozat.Size = new System.Drawing.Size(57, 36);
            this.btnGozat.TabIndex = 10;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // txtDosya
            // 
            this.txtDosya.Depth = 0;
            this.txtDosya.Hint = "Path";
            this.txtDosya.Location = new System.Drawing.Point(51, 273);
            this.txtDosya.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.PasswordChar = '\0';
            this.txtDosya.SelectedText = "";
            this.txtDosya.SelectionLength = 0;
            this.txtDosya.SelectionStart = 0;
            this.txtDosya.Size = new System.Drawing.Size(261, 23);
            this.txtDosya.TabIndex = 9;
            this.txtDosya.UseSystemPasswordChar = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(51, 235);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori seçin";
            this.cmbKategori.Size = new System.Drawing.Size(261, 29);
            this.cmbKategori.TabIndex = 8;
            this.cmbKategori.UseSelectable = true;
            // 
            // txtMedyaAdi
            // 
            this.txtMedyaAdi.Depth = 0;
            this.txtMedyaAdi.Hint = "Medya Adi";
            this.txtMedyaAdi.Location = new System.Drawing.Point(51, 206);
            this.txtMedyaAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMedyaAdi.Name = "txtMedyaAdi";
            this.txtMedyaAdi.PasswordChar = '\0';
            this.txtMedyaAdi.SelectedText = "";
            this.txtMedyaAdi.SelectionLength = 0;
            this.txtMedyaAdi.SelectionStart = 0;
            this.txtMedyaAdi.Size = new System.Drawing.Size(261, 23);
            this.txtMedyaAdi.TabIndex = 7;
            this.txtMedyaAdi.UseSystemPasswordChar = false;
            // 
            // vlcPlayer1
            // 
            this.vlcPlayer1.Location = new System.Drawing.Point(51, 6);
            this.vlcPlayer1.Name = "vlcPlayer1";
            this.vlcPlayer1.Size = new System.Drawing.Size(261, 194);
            this.vlcPlayer1.TabIndex = 13;
            // 
            // taburl1
            // 
            this.taburl1.AllowDrop = true;
            this.taburl1.BackColor = System.Drawing.Color.White;
            this.taburl1.Controls.Add(this.vlcPlayer2);
            this.taburl1.Controls.Add(this.materialFlatButton1);
            this.taburl1.Controls.Add(this.materialFlatButton2);
            this.taburl1.Controls.Add(this.txtURL);
            this.taburl1.Controls.Add(this.cmbKategori1);
            this.taburl1.Controls.Add(this.txtIsim);
            this.taburl1.Location = new System.Drawing.Point(4, 26);
            this.taburl1.Name = "taburl1";
            this.taburl1.Padding = new System.Windows.Forms.Padding(3);
            this.taburl1.Size = new System.Drawing.Size(354, 392);
            this.taburl1.TabIndex = 1;
            this.taburl1.Text = "URL";
            // 
            // vlcPlayer2
            // 
            this.vlcPlayer2.Location = new System.Drawing.Point(51, 6);
            this.vlcPlayer2.Name = "vlcPlayer2";
            this.vlcPlayer2.Size = new System.Drawing.Size(261, 194);
            this.vlcPlayer2.TabIndex = 13;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(146, 339);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(113, 36);
            this.materialFlatButton1.TabIndex = 11;
            this.materialFlatButton1.Text = "Yükle&Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(267, 339);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(45, 36);
            this.materialFlatButton2.TabIndex = 12;
            this.materialFlatButton2.Text = "Bitir";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Depth = 0;
            this.txtURL.Hint = "Medya URL";
            this.txtURL.Location = new System.Drawing.Point(51, 273);
            this.txtURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.Size = new System.Drawing.Size(261, 23);
            this.txtURL.TabIndex = 9;
            this.txtURL.UseSystemPasswordChar = false;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // cmbKategori1
            // 
            this.cmbKategori1.FormattingEnabled = true;
            this.cmbKategori1.ItemHeight = 23;
            this.cmbKategori1.Location = new System.Drawing.Point(51, 235);
            this.cmbKategori1.Name = "cmbKategori1";
            this.cmbKategori1.PromptText = "Kategori seçin";
            this.cmbKategori1.Size = new System.Drawing.Size(261, 29);
            this.cmbKategori1.TabIndex = 8;
            this.cmbKategori1.UseSelectable = true;
            // 
            // txtIsim
            // 
            this.txtIsim.Depth = 0;
            this.txtIsim.Hint = "Medya Adi";
            this.txtIsim.Location = new System.Drawing.Point(51, 206);
            this.txtIsim.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PasswordChar = '\0';
            this.txtIsim.SelectedText = "";
            this.txtIsim.SelectionLength = 0;
            this.txtIsim.SelectionStart = 0;
            this.txtIsim.Size = new System.Drawing.Size(261, 23);
            this.txtIsim.TabIndex = 7;
            this.txtIsim.UseSystemPasswordChar = false;
            // 
            // YeniMedya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 437);
            this.Controls.Add(this.tabURL);
            this.Name = "YeniMedya";
            this.Text = "YeniMedya";
            this.Load += new System.EventHandler(this.YeniMedya_Load);
            this.tabURL.ResumeLayout(false);
            this.sorutab.ResumeLayout(false);
            this.sorutab.PerformLayout();
            this.taburl1.ResumeLayout(false);
            this.taburl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabURL;
        private System.Windows.Forms.TabPage sorutab;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet;
        private MaterialSkin.Controls.MaterialFlatButton btnBitir;
        private MaterialSkin.Controls.MaterialFlatButton btnGozat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDosya;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMedyaAdi;
        private VlcPlayer vlcPlayer1;
        private System.Windows.Forms.TabPage taburl1;
        private VlcPlayer vlcPlayer2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtURL;
        private MetroFramework.Controls.MetroComboBox cmbKategori1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIsim;
    }
}