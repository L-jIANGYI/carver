using Carver.Database;
using Carver.Models;
using Carver.Services;
using System.Windows.Forms.DataVisualization.Charting;
using CarverModel = Carver.Models.Carver;

namespace Carver.Forms
{
    internal partial class StatisticsForm : Form
    {
        private readonly TestDriveService _testDriveService = new TestDriveService();
        private readonly ExperienceRepository _experienceRepo = new ExperienceRepository();
        
        public StatisticsForm()
        {
            InitializeComponent();
            LoadStatistieken();
        }

        private void LoadStatistieken()
        {
            cmbModel.DataSource = Enum.GetValues(typeof(CarverModelType))
                .Cast<CarverModelType>()
                .Select(m => new { Value = m, Display = CarverModel.ToDisplayName(m) })
                .ToList();
            cmbModel.DisplayMember = "Display";
            cmbModel.ValueMember = "Value";

            LoadPieChart();
            if (cmbModel.SelectedItem != null)
            {
                LoadExperienceStats((CarverModelType)((dynamic)cmbModel.SelectedItem).Value);
            }
        }

        private void LoadPieChart(CarverModelType? highlighted = null)
        {
            var completed = _testDriveService.GetByStatus(TestDriveStatus.Completed);

            var perModel = Enum.GetValues(typeof(CarverModelType))
                .Cast<CarverModelType>()
                .Select(m => new {
                    Model = m,
                    Count = completed.Count(t => t.Carver.ModelType == m),
                    Display = CarverModel.ToDisplayName(m)
                })
                .Where(x => x.Count > 0)
                .ToList();

            chartPie.Series.Clear();
            chartPie.Titles.Clear();
            chartPie.Titles.Add("Proefritten per model");
            chartPie.ChartAreas[0].Position = new ElementPosition(0, 10, 100, 100);

            var series = new Series("Modellen");
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Outside";
            series["PieLineColor"] = "Black";

            foreach (var item in perModel)
            {
                var point = new DataPoint();
                point.SetValueXY(item.Display, item.Count);
                point.Label = $"{item.Display}\n{item.Count}";

                if (highlighted.HasValue && item.Model == highlighted.Value)
                    point["Exploded"] = "true";
                else
                    point["Exploded"] = "false";

                series.Points.Add(point);
            }

            chartPie.Series.Add(series);
        }

        private void LoadExperienceStats(CarverModelType modelType)
        {
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();

            var completed = _testDriveService.GetByStatus(TestDriveStatus.Completed);
            var testDriveIds = completed
                .Where(t => t.Carver.ModelType == modelType)
                .Select(t => t.Id)
                .ToHashSet();

            var experiences = _experienceRepo.GetAll()
                .Where(e => testDriveIds.Contains(e.TestDriveId))
                .ToList();

            string[] questions = {
                "Voldeed aan verwachting",
                "Tevreden over prijs",
                "Opties voldoende",
                "Overweegt aankoop"
            };

            Func<Experience, ExperienceAnswer>[] selectors = {
                e => e.MeetExpectation,
                e => e.PriceSatisfaction,
                e => e.OptionsAdequate,
                e => e.WillPurchase
            };

            Color[] colors = {
                Color.FromArgb(220, 80, 80),
                Color.FromArgb(200, 180, 60),
                Color.FromArgb(80, 180, 80)
            };
            string[] labels = { "Oneens", "Neutraal", "Eens" };

            int total = experiences.Count;

            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33));

            tableLayoutPanel1.RowCount = questions.Length + 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            tableLayoutPanel1.Controls.Add(new Label { Text = "", Dock = DockStyle.Fill }, 0, 0);

            for (int c = 0; c < 3; c++)
            {
                var header = new Label
                {
                    Text = labels[c],
                    ForeColor = colors[c],
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                };
                tableLayoutPanel1.Controls.Add(header, c + 1, 0);
            }

            for (int i = 0; i < questions.Length; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));

                var lbl = new Label
                {
                    Text = questions[i],
                    Font = new Font("Segoe UI", 9),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Fill,
                    Padding = new Padding(4, 0, 0, 0)
                };
                tableLayoutPanel1.Controls.Add(lbl, 0, i + 1);

                int[] pcts = new int[3];
                if (total == 0)
                {
                    pcts = new int[] { 0, 0, 0 };
                }
                else
                {
                    pcts[0] = experiences.Count(e => selectors[i](e) == ExperienceAnswer.Disagree) * 100 / total;
                    pcts[1] = experiences.Count(e => selectors[i](e) == ExperienceAnswer.Neutral) * 100 / total;
                    pcts[2] = experiences.Count(e => selectors[i](e) == ExperienceAnswer.Agree) * 100 / total;
                }

                for (int c = 0; c < 3; c++)
                {
                    var panel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(4, 8, 4, 8) };

                    var pb = new ProgressBar
                    {
                        Minimum = 0,
                        Maximum = 100,
                        Value = pcts[c],
                        Dock = DockStyle.Fill,
                        ForeColor = colors[c],
                        Style = ProgressBarStyle.Continuous
                    };

                    var pct = new Label
                    {
                        Text = $"{pcts[c]}%",
                        Font = new Font("Segoe UI", 8),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Bottom,
                        Height = 18
                    };

                    panel.Controls.Add(pb);
                    panel.Controls.Add(pct);
                    tableLayoutPanel1.Controls.Add(panel, c + 1, i + 1);
                }
            }
        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbModel.SelectedItem == null) return;
            var selected = (CarverModelType)((dynamic)cmbModel.SelectedItem).Value;
            LoadPieChart(selected);
            LoadExperienceStats(selected);
        }
    }
}
