using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace FE3H_GrowthCalculator
{
    public class JsonReader
    {
        public static List<Class> readClasses(string filePath)
        {
            string? jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Class>>(jsonString);
        }

        public static List<Character> readCharacters(string filePath)
        {
            string? jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Character>>(jsonString);
        }
    }
}