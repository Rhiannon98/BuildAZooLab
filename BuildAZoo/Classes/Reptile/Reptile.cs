using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Reptile
{
    public abstract class Reptile : Animal
    {
        public virtual bool ColdBlooded { get; set; } = true;
        public override bool WarmBlooded { get; set; } = false;
        public abstract bool EggLayer { get; set; }
    }
}
