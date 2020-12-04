using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 2, 1};

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        Console.WriteLine("Duplikat in Liste");
                        return;
                    }
                }
            }

            Console.WriteLine("Keine Duplikate in der List enthalten");
        }
    }
}