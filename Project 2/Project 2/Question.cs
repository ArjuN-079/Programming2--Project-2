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
            this.correct = correct;
            this.incorrect = incorrect;
        }

        //JSON encapsulation {but still use field}

        [JsonPropertyName("type")]
        public string Type { get => type; set => type = value; }

        [JsonPropertyName("difficulty")]
        public string Difficulty { get => difficulty; set => difficulty = value; }
        [JsonPropertyName("category")]
        public string Category { get => category; set => category = value; }

        [JsonPropertyName("question")]
        public string Quest { get => quest; set => quest = value; }

        [JsonPropertyName("correct_answer")]
        public string Correct { get => correct; set => correct = value; }

        [JsonPropertyName("incorrect_answers")]
        public List<string> Incorrect { get => incorrect; set => incorrect = value; }

    }
}
