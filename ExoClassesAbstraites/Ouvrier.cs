using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClassesAbstraites
{
    public class Ouvrier:Employe
    {
        
        public int DateEntreeEnSociete { get; set; }
        public Ouvrier(int matricule,string nom, string prenom,DateTime dateNaissance, int dateEntree):base(matricule,nom,prenom,dateNaissance)
        {
            this.DateEntreeEnSociete = dateEntree;
        }

        public override string ToString()
        {
            return base.ToString() + " est ouvrier et a commencé en " +DateEntreeEnSociete;
        }
        public override void GetSalaire()
        {
             int SMIG = 2500;
            int SalaireMensuel = SMIG + (2022 - DateEntreeEnSociete) * 100;
            Console.WriteLine("Votre salaire mensuel en tant qu'ouvrier est: " + SalaireMensuel);


        }
       
    }
}
