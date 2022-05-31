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
using WindowsFormsApp1.Extensions;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Database;

namespace WindowsFormsApp1.Forms
{
    public partial class DetailsFilesForm : Form 
    {
        private IClientRepository _clientRepository;
        public DetailsFilesForm(string _cityName)
        {
            InitializeComponent();
            MaximizeBox = false;
            _clientRepository = new ClientRepository();
            filesGridView.ReadOnly = true;
            filesGridView.AutoGenerateColumns = false;
            filesGridView.AllowUserToAddRows = false;

            filesGridView
                .AddColumn(0, "Id client", "IdClient")
                .AddColumn(1, "Name", "Name")
                .AddColumn(2, "Age", "Age")
                .AddColumn(3, "City", "City")
                .AddButtonColumn("detailsColumn", "Details", "");

            filesGridView.DataSource = _clientRepository.GetAll()
                .Where(x => x.City == _cityName).ToList();

            filesGridView.CellClick += clientsDataGrid_CellClick;

            filesGridView.DataSource = _clientRepository.GetAll()
                .Where(x => x.City == _cityName).ToList();
        }

        private void clientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == filesGridView.Columns["detailsColumn"].Index)
            {
                var currentClient = (Client)filesGridView.CurrentRow.DataBoundItem;
                var detailsClientsForm = new DetailsClientsForm(currentClient.Name);
                detailsClientsForm.ShowDialog();
            }
        }
        private void addClientButton_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();

            var data = _clientRepository.GetAll();
            filesGridView.RefreshDataGrid(data);
        }
    }
}
