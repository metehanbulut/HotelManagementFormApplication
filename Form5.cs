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
    public partial class Form5 : Form
    {    
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
           + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut2 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut4 = new OleDbCommand();
        OleDbCommand komut5 = new OleDbCommand();
        OleDbCommand komut6 = new OleDbCommand();
        OleDbCommand komut7 = new OleDbCommand();
        OleDbCommand komut8 = new OleDbCommand();
        OleDbCommand komut9 = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void sadecesayi(object sender, KeyPressEventArgs e)                             //SADECE SAYI GİRİŞİ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        /*SELECT alanlar
FROM tablo1 INNER JOIN
(tablo2 INNER JOIN [( ]tablo3
[INNER JOIN [( ]tablox [INNER JOIN ...)] 
ON tablo3.alan3karşılaştırmatablox.alanx)]      Select musteritc,odanum,giristarihi,minibarucr,toplamhesap,ekstraucret from (odahesabi inner join minibar on odahesabi.minibarhesapid=minibar.minibarhesapid)inner join ekstralar on odahesabi.ekstrahesapid=ekstralar.ekstrahesapid  ORDER BY musteritc";
ON tablo2.alan2karşılaştırmatablo3.alan3) 
ON tablo1.alan1karşılaştırmatablo2.alan2;
         */
        
        private void verileridatadancek()
        {
            ds.Clear();
            komut.CommandText = "Select odahesabi.odanum,odaturu,musteriad,musterisoyad,giristarihi,cikistarihi,odafiyat,aktifodaucreti,minibarucreti,ekstraucreti,toplamhesap,musteritc from (odahesabi inner join musteribilgiler on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum ORDER BY odahesabi.odanum";
            da.SelectCommand = komut;
            komut.Connection = baglanti;
            da.Fill(ds,"odahesabi");

        }
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["odahesabi"];
            baglanti.Close();

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (hesapkesimoda.Text != "")
            {
                DialogResult cevap = MessageBox.Show("Oda Numarası : " + hesapkesimoda.Text + "  ?", "Onay Kutusu", MessageBoxButtons.OKCancel);
                if (cevap == DialogResult.OK)
                {

                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    OleDbDataAdapter adtr = new OleDbDataAdapter("Select odahesabi.odanum,odaturu,musteriad,musterisoyad,giristarihi,cikistarihi,odafiyat,aktifodaucreti,minibarucreti,ekstraucreti,toplamhesap,musteritc from (odahesabi inner join musteribilgiler on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum where odahesabi.odanum like'" + hesapkesimoda.Text + "%'", baglanti);
                    ds = new DataSet();
                    adtr.Fill(ds, "odahesabi");
                    dataGridView1.DataSource = ds.Tables["odahesabi"];
                    baglanti.Close();

                    groupBox1.Enabled = false;
                    groupBox2.Visible = groupBox3.Visible = buttonhesabigoster.Visible = buttonhesapcikis.Visible = true;
                }
            }
            else {
                MessageBox.Show("Hesap Alınacak Bir Oda Bulunamadı", "Hata");
                this.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            hesapkesimoda.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelminibarucret.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            labelodanum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            labelodatipi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labelodaucret.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            labeltoplamucret.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            labelesktraucret.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

        }

        private void buttonhesapcikis_Click(object sender, EventArgs e)
        {          //    eski müşterilere çıkış tarihini ekleme
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut8.Connection = baglanti;
            komut8.CommandText = "update eskimusteriler set cikistarihi=@cikistarihi where odanum=@odanum";                //çıkış dataya işlendi
            komut8.Parameters.AddWithValue("@cikistarihi", DateTime.Today);
            komut8.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            komut8.ExecuteNonQuery();
            baglanti.Close();

            buttonhesabigoster.Enabled = true;
            buttonhesapcikis.Enabled = false;
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut2.Connection = baglanti;
            komut2.CommandText = "update musteribilgiler set cikistarihi=@cikistarihi where odanum=@odanum";                //çıkış dataya işlendi
            komut2.Parameters.AddWithValue("@cikistarihi", DateTime.Today);
            komut2.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            ds.Clear();
            komut4.CommandText = "Select odahesabi.odanum,odaturu,musteriad,musterisoyad,giristarihi,cikistarihi,odafiyat,aktifodaucreti,minibarucreti,ekstraucreti,toplamhesap,musteritc from (odahesabi inner join musteribilgiler on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum where odahesabi.odanum=@odanum";
            komut4.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            da.SelectCommand = komut4;
            komut4.Connection = baglanti;  //GÖTLÜK !!!!!!!!!!!!! !    !!!!!!!!!!
            da.Fill(ds, "odahesabi");
            baglanti.Close();

        }

        private void buttonhesabigoster_Click(object sender, EventArgs e)
        {
            DateTime giris = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            DateTime cikis = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            TimeSpan kalinangun = cikis - giris;
            double odafiyati = Convert.ToDouble(dataGridView1.CurrentRow.Cells[6].Value);
            double aktifodafiyati = odafiyati * kalinangun.TotalDays;

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut3.Connection = baglanti;
            komut3.CommandText = "update odahesabi set toplamhesap=@toplamhesap,minibarucreti=@minibarucreti,ekstraucreti=@ekstraucreti,aktifodaucreti=@aktifodaucreti where odanum=@odanum";                //çıkış dataya işlendi
            komut3.Parameters.AddWithValue("@toplamhesap", aktifodafiyati + Convert.ToInt32(minibarucret.Text) + Convert.ToInt32(ekstraucret.Text));
            komut3.Parameters.AddWithValue("@minibarucreti", Convert.ToInt32(minibarucret.Text));
            komut3.Parameters.AddWithValue("@ekstraucreti", Convert.ToInt32(ekstraucret.Text));
            komut3.Parameters.AddWithValue("@aktifodaucreti", aktifodafiyati);
            komut3.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            komut3.ExecuteNonQuery();
            komut3.Dispose();
            baglanti.Close();


            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            ds.Clear();
            komut5.CommandText = "Select odahesabi.odanum,odaturu,musteriad,musterisoyad,giristarihi,cikistarihi,odafiyat,aktifodaucreti,minibarucreti,ekstraucreti,toplamhesap,musteritc from (odahesabi inner join musteribilgiler on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum where odahesabi.odanum=@odanum";
            komut5.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            da.SelectCommand = komut5;
            komut5.Connection = baglanti;  //GÖTLÜK !!!!!!!!!!!!! !    !!!!!!!!!!
            da.Fill(ds, "odahesabi");
            baglanti.Close();
            buttontamamla.Enabled = true;
            buttonhesapcikis.Enabled = false;
            buttonhesabigoster.Enabled = false;
        }

        private void buttontamamla_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut3.Connection = baglanti;
            komut3.CommandText = "update odahesabi set toplamhesap=@toplamhesap,minibarucreti=@minibarucreti,ekstraucreti=@ekstraucreti,aktifodaucreti=@aktifodaucreti where odanum=@odanum";                //çıkış dataya işlendi
            komut3.Parameters.AddWithValue("@toplamhesap", 0);
            komut3.Parameters.AddWithValue("@minibarucreti", 0);
            komut3.Parameters.AddWithValue("@ekstraucreti",0);
            komut3.Parameters.AddWithValue("@aktifodaucreti", 0);
            komut3.Parameters.AddWithValue("@odanum", hesapkesimoda.Text);
            komut3.ExecuteNonQuery();
            komut3.Dispose();
            baglanti.Close();


            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut6.Connection = baglanti;
            int odano = Convert.ToInt32(dataGridView1.CurrentRow.Cells["odanum"].Value);
            int tekkullanimlik = odano;
            komut6.CommandText = "delete from musteribilgiler where odanum=@odanum ";
            komut6.Parameters.AddWithValue("@odanum", odano);
            komut6.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Çıkış İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verileridatadancek();
            buttonhesapcikis.Enabled = true;
            buttontamamla.Enabled = false;
            
               // ODA DURUMU TEKRAR SIFIRLAMA 
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut7.Connection = baglanti;
            komut7.CommandText = "update odalar set odadurumu=@durum where odanum=@odanum";
            komut7.Parameters.AddWithValue("@durum", "Boş");
            komut7.Parameters.AddWithValue("@odanum",hesapkesimoda.Text);
            komut7.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Tamamlandı");
            this.Close();
        }

        private void ekstraucret_TextChanged(object sender, EventArgs e)
        {
            if (ekstraucret.TextLength != 0)
            { minibarucret.Enabled = true; }
            else if (ekstraucret.TextLength == 0)
                minibarucret.Enabled = false;
        }

        private void minibarucret_TextChanged(object sender, EventArgs e)
        {
            if (minibarucret.TextLength != 0)
            { buttonhesapcikis.Enabled = true; }
            else if (minibarucret.TextLength == 0)
                buttonhesapcikis.Enabled = false;

        }
    }
}
