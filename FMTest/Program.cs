using System;
using FMTool.Models;
using static FMTool.FMTool;

namespace FMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalities = LoadPersonalities();

            var roll = new Random().Next(personalities.Count);
            Console.WriteLine(personalities[roll]);

            Formation.GenerateFormation(false);
            Formation.GenerateFormation(true);
        }
    }
}
