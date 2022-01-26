using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraininConsoleAppCsharp
{
    class Program
    {
        static void Main(string[] args)
        {


            
             // Correction Exercice: Polymorphisme- La classe Personne https://www.exelib.net/csharp-poo/polymorphisme-la-classe-personne.html
            
             Personne employer1 = new Employe("roze","april","123",11.12);
             Personne employer2 = new Employe("ghost", "ghost", "2", 12.12);
             Personne employer3 = new Employe("mace", "shadow", "3", 13.12);
             Personne employer4 = new Employe("zane", "shadow", "4", 14.12);
             Personne employer5 = new Employe("milsim", "milsim", "5", 15.12);
             Personne chef1 = new Chef("Marcus", "Ortega", "6", 16.12, "comptable");
             Personne chef2 = new Chef("cyril", "White", "6", 16.13, "Numérique");
             Personne[] tableau = new Personne[7];
             tableau[0] =employer1;
             tableau[1] = employer2;
             tableau[2] = employer3;
             tableau[3] = employer4;
             tableau[4] = employer5;
             tableau[5] = chef1;
             tableau[6] = chef2;
            
            // parcourir le tableau avec une boucle for pour afficher la méthode afficher de chaque instance
            /*
            for (var i=0;i<tableau.Length;i++)
            {
                tableau[i].Afficher();
            }
            */
            //parcourir le tableau avec une instruction foreach
            
            foreach (var el in tableau)
            {
                el.Afficher();
            }

            Console.Read();
           



        }

    }
}
