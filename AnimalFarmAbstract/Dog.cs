using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmAbstract
{
  class Dog : Animal
  {
    
    public Dog(string name, string sound = "Wooof")
    {
      Name = name;
      Sound = sound;
    }

    public override string GetDescription()
    {
      return $"{Sound}! I'm {Name} the dog";
    }
  }
}
