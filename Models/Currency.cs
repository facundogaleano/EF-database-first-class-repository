using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Currency
{
    public long CurrencyId { get; set; }

    public string? CurrencyName { get; set; }

    public string? Iso { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public bool Enabled { get; set; }
}
