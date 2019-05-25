namespace EgitimUygulamasi.View
{
    partial class QuestionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOturumuKapat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.soruEkrani1 = new EgitimUygulamasi.View.SoruEkrani();
            this.stepOneApp1 = new EgitimUygulamasi.View.StepOneApp();
            this.medyaEkraniSoru1 = new EgitimUygulamasi.View.MedyaEkraniSoru();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnOturumuKapat);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOturumuKapat
            // 
            this.btnOturumuKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            this.btnOturumuKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOturumuKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOturumuKapat.FlatAppearance.BorderSize = 0;
            this.btnOturumuKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnOturumuKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(25)))), ((int)(((byte)(63)))));
            this.btnOturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOturumuKapat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOturumuKapat.ForeColor = System.Drawing.Color.White;
            this.btnOturumuKapat.Location = new System.Drawing.Point(524, 0);
            this.btnOturumuKapat.Name = "btnOturumuKapat";
            this.btnOturumuKapat.Size = new System.Drawing.Size(138, 46);
            this.btnOturumuKapat.TabIndex = 5;
            this.btnOturumuKapat.Text = "Oturumu Kapat";
            this.btnOturumuKapat.UseVisualStyleBackColor = false;
            this.btnOturumuKapat.Click += new System.EventHandler(this.btnOturumuKapat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(55, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eğitim Uygulaması";
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(662, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(62, 46);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnCikis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(724, 0);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(56, 46);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "X";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(-15, -15);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(75, 23);
            this.metroLink1.TabIndex = 4;
            this.metroLink1.Text = "metroLink1";
            this.metroLink1.UseSelectable = true;
            // 
            // soruEkrani1
            // 
            this.soruEkrani1.BackColor = System.Drawing.Color.Cornsilk;
            this.soruEkrani1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soruEkrani1.Location = new System.Drawing.Point(0, 46);
            this.soruEkrani1.Name = "soruEkrani1";
            this.soruEkrani1.Size = new System.Drawing.Size(780, 491);
            this.soruEkrani1.TabIndex = 6;
            this.soruEkrani1.Visible = false;
            this.soruEkrani1.Load += new System.EventHandler(this.soruEkrani1_Load);
            // 
            // stepOneApp1
            // 
            this.stepOneApp1.BackColor = System.Drawing.Color.White;
            this.stepOneApp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepOneApp1.Location = new System.Drawing.Point(0, 46);
            this.stepOneApp1.Name = "stepOneApp1";
            this.stepOneApp1.Size = new System.Drawing.Size(780, 491);
            this.stepOneApp1.TabIndex = 5;
            this.stepOneApp1.Load += new System.EventHandler(this.stepOneApp1_Load);
            // 
            // medyaEkraniSoru1
            // 
            this.medyaEkraniSoru1.BackColor = System.Drawing.Color.White;
            this.medyaEkraniSoru1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.medyaEkraniSoru1.Location = new System.Drawing.Point(0, 47);
            this.medyaEkraniSoru1.Name = "medyaEkraniSoru1";
            this.medyaEkraniSoru1.Size = new System.Drawing.Size(780, 490);
            this.medyaEkraniSoru1.TabIndex = 7;
            this.medyaEkraniSoru1.Visible = false;
            this.medyaEkraniSoru1.Load += new System.EventHandler(this.medyaEkraniSoru1_Load);
            // 
            // QuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(780, 537);
            this.Controls.Add(this.medyaEkraniSoru1);
            this.Controls.Add(this.soruEkrani1);
            this.Controls.Add(this.stepOneApp1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EgitimUygulamasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnMin;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOturumuKapat;
        private StepOneApp stepOneApp1;
        private SoruEkrani soruEkrani1;
        private MedyaEkraniSoru medyaEkraniSoru1;
    }
}