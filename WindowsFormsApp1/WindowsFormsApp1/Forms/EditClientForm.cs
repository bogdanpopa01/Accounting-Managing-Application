using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class EditClientForm : Form
    {
        private IClientRepository _clientRepository;
        private readonly Guid _clientId;
        public EditClientForm(Guid id)
        {
            InitializeComponent();
            MaximizeBox = false;
            _clientId = id;
            _clientRepository = new ClientRepository();

            var entity = _clientRepository.GetById(id);

            Text = "Editing " + entity.Name + " client... ";

            ageTextBox.Text = Convert.ToString(entity.Age);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var entity = _clientRepository.GetById(_clientId);
                entity.Age = Convert.ToInt32(ageTextBox.Text);
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

        private void age_va(object sender, CancelEventArgs e)
        {
            SetError(ageTextBox);
        }

        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(ageTextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
