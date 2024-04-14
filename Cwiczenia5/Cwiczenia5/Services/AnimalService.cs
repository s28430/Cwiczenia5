using Cwiczenia5.Models;
using Cwiczenia5.Repositories;

namespace Cwiczenia5.Services;

public class AnimalService(IAnimalRepository animalRepository) : IAnimalService
{
    public IEnumerable<Animal> GetAnimals()
    {
        return animalRepository.GetAnimals();
    }

    public Animal? GetAnimalById(int id)
    {
        return animalRepository.GetAnimalById(id);
    }

    public void AddAnimal(Animal animal)
    {
        animalRepository.AddAnimal(animal);
    }

    public bool RemoveAnimal(int id)
    {
        return animalRepository.RemoveAnimal(id);
    }

    public bool UpdateAnimal(int id, Animal newAnimal)
    {
        return animalRepository.UpdateAnimal(id, newAnimal);
    }
}