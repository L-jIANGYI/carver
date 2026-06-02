using Carver.Models;
using Carver.Services;

namespace Carver.Forms
{
    public partial class ExperienceForm : Form
    {
        private readonly int _testDriveId;
        private readonly ExperienceService _experienceService = new ExperienceService();

        public ExperienceForm(int testDriveId)
        {
            InitializeComponent();
            _testDriveId = testDriveId;
        }

        private ExperienceAnswer? GetAnswer(Panel panel)
        {
            foreach (RadioButton rb in panel.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    return (ExperienceAnswer)(rb.TabIndex + 1); // TabIndex 0=Disagree(1), 1=Neutral(2), 2=Agree(3)
            }
            return null;
        }

        private void btnExperienceSubmit_Click(object sender, EventArgs e)
        {
            var q1 = GetAnswer(pnlExperience1);
            var q2 = GetAnswer(pnlExperience2);
            var q3 = GetAnswer(pnlExperience3);
            var q4 = GetAnswer(pnlExperience4);

            if (q1 == null || q2 == null || q3 == null || q4 == null)
            {
                MessageBox.Show("Beantwoord alle vragen voor je opslaat.", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Experience experience = new Experience(_testDriveId)
            {
                MeetExpectation = q1.Value,
                PriceSatisfaction = q2.Value,
                OptionsAdequate = q3.Value,
                WillPurchase = q4.Value
            };

            try
            {
                _experienceService.Add(experience);
                MessageBox.Show("Ervaring opgeslagen.", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij opslaan: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}