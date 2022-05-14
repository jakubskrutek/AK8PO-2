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

        public LosyForm(SrpavceSoutezi spravceSoutezi)
        {
            InitializeComponent();

            this.spravceSoutezi = spravceSoutezi;
            soutezListBox.DataSource = spravceSoutezi.Souteze;
        }

        private void soutezListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soutezListBox.SelectedItem != null) {
                soutez = (Soutez)soutezListBox.SelectedItem;
                oddilListBox.DataSource = soutez.Teamy;
            }
        }

        private void generujButton_Click(object sender, EventArgs e)
        {
            if (soutezListBox.SelectedItem != null) {
                string muzstvo = oddilListBox.SelectedItem.ToString();
                var workbook = losy.GenerujLos(soutez, muzstvo);

                generujLosSaveFileDialog.Filter = "Excel file (*.xlsx)|*.xlsx";
                generujLosSaveFileDialog.RestoreDirectory = true;
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
