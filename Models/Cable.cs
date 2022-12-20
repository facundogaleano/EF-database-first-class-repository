using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Cable
{
    public long CableId { get; set; }

    public long OriginAccountId { get; set; }

    public decimal? OriginCurrencySellValue { get; set; }

    public long DestinationAccountId { get; set; }

    public decimal? DestinationCurrencyBuyValue { get; set; }

    public decimal? OriginCommissionPercentage { get; set; }

    public decimal OriginCommission { get; set; }

    public decimal? DestinationCommissionPercentage { get; set; }

    public decimal DestinationCommission { get; set; }

    public decimal Amount { get; set; }

    public bool Enabled { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public string? State { get; set; }

    public decimal TotalDebitOrigin { get; set; }

    public decimal TotalCreditDestination { get; set; }

    public bool OriginTreasury { get; set; }

    public bool DestinationTreasury { get; set; }

    public string? Concept { get; set; }

    public DateTime? DateOperation { get; set; }

    public long? CreatorUserId { get; set; }

    public long? ValidatorUserId { get; set; }
}
