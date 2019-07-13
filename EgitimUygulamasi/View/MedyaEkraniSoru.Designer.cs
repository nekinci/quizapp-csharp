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
            this.btnSoruyaGec = new MaterialSkin.Controls.MaterialFlatButton();
            this.vlcPlayer1 = new EgitimUygulamasi.View.VlcPlayer();
            this.SuspendLayout();
            // 
            // btnSoruyaGec
            // 
            this.btnSoruyaGec.AutoSize = true;
            this.btnSoruyaGec.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSoruyaGec.Depth = 0;
            this.btnSoruyaGec.Location = new System.Drawing.Point(667, 441);
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
            // vlcPlayer1
            // 
            this.vlcPlayer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vlcPlayer1.Location = new System.Drawing.Point(0, 0);
            this.vlcPlayer1.Name = "vlcPlayer1";
            this.vlcPlayer1.Size = new System.Drawing.Size(780, 432);
            this.vlcPlayer1.TabIndex = 2;
            // 
            // MedyaEkraniSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.vlcPlayer1);
            this.Controls.Add(this.btnSoruyaGec);
            this.Name = "MedyaEkraniSoru";
            this.Size = new System.Drawing.Size(780, 490);
            this.Load += new System.EventHandler(this.MedyaEkraniSoru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnSoruyaGec;
        private VlcPlayer vlcPlayer1;
    }
}
