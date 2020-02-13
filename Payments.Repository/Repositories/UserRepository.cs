using System;
using Payments.Domain.Contracts;
using Payments.Domain.Entities;

namespace Payments.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
