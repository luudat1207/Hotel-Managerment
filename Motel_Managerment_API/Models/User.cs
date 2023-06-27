using System;
using System.Collections.Generic;

namespace Motel_Managerment_API.Models
{
    public partial class User
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Role { get; set; }
    }
}
