using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[PrimaryKey("FoodId", "IngredientId")]
[Table("FoodNeedIngre")]
public partial class FoodNeedIngre
{
    [Key]
    [Column("FoodID")]
    public int FoodId { get; set; }

    [Key]
    [Column("IngredientID")]
    public int IngredientId { get; set; }

    public int? Amount { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("FoodNeedIngres")]
    public virtual Food Food { get; set; } = null!;

    [ForeignKey("IngredientId")]
    [InverseProperty("FoodNeedIngres")]
    public virtual Ingredient Ingredient { get; set; } = null!;
}
