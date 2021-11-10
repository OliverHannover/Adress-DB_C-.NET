using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    public partial class Administration
    {
        public Administration()
        {
            InitializeComponent();
            _BTN_Alle.Name = "BTN_Alle";
            _BTN_Aktuell.Name = "BTN_Aktuell";
            _BTN_Schliessen.Name = "BTN_Schliessen";
            _BTN_DWPfad.Name = "BTN_DWPfad";
            _BTN_Speichern.Name = "BTN_Speichern";
            _BTN_Vorlagenpfad.Name = "BTN_Vorlagenpfad";
            _BNAV_FirmenNameSave.Name = "BNAV_FirmenNameSave";
            _BNAV_KontoSave.Name = "BNAV_KontoSave";
            _BNAV_AdressenSave.Name = "BNAV_AdressenSave";
            _BNAV_KontakteSave.Name = "BNAV_KontakteSave";
            _BNAV_BelegeSaveItem.Name = "BNAV_BelegeSaveItem";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            BelegeTableAdapter.Fill(_WSL_AdressenDataSet.Belege);
            KontakteTableAdapter.Fill(_WSL_AdressenDataSet.Kontakte);
            AdressenTableAdapter.Fill(_WSL_AdressenDataSet.Adressen);
            KontoTableAdapter.Fill(_WSL_AdressenDataSet.Konto);
            FirmenNameTableAdapter.Fill(_WSL_AdressenDataSet.FirmenName);
            SachbearbeiterTableAdapter.FillByAktive(_WSL_AdressenDataSet.Sachbearbeiter);
            KonfigurationTableAdapter.Fill(_WSL_AdressenDataSet.Konfiguration);
            int foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            SachbearbeiterBindingSource.Position = foundIndex;
            if (AdminCheckBox.Checked == true)
            {
                TC_Administration.Enabled = true;
                BTN_Alle.Enabled = true;
                BTN_Aktuell.Enabled = true;
            }
            else
            {
                TC_Administration.Enabled = false;
                BTN_Alle.Enabled = false;
                BTN_Aktuell.Enabled = false;
            }
        }

        private void BTN_Vorlagenpfad_Click(object sender, EventArgs e)
        {
            // MsgBox("Vorlagenpfad ist " & Me.KonfigurationTableAdapter.ScalarVorlagenpfad().ToString)

            FolderBrowserDialog1.SelectedPath = KonfigurationTableAdapter.ScalarVorlagenpfad().ToString();
            FolderBrowserDialog1.ShowDialog();
            string files = FolderBrowserDialog1.SelectedPath;
            VorlagenpfadTextBox.Text = files + @"\";
        }

        private void BTN_Schliessen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Speichern_Click(object sender, EventArgs e)
        {
            try
            {
                KonfigurationTableAdapter.UpdateAlles(Conversions.ToInteger(IDFirmenNameTextBox.Text), Conversions.ToInteger(LeadnummerTextBox.Text), Conversions.ToInteger(KundennummerTextBox.Text), Conversions.ToInteger(LieferantennummerTextBox.Text), Conversions.ToInteger(IDAdresseTextBox.Text), Conversions.ToInteger(IDKontaktTextBox.Text), Conversions.ToInteger(IDBesuchTextBox.Text), VorlagenpfadTextBox.Text, DWpfadTextBox.Text, DWDateinameTextBox.Text, HilfelinkTextBox.Text, false);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Update der Konfigurations-Tabelle fehlgeschlagen");
            }

            Interaction.MsgBox("Update der Konfigurations-Tabelle erfolgreich");
        }

        private void BTN_Aktuell_Click(object sender, EventArgs e)
        {
            var IDFirmenName = default(int);
            if ((My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text ?? "") != (string.Empty ?? ""))
                IDFirmenName = Conversions.ToInteger(My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text);
            try
            {
                FirmenNameTableAdapter.SucheAktiveIDFirmenNameInFirmenName(_WSL_AdressenDataSet.FirmenName, IDFirmenName);
                KontoTableAdapter.SucheIDFirmenNameInKonto(_WSL_AdressenDataSet.Konto, IDFirmenName);
                AdressenTableAdapter.SucheIDFirmenNameInAdressen(_WSL_AdressenDataSet.Adressen, IDFirmenName);
                KontakteTableAdapter.SucheIDFirmenNameInKontakte(_WSL_AdressenDataSet.Kontakte, IDFirmenName);
                BelegeTableAdapter.SucheIDFirmenNameInBelege(_WSL_AdressenDataSet.Belege, IDFirmenName);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("lblIDFirmenName ohne Inhalt - Fehler");
                MessageBox.Show(ex.Message);
            }

            Module1.AlleTableAdapterAktualisieren(IDFirmenName);
        }

        private void BTN_Alle_Click(object sender, EventArgs e)
        {
            KontakteTableAdapter.Fill(_WSL_AdressenDataSet.Kontakte);
            AdressenTableAdapter.Fill(_WSL_AdressenDataSet.Adressen);
            KontoTableAdapter.Fill(_WSL_AdressenDataSet.Konto);
            FirmenNameTableAdapter.Fill(_WSL_AdressenDataSet.FirmenName);
            BelegeTableAdapter.Fill(_WSL_AdressenDataSet.Belege);
        }

        private void BTN_DWPfad_Click(object sender, EventArgs e)
        {
            // MsgBox("DW-Dateinpfad ist " & Me.KonfigurationTableAdapter.ScalarDWPfad().ToString)

            FolderBrowserDialog1.SelectedPath = KonfigurationTableAdapter.ScalarDWPfad().ToString();
            FolderBrowserDialog1.ShowDialog();
            string files = FolderBrowserDialog1.SelectedPath;
            DWpfadTextBox.Text = files + @"\";
        }

        private void BNAV_BelegeSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            BelegeBindingSource.EndEdit();
            BelegeTableAdapter.Update(_WSL_AdressenDataSet.Belege);
            BTN_Aktuell.PerformClick();
        }

        private void BNAV_FirmenNameSave_Click(object sender, EventArgs e)
        {
            Validate();
            FirmenNameBindingSource.EndEdit();
            FirmenNameTableAdapter.Update(_WSL_AdressenDataSet.FirmenName);
            BTN_Aktuell.PerformClick();
        }

        private void BNAV_KontoSave_Click(object sender, EventArgs e)
        {
            Validate();
            KontoBindingSource.EndEdit();
            KontoTableAdapter.Update(_WSL_AdressenDataSet.Konto);
            BTN_Aktuell.PerformClick();
        }

        private void BNAV_AdressenSave_Click(object sender, EventArgs e)
        {
            Validate();
            AdressenBindingSource.EndEdit();
            AdressenTableAdapter.Update(_WSL_AdressenDataSet.Adressen);
            BTN_Aktuell.PerformClick();
        }

        private void BNAV_KontakteSave_Click(object sender, EventArgs e)
        {
            Validate();
            KontakteBindingSource.EndEdit();
            KontakteTableAdapter.Update(_WSL_AdressenDataSet.Kontakte);
            BTN_Aktuell.PerformClick();
        }
    }
}