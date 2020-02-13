using System;
using Payments.Domain.Contracts;
using Payments.Domain.Entities;

namespace Payments.Repository.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository()
        {
        }
    }
}
