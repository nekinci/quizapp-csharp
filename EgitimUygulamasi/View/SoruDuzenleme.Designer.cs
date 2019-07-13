namespace EgitimUygulamasi.View
{
    partial class SoruDuzenleme
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
            this.SorularTablosu = new System.Windows.Forms.DataGridView();
            this.txtAra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabSorular = new System.Windows.Forms.TabControl();
            this.sorutab = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnIlerle = new MaterialSkin.Controls.MaterialFlatButton();
            this.cmbZorlukSeviyesi = new MetroFramework.Controls.MetroComboBox();
            this.cmbKategori = new MetroFramework.Controls.MetroComboBox();
            this.txtSure = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMedya = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSoruBasligi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.secenektab = new System.Windows.Forms.TabPage();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDogru = new MetroFramework.Controls.MetroComboBox();
            this.txtE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtD = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtA = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cmbFiltreZorluk = new MetroFramework.Controls.MetroComboBox();
            this.cmbFiltreKategori = new MetroFramework.Controls.MetroComboBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.chkKlasik = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkMedya = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SorularTablosu)).BeginInit();
            this.tabSorular.SuspendLayout();
            this.sorutab.SuspendLayout();
            this.secenektab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SorularTablosu
            // 
            this.SorularTablosu.AllowUserToAddRows = false;
            this.SorularTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SorularTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SorularTablosu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SorularTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SorularTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SorularTablosu.ColumnHeadersHeight = 45;
            this.SorularTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.SorularTablosu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.SorularTablosu.Location = new System.Drawing.Point(13, 88);
            this.SorularTablosu.MultiSelect = false;
            this.SorularTablosu.Name = "SorularTablosu";
            this.SorularTablosu.ReadOnly = true;
            this.SorularTablosu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SorularTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SorularTablosu.ShowEditingIcon = false;
            this.SorularTablosu.Size = new System.Drawing.Size(414, 383);
            this.SorularTablosu.TabIndex = 18;
            this.SorularTablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.SorularTablosu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SorularTablosu_RowEnter);
            // 
            // txtAra
            // 
            this.txtAra.Depth = 0;
            this.txtAra.Hint = "Soruyu ara";
            this.txtAra.Location = new System.Drawing.Point(307, 59);
            this.txtAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAra.Name = "txtAra";
            this.txtAra.PasswordChar = '\0';
            this.txtAra.SelectedText = "";
            this.txtAra.SelectionLength = 0;
            this.txtAra.SelectionStart = 0;
            this.txtAra.Size = new System.Drawing.Size(440, 23);
            this.txtAra.TabIndex = 17;
            this.txtAra.UseSystemPasswordChar = false;
            this.txtAra.Click += new System.EventHandler(this.txtAra_Click);
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // tabSorular
            // 
            this.tabSorular.Controls.Add(this.sorutab);
            this.tabSorular.Controls.Add(this.secenektab);
            this.tabSorular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabSorular.Location = new System.Drawing.Point(433, 88);
            this.tabSorular.Multiline = true;
            this.tabSorular.Name = "tabSorular";
            this.tabSorular.SelectedIndex = 0;
            this.tabSorular.Size = new System.Drawing.Size(323, 336);
            this.tabSorular.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSorular.TabIndex = 0;
            // 
            // sorutab
            // 
            this.sorutab.AllowDrop = true;
            this.sorutab.BackColor = System.Drawing.Color.White;
            this.sorutab.Controls.Add(this.chkMedya);
            this.sorutab.Controls.Add(this.materialFlatButton2);
            this.sorutab.Controls.Add(this.materialFlatButton1);
            this.sorutab.Controls.Add(this.materialLabel1);
            this.sorutab.Controls.Add(this.btnIlerle);
            this.sorutab.Controls.Add(this.cmbZorlukSeviyesi);
            this.sorutab.Controls.Add(this.cmbKategori);
            this.sorutab.Controls.Add(this.txtSure);
            this.sorutab.Controls.Add(this.txtMedya);
            this.sorutab.Controls.Add(this.txtSoruBasligi);
            this.sorutab.Location = new System.Drawing.Point(4, 26);
            this.sorutab.Name = "sorutab";
            this.sorutab.Padding = new System.Windows.Forms.Padding(3);
            this.sorutab.Size = new System.Drawing.Size(315, 306);
            this.sorutab.TabIndex = 0;
            this.sorutab.Text = "Soru";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(67, 214);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton2.TabIndex = 5;
            this.materialFlatButton2.TabStop = false;
            this.materialFlatButton2.Text = "Medya Gör";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click_1);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(164, 214);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(121, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.TabStop = false;
            this.materialFlatButton1.Text = "medya değiştir";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(259, 157);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(25, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "sn";
            // 
            // btnIlerle
            // 
            this.btnIlerle.AutoSize = true;
            this.btnIlerle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIlerle.Depth = 0;
            this.btnIlerle.Location = new System.Drawing.Point(229, 262);
            this.btnIlerle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIlerle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIlerle.Name = "btnIlerle";
            this.btnIlerle.Primary = false;
            this.btnIlerle.Size = new System.Drawing.Size(55, 36);
            this.btnIlerle.TabIndex = 7;
            this.btnIlerle.TabStop = false;
            this.btnIlerle.Text = "İLERLE";
            this.btnIlerle.UseVisualStyleBackColor = true;
            this.btnIlerle.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // cmbZorlukSeviyesi
            // 
            this.cmbZorlukSeviyesi.FormattingEnabled = true;
            this.cmbZorlukSeviyesi.ItemHeight = 23;
            this.cmbZorlukSeviyesi.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbZorlukSeviyesi.Location = new System.Drawing.Point(34, 118);
            this.cmbZorlukSeviyesi.Name = "cmbZorlukSeviyesi";
            this.cmbZorlukSeviyesi.PromptText = "Zorluk seviyesi seçiniz";
            this.cmbZorlukSeviyesi.Size = new System.Drawing.Size(251, 29);
            this.cmbZorlukSeviyesi.TabIndex = 2;
            this.cmbZorlukSeviyesi.TabStop = false;
            this.cmbZorlukSeviyesi.UseSelectable = true;
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.ItemHeight = 23;
            this.cmbKategori.Location = new System.Drawing.Point(34, 83);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.PromptText = "Kategori seçiniz";
            this.cmbKategori.Size = new System.Drawing.Size(251, 29);
            this.cmbKategori.TabIndex = 1;
            this.cmbKategori.TabStop = false;
            this.cmbKategori.UseSelectable = true;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.txtMedya_TextChanged);
            this.cmbKategori.SelectionChangeCommitted += new System.EventHandler(this.cmbKategori_SelectionChangeCommitted);
            // 
            // txtSure
            // 
            this.txtSure.Depth = 0;
            this.txtSure.Hint = "Süre giriniz(yalnızca sayı)";
            this.txtSure.Location = new System.Drawing.Point(34, 153);
            this.txtSure.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSure.Name = "txtSure";
            this.txtSure.PasswordChar = '\0';
            this.txtSure.SelectedText = "";
            this.txtSure.SelectionLength = 0;
            this.txtSure.SelectionStart = 0;
            this.txtSure.Size = new System.Drawing.Size(219, 23);
            this.txtSure.TabIndex = 3;
            this.txtSure.TabStop = false;
            this.txtSure.UseSystemPasswordChar = false;
            this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
            this.txtSure.TextChanged += new System.EventHandler(this.txtSure_TextChanged);
            // 
            // txtMedya
            // 
            this.txtMedya.Depth = 0;
            this.txtMedya.Hint = "Medya";
            this.txtMedya.Location = new System.Drawing.Point(34, 182);
            this.txtMedya.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMedya.Name = "txtMedya";
            this.txtMedya.PasswordChar = '\0';
            this.txtMedya.SelectedText = "";
            this.txtMedya.SelectionLength = 0;
            this.txtMedya.SelectionStart = 0;
            this.txtMedya.Size = new System.Drawing.Size(251, 23);
            this.txtMedya.TabIndex = 4;
            this.txtMedya.TabStop = false;
            this.txtMedya.UseSystemPasswordChar = false;
            this.txtMedya.TextChanged += new System.EventHandler(this.txtMedya_TextChanged);
            // 
            // txtSoruBasligi
            // 
            this.txtSoruBasligi.Depth = 0;
            this.txtSoruBasligi.Hint = "Soru Başlığı";
            this.txtSoruBasligi.Location = new System.Drawing.Point(34, 54);
            this.txtSoruBasligi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSoruBasligi.Name = "txtSoruBasligi";
            this.txtSoruBasligi.PasswordChar = '\0';
            this.txtSoruBasligi.SelectedText = "";
            this.txtSoruBasligi.SelectionLength = 0;
            this.txtSoruBasligi.SelectionStart = 0;
            this.txtSoruBasligi.Size = new System.Drawing.Size(251, 23);
            this.txtSoruBasligi.TabIndex = 0;
            this.txtSoruBasligi.TabStop = false;
            this.txtSoruBasligi.UseSystemPasswordChar = false;
            // 
            // secenektab
            // 
            this.secenektab.BackColor = System.Drawing.Color.White;
            this.secenektab.Controls.Add(this.materialFlatButton3);
            this.secenektab.Controls.Add(this.label1);
            this.secenektab.Controls.Add(this.cmbDogru);
            this.secenektab.Controls.Add(this.txtE);
            this.secenektab.Controls.Add(this.txtD);
            this.secenektab.Controls.Add(this.txtC);
            this.secenektab.Controls.Add(this.txtB);
            this.secenektab.Controls.Add(this.txtA);
            this.secenektab.Location = new System.Drawing.Point(4, 26);
            this.secenektab.Name = "secenektab";
            this.secenektab.Padding = new System.Windows.Forms.Padding(3);
            this.secenektab.Size = new System.Drawing.Size(315, 306);
            this.secenektab.TabIndex = 1;
            this.secenektab.Text = "Seçenek";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(219, 247);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(63, 36);
            this.materialFlatButton3.TabIndex = 4;
            this.materialFlatButton3.Text = "Kaydet";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doğru Cevap";
            // 
            // cmbDogru
            // 
            this.cmbDogru.FormattingEnabled = true;
            this.cmbDogru.ItemHeight = 23;
            this.cmbDogru.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cmbDogru.Location = new System.Drawing.Point(31, 209);
            this.cmbDogru.Name = "cmbDogru";
            this.cmbDogru.PromptText = "Dogru cevabı seçiniz";
            this.cmbDogru.Size = new System.Drawing.Size(251, 29);
            this.cmbDogru.TabIndex = 13;
            this.cmbDogru.TabStop = false;
            this.cmbDogru.UseSelectable = true;
            // 
            // txtE
            // 
            this.txtE.Depth = 0;
            this.txtE.Hint = "E Seçeneği";
            this.txtE.Location = new System.Drawing.Point(31, 148);
            this.txtE.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtE.Name = "txtE";
            this.txtE.PasswordChar = '\0';
            this.txtE.SelectedText = "";
            this.txtE.SelectionLength = 0;
            this.txtE.SelectionStart = 0;
            this.txtE.Size = new System.Drawing.Size(251, 23);
            this.txtE.TabIndex = 12;
            this.txtE.TabStop = false;
            this.txtE.UseSystemPasswordChar = false;
            // 
            // txtD
            // 
            this.txtD.Depth = 0;
            this.txtD.Hint = "D Seçeneği";
            this.txtD.Location = new System.Drawing.Point(31, 119);
            this.txtD.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtD.Name = "txtD";
            this.txtD.PasswordChar = '\0';
            this.txtD.SelectedText = "";
            this.txtD.SelectionLength = 0;
            this.txtD.SelectionStart = 0;
            this.txtD.Size = new System.Drawing.Size(251, 23);
            this.txtD.TabIndex = 11;
            this.txtD.TabStop = false;
            this.txtD.UseSystemPasswordChar = false;
            // 
            // txtC
            // 
            this.txtC.Depth = 0;
            this.txtC.Hint = "C Seçeneği";
            this.txtC.Location = new System.Drawing.Point(31, 89);
            this.txtC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtC.Name = "txtC";
            this.txtC.PasswordChar = '\0';
            this.txtC.SelectedText = "";
            this.txtC.SelectionLength = 0;
            this.txtC.SelectionStart = 0;
            this.txtC.Size = new System.Drawing.Size(251, 23);
            this.txtC.TabIndex = 10;
            this.txtC.TabStop = false;
            this.txtC.UseSystemPasswordChar = false;
            // 
            // txtB
            // 
            this.txtB.Depth = 0;
            this.txtB.Hint = "B Seçeneği";
            this.txtB.Location = new System.Drawing.Point(31, 57);
            this.txtB.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtB.Name = "txtB";
            this.txtB.PasswordChar = '\0';
            this.txtB.SelectedText = "";
            this.txtB.SelectionLength = 0;
            this.txtB.SelectionStart = 0;
            this.txtB.Size = new System.Drawing.Size(251, 23);
            this.txtB.TabIndex = 9;
            this.txtB.TabStop = false;
            this.txtB.UseSystemPasswordChar = false;
            // 
            // txtA
            // 
            this.txtA.Depth = 0;
            this.txtA.Hint = "A Seçeneği";
            this.txtA.Location = new System.Drawing.Point(31, 27);
            this.txtA.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtA.Name = "txtA";
            this.txtA.PasswordChar = '\0';
            this.txtA.SelectedText = "";
            this.txtA.SelectionLength = 0;
            this.txtA.SelectionStart = 0;
            this.txtA.Size = new System.Drawing.Size(251, 23);
            this.txtA.TabIndex = 8;
            this.txtA.TabStop = false;
            this.txtA.UseSystemPasswordChar = false;
            this.txtA.Click += new System.EventHandler(this.materialSingleLineTextField2_Click_1);
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(437, 430);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(319, 41);
            this.materialRaisedButton1.TabIndex = 14;
            this.materialRaisedButton1.Text = "Kaydı Sil";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // cmbFiltreZorluk
            // 
            this.cmbFiltreZorluk.FormattingEnabled = true;
            this.cmbFiltreZorluk.ItemHeight = 23;
            this.cmbFiltreZorluk.Items.AddRange(new object[] {
            "Tümü",
            "Kolay",
            "Orta",
            "Zor"});
            this.cmbFiltreZorluk.Location = new System.Drawing.Point(160, 53);
            this.cmbFiltreZorluk.Name = "cmbFiltreZorluk";
            this.cmbFiltreZorluk.PromptText = "Zorluk Seviyesi";
            this.cmbFiltreZorluk.Size = new System.Drawing.Size(141, 29);
            this.cmbFiltreZorluk.TabIndex = 16;
            this.cmbFiltreZorluk.UseSelectable = true;
            this.cmbFiltreZorluk.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            this.cmbFiltreZorluk.SelectionChangeCommitted += new System.EventHandler(this.cmbFiltreZorluk_SelectionChangeCommitted);
            // 
            // cmbFiltreKategori
            // 
            this.cmbFiltreKategori.FormattingEnabled = true;
            this.cmbFiltreKategori.ItemHeight = 23;
            this.cmbFiltreKategori.Location = new System.Drawing.Point(13, 53);
            this.cmbFiltreKategori.Name = "cmbFiltreKategori";
            this.cmbFiltreKategori.PromptText = "Kategori";
            this.cmbFiltreKategori.Size = new System.Drawing.Size(141, 29);
            this.cmbFiltreKategori.TabIndex = 15;
            this.cmbFiltreKategori.UseSelectable = true;
            this.cmbFiltreKategori.SelectedIndexChanged += new System.EventHandler(this.cmbFiltreKategori_SelectedIndexChanged);
            this.cmbFiltreKategori.SelectionChangeCommitted += new System.EventHandler(this.cmbFiltreKategori_SelectionChangeCommitted);
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lblFiltre.Location = new System.Drawing.Point(10, 24);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(118, 17);
            this.lblFiltre.TabIndex = 7;
            this.lblFiltre.Text = "Listeleme Kısıtları:";
            // 
            // chkKlasik
            // 
            this.chkKlasik.AutoSize = true;
            this.chkKlasik.Depth = 0;
            this.chkKlasik.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkKlasik.Location = new System.Drawing.Point(640, 81);
            this.chkKlasik.Margin = new System.Windows.Forms.Padding(0);
            this.chkKlasik.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkKlasik.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkKlasik.Name = "chkKlasik";
            this.chkKlasik.Ripple = true;
            this.chkKlasik.Size = new System.Drawing.Size(109, 30);
            this.chkKlasik.TabIndex = 19;
            this.chkKlasik.Text = "Klasik/Görev";
            this.chkKlasik.UseVisualStyleBackColor = true;
            this.chkKlasik.CheckedChanged += new System.EventHandler(this.chkKlasik_CheckedChanged);
            // 
            // chkMedya
            // 
            this.chkMedya.AutoSize = true;
            this.chkMedya.Depth = 0;
            this.chkMedya.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkMedya.Location = new System.Drawing.Point(34, 262);
            this.chkMedya.Margin = new System.Windows.Forms.Padding(0);
            this.chkMedya.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMedya.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMedya.Name = "chkMedya";
            this.chkMedya.Ripple = true;
            this.chkMedya.Size = new System.Drawing.Size(131, 30);
            this.chkMedya.TabIndex = 8;
            this.chkMedya.Text = "Medya Yok(Boş)";
            this.chkMedya.UseVisualStyleBackColor = true;
            this.chkMedya.CheckedChanged += new System.EventHandler(this.chkMedya_CheckedChanged);
            // 
            // SoruDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkKlasik);
            this.Controls.Add(this.lblFiltre);
            this.Controls.Add(this.cmbFiltreKategori);
            this.Controls.Add(this.cmbFiltreZorluk);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.tabSorular);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.SorularTablosu);
            this.Name = "SoruDuzenleme";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.SoruDuzenleme_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SoruDuzenleme_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.SorularTablosu)).EndInit();
            this.tabSorular.ResumeLayout(false);
            this.sorutab.ResumeLayout(false);
            this.sorutab.PerformLayout();
            this.secenektab.ResumeLayout(false);
            this.secenektab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SorularTablosu;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAra;
        private System.Windows.Forms.TabControl tabSorular;
        private System.Windows.Forms.TabPage sorutab;
        private System.Windows.Forms.TabPage secenektab;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSoruBasligi;
        private MetroFramework.Controls.MetroComboBox cmbKategori;
        private MetroFramework.Controls.MetroComboBox cmbZorlukSeviyesi;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSure;
        private MaterialSkin.Controls.MaterialFlatButton btnIlerle;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtB;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtA;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbDogru;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtE;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtD;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtC;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cmbFiltreZorluk;
        private MetroFramework.Controls.MetroComboBox cmbFiltreKategori;
        private System.Windows.Forms.Label lblFiltre;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMedya;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialCheckBox chkKlasik;
        private MaterialSkin.Controls.MaterialCheckBox chkMedya;
    }
}
