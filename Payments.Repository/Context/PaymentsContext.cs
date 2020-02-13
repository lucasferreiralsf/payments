using System;
using Microsoft.EntityFrameworkCore;
using Payments.Domain.Entities;
using Payments.Domain.ValueObjects;
using Payments.Repository.Config;

namespace Payments.Repository.Context
{
    public class PaymentsContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethods> PaymentMethods { get; set; }

        public PaymentsContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new OrderItemConfig());
            modelBuilder.ApplyConfiguration(new PaymentMethodsConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
