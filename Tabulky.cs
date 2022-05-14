using GemBox.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AK8PO_2
{
    public class Tabulky
    {
        public Tabulky()
        {
        }

        public ExcelFile GenerujTabulku(Soutez soutez)
        {
            string[,] tabulka = VytvorTabulku(soutez);

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("Tabulka");

            // NASTAVENÍ ŠÍŘKY BUNĚK
            worksheet.Columns[0].Width = 100 * 20;
            worksheet.Columns[1].Width = 350 * 20;
            worksheet.Columns[2].Width = 100 * 20;
            worksheet.Columns[3].Width = 100 * 20;
            worksheet.Columns[4].Width = 100 * 20;
            worksheet.Columns[5].Width = 100 * 20;
            worksheet.Columns[6].Width = 150 * 20;

            // MEZERA
            worksheet.Rows[0].Height = 10 * 20;

            // NADPIS
            var nadpis = worksheet.Cells.GetSubrange("A2:G2");
            nadpis.Merged = true;
            nadpis.Value = soutez.NazevSouteze;
            nadpis.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            nadpis.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            nadpis.Style.Font.Name = "Calibri";
            nadpis.Style.Font.Size = 21 * 20;
            nadpis.Style.Font.Weight = ExcelFont.BoldWeight;
            nadpis.Style.Font.UnderlineStyle = UnderlineStyle.Single;

            // PODNADPIS
            var podnadpis = worksheet.Cells.GetSubrange("A4:G4");
            podnadpis.Merged = true;
            podnadpis.Value = "Tabulka týmů";
            podnadpis.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            podnadpis.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            podnadpis.Style.Font.Name = "Calibri";
            podnadpis.Style.Font.Size = 18 * 20;
            podnadpis.Style.Font.Weight = ExcelFont.BoldWeight;
            podnadpis.Style.Font.UnderlineStyle = UnderlineStyle.Single;

            // DATA TABULKY
            int index = tabulka.GetLength(0);
            string bunky = "A7:G" + (7 + (index - 1)).ToString();
            var data = worksheet.Cells.GetSubrange(bunky);
            data.Style.Borders.SetBorders(MultipleBorders.All, SpreadsheetColor.FromArgb(0, 0, 0), LineStyle.Thin);
            data.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            data.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            data.Style.Font.Name = "Calibri";
            data.Style.Font.Size = 14 * 20;
            worksheet.Rows[5].Height = 25 * 20;

            for (int i = 0; i < tabulka.GetLength(0); i++) {
                for (int j = 0; j < tabulka.GetLength(1); j++)
                    if (j != 1)
                        worksheet.Cells[i + 6, j].Value = int.Parse(tabulka[i, j]);
                    else
                        worksheet.Cells[i + 6, j].Value = tabulka[i, j];
            }

            // HLAVIČKA TABULKY
            var hlavicka = worksheet.Cells.GetSubrange("A6:G6");
            hlavicka.Style.Borders.SetBorders(MultipleBorders.All, SpreadsheetColor.FromArgb(0, 0, 0), LineStyle.Thick);
            hlavicka.Style.VerticalAlignment = VerticalAlignmentStyle.Center;
            hlavicka.Style.HorizontalAlignment = HorizontalAlignmentStyle.Center;
            hlavicka.Style.Font.Name = "Calibri";
            hlavicka.Style.Font.Size = 14 * 20;
            hlavicka.Style.Font.Weight = ExcelFont.BoldWeight;
            for (int i = 0; i < tabulka.GetLength(0); i++)
                worksheet.Rows[i + 6].Height = 23 * 20;
            worksheet.Cells[5, 0].Value = "#";
            worksheet.Cells[5, 1].Value = "TÝM";
            worksheet.Cells[5, 2].Value = "PU";
            worksheet.Cells[5, 3].Value = "V";
            worksheet.Cells[5, 4].Value = "R";
            worksheet.Cells[5, 5].Value = "P";
            worksheet.Cells[5, 6].Value = "BODY";

            return workbook;
        }

        private string[,] VytvorTabulku(Soutez soutez)
        {
            string[,] tabulka = new string[soutez.Teamy.Length, 7];
            string[] pomocnaTabulka = new string[soutez.Teamy.Length];
            string[,] setridenaTabulka = new string[soutez.Teamy.Length, 7];
            byte poradi = 1;

            for (int i = 0; i < tabulka.GetLength(0); i++) {
                tabulka[i, 1] = soutez.Teamy[i];
                tabulka[i, 2] = "0";
                tabulka[i, 3] = "0";
                tabulka[i, 4] = "0";
                tabulka[i, 5] = "0";
                tabulka[i, 6] = "0";
                pomocnaTabulka[i] = soutez.Teamy[i];
            }
            for (int i = 0; i < soutez.Losy.GetLength(0); i++) {
                string tymA = soutez.Losy[i, 2];
                string tymB = soutez.Losy[i, 3];
                int indexA = Array.IndexOf(pomocnaTabulka, tymA);
                int indexB = Array.IndexOf(pomocnaTabulka, tymB);
                if (soutez.Losy[i, 4] != null) {
                    int x = int.Parse(tabulka[indexA, 2]);
                    x++;
                    tabulka[indexA, 2] = x.ToString();

                    int y = int.Parse(tabulka[indexB, 2]);
                    y++;
                    tabulka[indexB, 2] = y.ToString();

                    string[] vysledek = soutez.Losy[i, 4].Split(':');

                    if (int.Parse(vysledek[0]) > int.Parse(vysledek[1])) {
                        int a = int.Parse(tabulka[indexA, 3]);
                        a++;
                        tabulka[indexA, 3] = a.ToString();

                        int b = int.Parse(tabulka[indexA, 6]);
                        b += 4;
                        tabulka[indexA, 6] = b.ToString();

                        int c = int.Parse(tabulka[indexB, 5]);
                        c++;
                        tabulka[indexB, 5] = c.ToString();

                        int d = int.Parse(tabulka[indexB, 6]);
                        d++;
                        tabulka[indexB, 6] = d.ToString();
                    }
                    else if (int.Parse(vysledek[0]) < int.Parse(vysledek[1])) {
                        int a = int.Parse(tabulka[indexA, 5]);
                        a++;
                        tabulka[indexA, 5] = a.ToString();

                        int b = int.Parse(tabulka[indexA, 6]);
                        b++;
                        tabulka[indexA, 6] = b.ToString();

                        int c = int.Parse(tabulka[indexB, 3]);
                        c++;
                        tabulka[indexB, 3] = c.ToString();

                        int d = int.Parse(tabulka[indexB, 6]);
                        d += 4;
                        tabulka[indexB, 6] = d.ToString();
                    }
                    else {
                        int a = int.Parse(tabulka[indexA, 4]);
                        a++;
                        tabulka[indexA, 4] = a.ToString();

                        int b = int.Parse(tabulka[indexA, 6]);
                        b += 2;
                        tabulka[indexA, 6] = b.ToString();

                        int c = int.Parse(tabulka[indexB, 4]);
                        c++;
                        tabulka[indexB, 4] = c.ToString();

                        int d = int.Parse(tabulka[indexB, 6]);
                        d += 2;
                        tabulka[indexB, 6] = d.ToString();
                    }
                }
            }
            for (int i = (soutez.Teamy.Length - 1) * 8; i > -1 * 4; i--) {
                for (int j = 0; j < soutez.Teamy.Length; j++) {
                    if (int.Parse(tabulka[j, 6]) == i) {
                        setridenaTabulka[poradi - 1, 0] = poradi.ToString();
                        for (int k = 0; k < setridenaTabulka.GetLength(1) - 1; k++) {
                            setridenaTabulka[poradi - 1, k + 1] = tabulka[j, k + 1];
                        }
                        poradi++;
                    }
                }
            }
            return setridenaTabulka;
        }
    }
}
