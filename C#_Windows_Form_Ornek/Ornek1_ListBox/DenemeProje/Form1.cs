using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeProje
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (eğer varsa)
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           try 
            {
                Musteri M1 = new Musteri
                {
                    name = txtName.Text,
                    surname = txtSurname.Text,
                    age = txtAge.Text,
                    phoneNumber = long.Parse(txtPhoneNumber.Text),
                    emailAddress = txtEmailAddress.Text,

                    id = i
                };



                lstMusteriler.Items.Add(M1); // Müşteri nesnesini ListBox'a ekle
                i++;
                MessageBox.Show("Customer Added: " + M1.name);

                //Müşteri Eklendikten Sonra TextBoxların Text Kısmının Boşaltılması 
                txtAge.Text=string.Empty;
                txtEmailAddress.Text=string.Empty;
                txtName.Text=string.Empty;
                txtPhoneNumber.Text=string.Empty;
                txtSurname.Text=string.Empty;
            } 
            
           
            
           catch
            {
                MessageBox.Show("Kutucuklar Boş Bırakılmamalıdır", "Bir Hata Oluştu!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListBox'da Seçilen Müşterinin Bilgilerinin Sağ Tarafta Gösterilmesi
            if (lstMusteriler.SelectedItem != null)
            {
                Musteri secilenMusteri = (Musteri)lstMusteriler.SelectedItem;

                lblName.Text = secilenMusteri.name;
                lblSurname.Text = secilenMusteri.surname;
                lblAge.Text = secilenMusteri.age;
                lblPhoneNumber.Text = secilenMusteri.phoneNumber.ToString();
                lblEmailAddress.Text = secilenMusteri.emailAddress;


            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.Items.Count > 0)
            {
                lstMusteriler.Items.Remove(lstMusteriler.SelectedItem);
                MessageBox.Show("Müşteri Başarıyla Silindi","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Silinecek Müşteriyi Seçiniz","Bir Hata Oluştu!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
