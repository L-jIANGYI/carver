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

    }
}
