using System;
using System.Collections.Generic;

namespace Assignment2.Model
{
    public partial class Account
    {
        public int AccountId { get; set; }
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FullName { get; set; }
        public int Type { get; set; }
    }
}
