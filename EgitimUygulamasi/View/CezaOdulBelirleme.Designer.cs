namespace EgitimUygulamasi.View
{
    partial class CezaOdulBelirleme
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabSorular = new System.Windows.Forms.TabControl();
            this.sorutab = new System.Windows.Forms.TabPage();
            this.secenektab = new System.Windows.Forms.TabPage();
            this.txtAd = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbTur = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAralik1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAralik2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btmKaydet = new MaterialSkin.Controls.MaterialFlatButton();
            this.OdulVeCezaTablosu = new System.Windows.Forms.DataGridView();
            this.btnKaydet1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtAralik21 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAralik11 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cmbTur1 = new MetroFramework.Controls.MetroComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAd1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSil = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabSorular.SuspendLayout();
            this.sorutab.SuspendLayout();
            this.secenektab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdulVeCezaTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSorular
            // 
            this.tabSorular.Controls.Add(this.sorutab);
            this.tabSorular.Controls.Add(this.secenektab);
            this.tabSorular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabSorular.Location = new System.Drawing.Point(13, 31);
            this.tabSorular.Multiline = true;
            this.tabSorular.Name = "tabSorular";
            this.tabSorular.SelectedIndex = 0;
            this.tabSorular.Size = new System.Drawing.Size(738, 468);
            this.tabSorular.TabIndex = 1;
            // 
            // sorutab
            // 
            this.sorutab.AllowDrop = true;
            this.sorutab.BackColor = System.Drawing.Color.White;
            this.sorutab.Controls.Add(this.btmKaydet);
            this.sorutab.Controls.Add(this.txtAralik2);
            this.sorutab.Controls.Add(this.materialLabel4);
            this.sorutab.Controls.Add(this.txtAralik1);
            this.sorutab.Controls.Add(this.cmbTur);
            this.sorutab.Controls.Add(this.materialLabel3);
            this.sorutab.Controls.Add(this.materialLabel2);
            this.sorutab.Controls.Add(this.materialLabel1);
            this.sorutab.Controls.Add(this.txtAd);
            this.sorutab.Location = new System.Drawing.Point(4, 26);
            this.sorutab.Name = "sorutab";
            this.sorutab.Padding = new System.Windows.Forms.Padding(3);
            this.sorutab.Size = new System.Drawing.Size(730, 438);
            this.sorutab.TabIndex = 0;
            this.sorutab.Text = "Ödül ve Ceza Ekleme";
            // 
            // secenektab
            // 
            this.secenektab.BackColor = System.Drawing.Color.White;
            this.secenektab.Controls.Add(this.btnSil);
            this.secenektab.Controls.Add(this.btnKaydet1);
            this.secenektab.Controls.Add(this.txtAralik21);
            this.secenektab.Controls.Add(this.materialLabel5);
            this.secenektab.Controls.Add(this.txtAralik11);
            this.secenektab.Controls.Add(this.cmbTur1);
            this.secenektab.Controls.Add(this.materialLabel6);
            this.secenektab.Controls.Add(this.materialLabel7);
            this.secenektab.Controls.Add(this.materialLabel8);
            this.secenektab.Controls.Add(this.txtAd1);
            this.secenektab.Controls.Add(this.OdulVeCezaTablosu);
            this.secenektab.Location = new System.Drawing.Point(4, 26);
            this.secenektab.Name = "secenektab";
            this.secenektab.Padding = new System.Windows.Forms.Padding(3);
            this.secenektab.Size = new System.Drawing.Size(730, 438);
            this.secenektab.TabIndex = 1;
            this.secenektab.Text = "Listele ve Düzenle";
            // 
            // txtAd
            // 
            this.txtAd.Depth = 0;
            this.txtAd.Hint = "Ödül veya Ceza Adı";
            this.txtAd.Location = new System.Drawing.Point(186, 156);
            this.txtAd.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd.Name = "txtAd";
            this.txtAd.PasswordChar = '\0';
            this.txtAd.SelectedText = "";
            this.txtAd.SelectionLength = 0;
            this.txtAd.SelectionStart = 0;
            this.txtAd.Size = new System.Drawing.Size(355, 23);
            this.txtAd.TabIndex = 0;
            this.txtAd.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(182, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Ödül veya Ceza Adı";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(182, 192);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Ödül/Ceza";
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.ItemHeight = 23;
            this.cmbTur.Items.AddRange(new object[] {
            "Ödül",
            "Ceza"});
            this.cmbTur.Location = new System.Drawing.Point(186, 215);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.PromptText = "Ödül/Ceza";
            this.cmbTur.Size = new System.Drawing.Size(355, 29);
            this.cmbTur.TabIndex = 2;
            this.cmbTur.UseSelectable = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(182, 259);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(89, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Puan Aralığı";
            // 
            // txtAralik1
            // 
            this.txtAralik1.Depth = 0;
            this.txtAralik1.Hint = "";
            this.txtAralik1.Location = new System.Drawing.Point(186, 291);
            this.txtAralik1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAralik1.Name = "txtAralik1";
            this.txtAralik1.PasswordChar = '\0';
            this.txtAralik1.SelectedText = "";
            this.txtAralik1.SelectionLength = 0;
            this.txtAralik1.SelectionStart = 0;
            this.txtAralik1.Size = new System.Drawing.Size(160, 23);
            this.txtAralik1.TabIndex = 3;
            this.txtAralik1.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(359, 295);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(13, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "-";
            // 
            // txtAralik2
            // 
            this.txtAralik2.Depth = 0;
            this.txtAralik2.Hint = "";
            this.txtAralik2.Location = new System.Drawing.Point(386, 291);
            this.txtAralik2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAralik2.Name = "txtAralik2";
            this.txtAralik2.PasswordChar = '\0';
            this.txtAralik2.SelectedText = "";
            this.txtAralik2.SelectionLength = 0;
            this.txtAralik2.SelectionStart = 0;
            this.txtAralik2.Size = new System.Drawing.Size(155, 23);
            this.txtAralik2.TabIndex = 5;
            this.txtAralik2.UseSystemPasswordChar = false;
            this.txtAralik2.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // btmKaydet
            // 
            this.btmKaydet.AutoSize = true;
            this.btmKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btmKaydet.Depth = 0;
            this.btmKaydet.Location = new System.Drawing.Point(478, 323);
            this.btmKaydet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btmKaydet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btmKaydet.Name = "btmKaydet";
            this.btmKaydet.Primary = false;
            this.btmKaydet.Size = new System.Drawing.Size(63, 36);
            this.btmKaydet.TabIndex = 6;
            this.btmKaydet.Text = "Kaydet";
            this.btmKaydet.UseVisualStyleBackColor = true;
            this.btmKaydet.Click += new System.EventHandler(this.btmKaydet_Click);
            // 
            // OdulVeCezaTablosu
            // 
            this.OdulVeCezaTablosu.AllowUserToAddRows = false;
            this.OdulVeCezaTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.OdulVeCezaTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OdulVeCezaTablosu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.OdulVeCezaTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OdulVeCezaTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OdulVeCezaTablosu.ColumnHeadersHeight = 45;
            this.OdulVeCezaTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.OdulVeCezaTablosu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.OdulVeCezaTablosu.Location = new System.Drawing.Point(21, 29);
            this.OdulVeCezaTablosu.MultiSelect = false;
            this.OdulVeCezaTablosu.Name = "OdulVeCezaTablosu";
            this.OdulVeCezaTablosu.ReadOnly = true;
            this.OdulVeCezaTablosu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OdulVeCezaTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdulVeCezaTablosu.ShowEditingIcon = false;
            this.OdulVeCezaTablosu.Size = new System.Drawing.Size(414, 383);
            this.OdulVeCezaTablosu.TabIndex = 19;
            this.OdulVeCezaTablosu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdulVeCezaTablosu_RowEnter);
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.AutoSize = true;
            this.btnKaydet1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKaydet1.Depth = 0;
            this.btnKaydet1.Location = new System.Drawing.Point(637, 330);
            this.btnKaydet1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKaydet1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Primary = false;
            this.btnKaydet1.Size = new System.Drawing.Size(63, 36);
            this.btnKaydet1.TabIndex = 28;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // txtAralik21
            // 
            this.txtAralik21.Depth = 0;
            this.txtAralik21.Hint = "";
            this.txtAralik21.Location = new System.Drawing.Point(590, 302);
            this.txtAralik21.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAralik21.Name = "txtAralik21";
            this.txtAralik21.PasswordChar = '\0';
            this.txtAralik21.SelectedText = "";
            this.txtAralik21.SelectionLength = 0;
            this.txtAralik21.SelectionStart = 0;
            this.txtAralik21.Size = new System.Drawing.Size(110, 23);
            this.txtAralik21.TabIndex = 27;
            this.txtAralik21.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(571, 306);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(13, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "-";
            // 
            // txtAralik11
            // 
            this.txtAralik11.Depth = 0;
            this.txtAralik11.Hint = "";
            this.txtAralik11.Location = new System.Drawing.Point(463, 302);
            this.txtAralik11.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAralik11.Name = "txtAralik11";
            this.txtAralik11.PasswordChar = '\0';
            this.txtAralik11.SelectedText = "";
            this.txtAralik11.SelectionLength = 0;
            this.txtAralik11.SelectionStart = 0;
            this.txtAralik11.Size = new System.Drawing.Size(102, 23);
            this.txtAralik11.TabIndex = 25;
            this.txtAralik11.UseSystemPasswordChar = false;
            // 
            // cmbTur1
            // 
            this.cmbTur1.FormattingEnabled = true;
            this.cmbTur1.ItemHeight = 23;
            this.cmbTur1.Items.AddRange(new object[] {
            "Ödül",
            "Ceza"});
            this.cmbTur1.Location = new System.Drawing.Point(463, 226);
            this.cmbTur1.Name = "cmbTur1";
            this.cmbTur1.PromptText = "Ödül/Ceza";
            this.cmbTur1.Size = new System.Drawing.Size(237, 29);
            this.cmbTur1.TabIndex = 24;
            this.cmbTur1.UseSelectable = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(459, 270);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(89, 19);
            this.materialLabel6.TabIndex = 21;
            this.materialLabel6.Text = "Puan Aralığı";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(459, 203);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(78, 19);
            this.materialLabel7.TabIndex = 22;
            this.materialLabel7.Text = "Ödül/Ceza";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(459, 139);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(136, 19);
            this.materialLabel8.TabIndex = 23;
            this.materialLabel8.Text = "Ödül veya Ceza Adı";
            // 
            // txtAd1
            // 
            this.txtAd1.Depth = 0;
            this.txtAd1.Hint = "Ödül veya Ceza Adı";
            this.txtAd1.Location = new System.Drawing.Point(463, 167);
            this.txtAd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAd1.Name = "txtAd1";
            this.txtAd1.PasswordChar = '\0';
            this.txtAd1.SelectedText = "";
            this.txtAd1.SelectionLength = 0;
            this.txtAd1.SelectionStart = 0;
            this.txtAd1.Size = new System.Drawing.Size(237, 23);
            this.txtAd1.TabIndex = 20;
            this.txtAd1.UseSystemPasswordChar = false;
            // 
            // btnSil
            // 
            this.btnSil.Depth = 0;
            this.btnSil.Location = new System.Drawing.Point(463, 371);
            this.btnSil.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSil.Name = "btnSil";
            this.btnSil.Primary = true;
            this.btnSil.Size = new System.Drawing.Size(237, 41);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Kaydı Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // CezaOdulBelirleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabSorular);
            this.Name = "CezaOdulBelirleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.CezaOdulBelirleme_Load);
            this.tabSorular.ResumeLayout(false);
            this.sorutab.ResumeLayout(false);
            this.sorutab.PerformLayout();
            this.secenektab.ResumeLayout(false);
            this.secenektab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OdulVeCezaTablosu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSorular;
        private System.Windows.Forms.TabPage sorutab;
        private System.Windows.Forms.TabPage secenektab;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Controls.MetroComboBox cmbTur;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAralik2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAralik1;
        private MaterialSkin.Controls.MaterialFlatButton btmKaydet;
        private System.Windows.Forms.DataGridView OdulVeCezaTablosu;
        private MaterialSkin.Controls.MaterialFlatButton btnKaydet1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAralik21;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAralik11;
        private MetroFramework.Controls.MetroComboBox cmbTur1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAd1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSil;
    }
}
