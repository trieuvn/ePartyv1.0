using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOLayer.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace BOLayer.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodNeedIngre> FoodNeedIngres { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<IngreSupplyProvider> IngresupplyProviders { get; set; }
        public DbSet<Manager> managers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderHaveFood> ordersHaveFood { get; set; }
        public DbSet<OutdatedEvent> outdatedEvents { get; set; }
        public DbSet<OutdatedFood> outdatedFood { get; set; }
        public DbSet<Provider> providers { get; set; }
        public DbSet<Staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-M0KCUVC;Initial Catalog=ePartyDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Description).HasMaxLength(50);
                entity.Property(e => e.Address).HasMaxLength(50);
                entity.Property(e => e.Feedback).HasMaxLength(50);
                entity.Property(e => e.Manager).HasMaxLength(50);
                entity.Property(e => e.CustomerName).HasMaxLength(50);
                entity.Property(e => e.CustomerPhoneNumber).HasMaxLength(15);
            });
        }
    }
}
