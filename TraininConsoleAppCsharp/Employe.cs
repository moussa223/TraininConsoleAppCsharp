using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraininConsoleAppCsharp
{
   public class Employe:Personne
    {
        
        public double Salaire { get; set; }
        public Employe(string nom, string prenom, string dateNaissance,double salaire):base(nom,prenom,dateNaissance)
        {
            this.Salaire = salaire;

        }
        public override void Afficher()
        {
            Console.WriteLine("Employer:"+ Nom+" "+Prenom+" date de naissance "+DateNaissance+" ayant pour salaire "+Salaire);
        }
    }
}
