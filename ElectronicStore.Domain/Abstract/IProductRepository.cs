using ElectronicStore.Domain.Entities;
using System.Collections.Generic;

namespace ElectronicStore.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
