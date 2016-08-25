using System.Data.Entity;
using ElectronicStore.Domain.Entities;

namespace ElectronicStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; } 
    }
}
