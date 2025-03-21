using BOLayer.Repository.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("Order")]
public partial class Order
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    public int? NoTables { get; set; }

    [StringLength(50)]
    public string? Address { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeginTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [StringLength(50)]
    public string? Feedback { get; set; }

    [StringLength(50)]
    public string? Manager { get; set; }

    [StringLength(15)]
    public string? PhoneNumber { get; set; }

    public bool? Status { get; set; }

    public int? ActualCost { get; set; }

    [ForeignKey("Manager")]
    [InverseProperty("Orders")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderHaveFood> OrderHaveFoods { get; set; } = new List<OrderHaveFood>();

    [InverseProperty("Order")]
    public virtual ICollection<OrderHaveStaff> OrderHaveStaffs { get; set; } = new List<OrderHaveStaff>(); // Thêm mối quan hệ với OrderHaveStaff

    [ForeignKey("PhoneNumber")]
    [InverseProperty("Orders")]
    public virtual Customer? PhoneNumberNavigation { get; set; }
}