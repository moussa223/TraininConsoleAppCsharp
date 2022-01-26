using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cercle
{
    public class Cercle
    {
        public double Area { get; set; }
        public double Perimetre { get; set; }
        public double Rayon { get; set; }
        public Cercle(double rayon)
        {
            this.Rayon = rayon;
            
        }
        public void GetArea()
        {
            double Area = 3.14 * Rayon * Rayon;
            Console.WriteLine(Area);
        }
        public void GetPerimeter()
        {
            double perimeter = 3.14 * 2 * Rayon;
            Console.WriteLine(perimeter);
        }
        
    }
}
