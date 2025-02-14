using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Otel_Otomasyon
{
    public partial class FrmIncomeExpense : Form
    {
        public FrmIncomeExpense()
        {
            InitializeComponent();
        }

        // Alınan ürünlerin,personellerin ast-üst ilişkisine göre maaş skalasının ve personeller tablosunun detaylarına ve bunların tablolarına yer verilmemiştir.
        // Otomasyonun kullanılacağı otele göre bu özellikler detaylandırılabilir.
        // Bu formlar genel olarak küçük pansiyon tarzı bir otel otomasyonu için gerekli olan fonksiyonları içermektedir.Referans alınıp detaylandırılabilir.
       

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");
        private void FrmIncomeExpense_Load(object sender, EventArgs e)
        {

            // Kasadaki Tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblKasaToplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();

            // Alınan Ürünler
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida+İcecek+Cerezler) as toplam1 from Stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblAlinanUrunler.Text = oku2["toplam1"].ToString();

            }
            baglanti.Close();

            // Elektrik
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Elektrik+Su+İnternet) as toplam2 from Faturalar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblFaturalar.Text = oku3["toplam2"].ToString();

            }
            baglanti.Close();

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {

            // Personel
            int personel;
            personel = Convert.ToInt16(TxtPersonelSayisi.Text);
            LblPersonelMaas.Text = (personel * 25000).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(LblKasaToplam.Text) - (Convert.ToInt32(LblPersonelMaas.Text) + Convert.ToInt32(LblAlinanUrunler.Text) + Convert.ToInt32(LblFaturalar.Text));
            LblSonuc.Text = sonuc.ToString();

        }

    }
}
