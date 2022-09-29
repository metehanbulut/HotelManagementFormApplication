namespace deneme_veritabanı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttoncikis = new System.Windows.Forms.Button();
            this.buttongiris = new System.Windows.Forms.Button();
            this.tbsifre = new System.Windows.Forms.TextBox();
            this.tbkullanici = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncikis
            // 
            this.buttoncikis.BackColor = System.Drawing.Color.SaddleBrown;
            resources.ApplyResources(this.buttoncikis, "buttoncikis");
            this.buttoncikis.ForeColor = System.Drawing.Color.Black;
            this.buttoncikis.Name = "buttoncikis";
            this.buttoncikis.UseVisualStyleBackColor = false;
            this.buttoncikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttongiris
            // 
            this.buttongiris.BackColor = System.Drawing.Color.SaddleBrown;
            resources.ApplyResources(this.buttongiris, "buttongiris");
            this.buttongiris.ForeColor = System.Drawing.Color.Black;
            this.buttongiris.Name = "buttongiris";
            this.buttongiris.UseVisualStyleBackColor = false;
            this.buttongiris.Click += new System.EventHandler(this.buttongiris_Click);
            // 
            // tbsifre
            // 
            this.tbsifre.BackColor = System.Drawing.Color.SaddleBrown;
            resources.ApplyResources(this.tbsifre, "tbsifre");
            this.tbsifre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbsifre.Name = "tbsifre";
            this.tbsifre.Enter += new System.EventHandler(this.tbsifre_Enter);
            this.tbsifre.Leave += new System.EventHandler(this.tbsifre_Leave);
            // 
            // tbkullanici
            // 
            this.tbkullanici.BackColor = System.Drawing.Color.SaddleBrown;
            resources.ApplyResources(this.tbkullanici, "tbkullanici");
            this.tbkullanici.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbkullanici.Name = "tbkullanici";
            this.tbkullanici.Enter += new System.EventHandler(this.tbkullanici_Enter);
            this.tbkullanici.Leave += new System.EventHandler(this.tbkullanici_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.LinkColor = System.Drawing.Color.Plum;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::deneme_veritabanı.Properties.Resources.arkaplan;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbkullanici);
            this.Controls.Add(this.tbsifre);
            this.Controls.Add(this.buttongiris);
            this.Controls.Add(this.buttoncikis);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoncikis;
        private System.Windows.Forms.Button buttongiris;
        private System.Windows.Forms.TextBox tbsifre;
        private System.Windows.Forms.TextBox tbkullanici;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

