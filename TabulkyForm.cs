using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK8PO_2
{
    public partial class TabulkyForm : Form
    {
        private SrpavceSoutezi spravceSoutezi;
        private Soutez soutez;
        private Tabulky tabulky = new Tabulky();

        /// <summary>
        /// Dialogvé okno pro generování tabulek soutěže
        /// </summary>
        /// <param name="spravceSoutezi"></param>
        public TabulkyForm(SrpavceSoutezi spravceSoutezi)
        {
            InitializeComponent();

            this.spravceSoutezi = spravceSoutezi;
            soutezeListBox.DataSource = spravceSoutezi.Souteze;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Obsluha tlačítka pro vygenerování tabulky
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generujButton_Click(object sender, EventArgs e)
        {
            if (soutezeListBox.SelectedItem != null) {
                soutez = (Soutez)soutezeListBox.SelectedItem;
                var workbook = tabulky.GenerujTabulku(soutez);              // zavolání metody na vygenerování excelového souboru tabulky soutěže vybrané v listboxu

                generujTabulkuSaveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                generujTabulkuSaveFileDialog.RestoreDirectory = true;                       // dialogové okno pro uložení excelového souboru
                string nazev = soutez.NazevSouteze;
                int index = nazev.IndexOf('-');
                if (index > 0)
                    nazev = nazev.Substring(0, index - 1);
                generujTabulkuSaveFileDialog.FileName = "Tabulka " + nazev;

                if (generujTabulkuSaveFileDialog.ShowDialog() == DialogResult.OK)
                    workbook.Save(generujTabulkuSaveFileDialog.FileName);
            }
            else
                MessageBox.Show("Nemáte nahranou žádnou soutěž", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
