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
    public partial class AdminLoginForm : Form
    {
        private string _username;
        private string _password;
        // admin , admin

        public AdminLoginForm()
        {
            InitializeComponent();
        }


        // asta e butonul de password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _password = passwordTextBox.Text;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            _username = usernameTextBox.Text;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if(_password == "admin" && _username == "admin")
            {
                MessageBox.Show("You have logged in successfully!");
                var form1 = new Form1();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        // de asta n-am nevoie
        private void AdminLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
