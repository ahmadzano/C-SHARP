using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class FoodArtikel: Artikel
    {
        /// <summery> getter und setter
        /// <return>
        ///     DateTime
        /// </return>
        /// </summery>
        DateTime HaltbarkeitsDauer { set; get; }

        /// <summery> getter und setter
        /// <return>
        ///     String
        /// </return>
        /// </summery>
        String Kuehlungsart { set; get; }
    }
}
