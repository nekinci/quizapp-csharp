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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGoruntule = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGoruntule2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPath = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnGozat = new MaterialSkin.Controls.MaterialFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Medya adı";
            this.txtAd.Location = new System.Drawing.Point(101, 300);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(361, 23);
            this.txtAd.TabIndex = 2;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // txtPath
            // 
            this.txtPath.Depth = 0;
            this.txtPath.Hint = "Medya Path";
            this.txtPath.Location = new System.Drawing.Point(101, 340);
            this.txtPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPath.Name = "txtPath";
            this.txtPath.PasswordChar = '\0';
            this.txtPath.SelectedText = "";
            this.txtPath.SelectionLength = 0;
            this.txtPath.SelectionStart = 0;
            this.txtPath.Size = new System.Drawing.Size(361, 23);
            this.txtPath.TabIndex = 3;
            this.txtPath.UseSystemPasswordChar = false;
            // 
            // btnGozat
            // 
            this.btnGozat.AutoSize = true;
            this.btnGozat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGozat.Depth = 0;
            this.btnGozat.Location = new System.Drawing.Point(334, 372);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGozat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Primary = false;
            this.btnGozat.Size = new System.Drawing.Size(57, 36);
            this.btnGozat.TabIndex = 4;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.materialFlatButton3_Click);
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
            this.btnKaydet.Location = new System.Drawing.Point(399, 372);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Primary = false;
            this.btnKaydet.Size = new System.Drawing.Size(63, 36);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // MedyaGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 478);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MedyaGuncelleme";
            this.Text = "Medya Güncelleme";
            this.Load += new System.EventHandler(this.MedyaGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialFlatButton btnGoruntule;
        private MaterialSkin.Controls.MaterialFlatButton btnGoruntule2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPath;
        private MaterialSkin.Controls.MaterialFlatButton btnGozat;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet;
    }
}