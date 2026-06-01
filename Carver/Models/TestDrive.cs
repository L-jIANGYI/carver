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
        public string ProspectName => Prospect.FullName;
        public string CarverModel => Carver.Type;
        public string StatusDisplay => Status switch
        {
            TestDriveStatus.Scheduled => "Gepland",
            TestDriveStatus.Completed => "Uitgevoerd",
            TestDriveStatus.Canceled => "Geannuleerd",
            _ => Status.ToString()
        };

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
