﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("Staff")]
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
    public virtual ICollection<OutdatedStaff> OutdatedStaffs { get; set; } = new List<OutdatedStaff>();

    // Add navigation property for OrderHaveStaff
    [InverseProperty("Staff")]
    public virtual ICollection<OrderHaveStaff> OrderHaveStaffs { get; set; } = new List<OrderHaveStaff>();
}