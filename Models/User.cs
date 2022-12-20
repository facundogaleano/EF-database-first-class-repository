using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class User
{
    public long UserId { get; set; }

    public string Email { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public bool Enabled { get; set; }

    public int RoleId { get; set; }

    public string? ActivationKey { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime? DeletedDateTime { get; set; }

    public DateTime UpdatedDateTime { get; set; }

    public virtual ICollection<AccessToken> AccessTokens { get; } = new List<AccessToken>();

    public virtual Role Role { get; set; } = null!;
}
