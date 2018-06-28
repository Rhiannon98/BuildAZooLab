using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Invertebrates
{
    public class Arachnida : Invertebrates
    {
        public bool Exoskeleton { get; set; } = true;
        public override bool WarmBlooded { get; set; } = false;
        public override bool AirBreather { get; set; } = true;
        public override string AverageAge { get; set; } = "Surprisingly, if I am not squished I live 2-3 years";
        public override string FoodSource () {return "Carnivore";}
        public override string Sound () {return "Sssssssome of ussss hisssssss";}
        public override string Limbs { get; set; } = "8... maybe more";
    }
}
