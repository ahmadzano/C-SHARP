using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lager
    {
        /// <summery> getter und setter
        /// <return>
        ///     int
        /// </return>
        /// </summery>
        public int Nummer { set; get; }

        /// <summery> getter und setter
        /// <return>
        ///     String
        /// </return>
        /// </summery>
        public String Name { set; get; }

        public Lager(int number, string name)
        {
            this.Nummer = number;
            this.Name = name;
        }
    }
}
