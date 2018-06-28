using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Amphibians
{
    public abstract class Amphibians : Animal
    {
        public override bool Spine { get; set; } = true;
        public override bool WarmBlooded { get; set; } = false;
        public virtual bool LaysEggs { get; set; } = true;

        public virtual string Metamorphosis()
        { return "You would not recognize me from my offspring!"; }

        public bool PermeableSkin { get; set; } = true;
    }
}
