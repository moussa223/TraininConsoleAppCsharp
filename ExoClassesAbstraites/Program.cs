using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoClassesAbstraites
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouvrier o = new Ouvrier(1123, "Karembe", "Moussa",DateTime.Parse("30/11/2001"), 2015);
            Cadre c = new Cadre(26534, "Sow", "Gallo", DateTime.Now, 3);
            Patron p = new Patron(1223, "Sis", "Seyba", DateTime.Now, 10000, 30);
            Console.WriteLine(o.ToString());
            o.GetSalaire();
            Console.WriteLine(c.ToString());
            c.GetSalaire();
            Console.WriteLine(p.ToString());
            p.GetSalaire();
            Console.Read();
        }
    }
}
