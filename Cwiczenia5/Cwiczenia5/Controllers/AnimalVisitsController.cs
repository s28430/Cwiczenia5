using Cwiczenia5.Models;
using Cwiczenia5.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia5.Controllers;

[ApiController]
[Route("/api/visits")]
public class AnimalVisitsController(IAnimalVisitsService animalVisitsService) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimalVisits()
    {
        return Ok(animalVisitsService.GetAnimalVisits());
    }

    [HttpGet("{animalId:int}")]
    public IActionResult GetAnimalsVisitsForAnimal(int animalId)
    {
        var animalVisits = animalVisitsService.GetAnimalVisitsByAnimalId(animalId);
        return Ok(animalVisits);
    }

    [HttpPost]
    public IActionResult AddAnimalVisit(AnimalVisit animalVisit)
    {
        animalVisitsService.AddAnimalVisit(animalVisit);
        return StatusCode(StatusCodes.Status201Created);
    }
}