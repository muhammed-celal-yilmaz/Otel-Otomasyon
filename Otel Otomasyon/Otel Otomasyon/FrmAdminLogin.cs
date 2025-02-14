﻿using System;
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
    public partial class FrmAdminLogin : Form
    {
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=GrandUludag;Integrated Security=True");

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sql = "select * from AdminGiris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
            SqlParameter prm1 = new SqlParameter("Kullaniciadi", TxtKullaniciAdi.Text.Trim());
            SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text.Trim());
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.Add(prm1);
            komut.Parameters.Add(prm2);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                FrmMainForm fr = new FrmMainForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                baglanti.Close();
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmUpdateCheck frm= new FrmUpdateCheck();
            frm.Show();
        }
    }
}
