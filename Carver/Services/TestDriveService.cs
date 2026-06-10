using Carver.Database;
using Carver.Models;

namespace Carver.Services
{
    internal class TestDriveService
    {
        private readonly TestDriveRepository _testDriveRepo = new TestDriveRepository();

        public List<TestDrive> GetAll()
        {
            return _testDriveRepo.GetAll();
        }

        public List<TestDrive> GetByStatus(TestDriveStatus status)
        {
            var result = _testDriveRepo.GetByStatus(status);

            if (status == TestDriveStatus.Completed)
                return result.OrderByDescending(t => t.ScheduledAt).ToList();

            return result;
        }

        public List<TestDrive> GetByStatuses(params TestDriveStatus[] statuses)
        {
            return _testDriveRepo.GetAll()
                .Where(t => statuses.Contains(t.Status))
                .ToList();
        }

        public void Add(TestDrive testDrive)
        {
            if (testDrive.ScheduledAt < DateTime.Today)
                throw new ArgumentException("Geplande datum mag niet in het verleden liggen.");

            _testDriveRepo.Add(testDrive);
        }

        public void Update(TestDrive testDrive)
        {
            if (testDrive.ScheduledAt < DateTime.Today)
                throw new ArgumentException("Geplande datum mag niet in het verleden liggen.");

            _testDriveRepo.Update(testDrive);
        }

        public void UpdateStatus(int id, TestDriveStatus newStatus)
        {
            _testDriveRepo.UpdateStatus(id, newStatus);
        }

        public void Delete(TestDrive testDrive)
        {
            _testDriveRepo.Delete(testDrive);
        }
    }
}
