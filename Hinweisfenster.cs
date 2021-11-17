using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adress_DB
{
    public partial class Hinweisfenster : Form



    {
        private string FirmenNameNeu;
        private string FirmenNameAlt;
        private int IDFirmenName;
        private string Titel;


        public Hinweisfenster(string FirmenNameNeu, string FirmenNameAlt, int IDFirmenName, string Titel, int Auswahl)
        {
            InitializeComponent();

            this.FirmenNameNeu = FirmenNameNeu;
            this.FirmenNameAlt = FirmenNameAlt;
            this.Titel = Titel;
            this.IDFirmenName = IDFirmenName;

            if (Auswahl == 1)  //Neu anlegen
            {
                LBL_Ueberschrift.Text = this.Titel;
                BTN_Aendern.Visible = false;
                LBL_unten.Visible = false;
                LBL_HinweisUnten.Visible = false;

                LBL_oben.Text = "Neu anlegen:";
                LBL_HinweisOben.Text = Environment.NewLine + this.FirmenNameNeu;                           
            }

            if (Auswahl == 2) // Umbennen
            {
                LBL_Ueberschrift.Text = this.Titel;
                LBL_HinweisOben.Text = this.FirmenNameAlt + Environment.NewLine + "nach:  ---> " + Environment.NewLine + this.FirmenNameNeu;
                LBL_HinweisUnten.Text = this.FirmenNameNeu;
            }
        }


        private void BTN_Neu_Click(object sender, EventArgs e)
        {
            Module1.NeuenFirmenNamenAnlegen();
            this.Close();
        }

        private void BTN_Aendern_Click(object sender, EventArgs e)
        {
            try
            {
                // Datensatz FirmenName schreiben **DateTime solle eigentlich ein Datum Sein, kein String!
                My.MyProject.Forms.Hauptform.FirmenNameTableAdapter.UpdateFirmenName(this.FirmenNameNeu, Environment.UserName, Convert.ToString(DateTime.Now), this.IDFirmenName);

                // DocuWare-Datei schreiben:
                My.MyProject.Forms.Hauptform.BTN_Suche.PerformClick();
                Module1.SaveToCSV();
                Module1.Logging(3, this.IDFirmenName, this.IDFirmenName, this.FirmenNameAlt + " --> " + this.FirmenNameNeu); // LogTabelle schreiben
            }
            catch (Exception ex)
            {
                MessageBox.Show("Umbenennen fehlgeschlagen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message);
            }
            
            this.Close();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
