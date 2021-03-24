using System;
using static FMTool.FMTool;

namespace FMTest
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine(GetRandomPersonality());
            GenerateFormation();
            UseAdvancedFormations(true);
            GenerateFormation();
        }
    }
}
