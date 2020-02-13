using System;
using System.Collections.Generic;

namespace Payments.Domain.Entities
{
    public class User : EntityBase
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
