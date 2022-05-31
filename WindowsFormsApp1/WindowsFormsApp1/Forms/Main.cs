using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            var adminLoginForm = new AdminLoginForm();
            adminLoginForm.ShowDialog();
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            var userLoginForm = new UserLoginForm();
            userLoginForm.ShowDialog();
        }
    }
}
