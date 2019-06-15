namespace EgitimUygulamasi.View
{
    partial class AdminKaydi
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
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Ad";
            this.txtAd.Location = new System.Drawing.Point(111, 125);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(221, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.UseSystemPasswordChar = false;
            this.txtAd.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Depth = 0;
            this.txtSoyad.Hint = "Soyad";
            this.txtSoyad.Location = new System.Drawing.Point(111, 165);
            this.txtSoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.SelectionLength = 0;
            this.txtSoyad.SelectionStart = 0;
            this.txtSoyad.Size = new System.Drawing.Size(221, 23);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.UseSystemPasswordChar = false;
            this.txtSoyad.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Email";
            this.txtMail.Location = new System.Drawing.Point(111, 208);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(221, 23);
            this.txtMail.TabIndex = 2;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // txtKadi
            // 
            this.txtKadi.Depth = 0;
            this.txtKadi.Hint = "Kullanıcı Adı";
            this.txtKadi.Location = new System.Drawing.Point(111, 252);
            this.txtKadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.Size = new System.Drawing.Size(221, 23);
            this.txtKadi.TabIndex = 3;
            this.txtKadi.UseSystemPasswordChar = false;
            // 
            // txtSifre
            // 
            this.txtSifre.Depth = 0;
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.Location = new System.Drawing.Point(111, 297);
            this.txtSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '●';
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(221, 23);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(269, 339);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // AdminKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 456);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "AdminKaydi";
            this.Text = "Admin Kaydı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKadi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSifre;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}