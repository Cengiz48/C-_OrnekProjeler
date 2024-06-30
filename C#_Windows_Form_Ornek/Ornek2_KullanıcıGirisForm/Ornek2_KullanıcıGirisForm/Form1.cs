using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek2_KullanıcıGirisForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //TextBox içeriği değişkene atama
            string kullaniciAdi=txtKullaniciAdi.Text;
            string sifre=txtSifre.Text;
            //Giriş Kontrolü
            if (kullaniciAdi=="admin" && sifre == "123")
            {
                Form2 form2 = new Form2(kullaniciAdi);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!!!");
            }
        }
    }
}
