using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    public class ClientRepository : IClientRepository
    {
        public void Add(Client client)
        {
            client.IdClient = Guid.NewGuid();
            FakeDataBase.Clients.Add(client);
        }

        public void Delete(Guid id)
        {
            var currentClient = GetById(id);
            if (currentClient != null)
                FakeDataBase.Clients.Remove(currentClient);
        }

        public List<Client> GetAll()
        {
            return FakeDataBase.Clients;
        }

        public Client GetById(Guid id)
        {
            return FakeDataBase.Clients.First(x => x.IdClient == id);
        }
    }
}
