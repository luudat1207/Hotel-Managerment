using Motel_Managerment_API.Models;
using Motel_Managerment_Client.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel_Managerment_Client.Authentication
{
    public partial class FormValidationEmail : Form
    {
        UserManagerment userManagerment = new UserManagerment();
        string username = FormRegisterUser.username;
        string password = FormRegisterUser.password;
        string encoder = FormRegisterUser.randomCode;
        public FormValidationEmail()
        {
            InitializeComponent();
        }

        private void buttonVerifyMail_Click(object sender, EventArgs e)
        {
            if(textcodeMail.Text == encoder)
            {
                User user = new User();
                user.Username = username;
                user.Password = password;
                user.Role = 1;
                userManagerment.CreateUser(user);
                FormAlertResgister faR = new FormAlertResgister();
                this.Hide();
                faR.Show();
            }
            else
            {
                MessageBox.Show("Ma xac thuc khong dung! Vui long nhap lai");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormRegisterUser faR = new FormRegisterUser();
            this.Hide();
            faR.Show();
        }
    }
}
