using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datei();
            // Static Felder zum Zählen:
            Auto bmw = new Auto("bmw", "rot");
            Console.WriteLine(Auto.count);
            
            Auto audi = new Auto("audi", "gelb");
            Console.WriteLine(Auto.count);

        }

        static void Datei()
        {
            // Lesen und Schreiben einer Datei
            StreamReader sr = new StreamReader("test.txt");
            string zeile = sr.ReadLine();

            while (zeile != null)
            {
                Console.WriteLine(zeile);
                zeile = sr.ReadLine();
            }

            StreamWriter sw = new StreamWriter("test2.txt");
            sw.WriteLine("Hallo hallo");
            sw.Close();
        }
    }

    class Auto
    {
        public static int count = 0;
        
        public string marke;
        public string farbe;

        public Auto(string marke, string farbe)
        {
            this.marke = marke;
            this.farbe = farbe;

            Auto.count++;
        }

        public void Fahren()
        {
            // Objektmethode, weil kein static
        }

        public static void GebenAnzahlAus()
        {
            // Klassenmethode
        }
    }
}