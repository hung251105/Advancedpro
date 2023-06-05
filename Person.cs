using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advancedpro
{
    abstract class Person
    {

        private string name;
        private int age;

        //get, set method
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        //constructors

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {

        }

        public abstract void showInformation();

    }
}
