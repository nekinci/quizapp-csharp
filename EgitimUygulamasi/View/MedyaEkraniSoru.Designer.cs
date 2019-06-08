namespace EgitimUygulamasi.View
{
    partial class MedyaEkraniSoru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedyaEkraniSoru));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSoruyaGec = new MaterialSkin.Controls.MaterialFlatButton();
            this.videoMedya = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnTamEkran = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Lavender;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btnSoruyaGec
            // 
            this.btnSoruyaGec.AutoSize = true;
            this.btnSoruyaGec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSoruyaGec.Depth = 0;
            this.btnSoruyaGec.Location = new System.Drawing.Point(665, 413);
            this.btnSoruyaGec.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSoruyaGec.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSoruyaGec.Name = "btnSoruyaGec";
            this.btnSoruyaGec.Primary = false;
            this.btnSoruyaGec.Size = new System.Drawing.Size(94, 36);
            this.btnSoruyaGec.TabIndex = 1;
            this.btnSoruyaGec.Text = "Soruya Geç";
            this.btnSoruyaGec.UseVisualStyleBackColor = true;
            this.btnSoruyaGec.Click += new System.EventHandler(this.btnSoruyaGec_Click);
            // 
            // videoMedya
            // 
            this.videoMedya.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoMedya.Enabled = true;
            this.videoMedya.Location = new System.Drawing.Point(0, 0);
            this.videoMedya.Name = "videoMedya";
            this.videoMedya.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoMedya.OcxState")));
            this.videoMedya.Size = new System.Drawing.Size(780, 404);
            this.videoMedya.TabIndex = 2;
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.AutoSize = true;
            this.btnTamEkran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTamEkran.Depth = 0;
            this.btnTamEkran.Location = new System.Drawing.Point(568, 413);
            this.btnTamEkran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamEkran.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Primary = false;
            this.btnTamEkran.Size = new System.Drawing.Size(89, 36);
            this.btnTamEkran.TabIndex = 3;
            this.btnTamEkran.Text = "Tam Ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Visible = false;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // MedyaEkraniSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.videoMedya);
            this.Controls.Add(this.btnSoruyaGec);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MedyaEkraniSoru";
            this.Size = new System.Drawing.Size(780, 490);
            this.Load += new System.EventHandler(this.MedyaEkraniSoru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialFlatButton btnSoruyaGec;
        private AxWMPLib.AxWindowsMediaPlayer videoMedya;
        private MaterialSkin.Controls.MaterialFlatButton btnTamEkran;
    }
}
