using System;

namespace Varsity_Task
{
    class Program 
    { 
        enum JobRoles { JuniorDev, SeniorDev, CEO };
        static void Main(string[] args)
        {
            // 1. Print your full name
            Console.WriteLine("Name = Shahed Chowdhury Omi");

            // 2. Print your student id
            Console.WriteLine("ID = 18-38760-3");

            // 3.Implicit type casting(between int and char)
            char a = 'a';
            int b = a;
            Console.WriteLine("ASCII value = "+b);

            // 4. Explicit type casting (between int and double)
            double grade = 76.5;
            int toIntGrade = (int) grade;
            Console.WriteLine(toIntGrade);

            // 5. Constant variable demonstration
            const int MinAge = 18;
            Console.WriteLine("Minimum age must be = "+MinAge);

            // 6. Any one enum demonstration (not the ones shown in the class)
            JobRoles jobRoles = JobRoles.CEO;

            switch (jobRoles)
            {
                case JobRoles.JuniorDev:
                    Console.WriteLine("Salary = 25000");
                    break;
                case JobRoles.SeniorDev:
                    Console.WriteLine("Salary = 50000");
                    break;
                case JobRoles.CEO:
                    Console.WriteLine("Salary = 100000");
                    break;
            }

            Test t1 = new Test();
            t1.Age = 25;
            Console.WriteLine($"Age = {t1.Age}");


            Console.ReadKey();
            
    }

       
    }

    
}
