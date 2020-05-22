using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReverseTeam
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reverseTeam;
        public int count = 0;
        public int count1 = 0;
        public Team (string name)
        {
            this.firstTeam = new List <Person>();
            this.reverseTeam = new List<Person>();
            this.name = name;
        }
        public List<Person> FirstTeam
        {
            get { return this.firstTeam; }
        }

        public List<Person> ReverseTeam
        {
            get { return this.reverseTeam; }
        }
        
        public void AddPlayer(Person player)
        {
            
                if (player.Age < 40)
                {
                    firstTeam.Add(player);
                    count++;
                   
                }
            
                else
                {
                    reverseTeam.Add(player);
                    count1++;
                }
            
        }
       
        
    }
    }


