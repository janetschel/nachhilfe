using System;

namespace ConsoleApp1
{
    public class Aufgabe3
    {
        static void Main()
        { 
            Console.Write("Gib mir eine Zahl: ");
            string input = Console.ReadLine();    // "123"
            char[] array = input.ToCharArray();   // {'1', '2', '3'}

            int result = Berechnen(array);
            Console.WriteLine(result);
        }

        static int Berechnen(char[] array)
        {
            int summe = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                int charToInt = Convert.ToInt32(array[i].ToString());
                summe += charToInt;
            }

            return summe;
        }
    }
}