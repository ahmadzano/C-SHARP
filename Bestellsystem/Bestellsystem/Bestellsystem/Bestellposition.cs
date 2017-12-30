using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Bestellposition
    {
        /// <summery> getter und setter
        /// <return>
        ///     Artikel
        /// </return>
        /// </summery>
        Artikel Artikel { set; get; }

        /// <summary> getter uns setter
        /// <retun>
        ///     Double
        /// </retun>
        /// </summary>
        Double Anzahl { set; get; }
    }
}
