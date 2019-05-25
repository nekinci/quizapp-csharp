namespace EgitimUygulamasi.View
{
    partial class Calisan
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
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnTemizle = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Çalışan Adı";
            this.txtAd.Location = new System.Drawing.Point(230, 156);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(311, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Depth = 0;
            this.txtSoyad.Hint = "Çalışan Soyadı";
            this.txtSoyad.Location = new System.Drawing.Point(230, 194);
            this.txtSoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.SelectionLength = 0;
            this.txtSoyad.SelectionStart = 0;
            this.txtSoyad.Size = new System.Drawing.Size(311, 23);
            this.txtSoyad.TabIndex = 0;
            this.txtSoyad.UseSystemPasswordChar = false;
            // 
            // txtKadi
            // 
            this.txtKadi.Depth = 0;
            this.txtKadi.Hint = "Çalışan Kullanıcı Adı";
            this.txtKadi.Location = new System.Drawing.Point(230, 235);
            this.txtKadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.Size = new System.Drawing.Size(311, 23);
            this.txtKadi.TabIndex = 0;
            this.txtKadi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Depth = 0;
            this.txtSifre.Hint = "Çalışan Şifre";
            this.txtSifre.Location = new System.Drawing.Point(230, 313);
            this.txtSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(311, 23);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.Location = new System.Drawing.Point(478, 345);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Primary = false;
            this.btnKaydet.Size = new System.Drawing.Size(63, 36);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSize = true;
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.Location = new System.Drawing.Point(407, 345);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Primary = false;
            this.btnTemizle.Size = new System.Drawing.Size(67, 36);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Çalışan E-Mail";
            this.txtMail.Location = new System.Drawing.Point(230, 273);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(311, 23);
            this.txtMail.TabIndex = 0;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Calisan";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.Calisan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKadi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSifre;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet;
        private MaterialSkin.Controls.MaterialFlatButton btnTemizle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
    }
}
