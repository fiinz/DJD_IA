/*jaime fins - Introdução à Algoritmia */
using System;

namespace Vegito {
    /// <summary>
    /// # vegito 
    /// Create an algorithm that simulates a fusion between two game characters, 
    /// in which their attack,defenses, intelected are combined into their average. 
    /// The program should output their their fused stats.   
    /// </summary>
    class Program {
        static void Main (string[] args) 
        {
            Random r = new Random (); //creates a Random object

            /* character 1 stats  */
            int attack1 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable
            int intelect1 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable
            int defense1 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable

            /* character 2 stats  */
            int attack2 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable
            int intelect2 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable
            int defense2 = r.Next (1, 100); //generates a random number between 1 and 100 and assigns to the variable

            /* character 3 - Fusion - stats  */
            Console.WriteLine("Fusion");
            Console.WriteLine("Attack: "+(attack1+attack2)/2);
            Console.WriteLine("Intelect"+(intelect1+intelect2)/2);
            Console.WriteLine("Defense"+(defense1+defense2)/2);


        }
    }
}