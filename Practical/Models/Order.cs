using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Practical.Models;

public partial class Order
{
    [Key]
    public int OrderId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual Product? Product { get; set; }
}
