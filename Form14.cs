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
using Microsoft.VisualBasic;

namespace deneme_veritabanı
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbDataReader dr, dr2, dr3, dr4;
        

        private void button1_Click(object sender, EventArgs e)
        {

            /* ----------------- ACCESSTEN KULLANICI GÜVENLİK SORUSUNU ALMAK -----------------*/
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select guvsoruid from users where kullaniciadi='" + tbkuladi.Text + "'";
                dr2 = komut.ExecuteReader();
                dr2.Read();
                int guvsoruid = Convert.ToInt32(dr2["guvsoruid"]);
                baglanti.Close();

                /* ---------------------------------------------------------------------*/
                labelcev.Visible = tbcev.Visible = cbguvsorusu.Visible = labelguvsor.Visible = true;
                button1.Visible = false;
                button2.Enabled = true;
                /* ----------------- COMBOBOXUN İÇİNE VERİLERİ ACCESSTEN ÇEKMEK -----------------*/
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select Soru from guvsorular where Kimlik=@soruidsi";
                komut.Parameters.AddWithValue("@soruidsi", guvsoruid);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cbguvsorusu.Items.Add(dr["Soru"]);
                }
                cbguvsorusu.SelectedIndex = 0;
                baglanti.Close();
                /* ----------------------------------------------------------------------------*/
            }
            catch
            {
                MessageBox.Show("Kullanıcı Adı Hatalı");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* -------------------------ACCESSTEN KULLANICI CEVABINI ÇEKME----------------------------*/
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "select guvcevabi from users where kullaniciadi='" + tbkuladi.Text + "'";
            dr3 = komut2.ExecuteReader();
            dr3.Read();
            string guvsorucevabi = dr3["guvcevabi"].ToString();
            baglanti.Close();

            /* ----------------------------------------------------------------------------*/

            if (tbcev.Text == guvsorucevabi)
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut3.Connection = baglanti;
                komut3.CommandText = "select sifre from users where kullaniciadi='" + tbkuladi.Text + "'";
                dr4 = komut3.ExecuteReader();
                dr4.Read();
                string kullanicisifre = dr4["sifre"].ToString();
                baglanti.Close();
                Interaction.InputBox("Şifreniz:","Şifre Hatırlatma",kullanicisifre);
            }
            else MessageBox.Show("Cevabınız Yanlış");
        }
        
        private void Form14_Load(object sender, EventArgs e)
        {
        }

    }
}
