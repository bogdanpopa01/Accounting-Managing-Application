using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class AddClientForm : Form
    {
        private IClientRepository _clientRepository;
        public AddClientForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            _clientRepository = new ClientRepository();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var client = new Client()
                {
                    Age = Convert.ToInt32(ageTextBox.Text),
                    City = cityTextBox.Text,
                    Name = nameTextBox.Text
                };
                string elem = null;
                elem = cityTextBox.Text;
                int ok = 1;
                foreach (var file in FakeDataBase.Files)
                {
                    if (file.CityName == elem)
                    {
                        ok = 0;
                    }
                }
                if (ok == 1)
                {
                    MessageBox.Show("Create a file with " + elem + " as city name first!");
                    Hide();
                    return;
                }
                else
                {
                    _clientRepository.Add(client);
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Form is not valid!");
            }
        }

        private void SetError(Control control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorProvider.SetError(control, "Value cannot be empty!");
            }
            else
                errorProvider.SetError(control, string.Empty);
        }

        private void name_va(object sender,CancelEventArgs e)
        {
            SetError(nameTextBox);
        }

        private void age_va(object sender, CancelEventArgs e)
        {
            SetError(ageTextBox);
        }

        private void city_va(object sender, CancelEventArgs e)
        {
            SetError(cityTextBox);
        }

        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(ageTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
