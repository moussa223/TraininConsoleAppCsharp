using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp
{
    public class Langues
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string UtilisateurCreation { get; set; }
        public string UtilisateurModification { get; set; }

    }
}
