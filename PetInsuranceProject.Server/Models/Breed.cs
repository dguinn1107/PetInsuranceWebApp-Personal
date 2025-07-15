using System;
using System.Collections.Generic;

namespace PetInsuranceProject.Server.Models;

public partial class Breed
{
    public int BreedId { get; set; }

    public string BreedName { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
