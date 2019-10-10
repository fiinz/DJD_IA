/*jaime fins - Introdução à Algoritmia */
using System;

namespace Frostmourne {
    /// <summary>
    //# forAzeroth
   // Create an algorithm that defines a World of Warcraft character. 
    //The character should have a  specific nickname, level, race, gender (char), faction ( "Alliance", "Horde") and his class ( "Mage", "Warrior" or "Hunter). 
    //The algorithm should print the character's data in a formatted way.  All the code should be commented, in English, explaining what is being done on each line.
    /// </summary>
    class Program {
        static void Main (string[] args) 
        {
            
            //variable player Name
            string  weaponName="Ashbringer";
            string  description="An Undead Killing Machine Forged with Holy";   
            int damage=100;
            bool twohand=true;
            string rarity="Epic";
            string targetClass="Paladin"; // can't use the name class for the variable cause its reserved

            Console.WriteLine("--------- WEAPON DETAILS -----------");
            Console.WriteLine("* Weapon Name:"+weaponName);
            Console.WriteLine("* Weapon Description:"+description);
            Console.WriteLine("* Weapon Target Class:"+targetClass); 
            Console.WriteLine("* Weapon Rarity:"+rarity); 
            Console.WriteLine("* Weapon Damage:"+damage);
            Console.WriteLine("* Weapon TwoHanded:"+twohand);   
            Console.WriteLine("----------------------------------------");
        }
    }
}