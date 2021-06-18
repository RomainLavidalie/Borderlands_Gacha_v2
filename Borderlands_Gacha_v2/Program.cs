using System;

namespace Borderlands_Gacha
{
    internal class Program
    { 
        public static void Main(string[] args)
        {
            var rand = new Random();
            
            int currentLevel = 0;
            int level;
            int i = 1;
            
            string[] weaponManufacturer = { "Atlas", "CoV", "Dahl", "Hyperion", "Jakobs", "Maliwan", "Tediore", "Torgue", "Vladof" };
            string[] weaponType = { "Handgun", "Shotgun", "Assault Rifle", "SMG", "Sniper", "Heavy Weapon" };
            string[] weaponRarity = { "Common", "Uncommon", "Rare", "Very Rare" };
            
            int manufacturerPick;
            int typePick;
            int rarityPick;
            
            Console.WriteLine("Current level : ");
            currentLevel = Convert.ToInt32(Console.ReadLine());
            
            for (i = 0; i < 9; i++)
            {
                manufacturerPick = rand.Next(8);
                typePick = rand.Next(5);
                rarityPick = rand.Next(3);
                level = rand.Next(currentLevel - 5, currentLevel + 5);

                Console.WriteLine("Level {0} {1} {2} {3}\n", level, weaponRarity[rarityPick], weaponManufacturer[manufacturerPick], weaponType[typePick]);
            };
        }
    }
}