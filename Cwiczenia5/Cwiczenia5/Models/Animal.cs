namespace Cwiczenia5.Models;

public class Animal
{
    private static int _nextId = 1;
    public int Id { get; }
    public string Name { get; }
    public AnimalType Type;
    public double Weight { get; set; }
    public string SkinColor { get; }
    
    public Animal(string name, AnimalType type, double weight, string skinColor)
    {
        Id = _nextId;
        _nextId++;
        
        Name = name;
        Type = type;
        Weight = weight;
        SkinColor = skinColor;
    }
}
