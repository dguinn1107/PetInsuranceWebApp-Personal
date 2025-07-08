namespace PetInsuranceProject.Server.Models;
public class QuickQuoteModel
{
    private Guid _quoteId;
    private string _userName;
    private string _email;
    private Guid _petId;
    private Guid _healthId;

    private PetModel _pet;
    private HealthRecordModel _health;

    protected QuickQuoteModel() { }

    public QuickQuoteModel(string userName, string email, Guid petId, Guid healthId)
    {
        _quoteId = Guid.NewGuid();
        _userName = userName;
        _email = email;
        _petId = petId;
        _healthId = healthId;
    }
}





