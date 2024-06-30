using CQRS_Project.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Project.Intrastructure.Databases
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataDbContext).Assembly);
        }
    }
}
