using System;
using System.Collections.Generic;

namespace Assignment2.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string Password { get; set; } = null!;
        public string ContactName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
