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

        public void Register(User user)
        {
            if (user == null)
                throw new ArgumentException("Gebruiker is ongeldig.");

            if (string.IsNullOrWhiteSpace(user.Name))
                throw new ArgumentException("Naam is verplicht.");

            if (string.IsNullOrWhiteSpace(user.Email))
                throw new ArgumentException("E-mailadres is verplicht.");

            if (string.IsNullOrWhiteSpace(user.Password))
                throw new ArgumentException("Wachtwoord is verplicht.");

            _userRepo.Add(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public void Delete(User user)
        {
            if (user == null)
                throw new ArgumentException("Gebruiker is ongeldig.");

            _userRepo.Delete(user);
        }
    }
}
