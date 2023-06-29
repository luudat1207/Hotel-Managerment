using Motel_Managerment_API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Motel_Managerment_Client
{
    public partial class FormLogin : Form
    {
        Logics.UserManagerment userManagerment = new Logics.UserManagerment();
        List<User> listUsers = new List<User>();

        public FormLogin()
        {
            InitializeComponent();
           
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (testLogIn(textBoxUsername.Text, textBoxPassword.Text))
            {
                MIDForm f = new MIDForm();
                f.Show();
                this.Hide();
                //f.DangXuat += F_DangXuat;
            }
            else
            {
                MessageBox.Show("the User name or password your entered incorrect!");
                textBoxPassword.Clear();
                textBoxUsername.Focus();
            }
        }
        private void F_DangXuat(object? sender, EventArgs e)
        {
           // (sender as MIDForm).boolExit = false;
            (sender as MIDForm).Close();
            this.Show();
        }
        private bool testLogIn(string? username, string? password)
        {
            using (var context = new DBNhaTroContext())
            {
                listUsers = context.Users.ToList();
            }
            for (int i = 0; i < listUsers.Count; i++)
            {
                if (listUsers[i].Username == username && listUsers[i].Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormValidationCode fvc = new FormValidationCode();
            this.Hide();
            fvc.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentication.FormRegisterUser fvc = new Authentication.FormRegisterUser();
            this.Hide();
            fvc.Show();
        }
    }
}
