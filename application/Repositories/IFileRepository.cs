using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    public interface IFileRepository
    {
        List<File> GetAll();
        File GetById(Guid id);
        void Add(File file);
        void Delete(Guid id);
    }
}
