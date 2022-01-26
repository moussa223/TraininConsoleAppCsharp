using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercle
{
    class Program
    {
        static void Main(string[] args)
        {

            Cercle a = new Cercle(6.25);
            a.GetArea();
            a.GetPerimeter();

            Console.ReadLine();
        }
    }
}
