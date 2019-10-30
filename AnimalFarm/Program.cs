using System;

namespace AnimalFarm
{
  class Program
  {
    static void Main(string[] args)
    {
      var farm = new Farm();

      // Je mets les types plutôt que var juste 
      // pour qu'on voie **vraiment** bien qu'il 
      // s'agit de types différents.
      Cat pull = new Cat("Pull", "Bleu");
      Cat greubi = new Cat("Caprice", "Grochat");
      Cat defaultCat = new Cat();
      Cow marie = new Cow("Marie");
      // On peut mettre une vache dans une variable
      // de type Animal et c'est tout à fait légal:
      Animal rose = new Cow("Rose");
      // Plus d'animaux génériques:
      Animal genericAnimal = new Animal();
      Animal anotherGenericAnimal = new Animal("Frank");
      // Un mouton:
      Sheep someSheep = new Sheep();

      // Mettons les animaux dans la ferme:
      farm.AddAnimal(pull);
      farm.AddAnimal(greubi);
      farm.AddAnimal(defaultCat);
      farm.AddAnimal(marie);
      farm.AddAnimal(rose);
      farm.AddAnimal(genericAnimal);
      farm.AddAnimal(anotherGenericAnimal);
      farm.AddAnimal(someSheep);

      // Afficher les cris de tous les animaux
      // dans la console:
      farm.MakeAnimalsSpeak();
    }
  }
}
