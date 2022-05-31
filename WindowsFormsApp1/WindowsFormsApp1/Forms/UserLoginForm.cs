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
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void showFilesButton_Click(object sender, EventArgs e)
        {
            var seeFilesFormUser = new SeeFilesFormUser();
            seeFilesFormUser.ShowDialog();
        }
    }
}
