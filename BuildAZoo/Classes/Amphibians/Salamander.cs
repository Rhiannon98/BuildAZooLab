using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Amphibians
{
    public abstract class Salamander : Amphibians
    {
        public override string Limbs { get; set; } = "I have 4 legs, and some feelers! All of me can regenerate!";
        public virtual string LookAlike { get; set; } = "Welp. I am an eel, a lizard, and a frog?";
        public override string FoodSource()
        {
            return "I eat what I can get!";
        }
    }
}
