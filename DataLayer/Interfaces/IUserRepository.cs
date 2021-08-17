﻿using DataLayer.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfaces
{
    public interface IUserRepository 
    {
        UserDTO GetUserInfo(string email);
    }
}
