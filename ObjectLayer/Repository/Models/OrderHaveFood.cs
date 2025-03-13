using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[PrimaryKey("OrderId", "FoodId")]
[Table("OrderHaveFood")]
public partial class OrderHaveFood
{
    [Key]
    [Column("OrderID")]
    public int OrderId { get; set; }

    [Key]
    [Column("FoodID")]
    public int FoodId { get; set; }

    public int? Amount { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("OrderHaveFoods")]
    public virtual Food Food { get; set; } = null!;

    [ForeignKey("OrderId")]
    [InverseProperty("OrderHaveFoods")]
    public virtual Order Order { get; set; } = null!;
}
