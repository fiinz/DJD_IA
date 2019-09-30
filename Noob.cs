using System;
/* Jaime Fins 2019*/

namespace Noob
{
    // #LetTheGamesBegin
    /// <summary>Create an algorithm that defines and stores Player's nickname and it says "You’re such a Noob #Fiinz!
   // It's always good to have newbies around here!". Being #Fiinz, in this case,  the selected, name of the Player
    // <see cref="System.Console.WriteLine(System.String)"/> for information about output statements
    /// </summary>
    
    class Program
    {
        static void Main(string[] args)  
        {
            String nickname="#fiinz"; // write your nickname here
            
            //concatenation 
            // Concatenate, concatenation, or concat is a term that describes combining a string,
            // text, or other data in a series without any gaps
            System.Console.WriteLine(You’re such a Noob"+nickname+"! \n It's always good to have newbies around here!");
             // alternative 
             //System.Console.WriteLine(You’re such a Noob {0} \n It's always good to have newbies around here!", nickname );
         
        }
    }
}
