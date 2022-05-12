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
    public partial class LosyForm : Form
    {
        private SrpavceSoutezi spravceSoutezi;
        private Losy losy = new Losy();

        public LosyForm(SrpavceSoutezi spravceSoutezi)
        {
            InitializeComponent();

            this.spravceSoutezi = spravceSoutezi;
            soutezListBox.DataSource = spravceSoutezi.Souteze;
        }

        private void soutezListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soutezListBox.SelectedItem != null) {
                Soutez soutez = (Soutez)soutezListBox.SelectedItem;
                oddilListBox.DataSource = soutez.Teamy;
            }
        }
    }
}
