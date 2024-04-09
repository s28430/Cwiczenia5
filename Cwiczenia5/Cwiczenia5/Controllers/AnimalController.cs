using Cwiczenia5.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia5.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalController(IAnimalService animalService) : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
         return Ok(animalService.GetAnimals());
    }
}