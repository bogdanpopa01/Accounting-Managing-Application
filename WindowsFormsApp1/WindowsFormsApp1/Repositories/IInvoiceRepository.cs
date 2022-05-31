using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    public interface IInvoiceRepository
    {
        List<Invoice> GetAll();
        Invoice GetById(Guid id);
        void Add(Invoice invoice);
        void Delete(Guid id);
    }
}
