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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMedyaAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtDosya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGozat = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBitir = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 198);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtMedyaAdi
            // 
            this.txtMedyaAdi.Depth = 0;
            this.txtMedyaAdi.Hint = "Medya Adi";
            this.txtMedyaAdi.Location = new System.Drawing.Point(51, 229);
            this.txtMedyaAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMedyaAdi.Name = "txtMedyaAdi";
            this.txtMedyaAdi.PasswordChar = '\0';
            this.txtMedyaAdi.SelectedText = "";
            this.txtMedyaAdi.SelectionLength = 0;
            this.txtMedyaAdi.SelectionStart = 0;
            this.txtMedyaAdi.Size = new System.Drawing.Size(261, 23);
            this.txtMedyaAdi.TabIndex = 1;
            this.txtMedyaAdi.UseSystemPasswordChar = false;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(51, 258);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori seçin";
            this.cmbKategori.Size = new System.Drawing.Size(261, 29);
            this.cmbKategori.TabIndex = 2;
            this.cmbKategori.UseSelectable = true;
            // 
            // txtDosya
            // 
            this.txtDosya.Depth = 0;
            this.txtDosya.Hint = "Path";
            this.txtDosya.Location = new System.Drawing.Point(51, 296);
            this.txtDosya.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.PasswordChar = '\0';
            this.txtDosya.SelectedText = "";
            this.txtDosya.SelectionLength = 0;
            this.txtDosya.SelectionStart = 0;
            this.txtDosya.Size = new System.Drawing.Size(261, 23);
            this.txtDosya.TabIndex = 3;
            this.txtDosya.UseSystemPasswordChar = false;
            // 
            // btnGozat
            // 
            this.btnGozat.AutoSize = true;
            this.btnGozat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGozat.Depth = 0;
            this.btnGozat.Location = new System.Drawing.Point(255, 328);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGozat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Primary = false;
            this.btnGozat.Size = new System.Drawing.Size(57, 36);
            this.btnGozat.TabIndex = 4;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.AutoSize = true;
            this.btnBitir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBitir.Depth = 0;
            this.btnBitir.Location = new System.Drawing.Point(267, 362);
            this.btnBitir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBitir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Primary = false;
            this.btnBitir.Size = new System.Drawing.Size(45, 36);
            this.btnBitir.TabIndex = 5;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.Location = new System.Drawing.Point(146, 362);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Primary = false;
            this.btnKaydet.Size = new System.Drawing.Size(113, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Yükle&Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // YeniMedya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 413);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.txtMedyaAdi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YeniMedya";
            this.Text = "YeniMedya";
            this.Load += new System.EventHandler(this.YeniMedya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMedyaAdi;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDosya;
        private MaterialSkin.Controls.MaterialFlatButton btnGozat;
        private MaterialSkin.Controls.MaterialFlatButton btnBitir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet;
    }
}