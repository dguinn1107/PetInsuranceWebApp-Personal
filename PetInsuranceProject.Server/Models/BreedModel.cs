namespace PetInsuranceProject.Server.Models;

public class BreedModel
{
    private int _breedId;
    private string _name;
    private readonly List<PetModel> _pets = new();

    protected BreedModel() { }

    public BreedModel(string name)
    {
        _breedId = 0; //auto incremenet in db?
        _name = name;
    }

    public void AddPet(PetModel pet) => _pets.Add(pet);
}
