
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IUser : IGeneric<User>
    {
        Task<User> GetUserByUsername(string username);
    }
}