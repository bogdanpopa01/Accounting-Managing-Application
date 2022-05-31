using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Database;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Repositories
{
    internal class FileRepository : IFileRepository
    {
        public void Add(File file)
        {
            file.IdFile = Guid.NewGuid();
            FakeDataBase.Files.Add(file);
        }

        public void Delete(Guid id)
        {
            var currentFile = GetById(id);
            if (currentFile != null)
                FakeDataBase.Files.Remove(currentFile);
        }

        public List<File> GetAll()
        {
            return FakeDataBase.Files;
        }

        public File GetById(Guid id)
        {
            return FakeDataBase.Files.First(x => x.IdFile == id);
        }
    }
}
