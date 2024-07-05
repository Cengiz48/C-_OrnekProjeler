using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIO_WinForm
{
    public partial class Form1 : Form
    {
        Dataİslemleri dataIslemleri;
        List<Personel> personelListe;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            Dataİslemleri dataIslemleri= new Dataİslemleri();

           personelListe = dataIslemleri.personelGetir(150);
            lstPersonel.DataSource = personelListe;

        }

        private void lstPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personel secilenPersonel = (Personel)lstPersonel.SelectedItem;
            txtIsim.Text = secilenPersonel.isim;
            txtSoyisim.Text=secilenPersonel.soyisim;
            txtEmailAdres.Text = secilenPersonel.emailAdres;
            txtFirmaAdi.Text = secilenPersonel.firmaAdi;
            txtUlke.Text = secilenPersonel.ulke;
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
           
            if (Directory.Exists(@"c:\\PersonelListesi")==false)
            {
                Directory.CreateDirectory(@"c:\\PersonelListesi");
                MessageBox.Show("c:\\PersonelListesi" + " " + "Oluşturuldu","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            {

                Directory.CreateDirectory(@"c:\\PersonelListesi\\" + txtUlke.Text);
                FileStream fs = File.Create(@"c:\\PersonelListesi\\" + txtUlke.Text + @"\\" + txtIsim.Text + "." + txtSoyisim.Text + ".txt");
                fs.Close();
                File.WriteAllText(@"c:\\PersonelListesi\\" + txtUlke.Text + @"\\" + txtIsim.Text + "." + txtSoyisim.Text + ".txt", "İsim: " + txtIsim.Text + "\n" + "Soyisim: " + txtSoyisim.Text + "\n" + "Email Adres: " + txtEmailAdres.Text + "\n" + "Firma Adı: " + txtFirmaAdi.Text + "\n" + "Ülke: " + txtUlke.Text + "\n");

            }




        }
    }
}
