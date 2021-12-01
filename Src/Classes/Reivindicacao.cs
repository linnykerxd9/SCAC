using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCAC.Src.Classes
{

    public class Reinvidacao
    {
        public int id { get; set; }
        public string description { get; set; }
        public string openDate { get; set; }
        public string completionDate { get; set; }
        public int idLeader { get; set; }
        public int idResident { get; set; }
        public int idStatus { get; set; }
        public int idOrgPublic { get; set; }
        public int idPriority { get; set; }
        public LiderComunitario communityLeader { get; set; }
        public Morador Resident { get; set; }
        public Status Status { get; set; }
        public OrgPublico OrgPublic { get; set; }
        public Prioridade Priority { get; set; }
    }
}
