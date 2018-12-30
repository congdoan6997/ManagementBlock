using ManagementBlock.Data.Entities;
using ManagementBlock.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementBlock.Data.IRepositories
{
    public interface IProductRepository : IRepository<Product, int>
    {
    }
}
