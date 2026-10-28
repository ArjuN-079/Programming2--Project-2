using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_2
{
    public class DataHandlers
    {
        public static List<Question> ReadFromFile(string filePath)
        {
           // List<string> lines = File.ReadAllLines(filePath).ToList();
            string json = File.ReadAllText(filePath);
            List<Question> question = JsonSerializer.Deserialize<List<Question>>(json);

            return question;

           
        }
    }
    
}
