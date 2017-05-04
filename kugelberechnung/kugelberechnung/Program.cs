using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kugelberechnung
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 6;
            Kugelberechnung kugel = new Kugelberechnung(radius);
            Console.WriteLine(kugel.getUmfang());
            Console.WriteLine(kugel.getOeberflaeche());
            Console.ReadLine();

        }
    }
}
