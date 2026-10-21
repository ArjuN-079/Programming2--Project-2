using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Caller
        //fields
    {
        private string name;
        private string job;
        private string strengths;
        private string weaknesses;

        //constructor

        public Caller( string name, string job, string strengths, string weaknesses )
        {
            this.name = name;
            this.job = job;
            this.strengths = strengths;
            this.weaknesses = weaknesses;
        }

        //encapsulation {but still use field}
        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public string Strengths { get => strengths; set => strengths = value; }
        public string Weaknesses { get => weaknesses; set => weaknesses = value; }
    }
}
