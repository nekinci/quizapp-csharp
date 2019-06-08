namespace EgitimUygulamasi.View
{
    partial class KategoriDuzenleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.KategorilerTablosu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAciklama = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtKategoriAdi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.txtAra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.KategorilerTablosu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KategorilerTablosu
            // 
            this.KategorilerTablosu.AllowUserToAddRows = false;
            this.KategorilerTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KategorilerTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KategorilerTablosu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.KategorilerTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KategorilerTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.KategorilerTablosu.ColumnHeadersHeight = 45;
            this.KategorilerTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.KategorilerTablosu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.KategorilerTablosu.Location = new System.Drawing.Point(13, 88);
            this.KategorilerTablosu.MultiSelect = false;
            this.KategorilerTablosu.Name = "KategorilerTablosu";
            this.KategorilerTablosu.ReadOnly = true;
            this.KategorilerTablosu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.KategorilerTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KategorilerTablosu.ShowEditingIcon = false;
            this.KategorilerTablosu.Size = new System.Drawing.Size(414, 383);
            this.KategorilerTablosu.TabIndex = 5;
            this.KategorilerTablosu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.KategorilerTablosu_RowEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.materialFlatButton2);
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtKategoriAdi);
            this.panel1.Location = new System.Drawing.Point(440, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 335);
            this.panel1.TabIndex = 0;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(214, 228);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(79, 36);
            this.materialFlatButton2.TabIndex = 2;
            this.materialFlatButton2.Text = "Güncelle";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Depth = 0;
            this.txtAciklama.Hint = "Açıklama";
            this.txtAciklama.Location = new System.Drawing.Point(31, 196);
            this.txtAciklama.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.Size = new System.Drawing.Size(262, 23);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.TabStop = false;
            this.txtAciklama.UseSystemPasswordChar = false;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Depth = 0;
            this.txtKategoriAdi.Hint = "Kategori Adı";
            this.txtKategoriAdi.Location = new System.Drawing.Point(31, 156);
            this.txtKategoriAdi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.PasswordChar = '\0';
            this.txtKategoriAdi.SelectedText = "";
            this.txtKategoriAdi.SelectionLength = 0;
            this.txtKategoriAdi.SelectionStart = 0;
            this.txtKategoriAdi.Size = new System.Drawing.Size(262, 23);
            this.txtKategoriAdi.TabIndex = 0;
            this.txtKategoriAdi.TabStop = false;
            this.txtKategoriAdi.UseSystemPasswordChar = false;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(440, 430);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(319, 41);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Kaydı Sil";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblFiltre.Location = new System.Drawing.Point(10, 24);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(118, 17);
            this.lblFiltre.TabIndex = 11;
            this.lblFiltre.Text = "Listeleme Kısıtları:";
            // 
            // txtAra
            // 
            this.txtAra.Depth = 0;
            this.txtAra.Hint = "Kategoriyi Ara";
            this.txtAra.Location = new System.Drawing.Point(13, 59);
            this.txtAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(414, 23);
            this.txtAra.TabIndex = 4;
            this.txtAra.UseSystemPasswordChar = false;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // KategoriDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.KategorilerTablosu);
            this.Name = "KategoriDuzenleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.KategoriDuzenleme_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.KategoriDuzenleme_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.KategorilerTablosu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView KategorilerTablosu;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtKategoriAdi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAciklama;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.Label lblFiltre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAra;
    }
}
