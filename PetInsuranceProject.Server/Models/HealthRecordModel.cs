namespace PetInsuranceProject.Server.Models;

public class HealthRecordModel
{
        private Guid _healthId;
        private Guid _petId;
        private bool _healthy;
        private DateTime _recordDate;

        private PetModel _pet;
        private readonly List<HealthConditionModel> _conditions = new();

        protected HealthRecordModel() { }

        public HealthRecordModel(Guid petId, bool healthy, DateTime recordDate)
        {
            _healthId = Guid.NewGuid();
            _petId = petId;
        //add some logic to check healthconditoion table if healthy before assigning
            _healthy = healthy;
            _recordDate = recordDate;
        }

        public void AddCondition(HealthConditionModel condition) => _conditions.Add(condition);
    }


