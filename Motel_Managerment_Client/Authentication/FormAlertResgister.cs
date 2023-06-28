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
    public partial class FormAlertResgister : Form
    {
        public FormAlertResgister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            this.Hide();
            fl.Show();
        }
    }
}
