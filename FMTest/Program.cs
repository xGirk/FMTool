using System;
using static FMTool.FMTool;

namespace FMTest
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(GetRandomPersonality());
            Console.WriteLine(GetRandomCareerGoal());
            Console.WriteLine("These are your three formations.");
            GenerateFormation();
            GenerateFormation();
            GenerateFormation();

            Console.WriteLine("These are your three advanced formations.");
            UseAdvancedFormations(true);
            GenerateFormation();
            GenerateFormation();
            GenerateFormation();
        }
    }
}
