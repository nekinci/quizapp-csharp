namespace EgitimUygulamasi.View
{
    partial class MedyaGor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedyaGor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.medyaIsim = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.videoMedya = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnTamEkran = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medya İsmi:";
            // 
            // medyaIsim
            // 
            this.medyaIsim.AutoSize = true;
            this.medyaIsim.Location = new System.Drawing.Point(82, 347);
            this.medyaIsim.Name = "medyaIsim";
            this.medyaIsim.Size = new System.Drawing.Size(0, 13);
            this.medyaIsim.TabIndex = 2;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(488, 347);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(45, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "BİTİR";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // videoMedya
            // 
            this.videoMedya.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoMedya.Enabled = true;
            this.videoMedya.Location = new System.Drawing.Point(0, 0);
            this.videoMedya.Name = "videoMedya";
            this.videoMedya.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoMedya.OcxState")));
            this.videoMedya.Size = new System.Drawing.Size(546, 323);
            this.videoMedya.TabIndex = 4;
            this.videoMedya.Visible = false;
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.AutoSize = true;
            this.btnTamEkran.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTamEkran.Depth = 0;
            this.btnTamEkran.Location = new System.Drawing.Point(391, 347);
            this.btnTamEkran.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTamEkran.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Primary = false;
            this.btnTamEkran.Size = new System.Drawing.Size(89, 36);
            this.btnTamEkran.TabIndex = 5;
            this.btnTamEkran.Text = "tam ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Visible = false;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // MedyaGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(546, 392);
            this.Controls.Add(this.btnTamEkran);
            this.Controls.Add(this.videoMedya);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.medyaIsim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MedyaGor";
            this.Text = "Medyayı Görüntüle";
            this.Load += new System.EventHandler(this.MedyaGor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoMedya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label medyaIsim;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private AxWMPLib.AxWindowsMediaPlayer videoMedya;
        private MaterialSkin.Controls.MaterialFlatButton btnTamEkran;
    }
}