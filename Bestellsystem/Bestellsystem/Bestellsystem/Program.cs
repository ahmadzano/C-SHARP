using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lager Objekte anlegen
            Lager ostenLager = new Lager(28, "Osten Lager");
            Lager westenLager = new Lager(30, "Westen Lager");

            //Lieferanten Objekte mit Adressenanlegen
            Adresse adress_1 = new Adresse("Kebap Allee", 112, 10001, "Berlin");
            Lieferant lieferant_1 = new Lieferant(100, "Lieferando GmbH", 305533);
            lieferant_1.adressen.Add(adress_1);

            Adresse adress_2 = new Adresse("Döner Platz", 5, 1995, "Berlin");
            Lieferant lieferant_2 = new Lieferant(101, "Lieferfast UG", 303399);
            lieferant_2.adressen.Add(adress_2);
            //Ausländische Lieferanten
            Adresse adress_3 = new Adresse("High Street", 573, 80411, "London");
            Lieferant lieferant_3 = new AuslandischerLieferant(102, "Lieferfast LTD", 303399, "Groß Britannien", false);
            lieferant_3.adressen.Add(adress_3);

            Adresse adress_4 = new Adresse("Cada Azadi", 22, 52, "Qamishlo");
            Lieferant lieferant_4 = new AuslandischerLieferant(103, "Çomerîo EG", 52753212, "Syrien", false);
            lieferant_4.adressen.Add(adress_4);


        }
    }
}
