using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Invertebrates
{
    public class Squids : Invertebrates
    {
        public override bool WarmBlooded { get; set; } = false;
        public override string AverageAge { get; set; } = "well.. our giants are unknown. and us smalls usualy only live 2-5 years";
        public override string Limbs { get; set; } = "TEN-ticles";
        public override bool AirBreather { get; set; } = false;
        public override string FoodSource()
        {
            return "Carni";
        }
    }
}
