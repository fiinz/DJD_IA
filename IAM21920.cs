using System;
/// <summary>
/// M2 Test Solution
/// </summary>
namespace IA
{
    class IAM21920
    {
        public static Random r = new Random();
        public static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
        }


        /// <summary>
        /// exercise 1
        /// </summary>
        public static void Ex1()
        {
            //N lançamentos de 3 dados, apresentar o maior lançamento
            int max;
            int throws = r.Next(10, 30);
            int greaterThrowIndex = 0;
            int[] total = new int[throws];
            for (int i = 0; i < total.Length; i++)
            {
                total[i] = r.Next(1, 7) + r.Next(1, 7) + r.Next(1, 7);
            }
            max = total[0];
            for (int i = 1; i < total.Length; i++)
            {   //if u use greater or equal than you will get the last throw in case of equality
                if (total[i] >= max) { max = total[i]; greaterThrowIndex = i; }
            }
            Console.WriteLine($"The biggest throw was{total[greaterThrowIndex]} at the throw number{greaterThrowIndex} ");
        }


        public static void Ex2()
        {
            //sequence of notes
            int notes = r.Next(10, 30);
            int[] sequence = new int[notes];
            int[] inputs = new int[notes];
            int countCorrect = 0;

            for (int i = 0; i < sequence.Length; i++)
            { sequence[i] = r.Next(1, 4); }

            for (int i = 0; i < sequence.Length; i++)
            {
                inputs[i] = r.Next(0, 4);
                if (inputs[i] == sequence[i]) {Console.WriteLine("great"); countCorrect++; }
                else if (inputs[i] == 0)
                { Console.WriteLine("missed"); }
                else { Console.WriteLine("oh"); }
            }
            int accuracy = (int)((float)countCorrect/notes * 100);
            Console.WriteLine($"Accuracy of {accuracy} %");
        }

        public static void Ex3()
        {
            //Leaderboard 10
            // players can repeat entries in the leaderboard
            int notes = r.Next(10, 30);
            int[] leaderboardScores= new int[10];
            int[] leaderboardPlayers = new int[10];
            int[] entries=new int[r.Next(20,100)]; // stores the score entries
            int[] entriesPlayers= new int[entries.Length]; //save the players numbers who've made the above entries


            for (int entry = 0; entry < entries.Length; entry++)
            {
                int playerNumber = r.Next(1, 20); // which player ?
                entriesPlayers[entry] = playerNumber; //store the player id
                entries[entry] = r.Next(1,1000); //score
                

            }
            for (int pos = 0; pos < leaderboardScores.Length; pos++)
            {
                int entryToClear=0;
                //because we haven't learn sort algorithms we can replace values by -1 so we can keep looking for the biggest one
                for (int entry = 0; entry < entries.Length; entry++)
                {
                    if (entries[entry] > leaderboardScores[pos])
                    {
                        leaderboardScores[pos] = entries[entry];
                        leaderboardPlayers[pos] = entriesPlayers[entry];
                        entryToClear = entry;                        
                    }

                }
                //removing the score from the 
                entries[entryToClear] = -1;
                Console.WriteLine($"{pos+1}# Player: {leaderboardPlayers[pos]} Score:{leaderboardScores[pos]}");

            }


        }
    }
}
