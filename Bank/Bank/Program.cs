using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IFinanztransfer
    {
        void einzahlen(double betrag);

        bool auszahlen(double betrag);
    }

    abstract  class Konto : IFinanztransfer
    {
        protected double kontostand { get; set; }
        protected double habenzins { get; set; }
        public double Kontostand { get; }

        public Konto (double betrag, double habenzins) {}
        abstract public void einzahlen(double betrag);

        abstract public bool auszahlen(double betrag);

        abstract public void verzinsen();

    }

    class Spar : Konto
    {
        public Spar(double betrag, double habenzins) : base( betrag, habenzins)
        {
            
        }

        override public bool auszahlen(double betrag)
        {
            return true;
        }
        override public void einzahlen(double betrag)
        {
            
        }

        override public void verzinsen()
        {
            
        }
    }

    class Giro : Konto
    {
        private double disporahmen;
        private double zollzins;
        public Giro(double betrag, double habenzins, double zollzins, double disporahmen) : base(betrag, habenzins)
        {
            this.zollzins = zollzins;
            this.disporahmen = disporahmen;
        }

        override public bool auszahlen(double betrag)
        {
            return true;
        }
        override public void einzahlen(double betrag)
        {

        }

        override public void verzinsen()
        {

        }
    }
}
