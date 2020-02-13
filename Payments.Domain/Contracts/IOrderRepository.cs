using System;
using Payments.Domain.Entities;

namespace Payments.Domain.Contracts
{
    public interface IOrderRepository : IRepositoryBase<Order>
    {
    }
}
