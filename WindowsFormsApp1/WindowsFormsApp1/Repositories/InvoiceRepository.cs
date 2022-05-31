using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public void Add(Invoice invoice)
        {
            invoice.IdInvoice = Guid.NewGuid();
            FakeDataBase.Invoices.Add(invoice);
        }

        public void Delete(Guid id)
        {
            var currentInvoice = GetById(id);
            if (currentInvoice != null)
                FakeDataBase.Invoices.Remove(currentInvoice);
        }

        public List<Invoice> GetAll()
        {
            return FakeDataBase.Invoices;
        }

        public Invoice GetById(Guid id)
        {
            return FakeDataBase.Invoices.First(x => x.IdInvoice == id);
        }
    }
}
