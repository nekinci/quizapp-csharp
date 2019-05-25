namespace EgitimUygulamasi.View
{
    partial class SSoru1
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
        public void setMain(SoruEkleme main)
        {
            this.main = main;
        }
        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSure = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ilerleButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbZorluk = new MetroFramework.Controls.MetroComboBox();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtSoruBasligi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTemizle = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.btnTemizle);
            this.pnl1.Controls.Add(this.materialLabel1);
            this.pnl1.Controls.Add(this.txtSure);
            this.pnl1.Controls.Add(this.ilerleButton);
            this.pnl1.Controls.Add(this.cmbZorluk);
            this.pnl1.Controls.Add(this.cmbKategori);
            this.pnl1.Controls.Add(this.txtSoruBasligi);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(413, 286);
            this.pnl1.TabIndex = 24;
            this.pnl1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl1_Paint);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(342, 191);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "sn";
            // 
            // txtSure
            // 
            this.txtSure.Depth = 0;
            this.txtSure.Hint = "Soru Süresi(yalnuzca rakam)";
            this.txtSure.Location = new System.Drawing.Point(62, 187);
            this.txtSure.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSure.Name = "txtSure";
            this.txtSure.PasswordChar = '\0';
            this.txtSure.SelectedText = "";
            this.txtSure.SelectionLength = 0;
            this.txtSure.SelectionStart = 0;
            this.txtSure.Size = new System.Drawing.Size(283, 23);
            this.txtSure.TabIndex = 11;
            this.txtSure.UseSystemPasswordChar = false;
            this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
            // 
            // ilerleButton
            // 
            this.ilerleButton.AutoSize = true;
            this.ilerleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ilerleButton.Depth = 0;
            this.ilerleButton.Location = new System.Drawing.Point(305, 225);
            this.ilerleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ilerleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ilerleButton.Name = "ilerleButton";
            this.ilerleButton.Primary = false;
            this.ilerleButton.Size = new System.Drawing.Size(62, 36);
            this.ilerleButton.TabIndex = 10;
            this.ilerleButton.Text = "İlerle>";
            this.ilerleButton.UseVisualStyleBackColor = true;
            this.ilerleButton.Click += new System.EventHandler(this.ilerleButton_Click);
            // 
            // cmbZorluk
            // 
            this.cmbZorluk.FormattingEnabled = true;
            this.cmbZorluk.ItemHeight = 23;
            this.cmbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorluk.Location = new System.Drawing.Point(62, 135);
            this.cmbZorluk.Name = "cmbZorluk";
            this.cmbZorluk.PromptText = "Zorluk Seviyesi";
            this.cmbZorluk.Size = new System.Drawing.Size(305, 29);
            this.cmbZorluk.TabIndex = 8;
            this.cmbZorluk.UseSelectable = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Items.AddRange(new object[] {
            "Kategori seç:"});
            this.cmbKategori.Location = new System.Drawing.Point(62, 88);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori seç";
            this.cmbKategori.Size = new System.Drawing.Size(305, 29);
            this.cmbKategori.TabIndex = 7;
            this.cmbKategori.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbKategori.UseSelectable = true;
            // 
            // txtSoruBasligi
            // 
            this.txtSoruBasligi.Depth = 0;
            this.txtSoruBasligi.Hint = "Soru Başlığı";
            this.txtSoruBasligi.Location = new System.Drawing.Point(62, 44);
            this.txtSoruBasligi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoruBasligi.Name = "txtSoruBasligi";
            this.txtSoruBasligi.PasswordChar = '\0';
            this.txtSoruBasligi.SelectedText = "";
            this.txtSoruBasligi.SelectionLength = 0;
            this.txtSoruBasligi.SelectionStart = 0;
            this.txtSoruBasligi.Size = new System.Drawing.Size(305, 23);
            this.txtSoruBasligi.TabIndex = 6;
            this.txtSoruBasligi.UseSystemPasswordChar = false;
            this.txtSoruBasligi.Click += new System.EventHandler(this.txtSoruBasligi_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSize = true;
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.Location = new System.Drawing.Point(230, 225);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Primary = false;
            this.btnTemizle.Size = new System.Drawing.Size(67, 36);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SSoru1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl1);
            this.Name = "SSoru1";
            this.Size = new System.Drawing.Size(413, 286);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private MaterialSkin.Controls.MaterialFlatButton ilerleButton;
        private MetroFramework.Controls.MetroComboBox cmbZorluk;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoruBasligi;
        private SoruEkleme main;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSure;
        private MaterialSkin.Controls.MaterialFlatButton btnTemizle;
    }
}
