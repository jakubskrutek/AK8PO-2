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

        public TabulkyForm(SrpavceSoutezi spravceSoutezi)
        {
            InitializeComponent();

            this.spravceSoutezi = spravceSoutezi;
            soutezeListBox.DataSource = spravceSoutezi.Souteze;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generujButton_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
