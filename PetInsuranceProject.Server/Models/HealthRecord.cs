using System;
using System.Collections.Generic;

namespace PetInsuranceProject.Server.Models;

public partial class HealthRecord
{
    public Guid HealthRecordId { get; set; }

    public Guid PetId { get; set; }

    public bool Healthy { get; set; }

    public DateTime RecordDate { get; set; }

    public virtual ICollection<HealthCondition> Conditions { get; set; } = new List<HealthCondition>();
}
