using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Motel_Managerment_Client
{
    public partial class FormValidationCode : Form
    {
        string randomCode;
        public static string to;
        public FormValidationCode()
        {
            InitializeComponent();
        }

        private void buttonGuiCode_Click(object sender, EventArgs e)
        {
            if (textcodEmailFG.Text != null)
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (textcodEmailFG.Text).ToString();
                from = "ryudatto12072001@gmail.com";
                pass = "gmntkazkldsygdeo";
                messageBody = "Ma xac thuc de lay lai mat khau cua ban : " + randomCode;
                message.To.Add(to);
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
                    MessageBox.Show("code send successfully");
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

        private void buttonXacThuc_Click(object sender, EventArgs e)
        {
            if (randomCode == textBoxOptCode.Text)
            {
                to = textcodEmailFG.Text;
                FormResetPassword frp = new FormResetPassword();
                this.Hide();
                frp.Show();
            }
            else
            {
                MessageBox.Show("OTP wrong");
            }
        }
    }
}
