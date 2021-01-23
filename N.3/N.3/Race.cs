using System;
using Microsoft.VisualBasic;

namespace N._3
{
    public enum _Race
    {
        Elves,
        Dwarf,
        Human,
    }
    
    public class Race
    {
        private string Name;

        private int add_Health;
        private int add_Mana;
        private int add_Stamina;

        public Race(_Race race)
        {
            if (race == _Race.Elves)
            {
                add_Health = 30;
                add_Mana = 50;
                add_Health = 45;
                Name = "Elves";
            }
            else if(race == _Race.Dwarf)
            {
                add_Health = 55;
                add_Mana = 30;
                add_Stamina = 40;
                Name = "Dwarf";
            }
            else
            {
                add_Health = 45;
                add_Mana = 30;
                add_Stamina = 50;
                Name = "Human";
            }
        }

        public void Wyswietl()
        {
            Console.WriteLine("To jest: " + Name + "\n");
        }
    }
}