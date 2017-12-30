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
        int Nummer { set; get; }

        /// <summary> getter uns setter
        /// <retun>
        ///     DateTime
        /// </retun>
        /// </summary>
        DateTime Bestelldatum { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// <list type="Lager">
        /// <item type="Artikel">
        ///     Artikel
        /// </item>
        /// <item type="Double">
        ///     Anzahl
        /// </item>
        /// </list>
        /// </return>
        /// </summery>
        List<Bestellposition> Bestellpositionen { set; get; }
    }
}
