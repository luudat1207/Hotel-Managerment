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

namespace Motel_Managerment_Client
{
    public partial class FormResetPassword : Form
    {
        UserManagerment userManagerment = new UserManagerment();
        string username = FormValidationCode.to;
        public FormResetPassword()
        {
            InitializeComponent();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            if(textBoxPass1.Text == textBoxPass2.Text)
            {
                User u = new User();
                u.Username = username;
                u.Password = textBoxPass2.Text;
                u.Role = 1;
                userManagerment.UpdateUserByUserName(u);

                FormAlertChangePassword facp = new FormAlertChangePassword();
                this.Hide();
                facp.Show();
            }
            else
            {
                MessageBox.Show("mật khẩu không trùng nhau!");
            }
        }
    }
}
