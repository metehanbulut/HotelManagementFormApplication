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
    public partial class Form3 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath + "\\projeotelveritabani.mdb");
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();
        OleDbCommand komut1 = new OleDbCommand();
        OleDbCommand komut9 = new OleDbCommand();
        OleDbCommand komut7 = new OleDbCommand();
        OleDbCommand komut6 = new OleDbCommand();
        OleDbCommand komut3 = new OleDbCommand();
        OleDbCommand komut8 = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbDataReader dr2;
        private void aramayap(string tabloaramakismi,string gelenkutu)
        {
         
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                OleDbDataAdapter adtr = new OleDbDataAdapter("Select musteribilgiler.musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,giristarihi,cikistarihi,musteribilgiler.odanum,odaturu,odalar.katnum from (musteribilgiler inner join odahesabi on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum where " + tabloaramakismi + " like '" + gelenkutu + "%'", baglanti);
                ds = new DataSet();
                adtr.Fill(ds, "musteribilgiler");
                dataGridView1.DataSource = ds.Tables["musteribilgiler"];
                baglanti.Close();
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

        private void verileridatadancek()
        {
            ds.Clear();
            komut.CommandText = "Select musteribilgiler.musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,giristarihi,cikistarihi,musteribilgiler.odanum,odaturu,odalar.katnum from (musteribilgiler inner join odahesabi on musteribilgiler.odanum=odahesabi.odanum)inner join odalar on odahesabi.odanum=odalar.odanum";
            da.SelectCommand = komut;
            komut.Connection = baglanti;
            da.Fill(ds, "musteribilgiler");

        }
        private void digerlerinikapat(int numara)                                                //TBLERİ TEMİZLEMEK İÇİN KURDUĞUM ALGORİTMA HOCAM
        {
            if (numara == 1)
                katbsoyadi.Text = katbtcno.Text = katbmail.Text = cbodatipi.Text = katboda.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 2)
                katbadi.Text = katbtcno.Text = katbmail.Text = cbodatipi.Text = katboda.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 3)
                katbadi.Text = katbsoyadi.Text = katbmail.Text = cbodatipi.Text = katboda.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 4)
                katbadi.Text = katbsoyadi.Text = katbtcno.Text = cbodatipi.Text = katboda.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 5)
                katbadi.Text = katbsoyadi.Text = katbtcno.Text = katbmail.Text = katboda.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 6)
                katbadi.Text = katbsoyadi.Text = katbtcno.Text = katbmail.Text = cbodatipi.Text = kacbkat.Text = kscbcinsiyet.Text = "";
            else if (numara == 7)
                katbadi.Text = katbsoyadi.Text = katbtcno.Text = katbmail.Text = cbodatipi.Text = katboda.Text = kscbcinsiyet.Text = "";
            else if (numara == 8)
                katbadi.Text = katbsoyadi.Text = katbtcno.Text = katbmail.Text = cbodatipi.Text = katboda.Text = kacbkat.Text = "";
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["musteribilgiler"];
            baglanti.Close();
        }

        private void kabuttonguncelle_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void kabuttonsil_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }


        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (bgbuttontemizle.Enabled != true)
            {
                bgtbtcno.Text = kstbtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                bgtbadi.Text = kstbadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                bgtbsoyadi.Text = kstbsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                kscinsiyet1.Text = kscinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                bgtbgsmno.Text = kstbgsm.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                bgtbmail.Text = kstbmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                bggiris.Text = ksgiris.Text = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value).ToShortDateString();
                bgcbodatipi.Text = kcbodatipi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                bgtboda.Text = kstboda.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                bgkat.Text = kscbkat.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }


        }

        private void katbadi_TextChanged(object sender, EventArgs e)
        {
            aramayap("musteriad",katbadi.Text);
            digerlerinikapat(1);
        }

        private void katbsoyadi_TextChanged(object sender, EventArgs e)
        {
            aramayap("musterisoyad", katbsoyadi.Text);
            digerlerinikapat(2);

        }

        private void katbtcno_TextChanged(object sender, EventArgs e)
        {
            aramayap("musteribilgiler.musteritc", katbtcno.Text);
            digerlerinikapat(3);

        }

        private void katbmail_TextChanged(object sender, EventArgs e)
        {
            aramayap("musterimail", katbmail.Text);
            digerlerinikapat(4);

        }

        private void kscbcinsiyet_TextChanged(object sender, EventArgs e)
        {
            aramayap("mustericinsiyet", kscbcinsiyet.Text);
            digerlerinikapat(10);
        }

        private void katboda_TextChanged(object sender, EventArgs e)
        {
            aramayap("odahesabi.odanum", katboda.Text);
            digerlerinikapat(6);
        }

        private void cbodatipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            aramayap("odalar.odaturu", cbodatipi.Text);
            digerlerinikapat(5);

        }

        private void kacbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            aramayap("odalar.katnum", kacbkat.Text);
            digerlerinikapat(7);
        }

        private void kagiris_ValueChanged(object sender, EventArgs e)
        {
            aramayap(("musteribilgiler.giristarihi"), kagiris.Text);
        }

        private void ksbuttonsil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıtlı Müşteriyi Silmek İstediğinize Eminseniz 'Tamamla' Butonuna Tıklayın","Uyarı !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            ksbuttontemizle.Enabled = true;
            ksbuttonsil.Enabled = false;
        }

        private void ksbuttontemizle_Click(object sender, EventArgs e)         // SİLME BUTONU CLİCK EVENTİ
        {
            
            ksbuttonsil.Enabled = true;
            ksbuttontemizle.Enabled = false;
           
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut6.Connection = baglanti;
            int odano = Convert.ToInt32(dataGridView1.CurrentRow.Cells["odanum"].Value);
            komut6.CommandText = "delete from musteribilgiler where odanum=@odanum";
            komut6.Parameters.AddWithValue("@odanum", odano);
            komut6.ExecuteNonQuery();
            baglanti.Close();
            komut6.Dispose();
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut6.Connection = baglanti;
            komut6.CommandText = "delete from eskimusteriler where odanum=@odanum";
            komut6.Parameters.AddWithValue("@odanum", odano);
            komut6.ExecuteNonQuery();
            komut6.Dispose();
            baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut1.Connection = baglanti;
            komut1.CommandText = "insert into eskimusteriler (musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,odanum,giristarihi,cikistarihi) Values(@musteritc,@musteriad,@musterisoyad,@mustericinsiyet,@musterigsm,@musterimail,@odanum,@giristarihi,@cikistarihi)";
            komut1.Parameters.AddWithValue("@musteritc", kstbtc.Text);
            komut1.Parameters.AddWithValue("@musteriad", kstbadi.Text);
            komut1.Parameters.AddWithValue("@musterisoyad", kstbsoyadi.Text);
            komut1.Parameters.AddWithValue("@mustericinsiyet",kscinsiyet.Text);
            komut1.Parameters.AddWithValue("@musterigsm", kstbgsm.Text);
            komut1.Parameters.AddWithValue("@musterimail", kstbmail.Text);
            komut1.Parameters.AddWithValue("@odanum", kstboda.Text);
            komut1.Parameters.AddWithValue("@giristarihi", ksgiris.Text);
            komut1.Parameters.AddWithValue("@cikistarihi",DateTime.Today);
            komut1.ExecuteNonQuery();
            komut1.Dispose();
            baglanti.Close();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut3.Connection = baglanti;
            komut3.CommandText = "select * from musteribilgiler where odanum like'" + kstboda.Text + "%'";                                    // ESKİ MÜŞTERİ Mİ?
            dr2 = komut3.ExecuteReader();
            dr2.Read();
            if (dr2.HasRows != true)
            {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    komut7.Connection = baglanti;
                    komut7.CommandText = "update odalar set odadurumu=@durum where odanum=@odanum";
                    komut7.Parameters.AddWithValue("@durum", "Boş");
                    komut7.Parameters.AddWithValue("@odanum", kstboda.Text);
                    komut7.ExecuteNonQuery();
                    baglanti.Close();
                komut3.Dispose();
                baglanti.Close();
            }
            

            MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verileridatadancek();
       
        }

        private void bgbuttonguncelle_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            bgbuttonguncelle.Enabled = false;
            bgkat.Enabled = false;
            bgtboda.Enabled = false;
            bgcbodatipi.Enabled = false;
            bgtbtcno.Enabled = false;

        }

        private void bgbuttontemizle_Click(object sender, EventArgs e) //Güncelleme Butonu İŞlevi
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut8.Connection = baglanti; 
            komut8.CommandText = "update musteribilgiler set musteriad=@musteriad,musterisoyad=@musterisoyad,musterigsm=@musterigsm,musterimail=@musterimail,giristarihi=@giristarihi,mustericinsiyet=@mustericinsiyet   where musteritc=@musteritc";
            komut8.Parameters.AddWithValue("@musteriad", bgtbadi.Text);
            komut8.Parameters.AddWithValue("@musterisoyad", bgtbsoyadi.Text);
            komut8.Parameters.AddWithValue("@musterigsm", bgtbgsmno.Text);
            komut8.Parameters.AddWithValue("@musterimail", bgtbmail.Text);
            komut8.Parameters.AddWithValue("@giristarihi", bggiris.Text);
            komut8.Parameters.AddWithValue("@mustericinsiyet", kscinsiyet1.Text);
            komut8.Parameters.AddWithValue("@musteritc", bgtbtcno.Text);
            komut8.ExecuteNonQuery();
            baglanti.Close();
            komut8.Dispose();

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            komut8.Connection = baglanti;
            komut8.CommandText = "update eskimusteriler set musteriad=@musteriad,musterisoyad=@musterisoyad,musterigsm=@musterigsm,musterimail=@musterimail,giristarihi=@giristarihi,mustericinsiyet=@mustericinsiyet   where musteritc=@musteritc";
            komut8.Parameters.AddWithValue("@musteriad", bgtbadi.Text);
            komut8.Parameters.AddWithValue("@musterisoyad", bgtbsoyadi.Text);
            komut8.Parameters.AddWithValue("@musterigsm", bgtbgsmno.Text);
            komut8.Parameters.AddWithValue("@musterimail", bgtbmail.Text);
            komut8.Parameters.AddWithValue("@giristarihi", bggiris.Text);
            komut8.Parameters.AddWithValue("@mustericinsiyet", kscinsiyet1.Text);
            komut8.Parameters.AddWithValue("@musteritc", bgtbtcno.Text);
            komut8.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("İşlem Sonlandırıldı");
            this.Close();

        }
    }
}
