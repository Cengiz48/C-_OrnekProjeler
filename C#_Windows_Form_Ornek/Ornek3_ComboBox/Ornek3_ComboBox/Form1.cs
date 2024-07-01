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


namespace Ornek3_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UrunleriGetir();
        }

        private void cmbUrunListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
           object o1=cmbUrunListesi.SelectedItem;
           Urun urun = (Urun)o1;
           
          
            
             
            txtKitapAdi.Text = urun.kitapAdi;
            txtTur.Text = urun.tur;
            txtStokAdet.Text = urun.stokAdet.ToString();
            txtYazar.Text=urun.yazar;
            txtAciklama.Text = urun.aciklama;
            pctUrunResim.Image = Image.FromFile(urun.pctUrunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        void UrunleriGetir()
        {
            foreach (var item in SanalDatabase.urunListe)
            {
                cmbUrunListesi.Items.Add(item);
                
            }
        }
    }
}
