using System;
using System.Collections.Generic;

namespace Repository.Models;

public partial class AccessToken
{
    public long AccessTokenId { get; set; }

    public Guid AccessToken1 { get; set; }

    public long UserId { get; set; }

    public DateTime CreatedDateTime { get; set; }

    public DateTime ExpirationDateTime { get; set; }

    public virtual User User { get; set; } = null!;
}
