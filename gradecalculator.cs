using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }
        }
    }
}