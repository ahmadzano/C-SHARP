using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWSBecherner

{
    class MWSBecherner
    {
        static void Main(string[] args)
        {
            double bruttoPreis = 200.00;
            MWSCalculator mws = new MWSCalculator(bruttoPreis);
            Console.WriteLine(mws.getMWS());
            Console.ReadLine();
        }
    }
}
