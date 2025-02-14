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
using Excel = Microsoft.Office.Interop.Excel;

namespace Otel_Otomasyon
{
    public partial class FrmCustomers : Form
    {
        public FrmCustomers()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");


        private void verilerigoster() 
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku.GetValue(0).ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }

            baglanti.Close();
            oku.Close();

        }



      

        private void BtnVeriler_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            //Dolu odaya müşteri ekliyemezsin zaten ki yeni müşteri ekleme ekranında enable=false

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='" + comboBox1.Text + "'," +
                "Telefon='" + MskTxtTelefon.Text + "',Mail='" + TxtMail.Text + "',TC='" + TxtKimlikNo.Text + "',OdaNo='" + TxtOdaNo.Text + "',Ucret='" + TxtUcret.Text + "'," +
                "GirisTarihi='" + DtpGirisTarihi.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + DtpCikisTarihi.Value.ToString("yyyy-MM-dd") +
                "' where Musteriid=" + id + "", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();

            // Odalar için de değişiklikler uygulanıyor...
            string i = TxtOdaNo.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into Oda" + i + "(Adi,Soyadi) values('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Yapıldı...");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            // Müşteri tablosundan,müşteri siliniyor.Bunu istemeyiz zira son zamanlardaki müşteri bilgilerine ihtiyaç duyabiliriz.
            /* 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            */


            // Odalar için de değişiklikler uygulanıyor...
            string i = TxtOdaNo.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("delete from Oda" + i, baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
            MessageBox.Show("Silme işlemi yapıldı...");
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + TxtAra.Text + "%'", baglanti); 
            SqlDataReader oku = komut.ExecuteReader();


            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku.GetValue(0).ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Text = "";
            TxtKimlikNo.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = "";
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text; // Cinsiyet
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }



        // Unutulmamalıdır ki öncelikle verileri listview kısmına getirmelisin zira excel uygulamasına veriler buradan aktarılacak.

        private void ExportToExcel(ListView listView)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;  // Excel uygulamasını görünür yapar

            // Yeni bir çalışma kitabı oluştur
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            // Başlıkları yaz
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = listView.Columns[i].Text;
            }

            // Verileri yaz
            for (int i = 0; i < listView.Items.Count; i++)
            {
                for (int j = 0; j < listView.Items[i].SubItems.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = listView.Items[i].SubItems[j].Text;
                }
            }

            // Kullanıcıya dosya kaydetme penceresi göster
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
            }

            // Kaydetme işlemi tamamlandıktan sonra Excel'i kapat
            workbook.Close();
            excelApp.Quit();

            // COM nesnelerini serbest bırak
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }



        private void BtnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(listView1); // listView1, verilerin bulunduğu ListView
        }
    }
}
