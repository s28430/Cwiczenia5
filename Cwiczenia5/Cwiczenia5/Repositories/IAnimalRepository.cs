using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimalById(int id);
    void AddAnimal(Animal animal);
}