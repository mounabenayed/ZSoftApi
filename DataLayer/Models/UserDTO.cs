﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class UserDTO
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public ICollection<string> Accounts { get; set; }
    }
}
