using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class DebtFree
{
    public long DebtFreeId { get; set; }

    public long OriginAccountId { get; set; }

    public long DestinationAccountId { get; set; }

    public string? Concept { get; set; }

    public long CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public bool? Enabled { get; set; }

    public bool? Approved { get; set; }

    public string? State { get; set; }

    public long? CreatorUserId { get; set; }
}
