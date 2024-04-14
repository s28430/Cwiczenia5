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
}