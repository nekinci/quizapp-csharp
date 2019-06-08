﻿namespace EgitimUygulamasi.View
{
    partial class Ayarlar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtZor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtOrta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtKolay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.gericekilme = new MetroFramework.Controls.MetroToggle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtGunSayisi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.yanliscevap = new MetroFramework.Controls.MetroToggle();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.materialFlatButton1);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtZor);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtOrta);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtKolay);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puanlandırma Ayarları";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(176, 126);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton1.TabIndex = 13;
            this.materialFlatButton1.Text = "Kaydet";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 98);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(32, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Zor";
            // 
            // txtZor
            // 
            this.txtZor.Depth = 0;
            this.txtZor.Hint = "";
            this.txtZor.Location = new System.Drawing.Point(93, 94);
            this.txtZor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtZor.Name = "txtZor";
            this.txtZor.PasswordChar = '\0';
            this.txtZor.SelectedText = "";
            this.txtZor.SelectionLength = 0;
            this.txtZor.SelectionStart = 0;
            this.txtZor.Size = new System.Drawing.Size(146, 23);
            this.txtZor.TabIndex = 11;
            this.txtZor.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 69);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(37, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "Orta";
            // 
            // txtOrta
            // 
            this.txtOrta.Depth = 0;
            this.txtOrta.Hint = "";
            this.txtOrta.Location = new System.Drawing.Point(93, 65);
            this.txtOrta.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOrta.Name = "txtOrta";
            this.txtOrta.PasswordChar = '\0';
            this.txtOrta.SelectedText = "";
            this.txtOrta.SelectionLength = 0;
            this.txtOrta.SelectionStart = 0;
            this.txtOrta.Size = new System.Drawing.Size(146, 23);
            this.txtOrta.TabIndex = 9;
            this.txtOrta.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(25, 40);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Kolay";
            // 
            // txtKolay
            // 
            this.txtKolay.Depth = 0;
            this.txtKolay.Hint = "";
            this.txtKolay.Location = new System.Drawing.Point(93, 36);
            this.txtKolay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKolay.Name = "txtKolay";
            this.txtKolay.PasswordChar = '\0';
            this.txtKolay.SelectedText = "";
            this.txtKolay.SelectionLength = 0;
            this.txtKolay.SelectionStart = 0;
            this.txtKolay.Size = new System.Drawing.Size(146, 23);
            this.txtKolay.TabIndex = 7;
            this.txtKolay.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.materialFlatButton2);
            this.groupBox2.Controls.Add(this.gericekilme);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(22, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geri Çekilme tuşuna basıldığında puan düşsün mü?";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(176, 22);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "Kaydet";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // gericekilme
            // 
            this.gericekilme.Location = new System.Drawing.Point(29, 27);
            this.gericekilme.Name = "gericekilme";
            this.gericekilme.Size = new System.Drawing.Size(125, 26);
            this.gericekilme.Style = MetroFramework.MetroColorStyle.Red;
            this.gericekilme.TabIndex = 0;
            this.gericekilme.Text = "Off";
            this.gericekilme.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gericekilme.UseSelectable = true;
            this.gericekilme.UseStyleColors = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.materialFlatButton3);
            this.groupBox3.Controls.Add(this.txtGunSayisi);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(22, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 76);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aynı soruyu kaç gün içinde sormasın?";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(176, 24);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton3.TabIndex = 1;
            this.materialFlatButton3.Text = "Kaydet";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Depth = 0;
            this.txtGunSayisi.Hint = "Gün Sayısı";
            this.txtGunSayisi.Location = new System.Drawing.Point(29, 33);
            this.txtGunSayisi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.PasswordChar = '\0';
            this.txtGunSayisi.SelectedText = "";
            this.txtGunSayisi.SelectionLength = 0;
            this.txtGunSayisi.SelectionStart = 0;
            this.txtGunSayisi.Size = new System.Drawing.Size(125, 23);
            this.txtGunSayisi.TabIndex = 3;
            this.txtGunSayisi.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox4.Controls.Add(this.materialFlatButton4);
            this.groupBox4.Controls.Add(this.yanliscevap);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(22, 382);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(298, 72);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Yanlış cevapta puan düşsün mü?";
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Location = new System.Drawing.Point(176, 22);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton4.TabIndex = 1;
            this.materialFlatButton4.Text = "Kaydet";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            this.materialFlatButton4.Click += new System.EventHandler(this.materialFlatButton4_Click);
            // 
            // yanliscevap
            // 
            this.yanliscevap.Location = new System.Drawing.Point(29, 27);
            this.yanliscevap.Name = "yanliscevap";
            this.yanliscevap.Size = new System.Drawing.Size(125, 26);
            this.yanliscevap.Style = MetroFramework.MetroColorStyle.Red;
            this.yanliscevap.TabIndex = 0;
            this.yanliscevap.Text = "Off";
            this.yanliscevap.Theme = MetroFramework.MetroThemeStyle.Light;
            this.yanliscevap.UseSelectable = true;
            this.yanliscevap.UseStyleColors = true;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ayarlar";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtZor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOrta;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKolay;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroToggle gericekilme;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGunSayisi;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MetroFramework.Controls.MetroToggle yanliscevap;
    }
}
