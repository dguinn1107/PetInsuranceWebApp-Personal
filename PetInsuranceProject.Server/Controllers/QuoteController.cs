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
        { "French Bulldog", 0.40m },
        { "German Shepherd", 0.30m },
        { "Golden Retriever", 0.25m },
        { "Bulldog (English)", 0.50m },
        { "Beagle", -0.10m },
        { "Shih Tzu", -0.05m },
        { "Chihuahua", -0.15m },
        { "Rottweiler", 0.35m },
        { "Poodle (Standard)", -0.10m }
    };

    private readonly Dictionary<int, decimal> ageModifiers = new()
    {
        { 2, 0.05m }, { 3, 0.08m }, { 4, 0.10m },
        { 5, 0.12m }, { 6, 0.15m }, { 7, 0.18m },
        { 8, 0.20m }, { 9, 0.22m }, { 10, 0.25m },
        { 11, 0.27m }, { 12, 0.30m }, { 13, 0.35m }, { 14, 0.40m }
    };

    [HttpPost]
    public ActionResult<QuoteResponse> GetQuote([FromBody] QuoteRequest request)
    {
        const decimal baseRate = 50.00m;

        if (!breedModifiers.TryGetValue(request.PetBreed, out var breedFactor))
            return BadRequest("Unsupported breed.");

        decimal ageMultiplier = 1.0m;
        for (int i = 2; i <= request.PetAge; i++)
            if (ageModifiers.TryGetValue(i, out var inc))
                ageMultiplier *= (1 + inc);

        var finalPremium = baseRate * (1 + breedFactor) * ageMultiplier;

        return Ok(new QuoteResponse { MonthlyPremium = Math.Round(finalPremium, 2) });
    }
}