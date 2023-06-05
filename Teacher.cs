using Advancedpro;
using System;
using System.Xml.Linq;

namespace advanceprog
{

    class Teacher : Person
    {
        private int teacherId;
        private int experienceYear;


        public int ExperienceYear { get => experienceYear; set => experienceYear = value; }
        public int TeacherId { get { return this.teacherId; } set { this.teacherId = value; } }

        public Teacher(int teacherId, int experienceYear,
                        string name, int age) : base(name, age)
        {
            this.TeacherId = teacherId;
            this.ExperienceYear = experienceYear;
        }

        public Teacher()
        {

        }

        public override void showInformation()
        {
            Console.WriteLine($"Teacher : {Name} | Age : {Age} |" +
                                $" Teacher ID : {teacherId} | Experience Year : {experienceYear}");
        }
    }

}

//private float rating = 0;