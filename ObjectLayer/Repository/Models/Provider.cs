using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Provider")]
public partial class Provider
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    [StringLength(15)]
    public string? PhoneNumber { get; set; }

    [InverseProperty("ProviderNavigation")] // Update to match the renamed property in Supply
    public virtual ICollection<Supply> Supplies { get; set; } = new List<Supply>();
}