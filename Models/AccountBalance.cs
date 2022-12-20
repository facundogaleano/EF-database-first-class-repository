using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class AccountBalance
{
    public long BalanceId { get; set; }

    public long AccountId { get; set; }

    public long CurrencyId { get; set; }

    public decimal Balance { get; set; }
}
