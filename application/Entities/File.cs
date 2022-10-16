using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    [Serializable]
    public class File
    {
        public Guid IdFile { get; set; }
        public string CityName { get; set; }
    }
}
