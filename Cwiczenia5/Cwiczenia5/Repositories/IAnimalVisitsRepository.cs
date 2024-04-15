using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public interface IAnimalVisitsRepository
{
    IEnumerable<AnimalVisit> GetAnimalVisits();
    IEnumerable<AnimalVisit> GetAnimalVisitsByAnimalId(int animalId);
    void AddAnimalVisit(AnimalVisit visit);
}