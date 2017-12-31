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
        /// <returns>
        ///     DateTime
        /// </returns>
        /// </summery>
        public DateTime HaltbarkeitsDauer { set; get; }

        /// <summery> getter und setter
        /// <returns>
        ///     String
        /// </returns>
        /// </summery>
        public String Kuehlungsart { set; get; }
    }
}
