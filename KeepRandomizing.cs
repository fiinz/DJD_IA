using System;

namespace KeepRandomizing
{
    class Program 
    {
        
        static void Main(string[] args)
        {
            int posX, posY; // the "position" of the player
            Random r = new Random();
            
            int n = (int)r.Next(1, 1000); // number of times the position will be randomized
            for (int i = 0; i < n; i++)
            {
                //map of 500 x 500 
                posX = (int) r.Next(0, 501); 
                posY = (int) r.Next(0, 501);
                Console.WriteLine("posicao do jogador: " + posX + "," + posY);
            }
            Console.WriteLine("A posicao do jogador mudou " + n + " vezes");
        }

    }
}