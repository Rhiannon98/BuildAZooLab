using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Amphibians
{
    public class Axolotl : Salamander
    {
        public override bool LaysEggs { get; set; } = true;
        public override string AverageAge { get; set; } = "I live from 10-15 years =owo=";
        public override bool AirBreather { get; set; } = false;
    }
}
