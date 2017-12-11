using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Bestellposition
    {
        Artikel Artikel { set; get; }
        Double Anzahl { set; get; }
        Lieferant Lieferant { set; get; }
        Double Einkaufspreis { set; get; }
        int Lieferziet { set; get; }
    }
}
