using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel_Managerment_Client.Authentication
{
    public partial class FormRegisterUser : Form
    {
        public static string username;
        public static string password;
        public static string randomCode;

        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            username = textBoxEmailRG.Text;
            password = textBoxPasswordRG.Text;
            if (textBoxEmailRG.Text != null)
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                username = (textBoxEmailRG.Text).ToString();
                from = "ryudatto12072001@gmail.com";
                pass = "gmntkazkldsygdeo";
                messageBody = "Ma xac thuc dang ky tai khoan cua ban : " + randomCode;
                message.To.Add(username);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Ma xac thuc cua ban : " + randomCode;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    FormValidationEmail fve = new FormValidationEmail();
                    this.Hide();
                    fve.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Email không được trống!");
            }
        }
    }
}
