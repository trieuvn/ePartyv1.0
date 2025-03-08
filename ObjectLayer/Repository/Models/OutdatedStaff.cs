using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("OutdatedStaff")]
public partial class OutdatedStaff
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? Cost { get; set; }

    [Column("StaffID")]
    public int? StaffId { get; set; }

    [Column("EventID")]
    public int? EventId { get; set; }

    [ForeignKey("EventId")]
    [InverseProperty("OutdatedStaffs")]
    public virtual OutdatedEvent? Event { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("OutdatedStaffs")]
    public virtual Staff? Staff { get; set; }
}
