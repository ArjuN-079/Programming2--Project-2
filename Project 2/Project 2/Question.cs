using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project_2
{

    public class Question // based on JSON file data
        //JSON Fields
    {
        private string type;
        private string difficulty;
        private string category;
        private string quest;
        private string correct;
        private List<string> incorrect;


        //JSON constructor
        public Question(string type, string difficulty, string category, string quest, string correct, List<string> incorrect)
        {
            this.type = type;
            this.difficulty = difficulty;
            this.category = category;
            this.quest = quest;
            this.incorrect = incorrect;
        }

        //JSON encapsulation {but still use field}

        [JsonPropertyName("type")]
        public string Type { get => type; set => type = value; }
       //public string type { get; set; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get => difficulty; set => difficulty = value; }
        //public string difficulty { get; set; }
        [JsonPropertyName("category")]
        public string Category { get => category; set => category = value; }
        //public string category { get; set; }

        [JsonPropertyName("question")]
        public string Quest { get => quest; set => quest = value; }
        //public string quest { get; set; }

        [JsonPropertyName("correct_answers")]
        public string Correct { get => correct; set => correct = value; }
        //public List<string> correct { get; set; }

        [JsonPropertyName("incorrect_answers")]
        public List<string> Incorrect { get => incorrect; set => incorrect = value; }
        //public List<string> incorrect { get; set; }

    }
}
