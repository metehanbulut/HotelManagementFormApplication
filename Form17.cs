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
    
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        private void sadecesayi(object sender, KeyPressEventArgs e)                             //SADECE SAYI GİRİŞİ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();


        private void Form17_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
          DialogResult cevap=  MessageBox.Show("                         DİKKAT !! \n   Varolan Tüm veriler Kaybolacaktır !\n         İşlemi Onaylıyor Musunuz ?","UYARI!!!",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
          if (cevap == DialogResult.OK)
          {

              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "Update oteldizayn Set herkattakacodavar=@herkattakacodavar Where id=@id";
              komut.Parameters.AddWithValue("@herkattakacodavar",numericUpDown2.Value);
              komut.Parameters.AddWithValue("@id", 1);
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();


              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "delete * from katlar";
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();
              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "delete * from eskimusteriler";
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();
              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "delete * from musteribilgiler";
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();

              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "delete * from odalar";
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();

              if (baglanti.State == ConnectionState.Closed)
                  baglanti.Open();
              komut.Connection = baglanti;
              komut.CommandText = "delete * from odahesabi";
              komut.ExecuteNonQuery();
              baglanti.Close();
              komut.Dispose();
  //_____________________________EKLEYİCİLER_________________________________________________________________//
              int k = 1;
              for (int i = 1; i <= numericUpDown1.Value; i++)
              {
                  if (baglanti.State == ConnectionState.Closed)
                      baglanti.Open();
                  komut.Connection = baglanti;
                  komut.CommandText = "insert into katlar(katnum) Values ('" + i.ToString() +"')";
                  komut.ExecuteNonQuery();
                  baglanti.Close();
                  komut.Dispose();
                  for (int j = 1; j <= numericUpDown2.Value; j++)
                  {
                      if (baglanti.State == ConnectionState.Closed)
                          baglanti.Open();
                      komut.Connection = baglanti;
                      komut.CommandText = "insert into odahesabi(odanum,toplamhesap,minibarucreti,aktifodaucreti,ekstraucreti) Values ('" + k + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "')";
                      komut.ExecuteNonQuery();
                      komut.Dispose();
                      baglanti.Close();

                      if (baglanti.State == ConnectionState.Closed)
                          baglanti.Open();
                      komut.Connection = baglanti;
                      komut.CommandText = "insert into odalar(odanum,odafiyat,yataksayisi,odaturu,odadurumu,katnum) Values ('" + k + "','" + 100 + "','" + 1 + "','" + "Single" + "','" + "Boş" + "','" + i.ToString() + "')";
                      komut.ExecuteNonQuery();
                      komut.Dispose();
                      baglanti.Close();
                      k++;
                  }
              }

          }
        }
    }
}
