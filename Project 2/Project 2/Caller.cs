using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class Caller : Person // add in person.cs (name and job)

    //fields
    {
        private List<string> strengths;
        private List<string> weaknesses;
        
        //constructor

        public Caller( string name, string job, List<string> strengths, List<string> weaknesses ) : base( name, job )
        {
            
            this.strengths = strengths;
            this.weaknesses = weaknesses;
        }

        //encapsulation {but still use field}

        public List<string> Strengths { get => strengths; set => strengths = value; }
        public List<string> Weaknesses { get => weaknesses; set => weaknesses = value; }
    }
}
