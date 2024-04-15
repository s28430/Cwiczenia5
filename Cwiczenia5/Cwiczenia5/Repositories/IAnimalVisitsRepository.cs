using Cwiczenia5.Models;

namespace Cwiczenia5.Repositories;

public interface IAnimalVisitsRepository
{
    IEnumerable<AnimalVisit> GetAnimalVisits();
}