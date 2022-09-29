namespace deneme_veritabanı
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.buttononayla = new System.Windows.Forms.Button();
            this.buttonkayital = new System.Windows.Forms.Button();
            this.ksgiris = new System.Windows.Forms.DateTimePicker();
            this.kscbkat = new System.Windows.Forms.ComboBox();
            this.kscbcinsiyet = new System.Windows.Forms.ComboBox();
            this.kscbodatipi = new System.Windows.Forms.ComboBox();
            this.kstbgsm = new System.Windows.Forms.MaskedTextBox();
            this.kstboda = new System.Windows.Forms.TextBox();
            this.kstbmail = new System.Windows.Forms.TextBox();
            this.kstbtc = new System.Windows.Forms.TextBox();
            this.kstbsoyadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kstbadi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttononayla
            // 
            this.buttononayla.BackColor = System.Drawing.Color.Coral;
            this.buttononayla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttononayla.Enabled = false;
            this.buttononayla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttononayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttononayla.Location = new System.Drawing.Point(227, 405);
            this.buttononayla.Name = "buttononayla";
            this.buttononayla.Size = new System.Drawing.Size(80, 23);
            this.buttononayla.TabIndex = 78;
            this.buttononayla.Text = "Onayla";
            this.buttononayla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttononayla.UseVisualStyleBackColor = false;
            this.buttononayla.Click += new System.EventHandler(this.buttononayla_Click);
            // 
            // buttonkayital
            // 
            this.buttonkayital.BackColor = System.Drawing.Color.Coral;
            this.buttonkayital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonkayital.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonkayital.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonkayital.Location = new System.Drawing.Point(86, 397);
            this.buttonkayital.Name = "buttonkayital";
            this.buttonkayital.Size = new System.Drawing.Size(100, 37);
            this.buttonkayital.TabIndex = 81;
            this.buttonkayital.Text = "Kayıt Al";
            this.buttonkayital.UseVisualStyleBackColor = false;
            this.buttonkayital.Click += new System.EventHandler(this.kabuttonguncelle_Click);
            // 
            // ksgiris
            // 
            this.ksgiris.Enabled = false;
            this.ksgiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ksgiris.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ksgiris.Location = new System.Drawing.Point(95, 297);
            this.ksgiris.MinDate = new System.DateTime(2018, 6, 6, 0, 0, 0, 0);
            this.ksgiris.Name = "ksgiris";
            this.ksgiris.Size = new System.Drawing.Size(113, 22);
            this.ksgiris.TabIndex = 75;
            // 
            // kscbkat
            // 
            this.kscbkat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kscbkat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kscbkat.FormattingEnabled = true;
            this.kscbkat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.kscbkat.Location = new System.Drawing.Point(95, 264);
            this.kscbkat.Name = "kscbkat";
            this.kscbkat.Size = new System.Drawing.Size(64, 24);
            this.kscbkat.TabIndex = 74;
            // 
            // kscbcinsiyet
            // 
            this.kscbcinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kscbcinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kscbcinsiyet.FormattingEnabled = true;
            this.kscbcinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.kscbcinsiyet.Location = new System.Drawing.Point(95, 202);
            this.kscbcinsiyet.Name = "kscbcinsiyet";
            this.kscbcinsiyet.Size = new System.Drawing.Size(126, 24);
            this.kscbcinsiyet.TabIndex = 73;
            // 
            // kscbodatipi
            // 
            this.kscbodatipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kscbodatipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kscbodatipi.FormattingEnabled = true;
            this.kscbodatipi.Items.AddRange(new object[] {
            "Double",
            "Couple",
            "Single",
            "Triple",
            "Family",
            "King",
            "Couple Deluxe",
            "Family Big",
            "Triple Couple"});
            this.kscbodatipi.Location = new System.Drawing.Point(95, 172);
            this.kscbodatipi.Name = "kscbodatipi";
            this.kscbodatipi.Size = new System.Drawing.Size(126, 24);
            this.kscbodatipi.TabIndex = 73;
            // 
            // kstbgsm
            // 
            this.kstbgsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbgsm.Location = new System.Drawing.Point(95, 113);
            this.kstbgsm.Mask = "(999) 000-0000";
            this.kstbgsm.Name = "kstbgsm";
            this.kstbgsm.PromptChar = ' ';
            this.kstbgsm.Size = new System.Drawing.Size(126, 22);
            this.kstbgsm.TabIndex = 72;
            // 
            // kstboda
            // 
            this.kstboda.Enabled = false;
            this.kstboda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstboda.Location = new System.Drawing.Point(95, 235);
            this.kstboda.MaxLength = 2;
            this.kstboda.Name = "kstboda";
            this.kstboda.ReadOnly = true;
            this.kstboda.Size = new System.Drawing.Size(64, 22);
            this.kstboda.TabIndex = 70;
            this.kstboda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // kstbmail
            // 
            this.kstbmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbmail.Location = new System.Drawing.Point(95, 144);
            this.kstbmail.Name = "kstbmail";
            this.kstbmail.Size = new System.Drawing.Size(216, 22);
            this.kstbmail.TabIndex = 69;
            this.kstbmail.Leave += new System.EventHandler(this.kstbmail_Leave);
            // 
            // kstbtc
            // 
            this.kstbtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbtc.Location = new System.Drawing.Point(95, 26);
            this.kstbtc.MaxLength = 11;
            this.kstbtc.Name = "kstbtc";
            this.kstbtc.Size = new System.Drawing.Size(216, 22);
            this.kstbtc.TabIndex = 68;
            this.kstbtc.Enter += new System.EventHandler(this.kstbtc_Enter);
            this.kstbtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            this.kstbtc.Leave += new System.EventHandler(this.kstbtc_Leave);
            // 
            // kstbsoyadi
            // 
            this.kstbsoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbsoyadi.Location = new System.Drawing.Point(95, 85);
            this.kstbsoyadi.MaxLength = 16;
            this.kstbsoyadi.Name = "kstbsoyadi";
            this.kstbsoyadi.Size = new System.Drawing.Size(194, 22);
            this.kstbsoyadi.TabIndex = 71;
            this.kstbsoyadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceharf);
            this.kstbsoyadi.Leave += new System.EventHandler(this.kstbsoyadi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Cinsiyet:";
            // 
            // kstbadi
            // 
            this.kstbadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kstbadi.Location = new System.Drawing.Point(95, 54);
            this.kstbadi.MaxLength = 16;
            this.kstbadi.Name = "kstbadi";
            this.kstbadi.Size = new System.Drawing.Size(194, 22);
            this.kstbadi.TabIndex = 67;
            this.kstbadi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadeceharf);
            this.kstbadi.Leave += new System.EventHandler(this.kstbadi_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 65;
            this.label11.Text = "Oda Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(54, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 64;
            this.label12.Text = "Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(46, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 63;
            this.label13.Text = "Mail :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(30, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 16);
            this.label15.TabIndex = 62;
            this.label15.Text = "Soyadı:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(10, 302);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 60;
            this.label16.Text = "Giriş Tarihi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(55, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 16);
            this.label17.TabIndex = 59;
            this.label17.Text = "Kat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(32, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 16);
            this.label18.TabIndex = 58;
            this.label18.Text = "T.C No:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(25, 119);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 66;
            this.label19.Text = "Gsm No:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(48, 238);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 16);
            this.label31.TabIndex = 57;
            this.label31.Text = "Oda:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.ksgiris);
            this.groupBox1.Controls.Add(this.kscbkat);
            this.groupBox1.Controls.Add(this.kscbcinsiyet);
            this.groupBox1.Controls.Add(this.kscbodatipi);
            this.groupBox1.Controls.Add(this.kstbgsm);
            this.groupBox1.Controls.Add(this.kstboda);
            this.groupBox1.Controls.Add(this.kstbmail);
            this.groupBox1.Controls.Add(this.kstbtc);
            this.groupBox1.Controls.Add(this.kstbsoyadi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kstbadi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 352);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(625, 433);
            this.dataGridView1.TabIndex = 79;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 457);
            this.Controls.Add(this.buttononayla);
            this.Controls.Add(this.buttonkayital);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1057, 496);
            this.MinimumSize = new System.Drawing.Size(1057, 496);
            this.Name = "Form4";
            this.Text = "Rezervasyon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttononayla;
        private System.Windows.Forms.Button buttonkayital;
        private System.Windows.Forms.DateTimePicker ksgiris;
        private System.Windows.Forms.ComboBox kscbkat;
        private System.Windows.Forms.ComboBox kscbcinsiyet;
        private System.Windows.Forms.ComboBox kscbodatipi;
        private System.Windows.Forms.MaskedTextBox kstbgsm;
        private System.Windows.Forms.TextBox kstboda;
        private System.Windows.Forms.TextBox kstbmail;
        private System.Windows.Forms.TextBox kstbtc;
        private System.Windows.Forms.TextBox kstbsoyadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kstbadi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}