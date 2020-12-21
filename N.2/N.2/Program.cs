using System;

namespace N._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[10];
            string a;

            for (int i = 0; i < 10; i++)
            {
                a = Console.ReadLine();
                bool CheckA = int.TryParse(a, out _);
                
                if (CheckA == true) 
                { 
                    tab[i] = int.Parse(a);
                }
                else 
                {
                    Console.WriteLine("To nie jest liczba");
                    Console.WriteLine("Podaj Jeszcze raz ale liczbe:");
                    a = Console.ReadLine();
                    tab[i] = int.Parse(a);
                }
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("tab[" + j + "] = " + tab[j]);
            }
        }
    }
}