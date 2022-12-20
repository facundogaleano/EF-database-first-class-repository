using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class ExchangeCurrency
{
    public long ExchangeId { get; set; }

    public long CurrencyId { get; set; }

    public decimal BuyPrice { get; set; }

    public decimal SellPrice { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? UpdatedDateTime { get; set; }

    public bool? Enabled { get; set; }

    public DateTime? DeletedDateTime { get; set; }
}
