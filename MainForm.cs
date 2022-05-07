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
    public partial class MainForm : Form
    {
        private SpavceSoutezi spravceSoutezi = new SpavceSoutezi();

        public MainForm()
        {
            InitializeComponent();

            soutezeListBox.DataSource = spravceSoutezi.Souteze;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try {
                spravceSoutezi.Pridej(vlozOdkazTextBox.Text);                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
