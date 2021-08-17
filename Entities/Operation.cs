using System;

namespace Entities
{
    public class Operation
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public float Amount { get; set; }
    }
}
