using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class Account
{
    public long AccountId { get; set; }

    public string? SpecialAccountName { get; set; }

    public string? BusinessName { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Observation { get; set; }

    public bool Enabled { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public bool? IsBusiness { get; set; }

    public int? AccountType { get; set; }
}
