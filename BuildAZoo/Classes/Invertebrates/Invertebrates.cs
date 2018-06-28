using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Invertebrates
{
    public abstract class Invertebrates : Animal
    {
        public override bool Spine {get; set; } = false;
        public override bool WarmBlooded { get; set; } = false;
    }
}
