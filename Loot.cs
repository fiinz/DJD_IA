using System;

namespace Loot
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
            // The three items and their probability
            Random r = new Random();
            string item1Name="Fur";
            string item1Rarity="common";
            float item1Probability=0.6f;

            string item2Name="liver";
            string item2Rarity="uncommon";
            float item2Probability=0.3f;

            string item3Name="heart";
            string item3Rarity="rare";
            float item3Probability=0.1f;
            
            

            //it can be dropped two items of the same type
            //drop 1
            Console.WriteLine("The creature was Killed");
            Console.WriteLine("---------------------");

            //this random should be float, we dont care too much about not reaching 1
            // cause its a float that can reach 9.(9)

            float randomOne=random(0, 1);
            Console.WriteLine("1st Drop Value: "+randomOne);


            //check if  was inferior or equal to 0.6
            if (randomOne<=item1Probability)
            {
                Console.WriteLine("name:"+item1Name);
                Console.WriteLine("rarity: "+item1Rarity);
            } else
            {
                // if  was superior to 0.6
                //and checks if was inferior or equal to 0.9
                if (randomOne<=(item1Probability+item2Probability))
                {
                    Console.WriteLine("name:"+item2Name);
                    Console.WriteLine("rarity: "+item2Rarity);
                } else
                {
                    // if  was superior to 0.9
                    // rare
                    Console.WriteLine("name:"+item3Name);
                    Console.WriteLine("rarity: "+item3Rarity);
                }
            }
            float randomTwo=random(0, 1);

            Console.WriteLine("----------------------");
            Console.WriteLine("2nd Drop Value: "+randomTwo);


            //The second Item
            //check if  was inferior or equal to 0.6
            if (randomTwo<=item1Probability)
            {
                Console.WriteLine("name:"+item1Name);
                Console.WriteLine("rarity: "+item1Rarity);
            } else
            {
                // if  was superior to 0.6
                //and checks if was inferior or equal to 0.9
                if (randomTwo<=(item1Probability+item2Probability))
                {
                    Console.WriteLine("name:"+item2Name);
                    Console.WriteLine("rarity: "+item2Rarity);
                } else
                {
                    // if  was superior to 0.9
                    // rare
                    Console.WriteLine("name:"+item3Name);
                    Console.WriteLine("rarity: "+item3Rarity);
                }
            }

            Console.WriteLine("---------------------");
        }

        
    }
}