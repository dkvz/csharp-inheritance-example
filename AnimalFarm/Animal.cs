using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
  class Animal
  {

    public string Sound { get; set; }
    public string Name { get; set; }

    public Animal()
    {
      Sound = "Bleuuuuuuurblaaargllzbb";
      Name = "Incognito";
    }

    public Animal(string name)
    {
      Name = name;
    }

    public virtual string GetDescription()
    {
      return $"I'm a generic animal called {Name} and I go {Sound}";
    }

  }
}
