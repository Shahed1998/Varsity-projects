using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    class Shahed_Chowdhury_Omi
    {
        private string name, id, program;
        private int semester;
        private double cgpa;

        // Name
        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        // ID
        public void setID(string id)
        {
            this.id = id;
        }

        public string getID()
        {
            return id;
        }

        // Program
        public void setProgram(string program)
        {
            this.program = program;

        }

        public string getProgram()
        {
            return program;
        }

        // Semester
        public void setSemester(int sem)
        {
            this.semester = sem;

        }

        public int getSemester()
        {
            return semester;
        }

        // CGPA
        public void setCGPA(double cgpa)
        {
            this.cgpa = cgpa;

        }

        public double getCGPA()
        {
            return cgpa;
        }


        // Constructors 

        // Empty 
        public Shahed_Chowdhury_Omi()
        {

        }

        // Parameterized 
        public Shahed_Chowdhury_Omi(string name, string id, string program, int semester, double cgpa)
        {
            this.name = name;
            this.id = id;
            this.program = program;
            this.semester = semester;
            this.cgpa = cgpa;
        }

        // Copy
        public Shahed_Chowdhury_Omi(Shahed_Chowdhury_Omi s)
        {
            name = s.name;
            id = s.id;
            program = s.program;
            semester = s.semester;
            cgpa = s.cgpa;
        }


        public string display()
        {
            return $"Name = {name}\nID = {id}\nProgram = {program}\nSemester = {semester}\n" +
                $"CGPA = {cgpa}";
        }

        // Property
        public string Name
        {
            get{ return name; }
            set { name = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Program
        {
            get;
            set;
        }

        public int Semester
        {
            get;
            set;
        }

        public double CGPA
        {
            get;
            set;
        }


    }
}
