using System;
using System.Collections.Generic;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Repository;

public partial class ePartyDbDbContext : DbContext
{
    public ePartyDbDbContext()
    {
    }

    public ePartyDbDbContext(DbContextOptions<ePartyDbDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodNeedIngre> FoodNeedIngres { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderHaveFood> OrderHaveFoods { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<StaticFood> StaticFoods { get; set; }

    public virtual DbSet<StaticStaff> StaticStaffs { get; set; }

    public virtual DbSet<Supply> Supplies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HUY;Initial Catalog=ePartyDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Foods).HasConstraintName("FK_Food_Manager");
        });

        modelBuilder.Entity<FoodNeedIngre>(entity =>
        {
            entity.HasOne(d => d.Food).WithMany(p => p.FoodNeedIngres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodNeedIngre_Food");

            entity.HasOne(d => d.Ingredient).WithMany(p => p.FoodNeedIngres)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodNeedIngre_Ingredient");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredient_Manager");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Orders).HasConstraintName("FK_Order_Manager");

            entity.HasOne(d => d.PhoneNumberNavigation).WithMany(p => p.Orders).HasConstraintName("FK_Order_Customer");

            entity.HasMany(d => d.Staff).WithMany(p => p.Orders)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderHaveStaff",
                    r => r.HasOne<Staff>().WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OrderHaveStaff_Staff"),
                    l => l.HasOne<Order>().WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_OrderHaveStaff_Order"),
                    j =>
                    {
                        j.HasKey("OrderId", "StaffId");
                        j.ToTable("OrderHaveStaff");
                        j.IndexerProperty<int>("OrderId").HasColumnName("OrderID");
                        j.IndexerProperty<int>("StaffId").HasColumnName("StaffID");
                    });
        });

        modelBuilder.Entity<OrderHaveFood>(entity =>
        {
            entity.HasOne(d => d.Food).WithMany(p => p.OrderHaveFoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveFood_Food");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderHaveFoods)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveFood_Order");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Staff).HasConstraintName("FK_Staff_Manager");
        });

        modelBuilder.Entity<StaticFood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutdatedFood");

            entity.HasOne(d => d.Food).WithMany(p => p.StaticFoods).HasConstraintName("FK_OutdatedFood_Food");
        });

        modelBuilder.Entity<StaticStaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutdatedStaff");

            entity.HasOne(d => d.Staff).WithMany(p => p.StaticStaffs).HasConstraintName("FK_OutdatedStaff_Staff");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity.HasOne(d => d.Ingredient).WithMany(p => p.Supplies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supply_Ingredient");

            entity.HasOne(d => d.Provider).WithMany(p => p.Supplies)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supply_Provider");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
