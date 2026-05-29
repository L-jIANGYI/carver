using Carver.Database;
using Carver.Models;

namespace Carver.Services
{
    internal class ProspectService
    {
        private readonly ProspectRepository _prospectRepo = new ProspectRepository();

        public List<Prospect> GetAll()
        {
            return _prospectRepo.GetAll();
        }

        public Prospect? GetById(int id)
        {
            return _prospectRepo.GetById(id);
        }

        public Prospect? GetByEmail(string email)
        {
            return _prospectRepo.GetByEmail(email);
        }

        public void Add(Prospect prospect)
        {
            if (string.IsNullOrWhiteSpace(prospect.FirstName))
                throw new ArgumentException("Voornaam is verplicht.");

            if (string.IsNullOrWhiteSpace(prospect.LastName))
                throw new ArgumentException("Achternaam is verplicht.");

            if (string.IsNullOrWhiteSpace(prospect.Email))
                throw new ArgumentException("E-mailadres is verplicht.");

            if (string.IsNullOrWhiteSpace(prospect.Phone))
                throw new ArgumentException("Telefoonnummer is verplicht.");

            _prospectRepo.Add(prospect);
        }

        public void Update(Prospect prospect)
        {
            if (string.IsNullOrWhiteSpace(prospect.FirstName))
                throw new ArgumentException("Voornaam is verplicht.");

            if (string.IsNullOrWhiteSpace(prospect.LastName))
                throw new ArgumentException("Achternaam is verplicht.");

            _prospectRepo.Update(prospect);
        }

        public void Delete(Prospect prospect)
        {
            _prospectRepo.Delete(prospect);
        }
    }
}
