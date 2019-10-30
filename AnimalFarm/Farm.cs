using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
  class Farm
  {

    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
      animals.Add(animal);
    }

    public void MakeAnimalsSpeak()
    {
      if (animals.Count > 0)
      {
        foreach (Animal animal in animals)
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
