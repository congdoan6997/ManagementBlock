using ManagementBlock.Data.Entities;
using ManagementBlock.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementBlock.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {

        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
