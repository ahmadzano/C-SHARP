using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    abstract class Artikel
    {
        public int Nummer { set; get; }
        public String Bezeichnung { set; get; }
        public String Verpackungsatr { set; get; }
        public Double Lagerstand { set; get; }
        public Double LagerMidestBestand { set; get; }
        public List<Lager> lager;
        public Lieferkondition Lieferkondition { set; get; }
    }
}
