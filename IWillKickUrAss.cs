using System;

namespace IWillKickUrAss
{
    public class Program
    {
        static void Main(string[] args)
        {

        private Random r = new Random();
        int playerOneAttack = int(r.Next(10, 51)); 
        int playerOneAttack = int(r.Next(10, 51));
        int playerOneHp = int(r.Next(100, 201));

        int playerTwoAttack = int(r.Next(10, 51));
        int playerTwoHp = int(r.Next(100, 201));

        float turnsWillLivePlayerOne = playerOneHp / playerTwoAttack;
        float turnsWillLivePlayerTwo = playerTwoHp / playerOneAttack;

        Console.WriteLine("--- player one stats ---");
        Console.WriteLine ("attack: "+playerOneAttack);
        Console.WriteLine ("hp: "+playerOneHp);


        Console.WriteLine("--- player two stats ---");
        Console.WriteLine ("attack: "+playerTwoAttack);
        Console.WriteLine ("hp: "+playerTwoHp);

        println("--------------------------");
        if (turnsWillLivePlayerOne>turnsWillLivePlayerTwo)
        {
            Console.WriteLine("player one would win");
        } 
        else {
            Console.WriteLine("player two would win");
        }
        //message by
       }
    }
}
