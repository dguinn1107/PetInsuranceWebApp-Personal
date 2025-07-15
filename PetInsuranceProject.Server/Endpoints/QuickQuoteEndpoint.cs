using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

using PetInsuranceProject.Server.Database;
using PetInsuranceProject.Server.Models;
namespace PetInsuranceProject.Server.Endpoints;

public static class QuickQuoteEndpoint
{
    public static IEndpointRouteBuilder MapQuickQuoteEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/quick-quote", async (QuickQuote quote, PetInsuranceContext db) =>
        {
            if (string.IsNullOrWhiteSpace(quote.QuoteUserLastName))
                return Results.BadRequest("Last name is required.");

            quote.QuoteId = Guid.NewGuid();
            quote.Pet.PetId = Guid.NewGuid();  

            var breed = await db.Breeds.FindAsync(quote.Pet.BreedId);
            if (breed == null)
                return Results.BadRequest("Invalid breed.");

            quote.Pet.Breed = null;

            decimal premium = quote.Pet.PetAge switch
            {
                _ when quote.Pet.BreedId is 0 or 3 => quote.Pet.PetAge <= 2 ? 200m : quote.Pet.PetAge <= 5 ? 250m : 300m,
                _ when quote.Pet.BreedId is 1 or 4 => quote.Pet.PetAge <= 2 ? 220m : quote.Pet.PetAge <= 5 ? 270m : 320m,
                _ => quote.Pet.PetAge <= 2 ? 180m : quote.Pet.PetAge <= 5 ? 230m : 280m
            };

            db.QuickQuotes.Add(quote);
            await db.SaveChangesAsync();

            return Results.Ok(new { premium });
        });

        return app;
    }

}
//Premium Calculation Explanation:

//The monthly premium is determined based on the pet’s breed and age using this logic:

//For Labrador Retriever (BreedId 0) and Golden Retriever (BreedId 3):

//Age ≤ 2 years: $200

//Age ≤ 5 years: $250

//Older than 5 years: $300

//For French Bulldog (BreedId 1) and Bulldog (English) (BreedId 4):

//Age ≤ 2 years: $220

//Age ≤ 5 years: $270

//Older than 5 years: $320

//For all other breeds:

//Age ≤ 2 years: $180

//Age ≤ 5 years: $230

//Older than 5 years: $280
