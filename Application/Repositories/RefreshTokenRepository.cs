
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshToken
    {
        public RefreshTokenRepository(MainContext context) : base(context)
        {
        }
    }
}