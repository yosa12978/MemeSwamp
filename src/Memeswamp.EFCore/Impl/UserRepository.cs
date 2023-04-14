using Memeswamp.EFCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memeswamp.EFCore.Impl
{
    public class UserRepository : BaseRepository<User, string>, IUserRepository
    {
        public UserRepository(DatabaseContext db) : base(db)
        {

        }

        public Task<User?> GetUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsEmailTaken(string email)
        {
            return await Task.Run(() => _db.users.Any(x => x.email == email));
        }

        public Task<bool> IsUserExist(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
