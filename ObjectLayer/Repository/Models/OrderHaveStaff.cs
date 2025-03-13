using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("OrderHaveStaff")]
public partial class OrderHaveStaff
{
    [Key]
    [Column("OrderID")]
    public int OrderId { get; set; }

    [Key]
    [Column("StaffID")]
    public int StaffId { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderHaveStaffs")]
    public virtual Order Order { get; set; } = null!;

    [ForeignKey("StaffId")]
    [InverseProperty("OrderHaveStaffs")]
    public virtual Staff Staff { get; set; } = null!;
}