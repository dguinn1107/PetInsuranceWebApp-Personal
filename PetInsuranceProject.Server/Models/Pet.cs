using System;
using System.Collections.Generic;

namespace PetInsuranceProject.Server.Models;

public partial class Pet
{
    public Guid PetId { get; set; }

    public string PetName { get; set; } = null!;

    public int PetAge { get; set; }

    public bool PetSex { get; set; }

    public int BreedId { get; set; }

    public virtual Breed Breed { get; set; } = null!;

    public virtual ICollection<QuickQuote> QuickQuotes { get; set; } = new List<QuickQuote>();
}
