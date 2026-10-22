using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Project_2
{
    public class Player :Person // add in person.cs (name and job)
        //fields
    {
        private List<int> age;
        private List<string> hobbies;

        // constructor

        public Player(List<int> age, List<string> hobbies, string name, string job): base(name,job)
        {
            this.age = age;
            this.hobbies = hobbies;
        }

        //encapsulation {but still use field}

        public List<int> Age { get => age; set => age = value; }
        public List<string> Hobbies { get => hobbies; set => hobbies = value; }

    }
}
