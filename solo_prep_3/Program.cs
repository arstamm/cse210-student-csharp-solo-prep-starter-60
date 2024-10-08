using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Number
            Random randomGenerator = new Random();

            Console.WriteLine("Select a number range: ");
            int range = int.Parse(Console.ReadLine());
            int magicNum = randomGenerator.Next(1, range);
    
            Console.WriteLine("Try to guess my magic number!");

            int guess = 0;
            do {
                Console.WriteLine("Enter guess #: ");
                guess = int.Parse(Console.ReadLine());
                if (guess > magicNum) {
                    Console.WriteLine("Guess Lower");
                } else if (guess < magicNum) {
                    Console.WriteLine("Guess Higher");
                }
            } while (guess != magicNum);
            Console.WriteLine("BACON! \n(were you expecting a different statement at the end of this program?)");
     
        }
    }
}
