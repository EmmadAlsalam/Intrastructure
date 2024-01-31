using Intrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Intrastructure.Context;

public partial class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public virtual DbSet<CustomerEntity> Customers { get; set; }
    public virtual DbSet<OrderEntity> Orders { get; set; }
    public virtual DbSet<ProductEntity> Products { get; set; }
    public virtual DbSet<OrderItemEntity> OrderItems { get; set; }
    public virtual DbSet<CategoryEntity> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderItemEntity>().HasKey(x => new { x.OrderItemId, x.OrderId });

    }

}

