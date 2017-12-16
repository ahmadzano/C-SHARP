using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lieferkondition
    {
        public Lieferant Lieferant { set; get; }
        public Double Einkaufspreis { set; get; }
        public DateTime Lieferzeit { set; get; }
    }
}
