using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Adresse
    {
        public String Strasse { set; get; }
        List<String> zusaetzlicheInfo;
        public int Hausnummer { set; get; }
        public int PLZ { set; get; }
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
