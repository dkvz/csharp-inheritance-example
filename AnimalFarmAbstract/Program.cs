using System;

namespace AnimalFarmAbstract
{
  class Program
  {
    static void Main(string[] args)
    {
      // We can no longer directly instanciate Animal!
      Animal pull = new Cat("Pull", "Ouinouin", "Bleu");
      Animal paul = new Dog("Paul", "Waf");

      Console.WriteLine(pull.GetDescription());
      Console.WriteLine(paul.GetDescription());
    }
  }
}
