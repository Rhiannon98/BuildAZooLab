using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Amphibians
{
    public class JPS : Salamander
    {
        public override string AverageAge { get; set; } = "I live to be 45-55 years old";
        public override bool AirBreather { get; set; } = true;
        public override string LookAlike { get; set; } = "I look like a Salamander, but erm... more magical";
    }
}
