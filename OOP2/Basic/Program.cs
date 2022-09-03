using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            Console.Write("Enter 1st number: ");
            // ReadLine() :- returns string
            int a = Convert.ToInt32(Console.ReadLine()); // explicit type casting
            Console.Write("Enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = p.sum(a,b);
            Console.WriteLine($"The sum is: {sum}"); // string interpolation.

        }

        int sum(int a,int b)
        {
            return a + b;
        }
    }
}
