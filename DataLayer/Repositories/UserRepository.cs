using DataLayer.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserDTO GetUserInfo(string email)
        {
            if (email == null)
                throw new ArgumentNullException();

            return new UserDTO()
            {
                Name = "UserTest",
                Accounts = new List<string>(){ "1", "2" }
            };
        }
    }
}
