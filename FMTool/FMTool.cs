using FMTool.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FMTool
{
    public static class FMTool
    {
        public static List<Personality> Personalities = new();

        public static List<Personality> LoadPersonalities()
        {
            string path = Path.Combine(
                 System.Environment.CurrentDirectory,
                 "personalities",
                 "personalities.json");
            var json = File.ReadAllText(path);
            return Personalities = JsonSerializer.Deserialize<List<Personality>>(json);
        }

    }
}
