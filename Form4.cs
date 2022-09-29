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
    public partial class Form4 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut9 = new OleDbCommand();
        OleDbCommand komut5 = new OleDbCommand();
        OleDbDataReader dr2;
        DataSet ds = new DataSet();
        DataTable tablo = new DataTable();
        private void verileridatadancek()
        {
            ds.Clear();
            //string accesssecme = "select* from odalar where odadurumu like'"+"Boş%'";
            string accesssecme = "select odanum,odafiyat,yataksayisi,odaturu,odadurumu,katnum from odalar where odadurumu like'" + "Boş%'";
            OleDbDataAdapter da = new OleDbDataAdapter(accesssecme, baglanti);
            da.Fill(ds, "odalar");
        }
        private void sadecesayi(object sender, KeyPressEventArgs e)                             //SADECE SAYI GİRİŞİ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void sadeceharf(object sender, KeyPressEventArgs e)                        // SADECE HARF GİRİŞİ
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                        && !char.IsSeparator(e.KeyChar);
        }
        public Form4()
        {
            InitializeComponent();
        }
        public static int kisisayisistatik;
        public static int yataksayisiistatistik;

        private void Form4_Load(object sender, EventArgs e)
        {
            kisisayisistatik = 0;
            yataksayisiistatistik = 0;
            kscbcinsiyet.SelectedIndex = 0;
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["odalar"];

        }
        private void kontrol(TextBox kutu)
        {
            if (kutu.TextLength == 0)
            {
                MessageBox.Show("Bu Alan boş Geçilemez");
                kutu.Focus();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try                               // PROGRAM KAYNAKLI SORUN ÇÖZMEK İÇİN TRY CATCH
            {
                kstboda.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                kscbkat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                kscbodatipi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
        }
        private void kabuttonguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int kackisilik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                int gelenkisi = Convert.ToInt32(Interaction.InputBox("Kişi Sayısı", "Soru"));
                kisisayisistatik = gelenkisi;
                yataksayisiistatistik = kackisilik;
            }
            catch (FormatException) { MessageBox.Show("Girilen Veri Hatalı"); }

            if (kisisayisistatik > 0 && kisisayisistatik <= yataksayisiistatistik)
            {
                dataGridView1.Enabled = false;
                groupBox1.Enabled = true;
                buttononayla.Enabled = true;
                kscbkat.Enabled = false;
                kscbodatipi.Enabled = false;
                kstboda.Enabled = false;
                buttonkayital.Enabled = false;
                DialogResult cevap = MessageBox.Show("Kayıt Başlasın mı ?", "Onay Kutusu", MessageBoxButtons.OKCancel);
                if (cevap == DialogResult.OK)
                {
                    kstbtc.Focus();
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                    this.Close();
                }
            }
            else if (kisisayisistatik == 0 || kisisayisistatik < 0 || kisisayisistatik > yataksayisiistatistik) MessageBox.Show("Kişi Sayısı Hatalı");

        }

        private void buttononayla_Click(object sender, EventArgs e)
        {

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "select musteritc from musteribilgiler where musteritc like'" + kstbtc.Text + "%'";                                    // ESKİ MÜŞTERİ Mİ?
            dr2 = komut.ExecuteReader();
            dr2.Read();
            if (dr2.HasRows == true)
            {
                MessageBox.Show("Zaten Böyle Bir Müşteri Otelde Var!");
                komut.Dispose();
                baglanti.Close();
                this.Close();
            }
            else if (dr2.HasRows!=true)
            {
            komut.Dispose();
            baglanti.Close();
            MessageBox.Show(kisisayisistatik.ToString() + ". Kişi Kaydedildi");
            kisisayisistatik = kisisayisistatik - 1;
            {
                buttononayla.Text = "Onayla " + "/" + kisisayisistatik.ToString();
                //  YENİ MÜŞTERİ ALIMI 
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                    
                  
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "insert into musteribilgiler (musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,odanum,giristarihi) Values(@musteritc,@musteriad,@musterisoyad,@mustericinsiyet,@musterigsm,@musterimail,@odanum,@giristarihi)";
                        komut.Parameters.AddWithValue("@musteritc", kstbtc.Text);
                        komut.Parameters.AddWithValue("@musteriad", kstbadi.Text);
                        komut.Parameters.AddWithValue("@musterisoyad", kstbsoyadi.Text);
                        komut.Parameters.AddWithValue("@mustericinsiyet", kscbcinsiyet.Text);
                        komut.Parameters.AddWithValue("@musterigsm", kstbgsm.Text);
                        komut.Parameters.AddWithValue("@musterimail", kstbmail.Text);
                        komut.Parameters.AddWithValue("@odanum", kstboda.Text);
                        komut.Parameters.AddWithValue("@giristarihi",DateTime.Today);
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        baglanti.Close();
                                                                        // ESKİ MÜŞTERİLERE KAYIT
                        if (baglanti.State == ConnectionState.Closed)
                            baglanti.Open();
                        komut.Connection = baglanti;
                        komut.CommandText = "insert into eskimusteriler (musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,odanum,giristarihi) Values(@musteritc,@musteriad,@musterisoyad,@mustericinsiyet,@musterigsm,@musterimail,@odanum,@giristarihi)";
                        komut.Parameters.AddWithValue("@musteritc", kstbtc.Text);
                        komut.Parameters.AddWithValue("@musteriad", kstbadi.Text);
                        komut.Parameters.AddWithValue("@musterisoyad", kstbsoyadi.Text);
                        komut.Parameters.AddWithValue("@mustericinsiyet", kscbcinsiyet.Text);
                        komut.Parameters.AddWithValue("@musterigsm", kstbgsm.Text);
                        komut.Parameters.AddWithValue("@musterimail", kstbmail.Text);
                        komut.Parameters.AddWithValue("@odanum", kstboda.Text);
                        komut.Parameters.AddWithValue("@giristarihi", DateTime.Today);
                        komut.ExecuteNonQuery();
                        komut.Dispose();
                        baglanti.Close();



                        kstbadi.Text = "";
                        kstbsoyadi.Text = "";
                        kstbtc.Text = "";
                        kstbgsm.Text = "";
                        kstbmail.Text = "";
                if (kisisayisistatik == 0)
                {
                    buttononayla.Text = "Onayla";
                    buttononayla.Enabled = false; dataGridView1.Enabled = true;
                    //                                       ODA DURUMU SIFIRLAMA 
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    komut3.Connection = baglanti;
                    komut3.CommandText = "update odalar set odadurumu=@durum where odanum=@odanum";
                    komut3.Parameters.AddWithValue("@durum", "Dolu");
                    komut3.Parameters.AddWithValue("@odanum", kstboda.Text);
                    komut3.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem Sonlandırıldı");
                    this.Close();
                }
            }
            }

        }

        private void kstbtc_Leave(object sender, EventArgs e)
        {
            if (kstbtc.TextLength != 11)
            {
                MessageBox.Show("Tc Eksik");
                kstbtc.Focus();
            }
            kontrol(kstbtc);
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut5.Connection = baglanti;
            komut5.CommandText = "select musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail from eskimusteriler where musteritc=@musteritc ";                                    // ESKİ MÜŞTERİ Mİ?
            komut5.Parameters.AddWithValue("@musteritc", kstbtc.Text);
            dr2 = komut5.ExecuteReader();
            dr2.Read();
            if (dr2.HasRows == true)
            {
                string tckontrol = dr2["musteritc"].ToString();
                MessageBox.Show("Hoş Geldiniz " + dr2["musteriad"].ToString() + "   " + dr2["musterisoyad"].ToString());
                kstbadi.Text = dr2["musteriad"].ToString();
                kstbsoyadi.Text = dr2["musterisoyad"].ToString();
                kstbgsm.Text = dr2["musterigsm"].ToString();
                kstbmail.Text = dr2["musterimail"].ToString();
                kscbcinsiyet.Text = dr2["mustericinsiyet"].ToString();

                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut9.Connection = baglanti;
                komut9.CommandText = "delete *from eskimusteriler where musteritc=@musteritc";
                komut9.Parameters.AddWithValue("@musteritc", kstbtc.Text);
                komut9.ExecuteNonQuery();
                baglanti.Close();
                komut9.Dispose();


            }
            dr2.Dispose();
            baglanti.Close();
            
        }

        private void kstbadi_Leave(object sender, EventArgs e)
        {
            kontrol(kstbadi);
        }

        private void kstbtc_TextChanged(object sender, EventArgs e)
        {
            kontrol(kstbtc);
        }


        private void kstbsoyadi_Leave(object sender, EventArgs e)
        {
            kontrol(kstbsoyadi);
        }


        private void kstbmail_Leave(object sender, EventArgs e)
        {
            kontrol(kstbadi);

        }

        private void kstbtc_Enter(object sender, EventArgs e)
        {
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
