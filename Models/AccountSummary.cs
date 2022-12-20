using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class AccountSummary
{
    public long SummaryId { get; set; }

    public long AccountId { get; set; }

    public long CurrencyId { get; set; }

    public string Movement { get; set; } = null!;

    public long MovementId { get; set; }

    public string? Detail { get; set; }

    public decimal? Debit { get; set; }

    public decimal? Credit { get; set; }

    public decimal? Balance { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public string? Operation { get; set; }
}
