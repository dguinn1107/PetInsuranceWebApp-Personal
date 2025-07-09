using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetInsuranceProject.Server.Models;

public class HealthRecordModel
{
    [Key]
    public Guid HealthRecordId { get; set; }

    public bool isHealthy { get; set; } 
    public DateTime RecordDate { get; set; }



    //Pet
    public Guid PetId { get; set; }
    [ForeignKey("PetId")]
    public PetModel Pet { get; set; }



    //Relationships
    public List<HealthRecordConditionModel> HealthRecordConditions { get; set; } = new List<HealthRecordConditionModel>();



}


