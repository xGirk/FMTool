using FMTool.enums;
using FMTool.Models;
using System;
using System.Text;

namespace FMTool.Models
{
    public record CareerGoal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string AdvancedDescription { get; set; }
        public int Difficulty { get; set; }
        public ChallengeLength Length { get; set; }

        public override string ToString()
        {
            StringBuilder str = new();
            str.Append(Name + "\n");
            str.Append(Description + "\n");
            if (AdvancedDescription != null && AdvancedDescription != "")
                str.Append(AdvancedDescription + "\n");
            str.Append("Difficulty: " + Difficulty + "\n");
            if (Length != ChallengeLength.None)
                str.Append(Length + "\n");
            return str.ToString();
        }
    }
}
