using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace SEA_Models.Model;

public class Place
{
    public int Id { get; set; }
    
    public int PlaceId { get; set; }
    public string? Name { get; set; }
    
    [Range(0, int.MaxValue)]
    public int? NumberOfTokens { get; set; }
    
    [JsonIgnore]
    public int? PetriNetId { get; set; }
    [JsonIgnore]
    public PetriNet? PetriNet { get; set; }
}