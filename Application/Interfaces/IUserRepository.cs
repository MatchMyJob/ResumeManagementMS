using Domain.Entities;
using System.Web.Providers.Entities;

namespace Application.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        public Task<User> Update(User user);
    }
}
