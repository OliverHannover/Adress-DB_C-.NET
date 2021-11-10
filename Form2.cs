using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    public partial class KontoForm
    {
        public KontoForm()
        {
            InitializeComponent();
            _btnKontoSave.Name = "btnKontoSave";
            _Button1.Name = "Button1";
        }

        private int IDFirmenName;

        private void KontoForm_Load(object sender, EventArgs e)
        {
            this.PropertiesTableAdapter.Fill(this._WSL_AdressenDataSet.properties);
            IDFirmenName = Conversions.ToInteger(Adress_DB.My.MyProject.Forms.Hauptform.LBL_IDFirmenName.Text);
            this.lblIDFirmenName.Text = IDFirmenName.ToString();
            this.lblFirmenName.Text = Adress_DB.My.MyProject.Forms.Hauptform.LBL_FirmenName.Text;
            this.lblKontoNummer.Text = string.Empty;
            try
            {
                this.KontoTableAdapter.SucheIDFirmenNameInKonto(this._WSL_AdressenDataSet.Konto, IDFirmenName);
            }
            // Me.FirmenNameTableAdapter.SucheAktiveIDFirmenNameInFirmenName(_WSL_AdressenDataSet.FirmenName, IDFirmenName)
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnKontoSave_Click(object sender, EventArgs e)
        {
            string KontoName = "";
            if (this.rdbKundenNr.Checked == true)
            {
                KontoName = "Kunde";
                double KundenNummer = Conversion.Val(this.PropertiesTableAdapter.ScalarWert("Kundennummer"));
                this.lblKontoNummer.Text = KundenNummer.ToString();
                this.PropertiesTableAdapter.UpdateWert((++KundenNummer).ToString(), "KundenNummer");
            }
            else if (this.rdbLieferantenNr.Checked == true)
            {
                KontoName = "Lieferant";
                double LieferantenNummer = Conversion.Val(this.PropertiesTableAdapter.ScalarWert("Lieferantennummer"));
                this.lblKontoNummer.Text = LieferantenNummer.ToString();
                this.PropertiesTableAdapter.UpdateWert((++LieferantenNummer).ToString(), "LieferantenNummer");
            }

            this.Refresh();

            // die neuen Daten in die Tabelle 'Konto' schreiben: 
            int IDKonto = Conversions.ToInteger(this.lblKontoNummer.Text);
            int IDFirmenName = Conversions.ToInteger(this.lblIDFirmenName.Text);
            this.KontoTableAdapter.Insert(IDKonto, IDFirmenName, KontoName, DateAndTime.Now);
            Adress_DB.Module1.Logging(2, IDKonto, IDFirmenName, KontoName); // LogTabelle schreiben


            // Das DataGrid auf dem Hauptform aktualisieren (TableAdapter mit allen + neuen Werten füllen --> Suche ausführen)
            try
            {
                this.KontoTableAdapter.SucheIDFirmenNameInKonto(this._WSL_AdressenDataSet.Konto, IDFirmenName);
                Adress_DB.My.MyProject.Forms.Hauptform.KontoTableAdapter.SucheIDFirmenNameInKonto(Adress_DB.My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.Konto, IDFirmenName);
                Adress_DB.My.MyProject.Forms.Hauptform.DocuwareCSVTableAdapter.Fill(Adress_DB.My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.DocuwareCSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Neue Docuware-Datei schreiben...
            Adress_DB.Module1.SaveToCSV();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}