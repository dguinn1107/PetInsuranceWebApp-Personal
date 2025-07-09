using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetInsuranceProject.Server.Models;

public class PetModel
{
    [Key]
    public Guid PetId { get; set; }

    public string PetName { get; set; }
    public int PetAge { get; set; }

    public bool petSex { get; set; }

    // Foreign key and relationship
    public Guid BreedId { get; set; }

    [ForeignKey("BreedId")]
    public BreedModel Breed { get; set; }

    //Realtionships
    public List<QuickQuoteModel> Quotes { get; set; } = new List<QuickQuoteModel>();

    public List<HealthRecordModel> HealthRecords { get; set; } = new List<HealthRecordModel>();


}
