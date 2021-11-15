using System;
using System.Drawing;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

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
        //private const bool doErrorLogging = true;

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


        private void Form3_Load(object sender, EventArgs e)
        {

            LBL_Hinweis.Location = new Point(70, 80);
            LBL_Hinweis.Visible = false;

           Initialisierung();
        }


        public void Initialisierung()
        {
            
            PNL_GefundenerKontakt.Visible = false;
            LBL_Hinweis.Visible = true;
            int olContID;
            Cursor.Current = Cursors.WaitCursor;
            olContID = FindContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text);
            LBL_olContID.Text = olContID.ToString();

            //MessageBox.Show(LBL_olContID.Text);

            if (olContID != 0)
            {
                
                // With getContact(findContact(LBL_FirmenName.Text, NachnameLabel1.Text, VornameLabel1.Text)) !
                {
                    var getCont = GetContact(olContID);
                    LBLGEF_FirmenName.Text = getCont.CompanyName;
                    LBLGEF_Nachname.Text = getCont.LastName;
                    LBLGEF_Vorname.Text = getCont.FirstName;
                    LBLGEF_Position.Text = getCont.JobTitle;
                    LBLGEF_Email.Text = getCont.Email1Address;
                    LBLGEF_TelefonGesch.Text = getCont.BusinessTelephoneNumber;
                    LBLGEF_TelefonPriv.Text = getCont.HomeTelephoneNumber;
                    LBLGEF_Mobiltelefon.Text = getCont.MobileTelephoneNumber;
                    LBLGEF_Faxnummer.Text = getCont.BusinessFaxNumber;
                    LBLGEF_Strasse.Text = getCont.BusinessAddressStreet;
                    LBLGEF_PLZ.Text = getCont.BusinessAddressPostalCode;
                    LBLGEF_Ort.Text = getCont.BusinessAddressCity;
                    LBLGEF_Bundesland.Text = getCont.BusinessAddressState;
                    LBLGEF_Land.Text = getCont.BusinessAddressCountry;
                    LBLGEF_Website.Text = getCont.BusinessHomePage;
                }

                PNL_GefundenerKontakt.Visible = true;
                LBL_Hinweis.Visible = false;
            }

            Cursor.Current = Cursors.Default;
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
            if (AddContact(newContact) != 0)
            {
                MessageBox.Show("Kontakt erfolgreich hinzugefügt");
                Close();
            }
            else
            {
                MessageBox.Show("Hinzufügen des Kontaktes ist fehlgeschlagen");
                Close();
            }
        }

        public bool IsOutlookInstalled()
        {
            // Tries to create an instance of Outlook
            // Returnes true if successful, otherwise false

            bool isOutlookInstalledRet;

            try
            {
                Outlook.Application olApp = new Outlook.Application();
                isOutlookInstalledRet = true;
                olApp = null;
            }
            catch
            {
                MessageBox.Show("Function isOutlookInstalled() returned with error");
                isOutlookInstalledRet = false;
            }

            //MessageBox.Show(Convert.ToString(isOutlookInstalledRet));
            return isOutlookInstalledRet;
            
        }

        public int GetContactFolderCount()
        {
            int getContactFolderCountRet = 0;
            // Returnes the number of contacts in the Outlook contacts folder,
            // returnes zero if Outlook is not installed

            Outlook.Application olApp = new Outlook.Application();

            if (!IsOutlookInstalled())
            {
                getContactFolderCountRet = 0;
            }
            else
            {
                try
                {
                    Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
                    Outlook.MAPIFolder olFolder = olNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
                    //Outlook.Items ContactItems = olFolder.Items;

                    getContactFolderCountRet = Convert.ToInt32(olFolder.Items.Count);
                    olFolder = null;
                    olNameSpace = null;
                    olApp = null;
                }
                catch
                {
                    MessageBox.Show("Funktion GetContactFolderCount() erzeugt einen Fehler", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    getContactFolderCountRet = 0;                  
                }
            }    
            return getContactFolderCountRet;
        }

        public Contact GetContact(int index)
        {
            Contact getContactRet = default;
            // Returnes the Outlook contact information of the entry,
            // containes only the information which siemens mobile supports.
            // Returnes Nothing if Outlook is not installed or
            // the specified entry doesn't exist.           

            if (!IsOutlookInstalled())
            {
                getContactRet = default;
            }
            // getContact = Nothing
            else if (GetContactFolderCount() < index)
            {
                getContactRet = default;
            }
        
            else
            {
                try
                { 
                    Outlook.Application olApp = new Outlook.Application();
                    Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
                    Outlook.MAPIFolder olFolder = olNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
                    Outlook.Items olItems = olFolder.Items;
                    Outlook.ContactItem olContact = (Outlook.ContactItem)olItems[index];

                    Contact tmpContact;
                    
                    tmpContact.CompanyName = Convert.ToString(olContact.CompanyName);
                    tmpContact.LastName = Convert.ToString(olContact.LastName);
                    tmpContact.FirstName = Convert.ToString(olContact.FirstName);
                    tmpContact.JobTitle = Convert.ToString(olContact.JobTitle);
                    tmpContact.Email1Address = Convert.ToString(olContact.Email1Address);
                    tmpContact.BusinessTelephoneNumber = Convert.ToString(olContact.BusinessTelephoneNumber);
                    tmpContact.HomeTelephoneNumber = Convert.ToString(olContact.HomeTelephoneNumber);
                    tmpContact.MobileTelephoneNumber = Convert.ToString(olContact.MobileTelephoneNumber);
                    tmpContact.BusinessFaxNumber = Convert.ToString(olContact.BusinessFaxNumber);
                    tmpContact.BusinessAddressStreet = Convert.ToString(olContact.BusinessAddressStreet);
                    tmpContact.BusinessAddressPostalCode = Convert.ToString(olContact.BusinessAddressPostalCode);
                    tmpContact.BusinessAddressCity = Convert.ToString(olContact.BusinessAddressCity);
                    tmpContact.BusinessAddressState = Convert.ToString(olContact.BusinessAddressState);
                    tmpContact.BusinessAddressCountry = Convert.ToString(olContact.BusinessAddressCountry);
                    tmpContact.BusinessHomePage = Convert.ToString(olContact.BusinessHomePage);

                    olContact = null;
                    olFolder = null;
                    olNameSpace = null;
                    olApp = null;
                    getContactRet = tmpContact;
                }
                catch
                {
                    MessageBox.Show("Funktion getContact() erzeugt einen Fehler", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    getContactRet = default;
                }
            }
            return getContactRet;
        }

        public bool ModifyContact(int index, Contact modContact)
        {
            bool modifyContactRet = default;
            // Sets the new information to the outlook contact entry
            // with the specified index.
            // Returnes True if successful, 
            // otherwise False (e.G. if entry doesn't exist)


            if (!IsOutlookInstalled())
            {
                modifyContactRet = false;
            }
            else if (GetContactFolderCount() < index)
            {
                modifyContactRet = false;
            }
            else
            {
                try
                {
                    Outlook.Application olApp = new Outlook.Application();
                    Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
                    Outlook.MAPIFolder olFolder = olNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
                    Outlook.Items olItems = olFolder.Items;
                    Outlook.ContactItem olContact = (Outlook.ContactItem)olItems[index];


                    var modCont = olContact;
                    modCont.CompanyName = modContact.CompanyName;
                    modCont.LastName = modContact.LastName;
                    modCont.FirstName = modContact.FirstName;
                    modCont.JobTitle = modContact.JobTitle;
                    modCont.Email1Address = modContact.Email1Address;
                    modCont.BusinessTelephoneNumber = modContact.BusinessTelephoneNumber;
                    modCont.HomeTelephoneNumber = modContact.HomeTelephoneNumber;
                    modCont.MobileTelephoneNumber = modContact.MobileTelephoneNumber;
                    modCont.BusinessFaxNumber = modContact.BusinessFaxNumber;
                    modCont.BusinessAddressStreet = modContact.BusinessAddressStreet;
                    modCont.BusinessAddressPostalCode = modContact.BusinessAddressPostalCode;
                    modCont.BusinessAddressCity = modContact.BusinessAddressCity;
                    modCont.BusinessAddressState = modContact.BusinessAddressState;
                    modCont.BusinessAddressCountry = modContact.BusinessAddressCountry;
                    modCont.BusinessHomePage = modContact.BusinessHomePage;
                    modCont.Save();

                    olContact = null;
                    olFolder = null;
                    olNameSpace = null;
                    olApp = null;
                    modifyContactRet = true;

                }
                catch
                {
                    MessageBox.Show("Function modifyContact() returned with error");
                    modifyContactRet = false;
                }
            }

            return modifyContactRet;

        }

        public int AddContact(Contact newContact)
        {
            int addContactRet = default;
            // Adds the new contact to the outlook contact folder
            // Returnes Tthe index of the new entry, Zero if creation failed

            if (!IsOutlookInstalled())
            {
                addContactRet = 0;
            }
            else
            {
                try 
                { 
                    Outlook.Application olApp = new Outlook.Application();
                    Outlook.ContactItem olContact = olApp.CreateItem(Outlook.OlItemType.olContactItem);

                    var addCont = olContact;
                    addCont.CompanyName = newContact.CompanyName;
                    addCont.LastName = newContact.LastName;
                    addCont.FirstName = newContact.FirstName;
                    addCont.JobTitle = newContact.JobTitle;
                    addCont.Email1Address = newContact.Email1Address;
                    addCont.BusinessTelephoneNumber = newContact.BusinessTelephoneNumber;
                    addCont.HomeTelephoneNumber = newContact.HomeTelephoneNumber;
                    addCont.MobileTelephoneNumber = newContact.MobileTelephoneNumber;
                    addCont.BusinessFaxNumber = newContact.BusinessFaxNumber;
                    addCont.BusinessAddressStreet = newContact.BusinessAddressStreet;
                    addCont.BusinessAddressPostalCode = newContact.BusinessAddressPostalCode;
                    addCont.BusinessAddressCity = newContact.BusinessAddressCity;
                    addCont.BusinessAddressState = newContact.BusinessAddressState;
                    addCont.BusinessAddressCountry = newContact.BusinessAddressCountry;
                    addCont.BusinessHomePage = newContact.BusinessHomePage;
                    addCont.Save();

                    olContact = null;
                    olApp = null;
                    addContactRet = GetContactFolderCount();
                }
                catch
                {
                MessageBox.Show("Function addContact() returned with error");
                addContactRet = 0;
                }
            }
            return addContactRet;
        }

        public bool DeleteContact(int index)
        {
            bool deleteContactRet = default;
            // Deletes the specified entry from the Outlook contact folder
            // Returnes True if successful, 
            // otherwise False (e.G. if entry doesn't exist)
            // MsgBox("deleteContact aufgerufen")

            if (!IsOutlookInstalled())
            {
                deleteContactRet = false;
            }
            else if (GetContactFolderCount() < index)
            {
                deleteContactRet = false;
            }
            else
            {
                try
                {
                    Outlook.Application olApp = new Outlook.Application();
                    Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
                    Outlook.MAPIFolder olFolder = olNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
                    Outlook.Items olItems = olFolder.Items;
                    Outlook.ContactItem olContact = (Outlook.ContactItem)olItems[index];
                    olContact.Delete();
                    olContact = null;
                    olFolder = null;
                    olNameSpace = null;
                    olApp = null;
                    deleteContactRet = true;
                }
                catch
                {
                    MessageBox.Show("Function deleteContact() returned with error");
                    deleteContactRet = false;
                }
            }
            return deleteContactRet;
        }

        public int FindContact(string FirmenName, string LastName, string FirstName = null)
        {
            int findContactRet = default;
            // Searches for specified entry in the Outlook contact folder
            // Returnes the index if found, otherwise Zero

            if (!IsOutlookInstalled())
            {
                findContactRet = 0;
            }
            else
            {
                try
                {
                    Outlook.Application olApp = new Outlook.Application();
                    Outlook.NameSpace olNameSpace = olApp.GetNamespace("MAPI");
                    Outlook.MAPIFolder olFolder = olNameSpace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderContacts);
                    Outlook.Items olItems = olFolder.Items;

                    var loopTo = Convert.ToInt32(olFolder.Items.Count);
                    int i;

                    for (i = 1; i <= loopTo; i++)
                    {
                        Outlook.ContactItem olContact = (Outlook.ContactItem)olItems[i];
                        //MessageBox.Show(olContact.LastName);

                        if (olContact.CompanyName != null && olContact.LastName != null)
                        {
                            if (olContact.CompanyName.ToLower() == FirmenName.ToLower() && olContact.LastName.ToLower() == LastName.ToLower())
                            {
                                if (string.IsNullOrEmpty(FirstName))
                                {
                                    findContactRet = i;
                                    break;
                                }
                                else if (olContact.FirstName.ToLower() == FirstName.ToLower())
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

                }
                catch 
                {
                    MessageBox.Show("Function findContact() returned with error");
                    findContactRet = 0;
                    
                }

            }
            return findContactRet;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_aktualisieren_Click(object sender, EventArgs e)
        {
            Contact modContact;
            int Index;
            Index = Convert.ToInt32(LBL_olContID.Text);
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

            if (ModifyContact(Index, modContact) == true)
            {
                MessageBox.Show("Kontakt erfolgreich geändert");
                Hide();
            }
            else
            {
                MessageBox.Show("ändern des Kontaktes ist fehlgeschlagen");
                Hide();
            }
        }

        private void BTN_olContDelete_Click(object sender, EventArgs e)
        {
            int olContID;
            olContID = Convert.ToInt32(LBL_olContID.Text);
            DialogResult Result;
            Result = MessageBox.Show("Soll der Kontakt '" + LBLGEF_Nachname.Text + "', Kontaktnummer:" + olContID + " wirklich im Outlook gelöscht werden!", "Kontakt löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result == DialogResult.Yes)
            {
                if (DeleteContact(olContID) == true)
                {
                    MessageBox.Show("gelöscht!");
                    Initialisierung();
                    // Me.Close()
                }
            }
            else if (Result == DialogResult.No)
            {
                // exit the procedure
                return;
            }
        }

   } 
}