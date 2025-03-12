using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("StaticFood")]
public partial class StaticFood
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? Cost { get; set; }

    [Column("FoodID")]
    public int? FoodId { get; set; }

    [Column("OrderID")]
    public int? OrderId { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("StaticFoods")]
    public virtual Food? Food { get; set; }
}
