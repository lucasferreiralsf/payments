using System;
using Payments.Domain.Contracts;
using Payments.Domain.Entities;

namespace Payments.Repository.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository()
        {
        }
    }
}
