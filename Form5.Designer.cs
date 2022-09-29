namespace deneme_veritabanı
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonhesapcikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hesapkesimoda = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labeltoplamucret = new System.Windows.Forms.Label();
            this.labelminibarucret = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelodaucret = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelesktraucret = new System.Windows.Forms.Label();
            this.labelodatipi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelodanum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonhesabigoster = new System.Windows.Forms.Button();
            this.buttontamamla = new System.Windows.Forms.Button();
            this.ekstraucret = new System.Windows.Forms.TextBox();
            this.minibarucret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 370);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // buttonhesapcikis
            // 
            this.buttonhesapcikis.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonhesapcikis.Enabled = false;
            this.buttonhesapcikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhesapcikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.buttonhesapcikis.ForeColor = System.Drawing.Color.Black;
            this.buttonhesapcikis.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonhesapcikis.Location = new System.Drawing.Point(615, 231);
            this.buttonhesapcikis.Name = "buttonhesapcikis";
            this.buttonhesapcikis.Size = new System.Drawing.Size(114, 51);
            this.buttonhesapcikis.TabIndex = 2;
            this.buttonhesapcikis.Text = "Çıkışı Gerçekleştir";
            this.buttonhesapcikis.UseVisualStyleBackColor = false;
            this.buttonhesapcikis.Visible = false;
            this.buttonhesapcikis.Click += new System.EventHandler(this.buttonhesapcikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Oda :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(183, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seç";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.hesapkesimoda);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(643, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // hesapkesimoda
            // 
            this.hesapkesimoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hesapkesimoda.Location = new System.Drawing.Point(82, 19);
            this.hesapkesimoda.MaxLength = 2;
            this.hesapkesimoda.Name = "hesapkesimoda";
            this.hesapkesimoda.Size = new System.Drawing.Size(76, 45);
            this.hesapkesimoda.TabIndex = 71;
            this.hesapkesimoda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.labeltoplamucret);
            this.groupBox2.Controls.Add(this.labelminibarucret);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelodaucret);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.labelesktraucret);
            this.groupBox2.Controls.Add(this.labelodatipi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.labelodanum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(764, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 233);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // labeltoplamucret
            // 
            this.labeltoplamucret.AutoSize = true;
            this.labeltoplamucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltoplamucret.Location = new System.Drawing.Point(80, 195);
            this.labeltoplamucret.Name = "labeltoplamucret";
            this.labeltoplamucret.Size = new System.Drawing.Size(25, 22);
            this.labeltoplamucret.TabIndex = 2;
            this.labeltoplamucret.Text = "...";
            // 
            // labelminibarucret
            // 
            this.labelminibarucret.AutoSize = true;
            this.labelminibarucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelminibarucret.Location = new System.Drawing.Point(107, 160);
            this.labelminibarucret.Name = "labelminibarucret";
            this.labelminibarucret.Size = new System.Drawing.Size(20, 17);
            this.labelminibarucret.TabIndex = 2;
            this.labelminibarucret.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(6, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 22);
            this.label15.TabIndex = 3;
            this.label15.Text = "Hesap:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(6, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Minibar Ücreti";
            // 
            // labelodaucret
            // 
            this.labelodaucret.AutoSize = true;
            this.labelodaucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelodaucret.Location = new System.Drawing.Point(81, 124);
            this.labelodaucret.Name = "labelodaucret";
            this.labelodaucret.Size = new System.Drawing.Size(20, 17);
            this.labelodaucret.TabIndex = 1;
            this.labelodaucret.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Oda Ücreti";
            // 
            // labelesktraucret
            // 
            this.labelesktraucret.AutoSize = true;
            this.labelesktraucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelesktraucret.Location = new System.Drawing.Point(81, 90);
            this.labelesktraucret.Name = "labelesktraucret";
            this.labelesktraucret.Size = new System.Drawing.Size(20, 17);
            this.labelesktraucret.TabIndex = 1;
            this.labelesktraucret.Text = "...";
            // 
            // labelodatipi
            // 
            this.labelodatipi.AutoSize = true;
            this.labelodatipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelodatipi.Location = new System.Drawing.Point(81, 56);
            this.labelodatipi.Name = "labelodatipi";
            this.labelodatipi.Size = new System.Drawing.Size(20, 17);
            this.labelodatipi.TabIndex = 1;
            this.labelodatipi.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ekstralar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Oda Tipi:";
            // 
            // labelodanum
            // 
            this.labelodanum.AutoSize = true;
            this.labelodanum.Font = new System.Drawing.Font("Trajan Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelodanum.Location = new System.Drawing.Point(111, 16);
            this.labelodanum.Name = "labelodanum";
            this.labelodanum.Size = new System.Drawing.Size(30, 28);
            this.labelodanum.TabIndex = 0;
            this.labelodanum.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trajan Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "ODA ";
            // 
            // buttonhesabigoster
            // 
            this.buttonhesabigoster.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonhesabigoster.Enabled = false;
            this.buttonhesabigoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhesabigoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.buttonhesabigoster.ForeColor = System.Drawing.Color.Black;
            this.buttonhesabigoster.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonhesabigoster.Location = new System.Drawing.Point(615, 288);
            this.buttonhesabigoster.Name = "buttonhesabigoster";
            this.buttonhesabigoster.Size = new System.Drawing.Size(114, 51);
            this.buttonhesabigoster.TabIndex = 2;
            this.buttonhesabigoster.Text = "Hesabı Göster";
            this.buttonhesabigoster.UseVisualStyleBackColor = false;
            this.buttonhesabigoster.Visible = false;
            this.buttonhesabigoster.Click += new System.EventHandler(this.buttonhesabigoster_Click);
            // 
            // buttontamamla
            // 
            this.buttontamamla.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttontamamla.Enabled = false;
            this.buttontamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttontamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttontamamla.ForeColor = System.Drawing.Color.Black;
            this.buttontamamla.Location = new System.Drawing.Point(615, 345);
            this.buttontamamla.Name = "buttontamamla";
            this.buttontamamla.Size = new System.Drawing.Size(114, 37);
            this.buttontamamla.TabIndex = 8;
            this.buttontamamla.Text = "Tamamla";
            this.buttontamamla.UseVisualStyleBackColor = false;
            this.buttontamamla.Click += new System.EventHandler(this.buttontamamla_Click);
            // 
            // ekstraucret
            // 
            this.ekstraucret.Location = new System.Drawing.Point(78, 17);
            this.ekstraucret.Name = "ekstraucret";
            this.ekstraucret.Size = new System.Drawing.Size(73, 20);
            this.ekstraucret.TabIndex = 9;
            this.ekstraucret.TextChanged += new System.EventHandler(this.ekstraucret_TextChanged);
            this.ekstraucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // minibarucret
            // 
            this.minibarucret.Enabled = false;
            this.minibarucret.Location = new System.Drawing.Point(78, 44);
            this.minibarucret.Name = "minibarucret";
            this.minibarucret.Size = new System.Drawing.Size(73, 20);
            this.minibarucret.TabIndex = 9;
            this.minibarucret.TextChanged += new System.EventHandler(this.minibarucret_TextChanged);
            this.minibarucret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sadecesayi);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ekstra ucret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Minibar Fiyat:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ekstraucret);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.minibarucret);
            this.groupBox3.Location = new System.Drawing.Point(603, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 77);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.arkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 394);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttontamamla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonhesabigoster);
            this.Controls.Add(this.buttonhesapcikis);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(967, 433);
            this.MinimumSize = new System.Drawing.Size(967, 433);
            this.Name = "Form5";
            this.Text = "HesapKesim";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonhesapcikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelodanum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelodaucret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelesktraucret;
        private System.Windows.Forms.Label labelodatipi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labeltoplamucret;
        private System.Windows.Forms.Label labelminibarucret;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buttonhesabigoster;
        private System.Windows.Forms.TextBox hesapkesimoda;
        private System.Windows.Forms.Button buttontamamla;
        private System.Windows.Forms.TextBox ekstraucret;
        private System.Windows.Forms.TextBox minibarucret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}