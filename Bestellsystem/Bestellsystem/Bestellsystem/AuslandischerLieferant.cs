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
        bool IstVonEU { set; get; }

        public AuslandischerLieferant(int id, String name, int telefonNummer, String land, bool istVonEU) : base( id, name, telefonNummer)
        {
            this.Land = land;
            this.IstVonEU = istVonEU;
        }
    }
}
