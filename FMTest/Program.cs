using FMTool.Models;
using System;
using static FMTool.FMTool;

namespace FMTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("These are your three goals.");
            Console.WriteLine(GetRandom(CareerGoals));
            Console.WriteLine(GetRandom(CareerGoals));
            Console.WriteLine(GetRandom(CareerGoals));

            Console.WriteLine("These are your three formations.");
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());

            Console.WriteLine("\nThese are your three advanced formations.");
            AdvancedFormations = true;
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
        }
    }
}