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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
         + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand saydırmakomutu   = new OleDbCommand();
        OleDbCommand saydırmakomutu1   = new OleDbCommand();
        OleDbDataReader dr, dr2;
        




        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void buttonmusteriler_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void buttonrezervasyon_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog(); 
        }

        private void buttonhesap_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void buttonodalar_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void detaylarıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[0].Visible = false;
            contextMenuStrip1.Items[1].Visible = true;
            pictureBox1.Visible=buttoneskimusteriler.Visible = label1.Visible = label2.Visible = labelbosoda.Visible = labelmusteri.Visible = buttonotelkontrol.Visible = personelad.Visible = labeltelno.Visible=label4.Visible =gbkullanicibilgisi.Visible= true;
        }
        
        private void detaylarıKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[1].Visible = false;
            contextMenuStrip1.Items[0].Visible = true;
            pictureBox1.Visible =buttoneskimusteriler.Visible= label1.Visible = label2.Visible = labelbosoda.Visible = labelmusteri.Visible = buttonotelkontrol.Visible = personelad.Visible = labeltelno.Visible = label4.Visible = gbkullanicibilgisi.Visible= false;
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void oturumuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f1 = new Form1();
            f1.Show();
        }

        private void tamamenÇıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            saydırmakomutu1.Connection = baglanti;
            saydırmakomutu1.CommandText = "select count (*) from musteribilgiler";
            labelmusteri.Text = saydırmakomutu1.ExecuteScalar().ToString();
            baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            saydırmakomutu.Connection = baglanti;
            saydırmakomutu.CommandText = "select count (*) from odalar where odadurumu=@odadurumusayisi";
            saydırmakomutu.Parameters.AddWithValue("@odadurumusayisi", "Boş");
            labelbosoda.Text = saydırmakomutu.ExecuteScalar().ToString();
            baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select oteltelefon from oteltelefontablo where Kimlik="+1;                                    //telefonnumarasi
                dr2 = komut.ExecuteReader();
                dr2.Read();
                labeltelno.Text=dr2["oteltelefon"].ToString();
                baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "select Ad,Soyad from users where kullaniciadi='"+Form1.kullanici.adi+"'";
            dr = komut.ExecuteReader();
            dr.Read();
            personelad.Text = "" + dr["Ad"].ToString()+"  "+ dr["Soyad"].ToString()+"";                      //PERSONEL BİLGİ KISMINDAKİ LABELIN İÇİNE USERADI KOYMA
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                contextMenuStrip2.Items[0].Text = "Gizle";
            }
            else
            {
                contextMenuStrip2.Items[0].Text = "Göster";
                this.Hide();
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void kayıtSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void Form2_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
            notifyIcon1.ShowBalloonTip(1);

        }

        private void buttonrapor_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }

        private void buttoneskimusteriler_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.ShowDialog();
        }
        
    }
}
