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
        public static string CareerGoalLocation { get; set; }

        private static List<CareerGoal> _careergoals;
        public static List<CareerGoal> CareerGoals
        {
            get { return _careergoals == null ? LoadCareerGoals() : _careergoals; }
            set { _careergoals = value; }
        }

        public static List<CareerGoal> LoadCareerGoals()
        {
            string path = Path.Combine(
                 System.Environment.CurrentDirectory,
                 "Data",
                 "careergoals.json");
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<CareerGoal>>(json);
        }

        public static CareerGoal GetRandomCareerGoal()
        {
            var roll = new Random().Next(CareerGoals.Count);
            return CareerGoals[roll];
        }

        public static string GenerateFormation()
        {
            return Formation.GenerateFormation(AdvancedFormations);
        }

    }
}
