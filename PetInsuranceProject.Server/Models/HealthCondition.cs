using System;
using System.Collections.Generic;

namespace PetInsuranceProject.Server.Models;

public partial class HealthCondition
{
    public int ConditionId { get; set; }

    public string ConditionName { get; set; } = null!;

    public virtual ICollection<HealthRecord> HealthRecords { get; set; } = new List<HealthRecord>();
}
