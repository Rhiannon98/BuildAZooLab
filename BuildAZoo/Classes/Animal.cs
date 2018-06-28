using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes
{
    public abstract class Animal
    {
        public abstract bool WarmBlooded { get; set ; }
        public abstract string AverageAge { get; set; }
        public abstract bool AirBreather { get; set; }
        public abstract string Limbs { get; set; }
        public abstract bool Spine { get; set; }

        public virtual string FoodSource ()
        {
            return "onNomNomnivore";
        }

        public virtual string Sound()
        {
            return "...";
        }

        public virtual string Sleeps ()
        {
            return "zZZzzZzZZZ..zzZz";
        }
    }
}
