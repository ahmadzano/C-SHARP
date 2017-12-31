using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class NonFoodArtikel : Artikel
    {
        /// <summery> getter und setter
        /// <return>
        /// bool | void
        /// </return>
        /// </summery>
        public bool IstSperrgut { set; get; }
    }
}
