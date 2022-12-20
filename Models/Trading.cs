using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Trading
{
    public long TradingId { get; set; }

    public long DestinationAccountId { get; set; }

    public long CurrencyId { get; set; }

    public decimal Amount { get; set; }

    public string State { get; set; } = null!;

    public string Concept { get; set; } = null!;

    public long CashAccountId { get; set; }

    public decimal? ExchangeCurrencyValue { get; set; }

    public string? OperationType { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public bool Enabled { get; set; }

    public long? DestinationCurrencyId { get; set; }

    public long? CreatorUserId { get; set; }

    public long? ValidatorUserId { get; set; }
}
