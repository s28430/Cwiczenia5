using Cwiczenia5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia5.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalController : ControllerBase
{
    private static readonly List<Animal> Animals =
    [
        new Animal("Joe", AnimalType.Dog, 30, "black"),
        new Animal("Doe", AnimalType.Cat, 5, "beige"),
        new Animal("Burbon", AnimalType.Dog, 45, "black")
    ];
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(Animals);
    }
}