namespace deneme_veritabanı
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.labelkulad = new System.Windows.Forms.Label();
            this.tbkuladi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelguvsor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tbcev = new System.Windows.Forms.TextBox();
            this.labelcev = new System.Windows.Forms.Label();
            this.cbguvsorusu = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelkulad
            // 
            this.labelkulad.AutoSize = true;
            this.labelkulad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkulad.Location = new System.Drawing.Point(6, 19);
            this.labelkulad.Name = "labelkulad";
            this.labelkulad.Size = new System.Drawing.Size(77, 15);
            this.labelkulad.TabIndex = 4;
            this.labelkulad.Text = "Kullanıcı Adı:";
            // 
            // tbkuladi
            // 
            this.tbkuladi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbkuladi.Location = new System.Drawing.Point(89, 12);
            this.tbkuladi.MaxLength = 16;
            this.tbkuladi.Name = "tbkuladi";
            this.tbkuladi.Size = new System.Drawing.Size(239, 24);
            this.tbkuladi.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "İleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelguvsor
            // 
            this.labelguvsor.AutoSize = true;
            this.labelguvsor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelguvsor.Location = new System.Drawing.Point(6, 49);
            this.labelguvsor.Name = "labelguvsor";
            this.labelguvsor.Size = new System.Drawing.Size(99, 15);
            this.labelguvsor.TabIndex = 6;
            this.labelguvsor.Text = "Güvenlik Sorusu:";
            this.labelguvsor.Visible = false;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(197, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Hatırlat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbcev
            // 
            this.tbcev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbcev.Location = new System.Drawing.Point(119, 74);
            this.tbcev.Name = "tbcev";
            this.tbcev.Size = new System.Drawing.Size(209, 24);
            this.tbcev.TabIndex = 3;
            this.tbcev.Visible = false;
            // 
            // labelcev
            // 
            this.labelcev.AutoSize = true;
            this.labelcev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelcev.Location = new System.Drawing.Point(69, 81);
            this.labelcev.Name = "labelcev";
            this.labelcev.Size = new System.Drawing.Size(44, 15);
            this.labelcev.TabIndex = 6;
            this.labelcev.Text = "Cevap:";
            this.labelcev.Visible = false;
            // 
            // cbguvsorusu
            // 
            this.cbguvsorusu.Enabled = false;
            this.cbguvsorusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbguvsorusu.FormattingEnabled = true;
            this.cbguvsorusu.Location = new System.Drawing.Point(111, 42);
            this.cbguvsorusu.Name = "cbguvsorusu";
            this.cbguvsorusu.Size = new System.Drawing.Size(217, 26);
            this.cbguvsorusu.TabIndex = 7;
            this.cbguvsorusu.Visible = false;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(346, 168);
            this.Controls.Add(this.cbguvsorusu);
            this.Controls.Add(this.labelcev);
            this.Controls.Add(this.labelguvsor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelkulad);
            this.Controls.Add(this.tbcev);
            this.Controls.Add(this.tbkuladi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(362, 207);
            this.MinimumSize = new System.Drawing.Size(362, 207);
            this.Name = "Form14";
            this.Text = "Parola Sıfırlama";
            this.Load += new System.EventHandler(this.Form14_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelkulad;
        private System.Windows.Forms.TextBox tbkuladi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelguvsor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbcev;
        private System.Windows.Forms.Label labelcev;
        private System.Windows.Forms.ComboBox cbguvsorusu;

    }
}