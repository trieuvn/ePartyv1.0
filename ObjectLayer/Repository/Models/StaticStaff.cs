using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

[Table("StaticStaff")]
public partial class StaticStaff
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int? Cost { get; set; }

    [Column("StaffID")]
    public int? StaffId { get; set; }

    [Column("OrderID")]
    public int? OrderId { get; set; }

    [ForeignKey("StaffId")]
    [InverseProperty("StaticStaffs")]
    public virtual Staff? Staff { get; set; }
}
