using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReverseTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            Console.WriteLine("Enter the name and age:");
           
            for (int i = 0; i < 5; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                Person person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }
            Team team = new Team("Lexicon");
            foreach (Person p in persons)
            {
                team.AddPlayer(p);
               
            }
            Console.WriteLine("First team has " + team.count + "  players");
            Console.WriteLine("Reverse team has " + team.count1 + "players");
            Console.ReadLine();
        }
    }
}
