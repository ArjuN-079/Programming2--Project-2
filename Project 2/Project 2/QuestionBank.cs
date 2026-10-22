using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public class QuestionBank
    {
        private List<Question> allQuestions;

        public QuestionBank(List<Question> allQuestions)
        {
            this.allQuestions = allQuestions;
        }

        public List<Question> AllQuestions { get => allQuestions; set => allQuestions = value; }

        //public QuestionBank(List<Question> allQuestions);

    }
}
