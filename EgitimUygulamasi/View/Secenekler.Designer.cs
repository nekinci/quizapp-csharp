using EgitimUygulamasi.Model;
using MaterialSkin.Controls;

namespace EgitimUygulamasi.View
{
    partial class Secenekler
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
        public void setMain(SoruEkleme main)
        {
            this.main = main;
        }
        public Secenekler(SoruEkleme main)
        {
            this.main = main;
        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbDogruSecenekl = new MetroFramework.Controls.MetroComboBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.asecenegi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bsecenegi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.csecenegi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dsecenegi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.esecenegi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTemizle = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(118, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Lütfen seçenekleri girin:";
            // 
            // cmbDogruSecenekl
            // 
            this.cmbDogruSecenekl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDogruSecenekl.FormattingEnabled = true;
            this.cmbDogruSecenekl.ItemHeight = 23;
            this.cmbDogruSecenekl.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbDogruSecenekl.Location = new System.Drawing.Point(77, 272);
            this.cmbDogruSecenekl.Name = "cmbDogruSecenekl";
            this.cmbDogruSecenekl.PromptText = "Doğru Seçenek";
            this.cmbDogruSecenekl.Size = new System.Drawing.Size(283, 29);
            this.cmbDogruSecenekl.TabIndex = 1;
            this.cmbDogruSecenekl.UseSelectable = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(304, 310);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // asecenegi
            // 
            this.asecenegi.Depth = 0;
            this.asecenegi.Hint = "A Seçeneği";
            this.asecenegi.Location = new System.Drawing.Point(77, 67);
            this.asecenegi.MouseState = MaterialSkin.MouseState.HOVER;
            this.asecenegi.Name = "asecenegi";
            this.asecenegi.PasswordChar = '\0';
            this.asecenegi.SelectedText = "";
            this.asecenegi.SelectionLength = 0;
            this.asecenegi.SelectionStart = 0;
            this.asecenegi.Size = new System.Drawing.Size(283, 23);
            this.asecenegi.TabIndex = 3;
            this.asecenegi.UseSystemPasswordChar = false;
            // 
            // bsecenegi
            // 
            this.bsecenegi.Depth = 0;
            this.bsecenegi.Hint = "B Seçeneği";
            this.bsecenegi.Location = new System.Drawing.Point(77, 105);
            this.bsecenegi.MouseState = MaterialSkin.MouseState.HOVER;
            this.bsecenegi.Name = "bsecenegi";
            this.bsecenegi.PasswordChar = '\0';
            this.bsecenegi.SelectedText = "";
            this.bsecenegi.SelectionLength = 0;
            this.bsecenegi.SelectionStart = 0;
            this.bsecenegi.Size = new System.Drawing.Size(283, 23);
            this.bsecenegi.TabIndex = 3;
            this.bsecenegi.UseSystemPasswordChar = false;
            // 
            // csecenegi
            // 
            this.csecenegi.Depth = 0;
            this.csecenegi.Hint = "C Seçeneği";
            this.csecenegi.Location = new System.Drawing.Point(77, 144);
            this.csecenegi.MouseState = MaterialSkin.MouseState.HOVER;
            this.csecenegi.Name = "csecenegi";
            this.csecenegi.PasswordChar = '\0';
            this.csecenegi.SelectedText = "";
            this.csecenegi.SelectionLength = 0;
            this.csecenegi.SelectionStart = 0;
            this.csecenegi.Size = new System.Drawing.Size(283, 23);
            this.csecenegi.TabIndex = 3;
            this.csecenegi.UseSystemPasswordChar = false;
            // 
            // dsecenegi
            // 
            this.dsecenegi.Depth = 0;
            this.dsecenegi.Hint = "D Seçeneği";
            this.dsecenegi.Location = new System.Drawing.Point(77, 184);
            this.dsecenegi.MouseState = MaterialSkin.MouseState.HOVER;
            this.dsecenegi.Name = "dsecenegi";
            this.dsecenegi.PasswordChar = '\0';
            this.dsecenegi.SelectedText = "";
            this.dsecenegi.SelectionLength = 0;
            this.dsecenegi.SelectionStart = 0;
            this.dsecenegi.Size = new System.Drawing.Size(283, 23);
            this.dsecenegi.TabIndex = 3;
            this.dsecenegi.UseSystemPasswordChar = false;
            // 
            // esecenegi
            // 
            this.esecenegi.Depth = 0;
            this.esecenegi.Hint = "E Seçeneği";
            this.esecenegi.Location = new System.Drawing.Point(77, 226);
            this.esecenegi.MouseState = MaterialSkin.MouseState.HOVER;
            this.esecenegi.Name = "esecenegi";
            this.esecenegi.PasswordChar = '\0';
            this.esecenegi.SelectedText = "";
            this.esecenegi.SelectionLength = 0;
            this.esecenegi.SelectionStart = 0;
            this.esecenegi.Size = new System.Drawing.Size(283, 23);
            this.esecenegi.TabIndex = 3;
            this.esecenegi.UseSystemPasswordChar = false;
            // 
            // btnTemizle
            // 
            this.btnTemizle.AutoSize = true;
            this.btnTemizle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTemizle.Depth = 0;
            this.btnTemizle.Location = new System.Drawing.Point(229, 310);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTemizle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Primary = false;
            this.btnTemizle.Size = new System.Drawing.Size(67, 36);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Secenekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.esecenegi);
            this.Controls.Add(this.dsecenegi);
            this.Controls.Add(this.csecenegi);
            this.Controls.Add(this.bsecenegi);
            this.Controls.Add(this.asecenegi);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.cmbDogruSecenekl);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Secenekler";
            this.Size = new System.Drawing.Size(413, 367);
            this.Load += new System.EventHandler(this.Secenekler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SoruEkleme main;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cmbDogruSecenekl;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private Soru _soru;
        private MaterialSingleLineTextField asecenegi;
        private MaterialSingleLineTextField bsecenegi;
        private MaterialSingleLineTextField csecenegi;
        private MaterialSingleLineTextField dsecenegi;
        private MaterialSingleLineTextField esecenegi;
        private MaterialFlatButton btnTemizle;
    }
}
