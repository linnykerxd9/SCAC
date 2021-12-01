using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAC.Src.Classes
{

    public class Evento
    {
        public int id { get; set; }
        public string description { get; set; }
        public string nameResponsible { get; set; }
        public string date { get; set; }
        public string hour { get; set; }
        public int idStatus { get; set; }
        public Status status  { get; set; }
            
    }
}
