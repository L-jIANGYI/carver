using Carver.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Carver.Helpers
{
    internal static class ExcelExportHelper
    {
        public static void ExportProspectenLijst(List<Prospect> prospects)
        {
            using SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Klantenlijst opslaan als Excel",
                Filter = "Excel bestanden (*.xlsx)|*.xlsx",
                FileName = $"Klantenlijst_{DateTime.Now:yyyyMMdd}.xlsx"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            ExcelPackage.License.SetNonCommercialOrganization("Carver");

            using ExcelPackage package = new ExcelPackage();
            ExcelWorksheet ws = package.Workbook.Worksheets.Add("Klanten");

            // Column headers
            string[] headers =
            {
                "ID", "Voornaam", "Achternaam", "E-mail", "Telefoon",
                "Adres", "Stad", "Rijbewijs auto", "Rijbewijs scooter", "Gehandicaptenvoertuig"
            };

            for (int col = 1; col <= headers.Length; col++)
            {
                var cell = ws.Cells[1, col];
                cell.Value = headers[col - 1];

                cell.Style.Font.Bold = true;
                cell.Style.Font.Color.SetColor(Color.White);
                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(220, 50, 50));
                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cell.Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.White);
            }

            // Data rows
            Color rowEven = Color.FromArgb(245, 245, 245);
            Color rowOdd = Color.White;

            for (int i = 0; i < prospects.Count; i++)
            {
                Prospect p = prospects[i];
                int row = i + 2;
                Color bg = i % 2 == 0 ? rowEven : rowOdd;

                object[] values =
                {
                    p.Id,
                    p.FirstName,
                    p.LastName,
                    p.Email,
                    p.Phone,
                    p.Address,
                    p.City,
                    p.HasDrivingLicense   ? "Ja" : "Nee",
                    p.HasScooterLicense   ? "Ja" : "Nee",
                    p.IsDisabledVehicle   ? "Ja" : "Nee"
                };

                for (int col = 1; col <= values.Length; col++)
                {
                    var cell = ws.Cells[row, col];
                    cell.Value = values[col - 1];

                    cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    cell.Style.Fill.BackgroundColor.SetColor(bg);
                    cell.Style.Border.BorderAround(ExcelBorderStyle.Hair, Color.FromArgb(200, 200, 200));
                }
            }

            // Summary row
            int summaryRow = prospects.Count + 3;
            ws.Cells[summaryRow, 1].Value = "Totaal klanten:";
            ws.Cells[summaryRow, 1].Style.Font.Bold = true;
            ws.Cells[summaryRow, 2].Value = prospects.Count;

            // auto-fit columns
            ws.Cells[ws.Dimension.Address].AutoFitColumns();

            // Generated timestamp
            ws.Cells[summaryRow + 1, 1].Value = $"Gegenereerd op {DateTime.Now:dd-MM-yyyy HH:mm}";
            ws.Cells[summaryRow + 1, 1].Style.Font.Italic = true;
            ws.Cells[summaryRow + 1, 1].Style.Font.Color.SetColor(Color.Gray);
            ws.Cells[summaryRow + 1, 1, summaryRow + 1, 3].Merge = true;

            package.SaveAs(new FileInfo(dialog.FileName));

            MessageBox.Show(
                $"{prospects.Count} klanten geëxporteerd naar Excel.",
                "Export geslaagd",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
