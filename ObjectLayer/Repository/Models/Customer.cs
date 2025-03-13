﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BOLayer.Repository.Models;

[Table("Customer")]
public partial class Customer
{
    [Key]
    [StringLength(15)]
    public string PhoneNumber { get; set; } = null!;

    [StringLength(50)]
    public string? Name { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}