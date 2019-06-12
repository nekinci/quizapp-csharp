namespace EgitimUygulamasi.View
{
    partial class UCBildirim
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
            this.lblCalisan = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalisan
            // 
            this.lblCalisan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(155)))), ((int)(((byte)(229)))));
            this.lblCalisan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalisan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCalisan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalisan.ForeColor = System.Drawing.Color.White;
            this.lblCalisan.Location = new System.Drawing.Point(0, 0);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCalisan.Size = new System.Drawing.Size(263, 29);
            this.lblCalisan.TabIndex = 0;
            this.lblCalisan.Text = "Çalışan Adı:";
            this.lblCalisan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCalisan.Click += new System.EventHandler(this.lblCalisan_Click);
            this.lblCalisan.MouseEnter += new System.EventHandler(this.lblCevap_MouseEnter);
            this.lblCalisan.MouseLeave += new System.EventHandler(this.lblCevap_MouseLeave);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoEllipsis = true;
            this.lblCevap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCevap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCevap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCevap.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.ForeColor = System.Drawing.Color.Black;
            this.lblCevap.Location = new System.Drawing.Point(0, 29);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblCevap.Size = new System.Drawing.Size(263, 34);
            this.lblCevap.TabIndex = 2;
            this.lblCevap.Text = "Cevap";
            this.lblCevap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCevap.Click += new System.EventHandler(this.lblCalisan_Click);
            this.lblCevap.MouseEnter += new System.EventHandler(this.lblCevap_MouseEnter);
            this.lblCevap.MouseLeave += new System.EventHandler(this.lblCevap_MouseLeave);
            // 
            // UCBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblCalisan);
            this.Name = "UCBildirim";
            this.Size = new System.Drawing.Size(263, 63);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.Label lblCevap;
    }
}
