using Cwiczenia5.Models;

namespace Cwiczenia5.Services;

public interface IAnimalService
{
    IEnumerable<Animal> GetAnimals();
    Animal? GetAnimalById(int id);
    void AddAnimal(Animal animal);
}