using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
  class Cat : Animal
  {

    public string Race { get; set; }

    public Cat()
    {
      Race = "Chadegoutiaire";
    }

    public Cat(string name, string race)
    {
      Race = race;
      Name = name;
      Sound = "Meow";
    }

    public override string GetDescription()
    {
      return $"{Sound}! I'm {Name} the cat and I'm a {Race}!";
    }

  }
}
