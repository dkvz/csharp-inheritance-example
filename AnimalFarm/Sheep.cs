using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
  class Sheep : Animal
  {

    public bool Sheared { get; set; }

    public Sheep()
    {
      Sheared = false;
      Name = "Mr Mouton";
      Sound = "Baaaaaaaaah";
    }

    public Sheep(string name): this()
    {
      Name = name;
    }

    public void Shear()
    {
      Sheared = true;
    }

    public override string GetDescription()
    {
      // This should be a single line with a ternary operator:
      // var shearedText = Sheared ? "sheared" : "HAIRY";
      string shearedText;
      if (Sheared)
      {
        shearedText = "sheared";
      } 
      else
      {
        shearedText = "HAIRY";
      }
      return $"{Name} the {shearedText} sheep says {Sound}";
    }

  }
}
