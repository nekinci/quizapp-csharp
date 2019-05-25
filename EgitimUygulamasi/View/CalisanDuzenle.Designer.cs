namespace EgitimUygulamasi.View
{
    partial class CalisanDuzenle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CalisanlarTablosu = new System.Windows.Forms.DataGridView();
            this.txtAra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSil = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuncelle = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKadi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSoyad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.txtMail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanlarTablosu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalisanlarTablosu
            // 
            this.CalisanlarTablosu.AllowUserToAddRows = false;
            this.CalisanlarTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalisanlarTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalisanlarTablosu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CalisanlarTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CalisanlarTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CalisanlarTablosu.ColumnHeadersHeight = 45;
            this.CalisanlarTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalisanlarTablosu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.CalisanlarTablosu.Location = new System.Drawing.Point(13, 88);
            this.CalisanlarTablosu.MultiSelect = false;
            this.CalisanlarTablosu.Name = "CalisanlarTablosu";
            this.CalisanlarTablosu.ReadOnly = true;
            this.CalisanlarTablosu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CalisanlarTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CalisanlarTablosu.ShowEditingIcon = false;
            this.CalisanlarTablosu.Size = new System.Drawing.Size(414, 383);
            this.CalisanlarTablosu.TabIndex = 1;
            this.CalisanlarTablosu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalisanlarTablosu_RowEnter);
            // 
            // txtAra
            // 
            this.txtAra.Depth = 0;
            this.txtAra.Hint = "Çalışan Ara";
            this.txtAra.Location = new System.Drawing.Point(13, 59);
            this.txtAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(414, 23);
            this.txtAra.TabIndex = 11;
            this.txtAra.UseSystemPasswordChar = false;
            // 
            // btnSil
            // 
            this.btnSil.Depth = 0;
            this.btnSil.Location = new System.Drawing.Point(438, 430);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.Primary = true;
            this.btnSil.Size = new System.Drawing.Size(319, 41);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.txtSifre);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Controls.Add(this.txtKadi);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Location = new System.Drawing.Point(438, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 335);
            this.panel1.TabIndex = 10;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.AutoSize = true;
            this.btnGuncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuncelle.Depth = 0;
            this.btnGuncelle.Location = new System.Drawing.Point(214, 272);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuncelle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Primary = false;
            this.btnGuncelle.Size = new System.Drawing.Size(79, 36);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Depth = 0;
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.Location = new System.Drawing.Point(31, 240);
            this.txtSifre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.Size = new System.Drawing.Size(262, 23);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.UseSystemPasswordChar = false;
            // 
            // txtKadi
            // 
            this.txtKadi.Depth = 0;
            this.txtKadi.Hint = "Kullanıcı Adı";
            this.txtKadi.Location = new System.Drawing.Point(31, 165);
            this.txtKadi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.PasswordChar = '\0';
            this.txtKadi.SelectedText = "";
            this.txtKadi.SelectionLength = 0;
            this.txtKadi.SelectionStart = 0;
            this.txtKadi.Size = new System.Drawing.Size(262, 23);
            this.txtKadi.TabIndex = 0;
            this.txtKadi.UseSystemPasswordChar = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Depth = 0;
            this.txtSoyad.Hint = "Soyad";
            this.txtSoyad.Location = new System.Drawing.Point(31, 124);
            this.txtSoyad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.PasswordChar = '\0';
            this.txtSoyad.SelectedText = "";
            this.txtSoyad.SelectionLength = 0;
            this.txtSoyad.SelectionStart = 0;
            this.txtSoyad.Size = new System.Drawing.Size(262, 23);
            this.txtSoyad.TabIndex = 0;
            this.txtSoyad.UseSystemPasswordChar = false;
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Ad";
            this.txtAd.Location = new System.Drawing.Point(31, 86);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(262, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblFiltre.Location = new System.Drawing.Point(10, 27);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(118, 17);
            this.lblFiltre.TabIndex = 12;
            this.lblFiltre.Text = "Listeleme Kısıtları:";
            // 
            // txtMail
            // 
            this.txtMail.Depth = 0;
            this.txtMail.Hint = "Mail";
            this.txtMail.Location = new System.Drawing.Point(31, 204);
            this.txtMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.Size = new System.Drawing.Size(262, 23);
            this.txtMail.TabIndex = 0;
            this.txtMail.UseSystemPasswordChar = false;
            // 
            // CalisanDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CalisanlarTablosu);
            this.Name = "CalisanDuzenle";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.CalisanDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CalisanlarTablosu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CalisanlarTablosu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAra;
        private MaterialSkin.Controls.MaterialRaisedButton btnSil;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnGuncelle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoyad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private System.Windows.Forms.Label lblFiltre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSifre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKadi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMail;
    }
}
