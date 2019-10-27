using System;

namespace BetweenWalls
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
        // we randomize two positions
        int limit01=(int)random(0, 20);
        int limit02=(int)random(0, 20);
        int temp; 
            // however because we need to know what is the lowest limit we need to compare the limits
            //and switch them
        if (limit01>limit02) 
        {
            temp=limit01; 
            limit01=limit02;
            limit02=temp;
        }


        /* a different trick to solve it would be to use the first limit as 
         the minimum value of the second random
         
         int limit01=(int)random(0, 501-3); // we removed 3 numbers to ensure that the first limit would give space between limits
         int limit02=(int)random(limit01, 501); // we sh
         
         */

        Console.WriteLine ("A imprimir valores de: "+limit01+" até "+limit02);
        for ( int i=limit01; i<=limit02; i++)
        {
            Console.WriteLine("valor "+i);
        }
    }
}