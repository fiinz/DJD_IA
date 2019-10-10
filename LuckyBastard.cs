/*jaime fins - Introdução à Algoritmia */
using System;

namespace Geegee {
    /// <summary>
    //# luckybastard
    //Create an algorithm that simulates a player with a 100 Health Points that will suffer three random powered attacks that will leave him with only 1 health point. The algorithm should output "lucky"
    /// </summary>
    class Program {
        static void Main (string[] args) 
        {
            Random r = new Random();
            int maxHealth=100;
            int currentHealth=maxHealth;
            int blow;

            //multiplying the random using currentHealth by 0.98 we ensure
            //that 3 attacks will always be possible
            //keep in mind that the random excludes the last value

            //ATTACK 01 
            Console.WriteLine("------------FIRST ATTACK ------------------");
            blow= (int)(r.Next(1,(int)(currentHealth*0.98f))); // it assigns a random value to blow 0 to MaxHealth ( exclusevely),
            Console.WriteLine("* You were hit by an enemy for "+blow+" damage");
            currentHealth=currentHealth-blow;
            Console.WriteLine("* You current life "+currentHealth+"!");
            Console.WriteLine(""); //break
  
            //ATTACK 02 
            println("-------------SECOND ATTACK ----------------");
            blow= (int)(r.Next(1,(int)(currentHealth*0.98f))); // it assigns a random value to blow 0 to MaxHealth ( exclusevely),
            Console.WriteLine("* You were hit by an enemy for "+blow+" damage");
            currentHealth=currentHealth-blow;
            Console.WriteLine("* You current life "+currentHealth+"!");
            Console.WriteLine(""); //break

            //ATTACK 03
            println("-------------THIRD ATTACK -----------------");
            blow= (int)currentHealth-1; // the final blow should be the currentHealth except the 1 HP 
            Console.WriteLine("* You were hit by an enemy for "+blow+" damage");
            currentHealth=currentHealth-blow;
            Console.WriteLine("You remained with "+currentHealth+"HP!Lucky Bastard!");
            Console.WriteLine(""); //break
            
        }
    }
}