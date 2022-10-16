using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goSeeFilesButton_Click(object sender, EventArgs e)
        {
            var seeFilesForm = new SeeFilesForm();
            seeFilesForm.ShowDialog();
        }

        private void seeClientsButton_Click(object sender, EventArgs e)
        {
            var seeClientsForm = new SeeClientsForm();
            seeClientsForm.ShowDialog();
        }

        private void seeInvoicesButton_Click(object sender, EventArgs e)
        {
            var seeInvoicesForm = new SeeInvoicesForm();
            seeInvoicesForm.ShowDialog();
        }

        private void sFilesButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    FileStream fileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, FakeDataBase.Files);
                    fileStream.Close();
                }
            }
        }

        private void sClientsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    FileStream fileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, FakeDataBase.Clients);
                    fileStream.Close();
                }
            }
        }

        private void sInvoicesButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Binary file|.bin";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog.FileName))
                {
                    FileStream fileStream =
                        new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, FakeDataBase.Invoices);
                    fileStream.Close();
                }
            }
        }

        private void dFilesButton_Click(object sender, EventArgs e)
        {
           OpenFileDialog openFileDialog = new OpenFileDialog();
           openFileDialog.Filter = "Binary file|.bin";
           if (openFileDialog.ShowDialog() == DialogResult.OK)
           {
               if (!string.IsNullOrEmpty(openFileDialog.FileName))
               {
                   FileStream fileStream = new FileStream(
                       openFileDialog.FileName,
                       FileMode.Open
                       );
                   BinaryFormatter formatter = new BinaryFormatter();
                   FakeDataBase.Files = formatter.Deserialize(fileStream)
                       as List<Entities.File>;
                   fileStream.Close();
               }
           }
        }

        private void dClientsButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    FileStream fileStream = new FileStream(
                        openFileDialog.FileName,
                        FileMode.Open
                        );
                    BinaryFormatter formatter = new BinaryFormatter();
                    FakeDataBase.Clients = formatter.Deserialize(fileStream)
                        as List<Client>;     
                    fileStream.Close();
                }
            }
        }

        private void dInvoicesButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Binary file|.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    FileStream fileStream = new FileStream(
                        openFileDialog.FileName,
                        FileMode.Open
                        );
                    BinaryFormatter formatter = new BinaryFormatter();
                    FakeDataBase.Invoices = formatter.Deserialize(fileStream)
                        as List<Invoice>;
                    fileStream.Close();
                }
            }
        }
    }
}
