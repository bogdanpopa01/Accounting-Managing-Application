using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetAll();
        Client GetById(Guid id);
        void Add(Client client);
        void Delete(Guid id);
    }
}
