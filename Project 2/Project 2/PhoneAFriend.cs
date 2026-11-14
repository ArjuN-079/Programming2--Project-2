using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class PhoneAFriend : lifeline
    {
        private Caller Caller; 
        public PhoneAFriend(Caller caller) //pick for the game in lifeline
        {
            this.Caller = caller;
        }
        public override bool IsAvailable(int level) //level 0n 1 to 14
        {
            return !IsUsed && level < 15;
        }
        public override string Use(Question question, int level)
        {
            IsUsed = true;

            int chanceCorrect;
            if (Caller.Strengths.Contains(question.Category))
            {
                chanceCorrect = 100;
            }
            else if(Caller.Weaknesses.Contains(question.Category))
            {
                chanceCorrect = 25;
            }
            else
            {
                chanceCorrect = 50;
            }
            string answer;
            if(random.Next(100)< chanceCorrect)
            {
                answer = question.Correct;
            }
            else
            {
                answer = question.Incorrect[random.Next(question.Incorrect.Count)];
            }
            return Caller.Name + " says: \"I think the answer is " + answer + ".\"";
        }


    }
}
