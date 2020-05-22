﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary_Increase
{
    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of entries:");
            var lines = int.Parse(Console.ReadLine());

            var persons = new List<Person>();
            Console.WriteLine("Enter the name age and salary");
            for (int i = 0; i < lines; i++)

            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],cmdArgs[1],int.Parse(cmdArgs[2]),double.Parse(cmdArgs[3]));
                persons.Add(person);    

            }
            Console.WriteLine("Enter the bonus");
            double bonus = double.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadLine();
        }
        
    }
}
