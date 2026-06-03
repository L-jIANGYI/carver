using Carver.Models;
using Carver.Services;

namespace Carver.Forms
{
    internal partial class ExperienceForm : Form
    {
        private readonly int _testDriveId;
        private readonly ExperienceService _experienceService = new ExperienceService();

        public ExperienceForm(int testDriveId, Experience? existingExperience = null)
        {
            InitializeComponent();
            _testDriveId = testDriveId;

            if (existingExperience != null)
            {
                LoadExperience(existingExperience);
                SetReadOnly();
            }
        }

        private ExperienceAnswer? GetAnswer(Panel panel)
        {
            foreach (RadioButton rb in panel.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    return (ExperienceAnswer)(rb.TabIndex + 1);
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

        // Load existing experience into the form for read-only display
        private void LoadExperience(Experience experience)
        {
            SetAnswer(pnlExperience1, experience.MeetExpectation);
            SetAnswer(pnlExperience2, experience.PriceSatisfaction);
            SetAnswer(pnlExperience3, experience.OptionsAdequate);
            SetAnswer(pnlExperience4, experience.WillPurchase);
        }

        private void SetAnswer(Panel panel, ExperienceAnswer answer)
        {
            foreach (RadioButton rb in panel.Controls.OfType<RadioButton>())
            {
                if (rb.TabIndex + 1 == (int)answer)
                    rb.Checked = true;
            }
        }

        private void SetReadOnly()
        {
            foreach (Panel panel in new[] { pnlExperience1, pnlExperience2, pnlExperience3, pnlExperience4 })
                foreach (RadioButton rb in panel.Controls.OfType<RadioButton>())
                    rb.Enabled = false;

            btnExperienceSubmit.Visible = false;
        }
    }
}