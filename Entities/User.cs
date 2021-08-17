using System;
using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<Account> Accounts { get; set; }

    }
}
