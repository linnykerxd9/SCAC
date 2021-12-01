using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAC.Src.Classes
{
    public class LiderComunitario

    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public DateTime? entryDate { get; set; }
        public DateTime? exitDate { get; set; }
        public string login { get; set; }
        public string password { get; set; }

       
    }
}
