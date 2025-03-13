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

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<FoodNeedIngre> FoodNeedIngres { get; set; }

    public virtual DbSet<IngreSupplyProvider> IngreSupplyProviders { get; set; }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderHaveFood> OrderHaveFoods { get; set; }

    public virtual DbSet<OutdatedEvent> OutdatedEvents { get; set; }

    public virtual DbSet<OutdatedFood> OutdatedFoods { get; set; }

    public virtual DbSet<OutdatedStaff> OutdatedStaffs { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<OrderHaveStaff> OrderHaveStaffs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

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

        modelBuilder.Entity<IngreSupplyProvider>(entity =>
        {
            entity.HasOne(d => d.Ingredient).WithMany(p => p.IngreSupplyProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngreSupplyProvider_Ingredient");

            entity.HasOne(d => d.Provider).WithMany(p => p.IngreSupplyProviders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IngreSupplyProvider_Provider");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Ingredients).HasConstraintName("FK_Ingredient_Manager");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation)
                .WithMany(p => p.Orders)
                .HasConstraintName("FK_Order_Manager");

            // Update the relationship to use the renamed Customer property
            entity.HasOne(d => d.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.PhoneNumber)
                .HasConstraintName("FK_Order_Customer");
        });

        modelBuilder.Entity<OrderHaveStaff>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.StaffId });

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderHaveStaffs)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveStaff_Order");

            entity.HasOne(d => d.Staff)
                .WithMany(p => p.OrderHaveStaffs)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveStaff_Staff");
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

        modelBuilder.Entity<OutdatedEvent>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.OutdatedEvents).HasConstraintName("FK_OutdatedEvent_Manager");
        });

        modelBuilder.Entity<OutdatedFood>(entity =>
        {
            entity.HasOne(d => d.Event).WithMany(p => p.OutdatedFoods).HasConstraintName("FK_OutdatedFood_OutdatedEvent");

            entity.HasOne(d => d.Food).WithMany(p => p.OutdatedFoods).HasConstraintName("FK_OutdatedFood_Food");
        });

        modelBuilder.Entity<OutdatedStaff>(entity =>
        {
            entity.HasOne(d => d.Event).WithMany(p => p.OutdatedStaffs).HasConstraintName("FK_OutdatedStaff_OutdatedEvent");

            entity.HasOne(d => d.Staff).WithMany(p => p.OutdatedStaffs).HasConstraintName("FK_OutdatedStaff_Staff");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.Staff).HasConstraintName("FK_Staff_Manager");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}