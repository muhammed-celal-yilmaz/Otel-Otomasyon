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
using System.Reflection.Emit;


namespace Otel_Otomasyon
{
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminLogin fr = new FrmAdminLogin();
            fr.Show();
            this.Hide();
        }

        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmNewCustomer fr = new FrmNewCustomer();
            fr.Show();
          
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmRooms fr = new FrmRooms();
            fr.Show();
         
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmCustomers fr = new FrmCustomers();
            fr.Show();
        }

        private void BtnHakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grand Uludağ Otelleri Otomasyonu / 2025 / Bursa / MCY Company");
        }

        private void BtnHaberler_Click(object sender, EventArgs e)
        {
            FrmNews frm= new FrmNews();
            frm.Show();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadio frm= new FrmRadio();
            frm.Show(); 
        }

        private void BtnMesajlar_Click(object sender, EventArgs e)
        {
            FrmMessages frm= new FrmMessages();
            frm.Show(); 
        }

        private void BtnHesapMakinesi_Click(object sender, EventArgs e)
        {
            FrmCalculator frm = new FrmCalculator();
            frm.Show();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStocks frm= new FrmStocks();
            frm.Show();
        }

        private void BtnGelirGider_Click(object sender, EventArgs e)
        {
            FrmIncomeExpense frm= new FrmIncomeExpense();
            frm.Show(); 
        }

        private void BtnHavaDurumu_Click(object sender, EventArgs e)
        {
            FrmWeather frm= new FrmWeather();
            frm.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnKurlar_Click(object sender, EventArgs e)
        {
            FrmExchangeRate frm= new FrmExchangeRate();
            frm.Show();
        }
    }

    
}
