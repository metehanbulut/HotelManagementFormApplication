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
    public partial class Form10 : Form
    {

        public Form10()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath + "\\projeotelveritabani.mdb");
        DataSet ds = new DataSet();
        OleDbCommand komut = new OleDbCommand();
        private void verileridatadancek()
        {
            ds.Clear();
            string accesssecme = "select kullaniciadi,Ad,Soyad from users";
            OleDbDataAdapter da = new OleDbDataAdapter(accesssecme, baglanti);
            da.Fill(ds, "users");

        }
        private void Form10_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["users"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (Interaction.InputBox("Personeli Silmek için \"ONAYLIYORUM\" Yazın ", "Soru") == "ONAYLIYORUM")
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                komut.Connection = baglanti;
                string hesap = dataGridView1.CurrentRow.Cells["kullaniciadi"].Value.ToString();
                komut.CommandText = "delete from users where kullaniciadi='" + hesap + "'";
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                verileridatadancek();

            }
            else
            { MessageBox.Show("Silme işlemi Başarısız", "İkaz", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
        }
    }
}
