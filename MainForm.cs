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
        private SrpavceSoutezi spravceSoutezi = new SrpavceSoutezi();
        private bool kliknuto = false;

        public MainForm()
        {
            InitializeComponent();

            soutezeListBox.DataSource = spravceSoutezi.Souteze;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try {                
                spravceSoutezi.Pridej(vlozOdkazTextBox.Text);
                aktualizovanoLabel.Visible = true;
                DateTime datumCas = DateTime.Now;
                aktualizovanoDatumLabel.Text = datumCas.ToString("d.M. yyyy  HH:mm");
                aktualizovanoDatumLabel.Visible = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void vlozOdkazTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (kliknuto == false) {
                vlozOdkazTextBox.Text = "";
                vlozOdkazTextBox.ForeColor = Color.Black;
                kliknuto = true;
            }            
        }

        private void odeberButton_Click(object sender, EventArgs e)
        {
            if (soutezeListBox.SelectedItem != null)
                spravceSoutezi.Odeber((Soutez)soutezeListBox.SelectedItem);
            if (spravceSoutezi.Souteze.Count == 0) {
                aktualizovanoLabel.Visible = false;
                aktualizovanoDatumLabel.Visible = false;
            }
            DateTime datumCas = DateTime.Now;
            aktualizovanoDatumLabel.Text = datumCas.ToString("d.M. yyyy  HH:mm");
        }

        private void tabulkyButton_Click(object sender, EventArgs e)
        {

        }

        private void losyButton_Click(object sender, EventArgs e)
        {
            LosyForm losyForm = new LosyForm(spravceSoutezi);
            losyForm.ShowDialog();
        }
    }
}
