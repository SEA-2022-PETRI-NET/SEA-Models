using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SEA_Models.PetriNet;

public class Place
{
    public int Id { get; set; }
    
    public int PlaceId { get; set; }
    public string? Name { get; set; }
    
<<<<<<< HEAD:Domain/Model/PetriNet/Place.cs
=======
    
>>>>>>> 83a61c487b68da0ef189786cd599f69771a62758:PetriNet/Place.cs
    [JsonIgnore]
    public int? PetriNetId { get; set; }
    [JsonIgnore]
    public PetriNet? PetriNet { get; set; }
    
<<<<<<< HEAD:Domain/Model/PetriNet/Place.cs
    public int? maxAge { get; set; }
    
=======
>>>>>>> 83a61c487b68da0ef189786cd599f69771a62758:PetriNet/Place.cs
    public bool? isUrgent { get; set; }

    // We should either you one or the other of these two fields.
    // This depends on if we are working with a coloured petri net or not. 
    [Range(0, int.MaxValue)]
    public int? NumberOfTokens { get; set; } 
    public List<Token>? Tokens { get; set; }
}