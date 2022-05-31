using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Database
{
    public static class FakeDataBase
    {
        public static List<File> Files = new List<File>()
        {
            new File()
            {
                IdFile = Guid.NewGuid(),
                CityName = "Bucuresti",
            },
            new File()
            {
                IdFile = Guid.NewGuid(),
                CityName = "Cluj Napoca",
            },
            new File()
            {
                IdFile = Guid.NewGuid(),
                CityName = "Timisoara",
            }
        };

        public static List<Client> Clients = new List<Client>()
        {
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Popa Adrian Bogdan",
                Age = 21,
                City = "Bucuresti"
            },
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Iustinian Iustin",
                Age = 34,
                City = "Bucuresti"
            },
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Radulescu Radu",
                Age = 51,
                City = "Bucuresti"
            },
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Florian Florin",
                Age = 19,
                City = "Cluj Napoca"
            },
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Simion Simionescu",
                Age = 26,
                City = "Timisoara"
            },
            new Client()
            {
                IdClient = Guid.NewGuid(),
                Name = "Patru Diana",
                Age = 18,
                City = "Timisoara"
            }
        };

        public static List<Invoice> Invoices = new List<Invoice>()
        {
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Gaming Chair",
                MU = 1,
                ProductType = ProductType.Non_Food,
                TotalPrice = 1190,
                ClientName = "Popa Adrian Bogdan"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Pizza",
                MU = 3,
                ProductType = ProductType.Food,
                TotalPrice = 60,
                ClientName = "Popa Adrian Bogdan"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Laptop",
                MU = 1,
                ProductType = ProductType.Non_Food,
                TotalPrice = 5000,
                ClientName = "Iustinian Iustin"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Car",
                MU = 1,
                ProductType = ProductType.Non_Food,
                TotalPrice = 600000,
                ClientName = "Iustinian Iustin"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Pencil",
                MU = 10,
                ProductType = ProductType.Non_Food,
                TotalPrice = 20,
                ClientName = "Radulescu Radu"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Jeans",
                MU = 2,
                ProductType = ProductType.Non_Food,
                TotalPrice = 550,
                ClientName = "Florian Florin"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Lasagna",
                MU = 5,
                ProductType = ProductType.Food,
                TotalPrice = 250.99,
                ClientName = "Simion Simionescu"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Rifle",
                MU = 2,
                ProductType = ProductType.Non_Food,
                TotalPrice = 13000,
                ClientName = "Patru Diana"
            },
            new Invoice()
            {
                IdInvoice = Guid.NewGuid(),
                ProductName = "Puppet",
                MU = 3,
                ProductType =ProductType.Non_Food,
                TotalPrice = 300,
                ClientName = "Patru Diana"
            }
        };

    }
}
