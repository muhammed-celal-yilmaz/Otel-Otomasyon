using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

// Mail adresinizin bazı güvenlik ayarlarını yapılandırmanız gerekmektedir.Kodu ancak bu şekilde alabilirsiniz.

namespace Otel_Otomasyon
{
    public partial class FrmUpdateCheck : Form
    {
        public FrmUpdateCheck()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int sayi = 4561;

        private void BtnOnay_Click(object sender, EventArgs e) //Onay Aşaması
        {
            if (TxtOnay.Text == sayi.ToString()) 
            {
                FrmUpdateLogin fr = new FrmUpdateLogin(); // Girilen kod doğruysa şifre güncelleme ekranına ilerlersiniz.
                fr.Show();
            }

            else
            {
                MessageBox.Show("Hatalı giriş..."); // Girilen kod yanlışsa bir uyarı alırsınız.
            }

        }

        private void BtnKod_Click(object sender, EventArgs e)
        {
            sayi = rastgele.Next(1000, 5000);
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com"); // Gmail kullanıyoruz.
            var mail = new MailMessage();
            mail.From = new MailAddress("*****@gmail.com"); // Gönderici mail adres
            mail.To.Add("*******"); // Mesajı göndereceğiniz mail adresi
            mail.Subject = "ONAY KODU"; 
            mail.IsBodyHtml = true;
            string htmlBody;
            htmlBody = sayi.ToString(); // Random sayımızı mesaj içeriğine ekledik.
            mail.Body = htmlBody; // Mesaj içeriğimiz
            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Gönderen mail adresi", "Şifre"); // Kendi mail adresinizi ve şifrenizi yazın.(Gönderici için tabi ki :))
            SmtpServer.EnableSsl = true;
            SmtpServer.Timeout = int.MaxValue;
            SmtpServer.Send(mail);

        }




    }
}
