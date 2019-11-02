using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmAbstract
{
  class Cat : Animal
  {
    public string Race { get; set; }

    public Cat(string name, string sound, string race)
    {
      Race = race;
      Name = name;
      Sound = sound;
    }

    // Not implementing GetDescription would produce
    // a compile error.
    public override string GetDescription()
    {
      return $"{Sound}! I'm a {Race} cat called {Name}";
    }
  }
}
