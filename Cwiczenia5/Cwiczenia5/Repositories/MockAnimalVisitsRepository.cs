using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public class MockAnimalVisitsRepository : IAnimalVisitsRepository
{
    private static readonly List<AnimalVisit> AnimalVisits =
    [
        new AnimalVisit(1, DateTime.Today, "visit for animal 1", 450),
        new AnimalVisit(3, DateTime.Parse("2024-03-15"), "visit for animal 3", 1000),
        new AnimalVisit(2, DateTime.Parse("2024-03-25"), "visit for animal 2", 500)
    ];
    public IEnumerable<AnimalVisit> GetAnimalVisits()
    {
        return AnimalVisits;
    }

    public IEnumerable<AnimalVisit> GetAnimalVisitsByAnimalId(int animalId)
    {
        return AnimalVisits.FindAll(visit => visit.AnimalId == animalId);
    }

    public void AddAnimalVisit(AnimalVisit visit)
    {
        AnimalVisits.Add(visit);
    }
}