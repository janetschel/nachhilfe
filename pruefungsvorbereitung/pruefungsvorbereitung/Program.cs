using System;
using System.Globalization;
using System.IO;

namespace pruefungsvorbereitung
{
    enum Reifentyp { Sommer, Winter, Ganzjahr }
    
    class Reifen
    {
        string marke;
        int durchmesser;
        Reifentyp kategorie;

        public Reifentyp Kategorie
        {
            get
            {
                return this.kategorie;
            }
        }

        public int Durchmesser
        {
            get
            {
                return this.durchmesser;
            }
            set
            {
                if (value >= 10)
                {
                    durchmesser = value;
                }
                else
                {
                    throw new ArgumentException("Durchmesser mind. 10 Zoll");
                }
            }
        }

        public Reifen(string marke, int durchmesser, Reifentyp kategorie)
        {
            if (durchmesser >= 10)
            {
                this.marke = marke;
                this.durchmesser = durchmesser;
                this.kategorie = kategorie;
            }
            else
            {
                throw new ArgumentException("Durchmesser mind. 10 Zoll");
            }
        }

        // mit override auch ohne reifen1.ToString();
        public string ToString()
        {
            // Continental, Winter, 15 Zoll
            return $"{marke}, {kategorie}, {durchmesser} Zoll";
        }

        public int Angebote(Reifen[] vorhandeneReifen, Reifentyp gesuchteKategorie)
        {
            int count = 0;
            for (int i = 0; i < vorhandeneReifen.Length; i++)
            {
                if (vorhandeneReifen[i].Kategorie == gesuchteKategorie)
                {
                    count++;
                }
            }

            return count;
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            #region Strings sind CharArrays
            string test = "Hallo Welt";

            int count = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == 'l')
                {
                    count++;
                }
            }

            foreach (char current in test)
            {
                if (current == 'l')
                {
                    count++;
                }
            }
            #endregion

            #region Aufgabe 12
            #region Teilaufgabe 1
    
            string[] bestellung = { "S2", "V1", "H6", "V1", "H4", "H6", "D2" };
            Rechnung(bestellung);

            #endregion

            #region Teilaufgabe 2
            Console.WriteLine();

            Reifen reifen1 = new Reifen("Continental", 15, Reifentyp.Winter);
            Reifen reifen2 = new Reifen("Dunlop", 19, Reifentyp.Winter);
            Reifen reifen3 = new Reifen("Michelin", 17, Reifentyp.Ganzjahr);
            Reifen reifen4 = new Reifen("Michelin", 18, Reifentyp.Winter);

            Console.WriteLine(reifen1.ToString());
            Console.WriteLine(reifen2.ToString());
            Console.WriteLine(reifen3.ToString());
            Console.WriteLine(reifen4.ToString());
            Console.WriteLine();

            try
            {
                Reifen reifen5 = new Reifen("Continental", 5, Reifentyp.Winter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int ergebnis = reifen1.Angebote(new[] {reifen1, reifen2, reifen3, reifen4}, Reifentyp.Winter);
            Console.WriteLine($"Anzahl Reifen der Kategorie Winter: {ergebnis}");
            #endregion
            #endregion
        }

        static void Rechnung(string[] bestellung)
        {
            StreamReader sr = new StreamReader(@"../../../Speisekarte.txt");
            string zeile;
            double summe = 0;

            while (!sr.EndOfStream) // zeile = sr.ReadLine(); zeile != null
            {
                zeile = sr.ReadLine();
                // zeile = S2;Miso Suppe;2,90

                string[] einzelneElemente = zeile.Split(";");
                // einzelneElemente[0] = S2
                // einzelneElemente[1] = Miso Suppe
                // einzelneElemente[2] = 2,90

                int anzahl = 0;
                foreach (string element in bestellung)
                {
                    if (element == einzelneElemente[0])
                    {
                        anzahl++;
                    }
                }

                if (anzahl >= 1)
                {
                    double preis = anzahl * Convert.ToDouble(einzelneElemente[2]) / 100;
                    Console.WriteLine($"{anzahl}x {einzelneElemente[1]}: {preis:f2}");
                    summe += preis;
                }
            }

            Console.WriteLine($"Summe: {summe:f2}");
        }
    }
}