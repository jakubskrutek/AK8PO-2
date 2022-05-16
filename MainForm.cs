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

        /// <summary>
        /// Třída reprezentující hlavní formulář aplikace
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            spravceSoutezi.Nacti();                                           // načte uložené soutěže z xml souboru (pokud existují)
            soutezeListBox.DataSource = spravceSoutezi.Souteze;               // nastaví zdroj dat do hlavního listBoxu
            aktualizovanoLabel.Select();                                     
        }

        /// <summary>
        /// Obsluha události kliknutí na tlačítko OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void okButton_Click(object sender, EventArgs e)
        {
            try {
                spravceSoutezi.Pridej(vlozOdkazTextBox.Text);                 // přidá soutěž do seznamu soutěží skrze třídu správce soutěží
                aktualizovanoLabel.Visible = true;
                DateTime datumCas = DateTime.Now;
                aktualizovanoDatumLabel.Text = datumCas.ToString("d.M. yyyy  HH:mm");               // aktualizace textu s datem v labelu
                aktualizovanoDatumLabel.Visible = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            spravceSoutezi.Uloz();                                            // uloží nově přidanou soutěž do xml souboru
        }

        /// <summary>
        /// Zmizení předvyplněného textu z textBoxu po kliknutí do něj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vlozOdkazTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (kliknuto == false) {
                vlozOdkazTextBox.Text = "";
                vlozOdkazTextBox.ForeColor = Color.Black;
                kliknuto = true;
            }            
        }

        /// <summary>
        /// Obsluha tlačítka SMAZAT pro smazání soutěže ze seznamu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void odeberButton_Click(object sender, EventArgs e)
        {
            if (soutezeListBox.SelectedItem != null)
                spravceSoutezi.Odeber((Soutez)soutezeListBox.SelectedItem);         // pokud je nějaká soutěž v listBoxu označena, zavolej metodu na smazání
            if (spravceSoutezi.Souteze.Count == 0) {
                aktualizovanoLabel.Visible = false;                                 // změna viditelnosti textu s datem v labelu
                aktualizovanoDatumLabel.Visible = false;
            }
            spravceSoutezi.Uloz();                                  // znovu uloží (aktualizuje) seznam soutěží do xml souboru
        }

        /// <summary>
        /// Otevře dialogové okno s tabulkami soutěže
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabulkyButton_Click(object sender, EventArgs e)
        {
            TabulkyForm tabulkyForm = new TabulkyForm(spravceSoutezi);
            tabulkyForm.ShowDialog();
        }

        /// <summary>
        /// Otevře dialogové okno s losy soutěže
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void losyButton_Click(object sender, EventArgs e)
        {
            LosyForm losyForm = new LosyForm(spravceSoutezi);
            losyForm.ShowDialog();
        }

        private void vlozOdkazTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
