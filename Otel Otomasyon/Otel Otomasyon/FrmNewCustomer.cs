using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;


namespace Otel_Otomasyon
{
    public partial class FrmNewCustomer : Form
    {
        public FrmNewCustomer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");

        // "\" Yolda kaçış karakteri de kullanabilirsin -> MSI\SQLEXPRESS veya "@" eklersin.

        private void BtnOda301_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "301";
          
        }

        private void BtnOda302_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "302";

        }

        private void BtnOda303_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "303";

        }

        private void BtnOda304_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "304";

        }

        private void BtnOda305_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "305";

        }

        private void BtnOda306_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "306";

        }

        private void BtnOda307_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "307";

        }

        private void BtnOda308_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "308";

        }

        private void BtnOda309_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "309";

        }

        private void BtnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renk,boş odaları gösterir.");
        }

        private void BtnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renk,dolu odaları gösterir.");
        }

        private void DtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int fiyat;
            DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label11.Text = Sonuc.TotalDays.ToString(); // Gün farkı
            fiyat = Convert.ToInt32(label11.Text) * 100000; // Otelin günlük fiyatı
            TxtUcret.Text = fiyat.ToString();

            label11.Text = label11.Text + " Gün";
            label11.Visible= true;

        }

       
       

        public void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MusteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "','" + comboBox1.Text + "','" + MskTxtTelefon.Text + "','" + TxtMail.Text + "','" + TxtKimlikNo.Text + "','" + TxtOdaNo.Text + "','" + TxtUcret.Text + "','" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "','" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery(); // parametre güncelleme
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı...");

            // Odalar için de değişiklikler uygulanıyor...
            string i = TxtOdaNo.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Oda" + i +   "(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut2.ExecuteNonQuery();   
            baglanti.Close();
        }

        private void FrmNewCustomer_Load(object sender, EventArgs e)
        {
            for (int i = 301; i <= 309; i++)
            {
                string buttonName = "BtnOda" + i.ToString();
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;

                if (button != null)
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("select * from Oda" + i.ToString(), baglanti); //tablo ismini değişken olarak bu şekilde kullanabilirsin.
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        button.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    }
                    baglanti.Close();

                    if (button.Text != i.ToString())
                    {
                        button.BackColor = Color.Red;
                        button.Enabled= false;
                    }

                }

            }
        }


    }
}

// Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True

 