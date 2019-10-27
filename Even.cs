namespace Even
{
    public class Program
    {
        static void Main(string[] args)
        {
        for ( int i=0; i<=100; i++)
        {
            if (i%2==0) { // mod gives us the remainder after division by 2 if the remainder is 0 // we know that the number is even
                Console.WriteLine("number: "+i);
            }
        }


        //you could also use increments to reach  even numbers
        /*
        
         for ( int i=0; i<=100; i+=2) // if the increments are by 2 you ensure i will only have even numbers
         {
         println("number: "+i);
         }
         */
    }
}