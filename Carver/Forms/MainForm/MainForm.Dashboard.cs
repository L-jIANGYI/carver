using Carver.Models;
using Carver.Services;

namespace Carver
{
    internal partial class MainForm
    {
        private void LoadDashboard()
        {
            var scheduled = _testDriveService.GetByStatus(TestDriveStatus.Scheduled);
            var completed = _testDriveService.GetByStatus(TestDriveStatus.Completed);

            lblTotalScheduled.Text = scheduled.Count.ToString();
            lblTotalCompleted.Text = completed.Count.ToString();

            dgvDashboard.DataSource = scheduled
                .OrderBy(t => t.ScheduledAt)
                .Take(5)
                .ToList();
        }
    }
}
