using System;
using System.Collections.Generic;

namespace PetInsuranceProject.Server.Models;

public partial class QuickQuote
{
    public Guid QuoteId { get; set; }

    public string QuoteUserFirstName { get; set; } = null!;

    public string QuoteUserLastName { get; set; } = null!;

    public string QuoteEmail { get; set; } = null!;

    public Guid PetId { get; set; }

    public virtual Pet Pet { get; set; } = null!;
}
