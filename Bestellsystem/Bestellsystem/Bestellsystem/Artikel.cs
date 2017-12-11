using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    abstract class Artikel
    {
        int Nummer { set; get; }
        String Bezeichnung { set; get; }
        String Verpackungsatr { set; get; }
        Double Lagerstand { set; get; }
        Double LagerMidestBestand { set; get; }
        Lager Lager { set; get; }

    }
}
