using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraininConsoleAppCsharp
{
    public class Personne
    {
        
     
        public string Nom
        { get; set; }
        public string Prenom
        {get;set;
        }
        public string DateNaissance
        {
            get;set;
        }

        public Personne(string nom, string prenom, string dateNaissance)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;

        }

        public virtual void Afficher()
        {
            Console.WriteLine("Personne: " + Nom + " " + Prenom + " " + DateNaissance);
        }


    }

}
