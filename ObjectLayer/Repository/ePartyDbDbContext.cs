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
    public virtual DbSet<OrderHaveStaff> OrderHaveStaffs { get; set; }
    public virtual DbSet<Provider> Providers { get; set; }
    public virtual DbSet<Staff> Staff { get; set; }
    public virtual DbSet<StaticFood> StaticFoods { get; set; }
    public virtual DbSet<StaticStaff> StaticStaffs { get; set; }
    public virtual DbSet<Supply> Supplies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ePartyDb;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation)
                .WithMany(p => p.Foods)
                .HasForeignKey(d => d.Manager)
                .HasConstraintName("FK_Food_Manager");
        });

        modelBuilder.Entity<FoodNeedIngre>(entity =>
        {
            entity.HasKey(e => new { e.FoodId, e.IngredientId });

            entity.HasOne(d => d.Food)
                .WithMany(p => p.FoodNeedIngres)
                .HasForeignKey(d => d.FoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodNeedIngre_Food");

            entity.HasOne(d => d.Ingredient)
                .WithMany(p => p.FoodNeedIngres)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FoodNeedIngre_Ingredient");
        });

        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation)
                .WithMany(p => p.Ingredients)
                .HasForeignKey(d => d.Manager)
                .HasConstraintName("FK_Ingredient_Manager");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.Manager)
                .HasConstraintName("FK_Order_Manager");

            entity.HasOne(d => d.PhoneNumberNavigation)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.PhoneNumber)
                .HasConstraintName("FK_Order_Customer");
        });

        modelBuilder.Entity<OrderHaveFood>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.FoodId });

            entity.HasOne(d => d.Food)
                .WithMany(p => p.OrderHaveFoods)
                .HasForeignKey(d => d.FoodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveFood_Food");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderHaveFoods)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrderHaveFood_Order");
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

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasOne(d => d.ManagerNavigation)
                .WithMany(p => p.Staff)
                .HasForeignKey(d => d.Manager)
                .HasConstraintName("FK_Staff_Manager");
        });

        modelBuilder.Entity<StaticFood>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutdatedFood");

            entity.HasOne(d => d.Food)
                .WithMany(p => p.StaticFoods)
                .HasForeignKey(d => d.FoodId)
                .HasConstraintName("FK_OutdatedFood_Food");
        });

        modelBuilder.Entity<StaticStaff>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_OutdatedStaff");

            entity.HasOne(d => d.Staff)
                .WithMany(p => p.StaticStaffs)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK_OutdatedStaff_Staff");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity.HasKey(e => new { e.IngredientId, e.ProviderId });

            entity.HasOne(d => d.IngredientNavigation)
                .WithMany(p => p.Supplies)
                .HasForeignKey(d => d.IngredientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supply_Ingredient");

            entity.HasOne(d => d.ProviderNavigation)
                .WithMany(p => p.Supplies)
                .HasForeignKey(d => d.ProviderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Supply_Provider");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}