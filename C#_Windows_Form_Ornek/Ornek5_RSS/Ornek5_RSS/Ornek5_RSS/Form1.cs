using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ornek5_RSS
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

        private void btnGetir_Click(object sender, EventArgs e)
        {
            List<Haber> haberListesi = new List<Haber>();
            XDocument xDocument = XDocument.Load(txtUrl.Text);
            List<XElement> Rows = xDocument.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                Haber temp =new Haber();
                temp.baslik = item.Element("title").Value;
                temp.link = item.Element("link").Value;
                temp.aciklama = item.Element("description").Value;
                haberListesi.Add(temp);
            }
            lstGüncelHaberler.DataSource= haberListesi;

            
        }

        private void lstGüncelHaberler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox secilenDeger = (ListBox)sender;
            Haber secilenHaber = (Haber)secilenDeger.SelectedItem;
            webBrowser.DocumentText = secilenHaber.aciklama;
        }
    }
}
