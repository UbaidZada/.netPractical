using System;
using System.Collections.Generic;

namespace Practical.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string? ProdName { get; set; }

    public double? ProdPrice { get; set; }

    public string? ProdDesc { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
