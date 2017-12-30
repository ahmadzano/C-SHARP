using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Adresse
    {
        /// <summary> getter und setter
        /// Getters und Setters
        /// <return>
        /// String | void
        /// </return>
        /// </summary>
        public String Strasse { set; get; }

        /// <summery> Liste von zusaetzlicheInfo
        /// <return>
        /// <list type="String">
        /// <item>
        ///     String
        /// </item>
        /// </list>
        /// </return>
        /// </summery>
        List<String> zusaetzlicheInfo;

        /// <summer> getter und setter
        /// <return>
        /// int | void
        /// </return>
        /// </summer>
        public int Hausnummer { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// int | void
        /// </return>
        /// </summery>
        public int PLZ { set; get; }

        /// <summery> getter und setter
        /// <return>
        /// String | void
        /// </return>
        /// </summery>
        public String Ort { set; get; }

        public Adresse(String strasse, int hausnummer, int plz, String ort)
        {
            this.Strasse = strasse;
            this.Hausnummer = hausnummer;
            this.PLZ = plz;
            this.Ort = ort;
        }
    }
}
