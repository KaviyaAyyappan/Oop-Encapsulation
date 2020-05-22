using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReverseTeam
{
    class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;

        }
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
        }
        public string LastName
        {
            get { return this.lastName; }
        }
        public int Age
        {
            get { return this.age; }
        }

     


    }
}
