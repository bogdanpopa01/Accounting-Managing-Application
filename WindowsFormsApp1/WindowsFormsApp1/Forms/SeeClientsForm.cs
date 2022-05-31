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
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public partial class SeeClientsForm : Form
    {
        private IClientRepository _clientRepository;
        private IFileRepository _fileRepository;
        public SeeClientsForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            _clientRepository = new ClientRepository();
            clientsGridView.AutoGenerateColumns = false;
            clientsGridView.AllowUserToAddRows = false;
            clientsGridView.ReadOnly = true;

            
            clientsGridView
                .AddColumn(0, "Id client", "IdClient")
                .AddColumn(1, "Name", "Name")
                .AddColumn(2, "Age", "Age")
                .AddColumn(3, "City", "City")
                .AddButtonColumn("editColumn","Edit","")
                .AddButtonColumn("deleteColumn","Delete","")
                .AddButtonColumn("detailsColumn","Details","");

            clientsGridView.DataSource = _clientRepository.GetAll();

            clientsGridView.CellClick += clientsDataGrid_CellClick;

        }

        private void clientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string elem = null;
            Client currentObject2 = (Client)clientsGridView.CurrentRow.DataBoundItem;
            elem = currentObject2.Name;
            int ok = 0;
            foreach (var invoice in FakeDataBase.Invoices)
            {
                if (invoice.ClientName == elem)
                {
                    ok = 1;
                }
            }

            if (e.ColumnIndex == clientsGridView.Columns["deleteColumn"].Index)
            {
                if (ok == 1)
                {
                    MessageBox.Show("Delete all the invoices first!");
                    return;
                }
                else
                {
                    var currentClient = (Client)clientsGridView.CurrentRow.DataBoundItem;
                    _clientRepository.Delete(currentClient.IdClient);
                    var data = _clientRepository.GetAll();
                    clientsGridView.RefreshDataGrid(data);
                }
            }

            if(e.ColumnIndex == clientsGridView.Columns["editColumn"].Index)
            {
                var currentClient = (Client)clientsGridView.CurrentRow.DataBoundItem;
                var editClientForm = new EditClientForm(currentClient.IdClient);
                editClientForm.ShowDialog();
                var data = _clientRepository.GetAll();
                clientsGridView.RefreshDataGrid(data);
            }
            if(e.ColumnIndex == clientsGridView.Columns["detailsColumn"].Index)
            {
                var currentClient = (Client)clientsGridView.CurrentRow.DataBoundItem;
                var detailsClientsForm = new DetailsClientsForm(currentClient.Name);
                detailsClientsForm.ShowDialog();
            }
        }

        // aici e de fapt butonul de addClient
        private void addFileButton_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            
            var data = _clientRepository.GetAll();
            clientsGridView.RefreshDataGrid(data);
        }
    }
}
