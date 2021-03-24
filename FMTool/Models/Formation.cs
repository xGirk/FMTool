using System;
using System.Collections.Generic;

namespace FMTool.Models
{
    public static class Formation
    {
        
        public static void GenerateFormation(bool advanced)
        {
            List<Position> formation = new();
            formation.Add(new Position("Defenders", 5));

            if (advanced)
            {
                formation.Add(new Position("DefMids", 5));
                formation.Add(new Position("Midfielders", 5));
                formation.Add(new Position("AttMids", 5));
                formation.Add(new Position("Forwards", 3));
            }
            else
            {
                formation.Add(new Position("Midfielders", 8));
                formation.Add(new Position("Forwards", 5));
            }

            FillPositions(formation);

            PrintFormation(formation);
        }

        private static void FillPositions(List<Position> formation)
        {
            Random rand = new();

            for (int i = 0; i < 10; i++)
            {
                var bucket = rand.Next(formation.Count);
                if (!formation[bucket].Add())
                    i--;
            }
        }

        private static void PrintFormation(List<Position> formation)
        {
            List<int> output = new();
            foreach (var position in formation)
                output.Add(position.CurrentPlayers);

            Console.WriteLine($"Formation: " + string.Join("-", output));
        }

    }
}
