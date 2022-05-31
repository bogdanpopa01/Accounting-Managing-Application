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
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class SeeInvoicesForm : Form
    {
        private IInvoiceRepository _invoiceRepository;
        public SeeInvoicesForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            _invoiceRepository = new InvoiceRepository();
            invoicesGridView.AllowUserToAddRows = false;
            invoicesGridView.AutoGenerateColumns = false;
            invoicesGridView.ReadOnly = true;

            invoicesGridView.AddColumn(0, "Id Invoice", "IdInvoice")
                .AddColumn(1, "Product Name", "ProductName")
                .AddColumn(2, "MU", "MU")
                .AddColumn(3, "Product Type", "ProductType")
                .AddColumn(4, "Total Price", "TotalPrice")
                .AddColumn(5,"Client Name","ClientName")
                .AddButtonColumn("editColumn","Edit","")
                .AddButtonColumn("deleteColumn","Delete","");

            invoicesGridView.DataSource = _invoiceRepository.GetAll();

            invoicesGridView.CellClick += invoicesDataGrid_CellClick;
        }

        private void invoicesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == invoicesGridView.Columns["deleteColumn"].Index)
            {
                var currentObject = (Invoice)invoicesGridView.CurrentRow.DataBoundItem;
                _invoiceRepository.Delete(currentObject.IdInvoice);
                var data = _invoiceRepository.GetAll();
                invoicesGridView.RefreshDataGrid(data);
            }
            if(e.ColumnIndex == invoicesGridView.Columns["editColumn"].Index)
            {
                var currentObject = (Invoice)invoicesGridView.CurrentRow.DataBoundItem;
                var editInvoiceForm = new EditInvoiceForm(currentObject.IdInvoice);
                editInvoiceForm.ShowDialog();
                var data = _invoiceRepository.GetAll();
                invoicesGridView.RefreshDataGrid(data);
            }
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            var addInvoiceForm = new AddInvoiceForm();
            addInvoiceForm.ShowDialog();
            var data = _invoiceRepository.GetAll();
            invoicesGridView.RefreshDataGrid(data);
        }
    }
}
