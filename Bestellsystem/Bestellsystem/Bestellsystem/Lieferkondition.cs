using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lieferkondition
    {
        /// <summery> getter und setter
        /// <return>
        /// Lieferant | void
        /// </return>
        /// </summery>
        public Lieferant Lieferant { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// Double | void
        /// </return>
        /// </summery>
        public Double Einkaufspreis { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// DateTime | void
        /// </return>
        /// </summery>
        public DateTime Lieferzeit { set; get; }
    }
}
