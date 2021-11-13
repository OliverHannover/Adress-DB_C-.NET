using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    public partial class Hauptform
    {
        public Hauptform()
        {
            InitializeComponent();
            _BTN_Suche.Name = "BTN_Suche";
            _LBL_IDFirmenName.Name = "LBL_IDFirmenName";
            _CB_FirmenName.Name = "CB_FirmenName";
            _BTN_NachnameSuche.Name = "BTN_NachnameSuche";
            _Button1.Name = "Button1";
            _LBL_IDAdresse.Name = "LBL_IDAdresse";
            _btnNeueAdresse.Name = "btnNeueAdresse";
            _btnNeuerKontakt.Name = "btnNeuerKontakt";
            _BTN_ZuOutlook.Name = "BTN_ZuOutlook";
            _BTN_MapsSuche.Name = "BTN_MapsSuche";
            _btnNeuesKonto.Name = "btnNeuesKonto";
            BTN_Speichern.Name = "btnSpeichern";
            _btnKontoZuAdresse.Name = "btnKontoZuAdresse";
            _TB_PLZ.Name = "TB_PLZ";
            _EmailAddresseLinkLabel.Name = "EmailAddresseLinkLabel";
            _btnAdresseZuKontakt.Name = "btnAdresseZuKontakt";
            _LBL_IDKontakt.Name = "LBL_IDKontakt";
            _RB_OhneAnrede.Name = "RB_OhneAnrede";
            _RB_MitAnrede.Name = "RB_MitAnrede";
            _LBL_Sprache.Name = "LBL_Sprache";
            _CB_Vorlagen.Name = "CB_Vorlagen";
            _LBL_FirmenName.Name = "LBL_FirmenName";
            _btnAbbrechen.Name = "btnAbbrechen";
            _LBL_IDKontoZuAdresse.Name = "LBL_IDKontoZuAdresse";
            _WebseiteLinkLabel.Name = "WebseiteLinkLabel";
            _LBL_IDAdresseZuKontakt.Name = "LBL_IDAdresseZuKontakt";
            _MobiltelefonLinkLabel.Name = "MobiltelefonLinkLabel";
            _TelefonPrivatLinkLabel.Name = "TelefonPrivatLinkLabel";
            _TelefonGeschaeftlichLinkLabel.Name = "TelefonGeschaeftlichLinkLabel";
            _LBL_Anrede.Name = "LBL_Anrede";
            _BTN_DeleteUser.Name = "BTN_DeleteUser";
            _DocuWareDateiManuellToolStripMenuItem.Name = "DocuWareDateiManuellToolStripMenuItem";
            _SchließenToolStripMenuItem.Name = "SchließenToolStripMenuItem";
            _BenutzerlisteToolStripMenuItem.Name = "BenutzerlisteToolStripMenuItem";
            _EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem";
            _AktivitätslogToolStripMenuItem.Name = "AktivitätslogToolStripMenuItem";
            _InfoÜberAdressenDBToolStripMenuItem1.Name = "InfoÜberAdressenDBToolStripMenuItem1";
            _HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem";
        }

        public int IDBeleg;
        private bool AdresseNeu = false;
        private bool KontaktNeu = false;
        private string Suchstring;

        private void Form1_Load(object sender, EventArgs e)
        {
           
            // 'Tabellen laden:
            // Me.StaatenTableAdapter.Fill(Me._WSL_AdressenDataSet.Staaten)

            // Me.BelegeMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.BelegeMitAdresse)
            // Me.BelegeTableAdapter.Fill(Me._WSL_AdressenDataSet.Belege)
            // Me.LogTabelleTableAdapter.Fill(Me._WSL_AdressenDataSet.LogTabelle)
            // Me.DocuwareCSVTableAdapter.Fill(Me._WSL_AdressenDataSet.DocuwareCSV)
            // Me.KontakteMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.KontakteMitAdresse)

            // 'Liste wird mit ALLEN Usern gefüllt, auch den inaktiven (für die Usererkennung)!
            // Me.SachbearbeiterTableAdapter.Fill(Me._WSL_AdressenDataSet.Sachbearbeiter)

            Width = 1190;
            Height = 680;
            lblTrefferAnzahl.Text = "Trefferanzahl"; // Starttext
            PNL_Konto.Visible = false; // Groupboxen Konto, Adresse, Kontakt ausblenden
            TC_Adresse.Visible = false;
            TC_Kontakt.Visible = false;
            TC_Beleg.Visible = false;
            LBL_BBBesuchterKontakt.Text = string.Empty;
            // LBL_IDFirmenName.Text = String.Empty
            LBL_IDFirmenName.Text = "0";
            _LBL_IDAdresse.Text = "0";
            lblHinweisKeinTreffer.Visible = false;
            TB_FirmenName.Select();
            lblHinweisKeinTreffer.Location = new Point(200, 200);
            TLP_1.Location = new Point(0, 25);
            DTP_BBDatum.Value = DateTime.Now;
            DTP_Diverse.Value = DateTime.Now;



            // zuerst (wichtig) Combobox Anrede füllen
            {
                var withBlock = AnredeComboBox;
                withBlock.Items.Add("Hr.");
                withBlock.Items.Add("Hr. Dr.");
                withBlock.Items.Add("Fr.");
                withBlock.Items.Add("Fr. Dr.");
                withBlock.Items.Add("Mr.");
                withBlock.Items.Add("Mrs.");
                withBlock.SelectedIndex = 0;
            }

            DocuwareCSVDataGridView.Sort(DocuwareCSVDataGridView.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Hauptform_Shown(object sender, EventArgs e)
        {
            // Erest prüfen, ob das System im Wartungsmodus ist:
            //bool Wartung = Convert.ToBoolean(My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("Wartung")) == true;
            //if (Wartung == true)
            //{
            //    MessageBox.Show("Das System, befindet sich in der Wartung!" + Environment.NewLine + "Das Progamm wird sich jetzt beenden." + Environment.NewLine + "Bitte später noch einmal versuchen.");
            //    Application.Exit();
            //}

            // Dann Tabellen laden
            // Tabellen laden:
            StaatenTableAdapter.Fill(_WSL_AdressenDataSet.Staaten);
            BelegeMitAdresseTableAdapter.Fill(_WSL_AdressenDataSet.BelegeMitAdresse);
            BelegeTableAdapter.Fill(_WSL_AdressenDataSet.Belege);
            LogTabelleTableAdapter.Fill(_WSL_AdressenDataSet.LogTabelle);
            DocuwareCSVTableAdapter.Fill(_WSL_AdressenDataSet.DocuwareCSV);
            KontakteMitAdresseTableAdapter.Fill(_WSL_AdressenDataSet.KontakteMitAdresse);

            // Liste wird mit ALLEN Usern gefüllt, auch den inaktiven (für die Usererkennung)!
            SachbearbeiterTableAdapter.Fill(_WSL_AdressenDataSet.Sachbearbeiter);




            // Benutzer erkennen in der Tabelle mit ALLEN Usern - auch inaktive:
            int foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            if (foundIndex < 0)
            {
                MessageBox.Show("Ihr Login wurde nicht erkannt. Bitte im Menü über Einstellungen/Benutzerliste Ihre Benutzerdaten prüfen/korrigieren oder ergänzen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblUser.Text = "Sachbearbeiter nicht erkannt";
                lblUser.ForeColor = Color.Red;
                BTN_Speichern.Visible = false;
                BTN_DocErzeugen.Visible = false;
                My.MyProject.Forms.Sachbearbeiter.Show();
            }
            else
            {
                // Username in das Label schreiben
                lblUser.Text = SachbearbeiterTableAdapter.ScalarSachbearbeiter(foundIndex + 1);
            }

            // Dann die Tabelle nur mit den aktiven füllen und weiter geht es...
            SachbearbeiterTableAdapter.FillByAktive(_WSL_AdressenDataSet.Sachbearbeiter);
            foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            SachbearbeiterBindingSource.Position = foundIndex;

            // Combobox Vorlagen füllen
            Module1.FillVorlagen();
        }

        private void BTN_Suche_Click(object sender, EventArgs e)
        {
            // MsgBox("Starte Suche...")

            Suchstring = TB_FirmenName.Text;
            if ((TB_FirmenName.Text ?? "") != (string.Empty ?? ""))
            {
                try
                {
                    FirmenNameTableAdapter.SucheFirmenName(_WSL_AdressenDataSet.FirmenName, TB_FirmenName.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("FirmenName");
                    MessageBox.Show(ex.Message);
                }

                lblTrefferAnzahl.Text = CB_FirmenName.Items.Count + " Treffer";
            }
            else
            {
                Interaction.MsgBox("Bitte einen Suchbegriff eingeben", Constants.vbExclamation);
            }

            // MsgBox("beende Suche.")
        }

        private void btnNeuesKonto_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.KontoForm.Show();
        }

        private void LBL_FirmenName_TextChanged(object sender, EventArgs e)
        {
            // gefundenen/ausgewählten Firmennamen in die Suchtextbox zurück schreiben:

            if ((LBL_FirmenName.Text ?? "") != (string.Empty ?? ""))
            {
                TB_FirmenName.Text = LBL_FirmenName.Text;
                AdresseBauen();
            }
            // MsgBox(IDFirmenName & " LBL_(ohneID)FirmenName_TextChanged")

        }

        private void LBL_IDFirmenName_TextChanged(object sender, EventArgs e)
        {
            // Das Label lblIDFirmenName ist an die Datenquelle 'FirmenNameTableAdapter' gebunden. Ändert sich dieser
            // oder wird ein anderer Datensatz davon selektiert, ändert sich auch der Text im Label.
            // IDFirmenName MUSS Double sein - weil es zwischendurch den Wert 0 oder empty annimmt. Dies kann nicht zu integer konvertiert werden!
            double IDFirmenName;
            IDFirmenName = Conversion.Val(LBL_IDFirmenName.Text);
            //MessageBox.Show("ID=" + IDFirmenName + " LBL_IDFirmenName_TextChanged");

            if (IDFirmenName != 0d)
            {
                // Es wurden Treffer gefunden ----------------------------------------------------
                //MessageBox.Show("Treffer gefunden");
                PNL_Konto.Visible = true; // Groupboxen Konto, Adresse, Kontakt einblenden
                TC_Adresse.Visible = true;
                TC_Kontakt.Visible = true;
                TC_Beleg.Visible = true;
                CB_FirmenName.Enabled = true;
                lblHinweisKeinTreffer.Visible = false;
                // Alle anderen Tableadapter werden erst neu befüllt, wenn lblIDFirmenName auch einen Wert <> 0 zurück gibt!
                Module1.AlleTableAdapterAktualisieren((int)Math.Round(IDFirmenName));
            }
            else
            {
                // keine Treffer -----------------------------------------------------------------
                // MsgBox("keine Treffer gefunden")
                PNL_Konto.Visible = false; // Groupboxen Konto, Adresse, Kontakt ausblenden
                TC_Adresse.Visible = false;
                TC_Kontakt.Visible = false;
                TC_Beleg.Visible = false;
                CB_FirmenName.Enabled = false;
                lblHinweisKeinTreffer.Visible = true;
                lblHinweisKeinTreffer.Text = "Nichts gefunden!" + Constants.vbNewLine + "Klicke 'Speichern', um diesen Geschäftspartner neu anzulegen.";
                // btnSpeichern.BackColor = Color.Green
                TB_FirmenName.Text = Suchstring;
            }
        }



        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            // 1) Neuen Geschäftspartner anlegen
            // 2) FirmenName / Name Geschäftspartner ändern/aktualisieren
            // 3) Adresse neu anlegen
            // 4) Kontakt neu anlegen
            // 5) TableUpdate Adressen bei Änderung
            // 6) TableUpdate Kontakte bei Änderung


            // 1) #####################################################################################################################
            // Neuen Geschäftspartner anlegen:
            // Ein Datensatz in FirmenNamen ergänzen + LeadKonto in Konto ergänzen, wenn:
            // ComboBox leer, TextBox FirmenName hat Wert und Hinweislabel sichtbar
            // Wird ausgeführt im Modul1 / NeuenFirmenNamenAnlegen
            if (CB_FirmenName.Items.Count == 0 & !string.IsNullOrEmpty(TB_FirmenName.Text) & lblHinweisKeinTreffer.Visible == true)
            {
                // MsgBox("Neuen Geschäftspartner anlegen")
                // Abfrage ob gespeichert werden soll


                DialogResult Result;
                Result = MessageBox.Show("Folgenden Geschäftspartner anlegen:" + Constants.vbNewLine + Constants.vbNewLine + "auf RECHTSCHREIBUNG achten...!" + Constants.vbNewLine + Constants.vbNewLine + TB_FirmenName.Text, "Neuen Geschäftspartner anlegen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Result == DialogResult.Yes)
                {
                    Module1.NeuenFirmenNamenAnlegen();
                }
                else if (Result == DialogResult.No)
                {
                    // exit the procedure
                    return;
                }

                return; // keine weiteren IF/Then-Prüfungen! KEIN WEITERER PROZESSABLAUF!
            } // Ende neuen Geschäftspartner anlegen

            // 2) #####################################################################################################################

            int IDFirmenName = Convert.ToInt32(LBL_IDFirmenName.Text);
            var IDAdresse = default(int);
            var IDKontakt = default(int);

            // FirmenName / Name Geschäftspartner ändern/aktualisieren
            if ((TB_FirmenName.Text ?? "") != (CB_FirmenName.Text ?? "") & (TB_FirmenName.Text ?? "") != (string.Empty ?? "") & Conversion.Val(LBL_IDFirmenName.Text) != 0d)
            {
                // MsgBox("Geschäftspartner umbenennen")


                string FirmenNameNeu = TB_FirmenName.Text;
                string FirmenNameAlt = CB_FirmenName.Text;

                // Abfrage ob Umbenennen oder neu anlegen?
                int intAnswer;
                intAnswer = (int)MessageBox.Show("auf RECHTSCHREIBUNG achten...!" + Constants.vbNewLine + Constants.vbNewLine + "'Ja' für Umbenennen: " + FirmenNameAlt + " --> " + FirmenNameNeu + Constants.vbNewLine + Constants.vbNewLine + "'Nein' für NEU anlegen: " + FirmenNameNeu, "Geschäftspartner umbenennen oder neu?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (intAnswer)
                {
                    case (int)Constants.vbYes:
                        {
                            try
                            {
                                // Datensatz FirmenName schreiben
                                FirmenNameTableAdapter.UpdateFirmenName(FirmenNameNeu, Environment.UserName, DateAndTime.Now.ToString(), IDFirmenName);
                            }
                            catch (Exception ex)
                            {
                                Interaction.MsgBox("Umbenennen fehlgeschlagen", Constants.vbExclamation);
                                MessageBox.Show(ex.Message);
                            }

                            Module1.Logging(3, IDFirmenName, IDFirmenName, FirmenNameAlt + " --> " + FirmenNameNeu); // LogTabelle schreiben
                            Interaction.MsgBox("Firmenname umbenannt");

                            // DocuWare-Datei schreiben:
                            BTN_Suche.PerformClick();
                            Module1.SaveToCSV();
                            return;
                        }

                    case (int)Constants.vbNo:
                        {
                            // MsgBox("neu anlegen")
                            Module1.NeuenFirmenNamenAnlegen();
                            return;
                        }

                    case (int)Constants.vbCancel:
                        {
                            // MsgBox("Abbrechen")
                            return;
                        }
                }

                return; // keine weiteren IF/Then-Prüfungen!
            } // FirmenName/Geschäftspartner umbenennen

            // 3) #####################################################################################################################


            // Adresse neu anlegen
            if (AdresseNeu == true & (CB_Ort.Text ?? "") != (string.Empty ?? ""))
            {
                // MsgBox("Adresse neu anlegen")
                // Wert aus Konfig-Tabelle holen
                IDAdresse = Convert.ToInt32(My.MyProject.Forms.Hauptform.PropertiesTableAdapter.ScalarWert("IDAdresse"));

                // Datensatz Adresse hinzufügen
                try
                {
                    AdressenTableAdapter.Insert(IDAdresse, IDFirmenName, Convert.ToInt32(IDKontoTextBox.Text), AdresstypTextBox.Text, StraßeTextBox.Text, PostfachTextBox.Text, TB_PLZ.Text, CB_Ort.Text, TB_Bundesland.Text, CB_Staat.Text, UStIdNrTextBox.Text, WebseiteTextBox.Text, LBL_Countrycode.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler beim hinzufügen einer Adresse");
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    // Nächsten Wert in der Konfig-Tabelle aktualisieren
                    PropertiesTableAdapter.UpdateWert((++IDAdresse).ToString(), "IDAdresse");
                                    }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler beim änmdern der neuen IDAdresse in der Konfig-Tabelle");
                    MessageBox.Show(ex.Message);
                }

                Module1.Logging(4, IDAdresse, IDFirmenName, CB_Ort.Text); // LogTabelle schreiben
                AdresseNeu = false;
                lblAdresseNeu.Visible = false;
                LBL_IDKontoZuAdresse.ForeColor = Color.Black;
                TC_Adresse.SelectedIndex = 0;
                CB_Ort.BackColor = Color.White;
            }
            else if (AdresseNeu == true & (CB_Ort.Text ?? "") == (string.Empty ?? ""))
            {
                Interaction.MsgBox("Bitte einen Ort für Adresse erfassen!", Constants.vbExclamation, "Neue Adresse Anlegen");
                CB_Ort.Select();
                CB_Ort.BackColor = Color.MistyRose;
                return; // keine weiteren IF/Then-Prüfungen!
            }

            // 4) #####################################################################################################################
            // Kontakt neu anlegen

            if (KontaktNeu == true & (NachnameTextBox.Text ?? "") != (string.Empty ?? ""))
            {
                // MsgBox("Kontakt neu anlegen")
                // Wert aus Konfig-Tabelle holen
                IDKontakt = Convert.ToInt32(PropertiesTableAdapter.ScalarWert("IDKontakt"));

                // Datensatz Kontakt hinzufügen
                try
                {
                    KontakteTableAdapter.Insert(IDKontakt,
                                                IDFirmenName,
                                                NachnameTextBox.Text,
                                                VornameTextBox.Text,
                                                EmailAddresseTextBox.Text,
                                                PositionTextBox.Text,
                                                TelefonGeschaeftlichTextBox.Text,
                                                TelefonPrivatTextBox.Text,
                                                MobiltelefonTextBox.Text,
                                                FaxnummerTextBox.Text,
                                                Convert.ToInt32(IDAdresseTextBox.Text),
                                                AnredeComboBox.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler beim hinzufügen eines Kontaktes");
                    MessageBox.Show(ex.Message);
                }

                try
                {
                    // Nächsten Wert in der Konfig-Tabelle aktualisieren
                    PropertiesTableAdapter.UpdateWert((++IDKontakt).ToString(), "IDKontakt");
                    
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler beim Aktualisieren der neuen IDKontakt-Nummer in der Konfig-Tabelle");
                    MessageBox.Show(ex.Message);
                }

                Module1.Logging(6, IDKontakt, IDFirmenName, NachnameTextBox.Text); // LogTabelle schreiben
                KontaktNeu = false;
                lblKontaktNeu.Visible = false;
                LBL_IDAdresseZuKontakt.ForeColor = Color.Black;
                TC_Kontakt.SelectedIndex = 0;
                NachnameTextBox.BackColor = Color.White;
            }
            else if (KontaktNeu == true & (NachnameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Interaction.MsgBox("Bitte einen Nachnamen bei Kontakt erfassen!", Constants.vbExclamation, "Neuen Kontakt anlegen");
                NachnameTextBox.Select();
                NachnameTextBox.BackColor = Color.MistyRose;
                return; // keine weiteren IF/Then-Prüfungen!
            }

            // 5) #####################################################################################################################
            // TableUpdate Adressen bei Änderung
            // MsgBox(tcAdresse.SelectedIndex.ToString)


            if (AdresseNeu == false & TC_Adresse.SelectedIndex == 1 & (CB_Ort.Text ?? "") != (string.Empty ?? ""))
            {
                // MsgBox("Adresse ändern")
                int IDKonto;
                if ((IDKontoTextBox.Text ?? "") == (string.Empty ?? ""))
                {
                    IDKonto = Convert.ToInt32(lblIDKonto.Text);
                }
                else
                {
                    IDKonto = Convert.ToInt32(IDKontoTextBox.Text);
                }

                try
                {
                    AdressenTableAdapter.UpdateAdressen(IDFirmenName,
                                                        IDKonto,
                                                        AdresstypTextBox.Text,
                                                        StraßeTextBox.Text,
                                                        PostfachTextBox.Text,
                                                        TB_PLZ.Text,
                                                        CB_Ort.Text,
                                                        TB_Bundesland.Text,
                                                        CB_Staat.Text,
                                                        LBL_Countrycode.Text,
                                                        UStIdNrTextBox.Text,
                                                        WebseiteTextBox.Text,
                                                        Convert.ToInt32(LBL_IDAdresse.Text));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler bei 'Adresse ändern' in der Adress-Tabelle", Constants.vbExclamation);
                    MessageBox.Show(ex.Message);
                }

                Module1.Logging(5, Convert.ToInt32(LBL_IDAdresse.Text), IDFirmenName, CB_Ort.Text); // LogTabelle schreiben
                Interaction.MsgBox("Adresse geändert");
                TC_Adresse.SelectedIndex = 0;
                // Exit Sub 'keine weiteren IF/Then-Prüfungen!
            }

            // 6) #####################################################################################################################
            // TableUpdate Kontakte bei Änderung
            if (KontaktNeu == false & TC_Kontakt.SelectedIndex == 1 & (NachnameTextBox.Text ?? "") != (string.Empty ?? ""))
            {
                // MsgBox("Kontakt ändern")

                try
                {
                    KontakteTableAdapter.UpdateKontakte(IDFirmenName,
                                                        NachnameTextBox.Text,
                                                        VornameTextBox.Text,
                                                        EmailAddresseTextBox.Text,
                                                        PositionTextBox.Text,
                                                        TelefonGeschaeftlichTextBox.Text,
                                                        TelefonPrivatTextBox.Text,
                                                        MobiltelefonTextBox.Text,
                                                        FaxnummerTextBox.Text,
                                                        Convert.ToInt32(IDAdresseTextBox.Text),
                                                        AnredeComboBox.Text,
                                                        Convert.ToInt32(LBL_IDKontakt.Text));
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Fehler bei 'Kontakt ändern' in der Kontakte-Tabelle", Constants.vbExclamation);
                    MessageBox.Show(ex.Message);
                }

                Module1.Logging(7, System.Convert.ToInt32(LBL_IDKontakt.Text), IDFirmenName, NachnameTextBox.Text); // LogTabelle schreiben
                Interaction.MsgBox("Kontakt geändert");
                TC_Kontakt.SelectedIndex = 0;
                // Exit Sub 'keine weiteren IF/Then-Prüfungen!
            }


            // Schluss ############################################################################################################### 
            // TableAdapter aktualisieren und aktuellen Satz markieren
            Module1.AlleTableAdapterAktualisieren(IDFirmenName);
            Module1.IDFirmenNameInAdresseSatzMarkieren(IDFirmenName, IDAdresse);
            Module1.IDFirmenNameInKontakteSatzMarkieren(IDFirmenName, IDKontakt);
        }

        private void EmailAddresseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + EmailAddresseTextBox.Text);
        }

        private void btnKontoZuAdresse_Click(object sender, EventArgs e)
        {
            IDKontoTextBox.Text = lblIDKonto.Text;
        }

        private void btnAdresseZuKontakt_Click(object sender, EventArgs e)
        {
            IDAdresseTextBox.Text = LBL_IDAdresse.Text;
        }

        private void cbFirmenName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_FirmenName.Items.Count != 0)
            {
                TB_FirmenName.Text = CB_FirmenName.Text;
            }
        }

        private void btnNeueAdresse_Click(object sender, EventArgs e)
        {
            // Marker setzen
            AdresseNeu = true;
            lblAdresseNeu.Visible = true;

            // Staatenbox/Ländercode auf Deutschland stellen
            int foundIndex = StaatenBindingSource.Find("Staat", "Deutschland");
            StaatenBindingSource.Position = foundIndex;
            AdresstypTextBox.Text = string.Empty;
            AdresstypTextBox.Select();
            StraßeTextBox.Text = string.Empty;
            PostfachTextBox.Text = string.Empty;
            TB_PLZ.Text = string.Empty;
            CB_Ort.Text = string.Empty;
            CB_Ort.BackColor = Color.MistyRose;
            TB_Bundesland.Text = string.Empty;
            // CB_Staat.Text = "Deutschland"
            UStIdNrTextBox.Text = string.Empty;
            WebseiteTextBox.Text = string.Empty;
            WebseiteLinkLabel.Text = string.Empty;
            IDKontoTextBox.Text = lblIDKonto.Text;
            AdresstypTextBox.Enabled = true;
            StraßeTextBox.Enabled = true;
            PostfachTextBox.Enabled = true;
            TB_PLZ.Enabled = true;
            CB_Ort.Enabled = true;
            TB_Bundesland.Enabled = true;
            CB_Staat.Enabled = true;
            UStIdNrTextBox.Enabled = true;
            WebseiteTextBox.Enabled = true;
        }

        private void TB_PLZ_TextChanged(object sender, EventArgs e)
        {
            int foundIndex;
            switch (CB_Staat.Text ?? "")
            {
                case "Deutschland":
                    {
                        // MsgBox("DE")
                        DE_PLZ_GeodatenTableAdapter.SuchePLZ(_WSL_AdressenDataSet.DE_PLZ_Geodaten, TB_PLZ.Text);
                        CB_Ort.DataSource = DE_PLZ_GeodatenBindingSource;
                        CB_Ort.DisplayMember = "Ort";
                        {
                            var withBlock = TB_Bundesland;
                            withBlock.DataBindings.Clear();
                            withBlock.DataBindings.Add(new Binding("Text", DE_PLZ_GeodatenBindingSource, "Bundesland", true));
                        }

                        foundIndex = DE_PLZ_GeodatenBindingSource.Find("Ort", LBL_Ort.Text);
                        DE_PLZ_GeodatenBindingSource.Position = foundIndex;

                        // MsgBox(CB_Ort.Items.Count)
                        if (CB_Ort.Items.Count == 0)
                        {
                            LBL_PLZungueltig.Visible = true;
                        }
                        else
                        {
                            LBL_PLZungueltig.Visible = false;
                        }

                        break;
                    }

                case "Österreich": // -------------------------------------------------------------------
                    {
                        // MsgBox("DE")
                        AT_PLZ_GeodatenTableAdapter.SuchePLZ(_WSL_AdressenDataSet.AT_PLZ_Geodaten, TB_PLZ.Text);
                        CB_Ort.DataSource = AT_PLZ_GeodatenBindingSource;
                        CB_Ort.DisplayMember = "Ort";
                        {
                            var withBlock1 = TB_Bundesland;
                            withBlock1.DataBindings.Clear();
                            withBlock1.DataBindings.Add(new Binding("Text", AT_PLZ_GeodatenBindingSource, "Bundesland", true));
                        }

                        foundIndex = AT_PLZ_GeodatenBindingSource.Find("Ort", LBL_Ort.Text);
                        AT_PLZ_GeodatenBindingSource.Position = foundIndex;

                        // MsgBox(CB_Ort.Items.Count)
                        if (CB_Ort.Items.Count == 0)
                        {
                            LBL_PLZungueltig.Visible = true;
                        }
                        else
                        {
                            LBL_PLZungueltig.Visible = false;
                        }

                        break;
                    }

                case "Schweiz":  // ------------------------------------------------------------------------------
                    {
                        // MsgBox("DE")
                        CH_PLZ_GeodatenTableAdapter.SuchePLZ(_WSL_AdressenDataSet.CH_PLZ_Geodaten, TB_PLZ.Text);
                        CB_Ort.DataSource = CH_PLZ_GeodatenBindingSource;
                        CB_Ort.DisplayMember = "Ort";
                        {
                            var withBlock2 = TB_Bundesland;
                            withBlock2.DataBindings.Clear();
                            withBlock2.DataBindings.Add(new Binding("Text", CH_PLZ_GeodatenBindingSource, "Bundesland", true));
                        }

                        foundIndex = CH_PLZ_GeodatenBindingSource.Find("Ort", LBL_Ort.Text);
                        CH_PLZ_GeodatenBindingSource.Position = foundIndex;

                        // MsgBox(CB_Ort.Items.Count)
                        if (CB_Ort.Items.Count == 0)
                        {
                            LBL_PLZungueltig.Visible = true;
                        }
                        else
                        {
                            LBL_PLZungueltig.Visible = false;
                        }  // ---------------------------------------------------------------------------------------

                        break;
                    }

                default:
                    {
                        CB_Ort.DataSource = AdressenBindingSource;
                        CB_Ort.DisplayMember = "Ort";
                        {
                            var withBlock3 = TB_Bundesland;
                            withBlock3.DataBindings.Clear();
                            withBlock3.Text = string.Empty;
                        }

                        break;
                    }
            }
        }

        private void btnMapsSuche_Click(object sender, EventArgs e)
        {
            string strasse = LBL_Strasse.Text;
            string ort = LBL_Ort.Text;
            string land = LBL_Land.Text;
            string plz = LBL_PLZ.Text;
            var i = default(int);
     
                var querryAddress = new System.Text.StringBuilder();
                querryAddress.Append("https://www.google.de/maps/place/");
                if ((LBL_Strasse.Text ?? "") != (string.Empty ?? ""))
                {
                    querryAddress.Append(strasse + "," + "+");
                    i = 1;
                }

                if ((LBL_Ort.Text ?? "") != (string.Empty ?? ""))
                {
                    querryAddress.Append(ort + "," + "+");
                    i += 1;
                }

                if ((LBL_Land.Text ?? "") != (string.Empty ?? ""))
                {
                    querryAddress.Append(land + "," + "+");
                    i += 1;
                }

                if ((LBL_PLZ.Text ?? "") != (string.Empty ?? ""))
                {
                    querryAddress.Append(plz);
                    i += 1;
                }

            // MsgBox(querryAddress.ToString)
            if (i > 0)
            {
                Process.Start(querryAddress.ToString());
            }
            else
            {
                Interaction.MsgBox("Fehler bei der Bildung der Suchzeichenfolge für Google (zu wenig Infos)", Constants.vbExclamation);
            }
            
      
        }

        private void TelefonGeschaeftlichLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string LinkString = TelefonGeschaeftlichLinkLabel.Text;
            Process.Start("callto:" + LinkString);
        }

        private void TelefonPrivatLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string LinkString = TelefonPrivatLinkLabel.Text;
            Process.Start("callto:" + LinkString);
        }

        private void MobiltelefonLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string LinkString = MobiltelefonLinkLabel.Text;
            Process.Start("callto:" + LinkString);
        }

        private void WebseiteLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string LinkString = WebseiteLinkLabel.Text;
            try
            {
                Process.Start(LinkString.ToString());
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Öffnen des Links nicht möglich");
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNeuerKontakt_Click(object sender, EventArgs e)
        {
            // Marker setzen
            KontaktNeu = true;
            lblKontaktNeu.Visible = true;
            AnredeComboBox.Text = string.Empty;
            NachnameTextBox.Text = string.Empty;
            NachnameTextBox.BackColor = Color.MistyRose;
            VornameTextBox.Text = string.Empty;
            EmailAddresseTextBox.Text = string.Empty;
            PositionTextBox.Text = string.Empty;
            TelefonGeschaeftlichTextBox.Text = string.Empty;
            TelefonPrivatTextBox.Text = string.Empty;
            MobiltelefonTextBox.Text = string.Empty;
            FaxnummerTextBox.Text = string.Empty;
            WebseiteLinkLabel.Text = string.Empty;
            // Falls noch keine Adresse vorhanden ist:
            var IDAdresse = default(double);
            if ((LBL_IDAdresse.Text ?? "") != (string.Empty ?? ""))
            {
                IDAdresse = Conversion.Val(LBL_IDAdresse.Text);
            }

            IDAdresseTextBox.Text = IDAdresse.ToString();
            AnredeComboBox.Enabled = true;
            NachnameTextBox.Enabled = true;
            VornameTextBox.Enabled = true;
            EmailAddresseTextBox.Enabled = true;
            PositionTextBox.Enabled = true;
            TelefonGeschaeftlichTextBox.Enabled = true;
            TelefonPrivatTextBox.Enabled = true;
            MobiltelefonTextBox.Enabled = true;
            FaxnummerTextBox.Enabled = true;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            AdresseNeu = false;
            lblAdresseNeu.Visible = false;
            TC_Adresse.SelectedIndex = 0;
            AdresseNeu = false;
            CB_Ort.BackColor = Color.White;
            TC_Kontakt.SelectedIndex = 0;
            lblKontaktNeu.Visible = false;
            KontaktNeu = false;
            NachnameTextBox.BackColor = Color.White;
            CB_Ort.DataSource = AdressenBindingSource;
            CB_Ort.DisplayMember = "Ort";

            // Felder auf der Belegseite leeren
            switch (TC_Beleg.SelectedIndex)
            {
                case 0:
                    {
                        TB_BBWeitereBesucher.Text = string.Empty;
                        TB_BBWeitereKontakte.Text = string.Empty;
                        TB_BBThema.Text = string.Empty;
                        TB_BBThema.BackColor = Color.White;
                        break;
                    }

                case 1:
                    {
                        TB_DIVFaxnummer.Text = string.Empty;
                        TB_DIVFaxnummer.BackColor = Color.White;
                        TB_DIVThema.Text = string.Empty;
                        TB_DIVThema.BackColor = Color.White;
                        break;
                    }
            }

            Module1.AlleTableAdapterAktualisieren(System.Convert.ToInt32(LBL_IDFirmenName.Text));
        }

        private void LBL_IDAdresseZuKontakt_TextChanged(object sender, EventArgs e)
        {
            // ID-Zuordnungslabel rot färben, wenn nicht zugeordnet
            if ((LBL_IDAdresseZuKontakt.Text ?? "") == (string.Empty ?? "") & (LBL_IDKontakt.Text ?? "") != (string.Empty ?? "") | LBL_IDAdresseZuKontakt.Text == "0" & (LBL_IDKontakt.Text ?? "") != (string.Empty ?? ""))
            {
                LBL_IDAdresseZuKontakt.Text = "Kontakt hat keine Adresse!";
                LBL_IDAdresseZuKontakt.ForeColor = Color.Red;
            }
            else
            {
                LBL_IDAdresseZuKontakt.ForeColor = Color.Black;
                double IDAdresse = Conversion.Val(LBL_IDAdresseZuKontakt.Text);
                StraßeLabel3.Text = System.Convert.ToString(KontakteMitAdresseTableAdapter.ScalarStrasseInKontakteMitAdresse((int?)IDAdresse));
                OrtLabel3.Text = System.Convert.ToString(KontakteMitAdresseTableAdapter.ScalarOrtInKontakteMitAdresse((int?)IDAdresse));
            }
        }

        private void LBL_IDKontoZuAdresse_TextChanged(object sender, EventArgs e)
        {
            // ID-Zuordnungslabel rot färben, wenn nicht zugeordnet
            if ((LBL_IDKontoZuAdresse.Text ?? "") == (string.Empty ?? "") & (LBL_IDAdresse.Text ?? "") != (string.Empty ?? "") | LBL_IDKontoZuAdresse.Text == "0" & (LBL_IDAdresse.Text ?? "") != (string.Empty ?? ""))
            {
                LBL_IDKontoZuAdresse.Text = "Adresse nicht zugeordnet!";
                LBL_IDKontoZuAdresse.ForeColor = Color.Red;
            }
            else
            {
                LBL_IDKontoZuAdresse.ForeColor = Color.Black;
            }
        }

        private void LBL_IDAdresse_TextChanged(object sender, EventArgs e)
        {
            // Ändert sich der Label-Text, wird geprüft, ob er leer ist, dann:
            int foundIndex;
            if ((LBL_IDAdresse.Text ?? "") == (string.Empty ?? ""))
            {
                AdresstypTextBox.Enabled = false;
                StraßeTextBox.Enabled = false;
                PostfachTextBox.Enabled = false;
                TB_PLZ.Enabled = false;
                CB_Ort.Enabled = false;
                TB_Bundesland.Enabled = false;
                CB_Staat.Enabled = false;
                UStIdNrTextBox.Enabled = false;
                WebseiteTextBox.Enabled = false;
                LBL_AdressHinweis.Visible = false;
                LBL_CC.Visible = false;
                PNL_Geodaten.Visible = false;
                BTN_MapsSuche.Enabled = false;

            }
            else
            {
                AdresstypTextBox.Enabled = true;
                StraßeTextBox.Enabled = true;
                PostfachTextBox.Enabled = true;
                TB_PLZ.Enabled = true;
                CB_Ort.Enabled = true;
                TB_Bundesland.Enabled = true;
                CB_Staat.Enabled = true;
                UStIdNrTextBox.Enabled = true;
                WebseiteTextBox.Enabled = true;
                LBL_PLZungueltig.Visible = false;
                LBL_CC.Visible = true;
                BTN_MapsSuche.Enabled = true;
 

                if ((LBL_Land.Text ?? "") != (string.Empty ?? ""))
                {
                    // MsgBox(LBL_Land.Text)
                    foundIndex = StaatenBindingSource.Find("Staat", LBL_Land.Text);
                    if (foundIndex > -1)
                    {
                        StaatenBindingSource.Position = foundIndex;
                        LabelLandAdressen.ForeColor = Color.Black;
                    }
                    else
                    {
                        LabelLandAdressen.ForeColor = Color.Red;
                    }
                }
                else
                {
                    LabelLandAdressen.ForeColor = Color.Red;
                }


                // Zu jeder Adresse such das System im Falle der DACH-Staaten die Koordinaten und zeigt diese an. Nur dann kann eine Umkreissuche realisiert werden
                DataTable dt;
                switch (LBL_Land.Text ?? "")
                {
                    case "Deutschland":
                        {
                            // MsgBox("Deutschland")
                            // Hier wird zunächst geprüft, ob die Kombi PLZ/Ort in der Datenbank vorhanden ist. Falls nicht, wird ein Hinweis auf eine Fehlerhafte Adresse angezeigt.
                            dt = DE_PLZ_GeodatenTableAdapter.GetDataByPLZundOrt(LBL_PLZ.Text, LBL_Ort.Text);
                            if (dt.Rows.Count == 0)
                            {
                                LBL_AdressHinweis.Visible = true;
                            }
                            else
                            {
                                LBL_AdressHinweis.Visible = false;
                                PNL_Geodaten.Visible = true;
                            }

                            // Ist die Kombi vorhanden, führt die folgende Suche zu einem Treffer und zeigt die Koordinaten an.
                            DE_PLZ_GeodatenTableAdapter.SuchePLZundOrt(_WSL_AdressenDataSet.DE_PLZ_Geodaten, LBL_PLZ.Text, LBL_Ort.Text);
                            {
                                var withBlock = LBL_Lat;
                                withBlock.DataBindings.Clear();
                                withBlock.DataBindings.Add(new Binding("Text", DE_PLZ_GeodatenBindingSource, "latitude", true));
                            }

                            {
                                var withBlock1 = LBL_Long;
                                withBlock1.DataBindings.Clear();
                                withBlock1.DataBindings.Add(new Binding("Text", DE_PLZ_GeodatenBindingSource, "longitude", true));
                            }

                            break;
                        }

                    case "Österreich":
                        {
                            // MsgBox("Österreich")
                            dt = AT_PLZ_GeodatenTableAdapter.GetDataByPLZundOrt(LBL_PLZ.Text, LBL_Ort.Text);
                            if (dt.Rows.Count == 0)
                            {
                                LBL_AdressHinweis.Visible = true;
                            }
                            else
                            {
                                LBL_AdressHinweis.Visible = false;
                                PNL_Geodaten.Visible = true;
                            }

                            AT_PLZ_GeodatenTableAdapter.SuchePLZundOrt(_WSL_AdressenDataSet.AT_PLZ_Geodaten, LBL_PLZ.Text, LBL_Ort.Text);
                            {
                                var withBlock2 = LBL_Lat;
                                withBlock2.DataBindings.Clear();
                                withBlock2.DataBindings.Add(new Binding("Text", AT_PLZ_GeodatenBindingSource, "latitude", true));
                            }

                            {
                                var withBlock3 = LBL_Long;
                                withBlock3.DataBindings.Clear();
                                withBlock3.DataBindings.Add(new Binding("Text", AT_PLZ_GeodatenBindingSource, "longitude", true));
                            }

                            break;
                        }

                    case "Schweiz":
                        {
                            // MsgBox("Schweiz")
                            dt = CH_PLZ_GeodatenTableAdapter.GetDataByPLZundOrt(LBL_PLZ.Text, LBL_Ort.Text);
                            if (dt.Rows.Count == 0)
                            {
                                LBL_AdressHinweis.Visible = true;
                            }
                            else
                            {
                                LBL_AdressHinweis.Visible = false;
                                PNL_Geodaten.Visible = true;
                            }

                            CH_PLZ_GeodatenTableAdapter.SuchePLZundOrt(_WSL_AdressenDataSet.CH_PLZ_Geodaten, LBL_PLZ.Text, LBL_Ort.Text);
                            {
                                var withBlock4 = LBL_Lat;
                                withBlock4.DataBindings.Clear();
                                withBlock4.DataBindings.Add(new Binding("Text", CH_PLZ_GeodatenBindingSource, "latitude", true));
                            }

                            {
                                var withBlock5 = LBL_Long;
                                withBlock5.DataBindings.Clear();
                                withBlock5.DataBindings.Add(new Binding("Text", CH_PLZ_GeodatenBindingSource, "longitude", true));
                            }

                            break;
                        }

                    default:
                        {
                            // MsgBox("Else")
                            LBL_AdressHinweis.Visible = false;
                            PNL_Geodaten.Visible = false;
                            LBL_Lat.Text = string.Empty;
                            LBL_Long.Text = string.Empty;
                            break;
                        }
                }
            }

            // ID-Zuordnungslabel rot färben: Falls es leer ist, das TextänderungsEvent auslösen für das Label:
            if ((LBL_IDKontoZuAdresse.Text ?? "") == (string.Empty ?? "") & (LBL_IDAdresse.Text ?? "") != (string.Empty ?? ""))
            {
                LBL_IDKontoZuAdresse.Text = "-";
            }

            AdresseBauen();
        }

        private void LBL_IDKontakt_TextChanged(object sender, EventArgs e)
        {
            // MsgBox("LBL_IDKontakt.TextChanged")
            My.MyProject.Forms.Form3.LBL_IDKontakt.Text = LBL_IDKontakt.Text;

            // Wenn KEIN Kontakt, dann:
            if ((LBL_IDKontakt.Text ?? "") == (string.Empty ?? ""))
            {
                AnredeComboBox.Enabled = false;
                NachnameTextBox.Enabled = false;
                VornameTextBox.Enabled = false;
                EmailAddresseTextBox.Enabled = false;
                PositionTextBox.Enabled = false;
                TelefonGeschaeftlichTextBox.Enabled = false;
                TelefonPrivatTextBox.Enabled = false;
                MobiltelefonTextBox.Enabled = false;
                FaxnummerTextBox.Enabled = false;
                GB_Anrede.Enabled = false;
                RB_OhneAnrede.Checked = true;
                BTN_ZuOutlook.Enabled = false;
                

            }
            else // Wenn Kontakt, dann
            {
                AnredeComboBox.Enabled = true;
                NachnameTextBox.Enabled = true;
                VornameTextBox.Enabled = true;
                EmailAddresseTextBox.Enabled = true;
                PositionTextBox.Enabled = true;
                TelefonGeschaeftlichTextBox.Enabled = true;
                TelefonPrivatTextBox.Enabled = true;
                MobiltelefonTextBox.Enabled = true;
                FaxnummerTextBox.Enabled = true;
                GB_Anrede.Enabled = true;
                RB_MitAnrede.Checked = true;
                BTN_ZuOutlook.Enabled = true;
                LBL_BBBesuchterKontakt.Text = LBL_Anrede.Text + " " + LBL_Vorname.Text + " " + LBL_Nachname.Text;
            }

            // ID-Zuordnungslabel rot färben: Falls es leer ist, das TextänderungsEvent auslösen für das Label:
            if ((LBL_IDAdresseZuKontakt.Text ?? "") == (string.Empty ?? "") & (LBL_IDKontakt.Text ?? "") != (string.Empty ?? ""))
            {
                LBL_IDAdresseZuKontakt.Text = "-";
            }

            AdresseBauen();
        }

        private void BTN_ZuOutlook_Click(object sender, EventArgs e)
        {
            double IDKontakt = Conversion.Val(LBL_IDKontakt.Text);
            try
            {
                My.MyProject.Forms.Form3.KontakteMitAdresseTableAdapter.SucheAllesVonKontakt(My.MyProject.Forms.Form3._WSL_AdressenDataSet.KontakteMitAdresse, (int)Math.Round(IDKontakt));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            My.MyProject.Forms.Form3.LBL_FirmenName.Text = LBL_FirmenName.Text;
            My.MyProject.Forms.Form3.Show();
        }

        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Administration.Show();
        }

        private void BenutzerlisteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Sachbearbeiter.Show();
        }

        private void CB_Vorlagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wenn eine Vorlage ausgewählt wird, wirtd geschaut, ob die Vorlage ein Sprachkennzeichen enthält:
            string Datei = CB_Vorlagen.Text;
            string Endung8;
            string Endung2;
            Endung8 = Strings.Right(Datei, 8);
            Endung2 = Strings.Mid(Endung8, 1, 3);
            if (Endung2 == "_UK")
            {
                LBL_Sprache.Text = "englisch";
            }
            else
            {
                LBL_Sprache.Text = "deutsch";
            }
        }

        private void RB_OhneAnrede_CheckedChanged(object sender, EventArgs e)
        {
            AdresseBauen();
        }

        private void RB_MitAnrede_CheckedChanged(object sender, EventArgs e)
        {
            AdresseBauen();
        }


        /// <summary>
        /// Erstellt aus den Einzelkomponenten einen ganzen Adress-Strring
        /// </summary>
        public void AdresseBauen()
        {
            if (RB_OhneAnrede.Checked == true)
            {
                LBL_DIVAdresse.Text = LBL_FirmenName.Text + Constants.vbNewLine + LBL_Strasse.Text + Constants.vbNewLine + LBL_PLZ.Text + " " + LBL_Ort.Text + Constants.vbNewLine + LBL_Land.Text;
            }
            else if (RB_MitAnrede.Checked == true)
            {
                LBL_DIVAdresse.Text = LBL_FirmenName.Text + Constants.vbNewLine + LBL_Anrede.Text + " " + LBL_Vorname.Text + " " + LBL_Nachname.Text + Constants.vbNewLine + LBL_Strasse.Text + Constants.vbNewLine + LBL_PLZ.Text + " " + LBL_Ort.Text + Constants.vbNewLine + LBL_Land.Text;
            }
        }

        private void LBL_Anrede_TextChanged(object sender, EventArgs e)
        {
            AdresseBauen();
        }

        private void LBL_Sprache_TextChanged(object sender, EventArgs e)
        {
            if (LBL_Sprache.Text == "englisch")
            {
                {
                    var withBlock = LBL_DIVJobtitle;
                    withBlock.DataBindings.Clear();
                    withBlock.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "EnglJobtitle", true));
                    withBlock.Enabled = true;
                }
            }
            else if (LBL_Sprache.Text == "deutsch")
            {
                {
                    var withBlock1 = LBL_DIVJobtitle;
                    withBlock1.DataBindings.Clear();
                    withBlock1.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Jobtitle", true));
                    withBlock1.Enabled = true;
                }
            }
        }

        private void InfoÜberAdressenDBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.AboutBox1.Show();
        }

        private void DocuWareDateiManuellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.SaveToCSV();
        }

        private void AktivitätslogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Loginformationen.Show();
        }

        private void SchließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_DeleteUser_Click(object sender, EventArgs e)
        {
            int IDKOntakt = System.Convert.ToInt32(LBL_IDKontakt.Text);
            string Nachname = NachnameTextBox.Text;
            if (KontaktNeu != true)
            {
                int intAnswer;
                intAnswer = (int)MessageBox.Show("Ein Kontakt sollte nur dann gelöscht werden," + Constants.vbNewLine + "wenn er das Unternehmen verlassen hat!" + Constants.vbNewLine + Constants.vbNewLine + "Kontakt löschen?", "Kontakt löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (intAnswer)
                {
                    case (int)Constants.vbYes:
                        {
                            try
                            {
                                KontakteTableAdapter.DeleteKontakt(IDKOntakt); // LogTabelle schreiben
                            }
                            catch (Exception)
                            {
                                Interaction.MsgBox("Fehler beim Löschen des Kontakts", Constants.vbExclamation);
                            }

                            KontakteTableAdapter.SucheIDFirmenNameInKontakte(_WSL_AdressenDataSet.Kontakte, Convert.ToInt32(LBL_IDFirmenName.Text));
                            Interaction.MsgBox("Kontakt gelöscht");
                            Module1.Logging(10, IDKOntakt, System.Convert.ToInt32(LBL_IDFirmenName.Text), Nachname);
                            TC_Kontakt.SelectedIndex = 0;
                            break;
                        }

                    case (int)Constants.vbNo:
                        {
                            // exit the procedure
                            return;
                        }
                }
            }
        }

        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string Helplink = System.Convert.ToString(PropertiesTableAdapter.ScalarWert("Hilfelink"));
            Process.Start(Helplink);
        }

        private void BTN_NachnameSuche_Click(object sender, EventArgs e)
        {
            if ((TB_FirmenName.Text ?? "") != (string.Empty ?? ""))
            {
                try
                {
                    My.MyProject.Forms.Personensuche.KontakteMitAdresseTableAdapter.SucheKontakt(My.MyProject.Forms.Personensuche._WSL_AdressenDataSet.KontakteMitAdresse, TB_FirmenName.Text);
                }
                catch (Exception ex)
                {
                    Interaction.MsgBox("Nachname - Fehler bei der Suche");
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Interaction.MsgBox("Bitte einen Suchbegriff eingeben", Constants.vbExclamation);
            }

            My.MyProject.Forms.Personensuche.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Umkreissuche.Show();
        }

        private void BTN_DocErzeugen_Click(object sender, EventArgs e)
        {
            string BelegName;
            IDBeleg = System.Convert.ToInt32(PropertiesTableAdapter.ScalarWert("IDBeleg"));
            int IDKonto;

            // Die TabSeite mit 'Besuchsbericht' wird angezeigt, dann..
            if (TC_Beleg.SelectedIndex == 0)
            {
                if ((TB_BBThema.Text ?? "") == (string.Empty ?? ""))
                {
                    Interaction.MsgBox("Bitte das Thema des Besuchs erfassen!", Constants.vbExclamation, "Neuen BB anlegen");
                    TB_BBThema.Select();
                    TB_BBThema.BackColor = Color.MistyRose;
                    return;
                }


                // Falls die Adresse keine Konto-ID hat, wird die ID aus "Konto" gnommen!
                if ((LBL_BBIDKonto.Text ?? "") != (string.Empty ?? ""))
                {
                    IDKonto = Convert.ToInt32(LBL_BBIDKonto.Text);
                }
                else
                {
                    IDKonto = Convert.ToInt32(lblIDKonto.Text);
                }

                BelegName = "Besuchsbericht.dotx";
                if (Module1.WordStarten(BelegName) == true)
                {
                    // Datensatz Adresse hinzufügen
                    try
                    {
                        BelegeTableAdapter.Insert(IDBeleg,
                                                  Convert.ToInt32(LBL_IDFirmenName.Text),
                                                  LBL_FirmenName.Text,
                                                  DTP_BBDatum.Value,
                                                  Convert.ToInt32(LBL_IDAdresse.Text),
                                                  IDKonto,
                                                  CB_BBKuerzel.Text,
                                                  LBL_BBBesuchterKontakt.Text,
                                                  TB_BBWeitereKontakte.Text,
                                                  TB_BBThema.Text,
                                                  TB_BBWeitereBesucher.Text,
                                                  Environment.UserName,
                                                  BelegName);
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Fehler beim hinzufügen eines neuen Besuchsberichtes");
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        // Nächsten Wert in der Konfig-Tabelle aktualisieren;
                        PropertiesTableAdapter.UpdateWert((++IDBeleg).ToString(), "IDBeleg");
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Fehler beim Update der neuen IDBeleg-Nummer (BB)");
                        MessageBox.Show(ex.Message);
                    }

                    Module1.Logging(8, IDBeleg, Convert.ToInt32(LBL_IDFirmenName.Text), BelegName + " / " + TB_BBThema.Text); // LogTabelle schreiben mit BB!

                    // Aktuellen Satz in Tabelle markieren
                    Module1.IDBBInBesucheMitAdresse(Convert.ToInt32(LBL_IDFirmenName.Text), IDBeleg);
                }
            }



            // Erzeugen eines anderen Beleges: #####################################################################

            if (TC_Beleg.SelectedIndex == 1)
            {
                BelegName = CB_Vorlagen.Text;

                // Falls keine Belege geladen werden konnten, kann auch kein Dokument erzeugt wertden:
                if ((BelegName ?? "") == (string.Empty ?? ""))
                    return;

                // Das Feld Thema soll immer ausgefüllt sein:
                if ((TB_DIVThema.Text ?? "") == (string.Empty ?? ""))
                {
                    Interaction.MsgBox("Bitte einen Betreff erfassen!", Constants.vbExclamation, "kein Betreff");
                    TB_DIVThema.Select();
                    TB_DIVThema.BackColor = Color.MistyRose;
                    return;
                }

                // Falls die FAX-Vorlage gewählt wurde, sollte auch eine FAX-Nummer angegeben werden:
                if (Strings.Mid(CB_Vorlagen.Text, 1, 3) == "Fax" & (TB_DIVFaxnummer.Text ?? "") == (string.Empty ?? ""))
                {
                    Interaction.MsgBox("Bitte eine Fax-Nummererfassen!", Constants.vbExclamation, "Faxnummer fehlt");
                    TB_DIVFaxnummer.Select();
                    TB_DIVFaxnummer.BackColor = Color.MistyRose;
                    return;
                }

                // Falls die Adresse keine Konto-ID hat, wird die ID aus "Konto" gnommen!
                if ((LBL_DIVIDKonto.Text ?? "") != (string.Empty ?? ""))
                {
                    IDKonto = Convert.ToInt32(LBL_DIVIDKonto.Text);
                }
                else
                {
                    IDKonto = Convert.ToInt32(lblIDKonto.Text);
                }

                if (Module1.WordStarten(BelegName) == true)
                {
                    // Datensatz Adresse hinzufügen
                    try
                    {
                        BelegeTableAdapter.Insert(IDBeleg,
                                                  Convert.ToInt32(LBL_IDFirmenName.Text),
                                                  LBL_FirmenName.Text,
                                                  DTP_Diverse.Value,
                                                  Convert.ToInt32(LBL_IDAdresse.Text),
                                                  IDKonto,
                                                  CB_DIVSachbearbeiter.Text,
                                                  LBL_Anrede.Text + " " + LBL_Vorname.Text + " " + LBL_Nachname.Text,
                                                  "",
                                                  TB_DIVThema.Text,
                                                  "",
                                                  Environment.UserName,
                                                  BelegName);
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Fehler beim Speichern des Datensatzes vom Besuchsbericht");
                        MessageBox.Show(ex.Message);
                    }

                    try
                    {
                        // Nächsten Wert in der Konfig-Tabelle aktualisieren
                        PropertiesTableAdapter.UpdateWert((++IDBeleg).ToString(), "IDBeleg");
                    }
                    catch (Exception ex)
                    {
                        Interaction.MsgBox("Fehler beim Update der neuen IDBeleg-Nummer (Div. Belege)");
                        MessageBox.Show(ex.Message);
                    }

                    Module1.Logging(9, IDBeleg, Convert.ToInt32(LBL_IDFirmenName.Text), BelegName + " / " + TB_DIVThema.Text); // LogTabelle schreiben mit BB!
                    TB_DIVThema.BackColor = Color.White;
                    TB_DIVFaxnummer.BackColor = Color.White;

                    // Aktuellen Satz in Tabelle markieren
                    Module1.IDBBInBesucheMitAdresse(Convert.ToInt32(LBL_IDFirmenName.Text), IDBeleg);
                }
            }
        }
    }
}