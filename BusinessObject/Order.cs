using System;
using System.Collections.Generic;

namespace BusinessObject;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual OrderItem OrderNavigation { get; set; } = null!;
}
