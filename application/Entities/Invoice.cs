using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Entities
{
    [Serializable]
    public class Invoice
    {
        public Guid IdInvoice { get; set; }
        public string ProductName { get; set; }
        public int MU { get; set; }
        public ProductType ProductType { get; set; }
        public double TotalPrice { get; set; }
        public string ClientName { get; set; }
    }
}
