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
    public partial class Form15 : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\projeotelveritabani.mdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();
        private void verileridatadancek()
        {
            ds.Clear();
            komut.CommandText = "Select musteritc,musteriad,musterisoyad,mustericinsiyet,musterigsm,musteribilgiler.odanum,giristarihi from musteribilgiler inner join odahesabi on musteribilgiler.odanum=odahesabi.odanum where odahesabi.odanum=@odanumarasi";
            komut.Parameters.AddWithValue("@odanumarasi", Convert.ToInt32(Form7.tiklanan.adi));         // FORM 7deki butonun ismini inte çevirip veritabanı cümlesine aktarma kısmı
            da.SelectCommand = komut;
            komut.Connection = baglanti;
            da.Fill(ds, "musteribilgiler");
        }
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            verileridatadancek();
            dataGridView1.DataSource = ds.Tables["musteribilgiler"];
            baglanti.Close();

        }
    }
}
