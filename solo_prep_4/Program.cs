using System;
// IMPORTANT NOTE: the line below makes List creation possiblr
using System.Collections.Generic;

namespace solo_prep_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // The line below cannot run with this statement written before it: using System.Collections.Generic;
            
            
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            List<int> numList = new List<int>();
            int num = 0;
            while (true) {
                Console.WriteLine("Enter #: ");
                num = int.Parse(Console.ReadLine());
                if (num == 0) {
                    break;
                }
                numList.Add(num);
            }
            
            int sum = 0;
            int largestNum = 0;
            foreach (int n in numList) {
                if (n > largestNum) {
                    largestNum = n;
                }
                sum += n;
            }
            decimal avg = Decimal.Divide(sum, numList.Count);
            
            // sum / numList.Count;

            Console.WriteLine($"\nSum: {sum}\nAverage: {avg}\nLargest Number: {largestNum}\n");
            
        }
    }
}
