using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project_2
{
    public class Question
    {
        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("difficulty")]
        public string difficulty { get; set; }

        [JsonPropertyName("category")]
        public string category { get; set; }

        [JsonPropertyName("question")]
        public string quest { get; set; }

        [JsonPropertyName("incorrect_answers")]
        public List<string> incorrect { get; set; }
    }
}
