using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarmInterfaces
{
  class Farm
  {

    private List<IAnimal> animals = new List<IAnimal>();

    public void AddAnimal(IAnimal animal)
    {
      animals.Add(animal);
    }

    public void MakeAnimalsSpeak()
    {
      if (animals.Count > 0)
      {
        foreach (IAnimal animal in animals)
        {
          Console.WriteLine(animal.GetDescription());
        }
      }
      else
      {
        Console.WriteLine("The farm is empty.");
      }
    }

  }
}
