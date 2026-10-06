using Glovebox.api.Models;
using Microsoft.EntityFrameworkCore;

namespace Glovebox.api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Vehicle> Vehicles => Set<Vehicle>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Vehicle>(v =>
        {
            v.HasKey(x => x.Id);
            v.Property(x => x.Make).IsRequired().HasMaxLength(100);
            v.Property(x => x.Model).IsRequired().HasMaxLength(100);
            v.Property(x => x.PurchasePrice).HasPrecision(12, 2);
            v.Property(x => x.SoldPrice).HasPrecision(12, 2);

            // store enums as readable text
            v.Property(x => x.Type).HasConversion<string>();
            v.Property(x => x.FuelType).HasConversion<string>();
            v.Property(x => x.Transmission).HasConversion<string>();
        });
    }
}