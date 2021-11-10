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
    public partial class Administration : Form
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
            Label IDFirmenNameLabel;
            Label LeadnummerLabel;
            Label KundennummerLabel;
            Label LieferantennummerLabel;
            Label IDAdresseLabel;
            Label IDKontaktLabel;
            Label IDBesuchLabel;
            Label VorlagenpfadLabel;
            Label SachbearbeiterLabel;
            Label AdminLabel;
            Label IDFirmenNameLabel1;
            Label FirmenNameLabel;
            Label LoginLabel;
            Label ChangedLabel;
            Label IDKontoLabel;
            Label IDFirmenNameLabel2;
            Label KontoNameLabel;
            Label AnlageDatumLabel;
            Label IDAdresseLabel1;
            Label IDFirmenNameLabel3;
            Label IDKontoLabel1;
            Label AdresstypLabel;
            Label StraßeLabel;
            Label PostfachLabel;
            Label PLZLabel;
            Label OrtLabel;
            Label BundeslandLabel;
            Label LandLabel;
            Label UStIdNrLabel;
            Label WebseiteLabel;
            Label IDKontaktLabel1;
            Label IDFirmenNameLabel4;
            Label VornameLabel;
            Label NachnameLabel;
            Label AnredeLabel;
            Label EmailAddresseLabel;
            Label JobtitleLabel;
            Label TelefonGeschaeftlichLabel;
            Label TelefonPrivatLabel;
            Label MobiltelefonLabel;
            Label FaxnummerLabel;
            Label IDAdresseLabel2;
            Label DWpfadLabel;
            Label DWDateinameLabel;
            Label InaktivLabel;
            Label HilfelinkLabel;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            FolderBrowserDialog1 = new FolderBrowserDialog();
            VorlagenpfadTextBox = new TextBox();
            KonfigurationBindingSource = new BindingSource(components);
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            IDBesuchTextBox = new TextBox();
            IDKontaktTextBox = new TextBox();
            IDAdresseTextBox = new TextBox();
            LieferantennummerTextBox = new TextBox();
            KundennummerTextBox = new TextBox();
            LeadnummerTextBox = new TextBox();
            IDFirmenNameTextBox = new TextBox();
            Panel2 = new Panel();
            AdminCheckBox = new CheckBox();
            SachbearbeiterBindingSource = new BindingSource(components);
            SachbearbeiterLabel1 = new Label();
            _BTN_Alle = new Button();
            _BTN_Alle.Click += new EventHandler(BTN_Alle_Click);
            _BTN_Aktuell = new Button();
            _BTN_Aktuell.Click += new EventHandler(BTN_Aktuell_Click);
            Label1 = new Label();
            Panel3 = new Panel();
            _BTN_Schliessen = new Button();
            _BTN_Schliessen.Click += new EventHandler(BTN_Schliessen_Click);
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            KonfigurationTableAdapter = new _WSL_AdressenDataSetTableAdapters.KonfigurationTableAdapter();
            SachbearbeiterTableAdapter = new _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            TC_Administration = new TabControl();
            TabPage1 = new TabPage();
            HilfelinkTextBox = new TextBox();
            _BTN_DWPfad = new Button();
            _BTN_DWPfad.Click += new EventHandler(BTN_DWPfad_Click);
            DWDateinameTextBox = new TextBox();
            DWpfadTextBox = new TextBox();
            _BTN_Speichern = new Button();
            _BTN_Speichern.Click += new EventHandler(BTN_Speichern_Click);
            _BTN_Vorlagenpfad = new Button();
            _BTN_Vorlagenpfad.Click += new EventHandler(BTN_Vorlagenpfad_Click);
            TabPage2 = new TabPage();
            InaktivCheckBox = new CheckBox();
            FirmenNameBindingSource = new BindingSource(components);
            BindingNavigator1 = new BindingNavigator(components);
            ToolStripButton21 = new ToolStripButton();
            ToolStripLabel4 = new ToolStripLabel();
            ToolStripButton22 = new ToolStripButton();
            ToolStripButton23 = new ToolStripButton();
            ToolStripButton24 = new ToolStripButton();
            ToolStripSeparator10 = new ToolStripSeparator();
            ToolStripTextBox4 = new ToolStripTextBox();
            ToolStripSeparator11 = new ToolStripSeparator();
            ToolStripButton25 = new ToolStripButton();
            ToolStripButton26 = new ToolStripButton();
            ToolStripSeparator12 = new ToolStripSeparator();
            _BNAV_FirmenNameSave = new ToolStripButton();
            _BNAV_FirmenNameSave.Click += new EventHandler(BNAV_FirmenNameSave_Click);
            ChangedDateTimePicker = new DateTimePicker();
            LoginTextBox = new TextBox();
            FirmenNameTextBox = new TextBox();
            IDFirmenNameTextBox1 = new TextBox();
            FirmenNameDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            changed = new DataGridViewTextBoxColumn();
            inaktiv = new DataGridViewCheckBoxColumn();
            TabPage3 = new TabPage();
            BindingNavigator2 = new BindingNavigator(components);
            ToolStripButton14 = new ToolStripButton();
            KontoBindingSource = new BindingSource(components);
            ToolStripLabel3 = new ToolStripLabel();
            ToolStripButton15 = new ToolStripButton();
            ToolStripButton16 = new ToolStripButton();
            ToolStripButton17 = new ToolStripButton();
            ToolStripSeparator7 = new ToolStripSeparator();
            ToolStripTextBox3 = new ToolStripTextBox();
            ToolStripSeparator8 = new ToolStripSeparator();
            ToolStripButton18 = new ToolStripButton();
            ToolStripButton19 = new ToolStripButton();
            ToolStripSeparator9 = new ToolStripSeparator();
            _BNAV_KontoSave = new ToolStripButton();
            _BNAV_KontoSave.Click += new EventHandler(BNAV_KontoSave_Click);
            AnlageDatumDateTimePicker = new DateTimePicker();
            KontoNameTextBox = new TextBox();
            IDFirmenNameTextBox2 = new TextBox();
            IDKontoTextBox = new TextBox();
            KontoDataGridView = new DataGridView();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            Datum = new DataGridViewTextBoxColumn();
            TabPage4 = new TabPage();
            BindingNavigator3 = new BindingNavigator(components);
            ToolStripButton7 = new ToolStripButton();
            AdressenBindingSource = new BindingSource(components);
            ToolStripLabel2 = new ToolStripLabel();
            ToolStripButton8 = new ToolStripButton();
            ToolStripButton9 = new ToolStripButton();
            ToolStripButton10 = new ToolStripButton();
            ToolStripSeparator4 = new ToolStripSeparator();
            ToolStripTextBox2 = new ToolStripTextBox();
            ToolStripSeparator5 = new ToolStripSeparator();
            ToolStripButton11 = new ToolStripButton();
            ToolStripButton12 = new ToolStripButton();
            ToolStripSeparator6 = new ToolStripSeparator();
            _BNAV_AdressenSave = new ToolStripButton();
            _BNAV_AdressenSave.Click += new EventHandler(BNAV_AdressenSave_Click);
            WebseiteTextBox = new TextBox();
            UStIdNrTextBox = new TextBox();
            LandTextBox = new TextBox();
            BundeslandTextBox = new TextBox();
            OrtTextBox = new TextBox();
            PLZTextBox = new TextBox();
            PostfachTextBox = new TextBox();
            StraßeTextBox = new TextBox();
            AdresstypTextBox = new TextBox();
            IDKontoTextBox1 = new TextBox();
            IDFirmenNameTextBox3 = new TextBox();
            IDAdresseTextBox1 = new TextBox();
            DataGridView1 = new DataGridView();
            IDAdresse = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            IDKonto = new DataGridViewTextBoxColumn();
            Adresstyp = new DataGridViewTextBoxColumn();
            Straße = new DataGridViewTextBoxColumn();
            Postfach = new DataGridViewTextBoxColumn();
            PLZ = new DataGridViewTextBoxColumn();
            Ort = new DataGridViewTextBoxColumn();
            Bundesland = new DataGridViewTextBoxColumn();
            Land = new DataGridViewTextBoxColumn();
            UStIdNr = new DataGridViewTextBoxColumn();
            Webseite = new DataGridViewTextBoxColumn();
            TabPage5 = new TabPage();
            SachbearbeiterBindingNavigator = new BindingNavigator(components);
            ToolStripButton1 = new ToolStripButton();
            KontakteBindingSource = new BindingSource(components);
            ToolStripLabel1 = new ToolStripLabel();
            ToolStripButton2 = new ToolStripButton();
            ToolStripButton3 = new ToolStripButton();
            ToolStripButton4 = new ToolStripButton();
            ToolStripSeparator1 = new ToolStripSeparator();
            ToolStripTextBox1 = new ToolStripTextBox();
            ToolStripSeparator2 = new ToolStripSeparator();
            ToolStripButton5 = new ToolStripButton();
            ToolStripButton6 = new ToolStripButton();
            ToolStripSeparator3 = new ToolStripSeparator();
            _BNAV_KontakteSave = new ToolStripButton();
            _BNAV_KontakteSave.Click += new EventHandler(BNAV_KontakteSave_Click);
            IDAdresseTextBox2 = new TextBox();
            FaxnummerTextBox = new TextBox();
            MobiltelefonTextBox = new TextBox();
            TelefonPrivatTextBox = new TextBox();
            TelefonGeschaeftlichTextBox = new TextBox();
            JobtitleTextBox = new TextBox();
            EmailAddresseTextBox = new TextBox();
            AnredeTextBox = new TextBox();
            NachnameTextBox = new TextBox();
            VornameTextBox = new TextBox();
            IDFirmenNameTextBox4 = new TextBox();
            IDKontaktTextBox1 = new TextBox();
            DataGridView2 = new DataGridView();
            IDKontakt = new DataGridViewTextBoxColumn();
            IDFirmenName = new DataGridViewTextBoxColumn();
            Nachname = new DataGridViewTextBoxColumn();
            Vorname = new DataGridViewTextBoxColumn();
            EmailAddresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            JobtitleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TelefonGeschaeftlichDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TelefonPrivatDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            MobiltelefonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FaxnummerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            IDAdresseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            AnredeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Belege = new TabPage();
            BNAV_Belege = new BindingNavigator(components);
            ToolStripButton28 = new ToolStripButton();
            BelegeBindingSource = new BindingSource(components);
            ToolStripLabel5 = new ToolStripLabel();
            ToolStripButton29 = new ToolStripButton();
            ToolStripButton30 = new ToolStripButton();
            ToolStripButton31 = new ToolStripButton();
            ToolStripSeparator13 = new ToolStripSeparator();
            ToolStripTextBox5 = new ToolStripTextBox();
            ToolStripSeparator14 = new ToolStripSeparator();
            ToolStripButton32 = new ToolStripButton();
            ToolStripButton33 = new ToolStripButton();
            ToolStripSeparator15 = new ToolStripSeparator();
            _BNAV_BelegeSaveItem = new ToolStripButton();
            _BNAV_BelegeSaveItem.Click += new EventHandler(BNAV_BelegeSaveItem_Click);
            BelegeDataGridView = new DataGridView();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            FirmenNameTableAdapter = new _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            KontoTableAdapter = new _WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            AdressenTableAdapter = new _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter();
            KontakteTableAdapter = new _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter();
            BelegeTableAdapter = new _WSL_AdressenDataSetTableAdapters.BelegeTableAdapter();
            TableLayoutPanel1 = new TableLayoutPanel();
            IDFirmenNameLabel = new Label();
            LeadnummerLabel = new Label();
            KundennummerLabel = new Label();
            LieferantennummerLabel = new Label();
            IDAdresseLabel = new Label();
            IDKontaktLabel = new Label();
            IDBesuchLabel = new Label();
            VorlagenpfadLabel = new Label();
            SachbearbeiterLabel = new Label();
            AdminLabel = new Label();
            IDFirmenNameLabel1 = new Label();
            FirmenNameLabel = new Label();
            LoginLabel = new Label();
            ChangedLabel = new Label();
            IDKontoLabel = new Label();
            IDFirmenNameLabel2 = new Label();
            KontoNameLabel = new Label();
            AnlageDatumLabel = new Label();
            IDAdresseLabel1 = new Label();
            IDFirmenNameLabel3 = new Label();
            IDKontoLabel1 = new Label();
            AdresstypLabel = new Label();
            StraßeLabel = new Label();
            PostfachLabel = new Label();
            PLZLabel = new Label();
            OrtLabel = new Label();
            BundeslandLabel = new Label();
            LandLabel = new Label();
            UStIdNrLabel = new Label();
            WebseiteLabel = new Label();
            IDKontaktLabel1 = new Label();
            IDFirmenNameLabel4 = new Label();
            VornameLabel = new Label();
            NachnameLabel = new Label();
            AnredeLabel = new Label();
            EmailAddresseLabel = new Label();
            JobtitleLabel = new Label();
            TelefonGeschaeftlichLabel = new Label();
            TelefonPrivatLabel = new Label();
            MobiltelefonLabel = new Label();
            FaxnummerLabel = new Label();
            IDAdresseLabel2 = new Label();
            DWpfadLabel = new Label();
            DWDateinameLabel = new Label();
            InaktivLabel = new Label();
            HilfelinkLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)KonfigurationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingSource).BeginInit();
            Panel3.SuspendLayout();
            TC_Administration.SuspendLayout();
            TabPage1.SuspendLayout();
            TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirmenNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator1).BeginInit();
            BindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FirmenNameDataGridView).BeginInit();
            TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator2).BeginInit();
            BindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KontoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontoDataGridView).BeginInit();
            TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator3).BeginInit();
            BindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdressenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingNavigator).BeginInit();
            SachbearbeiterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)KontakteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).BeginInit();
            Belege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BNAV_Belege).BeginInit();
            BNAV_Belege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BelegeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BelegeDataGridView).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // IDFirmenNameLabel
            // 
            IDFirmenNameLabel.AutoSize = true;
            IDFirmenNameLabel.Location = new Point(24, 119);
            IDFirmenNameLabel.Name = "IDFirmenNameLabel";
            IDFirmenNameLabel.Size = new Size(83, 13);
            IDFirmenNameLabel.TabIndex = 2;
            IDFirmenNameLabel.Text = "IDFirmen Name:";
            // 
            // LeadnummerLabel
            // 
            LeadnummerLabel.AutoSize = true;
            LeadnummerLabel.Location = new Point(36, 145);
            LeadnummerLabel.Name = "LeadnummerLabel";
            LeadnummerLabel.Size = new Size(71, 13);
            LeadnummerLabel.TabIndex = 4;
            LeadnummerLabel.Text = "Leadnummer:";
            // 
            // KundennummerLabel
            // 
            KundennummerLabel.AutoSize = true;
            KundennummerLabel.Location = new Point(23, 171);
            KundennummerLabel.Name = "KundennummerLabel";
            KundennummerLabel.Size = new Size(84, 13);
            KundennummerLabel.TabIndex = 6;
            KundennummerLabel.Text = "Kundennummer:";
            // 
            // LieferantennummerLabel
            // 
            LieferantennummerLabel.AutoSize = true;
            LieferantennummerLabel.Location = new Point(7, 197);
            LieferantennummerLabel.Name = "LieferantennummerLabel";
            LieferantennummerLabel.Size = new Size(100, 13);
            LieferantennummerLabel.TabIndex = 8;
            LieferantennummerLabel.Text = "Lieferantennummer:";
            // 
            // IDAdresseLabel
            // 
            IDAdresseLabel.AutoSize = true;
            IDAdresseLabel.Location = new Point(48, 223);
            IDAdresseLabel.Name = "IDAdresseLabel";
            IDAdresseLabel.Size = new Size(59, 13);
            IDAdresseLabel.TabIndex = 10;
            IDAdresseLabel.Text = "IDAdresse:";
            // 
            // IDKontaktLabel
            // 
            IDKontaktLabel.AutoSize = true;
            IDKontaktLabel.Location = new Point(49, 249);
            IDKontaktLabel.Name = "IDKontaktLabel";
            IDKontaktLabel.Size = new Size(58, 13);
            IDKontaktLabel.TabIndex = 12;
            IDKontaktLabel.Text = "IDKontakt:";
            // 
            // IDBesuchLabel
            // 
            IDBesuchLabel.AutoSize = true;
            IDBesuchLabel.Location = new Point(50, 275);
            IDBesuchLabel.Name = "IDBesuchLabel";
            IDBesuchLabel.Size = new Size(48, 13);
            IDBesuchLabel.TabIndex = 14;
            IDBesuchLabel.Text = "IDBeleg:";
            // 
            // VorlagenpfadLabel
            // 
            VorlagenpfadLabel.AutoSize = true;
            VorlagenpfadLabel.Location = new Point(34, 15);
            VorlagenpfadLabel.Name = "VorlagenpfadLabel";
            VorlagenpfadLabel.Size = new Size(73, 13);
            VorlagenpfadLabel.TabIndex = 15;
            VorlagenpfadLabel.Text = "Vorlagenpfad:";
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            SachbearbeiterLabel.Location = new Point(13, 33);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new Size(82, 13);
            SachbearbeiterLabel.TabIndex = 25;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new Point(492, 39);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(70, 13);
            AdminLabel.TabIndex = 27;
            AdminLabel.Text = "Administrator:";
            // 
            // IDFirmenNameLabel1
            // 
            IDFirmenNameLabel1.AutoSize = true;
            IDFirmenNameLabel1.Location = new Point(9, 11);
            IDFirmenNameLabel1.Name = "IDFirmenNameLabel1";
            IDFirmenNameLabel1.Size = new Size(83, 13);
            IDFirmenNameLabel1.TabIndex = 1;
            IDFirmenNameLabel1.Text = "IDFirmen Name:";
            // 
            // FirmenNameLabel
            // 
            FirmenNameLabel.AutoSize = true;
            FirmenNameLabel.Location = new Point(20, 37);
            FirmenNameLabel.Name = "FirmenNameLabel";
            FirmenNameLabel.Size = new Size(72, 13);
            FirmenNameLabel.TabIndex = 3;
            FirmenNameLabel.Text = "Firmen Name:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(56, 63);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(36, 13);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Login:";
            // 
            // ChangedLabel
            // 
            ChangedLabel.AutoSize = true;
            ChangedLabel.Location = new Point(40, 90);
            ChangedLabel.Name = "ChangedLabel";
            ChangedLabel.Size = new Size(52, 13);
            ChangedLabel.TabIndex = 7;
            ChangedLabel.Text = "changed:";
            // 
            // IDKontoLabel
            // 
            IDKontoLabel.AutoSize = true;
            IDKontoLabel.Location = new Point(641, 10);
            IDKontoLabel.Name = "IDKontoLabel";
            IDKontoLabel.Size = new Size(49, 13);
            IDKontoLabel.TabIndex = 1;
            IDKontoLabel.Text = "IDKonto:";
            // 
            // IDFirmenNameLabel2
            // 
            IDFirmenNameLabel2.AutoSize = true;
            IDFirmenNameLabel2.Location = new Point(607, 36);
            IDFirmenNameLabel2.Name = "IDFirmenNameLabel2";
            IDFirmenNameLabel2.Size = new Size(83, 13);
            IDFirmenNameLabel2.TabIndex = 3;
            IDFirmenNameLabel2.Text = "IDFirmen Name:";
            // 
            // KontoNameLabel
            // 
            KontoNameLabel.AutoSize = true;
            KontoNameLabel.Location = new Point(621, 62);
            KontoNameLabel.Name = "KontoNameLabel";
            KontoNameLabel.Size = new Size(69, 13);
            KontoNameLabel.TabIndex = 5;
            KontoNameLabel.Text = "Konto Name:";
            // 
            // AnlageDatumLabel
            // 
            AnlageDatumLabel.AutoSize = true;
            AnlageDatumLabel.Location = new Point(613, 89);
            AnlageDatumLabel.Name = "AnlageDatumLabel";
            AnlageDatumLabel.Size = new Size(77, 13);
            AnlageDatumLabel.TabIndex = 7;
            AnlageDatumLabel.Text = "Anlage Datum:";
            // 
            // IDAdresseLabel1
            // 
            IDAdresseLabel1.AutoSize = true;
            IDAdresseLabel1.Location = new Point(27, 7);
            IDAdresseLabel1.Name = "IDAdresseLabel1";
            IDAdresseLabel1.Size = new Size(59, 13);
            IDAdresseLabel1.TabIndex = 1;
            IDAdresseLabel1.Text = "IDAdresse:";
            // 
            // IDFirmenNameLabel3
            // 
            IDFirmenNameLabel3.AutoSize = true;
            IDFirmenNameLabel3.Location = new Point(3, 59);
            IDFirmenNameLabel3.Name = "IDFirmenNameLabel3";
            IDFirmenNameLabel3.Size = new Size(83, 13);
            IDFirmenNameLabel3.TabIndex = 3;
            IDFirmenNameLabel3.Text = "IDFirmen Name:";
            // 
            // IDKontoLabel1
            // 
            IDKontoLabel1.AutoSize = true;
            IDKontoLabel1.Location = new Point(37, 33);
            IDKontoLabel1.Name = "IDKontoLabel1";
            IDKontoLabel1.Size = new Size(49, 13);
            IDKontoLabel1.TabIndex = 5;
            IDKontoLabel1.Text = "IDKonto:";
            // 
            // AdresstypLabel
            // 
            AdresstypLabel.AutoSize = true;
            AdresstypLabel.Location = new Point(206, 7);
            AdresstypLabel.Name = "AdresstypLabel";
            AdresstypLabel.Size = new Size(56, 13);
            AdresstypLabel.TabIndex = 7;
            AdresstypLabel.Text = "Adresstyp:";
            // 
            // StraßeLabel
            // 
            StraßeLabel.AutoSize = true;
            StraßeLabel.Location = new Point(407, 33);
            StraßeLabel.Name = "StraßeLabel";
            StraßeLabel.Size = new Size(41, 13);
            StraßeLabel.TabIndex = 9;
            StraßeLabel.Text = "Straße:";
            // 
            // PostfachLabel
            // 
            PostfachLabel.AutoSize = true;
            PostfachLabel.Location = new Point(396, 8);
            PostfachLabel.Name = "PostfachLabel";
            PostfachLabel.Size = new Size(52, 13);
            PostfachLabel.TabIndex = 11;
            PostfachLabel.Text = "Postfach:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new Point(418, 59);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new Size(30, 13);
            PLZLabel.TabIndex = 13;
            PLZLabel.Text = "PLZ:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new Point(542, 59);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new Size(24, 13);
            OrtLabel.TabIndex = 15;
            OrtLabel.Text = "Ort:";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new Point(723, 9);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new Size(66, 13);
            BundeslandLabel.TabIndex = 17;
            BundeslandLabel.Text = "Bundesland:";
            // 
            // LandLabel
            // 
            LandLabel.AutoSize = true;
            LandLabel.Location = new Point(911, 7);
            LandLabel.Name = "LandLabel";
            LandLabel.Size = new Size(34, 13);
            LandLabel.TabIndex = 19;
            LandLabel.Text = "Land:";
            // 
            // UStIdNrLabel
            // 
            UStIdNrLabel.AutoSize = true;
            UStIdNrLabel.Location = new Point(208, 33);
            UStIdNrLabel.Name = "UStIdNrLabel";
            UStIdNrLabel.Size = new Size(54, 13);
            UStIdNrLabel.TabIndex = 21;
            UStIdNrLabel.Text = "USt Id Nr:";
            // 
            // WebseiteLabel
            // 
            WebseiteLabel.AutoSize = true;
            WebseiteLabel.Location = new Point(734, 33);
            WebseiteLabel.Name = "WebseiteLabel";
            WebseiteLabel.Size = new Size(55, 13);
            WebseiteLabel.TabIndex = 23;
            WebseiteLabel.Text = "Webseite:";
            // 
            // IDKontaktLabel1
            // 
            IDKontaktLabel1.AutoSize = true;
            IDKontaktLabel1.Location = new Point(34, 9);
            IDKontaktLabel1.Name = "IDKontaktLabel1";
            IDKontaktLabel1.Size = new Size(58, 13);
            IDKontaktLabel1.TabIndex = 2;
            IDKontaktLabel1.Text = "IDKontakt:";
            // 
            // IDFirmenNameLabel4
            // 
            IDFirmenNameLabel4.AutoSize = true;
            IDFirmenNameLabel4.Location = new Point(5, 35);
            IDFirmenNameLabel4.Name = "IDFirmenNameLabel4";
            IDFirmenNameLabel4.Size = new Size(83, 13);
            IDFirmenNameLabel4.TabIndex = 3;
            IDFirmenNameLabel4.Text = "IDFirmen-Name:";
            // 
            // VornameLabel
            // 
            VornameLabel.AutoSize = true;
            VornameLabel.Location = new Point(231, 60);
            VornameLabel.Name = "VornameLabel";
            VornameLabel.Size = new Size(52, 13);
            VornameLabel.TabIndex = 5;
            VornameLabel.Text = "Vorname:";
            // 
            // NachnameLabel
            // 
            NachnameLabel.AutoSize = true;
            NachnameLabel.Location = new Point(217, 34);
            NachnameLabel.Name = "NachnameLabel";
            NachnameLabel.Size = new Size(62, 13);
            NachnameLabel.TabIndex = 7;
            NachnameLabel.Text = "Nachname:";
            // 
            // AnredeLabel
            // 
            AnredeLabel.AutoSize = true;
            AnredeLabel.Location = new Point(239, 9);
            AnredeLabel.Name = "AnredeLabel";
            AnredeLabel.Size = new Size(44, 13);
            AnredeLabel.TabIndex = 9;
            AnredeLabel.Text = "Anrede:";
            // 
            // EmailAddresseLabel
            // 
            EmailAddresseLabel.AutoSize = true;
            EmailAddresseLabel.Location = new Point(445, 35);
            EmailAddresseLabel.Name = "EmailAddresseLabel";
            EmailAddresseLabel.Size = new Size(35, 13);
            EmailAddresseLabel.TabIndex = 11;
            EmailAddresseLabel.Text = "Email:";
            // 
            // JobtitleLabel
            // 
            JobtitleLabel.AutoSize = true;
            JobtitleLabel.Location = new Point(439, 9);
            JobtitleLabel.Name = "JobtitleLabel";
            JobtitleLabel.Size = new Size(43, 13);
            JobtitleLabel.TabIndex = 13;
            JobtitleLabel.Text = "Jobtitle:";
            // 
            // TelefonGeschaeftlichLabel
            // 
            TelefonGeschaeftlichLabel.AutoSize = true;
            TelefonGeschaeftlichLabel.Location = new Point(629, 8);
            TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel";
            TelefonGeschaeftlichLabel.Size = new Size(84, 13);
            TelefonGeschaeftlichLabel.TabIndex = 15;
            TelefonGeschaeftlichLabel.Text = "Telefon (gesch):";
            // 
            // TelefonPrivatLabel
            // 
            TelefonPrivatLabel.AutoSize = true;
            TelefonPrivatLabel.Location = new Point(633, 34);
            TelefonPrivatLabel.Name = "TelefonPrivatLabel";
            TelefonPrivatLabel.Size = new Size(76, 13);
            TelefonPrivatLabel.TabIndex = 17;
            TelefonPrivatLabel.Text = "Telefon Privat:";
            // 
            // MobiltelefonLabel
            // 
            MobiltelefonLabel.AutoSize = true;
            MobiltelefonLabel.Location = new Point(645, 60);
            MobiltelefonLabel.Name = "MobiltelefonLabel";
            MobiltelefonLabel.Size = new Size(67, 13);
            MobiltelefonLabel.TabIndex = 19;
            MobiltelefonLabel.Text = "Mobiltelefon:";
            // 
            // FaxnummerLabel
            // 
            FaxnummerLabel.AutoSize = true;
            FaxnummerLabel.Location = new Point(645, 86);
            FaxnummerLabel.Name = "FaxnummerLabel";
            FaxnummerLabel.Size = new Size(64, 13);
            FaxnummerLabel.TabIndex = 21;
            FaxnummerLabel.Text = "Faxnummer:";
            // 
            // IDAdresseLabel2
            // 
            IDAdresseLabel2.AutoSize = true;
            IDAdresseLabel2.Location = new Point(29, 61);
            IDAdresseLabel2.Name = "IDAdresseLabel2";
            IDAdresseLabel2.Size = new Size(59, 13);
            IDAdresseLabel2.TabIndex = 23;
            IDAdresseLabel2.Text = "IDAdresse:";
            // 
            // DWpfadLabel
            // 
            DWpfadLabel.AutoSize = true;
            DWpfadLabel.Location = new Point(17, 41);
            DWpfadLabel.Name = "DWpfadLabel";
            DWpfadLabel.Size = new Size(86, 13);
            DWpfadLabel.TabIndex = 18;
            DWpfadLabel.Text = "DocuWare pfad:";
            // 
            // DWDateinameLabel
            // 
            DWDateinameLabel.AutoSize = true;
            DWDateinameLabel.Location = new Point(23, 67);
            DWDateinameLabel.Name = "DWDateinameLabel";
            DWDateinameLabel.Size = new Size(83, 13);
            DWDateinameLabel.TabIndex = 20;
            DWDateinameLabel.Text = "DW-Dateiname:";
            // 
            // InaktivLabel
            // 
            InaktivLabel.AutoSize = true;
            InaktivLabel.Location = new Point(51, 117);
            InaktivLabel.Name = "InaktivLabel";
            InaktivLabel.Size = new Size(41, 13);
            InaktivLabel.TabIndex = 10;
            InaktivLabel.Text = "inaktiv:";
            // 
            // HilfelinkLabel
            // 
            HilfelinkLabel.AutoSize = true;
            HilfelinkLabel.Location = new Point(60, 93);
            HilfelinkLabel.Name = "HilfelinkLabel";
            HilfelinkLabel.Size = new Size(47, 13);
            HilfelinkLabel.TabIndex = 23;
            HilfelinkLabel.Text = "Hilfelink:";
            // 
            // VorlagenpfadTextBox
            // 
            VorlagenpfadTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "Vorlagenpfad", true));
            VorlagenpfadTextBox.Location = new Point(113, 12);
            VorlagenpfadTextBox.Name = "VorlagenpfadTextBox";
            VorlagenpfadTextBox.Size = new Size(457, 20);
            VorlagenpfadTextBox.TabIndex = 16;
            // 
            // KonfigurationBindingSource
            // 
            KonfigurationBindingSource.DataMember = "Konfiguration";
            KonfigurationBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // IDBesuchTextBox
            // 
            IDBesuchTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "IDBeleg", true));
            IDBesuchTextBox.Location = new Point(113, 272);
            IDBesuchTextBox.Name = "IDBesuchTextBox";
            IDBesuchTextBox.Size = new Size(100, 20);
            IDBesuchTextBox.TabIndex = 15;
            // 
            // IDKontaktTextBox
            // 
            IDKontaktTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "IDKontakt", true));
            IDKontaktTextBox.Location = new Point(113, 246);
            IDKontaktTextBox.Name = "IDKontaktTextBox";
            IDKontaktTextBox.Size = new Size(100, 20);
            IDKontaktTextBox.TabIndex = 13;
            // 
            // IDAdresseTextBox
            // 
            IDAdresseTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "IDAdresse", true));
            IDAdresseTextBox.Location = new Point(113, 220);
            IDAdresseTextBox.Name = "IDAdresseTextBox";
            IDAdresseTextBox.Size = new Size(100, 20);
            IDAdresseTextBox.TabIndex = 11;
            // 
            // LieferantennummerTextBox
            // 
            LieferantennummerTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "Lieferantennummer", true));
            LieferantennummerTextBox.Location = new Point(113, 194);
            LieferantennummerTextBox.Name = "LieferantennummerTextBox";
            LieferantennummerTextBox.Size = new Size(100, 20);
            LieferantennummerTextBox.TabIndex = 9;
            // 
            // KundennummerTextBox
            // 
            KundennummerTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "Kundennummer", true));
            KundennummerTextBox.Location = new Point(113, 168);
            KundennummerTextBox.Name = "KundennummerTextBox";
            KundennummerTextBox.Size = new Size(100, 20);
            KundennummerTextBox.TabIndex = 7;
            // 
            // LeadnummerTextBox
            // 
            LeadnummerTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "Leadnummer", true));
            LeadnummerTextBox.Location = new Point(113, 142);
            LeadnummerTextBox.Name = "LeadnummerTextBox";
            LeadnummerTextBox.Size = new Size(100, 20);
            LeadnummerTextBox.TabIndex = 5;
            // 
            // IDFirmenNameTextBox
            // 
            IDFirmenNameTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "IDFirmenName", true));
            IDFirmenNameTextBox.Location = new Point(113, 116);
            IDFirmenNameTextBox.Name = "IDFirmenNameTextBox";
            IDFirmenNameTextBox.Size = new Size(100, 20);
            IDFirmenNameTextBox.TabIndex = 3;
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Silver;
            Panel2.Controls.Add(AdminCheckBox);
            Panel2.Controls.Add(AdminLabel);
            Panel2.Controls.Add(SachbearbeiterLabel1);
            Panel2.Controls.Add(_BTN_Alle);
            Panel2.Controls.Add(SachbearbeiterLabel);
            Panel2.Controls.Add(_BTN_Aktuell);
            Panel2.Controls.Add(Label1);
            Panel2.Dock = DockStyle.Fill;
            Panel2.Location = new Point(3, 3);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(1179, 61);
            Panel2.TabIndex = 25;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.DataBindings.Add(new Binding("CheckState", SachbearbeiterBindingSource, "Admin", true));
            AdminCheckBox.Enabled = false;
            AdminCheckBox.Location = new Point(568, 33);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(16, 24);
            AdminCheckBox.TabIndex = 28;
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterBindingSource
            // 
            SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            SachbearbeiterBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // SachbearbeiterLabel1
            // 
            SachbearbeiterLabel1.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Sachbearbeiter", true));
            SachbearbeiterLabel1.Location = new Point(101, 29);
            SachbearbeiterLabel1.Name = "SachbearbeiterLabel1";
            SachbearbeiterLabel1.Size = new Size(385, 22);
            SachbearbeiterLabel1.TabIndex = 26;
            SachbearbeiterLabel1.Text = "Vorname Name";
            SachbearbeiterLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BTN_Alle
            // 
            _BTN_Alle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Alle.Enabled = false;
            _BTN_Alle.Location = new Point(938, 6);
            _BTN_Alle.Name = "_BTN_Alle";
            _BTN_Alle.Size = new Size(75, 23);
            _BTN_Alle.TabIndex = 2;
            _BTN_Alle.Text = "alle";
            _BTN_Alle.UseVisualStyleBackColor = true;
            // 
            // BTN_Aktuell
            // 
            _BTN_Aktuell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Aktuell.Enabled = false;
            _BTN_Aktuell.Location = new Point(1019, 6);
            _BTN_Aktuell.Name = "_BTN_Aktuell";
            _BTN_Aktuell.Size = new Size(156, 23);
            _BTN_Aktuell.TabIndex = 1;
            _BTN_Aktuell.Text = "Aktuellen Geschäftspartner";
            _BTN_Aktuell.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(110, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Administration";
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.Gray;
            Panel3.Controls.Add(_BTN_Schliessen);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(3, 476);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(1179, 43);
            Panel3.TabIndex = 26;
            // 
            // BTN_Schliessen
            // 
            _BTN_Schliessen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Schliessen.Image = (Image)resources.GetObject("BTN_Schliessen.Image");
            _BTN_Schliessen.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Schliessen.Location = new Point(1095, 10);
            _BTN_Schliessen.Name = "_BTN_Schliessen";
            _BTN_Schliessen.Size = new Size(80, 23);
            _BTN_Schliessen.TabIndex = 16;
            _BTN_Schliessen.Text = "Schließen";
            _BTN_Schliessen.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Schliessen.UseVisualStyleBackColor = true;
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
            TableAdapterManager.KonfigurationTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = null;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = null;
            TableAdapterManager.StaatenTableAdapter = null;
            TableAdapterManager.UpdateOrder = _WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // KonfigurationTableAdapter
            // 
            KonfigurationTableAdapter.ClearBeforeFill = true;
            // 
            // SachbearbeiterTableAdapter
            // 
            SachbearbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // TC_Administration
            // 
            TC_Administration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TC_Administration.Controls.Add(TabPage1);
            TC_Administration.Controls.Add(TabPage2);
            TC_Administration.Controls.Add(TabPage3);
            TC_Administration.Controls.Add(TabPage4);
            TC_Administration.Controls.Add(TabPage5);
            TC_Administration.Controls.Add(Belege);
            TC_Administration.Location = new Point(3, 70);
            TC_Administration.Name = "TC_Administration";
            TC_Administration.SelectedIndex = 0;
            TC_Administration.Size = new Size(1179, 400);
            TC_Administration.TabIndex = 30;
            // 
            // TabPage1
            // 
            TabPage1.AutoScroll = true;
            TabPage1.Controls.Add(HilfelinkLabel);
            TabPage1.Controls.Add(HilfelinkTextBox);
            TabPage1.Controls.Add(_BTN_DWPfad);
            TabPage1.Controls.Add(DWDateinameLabel);
            TabPage1.Controls.Add(DWDateinameTextBox);
            TabPage1.Controls.Add(DWpfadLabel);
            TabPage1.Controls.Add(DWpfadTextBox);
            TabPage1.Controls.Add(_BTN_Speichern);
            TabPage1.Controls.Add(VorlagenpfadLabel);
            TabPage1.Controls.Add(LeadnummerTextBox);
            TabPage1.Controls.Add(VorlagenpfadTextBox);
            TabPage1.Controls.Add(_BTN_Vorlagenpfad);
            TabPage1.Controls.Add(IDBesuchLabel);
            TabPage1.Controls.Add(IDFirmenNameTextBox);
            TabPage1.Controls.Add(IDBesuchTextBox);
            TabPage1.Controls.Add(IDFirmenNameLabel);
            TabPage1.Controls.Add(IDKontaktLabel);
            TabPage1.Controls.Add(LeadnummerLabel);
            TabPage1.Controls.Add(IDKontaktTextBox);
            TabPage1.Controls.Add(KundennummerTextBox);
            TabPage1.Controls.Add(IDAdresseLabel);
            TabPage1.Controls.Add(KundennummerLabel);
            TabPage1.Controls.Add(IDAdresseTextBox);
            TabPage1.Controls.Add(LieferantennummerTextBox);
            TabPage1.Controls.Add(LieferantennummerLabel);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(1171, 374);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "Konfiguration";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // HilfelinkTextBox
            // 
            HilfelinkTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "Hilfelink", true));
            HilfelinkTextBox.Location = new Point(113, 90);
            HilfelinkTextBox.Name = "HilfelinkTextBox";
            HilfelinkTextBox.Size = new Size(457, 20);
            HilfelinkTextBox.TabIndex = 24;
            // 
            // BTN_DWPfad
            // 
            _BTN_DWPfad.Image = My.Resources.Resources.DocumentsFolder_16x;
            _BTN_DWPfad.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_DWPfad.Location = new Point(576, 38);
            _BTN_DWPfad.Name = "_BTN_DWPfad";
            _BTN_DWPfad.Size = new Size(138, 23);
            _BTN_DWPfad.TabIndex = 22;
            _BTN_DWPfad.Text = "DW-Pfad ändern";
            _BTN_DWPfad.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_DWPfad.UseVisualStyleBackColor = true;
            // 
            // DWDateinameTextBox
            // 
            DWDateinameTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "DWDateiname", true));
            DWDateinameTextBox.Location = new Point(113, 64);
            DWDateinameTextBox.Name = "DWDateinameTextBox";
            DWDateinameTextBox.Size = new Size(230, 20);
            DWDateinameTextBox.TabIndex = 21;
            // 
            // DWpfadTextBox
            // 
            DWpfadTextBox.DataBindings.Add(new Binding("Text", KonfigurationBindingSource, "DWpfad", true));
            DWpfadTextBox.Location = new Point(113, 38);
            DWpfadTextBox.Name = "DWpfadTextBox";
            DWpfadTextBox.Size = new Size(457, 20);
            DWpfadTextBox.TabIndex = 19;
            // 
            // BTN_Speichern
            // 
            _BTN_Speichern.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Speichern.Image = (Image)resources.GetObject("BTN_Speichern.Image");
            _BTN_Speichern.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Speichern.Location = new Point(113, 298);
            _BTN_Speichern.Name = "_BTN_Speichern";
            _BTN_Speichern.Size = new Size(80, 23);
            _BTN_Speichern.TabIndex = 17;
            _BTN_Speichern.Text = "speichern";
            _BTN_Speichern.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Speichern.UseVisualStyleBackColor = true;
            // 
            // BTN_Vorlagenpfad
            // 
            _BTN_Vorlagenpfad.Image = My.Resources.Resources.DocumentsFolder_16x;
            _BTN_Vorlagenpfad.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Vorlagenpfad.Location = new Point(576, 10);
            _BTN_Vorlagenpfad.Name = "_BTN_Vorlagenpfad";
            _BTN_Vorlagenpfad.Size = new Size(138, 23);
            _BTN_Vorlagenpfad.TabIndex = 2;
            _BTN_Vorlagenpfad.Text = "Vorlagenpfad ändern";
            _BTN_Vorlagenpfad.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Vorlagenpfad.UseVisualStyleBackColor = true;
            // 
            // TabPage2
            // 
            TabPage2.AutoScroll = true;
            TabPage2.Controls.Add(InaktivLabel);
            TabPage2.Controls.Add(InaktivCheckBox);
            TabPage2.Controls.Add(BindingNavigator1);
            TabPage2.Controls.Add(ChangedLabel);
            TabPage2.Controls.Add(ChangedDateTimePicker);
            TabPage2.Controls.Add(LoginLabel);
            TabPage2.Controls.Add(LoginTextBox);
            TabPage2.Controls.Add(FirmenNameLabel);
            TabPage2.Controls.Add(FirmenNameTextBox);
            TabPage2.Controls.Add(IDFirmenNameLabel1);
            TabPage2.Controls.Add(IDFirmenNameTextBox1);
            TabPage2.Controls.Add(FirmenNameDataGridView);
            TabPage2.Location = new Point(4, 22);
            TabPage2.Name = "TabPage2";
            TabPage2.Padding = new Padding(3);
            TabPage2.Size = new Size(1171, 374);
            TabPage2.TabIndex = 1;
            TabPage2.Text = "FirmenName";
            TabPage2.UseVisualStyleBackColor = true;
            // 
            // InaktivCheckBox
            // 
            InaktivCheckBox.DataBindings.Add(new Binding("CheckState", FirmenNameBindingSource, "inaktiv", true));
            InaktivCheckBox.Location = new Point(98, 112);
            InaktivCheckBox.Name = "InaktivCheckBox";
            InaktivCheckBox.Size = new Size(200, 24);
            InaktivCheckBox.TabIndex = 11;
            InaktivCheckBox.Text = "Geschäftspartner deaktivieren";
            InaktivCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirmenNameBindingSource
            // 
            FirmenNameBindingSource.DataMember = "FirmenName";
            FirmenNameBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // BindingNavigator1
            // 
            BindingNavigator1.AddNewItem = ToolStripButton21;
            BindingNavigator1.BindingSource = FirmenNameBindingSource;
            BindingNavigator1.CountItem = ToolStripLabel4;
            BindingNavigator1.DeleteItem = ToolStripButton22;
            BindingNavigator1.Dock = DockStyle.Bottom;
            BindingNavigator1.Items.AddRange(new ToolStripItem[] { ToolStripButton23, ToolStripButton24, ToolStripSeparator10, ToolStripTextBox4, ToolStripLabel4, ToolStripSeparator11, ToolStripButton25, ToolStripButton26, ToolStripSeparator12, ToolStripButton21, ToolStripButton22, _BNAV_FirmenNameSave });
            BindingNavigator1.Location = new Point(3, 346);
            BindingNavigator1.MoveFirstItem = ToolStripButton23;
            BindingNavigator1.MoveLastItem = ToolStripButton26;
            BindingNavigator1.MoveNextItem = ToolStripButton25;
            BindingNavigator1.MovePreviousItem = ToolStripButton24;
            BindingNavigator1.Name = "BindingNavigator1";
            BindingNavigator1.PositionItem = ToolStripTextBox4;
            BindingNavigator1.Size = new Size(1165, 25);
            BindingNavigator1.TabIndex = 10;
            BindingNavigator1.Text = "BindingNavigator1";
            // 
            // ToolStripButton21
            // 
            ToolStripButton21.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton21.Image = (Image)resources.GetObject("ToolStripButton21.Image");
            ToolStripButton21.Name = "ToolStripButton21";
            ToolStripButton21.RightToLeftAutoMirrorImage = true;
            ToolStripButton21.Size = new Size(23, 22);
            ToolStripButton21.Text = "Neu hinzufügen";
            // 
            // ToolStripLabel4
            // 
            ToolStripLabel4.Name = "ToolStripLabel4";
            ToolStripLabel4.Size = new Size(44, 22);
            ToolStripLabel4.Text = "von {0}";
            ToolStripLabel4.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton22
            // 
            ToolStripButton22.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton22.Image = (Image)resources.GetObject("ToolStripButton22.Image");
            ToolStripButton22.Name = "ToolStripButton22";
            ToolStripButton22.RightToLeftAutoMirrorImage = true;
            ToolStripButton22.Size = new Size(23, 22);
            ToolStripButton22.Text = "Löschen";
            // 
            // ToolStripButton23
            // 
            ToolStripButton23.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton23.Image = (Image)resources.GetObject("ToolStripButton23.Image");
            ToolStripButton23.Name = "ToolStripButton23";
            ToolStripButton23.RightToLeftAutoMirrorImage = true;
            ToolStripButton23.Size = new Size(23, 22);
            ToolStripButton23.Text = "Erste verschieben";
            // 
            // ToolStripButton24
            // 
            ToolStripButton24.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton24.Image = (Image)resources.GetObject("ToolStripButton24.Image");
            ToolStripButton24.Name = "ToolStripButton24";
            ToolStripButton24.RightToLeftAutoMirrorImage = true;
            ToolStripButton24.Size = new Size(23, 22);
            ToolStripButton24.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator10
            // 
            ToolStripSeparator10.Name = "ToolStripSeparator10";
            ToolStripSeparator10.Size = new Size(6, 25);
            // 
            // ToolStripTextBox4
            // 
            ToolStripTextBox4.AccessibleName = "Position";
            ToolStripTextBox4.AutoSize = false;
            ToolStripTextBox4.Font = new Font("Segoe UI", 9.75f);
            ToolStripTextBox4.Name = "ToolStripTextBox4";
            ToolStripTextBox4.Size = new Size(50, 25);
            ToolStripTextBox4.Text = "0";
            ToolStripTextBox4.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator11
            // 
            ToolStripSeparator11.Name = "ToolStripSeparator11";
            ToolStripSeparator11.Size = new Size(6, 25);
            // 
            // ToolStripButton25
            // 
            ToolStripButton25.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton25.Image = (Image)resources.GetObject("ToolStripButton25.Image");
            ToolStripButton25.Name = "ToolStripButton25";
            ToolStripButton25.RightToLeftAutoMirrorImage = true;
            ToolStripButton25.Size = new Size(23, 22);
            ToolStripButton25.Text = "Nächste verschieben";
            // 
            // ToolStripButton26
            // 
            ToolStripButton26.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton26.Image = (Image)resources.GetObject("ToolStripButton26.Image");
            ToolStripButton26.Name = "ToolStripButton26";
            ToolStripButton26.RightToLeftAutoMirrorImage = true;
            ToolStripButton26.Size = new Size(23, 22);
            ToolStripButton26.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator12
            // 
            ToolStripSeparator12.Name = "ToolStripSeparator12";
            ToolStripSeparator12.Size = new Size(6, 25);
            // 
            // BNAV_FirmenNameSave
            // 
            _BNAV_FirmenNameSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BNAV_FirmenNameSave.Image = (Image)resources.GetObject("BNAV_FirmenNameSave.Image");
            _BNAV_FirmenNameSave.Name = "_BNAV_FirmenNameSave";
            _BNAV_FirmenNameSave.Size = new Size(23, 22);
            _BNAV_FirmenNameSave.Text = "Daten speichern";
            // 
            // ChangedDateTimePicker
            // 
            ChangedDateTimePicker.DataBindings.Add(new Binding("Value", FirmenNameBindingSource, "changed", true));
            ChangedDateTimePicker.Location = new Point(98, 86);
            ChangedDateTimePicker.Name = "ChangedDateTimePicker";
            ChangedDateTimePicker.Size = new Size(200, 20);
            ChangedDateTimePicker.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            LoginTextBox.DataBindings.Add(new Binding("Text", FirmenNameBindingSource, "Login", true));
            LoginTextBox.Location = new Point(98, 60);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(349, 20);
            LoginTextBox.TabIndex = 6;
            // 
            // FirmenNameTextBox
            // 
            FirmenNameTextBox.DataBindings.Add(new Binding("Text", FirmenNameBindingSource, "FirmenName", true));
            FirmenNameTextBox.Location = new Point(98, 34);
            FirmenNameTextBox.Name = "FirmenNameTextBox";
            FirmenNameTextBox.Size = new Size(349, 20);
            FirmenNameTextBox.TabIndex = 4;
            // 
            // IDFirmenNameTextBox1
            // 
            IDFirmenNameTextBox1.DataBindings.Add(new Binding("Text", FirmenNameBindingSource, "IDFirmenName", true));
            IDFirmenNameTextBox1.Location = new Point(98, 8);
            IDFirmenNameTextBox1.Name = "IDFirmenNameTextBox1";
            IDFirmenNameTextBox1.Size = new Size(349, 20);
            IDFirmenNameTextBox1.TabIndex = 2;
            // 
            // FirmenNameDataGridView
            // 
            FirmenNameDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FirmenNameDataGridView.AutoGenerateColumns = false;
            FirmenNameDataGridView.BackgroundColor = Color.White;
            FirmenNameDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FirmenNameDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, Login, changed, inaktiv });
            FirmenNameDataGridView.DataSource = FirmenNameBindingSource;
            FirmenNameDataGridView.Location = new Point(453, 6);
            FirmenNameDataGridView.Name = "FirmenNameDataGridView";
            FirmenNameDataGridView.RowHeadersVisible = false;
            FirmenNameDataGridView.ScrollBars = ScrollBars.Vertical;
            FirmenNameDataGridView.Size = new Size(653, 359);
            FirmenNameDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn1.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.Width = 80;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "FirmenName";
            DataGridViewTextBoxColumn2.HeaderText = "Firmen-Name";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.Width = 220;
            // 
            // Login
            // 
            Login.DataPropertyName = "Login";
            Login.HeaderText = "Login";
            Login.Name = "Login";
            Login.Width = 70;
            // 
            // changed
            // 
            changed.DataPropertyName = "changed";
            changed.HeaderText = "changed";
            changed.Name = "changed";
            changed.Width = 180;
            // 
            // inaktiv
            // 
            inaktiv.DataPropertyName = "inaktiv";
            inaktiv.HeaderText = "inaktiv";
            inaktiv.Name = "inaktiv";
            inaktiv.Width = 50;
            // 
            // TabPage3
            // 
            TabPage3.AutoScroll = true;
            TabPage3.Controls.Add(BindingNavigator2);
            TabPage3.Controls.Add(AnlageDatumLabel);
            TabPage3.Controls.Add(AnlageDatumDateTimePicker);
            TabPage3.Controls.Add(KontoNameLabel);
            TabPage3.Controls.Add(KontoNameTextBox);
            TabPage3.Controls.Add(IDFirmenNameLabel2);
            TabPage3.Controls.Add(IDFirmenNameTextBox2);
            TabPage3.Controls.Add(IDKontoLabel);
            TabPage3.Controls.Add(IDKontoTextBox);
            TabPage3.Controls.Add(KontoDataGridView);
            TabPage3.Location = new Point(4, 22);
            TabPage3.Name = "TabPage3";
            TabPage3.Padding = new Padding(3);
            TabPage3.Size = new Size(1171, 374);
            TabPage3.TabIndex = 2;
            TabPage3.Text = "Konto";
            TabPage3.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator2
            // 
            BindingNavigator2.AddNewItem = ToolStripButton14;
            BindingNavigator2.BindingSource = KontoBindingSource;
            BindingNavigator2.CountItem = ToolStripLabel3;
            BindingNavigator2.DeleteItem = ToolStripButton15;
            BindingNavigator2.Dock = DockStyle.Bottom;
            BindingNavigator2.Items.AddRange(new ToolStripItem[] { ToolStripButton16, ToolStripButton17, ToolStripSeparator7, ToolStripTextBox3, ToolStripLabel3, ToolStripSeparator8, ToolStripButton18, ToolStripButton19, ToolStripSeparator9, ToolStripButton14, ToolStripButton15, _BNAV_KontoSave });
            BindingNavigator2.Location = new Point(3, 346);
            BindingNavigator2.MoveFirstItem = ToolStripButton16;
            BindingNavigator2.MoveLastItem = ToolStripButton19;
            BindingNavigator2.MoveNextItem = ToolStripButton18;
            BindingNavigator2.MovePreviousItem = ToolStripButton17;
            BindingNavigator2.Name = "BindingNavigator2";
            BindingNavigator2.PositionItem = ToolStripTextBox3;
            BindingNavigator2.Size = new Size(1165, 25);
            BindingNavigator2.TabIndex = 9;
            BindingNavigator2.Text = "BindingNavigator1";
            // 
            // ToolStripButton14
            // 
            ToolStripButton14.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton14.Image = (Image)resources.GetObject("ToolStripButton14.Image");
            ToolStripButton14.Name = "ToolStripButton14";
            ToolStripButton14.RightToLeftAutoMirrorImage = true;
            ToolStripButton14.Size = new Size(23, 22);
            ToolStripButton14.Text = "Neu hinzufügen";
            // 
            // KontoBindingSource
            // 
            KontoBindingSource.DataMember = "Konto";
            KontoBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // ToolStripLabel3
            // 
            ToolStripLabel3.Name = "ToolStripLabel3";
            ToolStripLabel3.Size = new Size(44, 22);
            ToolStripLabel3.Text = "von {0}";
            ToolStripLabel3.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton15
            // 
            ToolStripButton15.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton15.Image = (Image)resources.GetObject("ToolStripButton15.Image");
            ToolStripButton15.Name = "ToolStripButton15";
            ToolStripButton15.RightToLeftAutoMirrorImage = true;
            ToolStripButton15.Size = new Size(23, 22);
            ToolStripButton15.Text = "Löschen";
            // 
            // ToolStripButton16
            // 
            ToolStripButton16.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton16.Image = (Image)resources.GetObject("ToolStripButton16.Image");
            ToolStripButton16.Name = "ToolStripButton16";
            ToolStripButton16.RightToLeftAutoMirrorImage = true;
            ToolStripButton16.Size = new Size(23, 22);
            ToolStripButton16.Text = "Erste verschieben";
            // 
            // ToolStripButton17
            // 
            ToolStripButton17.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton17.Image = (Image)resources.GetObject("ToolStripButton17.Image");
            ToolStripButton17.Name = "ToolStripButton17";
            ToolStripButton17.RightToLeftAutoMirrorImage = true;
            ToolStripButton17.Size = new Size(23, 22);
            ToolStripButton17.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator7
            // 
            ToolStripSeparator7.Name = "ToolStripSeparator7";
            ToolStripSeparator7.Size = new Size(6, 25);
            // 
            // ToolStripTextBox3
            // 
            ToolStripTextBox3.AccessibleName = "Position";
            ToolStripTextBox3.AutoSize = false;
            ToolStripTextBox3.Font = new Font("Segoe UI", 9.75f);
            ToolStripTextBox3.Name = "ToolStripTextBox3";
            ToolStripTextBox3.Size = new Size(50, 25);
            ToolStripTextBox3.Text = "0";
            ToolStripTextBox3.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator8
            // 
            ToolStripSeparator8.Name = "ToolStripSeparator8";
            ToolStripSeparator8.Size = new Size(6, 25);
            // 
            // ToolStripButton18
            // 
            ToolStripButton18.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton18.Image = (Image)resources.GetObject("ToolStripButton18.Image");
            ToolStripButton18.Name = "ToolStripButton18";
            ToolStripButton18.RightToLeftAutoMirrorImage = true;
            ToolStripButton18.Size = new Size(23, 22);
            ToolStripButton18.Text = "Nächste verschieben";
            // 
            // ToolStripButton19
            // 
            ToolStripButton19.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton19.Image = (Image)resources.GetObject("ToolStripButton19.Image");
            ToolStripButton19.Name = "ToolStripButton19";
            ToolStripButton19.RightToLeftAutoMirrorImage = true;
            ToolStripButton19.Size = new Size(23, 22);
            ToolStripButton19.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator9
            // 
            ToolStripSeparator9.Name = "ToolStripSeparator9";
            ToolStripSeparator9.Size = new Size(6, 25);
            // 
            // BNAV_KontoSave
            // 
            _BNAV_KontoSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BNAV_KontoSave.Image = (Image)resources.GetObject("BNAV_KontoSave.Image");
            _BNAV_KontoSave.Name = "_BNAV_KontoSave";
            _BNAV_KontoSave.Size = new Size(23, 22);
            _BNAV_KontoSave.Text = "Daten speichern";
            // 
            // AnlageDatumDateTimePicker
            // 
            AnlageDatumDateTimePicker.DataBindings.Add(new Binding("Value", KontoBindingSource, "Datum", true));
            AnlageDatumDateTimePicker.Location = new Point(696, 85);
            AnlageDatumDateTimePicker.Name = "AnlageDatumDateTimePicker";
            AnlageDatumDateTimePicker.Size = new Size(200, 20);
            AnlageDatumDateTimePicker.TabIndex = 8;
            // 
            // KontoNameTextBox
            // 
            KontoNameTextBox.DataBindings.Add(new Binding("Text", KontoBindingSource, "KontoName", true));
            KontoNameTextBox.Location = new Point(696, 59);
            KontoNameTextBox.Name = "KontoNameTextBox";
            KontoNameTextBox.Size = new Size(100, 20);
            KontoNameTextBox.TabIndex = 6;
            // 
            // IDFirmenNameTextBox2
            // 
            IDFirmenNameTextBox2.DataBindings.Add(new Binding("Text", KontoBindingSource, "IDFirmenName", true));
            IDFirmenNameTextBox2.Location = new Point(696, 33);
            IDFirmenNameTextBox2.Name = "IDFirmenNameTextBox2";
            IDFirmenNameTextBox2.Size = new Size(100, 20);
            IDFirmenNameTextBox2.TabIndex = 4;
            // 
            // IDKontoTextBox
            // 
            IDKontoTextBox.DataBindings.Add(new Binding("Text", KontoBindingSource, "IDKonto", true));
            IDKontoTextBox.Location = new Point(696, 7);
            IDKontoTextBox.Name = "IDKontoTextBox";
            IDKontoTextBox.Size = new Size(100, 20);
            IDKontoTextBox.TabIndex = 2;
            // 
            // KontoDataGridView
            // 
            KontoDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            KontoDataGridView.AutoGenerateColumns = false;
            KontoDataGridView.BackgroundColor = Color.White;
            KontoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KontoDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, Datum });
            KontoDataGridView.DataSource = KontoBindingSource;
            KontoDataGridView.GridColor = SystemColors.AppWorkspace;
            KontoDataGridView.Location = new Point(7, 6);
            KontoDataGridView.Name = "KontoDataGridView";
            KontoDataGridView.RowHeadersVisible = false;
            KontoDataGridView.ScrollBars = ScrollBars.Vertical;
            KontoDataGridView.Size = new Size(472, 395);
            KontoDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto";
            DataGridViewTextBoxColumn3.HeaderText = "IDKonto";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.Width = 70;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "KontoName";
            DataGridViewTextBoxColumn5.HeaderText = "KontoName";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // Datum
            // 
            Datum.DataPropertyName = "Datum";
            Datum.HeaderText = "Datum";
            Datum.Name = "Datum";
            // 
            // TabPage4
            // 
            TabPage4.AutoScroll = true;
            TabPage4.Controls.Add(BindingNavigator3);
            TabPage4.Controls.Add(WebseiteLabel);
            TabPage4.Controls.Add(WebseiteTextBox);
            TabPage4.Controls.Add(UStIdNrLabel);
            TabPage4.Controls.Add(UStIdNrTextBox);
            TabPage4.Controls.Add(LandLabel);
            TabPage4.Controls.Add(LandTextBox);
            TabPage4.Controls.Add(BundeslandLabel);
            TabPage4.Controls.Add(BundeslandTextBox);
            TabPage4.Controls.Add(OrtLabel);
            TabPage4.Controls.Add(OrtTextBox);
            TabPage4.Controls.Add(PLZLabel);
            TabPage4.Controls.Add(PLZTextBox);
            TabPage4.Controls.Add(PostfachLabel);
            TabPage4.Controls.Add(PostfachTextBox);
            TabPage4.Controls.Add(StraßeLabel);
            TabPage4.Controls.Add(StraßeTextBox);
            TabPage4.Controls.Add(AdresstypLabel);
            TabPage4.Controls.Add(AdresstypTextBox);
            TabPage4.Controls.Add(IDKontoLabel1);
            TabPage4.Controls.Add(IDKontoTextBox1);
            TabPage4.Controls.Add(IDFirmenNameLabel3);
            TabPage4.Controls.Add(IDFirmenNameTextBox3);
            TabPage4.Controls.Add(IDAdresseLabel1);
            TabPage4.Controls.Add(IDAdresseTextBox1);
            TabPage4.Controls.Add(DataGridView1);
            TabPage4.Location = new Point(4, 22);
            TabPage4.Name = "TabPage4";
            TabPage4.Padding = new Padding(3);
            TabPage4.Size = new Size(1171, 374);
            TabPage4.TabIndex = 3;
            TabPage4.Text = "Adressen";
            TabPage4.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator3
            // 
            BindingNavigator3.AddNewItem = ToolStripButton7;
            BindingNavigator3.BindingSource = AdressenBindingSource;
            BindingNavigator3.CountItem = ToolStripLabel2;
            BindingNavigator3.DeleteItem = ToolStripButton8;
            BindingNavigator3.Dock = DockStyle.Bottom;
            BindingNavigator3.Items.AddRange(new ToolStripItem[] { ToolStripButton9, ToolStripButton10, ToolStripSeparator4, ToolStripTextBox2, ToolStripLabel2, ToolStripSeparator5, ToolStripButton11, ToolStripButton12, ToolStripSeparator6, ToolStripButton7, ToolStripButton8, _BNAV_AdressenSave });
            BindingNavigator3.Location = new Point(3, 346);
            BindingNavigator3.MoveFirstItem = ToolStripButton9;
            BindingNavigator3.MoveLastItem = ToolStripButton12;
            BindingNavigator3.MoveNextItem = ToolStripButton11;
            BindingNavigator3.MovePreviousItem = ToolStripButton10;
            BindingNavigator3.Name = "BindingNavigator3";
            BindingNavigator3.PositionItem = ToolStripTextBox2;
            BindingNavigator3.Size = new Size(1165, 25);
            BindingNavigator3.TabIndex = 25;
            BindingNavigator3.Text = "BindingNavigator1";
            // 
            // ToolStripButton7
            // 
            ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton7.Image = (Image)resources.GetObject("ToolStripButton7.Image");
            ToolStripButton7.Name = "ToolStripButton7";
            ToolStripButton7.RightToLeftAutoMirrorImage = true;
            ToolStripButton7.Size = new Size(23, 22);
            ToolStripButton7.Text = "Neu hinzufügen";
            // 
            // AdressenBindingSource
            // 
            AdressenBindingSource.DataMember = "Adressen";
            AdressenBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // ToolStripLabel2
            // 
            ToolStripLabel2.Name = "ToolStripLabel2";
            ToolStripLabel2.Size = new Size(44, 22);
            ToolStripLabel2.Text = "von {0}";
            ToolStripLabel2.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton8
            // 
            ToolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton8.Image = (Image)resources.GetObject("ToolStripButton8.Image");
            ToolStripButton8.Name = "ToolStripButton8";
            ToolStripButton8.RightToLeftAutoMirrorImage = true;
            ToolStripButton8.Size = new Size(23, 22);
            ToolStripButton8.Text = "Löschen";
            // 
            // ToolStripButton9
            // 
            ToolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton9.Image = (Image)resources.GetObject("ToolStripButton9.Image");
            ToolStripButton9.Name = "ToolStripButton9";
            ToolStripButton9.RightToLeftAutoMirrorImage = true;
            ToolStripButton9.Size = new Size(23, 22);
            ToolStripButton9.Text = "Erste verschieben";
            // 
            // ToolStripButton10
            // 
            ToolStripButton10.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton10.Image = (Image)resources.GetObject("ToolStripButton10.Image");
            ToolStripButton10.Name = "ToolStripButton10";
            ToolStripButton10.RightToLeftAutoMirrorImage = true;
            ToolStripButton10.Size = new Size(23, 22);
            ToolStripButton10.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator4
            // 
            ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator4.Size = new Size(6, 25);
            // 
            // ToolStripTextBox2
            // 
            ToolStripTextBox2.AccessibleName = "Position";
            ToolStripTextBox2.AutoSize = false;
            ToolStripTextBox2.Font = new Font("Segoe UI", 9.75f);
            ToolStripTextBox2.Name = "ToolStripTextBox2";
            ToolStripTextBox2.Size = new Size(50, 25);
            ToolStripTextBox2.Text = "0";
            ToolStripTextBox2.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator5
            // 
            ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator5.Size = new Size(6, 25);
            // 
            // ToolStripButton11
            // 
            ToolStripButton11.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton11.Image = (Image)resources.GetObject("ToolStripButton11.Image");
            ToolStripButton11.Name = "ToolStripButton11";
            ToolStripButton11.RightToLeftAutoMirrorImage = true;
            ToolStripButton11.Size = new Size(23, 22);
            ToolStripButton11.Text = "Nächste verschieben";
            // 
            // ToolStripButton12
            // 
            ToolStripButton12.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton12.Image = (Image)resources.GetObject("ToolStripButton12.Image");
            ToolStripButton12.Name = "ToolStripButton12";
            ToolStripButton12.RightToLeftAutoMirrorImage = true;
            ToolStripButton12.Size = new Size(23, 22);
            ToolStripButton12.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator6
            // 
            ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator6.Size = new Size(6, 25);
            // 
            // BNAV_AdressenSave
            // 
            _BNAV_AdressenSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BNAV_AdressenSave.Image = (Image)resources.GetObject("BNAV_AdressenSave.Image");
            _BNAV_AdressenSave.Name = "_BNAV_AdressenSave";
            _BNAV_AdressenSave.Size = new Size(23, 22);
            _BNAV_AdressenSave.Text = "Daten speichern";
            // 
            // WebseiteTextBox
            // 
            WebseiteTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Webseite", true));
            WebseiteTextBox.Location = new Point(795, 32);
            WebseiteTextBox.Name = "WebseiteTextBox";
            WebseiteTextBox.Size = new Size(257, 20);
            WebseiteTextBox.TabIndex = 24;
            // 
            // UStIdNrTextBox
            // 
            UStIdNrTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "UStIdNr", true));
            UStIdNrTextBox.Location = new Point(268, 30);
            UStIdNrTextBox.Name = "UStIdNrTextBox";
            UStIdNrTextBox.Size = new Size(100, 20);
            UStIdNrTextBox.TabIndex = 22;
            // 
            // LandTextBox
            // 
            LandTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Land", true));
            LandTextBox.Location = new Point(951, 6);
            LandTextBox.Name = "LandTextBox";
            LandTextBox.Size = new Size(100, 20);
            LandTextBox.TabIndex = 20;
            // 
            // BundeslandTextBox
            // 
            BundeslandTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Bundesland", true));
            BundeslandTextBox.Location = new Point(795, 6);
            BundeslandTextBox.Name = "BundeslandTextBox";
            BundeslandTextBox.Size = new Size(100, 20);
            BundeslandTextBox.TabIndex = 18;
            // 
            // OrtTextBox
            // 
            OrtTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Ort", true));
            OrtTextBox.Location = new Point(572, 56);
            OrtTextBox.Name = "OrtTextBox";
            OrtTextBox.Size = new Size(140, 20);
            OrtTextBox.TabIndex = 16;
            // 
            // PLZTextBox
            // 
            PLZTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "PLZ", true));
            PLZTextBox.Location = new Point(454, 56);
            PLZTextBox.Name = "PLZTextBox";
            PLZTextBox.Size = new Size(67, 20);
            PLZTextBox.TabIndex = 14;
            // 
            // PostfachTextBox
            // 
            PostfachTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Postfach", true));
            PostfachTextBox.Location = new Point(454, 5);
            PostfachTextBox.Name = "PostfachTextBox";
            PostfachTextBox.Size = new Size(100, 20);
            PostfachTextBox.TabIndex = 12;
            // 
            // StraßeTextBox
            // 
            StraßeTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Straße", true));
            StraßeTextBox.Location = new Point(454, 30);
            StraßeTextBox.Name = "StraßeTextBox";
            StraßeTextBox.Size = new Size(258, 20);
            StraßeTextBox.TabIndex = 10;
            // 
            // AdresstypTextBox
            // 
            AdresstypTextBox.DataBindings.Add(new Binding("Text", AdressenBindingSource, "Adresstyp", true));
            AdresstypTextBox.Location = new Point(268, 4);
            AdresstypTextBox.Name = "AdresstypTextBox";
            AdresstypTextBox.Size = new Size(100, 20);
            AdresstypTextBox.TabIndex = 8;
            // 
            // IDKontoTextBox1
            // 
            IDKontoTextBox1.DataBindings.Add(new Binding("Text", AdressenBindingSource, "IDKonto", true));
            IDKontoTextBox1.Location = new Point(92, 30);
            IDKontoTextBox1.Name = "IDKontoTextBox1";
            IDKontoTextBox1.Size = new Size(100, 20);
            IDKontoTextBox1.TabIndex = 6;
            // 
            // IDFirmenNameTextBox3
            // 
            IDFirmenNameTextBox3.DataBindings.Add(new Binding("Text", AdressenBindingSource, "IDFirmenName", true));
            IDFirmenNameTextBox3.Location = new Point(92, 55);
            IDFirmenNameTextBox3.Name = "IDFirmenNameTextBox3";
            IDFirmenNameTextBox3.Size = new Size(100, 20);
            IDFirmenNameTextBox3.TabIndex = 4;
            // 
            // IDAdresseTextBox1
            // 
            IDAdresseTextBox1.DataBindings.Add(new Binding("Text", AdressenBindingSource, "IDAdresse", true));
            IDAdresseTextBox1.Location = new Point(92, 4);
            IDAdresseTextBox1.Name = "IDAdresseTextBox1";
            IDAdresseTextBox1.Size = new Size(100, 20);
            IDAdresseTextBox1.TabIndex = 2;
            // 
            // DataGridView1
            // 
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DataGridView1.AutoGenerateColumns = false;
            DataGridView1.BackgroundColor = Color.White;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { IDAdresse, DataGridViewTextBoxColumn7, IDKonto, Adresstyp, Straße, Postfach, PLZ, Ort, Bundesland, Land, UStIdNr, Webseite });
            DataGridView1.DataSource = AdressenBindingSource;
            DataGridView1.GridColor = SystemColors.AppWorkspace;
            DataGridView1.Location = new Point(7, 98);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.ScrollBars = ScrollBars.Vertical;
            DataGridView1.Size = new Size(1156, 245);
            DataGridView1.TabIndex = 1;
            // 
            // IDAdresse
            // 
            IDAdresse.DataPropertyName = "IDAdresse";
            IDAdresse.HeaderText = "IDAdresse";
            IDAdresse.Name = "IDAdresse";
            IDAdresse.Width = 70;
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn7.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            DataGridViewTextBoxColumn7.Width = 70;
            // 
            // IDKonto
            // 
            IDKonto.DataPropertyName = "IDKonto";
            IDKonto.HeaderText = "IDKonto";
            IDKonto.Name = "IDKonto";
            IDKonto.Width = 70;
            // 
            // Adresstyp
            // 
            Adresstyp.DataPropertyName = "Adresstyp";
            Adresstyp.HeaderText = "Adresstyp";
            Adresstyp.Name = "Adresstyp";
            // 
            // Straße
            // 
            Straße.DataPropertyName = "Straße";
            Straße.HeaderText = "Straße";
            Straße.Name = "Straße";
            // 
            // Postfach
            // 
            Postfach.DataPropertyName = "Postfach";
            Postfach.HeaderText = "Postfach";
            Postfach.Name = "Postfach";
            // 
            // PLZ
            // 
            PLZ.DataPropertyName = "PLZ";
            PLZ.HeaderText = "PLZ";
            PLZ.Name = "PLZ";
            PLZ.Width = 50;
            // 
            // Ort
            // 
            Ort.DataPropertyName = "Ort";
            Ort.HeaderText = "Ort";
            Ort.Name = "Ort";
            // 
            // Bundesland
            // 
            Bundesland.DataPropertyName = "Bundesland";
            Bundesland.HeaderText = "Bundesland";
            Bundesland.Name = "Bundesland";
            // 
            // Land
            // 
            Land.DataPropertyName = "Land";
            Land.HeaderText = "Land";
            Land.Name = "Land";
            // 
            // UStIdNr
            // 
            UStIdNr.DataPropertyName = "UStIdNr";
            UStIdNr.HeaderText = "UStIdNr";
            UStIdNr.Name = "UStIdNr";
            // 
            // Webseite
            // 
            Webseite.DataPropertyName = "Webseite";
            Webseite.HeaderText = "Webseite";
            Webseite.Name = "Webseite";
            // 
            // TabPage5
            // 
            TabPage5.AutoScroll = true;
            TabPage5.Controls.Add(SachbearbeiterBindingNavigator);
            TabPage5.Controls.Add(IDAdresseLabel2);
            TabPage5.Controls.Add(IDAdresseTextBox2);
            TabPage5.Controls.Add(FaxnummerLabel);
            TabPage5.Controls.Add(FaxnummerTextBox);
            TabPage5.Controls.Add(MobiltelefonLabel);
            TabPage5.Controls.Add(MobiltelefonTextBox);
            TabPage5.Controls.Add(TelefonPrivatLabel);
            TabPage5.Controls.Add(TelefonPrivatTextBox);
            TabPage5.Controls.Add(TelefonGeschaeftlichLabel);
            TabPage5.Controls.Add(TelefonGeschaeftlichTextBox);
            TabPage5.Controls.Add(JobtitleLabel);
            TabPage5.Controls.Add(JobtitleTextBox);
            TabPage5.Controls.Add(EmailAddresseLabel);
            TabPage5.Controls.Add(EmailAddresseTextBox);
            TabPage5.Controls.Add(AnredeLabel);
            TabPage5.Controls.Add(AnredeTextBox);
            TabPage5.Controls.Add(NachnameLabel);
            TabPage5.Controls.Add(NachnameTextBox);
            TabPage5.Controls.Add(VornameLabel);
            TabPage5.Controls.Add(VornameTextBox);
            TabPage5.Controls.Add(IDFirmenNameLabel4);
            TabPage5.Controls.Add(IDFirmenNameTextBox4);
            TabPage5.Controls.Add(IDKontaktLabel1);
            TabPage5.Controls.Add(IDKontaktTextBox1);
            TabPage5.Controls.Add(DataGridView2);
            TabPage5.Location = new Point(4, 22);
            TabPage5.Name = "TabPage5";
            TabPage5.Padding = new Padding(3);
            TabPage5.Size = new Size(1171, 374);
            TabPage5.TabIndex = 4;
            TabPage5.Text = "Kontakte";
            TabPage5.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterBindingNavigator
            // 
            SachbearbeiterBindingNavigator.AddNewItem = ToolStripButton1;
            SachbearbeiterBindingNavigator.BindingSource = KontakteBindingSource;
            SachbearbeiterBindingNavigator.CountItem = ToolStripLabel1;
            SachbearbeiterBindingNavigator.DeleteItem = ToolStripButton2;
            SachbearbeiterBindingNavigator.Dock = DockStyle.Bottom;
            SachbearbeiterBindingNavigator.Items.AddRange(new ToolStripItem[] { ToolStripButton3, ToolStripButton4, ToolStripSeparator1, ToolStripTextBox1, ToolStripLabel1, ToolStripSeparator2, ToolStripButton5, ToolStripButton6, ToolStripSeparator3, ToolStripButton1, ToolStripButton2, _BNAV_KontakteSave });
            SachbearbeiterBindingNavigator.Location = new Point(3, 346);
            SachbearbeiterBindingNavigator.MoveFirstItem = ToolStripButton3;
            SachbearbeiterBindingNavigator.MoveLastItem = ToolStripButton6;
            SachbearbeiterBindingNavigator.MoveNextItem = ToolStripButton5;
            SachbearbeiterBindingNavigator.MovePreviousItem = ToolStripButton4;
            SachbearbeiterBindingNavigator.Name = "SachbearbeiterBindingNavigator";
            SachbearbeiterBindingNavigator.PositionItem = ToolStripTextBox1;
            SachbearbeiterBindingNavigator.Size = new Size(1165, 25);
            SachbearbeiterBindingNavigator.TabIndex = 25;
            SachbearbeiterBindingNavigator.Text = "BindingNavigator1";
            // 
            // ToolStripButton1
            // 
            ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton1.Image = (Image)resources.GetObject("ToolStripButton1.Image");
            ToolStripButton1.Name = "ToolStripButton1";
            ToolStripButton1.RightToLeftAutoMirrorImage = true;
            ToolStripButton1.Size = new Size(23, 22);
            ToolStripButton1.Text = "Neu hinzufügen";
            // 
            // KontakteBindingSource
            // 
            KontakteBindingSource.DataMember = "Kontakte";
            KontakteBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // ToolStripLabel1
            // 
            ToolStripLabel1.Name = "ToolStripLabel1";
            ToolStripLabel1.Size = new Size(44, 22);
            ToolStripLabel1.Text = "von {0}";
            ToolStripLabel1.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton2
            // 
            ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton2.Image = (Image)resources.GetObject("ToolStripButton2.Image");
            ToolStripButton2.Name = "ToolStripButton2";
            ToolStripButton2.RightToLeftAutoMirrorImage = true;
            ToolStripButton2.Size = new Size(23, 22);
            ToolStripButton2.Text = "Löschen";
            // 
            // ToolStripButton3
            // 
            ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton3.Image = (Image)resources.GetObject("ToolStripButton3.Image");
            ToolStripButton3.Name = "ToolStripButton3";
            ToolStripButton3.RightToLeftAutoMirrorImage = true;
            ToolStripButton3.Size = new Size(23, 22);
            ToolStripButton3.Text = "Erste verschieben";
            // 
            // ToolStripButton4
            // 
            ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton4.Image = (Image)resources.GetObject("ToolStripButton4.Image");
            ToolStripButton4.Name = "ToolStripButton4";
            ToolStripButton4.RightToLeftAutoMirrorImage = true;
            ToolStripButton4.Size = new Size(23, 22);
            ToolStripButton4.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(6, 25);
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.AccessibleName = "Position";
            ToolStripTextBox1.AutoSize = false;
            ToolStripTextBox1.Font = new Font("Segoe UI", 9.75f);
            ToolStripTextBox1.Name = "ToolStripTextBox1";
            ToolStripTextBox1.Size = new Size(50, 25);
            ToolStripTextBox1.Text = "0";
            ToolStripTextBox1.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(6, 25);
            // 
            // ToolStripButton5
            // 
            ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton5.Image = (Image)resources.GetObject("ToolStripButton5.Image");
            ToolStripButton5.Name = "ToolStripButton5";
            ToolStripButton5.RightToLeftAutoMirrorImage = true;
            ToolStripButton5.Size = new Size(23, 22);
            ToolStripButton5.Text = "Nächste verschieben";
            // 
            // ToolStripButton6
            // 
            ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton6.Image = (Image)resources.GetObject("ToolStripButton6.Image");
            ToolStripButton6.Name = "ToolStripButton6";
            ToolStripButton6.RightToLeftAutoMirrorImage = true;
            ToolStripButton6.Size = new Size(23, 22);
            ToolStripButton6.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator3
            // 
            ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator3.Size = new Size(6, 25);
            // 
            // BNAV_KontakteSave
            // 
            _BNAV_KontakteSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BNAV_KontakteSave.Image = (Image)resources.GetObject("BNAV_KontakteSave.Image");
            _BNAV_KontakteSave.Name = "_BNAV_KontakteSave";
            _BNAV_KontakteSave.Size = new Size(23, 22);
            _BNAV_KontakteSave.Text = "Daten speichern";
            // 
            // IDAdresseTextBox2
            // 
            IDAdresseTextBox2.DataBindings.Add(new Binding("Text", KontakteBindingSource, "IDAdresse", true));
            IDAdresseTextBox2.Location = new Point(94, 58);
            IDAdresseTextBox2.Name = "IDAdresseTextBox2";
            IDAdresseTextBox2.Size = new Size(100, 20);
            IDAdresseTextBox2.TabIndex = 24;
            // 
            // FaxnummerTextBox
            // 
            FaxnummerTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Faxnummer", true));
            FaxnummerTextBox.Location = new Point(715, 83);
            FaxnummerTextBox.Name = "FaxnummerTextBox";
            FaxnummerTextBox.Size = new Size(100, 20);
            FaxnummerTextBox.TabIndex = 22;
            // 
            // MobiltelefonTextBox
            // 
            MobiltelefonTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Mobiltelefon", true));
            MobiltelefonTextBox.Location = new Point(715, 57);
            MobiltelefonTextBox.Name = "MobiltelefonTextBox";
            MobiltelefonTextBox.Size = new Size(100, 20);
            MobiltelefonTextBox.TabIndex = 20;
            // 
            // TelefonPrivatTextBox
            // 
            TelefonPrivatTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "TelefonPrivat", true));
            TelefonPrivatTextBox.Location = new Point(715, 31);
            TelefonPrivatTextBox.Name = "TelefonPrivatTextBox";
            TelefonPrivatTextBox.Size = new Size(100, 20);
            TelefonPrivatTextBox.TabIndex = 18;
            // 
            // TelefonGeschaeftlichTextBox
            // 
            TelefonGeschaeftlichTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "TelefonGeschaeftlich", true));
            TelefonGeschaeftlichTextBox.Location = new Point(715, 5);
            TelefonGeschaeftlichTextBox.Name = "TelefonGeschaeftlichTextBox";
            TelefonGeschaeftlichTextBox.Size = new Size(100, 20);
            TelefonGeschaeftlichTextBox.TabIndex = 16;
            // 
            // JobtitleTextBox
            // 
            JobtitleTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Jobtitle", true));
            JobtitleTextBox.Location = new Point(484, 6);
            JobtitleTextBox.Name = "JobtitleTextBox";
            JobtitleTextBox.Size = new Size(100, 20);
            JobtitleTextBox.TabIndex = 14;
            // 
            // EmailAddresseTextBox
            // 
            EmailAddresseTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "EmailAddresse", true));
            EmailAddresseTextBox.Location = new Point(484, 32);
            EmailAddresseTextBox.Name = "EmailAddresseTextBox";
            EmailAddresseTextBox.Size = new Size(100, 20);
            EmailAddresseTextBox.TabIndex = 12;
            // 
            // AnredeTextBox
            // 
            AnredeTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Anrede", true));
            AnredeTextBox.Location = new Point(285, 6);
            AnredeTextBox.Name = "AnredeTextBox";
            AnredeTextBox.Size = new Size(100, 20);
            AnredeTextBox.TabIndex = 10;
            // 
            // NachnameTextBox
            // 
            NachnameTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Nachname", true));
            NachnameTextBox.Location = new Point(285, 31);
            NachnameTextBox.Name = "NachnameTextBox";
            NachnameTextBox.Size = new Size(100, 20);
            NachnameTextBox.TabIndex = 8;
            // 
            // VornameTextBox
            // 
            VornameTextBox.DataBindings.Add(new Binding("Text", KontakteBindingSource, "Vorname", true));
            VornameTextBox.Location = new Point(285, 57);
            VornameTextBox.Name = "VornameTextBox";
            VornameTextBox.Size = new Size(100, 20);
            VornameTextBox.TabIndex = 6;
            // 
            // IDFirmenNameTextBox4
            // 
            IDFirmenNameTextBox4.DataBindings.Add(new Binding("Text", KontakteBindingSource, "IDFirmenName", true));
            IDFirmenNameTextBox4.Location = new Point(94, 32);
            IDFirmenNameTextBox4.Name = "IDFirmenNameTextBox4";
            IDFirmenNameTextBox4.Size = new Size(100, 20);
            IDFirmenNameTextBox4.TabIndex = 4;
            // 
            // IDKontaktTextBox1
            // 
            IDKontaktTextBox1.DataBindings.Add(new Binding("Text", KontakteBindingSource, "IDKontakt", true));
            IDKontaktTextBox1.Location = new Point(94, 6);
            IDKontaktTextBox1.Name = "IDKontaktTextBox1";
            IDKontaktTextBox1.Size = new Size(100, 20);
            IDKontaktTextBox1.TabIndex = 3;
            // 
            // DataGridView2
            // 
            DataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            DataGridView2.AutoGenerateColumns = false;
            DataGridView2.BackgroundColor = Color.White;
            DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView2.Columns.AddRange(new DataGridViewColumn[] { IDKontakt, IDFirmenName, Nachname, Vorname, EmailAddresseDataGridViewTextBoxColumn, JobtitleDataGridViewTextBoxColumn, TelefonGeschaeftlichDataGridViewTextBoxColumn, TelefonPrivatDataGridViewTextBoxColumn, MobiltelefonDataGridViewTextBoxColumn, FaxnummerDataGridViewTextBoxColumn, IDAdresseDataGridViewTextBoxColumn, AnredeDataGridViewTextBoxColumn });
            DataGridView2.DataSource = KontakteBindingSource;
            DataGridView2.GridColor = SystemColors.AppWorkspace;
            DataGridView2.Location = new Point(7, 109);
            DataGridView2.Name = "DataGridView2";
            DataGridView2.RowHeadersVisible = false;
            DataGridView2.ScrollBars = ScrollBars.Vertical;
            DataGridView2.Size = new Size(1158, 234);
            DataGridView2.TabIndex = 2;
            // 
            // IDKontakt
            // 
            IDKontakt.DataPropertyName = "IDKontakt";
            IDKontakt.HeaderText = "IDKontakt";
            IDKontakt.Name = "IDKontakt";
            IDKontakt.Width = 70;
            // 
            // IDFirmenName
            // 
            IDFirmenName.DataPropertyName = "IDFirmenName";
            IDFirmenName.HeaderText = "IDFirmenName";
            IDFirmenName.Name = "IDFirmenName";
            IDFirmenName.Width = 80;
            // 
            // Nachname
            // 
            Nachname.DataPropertyName = "Nachname";
            Nachname.HeaderText = "Nachname";
            Nachname.Name = "Nachname";
            Nachname.Width = 90;
            // 
            // Vorname
            // 
            Vorname.DataPropertyName = "Vorname";
            Vorname.HeaderText = "Vorname";
            Vorname.Name = "Vorname";
            Vorname.Width = 90;
            // 
            // EmailAddresseDataGridViewTextBoxColumn
            // 
            EmailAddresseDataGridViewTextBoxColumn.DataPropertyName = "EmailAddresse";
            EmailAddresseDataGridViewTextBoxColumn.HeaderText = "EmailAddresse";
            EmailAddresseDataGridViewTextBoxColumn.Name = "EmailAddresseDataGridViewTextBoxColumn";
            // 
            // JobtitleDataGridViewTextBoxColumn
            // 
            JobtitleDataGridViewTextBoxColumn.DataPropertyName = "Jobtitle";
            JobtitleDataGridViewTextBoxColumn.HeaderText = "Jobtitle";
            JobtitleDataGridViewTextBoxColumn.Name = "JobtitleDataGridViewTextBoxColumn";
            JobtitleDataGridViewTextBoxColumn.Width = 90;
            // 
            // TelefonGeschaeftlichDataGridViewTextBoxColumn
            // 
            TelefonGeschaeftlichDataGridViewTextBoxColumn.DataPropertyName = "TelefonGeschaeftlich";
            TelefonGeschaeftlichDataGridViewTextBoxColumn.HeaderText = "TelefonGeschaeftlich";
            TelefonGeschaeftlichDataGridViewTextBoxColumn.Name = "TelefonGeschaeftlichDataGridViewTextBoxColumn";
            // 
            // TelefonPrivatDataGridViewTextBoxColumn
            // 
            TelefonPrivatDataGridViewTextBoxColumn.DataPropertyName = "TelefonPrivat";
            TelefonPrivatDataGridViewTextBoxColumn.HeaderText = "TelefonPrivat";
            TelefonPrivatDataGridViewTextBoxColumn.Name = "TelefonPrivatDataGridViewTextBoxColumn";
            // 
            // MobiltelefonDataGridViewTextBoxColumn
            // 
            MobiltelefonDataGridViewTextBoxColumn.DataPropertyName = "Mobiltelefon";
            MobiltelefonDataGridViewTextBoxColumn.HeaderText = "Mobiltelefon";
            MobiltelefonDataGridViewTextBoxColumn.Name = "MobiltelefonDataGridViewTextBoxColumn";
            // 
            // FaxnummerDataGridViewTextBoxColumn
            // 
            FaxnummerDataGridViewTextBoxColumn.DataPropertyName = "Faxnummer";
            FaxnummerDataGridViewTextBoxColumn.HeaderText = "Faxnummer";
            FaxnummerDataGridViewTextBoxColumn.Name = "FaxnummerDataGridViewTextBoxColumn";
            // 
            // IDAdresseDataGridViewTextBoxColumn
            // 
            IDAdresseDataGridViewTextBoxColumn.DataPropertyName = "IDAdresse";
            IDAdresseDataGridViewTextBoxColumn.HeaderText = "IDAdresse";
            IDAdresseDataGridViewTextBoxColumn.Name = "IDAdresseDataGridViewTextBoxColumn";
            IDAdresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // AnredeDataGridViewTextBoxColumn
            // 
            AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede";
            AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede";
            AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn";
            AnredeDataGridViewTextBoxColumn.Width = 60;
            // 
            // Belege
            // 
            Belege.AutoScroll = true;
            Belege.Controls.Add(BNAV_Belege);
            Belege.Controls.Add(BelegeDataGridView);
            Belege.Location = new Point(4, 22);
            Belege.Name = "Belege";
            Belege.Padding = new Padding(3);
            Belege.Size = new Size(1171, 374);
            Belege.TabIndex = 5;
            Belege.Text = "Belege";
            Belege.UseVisualStyleBackColor = true;
            // 
            // BNAV_Belege
            // 
            BNAV_Belege.AddNewItem = ToolStripButton28;
            BNAV_Belege.BindingSource = BelegeBindingSource;
            BNAV_Belege.CountItem = ToolStripLabel5;
            BNAV_Belege.DeleteItem = ToolStripButton29;
            BNAV_Belege.Dock = DockStyle.Bottom;
            BNAV_Belege.Items.AddRange(new ToolStripItem[] { ToolStripButton30, ToolStripButton31, ToolStripSeparator13, ToolStripTextBox5, ToolStripLabel5, ToolStripSeparator14, ToolStripButton32, ToolStripButton33, ToolStripSeparator15, ToolStripButton28, ToolStripButton29, _BNAV_BelegeSaveItem });
            BNAV_Belege.Location = new Point(3, 346);
            BNAV_Belege.MoveFirstItem = ToolStripButton30;
            BNAV_Belege.MoveLastItem = ToolStripButton33;
            BNAV_Belege.MoveNextItem = ToolStripButton32;
            BNAV_Belege.MovePreviousItem = ToolStripButton31;
            BNAV_Belege.Name = "BNAV_Belege";
            BNAV_Belege.PositionItem = ToolStripTextBox5;
            BNAV_Belege.Size = new Size(1165, 25);
            BNAV_Belege.TabIndex = 26;
            BNAV_Belege.Text = "BindingNavigator1";
            // 
            // ToolStripButton28
            // 
            ToolStripButton28.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton28.Image = (Image)resources.GetObject("ToolStripButton28.Image");
            ToolStripButton28.Name = "ToolStripButton28";
            ToolStripButton28.RightToLeftAutoMirrorImage = true;
            ToolStripButton28.Size = new Size(23, 22);
            ToolStripButton28.Text = "Neu hinzufügen";
            // 
            // BelegeBindingSource
            // 
            BelegeBindingSource.DataMember = "Belege";
            BelegeBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // ToolStripLabel5
            // 
            ToolStripLabel5.Name = "ToolStripLabel5";
            ToolStripLabel5.Size = new Size(44, 22);
            ToolStripLabel5.Text = "von {0}";
            ToolStripLabel5.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton29
            // 
            ToolStripButton29.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton29.Image = (Image)resources.GetObject("ToolStripButton29.Image");
            ToolStripButton29.Name = "ToolStripButton29";
            ToolStripButton29.RightToLeftAutoMirrorImage = true;
            ToolStripButton29.Size = new Size(23, 22);
            ToolStripButton29.Text = "Löschen";
            // 
            // ToolStripButton30
            // 
            ToolStripButton30.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton30.Image = (Image)resources.GetObject("ToolStripButton30.Image");
            ToolStripButton30.Name = "ToolStripButton30";
            ToolStripButton30.RightToLeftAutoMirrorImage = true;
            ToolStripButton30.Size = new Size(23, 22);
            ToolStripButton30.Text = "Erste verschieben";
            // 
            // ToolStripButton31
            // 
            ToolStripButton31.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton31.Image = (Image)resources.GetObject("ToolStripButton31.Image");
            ToolStripButton31.Name = "ToolStripButton31";
            ToolStripButton31.RightToLeftAutoMirrorImage = true;
            ToolStripButton31.Size = new Size(23, 22);
            ToolStripButton31.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator13
            // 
            ToolStripSeparator13.Name = "ToolStripSeparator13";
            ToolStripSeparator13.Size = new Size(6, 25);
            // 
            // ToolStripTextBox5
            // 
            ToolStripTextBox5.AccessibleName = "Position";
            ToolStripTextBox5.AutoSize = false;
            ToolStripTextBox5.Font = new Font("Segoe UI", 9.75f);
            ToolStripTextBox5.Name = "ToolStripTextBox5";
            ToolStripTextBox5.Size = new Size(50, 25);
            ToolStripTextBox5.Text = "0";
            ToolStripTextBox5.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator14
            // 
            ToolStripSeparator14.Name = "ToolStripSeparator14";
            ToolStripSeparator14.Size = new Size(6, 25);
            // 
            // ToolStripButton32
            // 
            ToolStripButton32.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton32.Image = (Image)resources.GetObject("ToolStripButton32.Image");
            ToolStripButton32.Name = "ToolStripButton32";
            ToolStripButton32.RightToLeftAutoMirrorImage = true;
            ToolStripButton32.Size = new Size(23, 22);
            ToolStripButton32.Text = "Nächste verschieben";
            // 
            // ToolStripButton33
            // 
            ToolStripButton33.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripButton33.Image = (Image)resources.GetObject("ToolStripButton33.Image");
            ToolStripButton33.Name = "ToolStripButton33";
            ToolStripButton33.RightToLeftAutoMirrorImage = true;
            ToolStripButton33.Size = new Size(23, 22);
            ToolStripButton33.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator15
            // 
            ToolStripSeparator15.Name = "ToolStripSeparator15";
            ToolStripSeparator15.Size = new Size(6, 25);
            // 
            // BNAV_BelegeSaveItem
            // 
            _BNAV_BelegeSaveItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BNAV_BelegeSaveItem.Image = (Image)resources.GetObject("BNAV_BelegeSaveItem.Image");
            _BNAV_BelegeSaveItem.Name = "_BNAV_BelegeSaveItem";
            _BNAV_BelegeSaveItem.Size = new Size(23, 22);
            _BNAV_BelegeSaveItem.Text = "Daten speichern";
            // 
            // BelegeDataGridView
            // 
            BelegeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            BelegeDataGridView.AutoGenerateColumns = false;
            BelegeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BelegeDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn9, DataGridViewTextBoxColumn10, DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12, DataGridViewTextBoxColumn13, DataGridViewTextBoxColumn14, DataGridViewTextBoxColumn15, DataGridViewTextBoxColumn16, DataGridViewTextBoxColumn17, DataGridViewTextBoxColumn18, DataGridViewTextBoxColumn19 });
            BelegeDataGridView.DataSource = BelegeBindingSource;
            BelegeDataGridView.Location = new Point(0, 0);
            BelegeDataGridView.Name = "BelegeDataGridView";
            BelegeDataGridView.Size = new Size(1168, 343);
            BelegeDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "IDBeleg";
            DataGridViewTextBoxColumn6.HeaderText = "IDBeleg";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            // 
            // DataGridViewTextBoxColumn9
            // 
            DataGridViewTextBoxColumn9.DataPropertyName = "FirmenName";
            DataGridViewTextBoxColumn9.HeaderText = "FirmenName";
            DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            // 
            // DataGridViewTextBoxColumn10
            // 
            DataGridViewTextBoxColumn10.DataPropertyName = "Datum";
            DataGridViewTextBoxColumn10.HeaderText = "Datum";
            DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "IDAdresse";
            DataGridViewTextBoxColumn11.HeaderText = "IDAdresse";
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "IDKonto";
            DataGridViewTextBoxColumn12.HeaderText = "IDKonto";
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "Kuerzel";
            DataGridViewTextBoxColumn13.HeaderText = "Kuerzel";
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            // 
            // DataGridViewTextBoxColumn14
            // 
            DataGridViewTextBoxColumn14.DataPropertyName = "Kontakt";
            DataGridViewTextBoxColumn14.HeaderText = "Kontakt";
            DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            // 
            // DataGridViewTextBoxColumn15
            // 
            DataGridViewTextBoxColumn15.DataPropertyName = "WeitereKontakte";
            DataGridViewTextBoxColumn15.HeaderText = "WeitereKontakte";
            DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            // 
            // DataGridViewTextBoxColumn16
            // 
            DataGridViewTextBoxColumn16.DataPropertyName = "Thema";
            DataGridViewTextBoxColumn16.HeaderText = "Thema";
            DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            // 
            // DataGridViewTextBoxColumn17
            // 
            DataGridViewTextBoxColumn17.DataPropertyName = "WeitereBesucher";
            DataGridViewTextBoxColumn17.HeaderText = "WeitereBesucher";
            DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            // 
            // DataGridViewTextBoxColumn18
            // 
            DataGridViewTextBoxColumn18.DataPropertyName = "Login";
            DataGridViewTextBoxColumn18.HeaderText = "Login";
            DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            // 
            // DataGridViewTextBoxColumn19
            // 
            DataGridViewTextBoxColumn19.DataPropertyName = "Belegname";
            DataGridViewTextBoxColumn19.HeaderText = "Belegname";
            DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            // 
            // FirmenNameTableAdapter
            // 
            FirmenNameTableAdapter.ClearBeforeFill = true;
            // 
            // KontoTableAdapter
            // 
            KontoTableAdapter.ClearBeforeFill = true;
            // 
            // AdressenTableAdapter
            // 
            AdressenTableAdapter.ClearBeforeFill = true;
            // 
            // KontakteTableAdapter
            // 
            KontakteTableAdapter.ClearBeforeFill = true;
            // 
            // BelegeTableAdapter
            // 
            BelegeTableAdapter.ClearBeforeFill = true;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(Panel2, 0, 0);
            TableLayoutPanel1.Controls.Add(TC_Administration, 0, 1);
            TableLayoutPanel1.Controls.Add(Panel3, 0, 2);
            TableLayoutPanel1.Location = new Point(1, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 3;
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.Size = new Size(1185, 522);
            TableLayoutPanel1.TabIndex = 31;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 523);
            Controls.Add(TableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Administration";
            Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)KonfigurationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingSource).EndInit();
            Panel3.ResumeLayout(false);
            TC_Administration.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            TabPage2.ResumeLayout(false);
            TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FirmenNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator1).EndInit();
            BindingNavigator1.ResumeLayout(false);
            BindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FirmenNameDataGridView).EndInit();
            TabPage3.ResumeLayout(false);
            TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator2).EndInit();
            BindingNavigator2.ResumeLayout(false);
            BindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KontoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontoDataGridView).EndInit();
            TabPage4.ResumeLayout(false);
            TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BindingNavigator3).EndInit();
            BindingNavigator3.ResumeLayout(false);
            BindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdressenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            TabPage5.ResumeLayout(false);
            TabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingNavigator).EndInit();
            SachbearbeiterBindingNavigator.ResumeLayout(false);
            SachbearbeiterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)KontakteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridView2).EndInit();
            Belege.ResumeLayout(false);
            Belege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BNAV_Belege).EndInit();
            BNAV_Belege.ResumeLayout(false);
            BNAV_Belege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BelegeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BelegeDataGridView).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(Form4_Load);
            ResumeLayout(false);
        }

        internal FolderBrowserDialog FolderBrowserDialog1;
        private Button _BTN_Vorlagenpfad;

        internal Button BTN_Vorlagenpfad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Vorlagenpfad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Vorlagenpfad != null)
                {
                    _BTN_Vorlagenpfad.Click -= BTN_Vorlagenpfad_Click;
                }

                _BTN_Vorlagenpfad = value;
                if (_BTN_Vorlagenpfad != null)
                {
                    _BTN_Vorlagenpfad.Click += BTN_Vorlagenpfad_Click;
                }
            }
        }

        private Button _BTN_Schliessen;

        internal Button BTN_Schliessen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Schliessen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Schliessen != null)
                {
                    _BTN_Schliessen.Click -= BTN_Schliessen_Click;
                }

                _BTN_Schliessen = value;
                if (_BTN_Schliessen != null)
                {
                    _BTN_Schliessen.Click += BTN_Schliessen_Click;
                }
            }
        }

        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal BindingSource KonfigurationBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KonfigurationTableAdapter KonfigurationTableAdapter;
        internal TextBox VorlagenpfadTextBox;
        internal TextBox IDBesuchTextBox;
        internal TextBox IDKontaktTextBox;
        internal TextBox IDAdresseTextBox;
        internal TextBox LieferantennummerTextBox;
        internal TextBox KundennummerTextBox;
        internal TextBox LeadnummerTextBox;
        internal TextBox IDFirmenNameTextBox;
        internal Panel Panel2;
        internal Label Label1;
        internal BindingSource SachbearbeiterBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter SachbearbeiterTableAdapter;
        internal Label SachbearbeiterLabel1;
        internal CheckBox AdminCheckBox;
        private Button _BTN_Speichern;

        internal Button BTN_Speichern
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Speichern;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Speichern != null)
                {
                    _BTN_Speichern.Click -= BTN_Speichern_Click;
                }

                _BTN_Speichern = value;
                if (_BTN_Speichern != null)
                {
                    _BTN_Speichern.Click += BTN_Speichern_Click;
                }
            }
        }

        internal Panel Panel3;
        internal TabControl TC_Administration;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal TabPage TabPage5;
        internal BindingSource FirmenNameBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter FirmenNameTableAdapter;
        internal DateTimePicker ChangedDateTimePicker;
        internal TextBox LoginTextBox;
        internal TextBox FirmenNameTextBox;
        internal TextBox IDFirmenNameTextBox1;
        internal DataGridView FirmenNameDataGridView;
        internal BindingSource KontoBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontoTableAdapter KontoTableAdapter;
        internal DateTimePicker AnlageDatumDateTimePicker;
        internal TextBox KontoNameTextBox;
        internal TextBox IDFirmenNameTextBox2;
        internal TextBox IDKontoTextBox;
        internal DataGridView KontoDataGridView;
        internal BindingSource AdressenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter AdressenTableAdapter;
        internal TextBox LandTextBox;
        internal TextBox BundeslandTextBox;
        internal TextBox OrtTextBox;
        internal TextBox PLZTextBox;
        internal TextBox PostfachTextBox;
        internal TextBox StraßeTextBox;
        internal TextBox AdresstypTextBox;
        internal TextBox IDKontoTextBox1;
        internal TextBox IDFirmenNameTextBox3;
        internal TextBox IDAdresseTextBox1;
        internal DataGridView DataGridView1;
        internal TextBox WebseiteTextBox;
        internal TextBox UStIdNrTextBox;
        internal DataGridView DataGridView2;
        internal BindingSource KontakteBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter KontakteTableAdapter;
        internal TextBox IDAdresseTextBox2;
        internal TextBox FaxnummerTextBox;
        internal TextBox MobiltelefonTextBox;
        internal TextBox TelefonPrivatTextBox;
        internal TextBox TelefonGeschaeftlichTextBox;
        internal TextBox JobtitleTextBox;
        internal TextBox EmailAddresseTextBox;
        internal TextBox AnredeTextBox;
        internal TextBox NachnameTextBox;
        internal TextBox VornameTextBox;
        internal TextBox IDFirmenNameTextBox4;
        internal TextBox IDKontaktTextBox1;
        internal BindingNavigator BindingNavigator1;
        internal ToolStripButton ToolStripButton21;
        internal ToolStripLabel ToolStripLabel4;
        internal ToolStripButton ToolStripButton22;
        internal ToolStripButton ToolStripButton23;
        internal ToolStripButton ToolStripButton24;
        internal ToolStripSeparator ToolStripSeparator10;
        internal ToolStripTextBox ToolStripTextBox4;
        internal ToolStripSeparator ToolStripSeparator11;
        internal ToolStripButton ToolStripButton25;
        internal ToolStripButton ToolStripButton26;
        internal ToolStripSeparator ToolStripSeparator12;
        private ToolStripButton _BNAV_FirmenNameSave;

        internal ToolStripButton BNAV_FirmenNameSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BNAV_FirmenNameSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BNAV_FirmenNameSave != null)
                {
                    _BNAV_FirmenNameSave.Click -= BNAV_FirmenNameSave_Click;
                }

                _BNAV_FirmenNameSave = value;
                if (_BNAV_FirmenNameSave != null)
                {
                    _BNAV_FirmenNameSave.Click += BNAV_FirmenNameSave_Click;
                }
            }
        }

        internal BindingNavigator BindingNavigator2;
        internal ToolStripButton ToolStripButton14;
        internal ToolStripLabel ToolStripLabel3;
        internal ToolStripButton ToolStripButton15;
        internal ToolStripButton ToolStripButton16;
        internal ToolStripButton ToolStripButton17;
        internal ToolStripSeparator ToolStripSeparator7;
        internal ToolStripTextBox ToolStripTextBox3;
        internal ToolStripSeparator ToolStripSeparator8;
        internal ToolStripButton ToolStripButton18;
        internal ToolStripButton ToolStripButton19;
        internal ToolStripSeparator ToolStripSeparator9;
        private ToolStripButton _BNAV_KontoSave;

        internal ToolStripButton BNAV_KontoSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BNAV_KontoSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BNAV_KontoSave != null)
                {
                    _BNAV_KontoSave.Click -= BNAV_KontoSave_Click;
                }

                _BNAV_KontoSave = value;
                if (_BNAV_KontoSave != null)
                {
                    _BNAV_KontoSave.Click += BNAV_KontoSave_Click;
                }
            }
        }

        internal BindingNavigator BindingNavigator3;
        internal ToolStripButton ToolStripButton7;
        internal ToolStripLabel ToolStripLabel2;
        internal ToolStripButton ToolStripButton8;
        internal ToolStripButton ToolStripButton9;
        internal ToolStripButton ToolStripButton10;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripTextBox ToolStripTextBox2;
        internal ToolStripSeparator ToolStripSeparator5;
        internal ToolStripButton ToolStripButton11;
        internal ToolStripButton ToolStripButton12;
        internal ToolStripSeparator ToolStripSeparator6;
        private ToolStripButton _BNAV_AdressenSave;

        internal ToolStripButton BNAV_AdressenSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BNAV_AdressenSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BNAV_AdressenSave != null)
                {
                    _BNAV_AdressenSave.Click -= BNAV_AdressenSave_Click;
                }

                _BNAV_AdressenSave = value;
                if (_BNAV_AdressenSave != null)
                {
                    _BNAV_AdressenSave.Click += BNAV_AdressenSave_Click;
                }
            }
        }

        internal BindingNavigator SachbearbeiterBindingNavigator;
        internal ToolStripButton ToolStripButton1;
        internal ToolStripLabel ToolStripLabel1;
        internal ToolStripButton ToolStripButton2;
        internal ToolStripButton ToolStripButton3;
        internal ToolStripButton ToolStripButton4;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripTextBox ToolStripTextBox1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton ToolStripButton5;
        internal ToolStripButton ToolStripButton6;
        internal ToolStripSeparator ToolStripSeparator3;
        private ToolStripButton _BNAV_KontakteSave;

        internal ToolStripButton BNAV_KontakteSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BNAV_KontakteSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BNAV_KontakteSave != null)
                {
                    _BNAV_KontakteSave.Click -= BNAV_KontakteSave_Click;
                }

                _BNAV_KontakteSave = value;
                if (_BNAV_KontakteSave != null)
                {
                    _BNAV_KontakteSave.Click += BNAV_KontakteSave_Click;
                }
            }
        }

        private Button _BTN_Aktuell;

        internal Button BTN_Aktuell
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Aktuell;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Aktuell != null)
                {
                    _BTN_Aktuell.Click -= BTN_Aktuell_Click;
                }

                _BTN_Aktuell = value;
                if (_BTN_Aktuell != null)
                {
                    _BTN_Aktuell.Click += BTN_Aktuell_Click;
                }
            }
        }

        private Button _BTN_Alle;

        internal Button BTN_Alle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Alle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Alle != null)
                {
                    _BTN_Alle.Click -= BTN_Alle_Click;
                }

                _BTN_Alle = value;
                if (_BTN_Alle != null)
                {
                    _BTN_Alle.Click += BTN_Alle_Click;
                }
            }
        }

        private Button _BTN_DWPfad;

        internal Button BTN_DWPfad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_DWPfad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_DWPfad != null)
                {
                    _BTN_DWPfad.Click -= BTN_DWPfad_Click;
                }

                _BTN_DWPfad = value;
                if (_BTN_DWPfad != null)
                {
                    _BTN_DWPfad.Click += BTN_DWPfad_Click;
                }
            }
        }

        internal TextBox DWDateinameTextBox;
        internal TextBox DWpfadTextBox;
        internal DataGridViewTextBoxColumn IDKontakt;
        internal DataGridViewTextBoxColumn IDFirmenName;
        internal DataGridViewTextBoxColumn Nachname;
        internal DataGridViewTextBoxColumn Vorname;
        internal DataGridViewTextBoxColumn EmailAddresseDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn JobtitleDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TelefonGeschaeftlichDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn TelefonPrivatDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn MobiltelefonDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn FaxnummerDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn IDAdresseDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn AnredeDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn IDAdresse;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn IDKonto;
        internal DataGridViewTextBoxColumn Adresstyp;
        internal DataGridViewTextBoxColumn Straße;
        internal DataGridViewTextBoxColumn Postfach;
        internal DataGridViewTextBoxColumn PLZ;
        internal DataGridViewTextBoxColumn Ort;
        internal DataGridViewTextBoxColumn Bundesland;
        internal DataGridViewTextBoxColumn Land;
        internal DataGridViewTextBoxColumn UStIdNr;
        internal DataGridViewTextBoxColumn Webseite;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn Datum;
        internal TabPage Belege;
        internal BindingSource BelegeBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.BelegeTableAdapter BelegeTableAdapter;
        internal DataGridView BelegeDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn17;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        internal BindingNavigator BNAV_Belege;
        internal ToolStripButton ToolStripButton28;
        internal ToolStripLabel ToolStripLabel5;
        internal ToolStripButton ToolStripButton29;
        internal ToolStripButton ToolStripButton30;
        internal ToolStripButton ToolStripButton31;
        internal ToolStripSeparator ToolStripSeparator13;
        internal ToolStripTextBox ToolStripTextBox5;
        internal ToolStripSeparator ToolStripSeparator14;
        internal ToolStripButton ToolStripButton32;
        internal ToolStripButton ToolStripButton33;
        internal ToolStripSeparator ToolStripSeparator15;
        private ToolStripButton _BNAV_BelegeSaveItem;

        internal ToolStripButton BNAV_BelegeSaveItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BNAV_BelegeSaveItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BNAV_BelegeSaveItem != null)
                {
                    _BNAV_BelegeSaveItem.Click -= BNAV_BelegeSaveItem_Click;
                }

                _BNAV_BelegeSaveItem = value;
                if (_BNAV_BelegeSaveItem != null)
                {
                    _BNAV_BelegeSaveItem.Click += BNAV_BelegeSaveItem_Click;
                }
            }
        }

        internal CheckBox InaktivCheckBox;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn Login;
        internal DataGridViewTextBoxColumn changed;
        internal DataGridViewCheckBoxColumn inaktiv;
        internal TextBox HilfelinkTextBox;
        internal TableLayoutPanel TableLayoutPanel1;
    }
}