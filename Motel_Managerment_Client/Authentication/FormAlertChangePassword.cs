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
    public partial class FormAlertChangePassword : Form
    {
        public FormAlertChangePassword()
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
