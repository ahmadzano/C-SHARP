using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Lager
    {
        private int Number { set; get; }
        private String Name { set; get; }

        public Lager(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
}
