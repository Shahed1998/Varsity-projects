using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // object 1-> empty constructor -> value passing: set -> printing: get
            Console.WriteLine("---------------------- User-1");
            Shahed_Chowdhury_Omi s1 = new Shahed_Chowdhury_Omi();
            s1.setName("Valorant");
            Console.WriteLine($"Name = {s1.getName()}");
            s1.setID("18-3");
            Console.WriteLine($"ID = {s1.getID()}");
            s1.setProgram("BSC.CSE");
            Console.WriteLine($"Program = {s1.getProgram()}");
            s1.setSemester(10);
            Console.WriteLine($"Semester = {s1.getSemester()}");
            s1.setCGPA(3.12);
            Console.WriteLine($"CGPA = {s1.getCGPA()}");

            //object 2->param constructor->value passing: param->printing->display function
            Console.WriteLine("---------------------- User-2");
            Shahed_Chowdhury_Omi s2 = new Shahed_Chowdhury_Omi(
                "Arma", "18-1", "BSC.CSE", 12, 3.8
            );

            Console.WriteLine(s2.display());

            //object 3-> copy contructor -> printing ->get/display
            Console.WriteLine("---------------------- User-3");
            Shahed_Chowdhury_Omi s3 = new Shahed_Chowdhury_Omi(s2);
            Console.WriteLine(s2.display());

            //object 4->empty constructor->value passing: property->printing: property
            Console.WriteLine("---------------------- User-4");
            Shahed_Chowdhury_Omi s4 = new Shahed_Chowdhury_Omi(s2);
            s4.Name = "Rainbow 6";
            s4.ID = "20-1";
            s4.Program = "BBA";
            s4.Semester = 6;
            s4.CGPA = 3.6;
            Console.WriteLine($"Name = {s4.Name}\nID = {s4.ID}\nProgram = {s4.Program}\n" +
                $"Semester = {s4.Semester}\nCGPA = {s4.CGPA}");
            Console.ReadKey();
        }
    }
}
