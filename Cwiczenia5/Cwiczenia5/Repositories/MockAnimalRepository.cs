using Cwiczenia5.Models;
using Microsoft.AspNetCore.Mvc;

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
        return Animals.Find(animal => animal.Id == id);
    }
}