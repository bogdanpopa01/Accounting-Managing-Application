using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class AddFileForm : Form
    {
        private IFileRepository _fileRepository;
        public AddFileForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            _fileRepository = new FileRepository();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var file = new File()
                {
                    CityName = cityNameTextBox.Text,
                };

                _fileRepository.Add(file);
                Hide();
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

        private void cityName_va(object sender, CancelEventArgs e)
        {
            SetError(cityNameTextBox);
        }

        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(cityNameTextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
