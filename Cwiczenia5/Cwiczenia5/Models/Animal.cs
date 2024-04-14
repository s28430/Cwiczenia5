using System.ComponentModel.DataAnnotations;

namespace Cwiczenia5.Models;

public class Animal
{
    private static int _nextId = 1;
    public int Id { get; }
    
    [Required]
    [MaxLength(50)]
    public string Name { get; }
    
    [Required]
    public AnimalType AnimalType { get; set; }

    [Required] [Range(1, 50)] public double Weight { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string SkinColor { get; }
    
    public Animal(string name, AnimalType animalType, double weight, string skinColor)
    {
        Id = _nextId;
        _nextId++;
        
        Name = name;
        AnimalType = animalType;
        Weight = weight;
        SkinColor = skinColor;
    }
}
