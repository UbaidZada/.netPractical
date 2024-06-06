using System;
using System.Collections.Generic;

namespace Practical.Models;

public partial class Cart
{
    public int CartId { get; set; }

    public int? ProductId { get; set; }

    public string? Quantity { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Product? Product { get; set; }
}
