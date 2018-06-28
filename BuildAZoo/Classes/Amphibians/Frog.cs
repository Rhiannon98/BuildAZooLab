using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Amphibians
{
    public class Frog : Amphibians
    {
        public override string AverageAge { get; set; } = "10-15 years!";
        public bool GotHops { get; set; } = true;
        public override string Metamorphosis() {return "Tadpoles!!!! Ribbit!";}
        public override string Sound()
            {return "Croak.. RrrrriIIIIbiit.. EEEEEEEEEEEEEEEEEEAAAAAAAA";}
        public override string FoodSource() {return "Carnivore!!";}
    }
}
