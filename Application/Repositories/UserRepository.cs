
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repositories
{
    public class UserRepository : GenericRepository<User>, IUser
    {
        public UserRepository(MainContext context) : base(context)
        {
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await  _context.Users.Where(x => x.Username.ToLower() == username.ToLower())
                                       .Include(x => x.Rols)
                                       .FirstOrDefaultAsync();
        }
    }
}