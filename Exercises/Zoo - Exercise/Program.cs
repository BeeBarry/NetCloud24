using System;
public class Animal
{
   public string Name { get; set; }
   private string Species { get; set; }
   public string Diet { get; set; }

  public Animal(string name, string species, string diet)
   {
      Name = name;
      Species = species;
      Diet = diet;
   }

   public string MakeSound()
   {
       return "Some sound!";
   }

   public string GetSpecies()
   {
       return Species;
   }
}


public class Zookeeper
{
    public string Name { get; set; }

    public Zookeeper(string name)
    {
        Name = name;
    }

    public void FeedAnimal(Animal animal)
    {
        Console.WriteLine($"{Name} is feeding {animal.Name}");
    }
    
}

class Program
{
    static void Main(string[] args)
    {

         List<Animal> wildlifeSection = new List<Animal>();
         
         wildlifeSection.Add(new Animal("Bill", "Bison", "Herbivore"));
         wildlifeSection.Add(new Animal("Suduko", "Tiger", "Carnivore"));
         wildlifeSection.Add(new Animal("Bearry", "Bear", "omnivore"));

         foreach (Animal animal in wildlifeSection)
         {
             Console.WriteLine($"Name :{animal.Name}, Species: {animal.GetSpecies()}, Diet: {animal.Diet}");
         }

         Zookeeper zookeeper = new Zookeeper("Otis");

         foreach (Animal animal in wildlifeSection)
         {
             zookeeper.FeedAnimal(animal);
         }


    }
    
    
}

