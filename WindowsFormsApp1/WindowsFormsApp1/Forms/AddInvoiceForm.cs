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
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class AddInvoiceForm : Form
    {
        private IInvoiceRepository _invoiceRepository;
        public AddInvoiceForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            _invoiceRepository = new InvoiceRepository();
            productTypeComboBox.DataSource = Enum.GetValues(typeof(ProductType));
        }


        // text box-ul pentru client name, de care de fapt nu am nevoie
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            if (FormIsValid())
            {
                string elem = null;
                elem = clientNameTextBox.Text;
                int ok = 1;
                foreach (var client in FakeDataBase.Clients)
                {
                    if (client.Name == elem)
                    {
                        ok = 0;
                    }
                }

                var invoice = new Invoice()
                {
                    MU = Convert.ToInt32(muTextBox.Text),
                    ProductName = productNameTextBox.Text,
                    ProductType = (ProductType)productTypeComboBox.SelectedItem,
                    TotalPrice = Convert.ToDouble(totalPriceTextBox.Text),
                    ClientName = clientNameTextBox.Text
                };

                if (ok == 1)
                {
                    MessageBox.Show("Create a client with " + elem + " name first!");
                    Hide();
                    return;
                }
                else
                {
                    _invoiceRepository.Add(invoice);
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Form is not valid!");
            }
        }

        // am apasat din greseala
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void productNameTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(productNameTextBox);
        }

        private void muTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(muTextBox);
        }

        private void totalPriceTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(totalPriceTextBox);
        }

        private void clientNameTextBox_validating(object sender, CancelEventArgs e)
        {
            SetError(clientNameTextBox);
        }

        private void productTypeComboBox_validating(object sender,CancelEventArgs e)
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
            if(string.IsNullOrEmpty(productNameTextBox.Text))
            {
                return false;
            }
            if(string.IsNullOrEmpty(muTextBox.Text))
            {
                return false;
            }
            if(string.IsNullOrEmpty(totalPriceTextBox.Text))
            {
                return false;
            }
            if(string.IsNullOrEmpty(clientNameTextBox.Text))
            {
                return false;
            }
            return true;
        }
        
    }
}
