namespace PetInsuranceProject.Server.Models;

public class PetModel
{
    private Guid _petId;
    private string _petName;
    private Guid _breedId;
    private int _petAge;
    private bool _petSex;

    private BreedModel _breed;
    private readonly List<HealthRecordModel> _healthRecords = new();
    private readonly List<QuickQuote> _quickQuotes = new();

    protected PetModel() { }

    public PetModel(string petName, Guid breedId, int petAge, bool petSex)
    {
        _petId = Guid.NewGuid();
        _petName = petName;
        _breedId = breedId;
        _petAge = petAge;
        _petSex = petSex;
    }

    public void AddHealthRecord(HealthRecordModel health) => _healthRecords.Add(health);
    public void AddQuote(QuickQuote quote) => _quickQuotes.Add(quote);
}
