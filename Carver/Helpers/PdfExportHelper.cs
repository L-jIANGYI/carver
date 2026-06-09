using Carver.Models;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Color = iText.Kernel.Colors.Color;

namespace Carver.Helpers
{
    internal static class PdfExportHelper
    {
        // Brand colors
        private static readonly Color ColorPrimary = new DeviceRgb(30, 30, 30);
        private static readonly Color ColorAccent = new DeviceRgb(220, 50, 50);
        private static readonly Color ColorLight = new DeviceRgb(245, 245, 245);
        private static readonly Color ColorBorder = new DeviceRgb(200, 200, 200);
        private static readonly Color ColorWhite = new DeviceRgb(255, 255, 255);

        public static void ExportKlantenkaart(Prospect prospect)
        {
            using SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Klantenkaart opslaan als PDF",
                Filter = "PDF bestanden (*.pdf)|*.pdf",
                FileName = $"Klantenkaart_{prospect.LastName}_{prospect.FirstName}.pdf"
            };

            if (dialog.ShowDialog() != DialogResult.OK) return;

            using PdfWriter pdfWriter = new PdfWriter(dialog.FileName);
            using PdfDocument pdf = new PdfDocument(pdfWriter);
            using Document doc = new Document(pdf, PageSize.A4);

            doc.SetMargins(60, 50, 60, 50);
            BuildDocument(pdf, doc, prospect);

            MessageBox.Show(
                $"Klantenkaart van {prospect.FullName} is opgeslagen.",
                "Export geslaagd",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static void BuildDocument(PdfDocument pdf, Document doc, Prospect prospect)
        {
            pdf.AddNewPage();

            PageSize pageSize = PageSize.A4;
            PdfPage page = pdf.GetFirstPage();
            PdfCanvas canvas = new PdfCanvas(page);

            // Header bar
            canvas.SaveState();

            float barY = pageSize.GetHeight() - 80;
            canvas.SetFillColor(ColorAccent)
                  .Rectangle(50, barY, pageSize.GetWidth() - 100, 40)
                  .Fill();

            PdfFont boldFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);
            PdfFont regFont = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);

            canvas.BeginText()
                  .SetFontAndSize(boldFont, 18)
                  .SetColor(ColorWhite, true)
                  .MoveText(pageSize.GetWidth() / 2 - 60, barY + 13)
                  .ShowText("KLANTENKAART")
                  .EndText();

            canvas.RestoreState();

            // Name + accent line
            doc.Add(new Paragraph("\n\n\n\n"));

            Paragraph name = new Paragraph(prospect.FullName)
                .SetFont(boldFont)
                .SetFontSize(15)
                .SetFontColor(ColorPrimary)
                .SetMarginBottom(4);
            doc.Add(name);

            float lineY = pageSize.GetHeight() - 148;
            canvas.SetStrokeColor(ColorAccent)
                  .SetLineWidth(1.5f)
                  .MoveTo(50, lineY)
                  .LineTo(pageSize.GetWidth() - 50, lineY)
                  .Stroke();

            doc.Add(new Paragraph(" ").SetMarginBottom(8));

            // Contact section
            doc.Add(SectionTitle("Contactgegevens", boldFont));
            doc.Add(InfoTable(new (string, string)[]
            {
                ("Voornaam",    prospect.FirstName),
                ("Achternaam",  prospect.LastName),
                ("E-mail",      prospect.Email),
                ("Telefoon",    prospect.Phone),
                ("Adres",       prospect.Address),
                ("Stad",        prospect.City)
            }, boldFont, regFont));

            doc.Add(new Paragraph(" ").SetMarginBottom(10));

            // Rijbevoegdheden section
            doc.Add(SectionTitle("Rijbevoegdheden", boldFont));
            doc.Add(InfoTable(new (string, string)[]
            {
                ("Rijbewijs auto",        prospect.HasDrivingLicense  ? "Ja" : "Nee"),
                ("Rijbewijs scooter",     prospect.HasScooterLicense  ? "Ja" : "Nee"),
                ("Gehandicaptenvoertuig", prospect.IsDisabledVehicle  ? "Ja" : "Nee")
            }, boldFont, regFont));

            // Footer
            canvas.BeginText()
                  .SetFontAndSize(regFont, 8)
                  .SetColor(ColorBorder, true)
                  .MoveText(pageSize.GetWidth() / 2 - 100, 35)
                  .ShowText($"Gegenereerd op {DateTime.Now:dd-MM-yyyy HH:mm}  |  Carver")
                  .EndText();
        }

        private static Paragraph SectionTitle(string title, PdfFont font)
        {
            return new Paragraph(title.ToUpper())
                .SetFont(font)
                .SetFontSize(11)
                .SetFontColor(ColorAccent)
                .SetMarginBottom(6);
        }

        private static Table InfoTable((string Label, string Value)[] rows, PdfFont boldFont, PdfFont regFont)
        {
            Table table = new Table(UnitValue.CreatePercentArray(new float[] { 35f, 65f }))
                .UseAllAvailableWidth()
                .SetMarginBottom(4);

            bool shade = false;
            foreach (var (label, value) in rows)
            {
                Color bg = shade ? ColorLight : ColorWhite;

                Cell cellLabel = new Cell()
                    .Add(new Paragraph(label).SetFont(boldFont).SetFontSize(10))
                    .SetBackgroundColor(bg)
                    .SetBorder(new SolidBorder(ColorBorder, 0.5f))
                    .SetPadding(6);

                Cell cellValue = new Cell()
                    .Add(new Paragraph(value).SetFont(regFont).SetFontSize(10))
                    .SetBackgroundColor(bg)
                    .SetBorder(new SolidBorder(ColorBorder, 0.5f))
                    .SetPadding(6);

                table.AddCell(cellLabel);
                table.AddCell(cellValue);
                shade = !shade;
            }

            return table;
        }
    }
}
