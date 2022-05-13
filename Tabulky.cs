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

        public ExcelFile GenerujTabulky(Soutez soutez)
        {
            string[,] tabulka = VytvorTabulku(soutez);

            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            var workbook = new ExcelFile();

            return workbook;
        }

        private string[,] VytvorTabulku(Soutez soutez)              // trizeni 2D pole - https://social.msdn.microsoft.com/Forums/vstudio/en-US/57691712-3064-4244-954a-1ada2d1e3020/how-to-sort-the-2d-array-according-to-specific-column?forum=csharpgeneral
        {
            string[,] tabulka = new string[12, 6];
            return tabulka;
        }
    }
}
