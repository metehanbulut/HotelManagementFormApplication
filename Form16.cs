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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
           + Application.StartupPath + "\\projeotelveritabani.mdb");
        public static DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();
        private void sadecesayi(object sender, KeyPressEventArgs e)                             //SADECE SAYI GİRİŞİ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void verileridatadancek()
        {
            ds.Clear();
            string accesssecme = "Select musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,giristarihi,cikistarihi from eskimusteriler where cikistarihi not like'" + " %'";
            OleDbDataAdapter da = new OleDbDataAdapter(accesssecme, baglanti);
            da.Fill(ds, "eskimusteriler");
        }
        private void aramayap(string tabloaramakismi, string gelenkutu)
        {

            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musterimail,giristarihi,cikistarihi from eskimusteriler where " + tabloaramakismi + " like '" + gelenkutu + "%'"+"AND cikistarihi not like'" + " %'", baglanti);
            ds = new DataSet();
            adtr.Fill(ds, "eskimusteriler");
            dataGridView1.DataSource = ds.Tables["eskimusteriler"];
            baglanti.Close();
        }


        private void Form16_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["eskimusteriler"];
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            aramayap("eskimusteriler.musteritc", textBox2.Text);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

                kstbtc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                kstbadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                kstbsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                kscinsiyet.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                kstbgsm.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                kstbmail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                ksgiris.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
                kscikis.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);

        }

        private void bosaltbutton_Click(object sender, EventArgs e)
        {
           DialogResult cevap= MessageBox.Show("   DİKKAT! BU İŞLEMİ GERİ ALAMAZSINIZ ! !\n\n                   EMİN MİSİNİZ ?", "                                       DİKKAT !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
           if (cevap == DialogResult.Yes)
           {
               if (baglanti.State == ConnectionState.Closed)
                   baglanti.Open();
               komut.Connection = baglanti;
               komut.CommandText = "delete* from eskimusteriler";
               komut.ExecuteNonQuery();
               komut.Dispose();
               baglanti.Close();
               verileridatadancek();
           }
           else
           { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 f18 = new Form18();
            f18.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dateTimePicker1.Enabled = label4.Enabled = false;
                textBox2.Enabled = label1.Enabled = true;
            }
            if (!radioButton1.Checked)
            {
                dateTimePicker1.Enabled = label4.Enabled = true;
                textBox2.Enabled = label1.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            aramayap(("eskimusteriler.cikistarihi"), dateTimePicker1.Text);

        }
    }
}
