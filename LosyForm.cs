using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Spreadsheet;

namespace AK8PO_2
{
    public partial class LosyForm : Form
    {
        private SrpavceSoutezi spravceSoutezi;
        private Losy losy = new Losy();
        private Soutez soutez;

        /// <summary>
        /// Formulář pro generování losů soutěže
        /// </summary>
        /// <param name="spravceSoutezi"></param>
        public LosyForm(SrpavceSoutezi spravceSoutezi)
        {
            InitializeComponent();

            this.spravceSoutezi = spravceSoutezi;
            soutezListBox.DataSource = spravceSoutezi.Souteze;
        }

        /// <summary>
        /// Obsluha události Listboxu při označení soutěže
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void soutezListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soutezListBox.SelectedItem != null) {
                soutez = (Soutez)soutezListBox.SelectedItem;
                oddilListBox.DataSource = soutez.Teamy;             // reakce na změnu vybrané soutěže, načtou se týmy v soutěži
            }
        }

        /// <summary>
        /// Obsluha tlačítka pro generování losu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generujButton_Click(object sender, EventArgs e)
        {
            if (soutezListBox.SelectedItem != null) {
                string muzstvo = oddilListBox.SelectedItem.ToString();
                var workbook = losy.GenerujLos(soutez, muzstvo);                            // zavolání metody na vygenerování excelového souboru s losem

                generujLosSaveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                generujLosSaveFileDialog.RestoreDirectory = true;                           // dialog pro ukládání souboru
                int index = muzstvo.IndexOf('"');
                if (index > 0)
                    muzstvo = muzstvo.Substring(0, index - 1).Trim() + " " + muzstvo[index + 1];
                generujLosSaveFileDialog.FileName = "Los " + muzstvo;

                if (generujLosSaveFileDialog.ShowDialog() == DialogResult.OK)
                    workbook.Save(generujLosSaveFileDialog.FileName);
            }
            else
                MessageBox.Show("Nemáte nahranou žádnou soutěž", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
