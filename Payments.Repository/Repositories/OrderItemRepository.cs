using System;
using Payments.Domain.Contracts;
using Payments.Domain.Entities;

namespace Payments.Repository.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository()
        {
        }
    }
}
