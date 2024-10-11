using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ornek7_HavaDurumuApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string resimYolu = System.IO.Path.Combine(Application.StartupPath, "resimdosyasi.jpg");

                lbl_tarih.Text = DateTime.Now.ToString();
                string api = "0d5fc9aa400ed41ba4b9420c7369c9cc";
                string connection = "https://api.openweathermap.org/data/2.5/weather?q=mu%C4%9Fla&mode=xml&lang=tr&units=metric&appid=" + api;
                XDocument havadurumu = XDocument.Load(connection);

                var sicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                //var yagis = havadurumu.Descendants("").ElementAt(0).Attribute("").Value;
                var nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                var rüzgar = havadurumu.Descendants("speed").ElementAt(0).Attribute("value").Value;
                var rüzgaryön = havadurumu.Descendants("direction").ElementAt(0).Attribute("name").Value;
                var havanındurumu = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;

                lbl_rüzgar.Text = rüzgar + "" + "m/s";
                lbl_nem.Text = nem + "" + "%";
                lbl_rüzgaryönü.Text = rüzgaryön;
                lbl_havanındurumu.Text = havanındurumu.ToUpper();
                lbl_sicaklik.Text = sicaklik + "°C";


                if (havanındurumu == "açık")
                {
                    pct_havadurum.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "güneşli.png");
                }
                if (havanındurumu == "parçalı bulutlu")
                {
                    pct_havadurum.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "parçalıbulutlu.png");
                }
                if (havanındurumu == "kapalı")
                {
                    pct_havadurum.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "bulutlu.png");
                }
                if (havanındurumu == "yağmurlu")
                {
                    pct_havadurum.ImageLocation = System.IO.Path.Combine(Application.StartupPath, "yağmurlu.png");
                }


            }
            catch 
            {
           
                MessageBox.Show("Hata Oluştu","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
               
            



        }
    }
}
