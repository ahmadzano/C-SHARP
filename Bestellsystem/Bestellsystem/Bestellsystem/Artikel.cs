using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    abstract class Artikel
    {
        /// <summery> getter und setter
        /// <return>
        /// int | void
        /// </return>
        /// </summery>
        public int Nummer { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// String | void
        /// </return>
        /// </summery>
        public String Bezeichnung { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// String | void
        /// </return>
        /// </summery>
        public String Verpackungsart { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// Double | void
        /// </return>
        /// </summery>
        public Double Lagerstand { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// Double | void
        /// </return>
        /// </summery>
        public Double LagerMidestBestand { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// <list type="Lager">
        /// <item type="int">
        ///     Nummer
        /// </item>
        /// <item type="String">
        ///     Name
        /// </item>
        /// </list>
        /// </return>
        /// </summery>
        public List<Lager> lager = new List<Lager>();

        /// <summary> getter und setter
        /// <return>
        /// Lieferkondition
        /// </return>
        /// </summary>
        public Lieferkondition Lieferkondition { set; get; }
    }
}
