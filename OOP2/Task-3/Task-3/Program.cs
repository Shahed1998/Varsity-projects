using System;

namespace Task_3
{
    class Program
    {
      
        public static void add(int resultId, int a, int b)
        {
            resultId = a + b;
            Console.WriteLine($"Summation =  {resultId} ");
        }

        public static void multiplication(ref int resultId, int idMiddle, int idLast)
        {
            resultId = idMiddle * idLast;
            Console.WriteLine($"Multiplication = {resultId}");

        }

        public static void printId(out int midIdVal, out int lastIdVal)
        {

            midIdVal = 760;
            lastIdVal = 3;

            Console.WriteLine($"intialised midIdVal = {midIdVal}, lastIdVal = {lastIdVal}, " +
                $"Multiplied value = {midIdVal * lastIdVal}");
        }

        public static void paramOut(params int[] arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public static void namedParams(int sem, double cgpa, string id)
        {
            Console.WriteLine($"ID = {id}, CGPA = {cgpa}, Semester = {sem} ");
        }

        static void Main(string[] args)
        {
            int idMiddle = 760;
            int idLast = 3;
            int resultId = 123;
            int midIdVal, lastIdVal;

            // Q-1: Pass by value
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Result Id before pass by value : {resultId}");
            add(resultId,idMiddle,idLast);
            Console.WriteLine($"Result Id after pass by value : {resultId}");


            // Q-2: Pass by reference
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Result Id before pass by reference : {resultId}");
            multiplication(ref resultId, idMiddle, idLast);
            Console.WriteLine($"Result Id after pass by reference : {resultId}");


            // Q-3: Out parameter
            Console.WriteLine("-------------------------------------------");
            printId(out midIdVal, out lastIdVal);

            // Q-4: Params
            Console.WriteLine("-------------------------------------------");
            paramOut(1, 8, 3, 8, 7, 6, 0, 3);

            // Q-5: Named parameters
            Console.WriteLine("-------------------------------------------");
            namedParams(id: "18-38760-3", sem: 10, cgpa: 3.37);

            // Q-6: Jagged array
            Console.WriteLine("-------------------------------------------");
            char[][] charArray = { new[] { 'A', 'B', 'C' }, new[] { 'D', 'E' } };

            Console.Write($"charArray = [");
            foreach (char[] i1 in charArray)
            {
                Console.Write("[");
                foreach (char j1 in i1)
                {
                    Console.Write(j1);
                }
                Console.Write("]");
            }
            Console.Write("]\n");

            Console.WriteLine($"charArray[{0}][{2}] = {charArray[0][2]}\n" +
                $"charArray[{1}][{2}] = {charArray[1][1]}");

            Console.WriteLine(" --- After manipulation --- ");
            charArray[0][2] = 'F'; charArray[1][1] = 'G';


            Console.WriteLine($"charArray[{0}][{2}] = {charArray[0][2]}\n" +
                $"charArray[{1}][{2}] = {charArray[1][1]}");

            Console.Write($"charArray = [");
            foreach(char[] i1 in charArray)
            {
                Console.Write("[");
                foreach (char j1 in i1)
                {
                    Console.Write(j1);
                }
                Console.Write("]");
            }
            Console.Write("]");


            Console.ReadKey();
        }
    }
}
