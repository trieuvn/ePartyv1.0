using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository.Models;

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

    [InverseProperty("Provider")]
    public virtual ICollection<IngreSupplyProvider> IngreSupplyProviders { get; set; } = new List<IngreSupplyProvider>();
}
