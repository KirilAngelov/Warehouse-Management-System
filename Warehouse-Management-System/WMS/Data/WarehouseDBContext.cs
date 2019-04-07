using Microsoft.EntityFrameworkCore;
using WMS.Data.Models;

namespace WMS.Data
{
    public class WarehouseDBContext:DbContext
    {
        public WarehouseDBContext()
        {

        }
        public WarehouseDBContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection.connection);
            }
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
