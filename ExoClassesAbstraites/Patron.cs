using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClassesAbstraites
{
    public class Patron:Employe
    {
        public double ChiffreAffaire { get; set; }
        public double Pourcentage { get; set; }
        public Patron(int matricule, string nom, string prenom, DateTime dateNaissance,double ChiffreAfaire,double pourcentage):base(matricule,nom,prenom,dateNaissance)
        {
            this.ChiffreAffaire = ChiffreAfaire;
            this.Pourcentage = pourcentage;
        }

        public override string ToString()
        {
            return base.ToString()+" est patron avec un Chiffre d'affaire = "+ ChiffreAffaire+" pourcentage= "+Pourcentage;
        }
        public override void GetSalaire()
        {
            double salaire = (ChiffreAffaire * Pourcentage) / 100;
            Console.WriteLine("Votre salaire en tant que patron est égale à: " + salaire);
        }

    }
}
