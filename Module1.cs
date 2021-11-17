using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
//using Microsoft.VisualBasic;
using Word = Microsoft.Office.Interop.Word;

namespace Adress_DB
{
    static class Module1
    {
       
        public static void NeuenFirmenNamenAnlegen()
        {
            // Komplett neuer Geschäftspartner wird angelegt. Dieser bekommt immer eine neue IDFirmenName und wird zunächst mit einer Leadnummer angelegt.
            // MsgBox("Neuen Geschäftspartner anlegen")

            // hole die nächste freie IDFirmenName
            int IDFirmenName = Convert.ToInt32(My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("IDFirmenName"));
            string FirmenName = My.MyProject.Forms.Hauptform.TB_FirmenName.Text;

            // hole die nächste freie Leadnummer
            int Leadnummer = Convert.ToInt32(My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("Leadnummer"));
            string KontoName = "Lead-" + Convert.ToString(DateTime.Now.Year);

            // Datensatz in Tabelle 'FirmenName' schreiben
            // MsgBox(IDFirmenName.ToString)
            My.MyProject.Forms.Hauptform.FirmenNameTableAdapter.Insert(IDFirmenName, FirmenName, Environment.UserName, System.DateTime.Now, false);
            Logging(1, IDFirmenName, IDFirmenName, FirmenName);

            // Datensatz Konto schreiben - zunächst mit der Leadnummer!
            My.MyProject.Forms.Hauptform.KontoTableAdapter.Insert(Leadnummer, IDFirmenName, KontoName, System.DateTime.Now);
            Logging(2,Leadnummer,IDFirmenName, KontoName);

            // DatensatzSuche wiederholen
            try
            {
                My.MyProject.Forms.Hauptform.FirmenNameTableAdapter.SucheFirmenName(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.FirmenName, My.MyProject.Forms.Hauptform.TB_FirmenName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Werte in der Konfigurations-Tabelle aktualisieren (IDFirmenName + Leadnummer)
            try
            {
                My.MyProject.Forms.Hauptform.PropertiesTableAdapter.UpdateWert((++IDFirmenName).ToString(), "IDFirmenName");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der neuen IDFirmenName in der Konfig-Tabelle");
                MessageBox.Show(ex.Message);
            }

            try
            {
                My.MyProject.Forms.Hauptform.PropertiesTableAdapter.UpdateWert((++Leadnummer).ToString(), "Leadnummer");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Aktualisieren der neuen Lead-Nummer in der Konfig-Tabelle");
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show("vom neu anlegen:");
            //AlleTableAdapterAktualisieren(IDFirmenName);


            // DocuWare-Datei schreiben:
            SaveToCSV();

            // versch Einstellungen:
            {
                var withBlock = My.MyProject.Forms.Hauptform;
                withBlock.PNL_Konto.Visible = true;
                withBlock.lblHinweisKeinTreffer.Visible = false;
                withBlock.PNL_Konto.Visible = true; // Groupboxen Konto, Adresse, Kontakt einblenden
                withBlock.TC_Adresse.Visible = true;
                withBlock.TC_Kontakt.Visible = true;
                withBlock.TB_FirmenName.Text = My.MyProject.Forms.Hauptform.CB_FirmenName.Text;
                withBlock.lblTrefferAnzahl.Text = My.MyProject.Forms.Hauptform.CB_FirmenName.Items.Count + " Treffer";
                withBlock.AdressenDataGridView.Visible = true;
                withBlock.KontakteDataGridView.Visible = true;
            }
        }

        public static void IDFirmenNameInAdresseSatzMarkieren(double IDFirmenName, double IDAdresse)
        {
            // geänderten Datensatz selektieren
            int foundIndex = My.MyProject.Forms.Hauptform.AdressenBindingSource.Find("IDAdresse", IDAdresse);
            My.MyProject.Forms.Hauptform.AdressenBindingSource.Position = foundIndex;
        }

        public static void IDFirmenNameInKontakteSatzMarkieren(int IDFirmenName, int IDKontakt)
        {

            // KontakteTableAdapter aktualisieren, geänderten Satz auswählen
            // Try
            // Hauptform.KontakteTableAdapter.SucheIDFirmenNameInKontakte(Hauptform._WSL_AdressenDataSet.Kontakte, IDFirmenName)
            // Catch ex As System.Exception
            // MsgBox("lblIDFirmenName in Kontakte suchen - Fehler")
            // System.Windows.Forms.MessageBox.Show(ex.Message)
            // End Try

            // geänderten Datensatz selektieren
            int foundIndex = My.MyProject.Forms.Hauptform.KontakteBindingSource.Find("IDKontakt", IDKontakt);
            My.MyProject.Forms.Hauptform.KontakteBindingSource.Position = foundIndex;

            if ((My.MyProject.Forms.Hauptform.LBL_IDAdresseZuKontakt.Text ?? "") == (string.Empty ?? "") & (My.MyProject.Forms.Hauptform.LBL_IDKontakt.Text ?? "") != (string.Empty ?? "") | My.MyProject.Forms.Hauptform.LBL_IDAdresseZuKontakt.Text == "0" & (My.MyProject.Forms.Hauptform.LBL_IDKontakt.Text ?? "") != (string.Empty ?? ""))
            {
                My.MyProject.Forms.Hauptform.LBL_IDAdresseZuKontakt.Text = "Kontakt hat keine Adresse!";
                My.MyProject.Forms.Hauptform.LBL_IDAdresseZuKontakt.ForeColor = Color.Red;
            }
            else
            {
                My.MyProject.Forms.Hauptform.LBL_IDAdresseZuKontakt.ForeColor = Color.Black;
            }
        }

        public static void IDBBInBesucheMitAdresse(int IDFirmenName, int IDBeleg)
        {

            // BesucheTableAdapter aktualisieren, geänderten Satz auswählen
            try
            {
                My.MyProject.Forms.Hauptform.BelegeMitAdresseTableAdapter.SucheIDFirmenNameInBelegeMitAdresse(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.BelegeMitAdresse, IDFirmenName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("lblIDFirmenName in Besuche suchen - Fehler");
                MessageBox.Show(ex.Message);
            }

            // geänderten Datensatz selektieren
            int foundIndex = My.MyProject.Forms.Hauptform.BelegeMitAdresseBindingSource.Find("IDBeleg", IDBeleg);
            // MsgBox(foundIndex & " " & IDBeleg)
            My.MyProject.Forms.Hauptform.BelegeMitAdresseBindingSource.Position = foundIndex;
        }

        public static void AlleTableAdapterAktualisieren(int IDFirmenName)
        {
            // Das Label ist eine eine Datenquelle gebunden. Je nach selektiertem Satz ändert sich der Inhalt.
            // Wenn sich der Text das Labels ändert, muss auch der KontoTableAdapter immer mit den Werten des aktuellen Geschäftspartners gefüllt werden:
            //MessageBox.Show("Alle Adapter aktualisieren");

            My.MyProject.Forms.Hauptform.KontakteDataGridView.DataSource = "";
            My.MyProject.Forms.Hauptform.KontakteDataGridView.Refresh();
            My.MyProject.Forms.Hauptform.AdressenDataGridView.DataSource = "";
            My.MyProject.Forms.Hauptform.AdressenDataGridView.Refresh();
            try
            {
                My.MyProject.Forms.Hauptform.KontoTableAdapter.SucheIDFirmenNameInKonto(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.Konto, IDFirmenName);
                My.MyProject.Forms.Hauptform.AdressenTableAdapter.SucheIDFirmenNameInAdressen(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.Adressen, IDFirmenName);
                My.MyProject.Forms.Hauptform.KontakteTableAdapter.SucheIDFirmenNameInKontakte(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.Kontakte, IDFirmenName);

                My.MyProject.Forms.Hauptform.BelegeMitAdresseTableAdapter.SucheIDFirmenNameInBelegeMitAdresse(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.BelegeMitAdresse, IDFirmenName);
                My.MyProject.Forms.Hauptform.KontakteMitAdresseTableAdapter.SucheIDFirmenNameInKontakteMitAdresse(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.KontakteMitAdresse, IDFirmenName);
                My.MyProject.Forms.Hauptform.DocuwareCSVTableAdapter.Fill(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.DocuwareCSV);

                

                
            }
            catch (Exception)
            {
                MessageBox.Show("lblIDFirmenName ohne Inhalt - Fehler");
            }

            // MsgBox("Datagrid leer und ungebunden, neu gesucht...")
            My.MyProject.Forms.Hauptform.KontakteDataGridView.DataSource = My.MyProject.Forms.Hauptform.KontakteBindingSource;
            My.MyProject.Forms.Hauptform.AdressenDataGridView.DataSource = My.MyProject.Forms.Hauptform.AdressenBindingSource;

        }

        //Using Microsoft Office Interop Word
        public static bool WordStarten(string Belegtyp) //Belegtyp wird übergeben
        {
            Cursor.Current = Cursors.WaitCursor;

            // öffnet den Word-Besuchsbericht und füllt den Kopf mit markierten Daten,
            string Pfad;
            Pfad = My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("Vorlagenpfad");
            if (Pfad.Substring(Pfad.Length -1 , 1) != @"\")
                Pfad += @"\";
            Pfad += Belegtyp;


            Microsoft.Office.Interop.Word._Document aDoc = null;
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Word._Application wordApp = new Microsoft.Office.Interop.Word.Application();

            try
            {
                if (File.Exists(Pfad))
                {
                    object fileName = Pfad;             
                    //object readOnly = false;
                    object isVisible = true;
                    object newTemplate = false;
                    object docType = 0;
                
                    wordApp.Visible = true;

                    aDoc = wordApp.Documents.Add(ref fileName, ref newTemplate, ref docType, ref isVisible);
                   
                    aDoc.Activate();

                    // nun alle Ersetzungen durchführen:
                    DateTime datum;
                    string dateWithFormat;

                    FindAndReplace((Word.Application)wordApp, "#FirmenName", My.MyProject.Forms.Hauptform.LBL_FirmenName.Text);
                    FindAndReplace((Word.Application)wordApp, "#BBBerichtNr", My.MyProject.Forms.Hauptform.IDBeleg);
                    FindAndReplace((Word.Application)wordApp, "#Strasse", My.MyProject.Forms.Hauptform.LBL_BBStrasse.Text);
                    FindAndReplace((Word.Application)wordApp, "#PLZ", My.MyProject.Forms.Hauptform.LBL_BBPLZ.Text);
                    FindAndReplace((Word.Application)wordApp, "#Ort", My.MyProject.Forms.Hauptform.LBL_BBOrt.Text);
                    FindAndReplace((Word.Application)wordApp, "#Region", My.MyProject.Forms.Hauptform.LBL_BBRegion.Text);
                    FindAndReplace((Word.Application)wordApp, "#Land", My.MyProject.Forms.Hauptform.LBL_BBLand.Text);
                    FindAndReplace((Word.Application)wordApp, "#VAT_ID", My.MyProject.Forms.Hauptform.UStIdNrLabel2.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontAnrede", My.MyProject.Forms.Hauptform.LBL_Anrede.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontVorname", My.MyProject.Forms.Hauptform.LBL_Vorname.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontNachname", My.MyProject.Forms.Hauptform.LBL_Nachname.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontEmail", My.MyProject.Forms.Hauptform.EmailAddresseLinkLabel.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontTelGesch", My.MyProject.Forms.Hauptform.TelefonGeschaeftlichLinkLabel.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontTelPriv", My.MyProject.Forms.Hauptform.TelefonPrivatLinkLabel.Text);
                    FindAndReplace((Word.Application)wordApp, "#KontTelMobil", My.MyProject.Forms.Hauptform.MobiltelefonLinkLabel.Text);
                    FindAndReplace((Word.Application)wordApp, "#BBWeitereKontakte", My.MyProject.Forms.Hauptform.TB_BBWeitereKontakte.Text);

                    datum = My.MyProject.Forms.Hauptform.DTP_BBDatum.Value;
                    dateWithFormat = datum.ToShortDateString();
                    FindAndReplace((Word.Application)wordApp, "#BBDatum", dateWithFormat);

                    FindAndReplace((Word.Application)wordApp, "#BBvonWem", My.MyProject.Forms.Hauptform.CB_BBKuerzel.Text);
                    FindAndReplace((Word.Application)wordApp, "#BBWeitereBesucher", My.MyProject.Forms.Hauptform.TB_BBWeitereBesucher.Text);
                    FindAndReplace((Word.Application)wordApp, "#BBThema", My.MyProject.Forms.Hauptform.TB_BBThema.Text);
                    FindAndReplace((Word.Application)wordApp, "#BriefBetreff", My.MyProject.Forms.Hauptform.TB_DIVThema.Text);

                    if ((My.MyProject.Forms.Hauptform.LBL_BBIDKonto.Text ?? "") == (string.Empty ?? ""))
                    {

                        FindAndReplace((Word.Application)wordApp, "#KontoNr", My.MyProject.Forms.Hauptform.LBL_BBIDKonto.Text);
                    }
                    else
                    {
                        FindAndReplace((Word.Application)wordApp, "#KontoNr", My.MyProject.Forms.Hauptform.lblIDKonto.Text);
                    }

                    string Adresse = My.MyProject.Forms.Hauptform.LBL_DIVAdresse.Text;
                    string newAdresse = Adresse.Replace("\n", string.Empty);
                    FindAndReplace((Word.Application)wordApp, "#KomplAdresse", newAdresse);

                    FindAndReplace((Word.Application)wordApp, "#FaxNr", My.MyProject.Forms.Hauptform.TB_DIVFaxnummer.Text);
                    FindAndReplace((Word.Application)wordApp, "#DW", My.MyProject.Forms.Hauptform.LBL_DIVDurchwahl.Text);

                    datum = My.MyProject.Forms.Hauptform.DTP_Diverse.Value;
                    dateWithFormat = datum.ToShortDateString();
                    FindAndReplace((Word.Application)wordApp, "#Datum", dateWithFormat);

                    FindAndReplace((Word.Application)wordApp, "#Sachbearbeiter", My.MyProject.Forms.Hauptform.CB_DIVSachbearbeiter.Text);
                    FindAndReplace((Word.Application)wordApp, "#BriefPosition", My.MyProject.Forms.Hauptform.LBL_DIVJobtitle.Text);
                    FindAndReplace((Word.Application)wordApp, "#Email", My.MyProject.Forms.Hauptform.LBL_DIVEmail.Text);


                    //System.Text.ASCIIEncoding enc = new ASCIIEncoding();
                    //System.Text.Encoding.Unicode

                    // File.WriteAllText(textBoxSaveFilePath.Text, text, System.Text.Encoding.Default);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Ersezten von Text in Word-Dokument");
                MessageBox.Show(ex.ToString());
                
            }
            finally
            {

                //aDoc.Close();
                //wordApp.Quit();
            }
            return true;
        }


        private static void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }




        public static void SaveToCSV()
        {
            Cursor.Current = Cursors.WaitCursor;
            // Build the CSV file data as a Comma separated string.
            string csv = string.Empty;
            // MsgBox(Form1.DocuwareCSVDataGridView.RowCount)

            // Add the Header row for CSV file.
            foreach (DataGridViewColumn column in My.MyProject.Forms.Hauptform.DocuwareCSVDataGridView.Columns)
                csv += column.HeaderText.ToString() + ';';

            // Add new line.
            csv += Environment.NewLine;

            // Adding the Rows
            foreach (DataGridViewRow row in My.MyProject.Forms.Hauptform.DocuwareCSVDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    // Add the Data rows.
                    // csv += cell.Value.ToString().Replace(",", ";") & ","c
                    csv += cell.Value.ToString() + ';';
                // Add new line.
                csv += Environment.NewLine;

            }

            // Exporting to Excel
            string folderPath;
            // Pfad und Dateiname aus der Datenbank auslesen:
            folderPath = My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("DWPfad") + My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("DWDateiname");
            // MsgBox(folderPath)
            File.WriteAllText(folderPath, csv);
            // File.WriteAllText(folderPath & "DataGridViewExport.csv", csv)




            Cursor.Current = Cursors.Default;
            My.MyProject.Forms.Hauptform.ToolStripStatusLabel1.Visible = true;

        }

        public static void FillVorlagen()
        {
            string pfad;
            pfad = My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("Vorlagenpfad"); // anpassen

            if (pfad.Substring(pfad.Length -1, 1) != @"\")
                pfad += @"\";

            //MessageBox.Show(pfad);

            DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(pfad);
            foreach (FileInfo f in ParentDirectory.GetFiles())
            {
                //MessageBox.Show((f.Name);
                if (f.Name != "" )
                {
                    if ((f.Extension == ".dotx") && (f.Name).Substring(1, 1) != "$")
                    {
                        if (f.Name != "Besuchsbericht.dotx") // der Besuchsbericht soll NICHT eingelesen werden!
                        {
                            My.MyProject.Forms.Hauptform.CB_Vorlagen.Items.Add(f.Name);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Der Vorlagenordner auf N:.. wurde nicht gefunden! BItte Info an den Administrator", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
               My.MyProject.Forms.Hauptform.CB_Vorlagen.SelectedIndex = 0; 
        }

        public static void Logging(int Typ, int IDInTabelle, int IDFirmenName, string Hinweis)
        {
            // Alle Änderungen werden hier übergeben und in die Log-TAbelle geschrieben

            string Meldung = string.Empty;
            string Tabelle = string.Empty;
            switch (Typ)
            {
                case 1:
                    {
                        Meldung = "Neuer Geschäftspartner angelegt";
                        Tabelle = "FirmenName";
                        break;
                    }

                case 2:
                    {
                        Meldung = "Neues Konto angelegt";
                        Tabelle = "Konto";
                        break;
                    }

                case 3:
                    {
                        Meldung = "Name des Geschäftspartners geändert";
                        Tabelle = "FirmenName";
                        break;
                    }

                case 4:
                    {
                        Meldung = "Neue Adresse angelegt";
                        Tabelle = "Adressen";
                        break;
                    }

                case 5:
                    {
                        Meldung = "Adresse geändert";
                        Tabelle = "Adressen";
                        break;
                    }

                case 6:
                    {
                        Meldung = "Neuen Kontakt angelegt";
                        Tabelle = "Kontakte";
                        break;
                    }

                case 7:
                    {
                        Meldung = "Kontakt geändert";
                        Tabelle = "Kontakte";
                        break;
                    }

                case 8:
                    {
                        Meldung = "Besuchsbericht erstellt";
                        Tabelle = "Belege";
                        break;
                    }

                case 9:
                    {
                        Meldung = My.MyProject.Forms.Hauptform.CB_Vorlagen.Text + " erstellt";
                        Tabelle = "Belege";
                        break;
                    }

                case 10:
                    {
                        Meldung = "Kontakt gelöscht";
                        Tabelle = "Kontakte";
                        break;
                    }
            }

            My.MyProject.Forms.Hauptform.LogTabelleTableAdapter.Insert(Meldung, Tabelle, IDInTabelle, Hinweis, Environment.UserName, DateTime.Now, IDFirmenName, My.MyProject.Forms.Hauptform.LBL_FirmenName.Text);
        }
    }
}