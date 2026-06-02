namespace Carver.Models
{
    internal class Experience
    {
        public int Id { get; set; }
        public int TestDriveId { get; set; }
        public ExperienceAnswer MeetExpectation { get; set; }
        public ExperienceAnswer PriceSatisfaction { get; set; }
        public ExperienceAnswer OptionsAdequate { get; set; }
        public ExperienceAnswer WillPurchase { get; set; }

        public Experience(int testDriveId)
        {
            TestDriveId = testDriveId;
        }
    }
}
