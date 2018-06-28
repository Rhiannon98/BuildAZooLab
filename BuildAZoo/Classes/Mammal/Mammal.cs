using System;
using System.Collections.Generic;
using System.Text;

namespace BuildAZoo.Classes.Mammal
{
    public abstract class Mammal : Animal
    {
        public virtual bool MammoryGlands { get; set; } = true;
        public virtual bool  Fur { get; set; } = true;
        public virtual bool LiveBirth { get; set; } = true;
    }
}
