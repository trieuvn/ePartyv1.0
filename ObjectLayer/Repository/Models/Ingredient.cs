using BOLayer.Repository.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Ingredient")]
public partial class Ingredient
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(20)]
    public string? Unit { get; set; }

    public int? Cost { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [StringLength(50)]
    public string? Manager { get; set; }

    [InverseProperty("Ingredient")]
    public virtual ICollection<FoodNeedIngre> FoodNeedIngres { get; set; } = new List<FoodNeedIngre>();

    [ForeignKey("Manager")]
    [InverseProperty("Ingredients")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("IngredientNavigation")] // Update to match the renamed property in Supply
    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}