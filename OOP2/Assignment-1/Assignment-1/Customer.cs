using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Customer : Person
    {
        private Account acc;

        public Customer() { }

        public Customer(string name, string dob, Account acc) : base(name, dob)
        {
            this.acc = acc;
        }

        public void setAcc(Account acc)
        {
            this.acc = acc;
        }


        public override void display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"DOB = {DOB}");
            acc.displayAccDetails();



        }
    }
}
