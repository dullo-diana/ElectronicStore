using System.Collections.Generic;
using ElectronicStore.Domain.Abstract;
using ElectronicStore.Domain.Entities;

namespace ElectronicStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository 
    {
        private readonly EFDbContext _context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get { return _context.Products; }
        }
    }
}
