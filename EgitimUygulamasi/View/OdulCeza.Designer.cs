namespace EgitimUygulamasi.View
{
    partial class OdulCeza
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.OdulVeCezaTablosu = new System.Windows.Forms.DataGridView();
            this.lblBilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OdulVeCezaTablosu)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(507, 95);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 316);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(-10, 88);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(778, 1);
            this.materialDivider3.TabIndex = 5;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-10, 435);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(778, 1);
            this.materialDivider1.TabIndex = 7;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(491, 445);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(250, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "Tüm Çalışanların Puanını Sıfırla";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // OdulVeCezaTablosu
            // 
            this.OdulVeCezaTablosu.AllowUserToAddRows = false;
            this.OdulVeCezaTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OdulVeCezaTablosu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OdulVeCezaTablosu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.OdulVeCezaTablosu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OdulVeCezaTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.OdulVeCezaTablosu.ColumnHeadersHeight = 45;
            this.OdulVeCezaTablosu.Cursor = System.Windows.Forms.Cursors.Default;
            this.OdulVeCezaTablosu.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.OdulVeCezaTablosu.Location = new System.Drawing.Point(16, 95);
            this.OdulVeCezaTablosu.MultiSelect = false;
            this.OdulVeCezaTablosu.Name = "OdulVeCezaTablosu";
            this.OdulVeCezaTablosu.ReadOnly = true;
            this.OdulVeCezaTablosu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OdulVeCezaTablosu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdulVeCezaTablosu.ShowEditingIcon = false;
            this.OdulVeCezaTablosu.Size = new System.Drawing.Size(485, 316);
            this.OdulVeCezaTablosu.TabIndex = 20;
            this.OdulVeCezaTablosu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.OdulVeCezaTablosu_RowEnter);
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilgi.Location = new System.Drawing.Point(351, 50);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(55, 23);
            this.lblBilgi.TabIndex = 21;
            this.lblBilgi.Text = "Ödül";
            // 
            // OdulCeza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.OdulVeCezaTablosu);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "OdulCeza";
            this.Size = new System.Drawing.Size(768, 522);
            this.Load += new System.EventHandler(this.OdulCeza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdulVeCezaTablosu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView OdulVeCezaTablosu;
        private System.Windows.Forms.Label lblBilgi;
    }
}
