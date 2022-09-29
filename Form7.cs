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
    public partial class Form7 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand saydirmakomutu = new OleDbCommand();
        OleDbDataReader dr;
        OleDbDataReader dr2;
        OleDbCommand komut8 = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        public static class tiklanan
        {
            public static string adi;                                           //global bir değişken tanımlayarak formlar arası veri aktarma olayı
        }
        public Form7()
        {
            InitializeComponent();
        }
        private void butontiklamasi(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            tiklanan.adi=((Button)sender).Text;
            Form15 f15 = new Form15();
            f15.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select herkattakacodavar from oteldizayn where id=1";
            dr = komut.ExecuteReader();
            dr.Read();
            int kattakiodasayisi = Convert.ToInt32(dr["herkattakacodavar"].ToString());
              baglanti.Close();
              komut.Dispose();



            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            saydirmakomutu.Connection = baglanti;
            saydirmakomutu.CommandText = "select count (*) from odalar";
            int odasayisi = Convert.ToInt32(saydirmakomutu.ExecuteScalar());
            saydirmakomutu.Dispose();
            baglanti.Close();
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            saydirmakomutu.Connection = baglanti;
            saydirmakomutu.CommandText = "select count (*) from katlar";               
            int katsayisi = Convert.ToInt32(saydirmakomutu.ExecuteScalar());
            baglanti.Close();


            for (int i = 1; i < katsayisi+1; i++)
            {
                Label lb = new Label();
                lb.Name = "labelkat" + i.ToString(); 
                lb.AutoSize = false;
                lb.Size = new Size(62, 17);
                lb.BackColor = Color.Transparent;
                lb.ForeColor = Color.White;
                lb.Font = new Font("Microsoft Sans Serif", 10,FontStyle.Bold);
                lb.Location = new Point(2, 69+50*(i-1)); 
                lb.Text = "Kat "+i.ToString()+":";
                this.Controls.Add(lb); 

            }



            

            if (baglanti.State==ConnectionState.Closed)
                baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select count(*) from odalar where odadurumu=@durumparametre";                      //SAYDIRMA SQL CÜMLESİ
            komut.Parameters.AddWithValue("@durumparametre", "Dolu");
            int doluoda = Convert.ToInt32(komut.ExecuteScalar());                                                 //SAYDIRDIĞINI AKTARMA KOMUTU
            double bosoda = odasayisi - doluoda;
            double dolulukyüzdesi = doluoda*100 / (doluoda + bosoda);
            double boslukyüzdesi= bosoda*100 / (doluoda+bosoda);
            progressBar1.Maximum = Convert.ToInt32(doluoda + bosoda);                                               //progressbarve labellara veritabanı kontrolü
            progressBar1.Value = doluoda;
            label5.Text = "%" + Math.Round(dolulukyüzdesi,2);
            label6.Text = "%" + Math.Round(boslukyüzdesi,2);
            baglanti.Close();

            int x = 65, y = 60;
            for (int i = 1; i <= odasayisi; i++)                                                                            // ÇOKLU BUTON KOYMA DİNAMİK BUTON EKLEME KISMI
            {
                
                if (i %kattakiodasayisi == 1 && i > kattakiodasayisi)
                    {
                        x = 65;
                        y = y + 50;
                    }
                Button btn = new Button();
                btn.Location = new System.Drawing.Point(x,y);
                x = x + 75;
                btn.Name ="button"+i.ToString();
                btn.Size = new System.Drawing.Size(55,35);
                btn.Text = i.ToString();
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut2.Connection = baglanti;
                komut2.CommandText = "select  odadurumu from odalar where odanum like'" + i.ToString() + "%'";                                //oda dolu mu
                dr2 = komut2.ExecuteReader();
                dr2.Read();
                if (dr2[0].ToString()=="Boş")
                { btn.BackColor = SystemColors.Control;
                komut2.Dispose();
                baglanti.Close();
                }
                else if (dr2[0].ToString() == "Dolu")
                { btn.BackColor = Color.LightSeaGreen;
                komut2.Dispose();
                baglanti.Close();
                }
                
                btn.Click += new EventHandler(butontiklamasi);                                          //tüm butonlara for döngüsüyle aynı olayı tanımlıyoruz
                this.Controls.Add(btn);
            }

        }
    }
}
