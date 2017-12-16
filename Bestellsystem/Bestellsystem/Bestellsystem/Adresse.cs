using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Adresse
    {
        String Strasse { set; get; }
        List<String> zusaetzlicheInfo;
        int Hausnummer { set; get; }
        int PLZ { set; get; }
        String Ort { set; get; }
    }
}
