namespace EgitimUygulamasi.View
{
    partial class SifremiUnuttum
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtKadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(211, 171);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "GÖSTER";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // txtKadi
            // 
            this.txtKadi.Depth = 0;
            this.txtKadi.Hint = "Kullanıcı Adı";
            this.txtKadi.Location = new System.Drawing.Point(71, 99);
            this.txtKadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.Size = new System.Drawing.Size(204, 23);
            this.txtKadi.TabIndex = 1;
            this.txtKadi.UseSystemPasswordChar = false;
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Kayıtlı Mail";
            this.txtMail.Location = new System.Drawing.Point(71, 139);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(204, 23);
            this.txtMail.TabIndex = 2;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // SifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtKadi);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "SifremiUnuttum";
            this.Text = "SifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKadi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
    }
}