using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmInterfaces
{
  class Cat : IAnimal
  {

    public string Name { get; set; }
    public string Sound { get; set; }
    public string Race { get; set; }

    public Cat(string name, string sound, string race)
    {
      Name = name;
      Sound = sound;
      Race = race;
    }

    public string GetDescription()
    {
      return $"{Sound} I'm a {Race} Cat called {Name}";
    }
  }
}
