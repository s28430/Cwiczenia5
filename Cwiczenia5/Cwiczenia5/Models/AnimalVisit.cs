using System.ComponentModel.DataAnnotations;

namespace Cwiczenia5.Models;

public class AnimalVisit
{
    private static int _nextVisitId = 1;
    
    public int VisitId { get; }
    
    [Required]
    [Range(1, 1000)]
    public int AnimalId { get; }
    
    [Required]
    public DateTime VisitDate { get; }
    
    [Required]
    public string VisitDescription { get; set; }
    
    [Required]
    [Range(1, 1000)]
    public double VisitPrice { get; }

    public AnimalVisit(int animalId, DateTime visitDate, string visitDescription, double visitPrice)
    {
        VisitId = _nextVisitId;
        _nextVisitId++;

        AnimalId = animalId;
        VisitDate = visitDate;
        VisitDescription = visitDescription;
        VisitPrice = visitPrice;
    }
}