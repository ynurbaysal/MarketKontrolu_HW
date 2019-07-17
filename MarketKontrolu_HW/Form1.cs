using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketKontrolu_HW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Disaridan urun adi girilecek, kasiyer bize urunun hangi reyonda oldugunu soyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
        }

        private void BtnReyon_Click(object sender, EventArgs e)
        {
            string urun = txtUrun.Text.ToLower();


            if (urun == "domates" || urun == "biber" || urun == "patlican")
            {
                MessageBox.Show("Sebze Reyonu");
            }
            if (urun == "dismacunu" || urun == "parfüm" || urun == "sampuan")
            {
                MessageBox.Show("Kozmetik Reyonu");
            }
            if (urun == "cep telefonu" || urun == "bilgisayar" || urun == "ses sistemi")
            {
                MessageBox.Show("Teknoloji Reyonu");
            }
            else
            {
                MessageBox.Show("Bu Urun Bizde YOK");
            }



        }
    }
}
