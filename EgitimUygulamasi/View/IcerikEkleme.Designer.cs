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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IcerikEkleme));
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtIsim = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDosya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureMedya = new System.Windows.Forms.PictureBox();
            this.videoMedya = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnTamEkran = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(241, 294);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori Seçin";
            this.cmbKategori.Size = new System.Drawing.Size(326, 29);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.UseSelectable = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtIsim
            // 
            this.txtIsim.Depth = 0;
            this.txtIsim.Hint = "Dosyayı nasıl isimlendirmek istersiniz?";
            this.txtIsim.Location = new System.Drawing.Point(241, 254);
            this.txtIsim.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.PasswordChar = '\0';
            this.txtIsim.SelectedText = "";
            this.txtIsim.SelectionLength = 0;
            this.txtIsim.SelectionStart = 0;
            this.txtIsim.Size = new System.Drawing.Size(326, 23);
            this.txtIsim.TabIndex = 4;
            this.txtIsim.UseSystemPasswordChar = false;
            // 
            // txtDosya
            // 
            this.txtDosya.Depth = 0;
            this.txtDosya.Hint = "Yükleyeceğiniz dosyayı seçin";
            this.txtDosya.Location = new System.Drawing.Point(241, 345);
            this.txtDosya.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.PasswordChar = '\0';
            this.txtDosya.SelectedText = "";
            this.txtDosya.SelectionLength = 0;
            this.txtDosya.SelectionStart = 0;
            this.txtDosya.Size = new System.Drawing.Size(262, 23);
            this.txtDosya.TabIndex = 5;
            this.txtDosya.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(510, 337);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(57, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Gözat";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(454, 385);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(113, 36);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "Yükle&Kaydet";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // pictureMedya
            // 
            this.pictureMedya.Location = new System.Drawing.Point(241, 31);
            this.pictureMedya.Name = "pictureMedya";
            this.pictureMedya.Size = new System.Drawing.Size(326, 201);
            this.pictureMedya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMedya.TabIndex = 8;
            this.pictureMedya.TabStop = false;
            this.pictureMedya.Visible = false;
            // 
            // videoMedya
            // 
            this.videoMedya.Enabled = true;
            this.videoMedya.Location = new System.Drawing.Point(241, 21);
            this.videoMedya.Name = "videoMedya";
            this.videoMedya.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoMedya.OcxState")));
            this.videoMedya.Size = new System.Drawing.Size(326, 211);
            this.videoMedya.TabIndex = 9;
            this.videoMedya.Visible = false;
            this.videoMedya.Enter += new System.EventHandler(this.videoMedya_Enter);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.AutoSize = true;
            this.btnTamEkran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTamEkran.Depth = 0;
            this.btnTamEkran.Location = new System.Drawing.Point(574, 196);
            this.btnTamEkran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamEkran.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Primary = false;
            this.btnTamEkran.Size = new System.Drawing.Size(89, 36);
            this.btnTamEkran.TabIndex = 10;
            this.btnTamEkran.Text = "tam ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Visible = false;
            this.btnTamEkran.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(373, 385);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(73, 36);
            this.materialFlatButton3.TabIndex = 11;
            this.materialFlatButton3.Text = "Geri Dön";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click_1);
            // 
            // IcerikEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.videoMedya);
            this.Controls.Add(this.pictureMedya);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.cmbKategori);
            this.Name = "IcerikEkleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.IcerikEkleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIsim;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDosya;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.PictureBox pictureMedya;
        private AxWMPLib.AxWindowsMediaPlayer videoMedya;
        private MaterialSkin.Controls.MaterialFlatButton btnTamEkran;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
    }
}
