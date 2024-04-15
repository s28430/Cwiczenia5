using Cwiczenia5.Models;
using Cwiczenia5.Repositories;

namespace Cwiczenia5.Services;

public class AnimalVisitsService(IAnimalVisitsRepository animalVisitsRepository) : IAnimalVisitsService
{
    public IEnumerable<AnimalVisit> GetAnimalVisits()
    {
        return animalVisitsRepository.GetAnimalVisits();
    }

    public IEnumerable<AnimalVisit> GetAnimalVisitsByAnimalId(int id)
    {
        return animalVisitsRepository.GetAnimalVisitsByAnimalId(id);
    }
}