using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class FiftyFifty : lifeline
    {
        public override bool IsAvailable(int level)
        {
            return !IsUsed;
        }

    public override string Use(Question question, int level)
        {
            IsUsed = true;
            int index = random.Next(question.Incorrect.Count);
            return question.Incorrect[index];
        }        
    }
    
}

