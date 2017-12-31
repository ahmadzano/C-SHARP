using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Bestellung
    {
        /// <summary> getter uns setter
        /// <retun>
        ///     int
        /// </retun>
        /// </summary>
        public int Nummer { set; get; }

        /// <summary> getter uns setter
        /// <retun>
        ///     DateTime
        /// </retun>
        /// </summary>
        public DateTime Bestelldatum { set; get; }

        /// <summery>
        /// <return>
        /// <list type="Bestellposition">
        /// <item type="Artikel">
        ///     Artikel
        /// </item>
        /// <item type="Double">
        ///     Anzahl
        /// </item>
        /// </list>
        /// </return>
        /// </summery>
        public List<Bestellposition> Bestellpositionen = new List<Bestellposition>();
    }
}
