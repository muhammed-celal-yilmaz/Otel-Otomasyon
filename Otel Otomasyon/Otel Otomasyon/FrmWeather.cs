using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace Otel_Otomasyon
{
    public partial class FrmWeather : Form
    {
        string hava_durumu_link = "https://mgm.gov.tr/ftpdata/analiz/sonsoa.xml";
        public FrmWeather()
        {
            InitializeComponent();
        }

        private void BtnHavaDurumu_Click(object sender, EventArgs e)
        {
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(hava_durumu_link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");

            foreach (XmlNode node in nodes)
            {
                string ili = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string maks_sıcaklık = node["Mak"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ili;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = maks_sıcaklık;
                dataGridView1.Rows.Add(row);

            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow secilen_satir in dataGridView1.Rows)
            {
                if (Convert.ToString(secilen_satir.Cells[0].Value) == "GAZİANTEP")
                {
                    secilen_satir.DefaultCellStyle.BackColor = Color.Yellow;
                }

            }
        }

        private void FrmWeather_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString();
        }
    }
}
