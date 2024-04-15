using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public class MockAnimalRepository : IAnimalRepository
{
    private static readonly List<Animal> Animals =
    [
        new Animal("Joe", AnimalType.Mammal, 30, "black"),
        new Animal("Doe", AnimalType.Fish, 5, "beige"),
        new Animal("Burbon", AnimalType.Mammal, 45, "black")
    ];
    
    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }

    public Animal? GetAnimalById(int id)
    {
        return Animals.FirstOrDefault(animal => animal.Id == id);
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public bool RemoveAnimal(int id)
    {
        var animalToRemove = Animals.FirstOrDefault(animal => animal.Id == id);

        if (animalToRemove is null) return false;
        Animals.Remove(animalToRemove);
        return true;
    }

    public bool UpdateAnimal(int id, Animal newAnimal)
    {
        var removeSuccess = RemoveAnimal(id);
        Console.WriteLine(removeSuccess);
        if (!removeSuccess) return false;
        
        AddAnimal(newAnimal);
        return true;
    }
}