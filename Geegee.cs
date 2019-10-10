/*jaime fins - Introdução à Algoritmia */
using System;

namespace Geegee {
    /// <summary>
    //# geegeee
    //Create an algorithm that simulates a player that starts the game with 100 Health Points but its loses all of his HP in a Single Blow. At the End of the algorithm is should output the message “gg".
    /// </summary>
    class Program {
        static void Main (string[] args) 
        {
            int maxHealth=100;
            //the trick was to assign the maximum health to the blow 
            //so it would reduce the player's life to zero.
            int blow=maxHealth;
            Console.WriteLine("You were hit by an enemyfor"+blow+" damage"); // outputs a message
            maxHealth-=blow; //it applies de damage into the player by reducing his life
            Console.WriteLine("gg"); // outputs gee gee
        }
    }
}