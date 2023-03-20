using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Account
{
    public int AccountId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int Type { get; set; }
}
