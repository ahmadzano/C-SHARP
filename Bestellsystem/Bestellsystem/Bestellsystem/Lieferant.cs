using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lieferant
    {
        /// <summery> getter und setter
        /// <return>
        ///     int
        /// </return>
        /// </summery>
        public int Id { set; get; }

        /// <summery> getter und setter
        /// <return>
        ///     String
        /// </return>
        /// </summery>
        public String Name { set; get; }

        /// <summery> getter und setter
        /// <return>
        ///     int
        /// </return>
        /// </summery>
        public int Telefonnummer { set; get; }

        /// <summery> Liste von Adressen Instazen
        /// <return>
        /// <list type="Adresse">
        /// <item type="String">
        ///     Strasse
        /// </item>
        /// <item type="int">
        ///     Hausnummer
        /// </item>
        /// <item type="int">
        ///     PLZ
        /// </item>
        /// <item type="Ort">
        ///     Ort
        /// </item>
        /// </list>
        /// </return>
        /// </summery>
        public List<Adresse> adressen;

        public Lieferant(int id, String name, int telefonNummer)
        {
            this.Id = id;
            this.Name = name;
            this.Telefonnummer = telefonNummer;
        }
    }
}
