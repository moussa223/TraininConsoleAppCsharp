using System;
using System.Collections.Generic;
using System.Text;

namespace ExoDeplacerElementsEntreDeuxListeBoxWPF.Entity
{
    public class programmingLanguages
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Libellé { get; set; }
        public string Description { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateModification { get; set; }
        public string UtilisateurCreation { get; set; }
        public string UtilisateurModification { get; set; }

    }
}
