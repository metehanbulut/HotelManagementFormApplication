using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace deneme_veritabanı
{

    public partial class Form8 : Form
    {
      
        
        public Form8()
        {
            InitializeComponent();
        }

        public void button3_Click_1(object sender, EventArgs e)
        {
            Interaction.InputBox("Yeni Telefon Numarasını Giriniz", "Numara Değişim");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.ShowDialog();
        }
    }
}
