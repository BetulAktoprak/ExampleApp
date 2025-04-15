using ExampleApp.Entities;
using ExampleProject;
using ExampleProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExampleApp.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ExampleAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-GQ3I60J\\MSSQLSERVER01;Initial Catalog=ExampleAppDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(builder =>
            {
                builder.Property(p => p.UnitPrice).HasColumnType("money");
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Cari> Caris { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

    }
}
