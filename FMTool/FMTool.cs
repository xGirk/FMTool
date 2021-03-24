using FMTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FMTool
{
    public static class FMTool
    {
        public static bool AdvancedFormations { get; set; } = false;

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

        public static Personality GetRandomPersonality()
        {
            if (Personalities.Count < 1)
                LoadPersonalities();

            var roll = new Random().Next(Personalities.Count);
            return Personalities[roll];
        }

        public static void UseAdvancedFormations(bool advanced)
        {
            AdvancedFormations = advanced;
        }

        public static void GenerateFormation()
        {
            Formation.GenerateFormation(AdvancedFormations);
        }

    }
}
