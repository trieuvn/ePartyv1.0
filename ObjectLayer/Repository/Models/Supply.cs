using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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
    public virtual Ingredient IngredientNavigation { get; set; } = null!; // Renamed to avoid ambiguity

    [ForeignKey("ProviderId")]
    [InverseProperty("Supplies")]
    public virtual Provider ProviderNavigation { get; set; } = null!; // Renamed to avoid ambiguity
}