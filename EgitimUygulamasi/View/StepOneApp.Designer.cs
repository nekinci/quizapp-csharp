using System.Timers;

namespace EgitimUygulamasi.View
{
    partial class StepOneApp
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
            this.components = new System.ComponentModel.Container();
            this.btnSoruSor = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlKategori = new System.Windows.Forms.Panel();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cmbZorluk = new MetroFramework.Controls.MetroComboBox();
            this.btnKategori = new MaterialSkin.Controls.MaterialFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHosgeldiniz = new System.Windows.Forms.Label();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlKategori.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSoruSor
            // 
            this.btnSoruSor.AutoSize = true;
            this.btnSoruSor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSoruSor.Depth = 0;
            this.btnSoruSor.Enabled = false;
            this.btnSoruSor.Location = new System.Drawing.Point(467, 358);
            this.btnSoruSor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSoruSor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSoruSor.Name = "btnSoruSor";
            this.btnSoruSor.Primary = false;
            this.btnSoruSor.Size = new System.Drawing.Size(77, 36);
            this.btnSoruSor.TabIndex = 12;
            this.btnSoruSor.Text = "Soru sor";
            this.btnSoruSor.UseVisualStyleBackColor = true;
            this.btnSoruSor.Click += new System.EventHandler(this.btnSoruSor_Click);
            // 
            // pnlKategori
            // 
            this.pnlKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.pnlKategori.Controls.Add(this.lblKategori);
            this.pnlKategori.Location = new System.Drawing.Point(245, 179);
            this.pnlKategori.Name = "pnlKategori";
            this.pnlKategori.Size = new System.Drawing.Size(299, 170);
            this.pnlKategori.TabIndex = 11;
            // 
            // lblKategori
            // 
            this.lblKategori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKategori.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblKategori.Location = new System.Drawing.Point(0, 67);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(299, 32);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "<Kategori Adı>";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.ItemHeight = 23;
            this.cmbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorluk.Location = new System.Drawing.Point(245, 133);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.Size = new System.Drawing.Size(299, 29);
            this.cmbZorluk.TabIndex = 9;
            this.cmbZorluk.UseSelectable = true;
            this.cmbZorluk.SelectedIndexChanged += new System.EventHandler(this.cmbZorluk_SelectedIndexChanged);
            // 
            // btnKategori
            // 
            this.btnKategori.AutoSize = true;
            this.btnKategori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKategori.Depth = 0;
            this.btnKategori.Location = new System.Drawing.Point(353, 358);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKategori.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Primary = false;
            this.btnKategori.Size = new System.Drawing.Size(106, 36);
            this.btnKategori.TabIndex = 13;
            this.btnKategori.Text = "Kategori Seç";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblHosgeldiniz
            // 
            this.lblHosgeldiniz.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldiniz.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblHosgeldiniz.Location = new System.Drawing.Point(0, 29);
            this.lblHosgeldiniz.Name = "lblHosgeldiniz";
            this.lblHosgeldiniz.Size = new System.Drawing.Size(780, 49);
            this.lblHosgeldiniz.TabIndex = 14;
            this.lblHosgeldiniz.Text = "Hoşgeldiniz x,";
            this.lblHosgeldiniz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHosgeldiniz.Click += new System.EventHandler(this.lblHosgeldiniz_Click);
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBilgilendirme.Location = new System.Drawing.Point(0, 89);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(780, 41);
            this.lblBilgilendirme.TabIndex = 14;
            this.lblBilgilendirme.Text = "Önce Kategori seçin";
            this.lblBilgilendirme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(450, 406);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(94, 36);
            this.materialFlatButton1.TabIndex = 15;
            this.materialFlatButton1.Text = "Oyunu Bitir";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // StepOneApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.lblHosgeldiniz);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.btnSoruSor);
            this.Controls.Add(this.pnlKategori);
            this.Controls.Add(this.cmbZorluk);
            this.Name = "StepOneApp";
            this.Size = new System.Drawing.Size(780, 491);
            this.Load += new System.EventHandler(this.StepOneApp_Load);
            this.pnlKategori.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnSoruSor;
        private System.Windows.Forms.Panel pnlKategori;
        private System.Windows.Forms.Label lblKategori;
        private MetroFramework.Controls.MetroComboBox cmbZorluk;
        private MaterialSkin.Controls.MaterialFlatButton btnKategori;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHosgeldiniz;
        private System.Windows.Forms.Label lblBilgilendirme;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}
