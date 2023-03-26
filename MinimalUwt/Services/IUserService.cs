using MinimalUwt.Models;

namespace MinimalUwt.Services
{
    public interface IUserService
    {
        public User GetUser(UserLogin userLogin);
    }
}
