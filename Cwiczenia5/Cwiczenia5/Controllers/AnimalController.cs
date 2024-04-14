using Cwiczenia5.Models;
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
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = animalService.GetAnimalById(id);
        if (animal == null) return NotFound($"Animal with id {id} was not found");
        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        animalService.AddAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }
}