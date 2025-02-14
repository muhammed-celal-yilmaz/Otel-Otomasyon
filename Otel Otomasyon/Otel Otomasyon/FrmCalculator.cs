using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyon
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }
        // Bu değişkenler tüm alanlarda(scope) kullanılacağı için internal scope kısmında tanımladık.Heryerden erişebiliriz yani.
        bool _isScreenClear;
        char _islem; 
        int _ilkSayi;

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (_isScreenClear) 
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if (_isScreenClear)
            {
                lblScreen.Text = "";
                _isScreenClear = false;
            }

            if (lblScreen.Text == "0") lblScreen.Text = "";
            lblScreen.Text += "0";
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            lblScreen.Text = "0";
        }

        private void BtnEsit_Click(object sender, EventArgs e)
        {

            int ikinciSayi = Convert.ToInt32(lblScreen.Text);
            int sonuc;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;

                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;

                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;

                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;

                default:
                    sonuc = 0;
                    break;
            }

            lblScreen.Text = Convert.ToString(sonuc);

        }

        private void BtnArti_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _isScreenClear = true;
            _ilkSayi = Convert.ToInt32(lblScreen.Text);
            
        }

        private void BtnEksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _isScreenClear = true;
            _ilkSayi = Convert.ToInt32(lblScreen.Text);
        }

        private void BtnCarpi_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _isScreenClear = true;
            _ilkSayi = Convert.ToInt32(lblScreen.Text);
        }

        private void BtnBolu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _isScreenClear = true;
            _ilkSayi = Convert.ToInt32(lblScreen.Text);
        }
    }
}
