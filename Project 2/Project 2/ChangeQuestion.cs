using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class ChangeQuestion: lifeline
    {
        public override bool IsAvailable(int level)
        {
            return !IsUsed && level <= 10;
        }

        public override string Use(Question question, int level)
        {
            IsUsed = true;
            return question.Category;
        }
    }
}
