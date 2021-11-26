using System;
using System.Data;
using System.Windows.Forms;

namespace Adress_DB
{
    public partial class Administration
    {
        public Administration()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Klassen". Sie können sie bei Bedarf verschieben oder entfernen.
            this.klassenTableAdapter.Fill(this._WSL_AdressenDataSet.Klassen);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.properties". Sie können sie bei Bedarf verschieben oder entfernen.
            this.propertiesTableAdapter.Fill(this._WSL_AdressenDataSet.properties);
            BelegeTableAdapter.Fill(_WSL_AdressenDataSet.Belege);
            KontakteTableAdapter.Fill(_WSL_AdressenDataSet.Kontakte);
            AdressenTableAdapter.Fill(_WSL_AdressenDataSet.Adressen);
            KontoTableAdapter.Fill(_WSL_AdressenDataSet.Konto);
            FirmenNameTableAdapter.Fill(_WSL_AdressenDataSet.FirmenName);

            SachbearbeiterTableAdapter.FillByAktive(_WSL_AdressenDataSet.Sachbearbeiter);
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
                tabControl1.TabPages.Remove(tabPage8);
            }
        }
      

        private void BTN_Aktuell_Click(object sender, EventArgs e)
        {
            var IDFirmenName = default(int);
            if ((My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text ?? "") != (string.Empty ?? ""))
                IDFirmenName = Convert.ToInt32(My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text);
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
                MessageBox.Show("lblIDFirmenName ohne Inhalt - Fehler");
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

        private void _BNAV_PropertiesSave_Click(object sender, EventArgs e)
        {
            Validate();
            propertiesBindingSource.EndEdit();
            propertiesTableAdapter.Update(_WSL_AdressenDataSet.properties);
            BTN_Aktuell.PerformClick();

        }

        private void BTN_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _BTN_NeuerSachbearbeiter_Click(object sender, EventArgs e)
        {
            klassenNameTextBox.DataBindings.Clear();
            klassenNameTextBox.Text = string.Empty;
        }

        private void BTN_Klasse_Speichern_Click(object sender, EventArgs e)
        {
            if (klassenNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Bitte die etwas in das Textfeld schreiben!");
                return;
            }

            try
            {
                klassenTableAdapter.Insert(klassenNameTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert der neuen Klasse fehlgeschlagen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show(ex.Message);
            }

            this.klassenTableAdapter.Fill(this._WSL_AdressenDataSet.Klassen);
            klassenNameTextBox.DataBindings.Add(new Binding("Text", klassenBindingSource, "KlassenName", true));
            My.MyProject.Forms.Hauptform.CB_Klassifizierung.Items.Clear();
            DataTable myDT;
            myDT = klassenTableAdapter.GetData();
            foreach (DataRow row in myDT.Rows)
            {
                My.MyProject.Forms.Hauptform.CB_Klassifizierung.Items.Add(row["KlassenName"]);
            }


        }
    }
}