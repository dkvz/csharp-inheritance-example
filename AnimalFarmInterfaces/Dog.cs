using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmInterfaces
{
  class Dog : IAnimal
  {

    public string Name { get; set; }

    public Dog(string name)
    {
      Name = name;
    }

    public string GetDescription()
    {
      return $"Woooof! I'm {Name} the dog";
    }
  }
}
