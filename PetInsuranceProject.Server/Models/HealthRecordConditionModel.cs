using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace PetInsuranceProject.Server.Models;

public class HealthRecordConditionModel
{
    public Guid HealthRecordId { get; set; }
    public int ConditionId { get; set; }

    public HealthRecordModel HealthRecord { get; set; }
    public HealthConditionModel Condition { get; set; }
}
