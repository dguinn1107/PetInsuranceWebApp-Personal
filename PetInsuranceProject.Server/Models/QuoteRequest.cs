namespace PetInsuranceProject.Server.Models;

public class QuoteRequest
{
    public string OwnerName  { get; set; } = string.Empty;
    public string OwnerEmail { get; set; } = string.Empty;
    public string PetName    { get; set; } = string.Empty;
    public string PetBreed   { get; set; } = string.Empty;
    public int    PetAge     { get; set; }
}