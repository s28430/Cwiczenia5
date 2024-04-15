using Cwiczenia5.Models;

namespace Cwiczenia5.Services;

public interface IAnimalVisitsService
{
    IEnumerable<AnimalVisit> GetAnimalVisits();
}