using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solo Prep 2

            Console.Write("Enter a grade percentage: ");
            string gradeAv = Console.ReadLine();
            int gradeAvInt = int.Parse(gradeAv);

            string status = "passed";

            if (gradeAvInt < 70)
            {
                status = "failed";
            }

            string grade = "A";

            if (gradeAvInt < 60)
            {
                grade = "F";
            }
            else if (gradeAvInt < 70) {
                grade = "D";
            }
            else if (gradeAvInt < 80) {
                grade = "C";
            }
            else if (gradeAvInt < 90) {
                grade = "B";
            }

            Console.WriteLine($"With a score of {gradeAvInt}, you have a(n) {grade} in this class. Basically, you {status}.");
        }
    }
}
