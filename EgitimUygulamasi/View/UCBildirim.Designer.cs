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
            this.lblSoruID = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalisan
            // 
            this.lblCalisan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCalisan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCalisan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCalisan.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalisan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCalisan.Location = new System.Drawing.Point(0, 0);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(235, 29);
            this.lblCalisan.TabIndex = 0;
            this.lblCalisan.Text = "Çalışan Adı:";
            this.lblCalisan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCalisan.Click += new System.EventHandler(this.lblCalisan_Click);
            // 
            // lblSoruID
            // 
            this.lblSoruID.AutoSize = true;
            this.lblSoruID.Location = new System.Drawing.Point(189, 16);
            this.lblSoruID.Name = "lblSoruID";
            this.lblSoruID.Size = new System.Drawing.Size(43, 13);
            this.lblSoruID.TabIndex = 1;
            this.lblSoruID.Text = "Soru ID";
            this.lblSoruID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCevap
            // 
            this.lblCevap.AutoEllipsis = true;
            this.lblCevap.BackColor = System.Drawing.SystemColors.Window;
            this.lblCevap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCevap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCevap.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.ForeColor = System.Drawing.Color.Black;
            this.lblCevap.Location = new System.Drawing.Point(0, 29);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(235, 32);
            this.lblCevap.TabIndex = 2;
            this.lblCevap.Text = "Cevap";
            this.lblCevap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCevap.Click += new System.EventHandler(this.lblCalisan_Click);
            // 
            // UCBildirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblSoruID);
            this.Controls.Add(this.lblCalisan);
            this.Name = "UCBildirim";
            this.Size = new System.Drawing.Size(235, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.Label lblSoruID;
        private System.Windows.Forms.Label lblCevap;
    }
}
