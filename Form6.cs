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
    public partial class Form6 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
    + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();
        string secim;
        string durumsecimi;

        public Form6()
        {
            InitializeComponent();
        }

        private void Verilerial(string secmecumlesi, DataSet dataset, DataGridView datagrid, string tabloadi)  // VERİ ÇEKME FONKSİYONU EFSANE OLAN 
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            dataset.Clear();
            OleDbDataAdapter da = new OleDbDataAdapter(secmecumlesi, baglanti);
            da.Fill(dataset,tabloadi);
            datagrid.DataSource = dataset.Tables[tabloadi];
        }                                                                                                       // VERİ ÇEKME FONKSİYONU EFSANE OLAN 

        private void sadecesayi(object sender, KeyPressEventArgs e)                             //SADECE SAYI GİRİŞİ
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void Form6_Load(object sender, EventArgs e)                                                     //Try Catch Program Hatasından Dolayı Kullanıldı Hocam
        {
            radioButton2.Checked = true;
            try
            {
                Verilerial("select*from katlar", ds2, dataGridView2, "katlar");
            }
            catch { }
        }
        
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            try //'" +secim + "%'"
            {
                secim = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                Verilerial("Select *from odalar where katnum like'" + secim + "%'" + "AND odadurumu like'" + durumsecimi + "%'", ds, dataGridView1, "odalar");
            }
            catch { }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                durumsecimi = "Dolu";
                dataGridView1.Refresh();
                dataGridView2_SelectionChanged(sender, e);
            }
            else
            {
                    durumsecimi = "Boş";
                    dataGridView1.Refresh();
                    dataGridView2_SelectionChanged(sender, e);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Verilerial("Select *from odalar", ds, dataGridView1, "odalar");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button1.Enabled = false;

        }
            //

        private void buttonodaduzenle_Click(object sender, EventArgs e)
        {
            Verilerial("Select *from odalar", ds, dataGridView1, "odalar");
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button1.Enabled = false;
            buttonodaduzenle.Text = "Oda Seç";
            buttonodaduzenle.Enabled = false;

            ActiveForm.Size=new System.Drawing.Size(754, 460);
            label1.Visible = label2.Visible = label3.Visible = label4.Visible = textboxfiyat.Visible = yataksayisi.Visible = odaturu.Visible = odadurumu.Visible=buttononayla.Visible = true;

        }

        private void buttononayla_Click(object sender, EventArgs e)
        {
            if (odadurumu.Text == "Boş")
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "update odalar set odafiyat=@odafiyat,yataksayisi=@yataksayisi,odaturu=@odaturu,odadurumu=@odadurumu where odanum=@odanum";
                komut.Parameters.AddWithValue("@odafiyat", textboxfiyat.Text);
                komut.Parameters.AddWithValue("@yataksayisi", yataksayisi.Value);
                komut.Parameters.AddWithValue("@odaturu", odaturu.Text);
                komut.Parameters.AddWithValue("@odadurumu", odadurumu.Text);
                komut.Parameters.AddWithValue("@odanum", dataGridView2.CurrentRow.Cells[0].Value);
                komut.ExecuteNonQuery();
                baglanti.Close();
                komut.Dispose();
                MessageBox.Show("İşlem Başarılı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Verilerial("Select *from odalar", ds, dataGridView1, "odalar");
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                button1.Enabled = false;
                ActiveForm.Size = new System.Drawing.Size(754, 420);
                label1.Visible = label2.Visible = label3.Visible = label4.Visible = textboxfiyat.Visible = yataksayisi.Visible = odaturu.Visible = odadurumu.Visible = buttononayla.Visible = false;

                buttonodaduzenle.Text = "Odaları Düzenle";
                buttonodaduzenle.Enabled = true;
            }
            else if (odadurumu.Text == "Dolu")
            {
                MessageBox.Show("Dolu Odaya İşlem Yapamazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ActiveForm.Size = new System.Drawing.Size(754, 420);
                label1.Visible = label2.Visible = label3.Visible = label4.Visible = textboxfiyat.Visible = yataksayisi.Visible = odaturu.Visible = odadurumu.Visible = buttononayla.Visible = false;
                buttonodaduzenle.Enabled = true;

            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textboxfiyat.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            yataksayisi.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            odaturu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            odadurumu.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        } 
    }
}
