/*jaime fins - Introdução à Algoritmia */
using System;

namespace ForAzeroth {
    /// <summary>
    //# forAzeroth
    //Create an algorithm that defines a World of Warcraft character. 
    //The character should have a  specific nickname, level, race, gender (char), faction ( "Alliance", "Horde") and his class ( "Mage", "Warrior" or "Hunter). 
    //The algorithm should print the character's data in a formatted way.  All the code should be commented, in English, explaining what is being done on each line.
    /// </summary>
    class Program {
        static void Main (string[] args) 
        {
            //variable player Name
            string  characterName="Athene";
            char gender='m';
            int level =120;
            string faction="Alliance";
            string charClass="Mage"; // can't use the name class for the variable cause its reserved
   
            Console.WriteLine("--------- CHARACTER DETAILS -----------");
            Console.WriteLine("* Character Name:"+characterName);
            Console.WriteLine("* Character Gender:"+gender);
            Console.WriteLine("* Character Faction:"+faction);
            Console.WriteLine("* Character Class:"+charClass); 
            Console.WriteLine("* Character Level:"+level);   
            Console.WriteLine("----------------------------------------");
        }
    }
}