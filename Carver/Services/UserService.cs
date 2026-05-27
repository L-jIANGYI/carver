using Carver.Database;
using Carver.Models;

namespace Carver.Services
{
    internal class UserService
    {
        private readonly UserRepository _userRepo = new UserRepository();

        public User? Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return null;

            return _userRepo.Login(email, password);
        }
    }
}
