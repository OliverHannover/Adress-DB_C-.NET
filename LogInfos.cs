﻿using System;
using System.Windows.Forms;
//using Microsoft.VisualBasic;

namespace Adress_DB
{
    public partial class Loginformationen
    {
        public Loginformationen()
        {
            InitializeComponent();

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.LogTabelle". Sie können sie bei Bedarf verschieben oder entfernen.
            LogTabelleTableAdapter.Fill(_WSL_AdressenDataSet.LogTabelle);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.LogTabelle". Sie können sie bei Bedarf verschieben oder entfernen.
            LogTabelleTableAdapter.Fill(_WSL_AdressenDataSet.LogTabelle);

        }

        private void BTN_Aktuell_Click(object sender, EventArgs e)
        {
            //Wenn sich der Textwert vom Label IDFirmenName in int convertieren lässt.... 
            int number1 = 0;
            bool canConvert = int.TryParse(My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text, out number1);
            if (canConvert == true)
            {
                int IDFirmenName = Convert.ToInt32(My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text);
                try
                {
                    LogTabelleTableAdapter.SucheIDFirmenNameInLogtabelle(_WSL_AdressenDataSet.LogTabelle, IDFirmenName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lblIDFirmenName ohne Inhalt - Fehler");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LogTabelleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            LogTabelleBindingSource.EndEdit();
            TableAdapterManager.UpdateAll(_WSL_AdressenDataSet);
        }

        private void BTN_Schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Alle_Click(object sender, EventArgs e)
        {
            LogTabelleTableAdapter.Fill(_WSL_AdressenDataSet.LogTabelle);
        }
    }
}