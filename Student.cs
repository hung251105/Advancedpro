using Advancedpro;
using System;
using System.Xml.Linq;

namespace advanceprog
{
    class Student : Person
    {
        private int studentID;
        public int StudentID
        {
            get { return this.studentID; }
            set { this.studentID = value; }
        }

        public Student(string name, int age,
            int studentID) : base(name, age)
        {
            this.studentID = studentID;
        }

        public Student()
        {
        }

        public override void showInformation()
        {
            Console.WriteLine($"Student Name : {Name} | Student Age : {Age} " +
                                $"| Student ID : {StudentID}");
        }
    }
}