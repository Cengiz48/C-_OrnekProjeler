using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Ornek6_EmailGonderme
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

        private void btn_Gmail_Click(object sender, EventArgs e)
        {
            txt_alanadi.Text = "smtp.gmail.com";
        }

        private void btn_Outlook_Click(object sender, EventArgs e)
        {
            txt_alanadi.Text = "smtp.office365.com";
        }

        
        private void btn_EmailGonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_alanadi.Text==null)
                {
                    MessageBox.Show("Email Gönderimi Başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Encoding encode = Encoding.GetEncoding("windows-1254");
                    MailAddress To1 = new MailAddress(txt_GönderilcekEmail.Text);
                    MailAddress MailFrom = new MailAddress(txt_EmailAdresi.Text, txt_MesajBaslik.Text, encode);
                    MailMessage Email = new MailMessage();
                    Email.From = MailFrom;

                    Email.To.Add(txt_EmailAdresi.Text);
                    Email.To.Add(To1);

                    Email.Subject = txt_MesajKonusu.Text;
                    Email.Body = rtxt_Mesajİcerik.Text;
                    Email.IsBodyHtml = true;



                    SmtpClient smtp = new SmtpClient(txt_alanadi.Text, 587);//25 de olabilir
                    smtp.Credentials = new System.Net.NetworkCredential(txt_EmailAdresi.Text, txt_UygulamaSifresi.Text);
                    smtp.EnableSsl = true;

                    smtp.Send(Email);
                    MessageBox.Show("Email Gönderimi Başarılı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            { 
                MessageBox.Show("Email Gönderimi Başarısız oldu.","Hata",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           




        }

        private void btn_NasılAlınır_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail Hesabınıza Girdikten Sonra Ayarlar Kısmına giriniz daha sonrasında Güvenlik kısmına girdikten sonra arama kısmına Uygulama Şifreleri yazınız ve tıklayınız(Uygulama adını rastgele yazabilirsiniz.) ve artık şifreniz hazır kopyalayıp buraya yapıştırınız.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
