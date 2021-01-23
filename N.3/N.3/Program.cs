using System;

namespace N._3
{
    class Program
    {
        static void Main()
        {
            bool check = true;

            while (check == true)
            {
                Console.WriteLine("Wybierz Klase:");
                Console.WriteLine("1.Elf");
                Console.WriteLine("2.Krasnolud");
                Console.WriteLine("3.Człowiek");
                Console.WriteLine("4.EXIT");
                int choice;
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Race elf = new Race(_Race.Elves);
                    elf.Wyswietl();
                }
                else if (choice == 2)
                {
                    Race krasnal = new Race(_Race.Dwarf);
                    krasnal.Wyswietl();
                }
                else if (choice == 3)
                {
                    Race czlek = new Race(_Race.Human);
                    czlek.Wyswietl();
                }
                else if (choice == 4)
                {
                    check = false;
                }
                else
                {
                    Console.WriteLine("Błędne Dane");
                }
            }
        }
    }
}