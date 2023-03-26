using MinimalUwt.Models;

namespace MinimalUwt.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
