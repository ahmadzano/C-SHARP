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

            // Lager info Ausgabe
            GibausLagerInfo(ostenLager);
            GibausLagerInfo(westenLager);


            //Lieferanten Objekte mit Adressenanlegen
            Adresse adress_1 = new Adresse("Kebap Allee", 112, 10001, "Berlin");
            Lieferant lieferant_1 = new Lieferant(100, "Lieferando GmbH", 305533);
            lieferant_1.adressen.Add(adress_1);

            Adresse adress_2 = new Adresse("Döner Platz", 5, 1995, "Berlin");
            Lieferant lieferant_2 = new Lieferant(101, "Lieferfast UG", 303399);
            lieferant_2.adressen.Add(adress_2);
            //Ausländische Lieferanten
            Adresse adress_3 = new Adresse("High Street", 573, 80411, "London");
            Lieferant lieferant_3 = new AuslandischerLieferant(102, "Lieferfast LTD", 303399, "Groß Britannien", true);
            lieferant_3.adressen.Add(adress_3);

            Adresse adress_4 = new Adresse("Cada Azadi", 22, 52, "Qamishlo");
            Lieferant lieferant_4 = new AuslandischerLieferant(103, "Çomerîo EG", 52753212, "Syrien", false);
            lieferant_4.adressen.Add(adress_4);

            // Lieferant info Ausgabe
            GibausLieferantenInfo(lieferant_1);
            GibausLieferantenInfo(lieferant_2);
            GibausLieferantenInfo(lieferant_3);
            GibausLieferantenInfo(lieferant_4);


            //NonFoodArtikel 1 Objekte Instanz
            NonFoodArtikel beton = new NonFoodArtikel
            {
                Nummer = 385,
                Bezeichnung = "Beton",
                Verpackungsart = null,
                Lagerstand = 5,
                LagerMidestBestand = 2
            };
            beton.lager.Add(westenLager);
            beton.IstSperrgut = true;

            //NonFoodArtikel 2 Objekte Instanz
            NonFoodArtikel stuhl = new NonFoodArtikel
            {
                Nummer = 85,
                Bezeichnung = "AD22 Stuhl",
                Verpackungsart = null,
                Lagerstand = 600,
                LagerMidestBestand = 150
            };
            stuhl.lager.Add(westenLager);
            stuhl.IstSperrgut = true;

            //FoodArtikel 1 Objekte Instanz
            FoodArtikel Apfel = new FoodArtikel
            {
                Nummer = 410,
                Bezeichnung = "Roter Apfel",
                LagerMidestBestand = .5,
                Lagerstand = 2.5,
                Verpackungsart = "Frischhaltefolie"
            };
            Apfel.lager.Add(ostenLager);
            Apfel.Kuehlungsart = "keine";
            Apfel.HaltbarkeitsDauer = new DateTime(2018, 03, 01);

            //FoodArtikel 2 Objekte Instanz
            FoodArtikel kartoffelsaft = new FoodArtikel
            {
                Nummer = 112,
                Bezeichnung = "Bio Kartoffelsaft",
                LagerMidestBestand = 200,
                Lagerstand = 320,
                Verpackungsart = "Karton 40cm x 75cm"
            };
            kartoffelsaft.lager.Add(ostenLager);
            kartoffelsaft.Kuehlungsart = "-2 C";
            kartoffelsaft.HaltbarkeitsDauer = new DateTime(2020, 01, 01);

            Bestellung bestellung_1 = new Bestellung
            {
                Nummer = 33,
                Bestelldatum = DateTime.Now
            };

            Bestellposition bestelposition_1 = new Bestellposition
            {
                Anzahl = 1,
                Artikel = beton
            };
            bestellung_1.Bestellpositionen.Add(bestelposition_1);


            Bestellung bestellung_2 = new Bestellung
            {
                Nummer = 69,
                Bestelldatum = DateTime.Now
            };

            Bestellposition bestelposition_2 = new Bestellposition
            {
                Anzahl = 1,
                Artikel = stuhl
            };
            bestellung_2.Bestellpositionen.Add(bestelposition_2);

            Bestellposition bestelposition_2_1 = new Bestellposition
            {
                Anzahl = 3,
                Artikel = Apfel
            };
            bestellung_2.Bestellpositionen.Add(bestelposition_2_1);

            Bestellposition bestelposition_2_2 = new Bestellposition
            {
                Anzahl = 75,
                Artikel = kartoffelsaft
            };
            bestellung_2.Bestellpositionen.Add(bestelposition_2_2);

            //Ausgabe der Bestellungen
            GibausBestellungsInfo(bestellung_1);
            GibausBestellungsInfo(bestellung_2);

            System.Console.ReadKey();
        }

        static void GibausLagerInfo(Lager lager)
        {
            System.Console.WriteLine("Lager Nummer: {0}", lager.Nummer);
            System.Console.WriteLine("Lager Name: {0}", lager.Name);
            System.Console.WriteLine();
        }
        static void GibausLieferantenInfo(Lieferant lieferant)
        {
            System.Console.WriteLine("Lieferanten ID: {0}", lieferant.Id);
            System.Console.WriteLine("Lieferantenname: {0}", lieferant.Name);
            System.Console.WriteLine("Lieferantentelefonnummer: {0}", lieferant.Telefonnummer);
            System.Console.WriteLine("LieferantenAdresse: {0} .{1}, {2} {3}", 
                lieferant.adressen.First().Strasse,
                lieferant.adressen.First().Hausnummer,
                lieferant.adressen.First().PLZ,
                lieferant.adressen.First().Ort
                );

            var type = lieferant.GetType();
             
            if (type.GetProperty("Land") != null)
            {
                string EU = lieferant.GetType().GetProperty("IstVonEU").GetValue(lieferant, null).ToString();
                if ( EU == "True")
                {
                    System.Console.WriteLine("Aus EU");
                } else
                {
                    System.Console.WriteLine("Nicht aus EU");
                }

                System.Console.WriteLine("Lieferantenland: {0}", lieferant.GetType().GetProperty("Land").GetValue(lieferant, null).ToString());
            }
            System.Console.WriteLine();
        }

        static void GibausBestellungsInfo(Bestellung bestellung)
        {

            System.Console.WriteLine("Bestellung:");
            System.Console.WriteLine("Bestellungsnummer: {0}", bestellung.Nummer);
            System.Console.WriteLine("Bestelldatum: {0}", bestellung.Bestelldatum);

            System.Console.WriteLine("Anzahl des Artiekles: {0}", bestellung.Bestellpositionen.First().Anzahl);

            foreach (Bestellposition bestellposition in bestellung.Bestellpositionen)
            {

                Artikel artikel = bestellposition.Artikel;
                System.Console.WriteLine("Artikelsnummer: {0}",artikel.Nummer);
                System.Console.WriteLine("Bezeichnung: {0}", artikel.Nummer);
                System.Console.WriteLine("Verpackung: {0}", artikel.Verpackungsart);
                System.Console.WriteLine("Lager Midestbestand: {0}", artikel.LagerMidestBestand);
                System.Console.WriteLine("Lagerstand: {0}", artikel.Lagerstand);
                System.Console.WriteLine("Lagernummer: {0}, Lagername: {1}",
                    artikel.lager.First().Nummer,
                    artikel.lager.First().Name
                    );
                System.Console.WriteLine("Lieferkondistion:");
                //System.Console.WriteLine("LieferantenID: {0}", artikel.Lieferkondition.Lieferant.Id);
                //System.Console.WriteLine("Lieferantenname: {0}", artikel.Lieferkondition.Lieferant.Name);
                //System.Console.WriteLine("Einkaufspreis: {0}", artikel.Lieferkondition.Einkaufspreis);
                //System.Console.WriteLine("Lieferzeit: {0}", artikel.Lieferkondition.Lieferzeit);

                if (artikel.GetType().GetProperty("IstSperrgut") != null)
                {
                    string istSperrgut = artikel.GetType().GetProperty("IstSperrgut").GetValue(artikel, null).ToString();
                    if (istSperrgut == "True")
                    {
                        System.Console.WriteLine("Artikel ist Sperrgut");
                    }
                    else
                    {
                        System.Console.WriteLine("Artikel ist kein Sperrgut");
                    }
                }

                if (artikel.GetType().GetProperty("Kuehlungsart") != null)
                {
                    System.Console.WriteLine("Haltbar bis: {0}", artikel.GetType().GetProperty("HaltbarkeitsDauer").ToString());
                    System.Console.WriteLine("Kuehlungsart: {0}", artikel.GetType().GetProperty("Kuehlungsart").ToString());
                }

                System.Console.WriteLine();
            }
        }
    }
}
