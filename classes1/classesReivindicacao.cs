using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reivindicacao {

    class reinvidacao
    {
        public int idReinvidicacao { get; set; }
        public string descricao { get; set; }
        public string dataAbertura { get; set; }
        public string dataConclusao { get; set; }
        public int idLider { get; set; }
        public int idMorador { get; set; }
        public int idStatus { get; set; }
        public int idOrgPublico { get; set; }
        public int idPrioridade { get; set; }

    }
}
