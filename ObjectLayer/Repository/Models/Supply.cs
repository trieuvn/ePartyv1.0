using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[PrimaryKey("IngredientId", "ProviderId")]
[Table("Supply")]
public partial class Supply
{
    [Key]
    [Column("IngredientID")]
    public int IngredientId { get; set; }

    [Key]
    [Column("ProviderID")]
    public int ProviderId { get; set; }

    public int? Cost { get; set; }

    [ForeignKey("IngredientId")]
    [InverseProperty("Supplies")]
    public virtual Ingredient Ingredient { get; set; } = null!;

    [ForeignKey("ProviderId")]
    [InverseProperty("Supplies")]
    public virtual Provider Provider { get; set; } = null!;
}
