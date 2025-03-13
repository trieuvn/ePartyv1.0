using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("OutdatedEvent")]
public partial class OutdatedEvent
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    public int? NoTables { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BeginTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    public int? ActualCost { get; set; }

    [StringLength(50)]
    public string? Manager { get; set; }

    [ForeignKey("Manager")]
    [InverseProperty("OutdatedEvents")]
    public virtual Manager? ManagerNavigation { get; set; }

    [InverseProperty("Event")]
    public virtual ICollection<OutdatedFood> OutdatedFoods { get; set; } = new List<OutdatedFood>();

    [InverseProperty("Event")]
    public virtual ICollection<OutdatedStaff> OutdatedStaffs { get; set; } = new List<OutdatedStaff>();
}
