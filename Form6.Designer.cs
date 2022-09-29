namespace deneme_veritabanı
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonodaduzenle = new System.Windows.Forms.Button();
            this.textboxfiyat = new System.Windows.Forms.TextBox();
            this.odadurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttononayla = new System.Windows.Forms.Button();
            this.odaturu = new System.Windows.Forms.ComboBox();
            this.yataksayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yataksayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataGridView1.Location = new System.Drawing.Point(121, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 355);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(103, 224);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(12, 252);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 19);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dolu Odalar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(12, 287);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Boş  Odalar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(8, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hepsini Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonodaduzenle
            // 
            this.buttonodaduzenle.BackColor = System.Drawing.Color.DarkRed;
            this.buttonodaduzenle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonodaduzenle.FlatAppearance.BorderSize = 2;
            this.buttonodaduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonodaduzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonodaduzenle.ForeColor = System.Drawing.Color.White;
            this.buttonodaduzenle.Location = new System.Drawing.Point(8, 348);
            this.buttonodaduzenle.Name = "buttonodaduzenle";
            this.buttonodaduzenle.Size = new System.Drawing.Size(107, 29);
            this.buttonodaduzenle.TabIndex = 5;
            this.buttonodaduzenle.Text = "Odaları Düzenle";
            this.buttonodaduzenle.UseVisualStyleBackColor = false;
            this.buttonodaduzenle.Click += new System.EventHandler(this.buttonodaduzenle_Click);
            // 
            // textboxfiyat
            // 
            this.textboxfiyat.Location = new System.Drawing.Point(181, 387);
            this.textboxfiyat.MaxLength = 4;
            this.textboxfiyat.Name = "textboxfiyat";
            this.textboxfiyat.Size = new System.Drawing.Size(60, 20);
            this.textboxfiyat.TabIndex = 6;
            this.textboxfiyat.Visible = false;
            this.textboxfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // odadurumu
            // 
            this.odadurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odadurumu.Enabled = false;
            this.odadurumu.FormattingEnabled = true;
            this.odadurumu.Items.AddRange(new object[] {
            "Boş",
            "Dolu"});
            this.odadurumu.Location = new System.Drawing.Point(545, 387);
            this.odadurumu.Name = "odadurumu";
            this.odadurumu.Size = new System.Drawing.Size(72, 21);
            this.odadurumu.TabIndex = 7;
            this.odadurumu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fiyat:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yatak Sayısı:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Oda Türü:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(546, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "OdaDurumu:";
            this.label4.Visible = false;
            // 
            // buttononayla
            // 
            this.buttononayla.Location = new System.Drawing.Point(644, 385);
            this.buttononayla.Name = "buttononayla";
            this.buttononayla.Size = new System.Drawing.Size(75, 23);
            this.buttononayla.TabIndex = 9;
            this.buttononayla.Text = "Onayla";
            this.buttononayla.UseVisualStyleBackColor = true;
            this.buttononayla.Visible = false;
            this.buttononayla.Click += new System.EventHandler(this.buttononayla_Click);
            // 
            // odaturu
            // 
            this.odaturu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.odaturu.FormattingEnabled = true;
            this.odaturu.Items.AddRange(new object[] {
            "Double",
            "Couple",
            "Single",
            "Triple",
            "Family",
            "King",
            "Couple Deluxe",
            "Family Big",
            "Triple Couple"});
            this.odaturu.Location = new System.Drawing.Point(408, 387);
            this.odaturu.Name = "odaturu";
            this.odaturu.Size = new System.Drawing.Size(91, 21);
            this.odaturu.TabIndex = 7;
            this.odaturu.Visible = false;
            // 
            // yataksayisi
            // 
            this.yataksayisi.Location = new System.Drawing.Point(294, 387);
            this.yataksayisi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yataksayisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yataksayisi.Name = "yataksayisi";
            this.yataksayisi.Size = new System.Drawing.Size(59, 20);
            this.yataksayisi.TabIndex = 10;
            this.yataksayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yataksayisi.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(738, 381);
            this.Controls.Add(this.yataksayisi);
            this.Controls.Add(this.buttononayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odaturu);
            this.Controls.Add(this.odadurumu);
            this.Controls.Add(this.textboxfiyat);
            this.Controls.Add(this.buttonodaduzenle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(754, 420);
            this.Name = "Form6";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yataksayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonodaduzenle;
        private System.Windows.Forms.TextBox textboxfiyat;
        private System.Windows.Forms.ComboBox odadurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttononayla;
        private System.Windows.Forms.ComboBox odaturu;
        private System.Windows.Forms.NumericUpDown yataksayisi;

    }
}