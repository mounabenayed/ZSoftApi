using System;
using System.Collections.Generic;

namespace Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public Int16 Number { get; set; }
        public float Balance { get; set; }
        public ICollection<Operation> Operations { get; set; }


    }
}
