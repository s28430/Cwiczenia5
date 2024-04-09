using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public interface IAnimalRepository
{
    IEnumerable<Animal> GetAnimals();
}