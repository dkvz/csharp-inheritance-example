using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
  class Cow : Animal
  {

    public Cow(string name)
    {
      Name = name;
      Sound = "Mooooooh";
    }

    public override string GetDescription()
    {
      //return base.GetDescription();
      return $"I'm {Name} the cow, I go {Sound}";
    }

  }
}
