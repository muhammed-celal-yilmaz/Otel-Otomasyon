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


namespace Otel_Otomasyon
{
    public partial class FrmRooms : Form
    {
        public FrmRooms()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");

        private void FrmRooms_Load(object sender, EventArgs e)
        {
            // Tek bir tabloda oda numaralarını kullanmak doğru yoldur.

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
                    }

                }

            }

        }






    }
}
