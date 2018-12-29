using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragonbladecarecter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string cName, cClassChoice;
            string[] cClass = new string[4];
            cClass[0] = "Fighter";
            cClass[1] = "Cleric";
            cClass[2] = "Mage";
            cClass[3] = "Thief";
            Random stat = new Random();
            int Str, Int, Wis, Dex, Con, Cha, HP, Mana ;
            for (int dummy = 0; dummy < 100;)
            { 
            Console.Write("Character Name: ");
            cName = Console.ReadLine();
            Console.WriteLine(" Character Class: \n 0 - " + cClass[0] + "\n 1 - " + cClass[1] + "\n 2 - " + cClass[2] + "\n 3 - " + cClass[3]);
            cClassChoice = Console.ReadLine();
                int stat1 = stat.Next(1, 7), stat2 = stat.Next(1, 7), stat3 = stat.Next(1, 7), stat4 = stat.Next(1, 7);
                int lowStat= Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Str = stat1 + stat2 + stat3 + stat4 - lowStat;

                stat1 = stat.Next(1, 7); stat2 = stat.Next(1, 7); stat3 = stat.Next(1, 7); stat4 = stat.Next(1, 7);
                lowStat = Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Int = stat1 + stat2 + stat3 + stat4 - lowStat;

                stat1 = stat.Next(1, 7); stat2 = stat.Next(1, 7); stat3 = stat.Next(1, 7); stat4 = stat.Next(1, 7);
                lowStat = Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Wis = stat1 + stat2 + stat3 + stat4 - lowStat;

                stat1 = stat.Next(1, 7); stat2 = stat.Next(1, 7); stat3 = stat.Next(1, 7); stat4 = stat.Next(1, 7);
                lowStat = Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Dex = stat1 + stat2 + stat3 + stat4 - lowStat;

                stat1 = stat.Next(1, 7); stat2 = stat.Next(1, 7); stat3 = stat.Next(1, 7); stat4 = stat.Next(1, 7);
                lowStat = Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Con = stat1 + stat2 + stat3 + stat4 - lowStat;

                stat1 = stat.Next(1, 7); stat2 = stat.Next(1, 7); stat3 = stat.Next(1, 7); stat4 = stat.Next(1, 7);
                lowStat = Math.Min(Math.Min(stat1, stat2), Math.Min(stat3, stat4));
                Cha = stat1 + stat2 + stat3 + stat4 - lowStat;

                Console.WriteLine("Name: " + cName + "\nClass: " + cClass[Convert.ToInt32(cClassChoice)]);
            Console.WriteLine("Strength " + Str + "\nIntelligence " + Int + "\nWisdom " + Wis + "\nDexterity " + Dex + "\nConstitution " + Con + "\nCharisma " + Cha);
            Console.ReadLine();
        }
            
        }
    }
}
