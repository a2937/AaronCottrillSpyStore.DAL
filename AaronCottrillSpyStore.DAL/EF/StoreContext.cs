using AaronCottrillSpyStore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


/**
 * Don`t forget to add an application config so we can change the server. 
 * https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/index?tabs=basicconfiguration
 * 
 */
namespace AaronCottrillSpyStore.DAL.EF
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {

        }

        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AaronCottrillSpyStore;Trusted_Connection=True;MultipleActiveResultSets=true;"
                    //,
                    //options => options.ExecutionStrategy(c => new MyExecutionStrategy(c))
                    //options => options.EnableRetryOnFailure()
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.EmailAddress).HasName("IX_Customers").IsUnique();
            });
            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
                entity.Property(e => e.ShipDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
            });
            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.Property(e => e.LineItemTotal)
                .HasColumnType("money")
                .HasComputedColumnSql("[Quantity] * [UnitCost]");
                entity.Property(e => e.UnitCost).HasColumnType("money");
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.UnitCost).HasColumnType("money");
                entity.Property(e => e.CurrentPrice).HasColumnType("money");
            });
            modelBuilder.Entity<ShoppingCartRecord>(entity =>
            {
                entity.HasIndex("IX_ShoppingCarty")
                .IsUnique();
                entity.Property(e => e.DateCreated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()");
                entity.Property(e => e.Quantity).HasDefaultValue(1);
            });
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ShoppingCartRecord> ShoppingCartRecords { get; set; }
    }
}
