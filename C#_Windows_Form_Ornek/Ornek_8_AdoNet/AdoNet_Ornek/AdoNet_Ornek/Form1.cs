using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet_Ornek
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        void MusteriGetir()
        {
            baglanti= new SqlConnection("server=localhost\\SQLEXPRESS;Initial Catalog=MusteriTakip;Integrated Security=True;");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM musteri", baglanti);
            DataTable tablo= new DataTable();
            da.Fill(tablo);
            dgw_Tablo.DataSource = tablo;
            baglanti.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MusteriGetir();

        }

        private void dgw_Tablo_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dgw_Tablo.CurrentRow.Cells[0].Value.ToString();
            txt_Ad.Text = dgw_Tablo.CurrentRow.Cells[1].Value.ToString();
            txt_Soyad.Text = dgw_Tablo.CurrentRow.Cells[2].Value.ToString();
            dtp_Dogum.Text = dgw_Tablo.CurrentRow.Cells[3].Value.ToString();
            txt_Telefon.Text = dgw_Tablo.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteri(Ad,Soyad,Dogum_Tarihi,Telefon) VALUES (@Ad,@Soyad,@Dogum_Tarihi,@Telefon)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad",txt_Ad.Text);
            komut.Parameters.AddWithValue("@Soyad",txt_Soyad.Text);
            komut.Parameters.AddWithValue("@Dogum_Tarihi",dtp_Dogum.Value);
            komut.Parameters.AddWithValue("@Telefon",txt_Telefon.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            MessageBox.Show("Başarıyla Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM musteri WHERE Id=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("Id", Convert.ToInt32(txt_Id.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            MessageBox.Show("Başarıyla Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE musteri SET Ad=@Ad,Soyad=@Soyad,Dogum_Tarihi=@Dogum_Tarihi,Telefon=@Telefon where Id=@Id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Id", Convert.ToInt32(txt_Id.Text));
            komut.Parameters.AddWithValue("@Ad", txt_Ad.Text);
            komut.Parameters.AddWithValue("@Soyad", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@Dogum_Tarihi", dtp_Dogum.Value);
            komut.Parameters.AddWithValue("@Telefon", txt_Telefon.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
            MessageBox.Show("Başarıyla Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
