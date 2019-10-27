using System;

namespace LostInMap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
        //sets the size of the draw area as 500x 500 
        // not necessary for this class
        //assume that they will never be on center
        int posX=int(r.Next(501));
        int posY=int(r.Next(501));
        String message;  

            if (posY<250) 
        {
            //if y is lesser than 250  message starts with top
            message="TOP";
        } else
        {
            //if y is greater than 250  message starts with bottom
            message="BOTTOM";
        }

        if (posX<250) 
        {
            //if y is lesser than 250  message starts with top
            message+="-LEFT";
        } else
        {
            //if y is greater than 250  message starts with bottom
            message+="-RIGT";
        }
  
        Console.WriteLine(message);

    }
}