using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GemBox.Spreadsheet;

namespace AK8PO_2
{
    public class Losy
    {
        public Losy()
        {
        }

        public ExcelFile GenerujLos(Soutez soutez, string muzstvo)
        {
            string[,] rozpis = setridLos(soutez, muzstvo);

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Los");

            // NASTAVENÍ ŠÍŘKY BUNĚK
            worksheet.Columns[0].Width = 100 * 20;
            worksheet.Columns[1].Width = 400 * 20;
            worksheet.Columns[2].Width = 280 * 20;
            worksheet.Columns[3].Width = 280 * 20;
            worksheet.Columns[4].Width = 180 * 20;

            // MEZERA
            worksheet.Rows[0].Height = 30 * 20;

            // NADPIS
            var nadpis = worksheet.Cells.GetSubrange("A2:E2");
            nadpis.Merged = true;
            nadpis.Value = soutez.NazevSouteze;
            nadpis.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            nadpis.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            nadpis.Style.Font.Name = "Calibri";
            nadpis.Style.Font.Size = 21 * 20;
            nadpis.Style.Font.Weight = ExcelFont.BoldWeight;
            nadpis.Style.Font.UnderlineStyle = UnderlineStyle.Single;

            // PODNADPIS
            var podnadpis = worksheet.Cells.GetSubrange("A4:E4");
            podnadpis.Merged = true;
            podnadpis.Value = "Rozpis utkání pro " + muzstvo.ToUpper();
            podnadpis.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            podnadpis.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            podnadpis.Style.Font.Name = "Calibri";
            podnadpis.Style.Font.Size = 18 * 20;
            podnadpis.Style.Font.Weight = ExcelFont.BoldWeight;
            podnadpis.Style.Font.UnderlineStyle = UnderlineStyle.Single;

            // DATA TABULKY
            int index = rozpis.GetLength(0);
            string bunky = "A7:E" + (7 + (index - 1)).ToString();
            var data = worksheet.Cells.GetSubrange(bunky);
            data.Style.Borders.SetBorders(MultipleBorders.All, SpreadsheetColor.FromArgb(0, 0, 0), LineStyle.Thin);
            data.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            data.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            data.Style.Font.Name = "Calibri";
            data.Style.Font.Size = 14 * 20;
            worksheet.Rows[5].Height = 25 * 20;

            for (int i = 0; i < rozpis.GetLength(0); i++) {
                for (int j = 0; j < rozpis.GetLength(1); j++)
                    worksheet.Cells[i + 6, j].Value = rozpis[i, j];
            }

            // HLAVIČKA TABULKY
            var hlavicka = worksheet.Cells.GetSubrange("A6:E6");
            hlavicka.Style.Borders.SetBorders(MultipleBorders.All, SpreadsheetColor.FromArgb(0, 0, 0), LineStyle.Thick);
            hlavicka.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            hlavicka.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            hlavicka.Style.Font.Name = "Calibri";
            hlavicka.Style.Font.Size = 14 * 20;
            hlavicka.Style.Font.Weight = ExcelFont.BoldWeight;
            for (int i = 0; i < rozpis.GetLength(0); i++)
                worksheet.Rows[i + 6].Height = 23 * 20;
            worksheet.Cells[5, 0].Value = "KOLO";
            worksheet.Cells[5, 1].Value = "TERMÍN";
            worksheet.Cells[5, 2].Value = "DOMÁCÍ";
            worksheet.Cells[5, 3].Value = "HOSTÉ";
            worksheet.Cells[5, 4].Value = "VÝSLEDEK";

            workbook.Save(@"D:\Los.xlsx");
            return workbook;
        }

        private string[,] setridLos(Soutez soutez, string muzstvo)
        {
            string[,] nesetridenyRozpis = soutez.Losy;
            int pocetZapasu = 0;
            int index = 0;

            for (int i = 0; i < nesetridenyRozpis.GetLength(0); i++) {
                if ((nesetridenyRozpis[i, 2] == muzstvo) || (nesetridenyRozpis[i, 3] == muzstvo))
                    pocetZapasu++;
            }

            string[,] rozpis = new string[pocetZapasu, 5];

            for (int i = 0; i < nesetridenyRozpis.GetLength(0); i++) {
                if ((nesetridenyRozpis[i, 2] == muzstvo) || (nesetridenyRozpis[i, 3] == muzstvo)) {
                    for (int j = 0; j < nesetridenyRozpis.GetLength(1); j++) {
                        rozpis[index, j] = nesetridenyRozpis[i, j];
                    }
                    index++;
                }                
            }
            return rozpis;
        }
    }
}
