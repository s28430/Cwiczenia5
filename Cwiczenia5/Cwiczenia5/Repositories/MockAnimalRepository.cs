using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public class MockAnimalRepository : IAnimalRepository
{
    private static readonly List<Animal> Animals =
    [
        new Animal("Joe", AnimalType.Dog, 30, "black"),
        new Animal("Doe", AnimalType.Cat, 5, "beige"),
        new Animal("Burbon", AnimalType.Dog, 45, "black")
    ];
    
    public IEnumerable<Animal> GetAnimals()
    {
        return Animals;
    }
}