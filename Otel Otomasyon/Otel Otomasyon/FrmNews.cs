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
    public partial class FrmNews : Form
    {
        public FrmNews()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.trtworld.com/  "); // web browser da gösterir.
            webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.voanews.com"); // direkt siteye yönlendirir.
        }

        private void button3_Click(object sender, EventArgs e)
        {
           webBrowser1.Navigate("https://www.trthaber.com/");
           webBrowser1.ScriptErrorsSuppressed = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.posta.com.tr/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bbc.com/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.bloomberght.com/");
            webBrowser1.ScriptErrorsSuppressed = true;
        }
    }
}
