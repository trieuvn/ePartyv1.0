using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("Manager")]
public partial class Manager
{
    [Key]
    [StringLength(50)]
    public string UserName { get; set; } = null!;

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? FullName { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    [StringLength(30)]
    public string? Email { get; set; }

    [StringLength(15)]
    public string? PhoneNumber { get; set; }

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<OutdatedEvent> OutdatedEvents { get; set; } = new List<OutdatedEvent>();

    [InverseProperty("ManagerNavigation")]
    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
