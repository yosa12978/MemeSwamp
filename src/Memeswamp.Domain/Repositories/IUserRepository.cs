using Memeswamp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User, string>
    {
        Task<bool> IsEmailTaken(string email);
        Task<bool> IsUserExist(string email, string password);
        Task<User?> GetUser(string email, string password);
    }
}
