using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

public partial class Staff
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? FullName { get; set; }

    [StringLength(30)]
    public string? Role { get; set; }

    [StringLength(15)]
    public string? PhoneNumber { get; set; }

    [StringLength(50)]
    public string? Location { get; set; }

    public int? Cost { get; set; }

    [StringLength(50)]
    public string? Password { get; set; }

    [StringLength(50)]
    public string? Manager { get; set; }

    [ForeignKey("Manager")]
    [InverseProperty("Staff")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("Staff")]
    public virtual ICollection<StaticStaff> StaticStaffs { get; set; } = new List<StaticStaff>();

    [ForeignKey("StaffId")]
    [InverseProperty("Staff")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
