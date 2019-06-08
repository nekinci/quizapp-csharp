namespace EgitimUygulamasi
{
    partial class KategoriEkleme
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
            this.txtAciklama = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Kategori Adı";
            this.txtAd.Location = new System.Drawing.Point(250, 206);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(305, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.TabStop = false;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Depth = 0;
            this.txtAciklama.Hint = "Açıklama";
            this.txtAciklama.Location = new System.Drawing.Point(250, 249);
            this.txtAciklama.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.Size = new System.Drawing.Size(305, 23);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.TabStop = false;
            this.txtAciklama.UseSystemPasswordChar = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(389, 291);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(166, 38);
            this.btnKaydet.Style = MetroFramework.MetroColorStyle.Brown;
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // KategoriEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAd);
            this.Name = "KategoriEkleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.KategoriEkleme_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAciklama;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
    }
}
