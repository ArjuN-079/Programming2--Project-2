using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project_2
{
    public class DataHandlers
    {
        public static void ReadFromFile(string filePath, List<Player>players, List<Caller>callers)
        {
            string json = File.ReadAllText(filePath);

            List<Question> question = JsonSerializer.Deserialize<List<Question>>(json);

        }
    }
    
}
