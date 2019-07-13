namespace EgitimUygulamasi.View
{
    partial class MedyaGuncelleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabSorular = new System.Windows.Forms.TabControl();
            this.sorutab = new System.Windows.Forms.TabPage();
            this.btnKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGozat = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtURL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMedyaAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSorular.SuspendLayout();
            this.sorutab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGoruntule);
            this.groupBox1.Location = new System.Drawing.Point(49, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şu anki medya";
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.AutoSize = true;
            this.btnGoruntule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoruntule.Depth = 0;
            this.btnGoruntule.Location = new System.Drawing.Point(69, 77);
            this.btnGoruntule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoruntule.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Primary = false;
            this.btnGoruntule.Size = new System.Drawing.Size(91, 36);
            this.btnGoruntule.TabIndex = 0;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = true;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGoruntule2);
            this.groupBox2.Location = new System.Drawing.Point(301, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncellenmek için Bekleyen Medya";
            // 
            // btnGoruntule2
            // 
            this.btnGoruntule2.AutoSize = true;
            this.btnGoruntule2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoruntule2.Depth = 0;
            this.btnGoruntule2.Enabled = false;
            this.btnGoruntule2.Location = new System.Drawing.Point(70, 77);
            this.btnGoruntule2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGoruntule2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGoruntule2.Name = "btnGoruntule2";
            this.btnGoruntule2.Primary = false;
            this.btnGoruntule2.Size = new System.Drawing.Size(91, 36);
            this.btnGoruntule2.TabIndex = 1;
            this.btnGoruntule2.Text = "Görüntüle";
            this.btnGoruntule2.UseVisualStyleBackColor = true;
            this.btnGoruntule2.Click += new System.EventHandler(this.btnGoruntule2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabSorular
            // 
            this.tabSorular.Controls.Add(this.sorutab);
            this.tabSorular.Controls.Add(this.tabPage1);
            this.tabSorular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabSorular.Location = new System.Drawing.Point(50, 283);
            this.tabSorular.Multiline = true;
            this.tabSorular.Name = "tabSorular";
            this.tabSorular.SelectedIndex = 0;
            this.tabSorular.Size = new System.Drawing.Size(483, 165);
            this.tabSorular.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSorular.TabIndex = 6;
            // 
            // sorutab
            // 
            this.sorutab.AllowDrop = true;
            this.sorutab.BackColor = System.Drawing.Color.White;
            this.sorutab.Controls.Add(this.btnKaydet);
            this.sorutab.Controls.Add(this.btnGozat);
            this.sorutab.Controls.Add(this.txtPath);
            this.sorutab.Controls.Add(this.txtAd);
            this.sorutab.Location = new System.Drawing.Point(4, 26);
            this.sorutab.Name = "sorutab";
            this.sorutab.Padding = new System.Windows.Forms.Padding(3);
            this.sorutab.Size = new System.Drawing.Size(475, 135);
            this.sorutab.TabIndex = 0;
            this.sorutab.Text = "Dosya";
            // 
            // btnKaydet
            // 
            this.btnKaydet.AutoSize = true;
            this.btnKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet.Depth = 0;
            this.btnKaydet.Location = new System.Drawing.Point(348, 91);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Primary = false;
            this.btnKaydet.Size = new System.Drawing.Size(63, 36);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // btnGozat
            // 
            this.btnGozat.AutoSize = true;
            this.btnGozat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGozat.Depth = 0;
            this.btnGozat.Location = new System.Drawing.Point(283, 91);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGozat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Primary = false;
            this.btnGozat.Size = new System.Drawing.Size(57, 36);
            this.btnGozat.TabIndex = 8;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // txtPath
            // 
            this.txtPath.Depth = 0;
            this.txtPath.Hint = "Medya Path";
            this.txtPath.Location = new System.Drawing.Point(50, 59);
            this.txtPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.Size = new System.Drawing.Size(361, 23);
            this.txtPath.TabIndex = 7;
            this.txtPath.UseSystemPasswordChar = false;
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Medya adı";
            this.txtAd.Location = new System.Drawing.Point(50, 19);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(361, 23);
            this.txtAd.TabIndex = 6;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialFlatButton1);
            this.tabPage1.Controls.Add(this.txtURL);
            this.tabPage1.Controls.Add(this.txtMedyaAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 135);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "URL";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(348, 91);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtURL
            // 
            this.txtURL.Depth = 0;
            this.txtURL.Hint = "Medya URL";
            this.txtURL.Location = new System.Drawing.Point(50, 59);
            this.txtURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtURL.Name = "txtURL";
            this.txtURL.PasswordChar = '\0';
            this.txtURL.SelectedText = "";
            this.txtURL.SelectionLength = 0;
            this.txtURL.SelectionStart = 0;
            this.txtURL.Size = new System.Drawing.Size(361, 23);
            this.txtURL.TabIndex = 7;
            this.txtURL.UseSystemPasswordChar = false;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // txtMedyaAdi
            // 
            this.txtMedyaAdi.Depth = 0;
            this.txtMedyaAdi.Hint = "Medya adı";
            this.txtMedyaAdi.Location = new System.Drawing.Point(50, 19);
            this.txtMedyaAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMedyaAdi.Name = "txtMedyaAdi";
            this.txtMedyaAdi.PasswordChar = '\0';
            this.txtMedyaAdi.SelectedText = "";
            this.txtMedyaAdi.SelectionLength = 0;
            this.txtMedyaAdi.SelectionStart = 0;
            this.txtMedyaAdi.Size = new System.Drawing.Size(361, 23);
            this.txtMedyaAdi.TabIndex = 6;
            this.txtMedyaAdi.UseSystemPasswordChar = false;
            // 
            // MedyaGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.tabSorular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedyaGuncelleme";
            this.Text = "Medya Güncelleme";
            this.Load += new System.EventHandler(this.MedyaGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSorular.ResumeLayout(false);
            this.sorutab.ResumeLayout(false);
            this.sorutab.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialFlatButton btnGoruntule;
        private MaterialSkin.Controls.MaterialFlatButton btnGoruntule2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabSorular;
        private System.Windows.Forms.TabPage sorutab;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet;
        private MaterialSkin.Controls.MaterialFlatButton btnGozat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPath;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtURL;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMedyaAdi;
    }
}