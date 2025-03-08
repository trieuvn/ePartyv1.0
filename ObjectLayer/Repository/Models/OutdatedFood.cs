using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("OutdatedFood")]
public partial class OutdatedFood
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? Cost { get; set; }

    [Column("FoodID")]
    public int? FoodId { get; set; }

    [Column("EventID")]
    public int? EventId { get; set; }

    [ForeignKey("EventId")]
    [InverseProperty("OutdatedFoods")]
    public virtual OutdatedEvent? Event { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("OutdatedFoods")]
    public virtual Food? Food { get; set; }
}
