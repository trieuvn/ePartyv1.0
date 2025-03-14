using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("Food")]
public partial class Food
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    public int? Amount { get; set; }

    [StringLength(20)]
    public string? Unit { get; set; }

    public int? Cost { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Image { get; set; }

    [StringLength(50)]
    public string? Manager { get; set; }

    [InverseProperty("Food")]
    public virtual ICollection<FoodNeedIngre> FoodNeedIngres { get; set; } = new List<FoodNeedIngre>();

    [ForeignKey("Manager")]
    [InverseProperty("Foods")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("Food")]
    public virtual ICollection<OrderHaveFood> OrderHaveFoods { get; set; } = new List<OrderHaveFood>();

    [InverseProperty("Food")]
    public virtual ICollection<StaticFood> StaticFoods { get; set; } = new List<StaticFood>();
}
