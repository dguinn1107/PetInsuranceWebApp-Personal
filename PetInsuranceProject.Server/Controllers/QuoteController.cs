using Microsoft.AspNetCore.Mvc;
using PetInsuranceProject.Server.Models;

namespace PetInsuranceProject.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QuoteController : ControllerBase
{
    private readonly Dictionary<string, decimal> breedModifiers = new()
    {
        { "Labrador Retriever", 0.00m },
        { "French Bulldog",    0.40m },
        { "German Shepherd",   0.30m },
        { "Golden Retriever",  0.25m },
        { "Bulldog (English)", 0.50m },
        { "Beagle",           -0.10m },
        { "Shih Tzu",         -0.05m },
        { "Chihuahua",        -0.15m },
        { "Rottweiler",        0.35m },
        { "Poodle (Standard)",-0.10m }
    };

    // Age modifiers calculated from average monthly prices vs $40 baseline
    // Age 1 uses baseline (no modifier), ages 2-9 from provided data, ages 10-14 extrapolated +3.5% bump
    private readonly Dictionary<int, decimal> ageModifiers = new()
    {
        { 2, 0.64m },  // (65.41-40)/40
        { 3, 0.75m },  // (69.94-40)/40
        { 4, 0.86m },  // (74.47-40)/40
        { 5, 0.98m },  // (79.00-40)/40
        { 6, 1.31m },  // (92.59-40)/40
        { 7, 1.77m },  // (110.71-40)/40
        { 8, 2.22m },  // (128.83-40)/40
        { 9, 2.67m },  // (146.95-40)/40
        {10, 3.13m },  // extrapolated from provided trend
        {11, 3.61m },  // +3.5% bump
        {12, 4.07m },  // +3.5% bump
        {13, 4.52m },  // +3.5% bump
        {14, 4.97m }   // +3.5% bump
    };

    [HttpPost]
    public ActionResult<QuoteResponse> GetQuote([FromBody] QuoteRequest request)
    {
        try
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(request.PetBreed) || !breedModifiers.ContainsKey(request.PetBreed))
                return BadRequest("Unsupported or missing breed.");

            if (request.PetAge < 1 || request.PetAge > 14)
                return BadRequest("Pet age must be between 1 and 14.");

            const decimal baseRate = 20.00m;
            var breedFactor = breedModifiers[request.PetBreed];
            decimal ageFactor = ageModifiers.TryGetValue(request.PetAge, out var af) ? af : 0.00m;

            var premium = baseRate * (1 + breedFactor) * (1 + ageFactor);
            var rounded = Math.Round(premium, 2);
            return Ok(new QuoteResponse { MonthlyPremium = rounded });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            return StatusCode(500, "Internal Server Error");
        }
    }
}