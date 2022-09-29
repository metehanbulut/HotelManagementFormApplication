using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace deneme_veritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class kullanici
        {
            public static string adi;
            public static string sifre;
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader dr;


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttongiris_Click(object sender, EventArgs e)
        {
            kullanici.sifre = tbsifre.Text;
            kullanici.adi = tbkullanici.Text;
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM users where kullaniciadi='" +tbkullanici.Text+ "' AND sifre='" + tbsifre.Text + "'";
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.Show();
            }
            else
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış","Hata",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            baglanti.Close();
        }

        private void tbkullanici_Enter(object sender, EventArgs e)
        {
            tbkullanici.Clear();
            tbkullanici.ForeColor = Color.Black;
        }

        private void tbsifre_Enter(object sender, EventArgs e)
        {
            tbsifre.Clear();
            tbsifre.ForeColor = Color.Black;
        }

        private void tbkullanici_Leave(object sender, EventArgs e)
        {
            if (tbkullanici.Text == "")
            {
                tbkullanici.Text = "Kullanıcı Adı:";
                tbkullanici.ForeColor = SystemColors.ButtonShadow;

            }
        }

        private void tbsifre_Leave(object sender, EventArgs e)
        {
            if (tbsifre.Text == "")
            {
                tbsifre.Text = "Şifre:";
                tbsifre.ForeColor = SystemColors.ButtonShadow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 f14 = new Form14();
            f14.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
