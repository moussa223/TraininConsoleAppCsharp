using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClassesAbstraites
{
    public class Cadre:Employe
    {
        public int indice { get; set; }
        public Cadre(int matricule,string nom, string prenom,DateTime DateNaissance,int indice):base(matricule,nom,prenom,DateNaissance)
        {
            this.indice = indice;
        }
        public override string ToString()
        {
            return base.ToString()+" est Cadre ayant l'indice: "+indice;
        }
        public override void GetSalaire()
        {
            if (indice==1)
            {
                Console.WriteLine("Votre salaire mensuel est 13 000 DH car vous êtes un cadre avec index étant à 1");
            }
            else if(indice==2){
                Console.WriteLine("Votre salaire mensuel est 15 000 DH car vous êtes un cadre avec index étant à 2");
            }
            else if (indice == 3)
            {
                Console.WriteLine("Votre salaire mensuel est 17 000 DH car vous êtes un cadre avec index étant à 3");
            }
            else if (indice == 4)
            {
                Console.WriteLine("Votre salaire mensuel est 20 000 DH car vous êtes un cadre avec index étant à 4");
            }
            else
            {
                Console.WriteLine("Vous n êtes pas un cadre petit malin :) !");
            }
        }
    }
}
