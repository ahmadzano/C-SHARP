using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kugelberechnung
{
    class Kugelberechnung
    {
        double radius;
        double umfang;
        double oeberflaeche;

        public Kugelberechnung(double radius)
        {
            this.radius = radius;
            this.calculateUmfang();
            this.calculateOeberflaeche();
        }

        private void calculateUmfang()
        {
            this.umfang = this.radius * 2;
        }

        private void calculateOeberflaeche()
        {
            this.oeberflaeche = this.radius * this.radius;
        }

        public double getUmfang()
        {
            return this.umfang;
        }

        public double getOeberflaeche()
        {
            return this.oeberflaeche;
        }

    }
}
