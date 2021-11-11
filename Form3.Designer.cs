using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    [DesignerGenerated()]
    public partial class Form3 : Form
    {

        // Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Label FirmenNameLabel;
            Label NachnameLabel;
            Label VornameLabel;
            Label PositionLabel;
            Label TelefonGeschaeftlichLabel;
            Label TelefonPrivatLabel;
            Label MobiltelefonLabel;
            Label FaxnummerLabel;
            Label EmailAddresseLabel;
            Label StraßeLabel;
            Label PLZLabel;
            Label OrtLabel;
            Label BundeslandLabel;
            Label LandLabel;
            Label WebseiteLabel;
            Label Label4;
            Label Label5;
            Label Label6;
            Label Label7;
            Label Label8;
            Label Label9;
            Label Label10;
            Label Label11;
            Label Label12;
            Label Label13;
            Label Label14;
            Label Label15;
            Label Label16;
            Label Label17;
            Label Label24;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            Panel1 = new Panel();
            PictureBox1 = new PictureBox();
            LBL_IDKontakt = new Label();
            Label3 = new Label();
            KontakteMitAdresseBindingSource = new BindingSource(components);
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            KontakteMitAdresseTableAdapter = new _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter();
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            LBL_FirmenName = new Label();
            NachnameLabel1 = new Label();
            VornameLabel1 = new Label();
            PositionLabel1 = new Label();
            TelefonGeschaeftlichLabel1 = new Label();
            TelefonPrivatLabel1 = new Label();
            MobiltelefonLabel1 = new Label();
            FaxnummerLabel1 = new Label();
            EmailAddresseLabel1 = new Label();
            StraßeLabel1 = new Label();
            PLZLabel1 = new Label();
            OrtLabel1 = new Label();
            BundeslandLabel1 = new Label();
            LandLabel1 = new Label();
            WebseiteLabel1 = new Label();
            _BTN_aktualisieren = new Button();
  //          _BTN_aktualisieren.Click += new EventHandler(BTN_aktualisieren_Click);
            LBLGEF_FirmenName = new Label();
            LBLGEF_Nachname = new Label();
            LBLGEF_Vorname = new Label();
            LBLGEF_Position = new Label();
            LBLGEF_Email = new Label();
            LBLGEF_TelefonGesch = new Label();
            LBLGEF_TelefonPriv = new Label();
            LBLGEF_Mobiltelefon = new Label();
            LBLGEF_Faxnummer = new Label();
            LBLGEF_Strasse = new Label();
            LBLGEF_PLZ = new Label();
            LBLGEF_Ort = new Label();
            LBLGEF_Bundesland = new Label();
            LBLGEF_Land = new Label();
            LBLGEF_Website = new Label();
            PNL_GefundenerKontakt = new Panel();
            _BTN_olContDelete = new Button();
  //          _BTN_olContDelete.Click += new EventHandler(BTN_olContDelete_Click);
            Panel3 = new Panel();
            LBL_olContID = new Label();
            Label18 = new Label();
            Panel4 = new Panel();
            Panel6 = new Panel();
            Label1 = new Label();
            Panel5 = new Panel();
            _Button1 = new Button();
  //          _Button1.Click += new EventHandler(Button1_Click_1);
            _BTN_hinzufügen = new Button();
  //          _BTN_hinzufügen.Click += new EventHandler(BTN_hinzufügen_Click);
            LBL_Hinweis = new Label();
            FirmenNameLabel = new Label();
            NachnameLabel = new Label();
            VornameLabel = new Label();
            PositionLabel = new Label();
            TelefonGeschaeftlichLabel = new Label();
            TelefonPrivatLabel = new Label();
            MobiltelefonLabel = new Label();
            FaxnummerLabel = new Label();
            EmailAddresseLabel = new Label();
            StraßeLabel = new Label();
            PLZLabel = new Label();
            OrtLabel = new Label();
            BundeslandLabel = new Label();
            LandLabel = new Label();
            WebseiteLabel = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            Label7 = new Label();
            Label8 = new Label();
            Label9 = new Label();
            Label10 = new Label();
            Label11 = new Label();
            Label12 = new Label();
            Label13 = new Label();
            Label14 = new Label();
            Label15 = new Label();
            Label16 = new Label();
            Label17 = new Label();
            Label24 = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            PNL_GefundenerKontakt.SuspendLayout();
            Panel3.SuspendLayout();
            Panel4.SuspendLayout();
            Panel6.SuspendLayout();
            Panel5.SuspendLayout();
            SuspendLayout();
            // 
            // FirmenNameLabel
            // 
            FirmenNameLabel.AutoSize = true;
            FirmenNameLabel.Location = new Point(28, 35);
            FirmenNameLabel.Name = "FirmenNameLabel";
            FirmenNameLabel.Size = new Size(72, 13);
            FirmenNameLabel.TabIndex = 17;
            FirmenNameLabel.Text = "Firmen Name:";
            // 
            // NachnameLabel
            // 
            NachnameLabel.AutoSize = true;
            NachnameLabel.Location = new Point(38, 49);
            NachnameLabel.Name = "NachnameLabel";
            NachnameLabel.Size = new Size(62, 13);
            NachnameLabel.TabIndex = 18;
            NachnameLabel.Text = "Nachname:";
            // 
            // VornameLabel
            // 
            VornameLabel.AutoSize = true;
            VornameLabel.Location = new Point(48, 63);
            VornameLabel.Name = "VornameLabel";
            VornameLabel.Size = new Size(52, 13);
            VornameLabel.TabIndex = 19;
            VornameLabel.Text = "Vorname:";
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new Point(53, 76);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new Size(47, 13);
            PositionLabel.TabIndex = 20;
            PositionLabel.Text = "Position:";
            // 
            // TelefonGeschaeftlichLabel
            // 
            TelefonGeschaeftlichLabel.AutoSize = true;
            TelefonGeschaeftlichLabel.Location = new Point(13, 104);
            TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel";
            TelefonGeschaeftlichLabel.Size = new Size(84, 13);
            TelefonGeschaeftlichLabel.TabIndex = 21;
            TelefonGeschaeftlichLabel.Text = "Telefon (gesch):";
            // 
            // TelefonPrivatLabel
            // 
            TelefonPrivatLabel.AutoSize = true;
            TelefonPrivatLabel.Location = new Point(17, 118);
            TelefonPrivatLabel.Name = "TelefonPrivatLabel";
            TelefonPrivatLabel.Size = new Size(81, 13);
            TelefonPrivatLabel.TabIndex = 22;
            TelefonPrivatLabel.Text = "Telefon (privat):";
            // 
            // MobiltelefonLabel
            // 
            MobiltelefonLabel.AutoSize = true;
            MobiltelefonLabel.Location = new Point(30, 132);
            MobiltelefonLabel.Name = "MobiltelefonLabel";
            MobiltelefonLabel.Size = new Size(67, 13);
            MobiltelefonLabel.TabIndex = 23;
            MobiltelefonLabel.Text = "Mobiltelefon:";
            // 
            // FaxnummerLabel
            // 
            FaxnummerLabel.AutoSize = true;
            FaxnummerLabel.Location = new Point(33, 146);
            FaxnummerLabel.Name = "FaxnummerLabel";
            FaxnummerLabel.Size = new Size(64, 13);
            FaxnummerLabel.TabIndex = 24;
            FaxnummerLabel.Text = "Faxnummer:";
            // 
            // EmailAddresseLabel
            // 
            EmailAddresseLabel.AutoSize = true;
            EmailAddresseLabel.Location = new Point(18, 89);
            EmailAddresseLabel.Name = "EmailAddresseLabel";
            EmailAddresseLabel.Size = new Size(82, 13);
            EmailAddresseLabel.TabIndex = 25;
            EmailAddresseLabel.Text = "Email Addresse:";
            // 
            // StraßeLabel
            // 
            StraßeLabel.AutoSize = true;
            StraßeLabel.Location = new Point(56, 170);
            StraßeLabel.Name = "StraßeLabel";
            StraßeLabel.Size = new Size(41, 13);
            StraßeLabel.TabIndex = 26;
            StraßeLabel.Text = "Straße:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new Point(67, 184);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new Size(30, 13);
            PLZLabel.TabIndex = 28;
            PLZLabel.Text = "PLZ:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new Point(73, 198);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new Size(24, 13);
            OrtLabel.TabIndex = 30;
            OrtLabel.Text = "Ort:";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new Point(31, 212);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new Size(66, 13);
            BundeslandLabel.TabIndex = 32;
            BundeslandLabel.Text = "Bundesland:";
            // 
            // LandLabel
            // 
            LandLabel.AutoSize = true;
            LandLabel.Location = new Point(63, 226);
            LandLabel.Name = "LandLabel";
            LandLabel.Size = new Size(34, 13);
            LandLabel.TabIndex = 34;
            LandLabel.Text = "Land:";
            // 
            // WebseiteLabel
            // 
            WebseiteLabel.AutoSize = true;
            WebseiteLabel.Location = new Point(42, 240);
            WebseiteLabel.Name = "WebseiteLabel";
            WebseiteLabel.Size = new Size(55, 13);
            WebseiteLabel.TabIndex = 36;
            WebseiteLabel.Text = "Webseite:";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(33, 235);
            Label4.Name = "Label4";
            Label4.Size = new Size(55, 13);
            Label4.TabIndex = 50;
            Label4.Text = "Webseite:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(55, 222);
            Label5.Name = "Label5";
            Label5.Size = new Size(34, 13);
            Label5.TabIndex = 49;
            Label5.Text = "Land:";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(22, 209);
            Label6.Name = "Label6";
            Label6.Size = new Size(66, 13);
            Label6.TabIndex = 48;
            Label6.Text = "Bundesland:";
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Location = new Point(58, 183);
            Label7.Name = "Label7";
            Label7.Size = new Size(30, 13);
            Label7.TabIndex = 47;
            Label7.Text = "PLZ:";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(47, 170);
            Label8.Name = "Label8";
            Label8.Size = new Size(41, 13);
            Label8.TabIndex = 46;
            Label8.Text = "Straße:";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Location = new Point(7, 91);
            Label9.Name = "Label9";
            Label9.Size = new Size(82, 13);
            Label9.TabIndex = 45;
            Label9.Text = "Email Addresse:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Location = new Point(24, 147);
            Label10.Name = "Label10";
            Label10.Size = new Size(64, 13);
            Label10.TabIndex = 44;
            Label10.Text = "Faxnummer:";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Location = new Point(22, 133);
            Label11.Name = "Label11";
            Label11.Size = new Size(67, 13);
            Label11.TabIndex = 43;
            Label11.Text = "Mobiltelefon:";
            // 
            // Label12
            // 
            Label12.AutoSize = true;
            Label12.Location = new Point(8, 119);
            Label12.Name = "Label12";
            Label12.Size = new Size(81, 13);
            Label12.TabIndex = 42;
            Label12.Text = "Telefon (privat):";
            // 
            // Label13
            // 
            Label13.AutoSize = true;
            Label13.Location = new Point(5, 105);
            Label13.Name = "Label13";
            Label13.Size = new Size(84, 13);
            Label13.TabIndex = 41;
            Label13.Text = "Telefon (gesch):";
            // 
            // Label14
            // 
            Label14.AutoSize = true;
            Label14.Location = new Point(41, 77);
            Label14.Name = "Label14";
            Label14.Size = new Size(47, 13);
            Label14.TabIndex = 40;
            Label14.Text = "Position:";
            // 
            // Label15
            // 
            Label15.AutoSize = true;
            Label15.Location = new Point(36, 63);
            Label15.Name = "Label15";
            Label15.Size = new Size(52, 13);
            Label15.TabIndex = 39;
            Label15.Text = "Vorname:";
            // 
            // Label16
            // 
            Label16.AutoSize = true;
            Label16.Location = new Point(27, 49);
            Label16.Name = "Label16";
            Label16.Size = new Size(62, 13);
            Label16.TabIndex = 38;
            Label16.Text = "Nachname:";
            // 
            // Label17
            // 
            Label17.AutoSize = true;
            Label17.Location = new Point(17, 35);
            Label17.Name = "Label17";
            Label17.Size = new Size(72, 13);
            Label17.TabIndex = 37;
            Label17.Text = "Firmen Name:";
            // 
            // Label24
            // 
            Label24.AutoSize = true;
            Label24.Location = new Point(64, 196);
            Label24.Name = "Label24";
            Label24.Size = new Size(24, 13);
            Label24.TabIndex = 40;
            Label24.Text = "Ort:";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Silver;
            Panel1.Controls.Add(PictureBox1);
            Panel1.Controls.Add(LBL_IDKontakt);
            Panel1.Controls.Add(Label3);
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(736, 38);
            Panel1.TabIndex = 15;
            // 
            // PictureBox1
            // 
            PictureBox1.Image = My.Resources.Resources.outlook_groß;
            PictureBox1.Location = new Point(7, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(38, 38);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 3;
            PictureBox1.TabStop = false;
            // 
            // LBL_IDKontakt
            // 
            LBL_IDKontakt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            LBL_IDKontakt.ForeColor = Color.Gray;
            LBL_IDKontakt.Location = new Point(624, 9);
            LBL_IDKontakt.Name = "LBL_IDKontakt";
            LBL_IDKontakt.Size = new Size(100, 23);
            LBL_IDKontakt.TabIndex = 2;
            LBL_IDKontakt.Text = "LBL_IDKontakt";
            LBL_IDKontakt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label3.Location = new Point(52, 9);
            Label3.Name = "Label3";
            Label3.Size = new Size(249, 20);
            Label3.TabIndex = 1;
            Label3.Text = "Kontakt nach Outlook exportieren:";
            // 
            // KontakteMitAdresseBindingSource
            // 
            KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse";
            KontakteMitAdresseBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // KontakteMitAdresseTableAdapter
            // 
            KontakteMitAdresseTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            TableAdapterManager.AdressenTableAdapter = null;
            TableAdapterManager.AT_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.BackupDataSetBeforeUpdate = false;
            TableAdapterManager.BelegeTableAdapter = null;
            TableAdapterManager.CH_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.Connection = null;
            TableAdapterManager.DE_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.FirmenNameTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = null;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = null;
            TableAdapterManager.StaatenTableAdapter = null;
            TableAdapterManager.UpdateOrder = _WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // LBL_FirmenName
            // 
            LBL_FirmenName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            LBL_FirmenName.Location = new Point(103, 35);
            LBL_FirmenName.Name = "LBL_FirmenName";
            LBL_FirmenName.Size = new Size(250, 13);
            LBL_FirmenName.TabIndex = 18;
            LBL_FirmenName.Text = "Firmenname GmbH";
            // 
            // NachnameLabel1
            // 
            NachnameLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Nachname", true));
            NachnameLabel1.Location = new Point(103, 49);
            NachnameLabel1.Name = "NachnameLabel1";
            NachnameLabel1.Size = new Size(250, 13);
            NachnameLabel1.TabIndex = 19;
            NachnameLabel1.Text = "Nachname";
            // 
            // VornameLabel1
            // 
            VornameLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Vorname", true));
            VornameLabel1.Location = new Point(103, 63);
            VornameLabel1.Name = "VornameLabel1";
            VornameLabel1.Size = new Size(250, 13);
            VornameLabel1.TabIndex = 20;
            VornameLabel1.Text = "Vorname";
            // 
            // PositionLabel1
            // 
            PositionLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Jobtitle", true));
            PositionLabel1.Location = new Point(103, 77);
            PositionLabel1.Name = "PositionLabel1";
            PositionLabel1.Size = new Size(250, 13);
            PositionLabel1.TabIndex = 21;
            PositionLabel1.Text = "Position";
            // 
            // TelefonGeschaeftlichLabel1
            // 
            TelefonGeschaeftlichLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "TelefonGeschaeftlich", true));
            TelefonGeschaeftlichLabel1.Location = new Point(103, 105);
            TelefonGeschaeftlichLabel1.Name = "TelefonGeschaeftlichLabel1";
            TelefonGeschaeftlichLabel1.Size = new Size(250, 13);
            TelefonGeschaeftlichLabel1.TabIndex = 22;
            TelefonGeschaeftlichLabel1.Text = "Tel gesch";
            // 
            // TelefonPrivatLabel1
            // 
            TelefonPrivatLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "TelefonPrivat", true));
            TelefonPrivatLabel1.Location = new Point(103, 119);
            TelefonPrivatLabel1.Name = "TelefonPrivatLabel1";
            TelefonPrivatLabel1.Size = new Size(250, 13);
            TelefonPrivatLabel1.TabIndex = 23;
            TelefonPrivatLabel1.Text = "Tel priv";
            // 
            // MobiltelefonLabel1
            // 
            MobiltelefonLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Mobiltelefon", true));
            MobiltelefonLabel1.Location = new Point(103, 133);
            MobiltelefonLabel1.Name = "MobiltelefonLabel1";
            MobiltelefonLabel1.Size = new Size(250, 13);
            MobiltelefonLabel1.TabIndex = 24;
            MobiltelefonLabel1.Text = "Mobilnummer";
            // 
            // FaxnummerLabel1
            // 
            FaxnummerLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Faxnummer", true));
            FaxnummerLabel1.Location = new Point(103, 147);
            FaxnummerLabel1.Name = "FaxnummerLabel1";
            FaxnummerLabel1.Size = new Size(250, 13);
            FaxnummerLabel1.TabIndex = 25;
            FaxnummerLabel1.Text = "Fax";
            // 
            // EmailAddresseLabel1
            // 
            EmailAddresseLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "EmailAddresse", true));
            EmailAddresseLabel1.Location = new Point(103, 91);
            EmailAddresseLabel1.Name = "EmailAddresseLabel1";
            EmailAddresseLabel1.Size = new Size(250, 13);
            EmailAddresseLabel1.TabIndex = 26;
            EmailAddresseLabel1.Text = "Email";
            // 
            // StraßeLabel1
            // 
            StraßeLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Straße", true));
            StraßeLabel1.Location = new Point(103, 170);
            StraßeLabel1.Name = "StraßeLabel1";
            StraßeLabel1.Size = new Size(250, 13);
            StraßeLabel1.TabIndex = 27;
            StraßeLabel1.Text = "Strasse";
            // 
            // PLZLabel1
            // 
            PLZLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "PLZ", true));
            PLZLabel1.Location = new Point(103, 184);
            PLZLabel1.Name = "PLZLabel1";
            PLZLabel1.Size = new Size(250, 13);
            PLZLabel1.TabIndex = 29;
            PLZLabel1.Text = "PLZ";
            // 
            // OrtLabel1
            // 
            OrtLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Ort", true));
            OrtLabel1.Location = new Point(103, 198);
            OrtLabel1.Name = "OrtLabel1";
            OrtLabel1.Size = new Size(250, 13);
            OrtLabel1.TabIndex = 31;
            OrtLabel1.Text = "Stadt";
            // 
            // BundeslandLabel1
            // 
            BundeslandLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Bundesland", true));
            BundeslandLabel1.Location = new Point(103, 212);
            BundeslandLabel1.Name = "BundeslandLabel1";
            BundeslandLabel1.Size = new Size(250, 13);
            BundeslandLabel1.TabIndex = 33;
            BundeslandLabel1.Text = "Niedersachsen";
            // 
            // LandLabel1
            // 
            LandLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Land", true));
            LandLabel1.Location = new Point(103, 226);
            LandLabel1.Name = "LandLabel1";
            LandLabel1.Size = new Size(250, 13);
            LandLabel1.TabIndex = 35;
            LandLabel1.Text = "Land";
            // 
            // WebseiteLabel1
            // 
            WebseiteLabel1.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "Webseite", true));
            WebseiteLabel1.Location = new Point(103, 240);
            WebseiteLabel1.Name = "WebseiteLabel1";
            WebseiteLabel1.Size = new Size(250, 13);
            WebseiteLabel1.TabIndex = 37;
            WebseiteLabel1.Text = "www.website.de";
            // 
            // BTN_aktualisieren
            // 
            _BTN_aktualisieren.Image = My.Resources.Resources.AssignToUser_16x;
            _BTN_aktualisieren.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_aktualisieren.Location = new Point(246, 268);
            _BTN_aktualisieren.Name = "_BTN_aktualisieren";
            _BTN_aktualisieren.Size = new Size(90, 23);
            _BTN_aktualisieren.TabIndex = 38;
            _BTN_aktualisieren.Text = "aktualisieren";
            _BTN_aktualisieren.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_aktualisieren.UseVisualStyleBackColor = true;
            // 
            // LBLGEF_FirmenName
            // 
            LBLGEF_FirmenName.AutoSize = true;
            LBLGEF_FirmenName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            LBLGEF_FirmenName.Location = new Point(97, 35);
            LBLGEF_FirmenName.Name = "LBLGEF_FirmenName";
            LBLGEF_FirmenName.Size = new Size(76, 13);
            LBLGEF_FirmenName.TabIndex = 51;
            LBLGEF_FirmenName.Text = "FirmenName";
            // 
            // LBLGEF_Nachname
            // 
            LBLGEF_Nachname.AutoSize = true;
            LBLGEF_Nachname.Location = new Point(97, 49);
            LBLGEF_Nachname.Name = "LBLGEF_Nachname";
            LBLGEF_Nachname.Size = new Size(59, 13);
            LBLGEF_Nachname.TabIndex = 52;
            LBLGEF_Nachname.Text = "Nachname";
            // 
            // LBLGEF_Vorname
            // 
            LBLGEF_Vorname.AutoSize = true;
            LBLGEF_Vorname.Location = new Point(97, 63);
            LBLGEF_Vorname.Name = "LBLGEF_Vorname";
            LBLGEF_Vorname.Size = new Size(49, 13);
            LBLGEF_Vorname.TabIndex = 53;
            LBLGEF_Vorname.Text = "Vorname";
            // 
            // LBLGEF_Position
            // 
            LBLGEF_Position.AutoSize = true;
            LBLGEF_Position.Location = new Point(97, 77);
            LBLGEF_Position.Name = "LBLGEF_Position";
            LBLGEF_Position.Size = new Size(44, 13);
            LBLGEF_Position.TabIndex = 54;
            LBLGEF_Position.Text = "Position";
            // 
            // LBLGEF_Email
            // 
            LBLGEF_Email.AutoSize = true;
            LBLGEF_Email.Location = new Point(97, 91);
            LBLGEF_Email.Name = "LBLGEF_Email";
            LBLGEF_Email.Size = new Size(32, 13);
            LBLGEF_Email.TabIndex = 55;
            LBLGEF_Email.Text = "Email";
            // 
            // LBLGEF_TelefonGesch
            // 
            LBLGEF_TelefonGesch.AutoSize = true;
            LBLGEF_TelefonGesch.Location = new Point(97, 105);
            LBLGEF_TelefonGesch.Name = "LBLGEF_TelefonGesch";
            LBLGEF_TelefonGesch.Size = new Size(75, 13);
            LBLGEF_TelefonGesch.TabIndex = 56;
            LBLGEF_TelefonGesch.Text = "Telefon gesch";
            // 
            // LBLGEF_TelefonPriv
            // 
            LBLGEF_TelefonPriv.AutoSize = true;
            LBLGEF_TelefonPriv.Location = new Point(97, 119);
            LBLGEF_TelefonPriv.Name = "LBLGEF_TelefonPriv";
            LBLGEF_TelefonPriv.Size = new Size(72, 13);
            LBLGEF_TelefonPriv.TabIndex = 57;
            LBLGEF_TelefonPriv.Text = "Telefon privat";
            // 
            // LBLGEF_Mobiltelefon
            // 
            LBLGEF_Mobiltelefon.AutoSize = true;
            LBLGEF_Mobiltelefon.Location = new Point(97, 133);
            LBLGEF_Mobiltelefon.Name = "LBLGEF_Mobiltelefon";
            LBLGEF_Mobiltelefon.Size = new Size(101, 13);
            LBLGEF_Mobiltelefon.TabIndex = 58;
            LBLGEF_Mobiltelefon.Text = "Mobiltelefonnummer";
            // 
            // LBLGEF_Faxnummer
            // 
            LBLGEF_Faxnummer.AutoSize = true;
            LBLGEF_Faxnummer.Location = new Point(97, 147);
            LBLGEF_Faxnummer.Name = "LBLGEF_Faxnummer";
            LBLGEF_Faxnummer.Size = new Size(61, 13);
            LBLGEF_Faxnummer.TabIndex = 59;
            LBLGEF_Faxnummer.Text = "Faxnummer";
            // 
            // LBLGEF_Strasse
            // 
            LBLGEF_Strasse.AutoSize = true;
            LBLGEF_Strasse.Location = new Point(97, 170);
            LBLGEF_Strasse.Name = "LBLGEF_Strasse";
            LBLGEF_Strasse.Size = new Size(42, 13);
            LBLGEF_Strasse.TabIndex = 60;
            LBLGEF_Strasse.Text = "Strasse";
            // 
            // LBLGEF_PLZ
            // 
            LBLGEF_PLZ.AutoSize = true;
            LBLGEF_PLZ.Location = new Point(98, 183);
            LBLGEF_PLZ.Name = "LBLGEF_PLZ";
            LBLGEF_PLZ.Size = new Size(60, 13);
            LBLGEF_PLZ.TabIndex = 61;
            LBLGEF_PLZ.Text = "Postleitzahl";
            // 
            // LBLGEF_Ort
            // 
            LBLGEF_Ort.AutoSize = true;
            LBLGEF_Ort.Location = new Point(98, 196);
            LBLGEF_Ort.Name = "LBLGEF_Ort";
            LBLGEF_Ort.Size = new Size(32, 13);
            LBLGEF_Ort.TabIndex = 62;
            LBLGEF_Ort.Text = "Stadt";
            // 
            // LBLGEF_Bundesland
            // 
            LBLGEF_Bundesland.AutoSize = true;
            LBLGEF_Bundesland.Location = new Point(97, 209);
            LBLGEF_Bundesland.Name = "LBLGEF_Bundesland";
            LBLGEF_Bundesland.Size = new Size(63, 13);
            LBLGEF_Bundesland.TabIndex = 63;
            LBLGEF_Bundesland.Text = "Bundesland";
            // 
            // LBLGEF_Land
            // 
            LBLGEF_Land.AutoSize = true;
            LBLGEF_Land.Location = new Point(99, 222);
            LBLGEF_Land.Name = "LBLGEF_Land";
            LBLGEF_Land.Size = new Size(31, 13);
            LBLGEF_Land.TabIndex = 64;
            LBLGEF_Land.Text = "Land";
            // 
            // LBLGEF_Website
            // 
            LBLGEF_Website.AutoSize = true;
            LBLGEF_Website.Location = new Point(97, 235);
            LBLGEF_Website.Name = "LBLGEF_Website";
            LBLGEF_Website.Size = new Size(85, 13);
            LBLGEF_Website.TabIndex = 65;
            LBLGEF_Website.Text = "www.website.de";
            // 
            // PNL_GefundenerKontakt
            // 
            PNL_GefundenerKontakt.BackColor = Color.White;
            PNL_GefundenerKontakt.Controls.Add(_BTN_olContDelete);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Website);
            PNL_GefundenerKontakt.Controls.Add(Panel3);
            PNL_GefundenerKontakt.Controls.Add(_BTN_aktualisieren);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_TelefonGesch);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Land);
            PNL_GefundenerKontakt.Controls.Add(Label9);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Bundesland);
            PNL_GefundenerKontakt.Controls.Add(Label8);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Ort);
            PNL_GefundenerKontakt.Controls.Add(Label10);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_PLZ);
            PNL_GefundenerKontakt.Controls.Add(Label12);
            PNL_GefundenerKontakt.Controls.Add(Label24);
            PNL_GefundenerKontakt.Controls.Add(Label7);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Strasse);
            PNL_GefundenerKontakt.Controls.Add(Label13);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Faxnummer);
            PNL_GefundenerKontakt.Controls.Add(Label14);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Mobiltelefon);
            PNL_GefundenerKontakt.Controls.Add(Label6);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_TelefonPriv);
            PNL_GefundenerKontakt.Controls.Add(Label15);
            PNL_GefundenerKontakt.Controls.Add(Label16);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Email);
            PNL_GefundenerKontakt.Controls.Add(Label5);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Position);
            PNL_GefundenerKontakt.Controls.Add(Label17);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Vorname);
            PNL_GefundenerKontakt.Controls.Add(Label11);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_Nachname);
            PNL_GefundenerKontakt.Controls.Add(Label4);
            PNL_GefundenerKontakt.Controls.Add(LBLGEF_FirmenName);
            PNL_GefundenerKontakt.Location = new Point(5, 43);
            PNL_GefundenerKontakt.Name = "PNL_GefundenerKontakt";
            PNL_GefundenerKontakt.Size = new Size(360, 294);
            PNL_GefundenerKontakt.TabIndex = 40;
            // 
            // BTN_olContDelete
            // 
            _BTN_olContDelete.BackColor = Color.Red;
            _BTN_olContDelete.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _BTN_olContDelete.ForeColor = Color.White;
            _BTN_olContDelete.Image = My.Resources.Resources.DeleteUser_16x;
            _BTN_olContDelete.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_olContDelete.Location = new Point(11, 268);
            _BTN_olContDelete.Name = "_BTN_olContDelete";
            _BTN_olContDelete.Size = new Size(90, 23);
            _BTN_olContDelete.TabIndex = 66;
            _BTN_olContDelete.Text = "löschen";
            _BTN_olContDelete.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_olContDelete.UseVisualStyleBackColor = false;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(255)), Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(192)));
            Panel3.Controls.Add(LBL_olContID);
            Panel3.Controls.Add(Label18);
            Panel3.Location = new Point(0, 0);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(360, 27);
            Panel3.TabIndex = 0;
            // 
            // LBL_olContID
            // 
            LBL_olContID.AutoSize = true;
            LBL_olContID.ForeColor = Color.Gray;
            LBL_olContID.Location = new Point(318, 8);
            LBL_olContID.Name = "LBL_olContID";
            LBL_olContID.Size = new Size(18, 13);
            LBL_olContID.TabIndex = 1;
            LBL_olContID.Text = "ID";
            // 
            // Label18
            // 
            Label18.AutoSize = true;
            Label18.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label18.ForeColor = Color.Black;
            Label18.Location = new Point(0, 0);
            Label18.Name = "Label18";
            Label18.Size = new Size(233, 24);
            Label18.TabIndex = 0;
            Label18.Text = "Kontakt bereits vorhanden!";
            // 
            // Panel4
            // 
            Panel4.BackColor = Color.White;
            Panel4.Controls.Add(Panel6);
            Panel4.Controls.Add(FirmenNameLabel);
            Panel4.Controls.Add(LBL_FirmenName);
            Panel4.Controls.Add(WebseiteLabel);
            Panel4.Controls.Add(NachnameLabel1);
            Panel4.Controls.Add(WebseiteLabel1);
            Panel4.Controls.Add(VornameLabel1);
            Panel4.Controls.Add(LandLabel);
            Panel4.Controls.Add(NachnameLabel);
            Panel4.Controls.Add(LandLabel1);
            Panel4.Controls.Add(VornameLabel);
            Panel4.Controls.Add(BundeslandLabel);
            Panel4.Controls.Add(PositionLabel);
            Panel4.Controls.Add(BundeslandLabel1);
            Panel4.Controls.Add(PositionLabel1);
            Panel4.Controls.Add(OrtLabel);
            Panel4.Controls.Add(EmailAddresseLabel);
            Panel4.Controls.Add(OrtLabel1);
            Panel4.Controls.Add(EmailAddresseLabel1);
            Panel4.Controls.Add(PLZLabel);
            Panel4.Controls.Add(TelefonGeschaeftlichLabel1);
            Panel4.Controls.Add(PLZLabel1);
            Panel4.Controls.Add(TelefonGeschaeftlichLabel);
            Panel4.Controls.Add(StraßeLabel);
            Panel4.Controls.Add(TelefonPrivatLabel1);
            Panel4.Controls.Add(StraßeLabel1);
            Panel4.Controls.Add(TelefonPrivatLabel);
            Panel4.Controls.Add(FaxnummerLabel);
            Panel4.Controls.Add(MobiltelefonLabel1);
            Panel4.Controls.Add(FaxnummerLabel1);
            Panel4.Controls.Add(MobiltelefonLabel);
            Panel4.Location = new Point(371, 43);
            Panel4.Name = "Panel4";
            Panel4.Size = new Size(360, 295);
            Panel4.TabIndex = 41;
            // 
            // Panel6
            // 
            Panel6.BackColor = Color.Silver;
            Panel6.Controls.Add(Label1);
            Panel6.Location = new Point(0, 0);
            Panel6.Name = "Panel6";
            Panel6.Size = new Size(360, 27);
            Panel6.TabIndex = 38;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 14.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(0, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(134, 24);
            Label1.TabIndex = 1;
            Label1.Text = "Neuer Kontakt:";
            // 
            // Panel5
            // 
            Panel5.BackColor = Color.Gray;
            Panel5.Controls.Add(_Button1);
            Panel5.Controls.Add(_BTN_hinzufügen);
            Panel5.Location = new Point(0, 344);
            Panel5.Name = "Panel5";
            Panel5.Size = new Size(736, 43);
            Panel5.TabIndex = 42;
            // 
            // Button1
            // 
            _Button1.Image = My.Resources.Resources.Cancel_16x;
            _Button1.ImageAlign = ContentAlignment.MiddleRight;
            _Button1.Location = new Point(477, 10);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(80, 23);
            _Button1.TabIndex = 1;
            _Button1.Text = "Abbrechen";
            _Button1.TextAlign = ContentAlignment.MiddleLeft;
            _Button1.UseVisualStyleBackColor = true;
            // 
            // BTN_hinzufügen
            // 
            _BTN_hinzufügen.Image = My.Resources.Resources.AddUser_16x;
            _BTN_hinzufügen.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_hinzufügen.Location = new Point(645, 10);
            _BTN_hinzufügen.Name = "_BTN_hinzufügen";
            _BTN_hinzufügen.Size = new Size(80, 23);
            _BTN_hinzufügen.TabIndex = 0;
            _BTN_hinzufügen.Text = "hinzufügen";
            _BTN_hinzufügen.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_hinzufügen.UseVisualStyleBackColor = true;
            // 
            // LBL_Hinweis
            // 
            LBL_Hinweis.AutoSize = true;
            LBL_Hinweis.Location = new Point(69, 78);
            LBL_Hinweis.Name = "LBL_Hinweis";
            LBL_Hinweis.Size = new Size(240, 104);
            LBL_Hinweis.TabIndex = 43;
            LBL_Hinweis.Text = resources.GetString("LBL_Hinweis.Text");
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 389);
            Controls.Add(LBL_Hinweis);
            Controls.Add(Panel5);
            Controls.Add(Panel4);
            Controls.Add(PNL_GefundenerKontakt);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form3";
            Text = "Outlook-Export";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            PNL_GefundenerKontakt.ResumeLayout(false);
            PNL_GefundenerKontakt.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel4.ResumeLayout(false);
            Panel4.PerformLayout();
            Panel6.ResumeLayout(false);
            Panel6.PerformLayout();
            Panel5.ResumeLayout(false);
  //          Load += new EventHandler(Form3_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private Button _BTN_hinzufügen;

        internal Button BTN_hinzufügen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_hinzufügen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_hinzufügen != null)
                {
     //               _BTN_hinzufügen.Click -= BTN_hinzufügen_Click;
                }

                _BTN_hinzufügen = value;
                if (_BTN_hinzufügen != null)
                {
  //                  _BTN_hinzufügen.Click += BTN_hinzufügen_Click;
                }
            }
        }

        internal Panel Panel1;
        internal Label LBL_IDKontakt;
        internal Label Label3;
        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal BindingSource KontakteMitAdresseBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter KontakteMitAdresseTableAdapter;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal Label LBL_FirmenName;
        internal Label NachnameLabel1;
        internal Label VornameLabel1;
        internal Label PositionLabel1;
        internal Label TelefonGeschaeftlichLabel1;
        internal Label TelefonPrivatLabel1;
        internal Label MobiltelefonLabel1;
        internal Label FaxnummerLabel1;
        internal Label EmailAddresseLabel1;
        internal Label StraßeLabel1;
        internal Label PLZLabel1;
        internal Label OrtLabel1;
        internal Label BundeslandLabel1;
        internal Label LandLabel1;
        internal Label WebseiteLabel1;
        private Button _BTN_aktualisieren;

        internal Button BTN_aktualisieren
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_aktualisieren;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_aktualisieren != null)
                {
 //                   _BTN_aktualisieren.Click -= BTN_aktualisieren_Click;
                }

                _BTN_aktualisieren = value;
                if (_BTN_aktualisieren != null)
                {
  //                  _BTN_aktualisieren.Click += BTN_aktualisieren_Click;
                }
            }
        }

        internal Label LBLGEF_FirmenName;
        internal Label LBLGEF_Website;
        internal Label LBLGEF_Land;
        internal Label LBLGEF_Bundesland;
        internal Label LBLGEF_Ort;
        internal Label LBLGEF_PLZ;
        internal Label LBLGEF_Strasse;
        internal Label LBLGEF_Faxnummer;
        internal Label LBLGEF_Mobiltelefon;
        internal Label LBLGEF_TelefonPriv;
        internal Label LBLGEF_TelefonGesch;
        internal Label LBLGEF_Email;
        internal Label LBLGEF_Position;
        internal Label LBLGEF_Vorname;
        internal Label LBLGEF_Nachname;
        internal Panel PNL_GefundenerKontakt;
        internal Panel Panel3;
        internal Label Label18;
        internal Panel Panel4;
        internal Panel Panel5;
        internal Panel Panel6;
        internal Label Label1;
        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
 //                   _Button1.Click -= Button1_Click_1;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
 //                   _Button1.Click += Button1_Click_1;
                }
            }
        }

        internal Label LBL_Hinweis;
        internal Label LBL_olContID;
        private Button _BTN_olContDelete;

        internal Button BTN_olContDelete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_olContDelete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_olContDelete != null)
                {
  //                  _BTN_olContDelete.Click -= BTN_olContDelete_Click;
                }

                _BTN_olContDelete = value;
                if (_BTN_olContDelete != null)
                {
  //                  _BTN_olContDelete.Click += BTN_olContDelete_Click;
                }
            }
        }

        internal PictureBox PictureBox1;
    }
}