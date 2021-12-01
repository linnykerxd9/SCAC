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
        public string descricao { get; set; }
        public string nomeResponsavel { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public int idStatus { get; set; }

    }
}
