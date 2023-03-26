using MinimalUwt.Models;

namespace MinimalUwt.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { Username = "emilio.bresolin", EmailAddress = "emilio@mail.com", Password = "MyPass_w0rd", GivenName = "emilio", Surname = "bresolin", Role = "Administrator" },
            //new() { Username = "luke_admin", EmailAddress = "luke.admin@email.com", Password = "MyPass_w0rd", GivenName = "Luke", Surname = "Rogers", Role = "Administrator" },
            new() { Username = "lydia_standard", EmailAddress = "lydia.standard@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Burton", Role = "Standard" },
        };
    }
}
