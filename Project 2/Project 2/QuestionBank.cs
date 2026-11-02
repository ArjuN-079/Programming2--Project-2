using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class QuestionBank
    //Fields
    {
        private List<Question> allQuestions;


        //constructor
        public QuestionBank(List<Question> allQuestions)
        {
            this.allQuestions = allQuestions;
        }

        //encapsulation {but still use field}
        public List<Question> AllQuestions { get => allQuestions; set => allQuestions = value; }

        //public QuestionBank(List<Question> allQuestions);
        
        public List<Question> GetCategory(string category, string difficulty)
        {
            return allQuestions.Where( n => n.Category == category && n.Difficulty == difficulty).ToList();
        }

    }
}
