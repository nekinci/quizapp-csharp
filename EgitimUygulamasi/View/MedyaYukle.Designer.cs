namespace EgitimUygulamasi.View
{
    partial class MedyaYukle
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
            this.icerikEkleme1 = new EgitimUygulamasi.View.IcerikEkleme();
            this.SuspendLayout();
            // 
            // icerikEkleme1
            // 
            this.icerikEkleme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icerikEkleme1.Location = new System.Drawing.Point(0, 0);
            this.icerikEkleme1.Name = "icerikEkleme1";
            this.icerikEkleme1.Size = new System.Drawing.Size(775, 517);
            this.icerikEkleme1.TabIndex = 0;
            this.icerikEkleme1.Load += new System.EventHandler(this.ıcerikEkleme1_Load);
            // 
            // MedyaYukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 517);
            this.Controls.Add(this.icerikEkleme1);
            this.Name = "MedyaYukle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medya Yükle";
            this.Load += new System.EventHandler(this.MedyaYukle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public IcerikEkleme icerikEkleme1;
    }
}