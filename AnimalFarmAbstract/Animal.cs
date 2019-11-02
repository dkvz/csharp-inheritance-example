using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmAbstract
{
  public abstract class Animal
  {

    public string Name { get; set; }
    public string Sound { get; set; }

    public abstract string GetDescription();

  }
}
