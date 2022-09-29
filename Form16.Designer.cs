namespace deneme_veritabanı
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kscinsiyet = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.kstbgsm = new System.Windows.Forms.MaskedTextBox();
            this.kstbtc = new System.Windows.Forms.TextBox();
            this.kstbsoyadi = new System.Windows.Forms.TextBox();
            this.kstbadi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.kscikis = new System.Windows.Forms.DateTimePicker();
            this.ksgiris = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kstbmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bosaltbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(805, 211);
            this.dataGridView1.TabIndex = 80;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 269);
            this.textBox2.MaxLength = 11;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 81;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "TC FİLTRESİ:";
            // 
            // kscinsiyet
            // 
            this.kscinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kscinsiyet.Enabled = false;
            this.kscinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kscinsiyet.FormattingEnabled = true;
            this.kscinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.kscinsiyet.Location = new System.Drawing.Point(669, 310);
            this.kscinsiyet.Name = "kscinsiyet";
            this.kscinsiyet.Size = new System.Drawing.Size(126, 26);
            this.kscinsiyet.TabIndex = 112;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Window;
            this.label34.Enabled = false;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(591, 313);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(68, 20);
            this.label34.TabIndex = 111;
            this.label34.Text = "Cinsiyet:";
            // 
            // kstbgsm
            // 
            this.kstbgsm.Enabled = false;
            this.kstbgsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbgsm.Location = new System.Drawing.Point(669, 279);
            this.kstbgsm.Mask = "(999) 000-0000";
            this.kstbgsm.Name = "kstbgsm";
            this.kstbgsm.PromptChar = ' ';
            this.kstbgsm.ReadOnly = true;
            this.kstbgsm.Size = new System.Drawing.Size(126, 25);
            this.kstbgsm.TabIndex = 110;
            // 
            // kstbtc
            // 
            this.kstbtc.Enabled = false;
            this.kstbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbtc.Location = new System.Drawing.Point(330, 341);
            this.kstbtc.MaxLength = 11;
            this.kstbtc.Name = "kstbtc";
            this.kstbtc.ReadOnly = true;
            this.kstbtc.Size = new System.Drawing.Size(227, 25);
            this.kstbtc.TabIndex = 108;
            // 
            // kstbsoyadi
            // 
            this.kstbsoyadi.Enabled = false;
            this.kstbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbsoyadi.Location = new System.Drawing.Point(330, 310);
            this.kstbsoyadi.MaxLength = 16;
            this.kstbsoyadi.Name = "kstbsoyadi";
            this.kstbsoyadi.ReadOnly = true;
            this.kstbsoyadi.Size = new System.Drawing.Size(194, 25);
            this.kstbsoyadi.TabIndex = 109;
            // 
            // kstbadi
            // 
            this.kstbadi.Enabled = false;
            this.kstbadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbadi.Location = new System.Drawing.Point(330, 279);
            this.kstbadi.MaxLength = 16;
            this.kstbadi.Name = "kstbadi";
            this.kstbadi.ReadOnly = true;
            this.kstbadi.Size = new System.Drawing.Size(194, 25);
            this.kstbadi.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(283, 282);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 20);
            this.label12.TabIndex = 105;
            this.label12.Text = "Adı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Window;
            this.label15.Enabled = false;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(259, 313);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 20);
            this.label15.TabIndex = 104;
            this.label15.Text = "Soyadı:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Window;
            this.label18.Enabled = false;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(259, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 20);
            this.label18.TabIndex = 103;
            this.label18.Text = "T.C No:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Window;
            this.label19.Enabled = false;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(588, 286);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 106;
            this.label19.Text = "Gsm No:";
            // 
            // kscikis
            // 
            this.kscikis.Enabled = false;
            this.kscikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kscikis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kscikis.Location = new System.Drawing.Point(669, 372);
            this.kscikis.Name = "kscikis";
            this.kscikis.Size = new System.Drawing.Size(162, 25);
            this.kscikis.TabIndex = 114;
            this.kscikis.Value = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            // 
            // ksgiris
            // 
            this.ksgiris.Enabled = false;
            this.ksgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ksgiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ksgiris.Location = new System.Drawing.Point(669, 341);
            this.ksgiris.Name = "ksgiris";
            this.ksgiris.Size = new System.Drawing.Size(162, 25);
            this.ksgiris.TabIndex = 113;
            this.ksgiris.Value = new System.DateTime(2018, 6, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Çıkış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(575, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Giriş Tarihi:";
            // 
            // kstbmail
            // 
            this.kstbmail.Enabled = false;
            this.kstbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbmail.Location = new System.Drawing.Point(330, 372);
            this.kstbmail.Name = "kstbmail";
            this.kstbmail.Size = new System.Drawing.Size(227, 25);
            this.kstbmail.TabIndex = 116;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(269, 377);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 115;
            this.label13.Text = "Mail :";
            // 
            // bosaltbutton
            // 
            this.bosaltbutton.BackColor = System.Drawing.Color.BurlyWood;
            this.bosaltbutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bosaltbutton.FlatAppearance.BorderSize = 3;
            this.bosaltbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bosaltbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bosaltbutton.Location = new System.Drawing.Point(38, 325);
            this.bosaltbutton.Name = "bosaltbutton";
            this.bosaltbutton.Size = new System.Drawing.Size(152, 36);
            this.bosaltbutton.TabIndex = 117;
            this.bosaltbutton.Text = "Listeyi Boşalt";
            this.bosaltbutton.UseVisualStyleBackColor = false;
            this.bosaltbutton.Click += new System.EventHandler(this.bosaltbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(54, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 117;
            this.button1.Text = "Raporla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(10, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "ÇIKIŞ GÜNÜ:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(90, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 118;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(196, 270);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 119;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tc İle";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(180, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 119;
            this.radioButton2.Text = "Tarih ile";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.depositphotos_142369728_stock_illustration_letter_h_emblem_with_crown;
            this.ClientSize = new System.Drawing.Size(892, 417);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bosaltbutton);
            this.Controls.Add(this.kstbmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.kscikis);
            this.Controls.Add(this.ksgiris);
            this.Controls.Add(this.kscinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.kstbgsm);
            this.Controls.Add(this.kstbtc);
            this.Controls.Add(this.kstbsoyadi);
            this.Controls.Add(this.kstbadi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(908, 456);
            this.MinimumSize = new System.Drawing.Size(908, 456);
            this.Name = "Form16";
            this.Text = "Eski Müsterilerimiz";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kscinsiyet;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.MaskedTextBox kstbgsm;
        private System.Windows.Forms.TextBox kstbtc;
        private System.Windows.Forms.TextBox kstbsoyadi;
        private System.Windows.Forms.TextBox kstbadi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker kscikis;
        private System.Windows.Forms.DateTimePicker ksgiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kstbmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bosaltbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

    }
}