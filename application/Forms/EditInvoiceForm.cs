using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class EditInvoiceForm : Form
    {
        private IInvoiceRepository _invoiceRepository;
        private readonly Guid _invoiceId;
        public EditInvoiceForm(Guid id)
        {
            InitializeComponent();
            MaximizeBox = false;
            _invoiceRepository = new InvoiceRepository();
            _invoiceId = id;
            productTypeComboBox.DataSource = Enum.GetValues(typeof(ProductType));

            var entity = _invoiceRepository.GetById(id);
            Text = "Editing " + entity.ProductName + "...";
            nameTextBox.Text = entity.ProductName;
            muTextBox.Text = Convert.ToString(entity.MU);
            priceTextBox.Text = Convert.ToString(entity.TotalPrice);
            productTypeComboBox.Text = Convert.ToString(entity.ProductType);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                var entity = _invoiceRepository.GetById(_invoiceId);
                entity.ProductName = nameTextBox.Text;
                entity.MU = Convert.ToInt32(muTextBox.Text);
                entity.TotalPrice = Convert.ToDouble(priceTextBox.Text);
                entity.ProductType = (ProductType)productTypeComboBox.SelectedItem;
                Hide();
            }
            else
            {
                MessageBox.Show("Form is not valid!");
            }
        }

        private void productNameTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(nameTextBox);
        }

        private void muTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(muTextBox);
        }

        private void totalPriceTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(priceTextBox);
        }

        private void productTypeComboBox_validating(object sender, CancelEventArgs e)
        {
            SetError(productTypeComboBox);
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

        private bool FormIsValid()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(muTextBox.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(priceTextBox.Text))
            {
                return false;
            }
            return true;
        }
    }
}
