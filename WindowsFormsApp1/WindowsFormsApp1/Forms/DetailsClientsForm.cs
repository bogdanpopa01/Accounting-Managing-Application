using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class DetailsClientsForm : Form
    {
        private IInvoiceRepository _invoiceRepository;
        public DetailsClientsForm(string _clientName)
        {
            InitializeComponent();
            MaximizeBox = false;
            _invoiceRepository = new InvoiceRepository();
            clientsGridView.ReadOnly = true;
            clientsGridView.AllowUserToAddRows = false;
            clientsGridView.AutoGenerateColumns = false;

            clientsGridView.AddColumn(0, "Id invoice", "IdInvoice")
                .AddColumn(1, "Product name", "ProductName")
                .AddColumn(2, "MU", "MU")
                .AddColumn(3, "Produt Type", "ProductType")
                .AddColumn(4, "Total price", "TotalPrice");

            clientsGridView.DataSource = _invoiceRepository
                .GetAll().Where(x => x.ClientName == _clientName).ToList();
        }
    }
}
