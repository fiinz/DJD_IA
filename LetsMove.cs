using System;

namespace LetsMove
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Random r = new Random();
            int startX=0;
            int startY=0;

            int currentX=startX;
            int currentY=startY;

            //simulating for a map of 20 cells x 20 cells
            int targetX=(int)r.Next(0, 20);
            int targetY=(int)r.Next(0, 20);


            //the L approach : the player will move  horizontally and then vertically
            //pay notice that i didnt initialize the currentX inside the cycle
            Console.WriteLine("target x: "+targetX);
            for ( currentX=startX; currentX<=targetX; currentX++)
            {
                Console.WriteLine("The character is on the "+currentX+","+currentY+" position");
            }

            Console.WriteLine("target y: "+targetY);

            for (currentY=startY; currentY<=targetY; currentY++)
            {
                Console.WriteLine("The character is on the "+currentX+","+currentY+" position");
            }
        }

    }
}