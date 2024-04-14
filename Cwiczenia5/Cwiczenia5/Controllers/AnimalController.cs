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
        animalService.AddAnimal(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateAnimal(int id, [FromBody] Animal newAnimal)
    {
        var animalToEdit = animalService.GetAnimalById(id);
        if (animalToEdit == null) return NotFound($"Animal with id {id} was not found");
        var result = animalService.UpdateAnimal(id, newAnimal);
        return StatusCode(result ? StatusCodes.Status204NoContent : StatusCodes.Status400BadRequest);
    }

    [HttpDelete("{id:int}")]
    public IActionResult RemoveAnimal(int id)
    {
        var result = animalService.RemoveAnimal(id);
        
        return StatusCode(result ? StatusCodes.Status204NoContent : StatusCodes.Status400BadRequest);
    }
}