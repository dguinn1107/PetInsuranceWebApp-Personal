namespace PetInsuranceProject.Server.Models;

public class HealthConditionModel
{
    private int _conditionId;
    private Guid _healthId;
    private string _name;

    private HealthRecordModel _health;

    protected HealthConditionModel() { }

    public HealthConditionModel(Guid healthId, string name)
    {
        _conditionId = 0; 
        _healthId = healthId;
        _name = name;
    }
}
