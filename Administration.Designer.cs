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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label SachbearbeiterLabel;
            System.Windows.Forms.Label AdminLabel;
            System.Windows.Forms.Label IDFirmenNameLabel1;
            System.Windows.Forms.Label FirmenNameLabel;
            System.Windows.Forms.Label LoginLabel;
            System.Windows.Forms.Label ChangedLabel;
            System.Windows.Forms.Label IDKontoLabel;
            System.Windows.Forms.Label IDFirmenNameLabel2;
            System.Windows.Forms.Label KontoNameLabel;
            System.Windows.Forms.Label AnlageDatumLabel;
            System.Windows.Forms.Label IDAdresseLabel1;
            System.Windows.Forms.Label IDFirmenNameLabel3;
            System.Windows.Forms.Label IDKontoLabel1;
            System.Windows.Forms.Label AdresstypLabel;
            System.Windows.Forms.Label StraßeLabel;
            System.Windows.Forms.Label PostfachLabel;
            System.Windows.Forms.Label PLZLabel;
            System.Windows.Forms.Label OrtLabel;
            System.Windows.Forms.Label BundeslandLabel;
            System.Windows.Forms.Label LandLabel;
            System.Windows.Forms.Label UStIdNrLabel;
            System.Windows.Forms.Label WebseiteLabel;
            System.Windows.Forms.Label IDKontaktLabel1;
            System.Windows.Forms.Label IDFirmenNameLabel4;
            System.Windows.Forms.Label VornameLabel;
            System.Windows.Forms.Label NachnameLabel;
            System.Windows.Forms.Label AnredeLabel;
            System.Windows.Forms.Label EmailAddresseLabel;
            System.Windows.Forms.Label JobtitleLabel;
            System.Windows.Forms.Label TelefonGeschaeftlichLabel;
            System.Windows.Forms.Label TelefonPrivatLabel;
            System.Windows.Forms.Label MobiltelefonLabel;
            System.Windows.Forms.Label FaxnummerLabel;
            System.Windows.Forms.Label IDAdresseLabel2;
            System.Windows.Forms.Label InaktivLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SachbearbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SachbearbeiterLabel1 = new System.Windows.Forms.Label();
            this._BTN_Alle = new System.Windows.Forms.Button();
            this._BTN_Aktuell = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this._BTN_Schliessen = new System.Windows.Forms.Button();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.SachbearbeiterTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            this.TC_Administration = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.FirmenNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton20 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton27 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton34 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox6 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton35 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton36 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_PropertiesSave = new System.Windows.Forms.ToolStripButton();
            this.propertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.InaktivCheckBox = new System.Windows.Forms.CheckBox();
            this.BindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton22 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_FirmenNameSave = new System.Windows.Forms.ToolStripButton();
            this.ChangedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FirmenNameTextBox = new System.Windows.Forms.TextBox();
            this.IDFirmenNameTextBox1 = new System.Windows.Forms.TextBox();
            this.FirmenNameDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inaktiv = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.BindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.KontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton19 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_KontoSave = new System.Windows.Forms.ToolStripButton();
            this.AnlageDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.KontoNameTextBox = new System.Windows.Forms.TextBox();
            this.IDFirmenNameTextBox2 = new System.Windows.Forms.TextBox();
            this.IDKontoTextBox = new System.Windows.Forms.TextBox();
            this.KontoDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.BindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.AdressenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_AdressenSave = new System.Windows.Forms.ToolStripButton();
            this.WebseiteTextBox = new System.Windows.Forms.TextBox();
            this.UStIdNrTextBox = new System.Windows.Forms.TextBox();
            this.LandTextBox = new System.Windows.Forms.TextBox();
            this.BundeslandTextBox = new System.Windows.Forms.TextBox();
            this.OrtTextBox = new System.Windows.Forms.TextBox();
            this.PLZTextBox = new System.Windows.Forms.TextBox();
            this.PostfachTextBox = new System.Windows.Forms.TextBox();
            this.StraßeTextBox = new System.Windows.Forms.TextBox();
            this.AdresstypTextBox = new System.Windows.Forms.TextBox();
            this.IDKontoTextBox1 = new System.Windows.Forms.TextBox();
            this.IDFirmenNameTextBox3 = new System.Windows.Forms.TextBox();
            this.IDAdresseTextBox1 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresstyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Straße = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postfach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bundesland = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Land = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UStIdNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Webseite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.SachbearbeiterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.KontakteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_KontakteSave = new System.Windows.Forms.ToolStripButton();
            this.IDAdresseTextBox2 = new System.Windows.Forms.TextBox();
            this.FaxnummerTextBox = new System.Windows.Forms.TextBox();
            this.MobiltelefonTextBox = new System.Windows.Forms.TextBox();
            this.TelefonPrivatTextBox = new System.Windows.Forms.TextBox();
            this.TelefonGeschaeftlichTextBox = new System.Windows.Forms.TextBox();
            this.JobtitleTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddresseTextBox = new System.Windows.Forms.TextBox();
            this.AnredeTextBox = new System.Windows.Forms.TextBox();
            this.NachnameTextBox = new System.Windows.Forms.TextBox();
            this.VornameTextBox = new System.Windows.Forms.TextBox();
            this.IDFirmenNameTextBox4 = new System.Windows.Forms.TextBox();
            this.IDKontaktTextBox1 = new System.Windows.Forms.TextBox();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.IDKontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFirmenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nachname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailAddresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonGeschaeftlichDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonPrivatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobiltelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaxnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnredeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Belege = new System.Windows.Forms.TabPage();
            this.BNAV_Belege = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton28 = new System.Windows.Forms.ToolStripButton();
            this.BelegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton29 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton30 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton31 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox5 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton32 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton33 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_BelegeSaveItem = new System.Windows.Forms.ToolStripButton();
            this.BelegeDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmenNameTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            this.KontoTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            this.AdressenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.AdressenTableAdapter();
            this.KontakteTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteTableAdapter();
            this.BelegeTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeTableAdapter();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.propertiesTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SachbearbeiterLabel = new System.Windows.Forms.Label();
            AdminLabel = new System.Windows.Forms.Label();
            IDFirmenNameLabel1 = new System.Windows.Forms.Label();
            FirmenNameLabel = new System.Windows.Forms.Label();
            LoginLabel = new System.Windows.Forms.Label();
            ChangedLabel = new System.Windows.Forms.Label();
            IDKontoLabel = new System.Windows.Forms.Label();
            IDFirmenNameLabel2 = new System.Windows.Forms.Label();
            KontoNameLabel = new System.Windows.Forms.Label();
            AnlageDatumLabel = new System.Windows.Forms.Label();
            IDAdresseLabel1 = new System.Windows.Forms.Label();
            IDFirmenNameLabel3 = new System.Windows.Forms.Label();
            IDKontoLabel1 = new System.Windows.Forms.Label();
            AdresstypLabel = new System.Windows.Forms.Label();
            StraßeLabel = new System.Windows.Forms.Label();
            PostfachLabel = new System.Windows.Forms.Label();
            PLZLabel = new System.Windows.Forms.Label();
            OrtLabel = new System.Windows.Forms.Label();
            BundeslandLabel = new System.Windows.Forms.Label();
            LandLabel = new System.Windows.Forms.Label();
            UStIdNrLabel = new System.Windows.Forms.Label();
            WebseiteLabel = new System.Windows.Forms.Label();
            IDKontaktLabel1 = new System.Windows.Forms.Label();
            IDFirmenNameLabel4 = new System.Windows.Forms.Label();
            VornameLabel = new System.Windows.Forms.Label();
            NachnameLabel = new System.Windows.Forms.Label();
            AnredeLabel = new System.Windows.Forms.Label();
            EmailAddresseLabel = new System.Windows.Forms.Label();
            JobtitleLabel = new System.Windows.Forms.Label();
            TelefonGeschaeftlichLabel = new System.Windows.Forms.Label();
            TelefonPrivatLabel = new System.Windows.Forms.Label();
            MobiltelefonLabel = new System.Windows.Forms.Label();
            FaxnummerLabel = new System.Windows.Forms.Label();
            IDAdresseLabel2 = new System.Windows.Forms.Label();
            InaktivLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).BeginInit();
            this.Panel3.SuspendLayout();
            this.TC_Administration.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).BeginInit();
            this.BindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameDataGridView)).BeginInit();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator2)).BeginInit();
            this.BindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).BeginInit();
            this.TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator3)).BeginInit();
            this.BindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.TabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingNavigator)).BeginInit();
            this.SachbearbeiterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.Belege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNAV_Belege)).BeginInit();
            this.BNAV_Belege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeDataGridView)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SachbearbeiterLabel.Location = new System.Drawing.Point(13, 33);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new System.Drawing.Size(82, 13);
            SachbearbeiterLabel.TabIndex = 25;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new System.Drawing.Point(492, 39);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new System.Drawing.Size(70, 13);
            AdminLabel.TabIndex = 27;
            AdminLabel.Text = "Administrator:";
            // 
            // IDFirmenNameLabel1
            // 
            IDFirmenNameLabel1.AutoSize = true;
            IDFirmenNameLabel1.Location = new System.Drawing.Point(9, 11);
            IDFirmenNameLabel1.Name = "IDFirmenNameLabel1";
            IDFirmenNameLabel1.Size = new System.Drawing.Size(83, 13);
            IDFirmenNameLabel1.TabIndex = 1;
            IDFirmenNameLabel1.Text = "IDFirmen Name:";
            // 
            // FirmenNameLabel
            // 
            FirmenNameLabel.AutoSize = true;
            FirmenNameLabel.Location = new System.Drawing.Point(20, 37);
            FirmenNameLabel.Name = "FirmenNameLabel";
            FirmenNameLabel.Size = new System.Drawing.Size(72, 13);
            FirmenNameLabel.TabIndex = 3;
            FirmenNameLabel.Text = "Firmen Name:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new System.Drawing.Point(56, 63);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(36, 13);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Login:";
            // 
            // ChangedLabel
            // 
            ChangedLabel.AutoSize = true;
            ChangedLabel.Location = new System.Drawing.Point(40, 90);
            ChangedLabel.Name = "ChangedLabel";
            ChangedLabel.Size = new System.Drawing.Size(52, 13);
            ChangedLabel.TabIndex = 7;
            ChangedLabel.Text = "changed:";
            // 
            // IDKontoLabel
            // 
            IDKontoLabel.AutoSize = true;
            IDKontoLabel.Location = new System.Drawing.Point(641, 10);
            IDKontoLabel.Name = "IDKontoLabel";
            IDKontoLabel.Size = new System.Drawing.Size(49, 13);
            IDKontoLabel.TabIndex = 1;
            IDKontoLabel.Text = "IDKonto:";
            // 
            // IDFirmenNameLabel2
            // 
            IDFirmenNameLabel2.AutoSize = true;
            IDFirmenNameLabel2.Location = new System.Drawing.Point(607, 36);
            IDFirmenNameLabel2.Name = "IDFirmenNameLabel2";
            IDFirmenNameLabel2.Size = new System.Drawing.Size(83, 13);
            IDFirmenNameLabel2.TabIndex = 3;
            IDFirmenNameLabel2.Text = "IDFirmen Name:";
            // 
            // KontoNameLabel
            // 
            KontoNameLabel.AutoSize = true;
            KontoNameLabel.Location = new System.Drawing.Point(621, 62);
            KontoNameLabel.Name = "KontoNameLabel";
            KontoNameLabel.Size = new System.Drawing.Size(69, 13);
            KontoNameLabel.TabIndex = 5;
            KontoNameLabel.Text = "Konto Name:";
            // 
            // AnlageDatumLabel
            // 
            AnlageDatumLabel.AutoSize = true;
            AnlageDatumLabel.Location = new System.Drawing.Point(613, 89);
            AnlageDatumLabel.Name = "AnlageDatumLabel";
            AnlageDatumLabel.Size = new System.Drawing.Size(77, 13);
            AnlageDatumLabel.TabIndex = 7;
            AnlageDatumLabel.Text = "Anlage Datum:";
            // 
            // IDAdresseLabel1
            // 
            IDAdresseLabel1.AutoSize = true;
            IDAdresseLabel1.Location = new System.Drawing.Point(27, 7);
            IDAdresseLabel1.Name = "IDAdresseLabel1";
            IDAdresseLabel1.Size = new System.Drawing.Size(59, 13);
            IDAdresseLabel1.TabIndex = 1;
            IDAdresseLabel1.Text = "IDAdresse:";
            // 
            // IDFirmenNameLabel3
            // 
            IDFirmenNameLabel3.AutoSize = true;
            IDFirmenNameLabel3.Location = new System.Drawing.Point(3, 59);
            IDFirmenNameLabel3.Name = "IDFirmenNameLabel3";
            IDFirmenNameLabel3.Size = new System.Drawing.Size(83, 13);
            IDFirmenNameLabel3.TabIndex = 3;
            IDFirmenNameLabel3.Text = "IDFirmen Name:";
            // 
            // IDKontoLabel1
            // 
            IDKontoLabel1.AutoSize = true;
            IDKontoLabel1.Location = new System.Drawing.Point(37, 33);
            IDKontoLabel1.Name = "IDKontoLabel1";
            IDKontoLabel1.Size = new System.Drawing.Size(49, 13);
            IDKontoLabel1.TabIndex = 5;
            IDKontoLabel1.Text = "IDKonto:";
            // 
            // AdresstypLabel
            // 
            AdresstypLabel.AutoSize = true;
            AdresstypLabel.Location = new System.Drawing.Point(206, 7);
            AdresstypLabel.Name = "AdresstypLabel";
            AdresstypLabel.Size = new System.Drawing.Size(56, 13);
            AdresstypLabel.TabIndex = 7;
            AdresstypLabel.Text = "Adresstyp:";
            // 
            // StraßeLabel
            // 
            StraßeLabel.AutoSize = true;
            StraßeLabel.Location = new System.Drawing.Point(407, 33);
            StraßeLabel.Name = "StraßeLabel";
            StraßeLabel.Size = new System.Drawing.Size(41, 13);
            StraßeLabel.TabIndex = 9;
            StraßeLabel.Text = "Straße:";
            // 
            // PostfachLabel
            // 
            PostfachLabel.AutoSize = true;
            PostfachLabel.Location = new System.Drawing.Point(396, 8);
            PostfachLabel.Name = "PostfachLabel";
            PostfachLabel.Size = new System.Drawing.Size(52, 13);
            PostfachLabel.TabIndex = 11;
            PostfachLabel.Text = "Postfach:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new System.Drawing.Point(418, 59);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new System.Drawing.Size(30, 13);
            PLZLabel.TabIndex = 13;
            PLZLabel.Text = "PLZ:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new System.Drawing.Point(542, 59);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new System.Drawing.Size(24, 13);
            OrtLabel.TabIndex = 15;
            OrtLabel.Text = "Ort:";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new System.Drawing.Point(723, 9);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new System.Drawing.Size(66, 13);
            BundeslandLabel.TabIndex = 17;
            BundeslandLabel.Text = "Bundesland:";
            // 
            // LandLabel
            // 
            LandLabel.AutoSize = true;
            LandLabel.Location = new System.Drawing.Point(911, 7);
            LandLabel.Name = "LandLabel";
            LandLabel.Size = new System.Drawing.Size(34, 13);
            LandLabel.TabIndex = 19;
            LandLabel.Text = "Land:";
            // 
            // UStIdNrLabel
            // 
            UStIdNrLabel.AutoSize = true;
            UStIdNrLabel.Location = new System.Drawing.Point(208, 33);
            UStIdNrLabel.Name = "UStIdNrLabel";
            UStIdNrLabel.Size = new System.Drawing.Size(54, 13);
            UStIdNrLabel.TabIndex = 21;
            UStIdNrLabel.Text = "USt Id Nr:";
            // 
            // WebseiteLabel
            // 
            WebseiteLabel.AutoSize = true;
            WebseiteLabel.Location = new System.Drawing.Point(734, 33);
            WebseiteLabel.Name = "WebseiteLabel";
            WebseiteLabel.Size = new System.Drawing.Size(55, 13);
            WebseiteLabel.TabIndex = 23;
            WebseiteLabel.Text = "Webseite:";
            // 
            // IDKontaktLabel1
            // 
            IDKontaktLabel1.AutoSize = true;
            IDKontaktLabel1.Location = new System.Drawing.Point(34, 9);
            IDKontaktLabel1.Name = "IDKontaktLabel1";
            IDKontaktLabel1.Size = new System.Drawing.Size(58, 13);
            IDKontaktLabel1.TabIndex = 2;
            IDKontaktLabel1.Text = "IDKontakt:";
            // 
            // IDFirmenNameLabel4
            // 
            IDFirmenNameLabel4.AutoSize = true;
            IDFirmenNameLabel4.Location = new System.Drawing.Point(5, 35);
            IDFirmenNameLabel4.Name = "IDFirmenNameLabel4";
            IDFirmenNameLabel4.Size = new System.Drawing.Size(83, 13);
            IDFirmenNameLabel4.TabIndex = 3;
            IDFirmenNameLabel4.Text = "IDFirmen-Name:";
            // 
            // VornameLabel
            // 
            VornameLabel.AutoSize = true;
            VornameLabel.Location = new System.Drawing.Point(231, 60);
            VornameLabel.Name = "VornameLabel";
            VornameLabel.Size = new System.Drawing.Size(52, 13);
            VornameLabel.TabIndex = 5;
            VornameLabel.Text = "Vorname:";
            // 
            // NachnameLabel
            // 
            NachnameLabel.AutoSize = true;
            NachnameLabel.Location = new System.Drawing.Point(217, 34);
            NachnameLabel.Name = "NachnameLabel";
            NachnameLabel.Size = new System.Drawing.Size(62, 13);
            NachnameLabel.TabIndex = 7;
            NachnameLabel.Text = "Nachname:";
            // 
            // AnredeLabel
            // 
            AnredeLabel.AutoSize = true;
            AnredeLabel.Location = new System.Drawing.Point(239, 9);
            AnredeLabel.Name = "AnredeLabel";
            AnredeLabel.Size = new System.Drawing.Size(44, 13);
            AnredeLabel.TabIndex = 9;
            AnredeLabel.Text = "Anrede:";
            // 
            // EmailAddresseLabel
            // 
            EmailAddresseLabel.AutoSize = true;
            EmailAddresseLabel.Location = new System.Drawing.Point(445, 35);
            EmailAddresseLabel.Name = "EmailAddresseLabel";
            EmailAddresseLabel.Size = new System.Drawing.Size(35, 13);
            EmailAddresseLabel.TabIndex = 11;
            EmailAddresseLabel.Text = "Email:";
            // 
            // JobtitleLabel
            // 
            JobtitleLabel.AutoSize = true;
            JobtitleLabel.Location = new System.Drawing.Point(439, 9);
            JobtitleLabel.Name = "JobtitleLabel";
            JobtitleLabel.Size = new System.Drawing.Size(43, 13);
            JobtitleLabel.TabIndex = 13;
            JobtitleLabel.Text = "Jobtitle:";
            // 
            // TelefonGeschaeftlichLabel
            // 
            TelefonGeschaeftlichLabel.AutoSize = true;
            TelefonGeschaeftlichLabel.Location = new System.Drawing.Point(629, 8);
            TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel";
            TelefonGeschaeftlichLabel.Size = new System.Drawing.Size(84, 13);
            TelefonGeschaeftlichLabel.TabIndex = 15;
            TelefonGeschaeftlichLabel.Text = "Telefon (gesch):";
            // 
            // TelefonPrivatLabel
            // 
            TelefonPrivatLabel.AutoSize = true;
            TelefonPrivatLabel.Location = new System.Drawing.Point(633, 34);
            TelefonPrivatLabel.Name = "TelefonPrivatLabel";
            TelefonPrivatLabel.Size = new System.Drawing.Size(76, 13);
            TelefonPrivatLabel.TabIndex = 17;
            TelefonPrivatLabel.Text = "Telefon Privat:";
            // 
            // MobiltelefonLabel
            // 
            MobiltelefonLabel.AutoSize = true;
            MobiltelefonLabel.Location = new System.Drawing.Point(645, 60);
            MobiltelefonLabel.Name = "MobiltelefonLabel";
            MobiltelefonLabel.Size = new System.Drawing.Size(67, 13);
            MobiltelefonLabel.TabIndex = 19;
            MobiltelefonLabel.Text = "Mobiltelefon:";
            // 
            // FaxnummerLabel
            // 
            FaxnummerLabel.AutoSize = true;
            FaxnummerLabel.Location = new System.Drawing.Point(645, 86);
            FaxnummerLabel.Name = "FaxnummerLabel";
            FaxnummerLabel.Size = new System.Drawing.Size(64, 13);
            FaxnummerLabel.TabIndex = 21;
            FaxnummerLabel.Text = "Faxnummer:";
            // 
            // IDAdresseLabel2
            // 
            IDAdresseLabel2.AutoSize = true;
            IDAdresseLabel2.Location = new System.Drawing.Point(29, 61);
            IDAdresseLabel2.Name = "IDAdresseLabel2";
            IDAdresseLabel2.Size = new System.Drawing.Size(59, 13);
            IDAdresseLabel2.TabIndex = 23;
            IDAdresseLabel2.Text = "IDAdresse:";
            // 
            // InaktivLabel
            // 
            InaktivLabel.AutoSize = true;
            InaktivLabel.Location = new System.Drawing.Point(51, 117);
            InaktivLabel.Name = "InaktivLabel";
            InaktivLabel.Size = new System.Drawing.Size(41, 13);
            InaktivLabel.TabIndex = 10;
            InaktivLabel.Text = "inaktiv:";
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this.AdminCheckBox);
            this.Panel2.Controls.Add(AdminLabel);
            this.Panel2.Controls.Add(this.SachbearbeiterLabel1);
            this.Panel2.Controls.Add(this._BTN_Alle);
            this.Panel2.Controls.Add(SachbearbeiterLabel);
            this.Panel2.Controls.Add(this._BTN_Aktuell);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1179, 61);
            this.Panel2.TabIndex = 25;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.SachbearbeiterBindingSource, "Admin", true));
            this.AdminCheckBox.Enabled = false;
            this.AdminCheckBox.Location = new System.Drawing.Point(568, 33);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(16, 24);
            this.AdminCheckBox.TabIndex = 28;
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterBindingSource
            // 
            this.SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            this.SachbearbeiterBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // SachbearbeiterLabel1
            // 
            this.SachbearbeiterLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SachbearbeiterBindingSource, "Sachbearbeiter", true));
            this.SachbearbeiterLabel1.Location = new System.Drawing.Point(101, 29);
            this.SachbearbeiterLabel1.Name = "SachbearbeiterLabel1";
            this.SachbearbeiterLabel1.Size = new System.Drawing.Size(385, 22);
            this.SachbearbeiterLabel1.TabIndex = 26;
            this.SachbearbeiterLabel1.Text = "Vorname Name";
            this.SachbearbeiterLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _BTN_Alle
            // 
            this._BTN_Alle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Alle.Enabled = false;
            this._BTN_Alle.Location = new System.Drawing.Point(938, 6);
            this._BTN_Alle.Name = "_BTN_Alle";
            this._BTN_Alle.Size = new System.Drawing.Size(75, 23);
            this._BTN_Alle.TabIndex = 2;
            this._BTN_Alle.Text = "alle";
            this._BTN_Alle.UseVisualStyleBackColor = true;
            this._BTN_Alle.Click += new System.EventHandler(this.BTN_Alle_Click);
            // 
            // _BTN_Aktuell
            // 
            this._BTN_Aktuell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Aktuell.Enabled = false;
            this._BTN_Aktuell.Location = new System.Drawing.Point(1019, 6);
            this._BTN_Aktuell.Name = "_BTN_Aktuell";
            this._BTN_Aktuell.Size = new System.Drawing.Size(156, 23);
            this._BTN_Aktuell.TabIndex = 1;
            this._BTN_Aktuell.Text = "Aktuellen Geschäftspartner";
            this._BTN_Aktuell.UseVisualStyleBackColor = true;
            this._BTN_Aktuell.Click += new System.EventHandler(this.BTN_Aktuell_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Administration";
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gray;
            this.Panel3.Controls.Add(this._BTN_Schliessen);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 476);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(1179, 43);
            this.Panel3.TabIndex = 26;
            // 
            // _BTN_Schliessen
            // 
            this._BTN_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Schliessen.Image = ((System.Drawing.Image)(resources.GetObject("_BTN_Schliessen.Image")));
            this._BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Schliessen.Location = new System.Drawing.Point(1095, 10);
            this._BTN_Schliessen.Name = "_BTN_Schliessen";
            this._BTN_Schliessen.Size = new System.Drawing.Size(80, 23);
            this._BTN_Schliessen.TabIndex = 16;
            this._BTN_Schliessen.Text = "Schließen";
            this._BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Schliessen.UseVisualStyleBackColor = true;
            this._BTN_Schliessen.Click += new System.EventHandler(this.BTN_Schliessen_Click);
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.AdressenTableAdapter = null;
            this.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.BelegeTableAdapter = null;
            this.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.Connection = null;
            this.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.FirmenNameTableAdapter = null;
            this.TableAdapterManager.KontakteTableAdapter = null;
            this.TableAdapterManager.KontoTableAdapter = null;
            this.TableAdapterManager.LogTabelleTableAdapter = null;
            this.TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.propertiesTableAdapter = null;
            this.TableAdapterManager.SachbearbeiterTableAdapter = null;
            this.TableAdapterManager.StaatenTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SachbearbeiterTableAdapter
            // 
            this.SachbearbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // TC_Administration
            // 
            this.TC_Administration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Administration.Controls.Add(this.TabPage1);
            this.TC_Administration.Controls.Add(this.TabPage2);
            this.TC_Administration.Controls.Add(this.TabPage3);
            this.TC_Administration.Controls.Add(this.TabPage4);
            this.TC_Administration.Controls.Add(this.TabPage5);
            this.TC_Administration.Controls.Add(this.Belege);
            this.TC_Administration.Location = new System.Drawing.Point(3, 70);
            this.TC_Administration.Name = "TC_Administration";
            this.TC_Administration.SelectedIndex = 0;
            this.TC_Administration.Size = new System.Drawing.Size(1179, 400);
            this.TC_Administration.TabIndex = 30;
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.Controls.Add(this.bindingNavigator4);
            this.TabPage1.Controls.Add(this.propertiesDataGridView);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(1171, 374);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Konfiguration";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.toolStripButton13;
            this.bindingNavigator4.BindingSource = this.FirmenNameBindingSource;
            this.bindingNavigator4.CountItem = this.toolStripLabel6;
            this.bindingNavigator4.DeleteItem = this.toolStripButton20;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton27,
            this.toolStripButton34,
            this.toolStripSeparator16,
            this.toolStripTextBox6,
            this.toolStripLabel6,
            this.toolStripSeparator17,
            this.toolStripButton35,
            this.toolStripButton36,
            this.toolStripSeparator18,
            this.toolStripButton13,
            this.toolStripButton20,
            this._BNAV_PropertiesSave});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 346);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton27;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton36;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton35;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton34;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox6;
            this.bindingNavigator4.Size = new System.Drawing.Size(1165, 25);
            this.bindingNavigator4.TabIndex = 11;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Neu hinzufügen";
            // 
            // FirmenNameBindingSource
            // 
            this.FirmenNameBindingSource.DataMember = "FirmenName";
            this.FirmenNameBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel6.Text = "von {0}";
            this.toolStripLabel6.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // toolStripButton20
            // 
            this.toolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton20.Image")));
            this.toolStripButton20.Name = "toolStripButton20";
            this.toolStripButton20.RightToLeftAutoMirrorImage = true;
            this.toolStripButton20.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton20.Text = "Löschen";
            // 
            // toolStripButton27
            // 
            this.toolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton27.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton27.Image")));
            this.toolStripButton27.Name = "toolStripButton27";
            this.toolStripButton27.RightToLeftAutoMirrorImage = true;
            this.toolStripButton27.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton27.Text = "Erste verschieben";
            // 
            // toolStripButton34
            // 
            this.toolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton34.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton34.Image")));
            this.toolStripButton34.Name = "toolStripButton34";
            this.toolStripButton34.RightToLeftAutoMirrorImage = true;
            this.toolStripButton34.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton34.Text = "Vorherige verschieben";
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox6
            // 
            this.toolStripTextBox6.AccessibleName = "Position";
            this.toolStripTextBox6.AutoSize = false;
            this.toolStripTextBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toolStripTextBox6.Name = "toolStripTextBox6";
            this.toolStripTextBox6.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox6.Text = "0";
            this.toolStripTextBox6.ToolTipText = "Aktuelle Position";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton35
            // 
            this.toolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton35.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton35.Image")));
            this.toolStripButton35.Name = "toolStripButton35";
            this.toolStripButton35.RightToLeftAutoMirrorImage = true;
            this.toolStripButton35.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton35.Text = "Nächste verschieben";
            // 
            // toolStripButton36
            // 
            this.toolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton36.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton36.Image")));
            this.toolStripButton36.Name = "toolStripButton36";
            this.toolStripButton36.RightToLeftAutoMirrorImage = true;
            this.toolStripButton36.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton36.Text = "Letzte verschieben";
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_PropertiesSave
            // 
            this._BNAV_PropertiesSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_PropertiesSave.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_PropertiesSave.Image")));
            this._BNAV_PropertiesSave.Name = "_BNAV_PropertiesSave";
            this._BNAV_PropertiesSave.Size = new System.Drawing.Size(23, 22);
            this._BNAV_PropertiesSave.Text = "Daten speichern";
            this._BNAV_PropertiesSave.Click += new System.EventHandler(this._BNAV_PropertiesSave_Click);
            // 
            // propertiesDataGridView
            // 
            this.propertiesDataGridView.AutoGenerateColumns = false;
            this.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.propertiesDataGridView.DataSource = this.propertiesBindingSource;
            this.propertiesDataGridView.Location = new System.Drawing.Point(6, 6);
            this.propertiesDataGridView.Name = "propertiesDataGridView";
            this.propertiesDataGridView.Size = new System.Drawing.Size(1158, 302);
            this.propertiesDataGridView.TabIndex = 0;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "properties";
            this.propertiesBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // TabPage2
            // 
            this.TabPage2.AutoScroll = true;
            this.TabPage2.Controls.Add(InaktivLabel);
            this.TabPage2.Controls.Add(this.InaktivCheckBox);
            this.TabPage2.Controls.Add(this.BindingNavigator1);
            this.TabPage2.Controls.Add(ChangedLabel);
            this.TabPage2.Controls.Add(this.ChangedDateTimePicker);
            this.TabPage2.Controls.Add(LoginLabel);
            this.TabPage2.Controls.Add(this.LoginTextBox);
            this.TabPage2.Controls.Add(FirmenNameLabel);
            this.TabPage2.Controls.Add(this.FirmenNameTextBox);
            this.TabPage2.Controls.Add(IDFirmenNameLabel1);
            this.TabPage2.Controls.Add(this.IDFirmenNameTextBox1);
            this.TabPage2.Controls.Add(this.FirmenNameDataGridView);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(1171, 374);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "FirmenName";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // InaktivCheckBox
            // 
            this.InaktivCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.FirmenNameBindingSource, "inaktiv", true));
            this.InaktivCheckBox.Location = new System.Drawing.Point(98, 112);
            this.InaktivCheckBox.Name = "InaktivCheckBox";
            this.InaktivCheckBox.Size = new System.Drawing.Size(200, 24);
            this.InaktivCheckBox.TabIndex = 11;
            this.InaktivCheckBox.Text = "Geschäftspartner deaktivieren";
            this.InaktivCheckBox.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator1
            // 
            this.BindingNavigator1.AddNewItem = this.ToolStripButton21;
            this.BindingNavigator1.BindingSource = this.FirmenNameBindingSource;
            this.BindingNavigator1.CountItem = this.ToolStripLabel4;
            this.BindingNavigator1.DeleteItem = this.ToolStripButton22;
            this.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton23,
            this.ToolStripButton24,
            this.ToolStripSeparator10,
            this.ToolStripTextBox4,
            this.ToolStripLabel4,
            this.ToolStripSeparator11,
            this.ToolStripButton25,
            this.ToolStripButton26,
            this.ToolStripSeparator12,
            this.ToolStripButton21,
            this.ToolStripButton22,
            this._BNAV_FirmenNameSave});
            this.BindingNavigator1.Location = new System.Drawing.Point(3, 346);
            this.BindingNavigator1.MoveFirstItem = this.ToolStripButton23;
            this.BindingNavigator1.MoveLastItem = this.ToolStripButton26;
            this.BindingNavigator1.MoveNextItem = this.ToolStripButton25;
            this.BindingNavigator1.MovePreviousItem = this.ToolStripButton24;
            this.BindingNavigator1.Name = "BindingNavigator1";
            this.BindingNavigator1.PositionItem = this.ToolStripTextBox4;
            this.BindingNavigator1.Size = new System.Drawing.Size(1165, 25);
            this.BindingNavigator1.TabIndex = 10;
            this.BindingNavigator1.Text = "BindingNavigator1";
            // 
            // ToolStripButton21
            // 
            this.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton21.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton21.Image")));
            this.ToolStripButton21.Name = "ToolStripButton21";
            this.ToolStripButton21.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton21.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton21.Text = "Neu hinzufügen";
            // 
            // ToolStripLabel4
            // 
            this.ToolStripLabel4.Name = "ToolStripLabel4";
            this.ToolStripLabel4.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel4.Text = "von {0}";
            this.ToolStripLabel4.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton22
            // 
            this.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton22.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton22.Image")));
            this.ToolStripButton22.Name = "ToolStripButton22";
            this.ToolStripButton22.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton22.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton22.Text = "Löschen";
            // 
            // ToolStripButton23
            // 
            this.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton23.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton23.Image")));
            this.ToolStripButton23.Name = "ToolStripButton23";
            this.ToolStripButton23.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton23.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton23.Text = "Erste verschieben";
            // 
            // ToolStripButton24
            // 
            this.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton24.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton24.Image")));
            this.ToolStripButton24.Name = "ToolStripButton24";
            this.ToolStripButton24.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton24.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton24.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripTextBox4
            // 
            this.ToolStripTextBox4.AccessibleName = "Position";
            this.ToolStripTextBox4.AutoSize = false;
            this.ToolStripTextBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripTextBox4.Name = "ToolStripTextBox4";
            this.ToolStripTextBox4.Size = new System.Drawing.Size(50, 25);
            this.ToolStripTextBox4.Text = "0";
            this.ToolStripTextBox4.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton25
            // 
            this.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton25.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton25.Image")));
            this.ToolStripButton25.Name = "ToolStripButton25";
            this.ToolStripButton25.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton25.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton25.Text = "Nächste verschieben";
            // 
            // ToolStripButton26
            // 
            this.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton26.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton26.Image")));
            this.ToolStripButton26.Name = "ToolStripButton26";
            this.ToolStripButton26.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton26.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton26.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator12
            // 
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_FirmenNameSave
            // 
            this._BNAV_FirmenNameSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_FirmenNameSave.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_FirmenNameSave.Image")));
            this._BNAV_FirmenNameSave.Name = "_BNAV_FirmenNameSave";
            this._BNAV_FirmenNameSave.Size = new System.Drawing.Size(23, 22);
            this._BNAV_FirmenNameSave.Text = "Daten speichern";
            this._BNAV_FirmenNameSave.Click += new System.EventHandler(this.BNAV_FirmenNameSave_Click);
            // 
            // ChangedDateTimePicker
            // 
            this.ChangedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.FirmenNameBindingSource, "changed", true));
            this.ChangedDateTimePicker.Location = new System.Drawing.Point(98, 86);
            this.ChangedDateTimePicker.Name = "ChangedDateTimePicker";
            this.ChangedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ChangedDateTimePicker.TabIndex = 8;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "Login", true));
            this.LoginTextBox.Location = new System.Drawing.Point(98, 60);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(349, 20);
            this.LoginTextBox.TabIndex = 6;
            // 
            // FirmenNameTextBox
            // 
            this.FirmenNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "FirmenName", true));
            this.FirmenNameTextBox.Location = new System.Drawing.Point(98, 34);
            this.FirmenNameTextBox.Name = "FirmenNameTextBox";
            this.FirmenNameTextBox.Size = new System.Drawing.Size(349, 20);
            this.FirmenNameTextBox.TabIndex = 4;
            // 
            // IDFirmenNameTextBox1
            // 
            this.IDFirmenNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "IDFirmenName", true));
            this.IDFirmenNameTextBox1.Location = new System.Drawing.Point(98, 8);
            this.IDFirmenNameTextBox1.Name = "IDFirmenNameTextBox1";
            this.IDFirmenNameTextBox1.Size = new System.Drawing.Size(349, 20);
            this.IDFirmenNameTextBox1.TabIndex = 2;
            // 
            // FirmenNameDataGridView
            // 
            this.FirmenNameDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirmenNameDataGridView.AutoGenerateColumns = false;
            this.FirmenNameDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FirmenNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirmenNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.Login,
            this.changed,
            this.inaktiv});
            this.FirmenNameDataGridView.DataSource = this.FirmenNameBindingSource;
            this.FirmenNameDataGridView.Location = new System.Drawing.Point(453, 6);
            this.FirmenNameDataGridView.Name = "FirmenNameDataGridView";
            this.FirmenNameDataGridView.RowHeadersVisible = false;
            this.FirmenNameDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FirmenNameDataGridView.Size = new System.Drawing.Size(653, 359);
            this.FirmenNameDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn1.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.Width = 80;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "FirmenName";
            this.DataGridViewTextBoxColumn2.HeaderText = "Firmen-Name";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.Width = 220;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.Width = 70;
            // 
            // changed
            // 
            this.changed.DataPropertyName = "changed";
            this.changed.HeaderText = "changed";
            this.changed.Name = "changed";
            this.changed.Width = 180;
            // 
            // inaktiv
            // 
            this.inaktiv.DataPropertyName = "inaktiv";
            this.inaktiv.HeaderText = "inaktiv";
            this.inaktiv.Name = "inaktiv";
            this.inaktiv.Width = 50;
            // 
            // TabPage3
            // 
            this.TabPage3.AutoScroll = true;
            this.TabPage3.Controls.Add(this.BindingNavigator2);
            this.TabPage3.Controls.Add(AnlageDatumLabel);
            this.TabPage3.Controls.Add(this.AnlageDatumDateTimePicker);
            this.TabPage3.Controls.Add(KontoNameLabel);
            this.TabPage3.Controls.Add(this.KontoNameTextBox);
            this.TabPage3.Controls.Add(IDFirmenNameLabel2);
            this.TabPage3.Controls.Add(this.IDFirmenNameTextBox2);
            this.TabPage3.Controls.Add(IDKontoLabel);
            this.TabPage3.Controls.Add(this.IDKontoTextBox);
            this.TabPage3.Controls.Add(this.KontoDataGridView);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(1171, 374);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Konto";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator2
            // 
            this.BindingNavigator2.AddNewItem = this.ToolStripButton14;
            this.BindingNavigator2.BindingSource = this.KontoBindingSource;
            this.BindingNavigator2.CountItem = this.ToolStripLabel3;
            this.BindingNavigator2.DeleteItem = this.ToolStripButton15;
            this.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton16,
            this.ToolStripButton17,
            this.ToolStripSeparator7,
            this.ToolStripTextBox3,
            this.ToolStripLabel3,
            this.ToolStripSeparator8,
            this.ToolStripButton18,
            this.ToolStripButton19,
            this.ToolStripSeparator9,
            this.ToolStripButton14,
            this.ToolStripButton15,
            this._BNAV_KontoSave});
            this.BindingNavigator2.Location = new System.Drawing.Point(3, 346);
            this.BindingNavigator2.MoveFirstItem = this.ToolStripButton16;
            this.BindingNavigator2.MoveLastItem = this.ToolStripButton19;
            this.BindingNavigator2.MoveNextItem = this.ToolStripButton18;
            this.BindingNavigator2.MovePreviousItem = this.ToolStripButton17;
            this.BindingNavigator2.Name = "BindingNavigator2";
            this.BindingNavigator2.PositionItem = this.ToolStripTextBox3;
            this.BindingNavigator2.Size = new System.Drawing.Size(1165, 25);
            this.BindingNavigator2.TabIndex = 9;
            this.BindingNavigator2.Text = "BindingNavigator1";
            // 
            // ToolStripButton14
            // 
            this.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton14.Image")));
            this.ToolStripButton14.Name = "ToolStripButton14";
            this.ToolStripButton14.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton14.Text = "Neu hinzufügen";
            // 
            // KontoBindingSource
            // 
            this.KontoBindingSource.DataMember = "Konto";
            this.KontoBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // ToolStripLabel3
            // 
            this.ToolStripLabel3.Name = "ToolStripLabel3";
            this.ToolStripLabel3.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel3.Text = "von {0}";
            this.ToolStripLabel3.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton15
            // 
            this.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton15.Image")));
            this.ToolStripButton15.Name = "ToolStripButton15";
            this.ToolStripButton15.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton15.Text = "Löschen";
            // 
            // ToolStripButton16
            // 
            this.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton16.Image")));
            this.ToolStripButton16.Name = "ToolStripButton16";
            this.ToolStripButton16.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton16.Text = "Erste verschieben";
            // 
            // ToolStripButton17
            // 
            this.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton17.Image")));
            this.ToolStripButton17.Name = "ToolStripButton17";
            this.ToolStripButton17.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton17.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator7
            // 
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripTextBox3
            // 
            this.ToolStripTextBox3.AccessibleName = "Position";
            this.ToolStripTextBox3.AutoSize = false;
            this.ToolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripTextBox3.Name = "ToolStripTextBox3";
            this.ToolStripTextBox3.Size = new System.Drawing.Size(50, 25);
            this.ToolStripTextBox3.Text = "0";
            this.ToolStripTextBox3.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton18
            // 
            this.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton18.Image")));
            this.ToolStripButton18.Name = "ToolStripButton18";
            this.ToolStripButton18.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton18.Text = "Nächste verschieben";
            // 
            // ToolStripButton19
            // 
            this.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton19.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton19.Image")));
            this.ToolStripButton19.Name = "ToolStripButton19";
            this.ToolStripButton19.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton19.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton19.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_KontoSave
            // 
            this._BNAV_KontoSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_KontoSave.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_KontoSave.Image")));
            this._BNAV_KontoSave.Name = "_BNAV_KontoSave";
            this._BNAV_KontoSave.Size = new System.Drawing.Size(23, 22);
            this._BNAV_KontoSave.Text = "Daten speichern";
            this._BNAV_KontoSave.Click += new System.EventHandler(this.BNAV_KontoSave_Click);
            // 
            // AnlageDatumDateTimePicker
            // 
            this.AnlageDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.KontoBindingSource, "Datum", true));
            this.AnlageDatumDateTimePicker.Location = new System.Drawing.Point(696, 85);
            this.AnlageDatumDateTimePicker.Name = "AnlageDatumDateTimePicker";
            this.AnlageDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.AnlageDatumDateTimePicker.TabIndex = 8;
            // 
            // KontoNameTextBox
            // 
            this.KontoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontoBindingSource, "KontoName", true));
            this.KontoNameTextBox.Location = new System.Drawing.Point(696, 59);
            this.KontoNameTextBox.Name = "KontoNameTextBox";
            this.KontoNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.KontoNameTextBox.TabIndex = 6;
            // 
            // IDFirmenNameTextBox2
            // 
            this.IDFirmenNameTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontoBindingSource, "IDFirmenName", true));
            this.IDFirmenNameTextBox2.Location = new System.Drawing.Point(696, 33);
            this.IDFirmenNameTextBox2.Name = "IDFirmenNameTextBox2";
            this.IDFirmenNameTextBox2.Size = new System.Drawing.Size(100, 20);
            this.IDFirmenNameTextBox2.TabIndex = 4;
            // 
            // IDKontoTextBox
            // 
            this.IDKontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontoBindingSource, "IDKonto", true));
            this.IDKontoTextBox.Location = new System.Drawing.Point(696, 7);
            this.IDKontoTextBox.Name = "IDKontoTextBox";
            this.IDKontoTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDKontoTextBox.TabIndex = 2;
            // 
            // KontoDataGridView
            // 
            this.KontoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.KontoDataGridView.AutoGenerateColumns = false;
            this.KontoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.KontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.Datum});
            this.KontoDataGridView.DataSource = this.KontoBindingSource;
            this.KontoDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.KontoDataGridView.Location = new System.Drawing.Point(7, 6);
            this.KontoDataGridView.Name = "KontoDataGridView";
            this.KontoDataGridView.RowHeadersVisible = false;
            this.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KontoDataGridView.Size = new System.Drawing.Size(472, 395);
            this.KontoDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto";
            this.DataGridViewTextBoxColumn3.HeaderText = "IDKonto";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.Width = 70;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "KontoName";
            this.DataGridViewTextBoxColumn5.HeaderText = "KontoName";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // TabPage4
            // 
            this.TabPage4.AutoScroll = true;
            this.TabPage4.Controls.Add(this.BindingNavigator3);
            this.TabPage4.Controls.Add(WebseiteLabel);
            this.TabPage4.Controls.Add(this.WebseiteTextBox);
            this.TabPage4.Controls.Add(UStIdNrLabel);
            this.TabPage4.Controls.Add(this.UStIdNrTextBox);
            this.TabPage4.Controls.Add(LandLabel);
            this.TabPage4.Controls.Add(this.LandTextBox);
            this.TabPage4.Controls.Add(BundeslandLabel);
            this.TabPage4.Controls.Add(this.BundeslandTextBox);
            this.TabPage4.Controls.Add(OrtLabel);
            this.TabPage4.Controls.Add(this.OrtTextBox);
            this.TabPage4.Controls.Add(PLZLabel);
            this.TabPage4.Controls.Add(this.PLZTextBox);
            this.TabPage4.Controls.Add(PostfachLabel);
            this.TabPage4.Controls.Add(this.PostfachTextBox);
            this.TabPage4.Controls.Add(StraßeLabel);
            this.TabPage4.Controls.Add(this.StraßeTextBox);
            this.TabPage4.Controls.Add(AdresstypLabel);
            this.TabPage4.Controls.Add(this.AdresstypTextBox);
            this.TabPage4.Controls.Add(IDKontoLabel1);
            this.TabPage4.Controls.Add(this.IDKontoTextBox1);
            this.TabPage4.Controls.Add(IDFirmenNameLabel3);
            this.TabPage4.Controls.Add(this.IDFirmenNameTextBox3);
            this.TabPage4.Controls.Add(IDAdresseLabel1);
            this.TabPage4.Controls.Add(this.IDAdresseTextBox1);
            this.TabPage4.Controls.Add(this.DataGridView1);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(1171, 374);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Adressen";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator3
            // 
            this.BindingNavigator3.AddNewItem = this.ToolStripButton7;
            this.BindingNavigator3.BindingSource = this.AdressenBindingSource;
            this.BindingNavigator3.CountItem = this.ToolStripLabel2;
            this.BindingNavigator3.DeleteItem = this.ToolStripButton8;
            this.BindingNavigator3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton9,
            this.ToolStripButton10,
            this.ToolStripSeparator4,
            this.ToolStripTextBox2,
            this.ToolStripLabel2,
            this.ToolStripSeparator5,
            this.ToolStripButton11,
            this.ToolStripButton12,
            this.ToolStripSeparator6,
            this.ToolStripButton7,
            this.ToolStripButton8,
            this._BNAV_AdressenSave});
            this.BindingNavigator3.Location = new System.Drawing.Point(3, 346);
            this.BindingNavigator3.MoveFirstItem = this.ToolStripButton9;
            this.BindingNavigator3.MoveLastItem = this.ToolStripButton12;
            this.BindingNavigator3.MoveNextItem = this.ToolStripButton11;
            this.BindingNavigator3.MovePreviousItem = this.ToolStripButton10;
            this.BindingNavigator3.Name = "BindingNavigator3";
            this.BindingNavigator3.PositionItem = this.ToolStripTextBox2;
            this.BindingNavigator3.Size = new System.Drawing.Size(1165, 25);
            this.BindingNavigator3.TabIndex = 25;
            this.BindingNavigator3.Text = "BindingNavigator1";
            // 
            // ToolStripButton7
            // 
            this.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton7.Image")));
            this.ToolStripButton7.Name = "ToolStripButton7";
            this.ToolStripButton7.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton7.Text = "Neu hinzufügen";
            // 
            // AdressenBindingSource
            // 
            this.AdressenBindingSource.DataMember = "Adressen";
            this.AdressenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel2.Text = "von {0}";
            this.ToolStripLabel2.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton8
            // 
            this.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton8.Image")));
            this.ToolStripButton8.Name = "ToolStripButton8";
            this.ToolStripButton8.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton8.Text = "Löschen";
            // 
            // ToolStripButton9
            // 
            this.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton9.Image")));
            this.ToolStripButton9.Name = "ToolStripButton9";
            this.ToolStripButton9.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton9.Text = "Erste verschieben";
            // 
            // ToolStripButton10
            // 
            this.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton10.Image")));
            this.ToolStripButton10.Name = "ToolStripButton10";
            this.ToolStripButton10.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton10.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripTextBox2
            // 
            this.ToolStripTextBox2.AccessibleName = "Position";
            this.ToolStripTextBox2.AutoSize = false;
            this.ToolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripTextBox2.Name = "ToolStripTextBox2";
            this.ToolStripTextBox2.Size = new System.Drawing.Size(50, 25);
            this.ToolStripTextBox2.Text = "0";
            this.ToolStripTextBox2.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton11
            // 
            this.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton11.Image")));
            this.ToolStripButton11.Name = "ToolStripButton11";
            this.ToolStripButton11.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton11.Text = "Nächste verschieben";
            // 
            // ToolStripButton12
            // 
            this.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton12.Image")));
            this.ToolStripButton12.Name = "ToolStripButton12";
            this.ToolStripButton12.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton12.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator6
            // 
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_AdressenSave
            // 
            this._BNAV_AdressenSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_AdressenSave.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_AdressenSave.Image")));
            this._BNAV_AdressenSave.Name = "_BNAV_AdressenSave";
            this._BNAV_AdressenSave.Size = new System.Drawing.Size(23, 22);
            this._BNAV_AdressenSave.Text = "Daten speichern";
            this._BNAV_AdressenSave.Click += new System.EventHandler(this.BNAV_AdressenSave_Click);
            // 
            // WebseiteTextBox
            // 
            this.WebseiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Webseite", true));
            this.WebseiteTextBox.Location = new System.Drawing.Point(795, 32);
            this.WebseiteTextBox.Name = "WebseiteTextBox";
            this.WebseiteTextBox.Size = new System.Drawing.Size(257, 20);
            this.WebseiteTextBox.TabIndex = 24;
            // 
            // UStIdNrTextBox
            // 
            this.UStIdNrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "UStIdNr", true));
            this.UStIdNrTextBox.Location = new System.Drawing.Point(268, 30);
            this.UStIdNrTextBox.Name = "UStIdNrTextBox";
            this.UStIdNrTextBox.Size = new System.Drawing.Size(100, 20);
            this.UStIdNrTextBox.TabIndex = 22;
            // 
            // LandTextBox
            // 
            this.LandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Land", true));
            this.LandTextBox.Location = new System.Drawing.Point(951, 6);
            this.LandTextBox.Name = "LandTextBox";
            this.LandTextBox.Size = new System.Drawing.Size(100, 20);
            this.LandTextBox.TabIndex = 20;
            // 
            // BundeslandTextBox
            // 
            this.BundeslandTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Bundesland", true));
            this.BundeslandTextBox.Location = new System.Drawing.Point(795, 6);
            this.BundeslandTextBox.Name = "BundeslandTextBox";
            this.BundeslandTextBox.Size = new System.Drawing.Size(100, 20);
            this.BundeslandTextBox.TabIndex = 18;
            // 
            // OrtTextBox
            // 
            this.OrtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Ort", true));
            this.OrtTextBox.Location = new System.Drawing.Point(572, 56);
            this.OrtTextBox.Name = "OrtTextBox";
            this.OrtTextBox.Size = new System.Drawing.Size(140, 20);
            this.OrtTextBox.TabIndex = 16;
            // 
            // PLZTextBox
            // 
            this.PLZTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "PLZ", true));
            this.PLZTextBox.Location = new System.Drawing.Point(454, 56);
            this.PLZTextBox.Name = "PLZTextBox";
            this.PLZTextBox.Size = new System.Drawing.Size(67, 20);
            this.PLZTextBox.TabIndex = 14;
            // 
            // PostfachTextBox
            // 
            this.PostfachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Postfach", true));
            this.PostfachTextBox.Location = new System.Drawing.Point(454, 5);
            this.PostfachTextBox.Name = "PostfachTextBox";
            this.PostfachTextBox.Size = new System.Drawing.Size(100, 20);
            this.PostfachTextBox.TabIndex = 12;
            // 
            // StraßeTextBox
            // 
            this.StraßeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Straße", true));
            this.StraßeTextBox.Location = new System.Drawing.Point(454, 30);
            this.StraßeTextBox.Name = "StraßeTextBox";
            this.StraßeTextBox.Size = new System.Drawing.Size(258, 20);
            this.StraßeTextBox.TabIndex = 10;
            // 
            // AdresstypTextBox
            // 
            this.AdresstypTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Adresstyp", true));
            this.AdresstypTextBox.Location = new System.Drawing.Point(268, 4);
            this.AdresstypTextBox.Name = "AdresstypTextBox";
            this.AdresstypTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdresstypTextBox.TabIndex = 8;
            // 
            // IDKontoTextBox1
            // 
            this.IDKontoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDKonto", true));
            this.IDKontoTextBox1.Location = new System.Drawing.Point(92, 30);
            this.IDKontoTextBox1.Name = "IDKontoTextBox1";
            this.IDKontoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDKontoTextBox1.TabIndex = 6;
            // 
            // IDFirmenNameTextBox3
            // 
            this.IDFirmenNameTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDFirmenName", true));
            this.IDFirmenNameTextBox3.Location = new System.Drawing.Point(92, 55);
            this.IDFirmenNameTextBox3.Name = "IDFirmenNameTextBox3";
            this.IDFirmenNameTextBox3.Size = new System.Drawing.Size(100, 20);
            this.IDFirmenNameTextBox3.TabIndex = 4;
            // 
            // IDAdresseTextBox1
            // 
            this.IDAdresseTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDAdresse", true));
            this.IDAdresseTextBox1.Location = new System.Drawing.Point(92, 4);
            this.IDAdresseTextBox1.Name = "IDAdresseTextBox1";
            this.IDAdresseTextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDAdresseTextBox1.TabIndex = 2;
            // 
            // DataGridView1
            // 
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAdresse,
            this.DataGridViewTextBoxColumn7,
            this.IDKonto,
            this.Adresstyp,
            this.Straße,
            this.Postfach,
            this.PLZ,
            this.Ort,
            this.Bundesland,
            this.Land,
            this.UStIdNr,
            this.Webseite});
            this.DataGridView1.DataSource = this.AdressenBindingSource;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridView1.Location = new System.Drawing.Point(7, 98);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.Size = new System.Drawing.Size(1156, 245);
            this.DataGridView1.TabIndex = 1;
            // 
            // IDAdresse
            // 
            this.IDAdresse.DataPropertyName = "IDAdresse";
            this.IDAdresse.HeaderText = "IDAdresse";
            this.IDAdresse.Name = "IDAdresse";
            this.IDAdresse.Width = 70;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn7.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Width = 70;
            // 
            // IDKonto
            // 
            this.IDKonto.DataPropertyName = "IDKonto";
            this.IDKonto.HeaderText = "IDKonto";
            this.IDKonto.Name = "IDKonto";
            this.IDKonto.Width = 70;
            // 
            // Adresstyp
            // 
            this.Adresstyp.DataPropertyName = "Adresstyp";
            this.Adresstyp.HeaderText = "Adresstyp";
            this.Adresstyp.Name = "Adresstyp";
            // 
            // Straße
            // 
            this.Straße.DataPropertyName = "Straße";
            this.Straße.HeaderText = "Straße";
            this.Straße.Name = "Straße";
            // 
            // Postfach
            // 
            this.Postfach.DataPropertyName = "Postfach";
            this.Postfach.HeaderText = "Postfach";
            this.Postfach.Name = "Postfach";
            // 
            // PLZ
            // 
            this.PLZ.DataPropertyName = "PLZ";
            this.PLZ.HeaderText = "PLZ";
            this.PLZ.Name = "PLZ";
            this.PLZ.Width = 50;
            // 
            // Ort
            // 
            this.Ort.DataPropertyName = "Ort";
            this.Ort.HeaderText = "Ort";
            this.Ort.Name = "Ort";
            // 
            // Bundesland
            // 
            this.Bundesland.DataPropertyName = "Bundesland";
            this.Bundesland.HeaderText = "Bundesland";
            this.Bundesland.Name = "Bundesland";
            // 
            // Land
            // 
            this.Land.DataPropertyName = "Land";
            this.Land.HeaderText = "Land";
            this.Land.Name = "Land";
            // 
            // UStIdNr
            // 
            this.UStIdNr.DataPropertyName = "UStIdNr";
            this.UStIdNr.HeaderText = "UStIdNr";
            this.UStIdNr.Name = "UStIdNr";
            // 
            // Webseite
            // 
            this.Webseite.DataPropertyName = "Webseite";
            this.Webseite.HeaderText = "Webseite";
            this.Webseite.Name = "Webseite";
            // 
            // TabPage5
            // 
            this.TabPage5.AutoScroll = true;
            this.TabPage5.Controls.Add(this.SachbearbeiterBindingNavigator);
            this.TabPage5.Controls.Add(IDAdresseLabel2);
            this.TabPage5.Controls.Add(this.IDAdresseTextBox2);
            this.TabPage5.Controls.Add(FaxnummerLabel);
            this.TabPage5.Controls.Add(this.FaxnummerTextBox);
            this.TabPage5.Controls.Add(MobiltelefonLabel);
            this.TabPage5.Controls.Add(this.MobiltelefonTextBox);
            this.TabPage5.Controls.Add(TelefonPrivatLabel);
            this.TabPage5.Controls.Add(this.TelefonPrivatTextBox);
            this.TabPage5.Controls.Add(TelefonGeschaeftlichLabel);
            this.TabPage5.Controls.Add(this.TelefonGeschaeftlichTextBox);
            this.TabPage5.Controls.Add(JobtitleLabel);
            this.TabPage5.Controls.Add(this.JobtitleTextBox);
            this.TabPage5.Controls.Add(EmailAddresseLabel);
            this.TabPage5.Controls.Add(this.EmailAddresseTextBox);
            this.TabPage5.Controls.Add(AnredeLabel);
            this.TabPage5.Controls.Add(this.AnredeTextBox);
            this.TabPage5.Controls.Add(NachnameLabel);
            this.TabPage5.Controls.Add(this.NachnameTextBox);
            this.TabPage5.Controls.Add(VornameLabel);
            this.TabPage5.Controls.Add(this.VornameTextBox);
            this.TabPage5.Controls.Add(IDFirmenNameLabel4);
            this.TabPage5.Controls.Add(this.IDFirmenNameTextBox4);
            this.TabPage5.Controls.Add(IDKontaktLabel1);
            this.TabPage5.Controls.Add(this.IDKontaktTextBox1);
            this.TabPage5.Controls.Add(this.DataGridView2);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(1171, 374);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Kontakte";
            this.TabPage5.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterBindingNavigator
            // 
            this.SachbearbeiterBindingNavigator.AddNewItem = this.ToolStripButton1;
            this.SachbearbeiterBindingNavigator.BindingSource = this.KontakteBindingSource;
            this.SachbearbeiterBindingNavigator.CountItem = this.ToolStripLabel1;
            this.SachbearbeiterBindingNavigator.DeleteItem = this.ToolStripButton2;
            this.SachbearbeiterBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SachbearbeiterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton3,
            this.ToolStripButton4,
            this.ToolStripSeparator1,
            this.ToolStripTextBox1,
            this.ToolStripLabel1,
            this.ToolStripSeparator2,
            this.ToolStripButton5,
            this.ToolStripButton6,
            this.ToolStripSeparator3,
            this.ToolStripButton1,
            this.ToolStripButton2,
            this._BNAV_KontakteSave});
            this.SachbearbeiterBindingNavigator.Location = new System.Drawing.Point(3, 346);
            this.SachbearbeiterBindingNavigator.MoveFirstItem = this.ToolStripButton3;
            this.SachbearbeiterBindingNavigator.MoveLastItem = this.ToolStripButton6;
            this.SachbearbeiterBindingNavigator.MoveNextItem = this.ToolStripButton5;
            this.SachbearbeiterBindingNavigator.MovePreviousItem = this.ToolStripButton4;
            this.SachbearbeiterBindingNavigator.Name = "SachbearbeiterBindingNavigator";
            this.SachbearbeiterBindingNavigator.PositionItem = this.ToolStripTextBox1;
            this.SachbearbeiterBindingNavigator.Size = new System.Drawing.Size(1165, 25);
            this.SachbearbeiterBindingNavigator.TabIndex = 25;
            this.SachbearbeiterBindingNavigator.Text = "BindingNavigator1";
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton1.Image")));
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton1.Text = "Neu hinzufügen";
            // 
            // KontakteBindingSource
            // 
            this.KontakteBindingSource.DataMember = "Kontakte";
            this.KontakteBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel1.Text = "von {0}";
            this.ToolStripLabel1.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton2.Text = "Löschen";
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton3.Image")));
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton3.Text = "Erste verschieben";
            // 
            // ToolStripButton4
            // 
            this.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton4.Image")));
            this.ToolStripButton4.Name = "ToolStripButton4";
            this.ToolStripButton4.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton4.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripTextBox1
            // 
            this.ToolStripTextBox1.AccessibleName = "Position";
            this.ToolStripTextBox1.AutoSize = false;
            this.ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripTextBox1.Name = "ToolStripTextBox1";
            this.ToolStripTextBox1.Size = new System.Drawing.Size(50, 25);
            this.ToolStripTextBox1.Text = "0";
            this.ToolStripTextBox1.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton5.Image")));
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton5.Text = "Nächste verschieben";
            // 
            // ToolStripButton6
            // 
            this.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton6.Image")));
            this.ToolStripButton6.Name = "ToolStripButton6";
            this.ToolStripButton6.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton6.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_KontakteSave
            // 
            this._BNAV_KontakteSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_KontakteSave.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_KontakteSave.Image")));
            this._BNAV_KontakteSave.Name = "_BNAV_KontakteSave";
            this._BNAV_KontakteSave.Size = new System.Drawing.Size(23, 22);
            this._BNAV_KontakteSave.Text = "Daten speichern";
            this._BNAV_KontakteSave.Click += new System.EventHandler(this.BNAV_KontakteSave_Click);
            // 
            // IDAdresseTextBox2
            // 
            this.IDAdresseTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDAdresse", true));
            this.IDAdresseTextBox2.Location = new System.Drawing.Point(94, 58);
            this.IDAdresseTextBox2.Name = "IDAdresseTextBox2";
            this.IDAdresseTextBox2.Size = new System.Drawing.Size(100, 20);
            this.IDAdresseTextBox2.TabIndex = 24;
            // 
            // FaxnummerTextBox
            // 
            this.FaxnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Faxnummer", true));
            this.FaxnummerTextBox.Location = new System.Drawing.Point(715, 83);
            this.FaxnummerTextBox.Name = "FaxnummerTextBox";
            this.FaxnummerTextBox.Size = new System.Drawing.Size(100, 20);
            this.FaxnummerTextBox.TabIndex = 22;
            // 
            // MobiltelefonTextBox
            // 
            this.MobiltelefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Mobiltelefon", true));
            this.MobiltelefonTextBox.Location = new System.Drawing.Point(715, 57);
            this.MobiltelefonTextBox.Name = "MobiltelefonTextBox";
            this.MobiltelefonTextBox.Size = new System.Drawing.Size(100, 20);
            this.MobiltelefonTextBox.TabIndex = 20;
            // 
            // TelefonPrivatTextBox
            // 
            this.TelefonPrivatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonPrivat", true));
            this.TelefonPrivatTextBox.Location = new System.Drawing.Point(715, 31);
            this.TelefonPrivatTextBox.Name = "TelefonPrivatTextBox";
            this.TelefonPrivatTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonPrivatTextBox.TabIndex = 18;
            // 
            // TelefonGeschaeftlichTextBox
            // 
            this.TelefonGeschaeftlichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonGeschaeftlich", true));
            this.TelefonGeschaeftlichTextBox.Location = new System.Drawing.Point(715, 5);
            this.TelefonGeschaeftlichTextBox.Name = "TelefonGeschaeftlichTextBox";
            this.TelefonGeschaeftlichTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefonGeschaeftlichTextBox.TabIndex = 16;
            // 
            // JobtitleTextBox
            // 
            this.JobtitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Jobtitle", true));
            this.JobtitleTextBox.Location = new System.Drawing.Point(484, 6);
            this.JobtitleTextBox.Name = "JobtitleTextBox";
            this.JobtitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.JobtitleTextBox.TabIndex = 14;
            // 
            // EmailAddresseTextBox
            // 
            this.EmailAddresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "EmailAddresse", true));
            this.EmailAddresseTextBox.Location = new System.Drawing.Point(484, 32);
            this.EmailAddresseTextBox.Name = "EmailAddresseTextBox";
            this.EmailAddresseTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailAddresseTextBox.TabIndex = 12;
            // 
            // AnredeTextBox
            // 
            this.AnredeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Anrede", true));
            this.AnredeTextBox.Location = new System.Drawing.Point(285, 6);
            this.AnredeTextBox.Name = "AnredeTextBox";
            this.AnredeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnredeTextBox.TabIndex = 10;
            // 
            // NachnameTextBox
            // 
            this.NachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Nachname", true));
            this.NachnameTextBox.Location = new System.Drawing.Point(285, 31);
            this.NachnameTextBox.Name = "NachnameTextBox";
            this.NachnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NachnameTextBox.TabIndex = 8;
            // 
            // VornameTextBox
            // 
            this.VornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Vorname", true));
            this.VornameTextBox.Location = new System.Drawing.Point(285, 57);
            this.VornameTextBox.Name = "VornameTextBox";
            this.VornameTextBox.Size = new System.Drawing.Size(100, 20);
            this.VornameTextBox.TabIndex = 6;
            // 
            // IDFirmenNameTextBox4
            // 
            this.IDFirmenNameTextBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDFirmenName", true));
            this.IDFirmenNameTextBox4.Location = new System.Drawing.Point(94, 32);
            this.IDFirmenNameTextBox4.Name = "IDFirmenNameTextBox4";
            this.IDFirmenNameTextBox4.Size = new System.Drawing.Size(100, 20);
            this.IDFirmenNameTextBox4.TabIndex = 4;
            // 
            // IDKontaktTextBox1
            // 
            this.IDKontaktTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDKontakt", true));
            this.IDKontaktTextBox1.Location = new System.Drawing.Point(94, 6);
            this.IDKontaktTextBox1.Name = "IDKontaktTextBox1";
            this.IDKontaktTextBox1.Size = new System.Drawing.Size(100, 20);
            this.IDKontaktTextBox1.TabIndex = 3;
            // 
            // DataGridView2
            // 
            this.DataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView2.AutoGenerateColumns = false;
            this.DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKontakt,
            this.IDFirmenName,
            this.Nachname,
            this.Vorname,
            this.EmailAddresseDataGridViewTextBoxColumn,
            this.JobtitleDataGridViewTextBoxColumn,
            this.TelefonGeschaeftlichDataGridViewTextBoxColumn,
            this.TelefonPrivatDataGridViewTextBoxColumn,
            this.MobiltelefonDataGridViewTextBoxColumn,
            this.FaxnummerDataGridViewTextBoxColumn,
            this.IDAdresseDataGridViewTextBoxColumn,
            this.AnredeDataGridViewTextBoxColumn});
            this.DataGridView2.DataSource = this.KontakteBindingSource;
            this.DataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridView2.Location = new System.Drawing.Point(7, 109);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView2.Size = new System.Drawing.Size(1158, 234);
            this.DataGridView2.TabIndex = 2;
            // 
            // IDKontakt
            // 
            this.IDKontakt.DataPropertyName = "IDKontakt";
            this.IDKontakt.HeaderText = "IDKontakt";
            this.IDKontakt.Name = "IDKontakt";
            this.IDKontakt.Width = 70;
            // 
            // IDFirmenName
            // 
            this.IDFirmenName.DataPropertyName = "IDFirmenName";
            this.IDFirmenName.HeaderText = "IDFirmenName";
            this.IDFirmenName.Name = "IDFirmenName";
            this.IDFirmenName.Width = 80;
            // 
            // Nachname
            // 
            this.Nachname.DataPropertyName = "Nachname";
            this.Nachname.HeaderText = "Nachname";
            this.Nachname.Name = "Nachname";
            this.Nachname.Width = 90;
            // 
            // Vorname
            // 
            this.Vorname.DataPropertyName = "Vorname";
            this.Vorname.HeaderText = "Vorname";
            this.Vorname.Name = "Vorname";
            this.Vorname.Width = 90;
            // 
            // EmailAddresseDataGridViewTextBoxColumn
            // 
            this.EmailAddresseDataGridViewTextBoxColumn.DataPropertyName = "EmailAddresse";
            this.EmailAddresseDataGridViewTextBoxColumn.HeaderText = "EmailAddresse";
            this.EmailAddresseDataGridViewTextBoxColumn.Name = "EmailAddresseDataGridViewTextBoxColumn";
            // 
            // JobtitleDataGridViewTextBoxColumn
            // 
            this.JobtitleDataGridViewTextBoxColumn.DataPropertyName = "Jobtitle";
            this.JobtitleDataGridViewTextBoxColumn.HeaderText = "Jobtitle";
            this.JobtitleDataGridViewTextBoxColumn.Name = "JobtitleDataGridViewTextBoxColumn";
            this.JobtitleDataGridViewTextBoxColumn.Width = 90;
            // 
            // TelefonGeschaeftlichDataGridViewTextBoxColumn
            // 
            this.TelefonGeschaeftlichDataGridViewTextBoxColumn.DataPropertyName = "TelefonGeschaeftlich";
            this.TelefonGeschaeftlichDataGridViewTextBoxColumn.HeaderText = "TelefonGeschaeftlich";
            this.TelefonGeschaeftlichDataGridViewTextBoxColumn.Name = "TelefonGeschaeftlichDataGridViewTextBoxColumn";
            // 
            // TelefonPrivatDataGridViewTextBoxColumn
            // 
            this.TelefonPrivatDataGridViewTextBoxColumn.DataPropertyName = "TelefonPrivat";
            this.TelefonPrivatDataGridViewTextBoxColumn.HeaderText = "TelefonPrivat";
            this.TelefonPrivatDataGridViewTextBoxColumn.Name = "TelefonPrivatDataGridViewTextBoxColumn";
            // 
            // MobiltelefonDataGridViewTextBoxColumn
            // 
            this.MobiltelefonDataGridViewTextBoxColumn.DataPropertyName = "Mobiltelefon";
            this.MobiltelefonDataGridViewTextBoxColumn.HeaderText = "Mobiltelefon";
            this.MobiltelefonDataGridViewTextBoxColumn.Name = "MobiltelefonDataGridViewTextBoxColumn";
            // 
            // FaxnummerDataGridViewTextBoxColumn
            // 
            this.FaxnummerDataGridViewTextBoxColumn.DataPropertyName = "Faxnummer";
            this.FaxnummerDataGridViewTextBoxColumn.HeaderText = "Faxnummer";
            this.FaxnummerDataGridViewTextBoxColumn.Name = "FaxnummerDataGridViewTextBoxColumn";
            // 
            // IDAdresseDataGridViewTextBoxColumn
            // 
            this.IDAdresseDataGridViewTextBoxColumn.DataPropertyName = "IDAdresse";
            this.IDAdresseDataGridViewTextBoxColumn.HeaderText = "IDAdresse";
            this.IDAdresseDataGridViewTextBoxColumn.Name = "IDAdresseDataGridViewTextBoxColumn";
            this.IDAdresseDataGridViewTextBoxColumn.Width = 70;
            // 
            // AnredeDataGridViewTextBoxColumn
            // 
            this.AnredeDataGridViewTextBoxColumn.DataPropertyName = "Anrede";
            this.AnredeDataGridViewTextBoxColumn.HeaderText = "Anrede";
            this.AnredeDataGridViewTextBoxColumn.Name = "AnredeDataGridViewTextBoxColumn";
            this.AnredeDataGridViewTextBoxColumn.Width = 60;
            // 
            // Belege
            // 
            this.Belege.AutoScroll = true;
            this.Belege.Controls.Add(this.BNAV_Belege);
            this.Belege.Controls.Add(this.BelegeDataGridView);
            this.Belege.Location = new System.Drawing.Point(4, 22);
            this.Belege.Name = "Belege";
            this.Belege.Padding = new System.Windows.Forms.Padding(3);
            this.Belege.Size = new System.Drawing.Size(1171, 374);
            this.Belege.TabIndex = 5;
            this.Belege.Text = "Belege";
            this.Belege.UseVisualStyleBackColor = true;
            // 
            // BNAV_Belege
            // 
            this.BNAV_Belege.AddNewItem = this.ToolStripButton28;
            this.BNAV_Belege.BindingSource = this.BelegeBindingSource;
            this.BNAV_Belege.CountItem = this.ToolStripLabel5;
            this.BNAV_Belege.DeleteItem = this.ToolStripButton29;
            this.BNAV_Belege.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BNAV_Belege.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton30,
            this.ToolStripButton31,
            this.ToolStripSeparator13,
            this.ToolStripTextBox5,
            this.ToolStripLabel5,
            this.ToolStripSeparator14,
            this.ToolStripButton32,
            this.ToolStripButton33,
            this.ToolStripSeparator15,
            this.ToolStripButton28,
            this.ToolStripButton29,
            this._BNAV_BelegeSaveItem});
            this.BNAV_Belege.Location = new System.Drawing.Point(3, 346);
            this.BNAV_Belege.MoveFirstItem = this.ToolStripButton30;
            this.BNAV_Belege.MoveLastItem = this.ToolStripButton33;
            this.BNAV_Belege.MoveNextItem = this.ToolStripButton32;
            this.BNAV_Belege.MovePreviousItem = this.ToolStripButton31;
            this.BNAV_Belege.Name = "BNAV_Belege";
            this.BNAV_Belege.PositionItem = this.ToolStripTextBox5;
            this.BNAV_Belege.Size = new System.Drawing.Size(1165, 25);
            this.BNAV_Belege.TabIndex = 26;
            this.BNAV_Belege.Text = "BindingNavigator1";
            // 
            // ToolStripButton28
            // 
            this.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton28.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton28.Image")));
            this.ToolStripButton28.Name = "ToolStripButton28";
            this.ToolStripButton28.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton28.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton28.Text = "Neu hinzufügen";
            // 
            // BelegeBindingSource
            // 
            this.BelegeBindingSource.DataMember = "Belege";
            this.BelegeBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // ToolStripLabel5
            // 
            this.ToolStripLabel5.Name = "ToolStripLabel5";
            this.ToolStripLabel5.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel5.Text = "von {0}";
            this.ToolStripLabel5.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // ToolStripButton29
            // 
            this.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton29.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton29.Image")));
            this.ToolStripButton29.Name = "ToolStripButton29";
            this.ToolStripButton29.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton29.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton29.Text = "Löschen";
            // 
            // ToolStripButton30
            // 
            this.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton30.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton30.Image")));
            this.ToolStripButton30.Name = "ToolStripButton30";
            this.ToolStripButton30.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton30.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton30.Text = "Erste verschieben";
            // 
            // ToolStripButton31
            // 
            this.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton31.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton31.Image")));
            this.ToolStripButton31.Name = "ToolStripButton31";
            this.ToolStripButton31.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton31.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton31.Text = "Vorherige verschieben";
            // 
            // ToolStripSeparator13
            // 
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripTextBox5
            // 
            this.ToolStripTextBox5.AccessibleName = "Position";
            this.ToolStripTextBox5.AutoSize = false;
            this.ToolStripTextBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ToolStripTextBox5.Name = "ToolStripTextBox5";
            this.ToolStripTextBox5.Size = new System.Drawing.Size(50, 25);
            this.ToolStripTextBox5.Text = "0";
            this.ToolStripTextBox5.ToolTipText = "Aktuelle Position";
            // 
            // ToolStripSeparator14
            // 
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton32
            // 
            this.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton32.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton32.Image")));
            this.ToolStripButton32.Name = "ToolStripButton32";
            this.ToolStripButton32.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton32.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton32.Text = "Nächste verschieben";
            // 
            // ToolStripButton33
            // 
            this.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton33.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton33.Image")));
            this.ToolStripButton33.Name = "ToolStripButton33";
            this.ToolStripButton33.RightToLeftAutoMirrorImage = true;
            this.ToolStripButton33.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton33.Text = "Letzte verschieben";
            // 
            // ToolStripSeparator15
            // 
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // _BNAV_BelegeSaveItem
            // 
            this._BNAV_BelegeSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BNAV_BelegeSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("_BNAV_BelegeSaveItem.Image")));
            this._BNAV_BelegeSaveItem.Name = "_BNAV_BelegeSaveItem";
            this._BNAV_BelegeSaveItem.Size = new System.Drawing.Size(23, 22);
            this._BNAV_BelegeSaveItem.Text = "Daten speichern";
            this._BNAV_BelegeSaveItem.Click += new System.EventHandler(this.BNAV_BelegeSaveItem_Click);
            // 
            // BelegeDataGridView
            // 
            this.BelegeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BelegeDataGridView.AutoGenerateColumns = false;
            this.BelegeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BelegeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9,
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13,
            this.DataGridViewTextBoxColumn14,
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn17,
            this.DataGridViewTextBoxColumn18,
            this.DataGridViewTextBoxColumn19});
            this.BelegeDataGridView.DataSource = this.BelegeBindingSource;
            this.BelegeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.BelegeDataGridView.Name = "BelegeDataGridView";
            this.BelegeDataGridView.Size = new System.Drawing.Size(1168, 343);
            this.BelegeDataGridView.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "IDBeleg";
            this.DataGridViewTextBoxColumn6.HeaderText = "IDBeleg";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.DataPropertyName = "FirmenName";
            this.DataGridViewTextBoxColumn9.HeaderText = "FirmenName";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.DataPropertyName = "Datum";
            this.DataGridViewTextBoxColumn10.HeaderText = "Datum";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.DataPropertyName = "IDAdresse";
            this.DataGridViewTextBoxColumn11.HeaderText = "IDAdresse";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.DataPropertyName = "IDKonto";
            this.DataGridViewTextBoxColumn12.HeaderText = "IDKonto";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.DataPropertyName = "Kuerzel";
            this.DataGridViewTextBoxColumn13.HeaderText = "Kuerzel";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            // 
            // DataGridViewTextBoxColumn14
            // 
            this.DataGridViewTextBoxColumn14.DataPropertyName = "Kontakt";
            this.DataGridViewTextBoxColumn14.HeaderText = "Kontakt";
            this.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14";
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.DataPropertyName = "WeitereKontakte";
            this.DataGridViewTextBoxColumn15.HeaderText = "WeitereKontakte";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.DataPropertyName = "Thema";
            this.DataGridViewTextBoxColumn16.HeaderText = "Thema";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            // 
            // DataGridViewTextBoxColumn17
            // 
            this.DataGridViewTextBoxColumn17.DataPropertyName = "WeitereBesucher";
            this.DataGridViewTextBoxColumn17.HeaderText = "WeitereBesucher";
            this.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17";
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.DataPropertyName = "Login";
            this.DataGridViewTextBoxColumn18.HeaderText = "Login";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.DataPropertyName = "Belegname";
            this.DataGridViewTextBoxColumn19.HeaderText = "Belegname";
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            // 
            // FirmenNameTableAdapter
            // 
            this.FirmenNameTableAdapter.ClearBeforeFill = true;
            // 
            // KontoTableAdapter
            // 
            this.KontoTableAdapter.ClearBeforeFill = true;
            // 
            // AdressenTableAdapter
            // 
            this.AdressenTableAdapter.ClearBeforeFill = true;
            // 
            // KontakteTableAdapter
            // 
            this.KontakteTableAdapter.ClearBeforeFill = true;
            // 
            // BelegeTableAdapter
            // 
            this.BelegeTableAdapter.ClearBeforeFill = true;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.TC_Administration, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel3, 0, 2);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1185, 522);
            this.TableLayoutPanel1.TabIndex = 31;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn20.HeaderText = "ID";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "Bezeichner";
            this.dataGridViewTextBoxColumn21.HeaderText = "Bezeichner";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Wert";
            this.dataGridViewTextBoxColumn22.HeaderText = "Wert";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 300;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Beschreibung";
            this.dataGridViewTextBoxColumn23.HeaderText = "Beschreibung";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 523);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.TC_Administration.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).EndInit();
            this.BindingNavigator1.ResumeLayout(false);
            this.BindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameDataGridView)).EndInit();
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator2)).EndInit();
            this.BindingNavigator2.ResumeLayout(false);
            this.BindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator3)).EndInit();
            this.BindingNavigator3.ResumeLayout(false);
            this.BindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingNavigator)).EndInit();
            this.SachbearbeiterBindingNavigator.ResumeLayout(false);
            this.SachbearbeiterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.Belege.ResumeLayout(false);
            this.Belege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNAV_Belege)).EndInit();
            this.BNAV_Belege.ResumeLayout(false);
            this.BNAV_Belege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeDataGridView)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        internal Panel Panel2;
        internal Label Label1;
        internal BindingSource SachbearbeiterBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter SachbearbeiterTableAdapter;
        internal Label SachbearbeiterLabel1;
        internal CheckBox AdminCheckBox;

        

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
        internal TableLayoutPanel TableLayoutPanel1;
        private BindingSource propertiesBindingSource;
        private _WSL_AdressenDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        internal BindingNavigator bindingNavigator4;
        internal ToolStripButton toolStripButton13;
        internal ToolStripLabel toolStripLabel6;
        internal ToolStripButton toolStripButton20;
        internal ToolStripButton toolStripButton27;
        internal ToolStripButton toolStripButton34;
        internal ToolStripSeparator toolStripSeparator16;
        internal ToolStripTextBox toolStripTextBox6;
        internal ToolStripSeparator toolStripSeparator17;
        internal ToolStripButton toolStripButton35;
        internal ToolStripButton toolStripButton36;
        internal ToolStripSeparator toolStripSeparator18;
        private ToolStripButton _BNAV_PropertiesSave;
        private DataGridView propertiesDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
    }
}