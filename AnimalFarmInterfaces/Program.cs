using System;

namespace AnimalFarmInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      var farm = new Farm();
      Cat pull = new Cat("Pull", "Ouinouin", "Bleu");
      Dog mitch = new Dog("Mitch");

      farm.AddAnimal(pull);
      farm.AddAnimal(mitch);

      farm.MakeAnimalsSpeak();
    }
  }
}
