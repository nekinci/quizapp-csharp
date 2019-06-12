namespace EgitimUygulamasi.View
{
    partial class UICevapItem
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.lblAd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAd.ForeColor = System.Drawing.Color.White;
            this.lblAd.Location = new System.Drawing.Point(0, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblAd.Size = new System.Drawing.Size(231, 29);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "İsim Soyisim";
            this.lblAd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAd.MouseEnter += new System.EventHandler(this.lblCevap_MouseEnter);
            this.lblAd.MouseLeave += new System.EventHandler(this.lblCevap_MouseLeave);
            // 
            // lblCevap
            // 
            this.lblCevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCevap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCevap.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.Location = new System.Drawing.Point(0, 29);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblCevap.Size = new System.Drawing.Size(231, 51);
            this.lblCevap.TabIndex = 1;
            this.lblCevap.Text = "Cevap";
            this.lblCevap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCevap.Click += new System.EventHandler(this.lblCevap_Click);
            this.lblCevap.MouseEnter += new System.EventHandler(this.lblCevap_MouseEnter);
            this.lblCevap.MouseLeave += new System.EventHandler(this.lblCevap_MouseLeave);
            this.lblCevap.MouseHover += new System.EventHandler(this.lblCevap_MouseHover);
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTarih.Location = new System.Drawing.Point(131, 59);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.lblTarih.Size = new System.Drawing.Size(100, 21);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "02/02/2012";
            this.lblTarih.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTarih.Click += new System.EventHandler(this.lblCevap_Click);
            // 
            // UICevapItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblAd);
            this.Name = "UICevapItem";
            this.Size = new System.Drawing.Size(231, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblTarih;
    }
}
