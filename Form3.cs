using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
//using Outlook = Microsoft.Office.Interop.Outlook;

namespace Adress_DB
{
    public partial class Form3
    {
        public Form3()
        {
            InitializeComponent();
            _BTN_aktualisieren.Name = "BTN_aktualisieren";
            _BTN_olContDelete.Name = "BTN_olContDelete";
            _Button1.Name = "Button1";
            _BTN_hinzufügen.Name = "BTN_hinzufügen";
        }

        

        // declared like Outlook does
        private const long olFolderContacts = 10L;

        // Log errors into this file (File path is App.Path)
        // Private Const errFile As String = "error.log"

        // Switch to turn off the logging functionality
        // Shouldn't be turned off, only unexpected errors were logged
        private const bool doErrorLogging = true;

        public struct Contact
        {
            public string CompanyName;
            public string LastName;
            public string FirstName;
            public string JobTitle;
            public string Email1Address;
            public string BusinessTelephoneNumber;
            public string HomeTelephoneNumber;
            public string MobileTelephoneNumber;
            public string BusinessFaxNumber;
            public string BusinessAddressStreet;
            public string BusinessAddressPostalCode;
            public string BusinessAddressCity;
            public string BusinessAddressState;
            public string BusinessAddressCountry;
            public string BusinessHomePage;
        }

