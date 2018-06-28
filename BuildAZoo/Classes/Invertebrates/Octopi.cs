using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Invertebrates
{
    public class Octopi : Invertebrates
    {
        public override bool WarmBlooded { get; set; } = false;
        public override string AverageAge { get; set; } = "3-5 years old";
        public override bool AirBreather { get; set; } = false;
        public override string Limbs { get; set; } = "8 tenticles!!";
        
        public override string FoodSource()
        {
            return "Carnivore!";
        }
        public override string Sleeps()
        {
            return "I can sleep as much as a human!!";
        }
    }
}
