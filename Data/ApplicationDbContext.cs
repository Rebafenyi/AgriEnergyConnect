using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Farmer> Farmers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Solar Panel Kit",
                    Price = 1200.00m,
                    Description = "Complete off-grid solar solution",
                    CreatedDate = new DateTime(2024, 01, 01)
                },
                new Product
                {
                    Id = 2,
                    Name = "Wind Turbine",
                    Price = 3500.00m,
                    Description = "High-efficiency small wind turbine",
                    CreatedDate = new DateTime(2024, 02, 01)
                },
                new Product
                {
                    Id = 3,
                    Name = "Irrigation Controller",
                    Price = 850.00m,
                    Description = "Automated irrigation system",
                    CreatedDate = new DateTime(2024, 03, 01)
                }
            );

            // Apply column precision for Price
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            // Seed Providers (Employees)
            modelBuilder.Entity<Employees>().HasData(
                new Employees
                {
                    Id = 1,
                    EmployeeName = "Tau",
                    Email = "info@greentech.com",
                    Phone = "011-278-4387"
                },
                new Employees
                {
                    Id = 2,
                    EmployeeName = "Sfiso",
                    Email = "contact@agrosolar.com",
                    Phone = "011-973-3518"
                }
            );

            // Seed Farmers (fixed with required fields)
                    modelBuilder.Entity<Farmer>().HasData(
            new Farmer
            {
                Id = 1,
                FarmName = "Green Field",
                FullName = "zakhele",
                Location = "limpopo",
                Email = "zakheleseme@gmail.com",
                Phone = "074-737-9533",
                CreatedBy = "System"
            },
            new Farmer
            {
                Id = 2,
                FarmName = "Solar Valley",
                FullName = "Tebogo Seme",
                Location = "Gauteng",
                Email = "tebogoseme7@gmail.com",
                Phone = "060-973-3518",
                CreatedBy = "Admin"
            }
        );
        }
    }
}
