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
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class SeeFilesFormUser : Form
    {
        private IFileRepository _fileRepository;
        public SeeFilesFormUser()
        {
            InitializeComponent();
            MaximizeBox = false;
            _fileRepository = new FileRepository();
            filesGridView.AutoGenerateColumns = false;
            filesGridView.ReadOnly = true;
            filesGridView.AllowUserToAddRows = false;


            filesGridView.AddColumn(0, "Id File", "IdFile")
                .AddColumn(1, "City Name", "CityName")
                .AddButtonColumn("detailsColumn", "Details", "");


            filesGridView.DataSource = _fileRepository.GetAll();

            filesGridView.CellClick += filesDataGrid_cellClick;
        }

        private void filesDataGrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == filesGridView.Columns["detailsColumn"].Index)
            {
                File currentObject = (File)filesGridView.CurrentRow.DataBoundItem;
                var detailsFilesFormUser = new DetailsFilesFormUser(currentObject.CityName);
                detailsFilesFormUser.ShowDialog();
                //var data = _fileRepository.GetAll();
                //filesGridView.RefreshDataGrid(data);
            }
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            var addFileForm = new AddFileForm();
            addFileForm.ShowDialog();
            var data = _fileRepository.GetAll();
            filesGridView.RefreshDataGrid(data);
        }
    }
}
