using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Validation_data
{
    class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                this.firstName = value;
            }
            


        }


        public string LastName
        {
            get { return this.lastName; }
             set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {

                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                this.age = value;
            }
        }
        public override string ToString()
        {

            return $"{this.FirstName} {this.LastName} receives {this.salary} dollors.";
        }

        public decimal Salary
        {
            get
            {
                return this.salary;

            }
           set
            {

                if (value < 460)
                {
                    throw new ArgumentException("salary cannot be less than 460 dollar!");
                }
                this.salary = value;

            }
        }
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
       
    }
}







