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
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());

            Console.WriteLine("\nThese are your three advanced formations.");
            UseAdvancedFormations(true);
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
            Console.WriteLine(GenerateFormation());
        }
    }
}
