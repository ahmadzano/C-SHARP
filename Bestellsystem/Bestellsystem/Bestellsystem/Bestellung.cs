using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Bestellung
    {
        int Nummer { set; get; }
        DateTime Bestelldatum { set; get; }
        List<Bestellposition> Bestellpositionen { set; get; }
    }
}
