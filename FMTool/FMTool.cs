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

        private static List<Personality> _personalities;
        public static List<Personality> Personalities 
        {
            get { return _personalities == null ? LoadPersonalities() : _personalities; }
            set { _personalities = value; }
        }

        private static List<CareerGoals> _careergoals;
        public static List<CareerGoals> CareerGoals
        {
            get { return _careergoals == null ? LoadCareerGoals() : _careergoals; }
            set { _careergoals = value; }
        }

        public static List<Personality> LoadPersonalities()
        {
            string path = Path.Combine(
                 System.Environment.CurrentDirectory,
                 "Data",
                 "personalities.json");
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Personality>>(json);
        }

        public static List<CareerGoals> LoadCareerGoals()
        {
            string path = Path.Combine(
                 System.Environment.CurrentDirectory,
                 "Data",
                 "careergoals.json");
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<CareerGoals>>(json);
        }

        public static Personality GetRandomPersonality()
        {
            var roll = new Random().Next(Personalities.Count);
            return Personalities[roll];
        }

        public static CareerGoals GetRandomCareerGoal()
        {
            var roll = new Random().Next(CareerGoals.Count);
            return CareerGoals[roll];
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
