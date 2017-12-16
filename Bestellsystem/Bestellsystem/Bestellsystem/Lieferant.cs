using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lieferant
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public int Telefonnummer { set; get; }
        public List<Adresse> adressen;

        public Lieferant(int id, String name, int telefonNummer)
        {
            this.Id = id;
            this.Name = name;
            this.Telefonnummer = telefonNummer;
        }
    }
}