        /*
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.KontakteMitAdresse". Sie können sie bei Bedarf verschieben oder entfernen.
            // Me.KontakteMitAdresseTableAdapter.Fill(Me._WSL_AdressenDataSet.KontakteMitAdresse)

            Initialisierung();
        }

        public bool Initialisierung()
        {
            bool InitialisierungRet = default;
            PNL_GefundenerKontakt.Visible = false;
            LBL_Hinweis.Visible = true;
            int olContID;
            Cursor.Current = Cursors.WaitCursor;
            olContID = findContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text);
            LBL_olContID.Text = olContID.ToString();
            if (olContID != 0)
            {
                InitialisierungRet = true;
                // With getContact(findContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text))
                {
                    var withBlock = getContact(olContID);
                    LBLGEF_FirmenName.Text = withBlock.CompanyName;
                    LBLGEF_Nachname.Text = withBlock.LastName;
                    LBLGEF_Vorname.Text = withBlock.FirstName;
                    LBLGEF_Position.Text = withBlock.JobTitle;
                    LBLGEF_Email.Text = withBlock.Email1Address;
                    LBLGEF_TelefonGesch.Text = withBlock.BusinessTelephoneNumber;
                    LBLGEF_TelefonPriv.Text = withBlock.HomeTelephoneNumber;
                    LBLGEF_Mobiltelefon.Text = withBlock.MobileTelephoneNumber;
                    LBLGEF_Faxnummer.Text = withBlock.BusinessFaxNumber;
                    LBLGEF_Strasse.Text = withBlock.BusinessAddressStreet;
                    LBLGEF_PLZ.Text = withBlock.BusinessAddressPostalCode;
                    LBLGEF_Ort.Text = withBlock.BusinessAddressCity;
                    LBLGEF_Bundesland.Text = withBlock.BusinessAddressState;
                    LBLGEF_Land.Text = withBlock.BusinessAddressCountry;
                    LBLGEF_Website.Text = withBlock.BusinessHomePage;
                }

                PNL_GefundenerKontakt.Visible = true;
                LBL_Hinweis.Visible = false;
            }
            else
            {
                InitialisierungRet = false;
            }

            Cursor.Current = Cursors.Default;
            return InitialisierungRet;
        }

        

        private void BTN_hinzufügen_Click(object sender, EventArgs e)
        {
            if (PNL_GefundenerKontakt.Visible == true)
            {
                DialogResult Result;
                Result = MessageBox.Show("Der Kontakt ist bereits vorhanden. Soll der Kontakt 'zusätzlich' hinzugefügt werden?", "Kontakt hinzufügen", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (Result == DialogResult.Yes)
                {
                }
                // Einfach nichts machen, weiter in der Funktion...
                else if (Result == DialogResult.No)
                {
                    return;
                }
            }

            Contact newContact;
            newContact.CompanyName = LBL_FirmenName.Text;
            newContact.LastName = NachnameLabel1.Text;
            newContact.FirstName = VornameLabel1.Text;
            newContact.JobTitle = PositionLabel1.Text;
            newContact.Email1Address = EmailAddresseLabel1.Text;
            newContact.BusinessTelephoneNumber = TelefonGeschaeftlichLabel1.Text;
            newContact.HomeTelephoneNumber = TelefonPrivatLabel1.Text;
            newContact.MobileTelephoneNumber = MobiltelefonLabel1.Text;
            newContact.BusinessFaxNumber = FaxnummerLabel1.Text;
            newContact.BusinessAddressStreet = StraßeLabel1.Text;
            newContact.BusinessAddressPostalCode = PLZLabel1.Text;
            newContact.BusinessAddressCity = OrtLabel1.Text;
            newContact.BusinessAddressState = BundeslandLabel1.Text;
            newContact.BusinessAddressCountry = LandLabel1.Text;
            newContact.BusinessHomePage = WebseiteLabel1.Text;
            if (addContact(newContact) != 0)
            {
                Interaction.MsgBox("Kontakt erfolgreich hinzugefügt");
                Close();
            }
            else
            {
                Interaction.MsgBox("Hinzufügen des Kontaktes ist fehlgeschlagen");
                Close();
            }
        }

        public bool isOutlookInstalled()
        {
            bool isOutlookInstalledRet = default;
            // Tries to create an instance of Outlook
            // Returnes true if successful, otherwise false

            object olApp;
            

            olApp = Interaction.CreateObject("Outlook.Application");
            isOutlookInstalledRet = true;
            olApp = null;
            return isOutlookInstalledRet;

         
            if (Information.Err().Number == 429)
            {
            }
            // Can't create Object -> Outlook is not installed
            // Don't need to log as error.
            else
            {
                Interaction.MsgBox("Function isOutlookInstalled() returned with error");
            }

            isOutlookInstalledRet = false;
        }

        public int getContactFolderCount()
        {
            int getContactFolderCountRet = default;
            // Returnes the number of contacts in the Outlook contacts folder,
            // returnes zero if Outlook is not installed

            Outlook.Application application = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook._Application olApp = application;

            object olNameSpace = olApp.GetNamespace("MAPI"); ;
            object olFolder = mapiNamespace.GetDefaultFolder(OlDefaultFolders.olFolderContacts);

            if (!isOutlookInstalled())
            {
                getContactFolderCountRet = 0;
            }
            else
            {
                
                //olApp = Interaction.CreateObject("Outlook.Application");
    
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                getContactFolderCountRet = Conversions.ToInteger(olFolder.Items.Count);
                olFolder = null;
                olNameSpace = null;
                olApp = null;
            }

            return getContactFolderCountRet;

            ;
            Interaction.MsgBox("Function getContactFolderCount() returned with error");
            getContactFolderCountRet = 0;
        }

        public Contact getContact(int index)
        {
            Contact getContactRet = default;
            // Returnes the Outlook contact information of the entry,
            // containes only the information which siemens mobile supports.
            // Returnes Nothing if Outlook is not installed or
            // the specified entry doesn't exist.

            object olApp;
            object olNameSpace;
            object olFolder;
            object olContact;
            ;

            if (!isOutlookInstalled())
            {
            }
            // getContact = Nothing
            else if (getContactFolderCount() < index)
            {
            }
            // getContact = Nothing
            else
            {
                olApp = Interaction.CreateObject("Outlook.Application");
                olNameSpace = olApp.GetNamespace("MAPI");
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                olContact = olFolder.Items(index);
                {
                    var withBlock = tmpContact;
                    withBlock.CompanyName = Conversions.ToString(olContact.CompanyName);
                    withBlock.LastName = Conversions.ToString(olContact.LastName);
                    withBlock.FirstName = Conversions.ToString(olContact.FirstName);
                    withBlock.JobTitle = Conversions.ToString(olContact.JobTitle);
                    withBlock.Email1Address = Conversions.ToString(olContact.Email1Address);
                    withBlock.BusinessTelephoneNumber = Conversions.ToString(olContact.BusinessTelephoneNumber);
                    withBlock.HomeTelephoneNumber = Conversions.ToString(olContact.HomeTelephoneNumber);
                    withBlock.MobileTelephoneNumber = Conversions.ToString(olContact.MobileTelephoneNumber);
                    withBlock.BusinessFaxNumber = Conversions.ToString(olContact.BusinessFaxNumber);
                    withBlock.BusinessAddressStreet = Conversions.ToString(olContact.BusinessAddressStreet);
                    withBlock.BusinessAddressPostalCode = Conversions.ToString(olContact.BusinessAddressPostalCode);
                    withBlock.BusinessAddressCity = Conversions.ToString(olContact.BusinessAddressCity);
                    withBlock.BusinessAddressState = Conversions.ToString(olContact.BusinessAddressState);
                    withBlock.BusinessAddressCountry = Conversions.ToString(olContact.BusinessAddressCountry);
                    withBlock.BusinessHomePage = Conversions.ToString(olContact.BusinessHomePage);
                }

                olContact = null;
                olFolder = null;
                olNameSpace = null;
                olApp = null;
                getContactRet = tmpContact;
            }

            return getContactRet;

            ;
            Interaction.MsgBox("Function getContact() returned with error");
            // getContact = Nothing
        }

        public bool modifyContact(int index, Contact modContact)
        {
            bool modifyContactRet = default;
            // Sets the new information to the outlook contact entry
            // with the specified index.
            // Returnes True if successful, 
            // otherwise False (e.G. if entry doesn't exist)

            object olApp;
            object olNameSpace;
            object olFolder;
            object olContact;
            ;

            if (!isOutlookInstalled())
            {
                modifyContactRet = false;
            }
            else if (getContactFolderCount() < index)
            {
                modifyContactRet = false;
            }
            else
            {
                olApp = Interaction.CreateObject("Outlook.Application");
                olNameSpace = olApp.GetNamespace("MAPI");
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                olContact = olFolder.Items(index);
                {
                    var withBlock = olContact;
                    withBlock.CompanyName = modContact.CompanyName;
                    withBlock.LastName = modContact.LastName;
                    withBlock.FirstName = modContact.FirstName;
                    withBlock.JobTitle = modContact.JobTitle;
                    withBlock.Email1Address = modContact.Email1Address;
                    withBlock.BusinessTelephoneNumber = modContact.BusinessTelephoneNumber;
                    withBlock.HomeTelephoneNumber = modContact.HomeTelephoneNumber;
                    withBlock.MobileTelephoneNumber = modContact.MobileTelephoneNumber;
                    withBlock.BusinessFaxNumber = modContact.BusinessFaxNumber;
                    withBlock.BusinessAddressStreet = modContact.BusinessAddressStreet;
                    withBlock.BusinessAddressPostalCode = modContact.BusinessAddressPostalCode;
                    withBlock.BusinessAddressCity = modContact.BusinessAddressCity;
                    withBlock.BusinessAddressState = modContact.BusinessAddressState;
                    withBlock.BusinessAddressCountry = modContact.BusinessAddressCountry;
                    withBlock.BusinessHomePage = modContact.BusinessHomePage;
                    withBlock.Save();
                }

                olContact = null;
                olFolder = null;
                olNameSpace = null;
                olApp = null;
                modifyContactRet = true;
            }

            return modifyContactRet;
        errHandler:
            ;
            Interaction.MsgBox("Function modifyContact() returned with error");
            modifyContactRet = false;
        }

        public int addContact(Contact newContact)
        {
            int addContactRet = default;
            // Adds the new contact to the outlook contact folder
            // Returnes Tthe index of the new entry, Zero if creation failed

            object olApp;
            object olNameSpace;
            object olFolder;
            object olContact;

            if (!isOutlookInstalled())
            {
                addContactRet = 0;
            }
            else
            {
                olApp = Interaction.CreateObject("Outlook.Application");
                olNameSpace = olApp.GetNamespace("MAPI");
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                olContact = olFolder.Items.Add;
                {
                    var withBlock = olContact;
                    withBlock.CompanyName = newContact.CompanyName;
                    withBlock.LastName = newContact.LastName;
                    withBlock.FirstName = newContact.FirstName;
                    withBlock.JobTitle = newContact.JobTitle;
                    withBlock.Email1Address = newContact.Email1Address;
                    withBlock.BusinessTelephoneNumber = newContact.BusinessTelephoneNumber;
                    withBlock.HomeTelephoneNumber = newContact.HomeTelephoneNumber;
                    withBlock.MobileTelephoneNumber = newContact.MobileTelephoneNumber;
                    withBlock.BusinessFaxNumber = newContact.BusinessFaxNumber;
                    withBlock.BusinessAddressStreet = newContact.BusinessAddressStreet;
                    withBlock.BusinessAddressPostalCode = newContact.BusinessAddressPostalCode;
                    withBlock.BusinessAddressCity = newContact.BusinessAddressCity;
                    withBlock.BusinessAddressState = newContact.BusinessAddressState;
                    withBlock.BusinessAddressCountry = newContact.BusinessAddressCountry;
                    withBlock.BusinessHomePage = newContact.BusinessHomePage;
                    withBlock.Save();
                }

                olContact = null;
                olFolder = null;
                olNameSpace = null;
                olApp = null;
                addContactRet = getContactFolderCount();
            }

            return addContactRet;
        errHandler:
            ;
            Interaction.MsgBox("Function addContact() returned with error");
            addContactRet = 0;
        }

        public bool deleteContact(int index)
        {
            bool deleteContactRet = default;
            // Deletes the specified entry from the Outlook contact folder
            // Returnes True if successful, 
            // otherwise False (e.G. if entry doesn't exist)
            // MsgBox("deleteContact aufgerufen")

            object olApp;
            object olNameSpace;
            object olFolder;
            object olContact;

            if (!isOutlookInstalled())
            {
                deleteContactRet = false;
            }
            else if (getContactFolderCount() < index)
            {
                deleteContactRet = false;
            }
            else
            {
                olApp = Interaction.CreateObject("Outlook.Application");
                olNameSpace = olApp.GetNamespace("MAPI");
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                olContact = olFolder.Items(index);
                olContact.Delete();
                olContact = null;
                olFolder = null;
                olNameSpace = null;
                olApp = null;
                deleteContactRet = true;
            }

            return deleteContactRet;
        errHandler:
            ;
            Interaction.MsgBox("Function deleteContact() returned with error");
            deleteContactRet = false;
        }

        public int findContact(string FirmenName, string LastName, string FirstName = Constants.vbNullString)
        {
            int findContactRet = default;
            // Searches for specified entry in the Outlook contact folder
            // Returnes the index if found, otherwise Zero

            object olApp;
            object olNameSpace;
            object olFolder; // Object
            object olContact; // Object
            int i;

            if (!isOutlookInstalled())
            {
                findContactRet = 0;
            }
            else
            {
                olApp = Interaction.CreateObject("Outlook.Application");
                olNameSpace = olApp.GetNamespace("MAPI");
                olFolder = olNameSpace.GetDefaultFolder((object)olFolderContacts);
                findContactRet = 0;
                var loopTo = Conversions.ToInteger(olFolder.Items.Count);
                for (i = 1; i <= loopTo; i++)
                {
                    // MsgBox(olFolder.Items.Count)
                    olContact = olFolder.Items(i);
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.ConditionalCompareObjectEqual(LCase(olContact.LastName), Strings.LCase(LastName), false), Operators.ConditionalCompareObjectEqual(LCase(olContact.CompanyName), Strings.LCase(FirmenName), false))))
                    {
                        if (string.IsNullOrEmpty(FirstName))
                        {
                            findContactRet = i;
                            break;
                        }
                        else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(olContact.FirstName, FirstName, false)))
                        {
                            findContactRet = i;
                            break;
                        }
                    }
                }

                olContact = null;
                olFolder = null;
                olNameSpace = null;
                olApp = null;
            }

            // MsgBox("Kontakt-Nummer: " & findContact)
            return findContactRet;
        errHandler:
            ;
            Interaction.MsgBox("Function findContact() returned with error");
            findContactRet = 0;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_aktualisieren_Click(object sender, EventArgs e)
        {
            Contact modContact;
            int Index;
            Index = (int)Math.Round(Conversion.Val(LBL_olContID.Text));
            modContact.CompanyName = LBL_FirmenName.Text;
            modContact.LastName = NachnameLabel1.Text;
            // --------
            if ((VornameLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.FirstName = VornameLabel1.Text;
            }
            else
            {
                modContact.FirstName = LBLGEF_Vorname.Text;
            }
            // --------
            if ((PositionLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.JobTitle = PositionLabel1.Text;
            }
            else
            {
                modContact.JobTitle = LBLGEF_Position.Text;
            }
            // --------
            if ((EmailAddresseLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.Email1Address = EmailAddresseLabel1.Text;
            }
            else
            {
                modContact.Email1Address = LBLGEF_Email.Text;
            }
            // --------
            if ((TelefonGeschaeftlichLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessTelephoneNumber = TelefonGeschaeftlichLabel1.Text;
            }
            else
            {
                modContact.BusinessTelephoneNumber = LBLGEF_TelefonGesch.Text;
            }
            // --------
            if ((TelefonPrivatLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.HomeTelephoneNumber = TelefonPrivatLabel1.Text;
            }
            else
            {
                modContact.HomeTelephoneNumber = LBLGEF_TelefonPriv.Text;
            }
            // --------
            if ((MobiltelefonLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.MobileTelephoneNumber = MobiltelefonLabel1.Text;
            }
            else
            {
                modContact.MobileTelephoneNumber = LBLGEF_Mobiltelefon.Text;
            }
            // --------
            if ((FaxnummerLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessFaxNumber = FaxnummerLabel1.Text;
            }
            else
            {
                modContact.BusinessFaxNumber = LBLGEF_Faxnummer.Text;
            }
            // --------
            if ((StraßeLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessAddressStreet = StraßeLabel1.Text;
            }
            else
            {
                modContact.BusinessAddressStreet = LBLGEF_Strasse.Text;
            }
            // --------
            if ((PLZLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessAddressPostalCode = PLZLabel1.Text;
            }
            else
            {
                modContact.BusinessAddressPostalCode = LBLGEF_PLZ.Text;
            }
            // --------
            if ((OrtLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessAddressCity = OrtLabel1.Text;
            }
            else
            {
                modContact.BusinessAddressCity = LBLGEF_Ort.Text;
            }
            // --------
            if ((BundeslandLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessAddressState = BundeslandLabel1.Text;
            }
            else
            {
                modContact.BusinessAddressState = LBLGEF_Bundesland.Text;
            }
            // --------
            if ((LandLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessAddressCountry = LandLabel1.Text;
            }
            else
            {
                modContact.BusinessAddressCountry = LBLGEF_Land.Text;
            }
            // --------
            if ((WebseiteLabel1.Text ?? "") != (string.Empty ?? ""))
            {
                modContact.BusinessHomePage = WebseiteLabel1.Text;
            }
            else
            {
                modContact.BusinessHomePage = LBLGEF_Website.Text;
            }

            if (modifyContact(Index, modContact) == true)
            {
                Interaction.MsgBox("Kontakt erfolgreich geändert");
                Hide();
            }
            else
            {
                Interaction.MsgBox("ändern des Kontaktes ist fehlgeschlagen");
                Hide();
            }
        }

        private void BTN_olContDelete_Click(object sender, EventArgs e)
        {
            int olContID;
            olContID = (int)Math.Round(Conversion.Val(LBL_olContID.Text));
            DialogResult Result;
            Result = MessageBox.Show("Soll der Kontakt '" + LBLGEF_Nachname.Text + "', Kontaktnummer:" + olContID + " wirklich im Outlook gelöscht werden!", "Kontakt löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes)
            {
                if (deleteContact(olContID) == true)
                {
                    Interaction.MsgBox("gelöscht!");
                    Initialisierung();
                    // Me.Close()
                }
            }
            else if (Result == DialogResult.No)
            {
                // exit the procedure
                return;
            }
        }*/
    } 
}