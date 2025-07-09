namespace PetInsuranceProject.Server.Models;

public class HealthConditionModel
{
    public int CondtionId { get; set; }
    public string ConditionName { get; set; }

    //Relationships
    public List<HealthRecordConditionModel> HealthRecordConditions { get; set; } = new List<HealthRecordConditionModel>();
}
