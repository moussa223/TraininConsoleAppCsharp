using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClassesAbstraites
{
    public abstract class Employe
    {

        public int Matricule
        {
            get;set;
        }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public Employe(int matricule,string nom,string prenom, DateTime dateNaissance)
        {
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaissance = dateNaissance;
        }

        public override string ToString()
        {
            return "Employé N° " + Matricule + " nom: " + Nom + " ,prenom: " + Prenom + " ,né vers: " + DateNaissance;
        }
        public abstract void GetSalaire();
    }
}
