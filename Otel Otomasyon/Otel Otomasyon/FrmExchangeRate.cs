using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Otel_Otomasyon
{
    public partial class FrmExchangeRate : Form
    {
        public FrmExchangeRate()
        {
            InitializeComponent();
        }


        private void FrmExchangeRate_Load(object sender, EventArgs e)
        {

            string url = "https://www.tcmb.gov.tr/kurlar/today.xml";

            var xmldoc = new XmlDocument();
            xmldoc.Load(url);
            DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            string USD = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/BanknoteSelling").InnerXml;
            lblDolar.Text = string.Format("-> Tarih {0} | USD : {1}", tarih.ToShortDateString(), USD);

            string EURO = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuro.Text = string.Format("-> Tarih {0} | EURO : {1}", tarih.ToShortDateString(), EURO);

            string POUND = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
            lblSterlin.Text = string.Format("-> Tarih {0} | POUND : {1}", tarih.ToShortDateString(), POUND);

            string Riyal = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/BanknoteSelling").InnerXml;
            lblRiyal.Text = string.Format("-> Tarih {0} | Riyal : {1}", tarih.ToShortDateString(), Riyal);


        }

    }
}
