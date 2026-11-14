using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class AskTheAudience: lifeline
    {
        public override bool IsAvailable(int level)
        {
            return !IsUsed && level < 15;
        }

        public Dictionary<string, int> GetVotes(Question question, int level)
        {
            IsUsed = true;

            int correctPercent;
            if (level <= 5)
            {
                correctPercent = 90;
            }
            else if (level <= 10)
            {
                correctPercent = 70;
            }
            else
            {
                correctPercent = 25;
            }

            int remaining = 100 - correctPercent;
            int first = random.Next(remaining + 1);
            int second = random.Next(remaining - first + 1);
            int third = remaining - first - second;

            Dictionary<string, int> votes = new Dictionary<string, int>();
            votes.Add(question.Correct, correctPercent);
            votes.Add(question.Incorrect[0], first);
            votes.Add(question.Incorrect[1], second);
            votes.Add(question.Incorrect[2], third);
            return votes;
        }
        public override string Use(Question question, int level)
        {
            string result = "";
            foreach (KeyValuePair<string, int> vote in GetVotes(question, level))
            {
                result += vote.Key + ": " + vote.Value + "%\n";
            }
            return result;
        }


    }
}
