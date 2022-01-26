using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraininConsoleAppCsharp
{
    public class Chef:Employe
    {
        public string Service { get; set; }
        public Chef(string nom,string prenom, string dateNaissance,double salaire,string service):base(nom,prenom,dateNaissance,salaire)
        {
            this.Service = service;

        }
        public override void Afficher()
        {
            Console.WriteLine("Je suis le chef "+Nom+" "+Prenom+" né en "+DateNaissance+" "+" salaire = "+Salaire+" dans le service "+Service);
        }

    }
}
