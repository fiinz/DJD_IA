using System;

namespace TimeOver
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 99; i >= 0; i--)
            {
                println("time remaining: " + i);
                if (i == 0) println("time over"); // you could move  this line of code to the end of the cycle
            }

            //you could also do the inverse
            /*
            for ( int i=0; i<99; i++)
            {
              println("time remaining: "+99-i);
              if (i==99)println("time over"); // you could move  this line of code to the end of the cycle
            }
            */
        }
    }
}