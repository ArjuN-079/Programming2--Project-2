using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Person // adding the common elements between player and caller classes :name, job
        //fields
    {
        protected string name;
        protected string job;

        //constructor
        public Person(string name, string job)
        {
            this.name = name;
            this.job = job;
        }
         // encapsulation {but still use field}

        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
    }
}
