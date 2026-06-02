using Carver.Database;
using Carver.Models;

namespace Carver.Services
{
    internal class ExperienceService
    {
        private readonly ExperienceRepository _repo = new ExperienceRepository();

        public void Add(Experience experience)
        {
            _repo.Add(experience);
        }

        public Experience? GetByTestDriveId(int testDriveId)
        {
            return _repo.GetByTestDriveId(testDriveId);
        }

        public List<Experience> GetAll()
        {
            return _repo.GetAll();
        }

        public bool ExistsForTestDrive(int testDriveId)
        {
            return _repo.GetByTestDriveId(testDriveId) != null;
        }
    }
}
