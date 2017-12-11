using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class AuslandischerLieferant : Lieferant
    {
        String Land { set; get; }
        bool EUMitglied { set; get; }
    }
}
