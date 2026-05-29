namespace Carver.Models
{
    internal class TestDrive
    {
        public int Id { get; set; }
        public Prospect Prospect { get; set; }
        public Carver Carver { get; set; }
        public DateTime ScheduledAt { get; set; }
        public string Reason { get; set; }
        public TestDriveStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public TestDrive(Prospect prospect, Carver carver, DateTime scheduledAt, string reason)
        {
            Prospect = prospect;
            Carver = carver;
            ScheduledAt = scheduledAt;
            Reason = reason;
            Status = TestDriveStatus.Scheduled;
        }
    }
}
