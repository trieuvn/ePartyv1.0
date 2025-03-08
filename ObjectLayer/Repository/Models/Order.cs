using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

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

    [StringLength(50)]
    public string? CustomerName { get; set; }

    [StringLength(15)]
    public string? CustomerPhoneNumber { get; set; }

    [ForeignKey("Manager")]
    [InverseProperty("Orders")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderHaveFood> OrderHaveFoods { get; set; } = new List<OrderHaveFood>();

    [ForeignKey("OrderId")]
    [InverseProperty("Orders")]
    public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
}
