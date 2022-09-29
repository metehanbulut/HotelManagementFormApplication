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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader dr; 
        private void Form9_Load(object sender, EventArgs e)
        {
            if (baglanti.State==ConnectionState.Closed) 
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select * from guvsorular";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbguvsoru.Items.Add(dr["Soru"]);
            }
            baglanti.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbsifretekrar.Clear();
            tbad.Text = tbsoyad.Text = tbkad.Text = tbsifre.Text = tbcevap.Text = tbkadtekrar.Text = tbsifretekrar.Text;
        }

        private void button1_Click(object sender, EventArgs e)                          //KULLANICI EKLE
        {
            DialogResult cevap = MessageBox.Show("Yeni Kullanıcıyı Onaylıyor Musunuz", "İkaz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut.CommandText = "insert into users (kullaniciadi,sifre,Ad,Soyad,guvcevabi,guvsoruid) Values('" + tbkad.Text + "','" + tbsifre.Text + "','" + tbad.Text + "','" + tbsoyad.Text + "','" + tbcevap.Text + "','" + (cbguvsoru.SelectedIndex+1)+ "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                baglanti.Close();
            }
            else { MessageBox.Show("Kayıt İptal Edildi", "İşlem Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Warning); }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)     // NUMARA GİRİŞİ ENGELLEMEK
                        && !char.IsSeparator(e.KeyChar);
        }
    }
}
