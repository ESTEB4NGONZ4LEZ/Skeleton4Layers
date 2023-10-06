
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repositories
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        public RolRepository(MainContext context) : base(context)
        {
        }
    }
}