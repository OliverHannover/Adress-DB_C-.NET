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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SachbearbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.SachbearbeiterLabel1 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._BTN_Alle = new System.Windows.Forms.Button();
            this._BTN_Aktuell = new System.Windows.Forms.Button();
            this.TC_Administration = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BNAV_PropertiesSave = new System.Windows.Forms.ToolStripButton();
            this.propertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.BindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.ToolStripButton21 = new System.Windows.Forms.ToolStripButton();
            this.FirmenNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripButton23 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton24 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripTextBox4 = new System.Windows.Forms.ToolStripTextBox();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton25 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton26 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this._BNAV_FirmenNameSave = new System.Windows.Forms.ToolStripButton();
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
            this.TabPage6 = new System.Windows.Forms.TabPage();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this._BTN_Schliessen = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.klassenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton38 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton39 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton40 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox7 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton41 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton42 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNAV_SaveKlassen = new System.Windows.Forms.ToolStripButton();
            this.klassenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.SachbearbeiterTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            this.FirmenNameTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            this.KontoTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            this.AdressenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.AdressenTableAdapter();
            this.KontakteTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteTableAdapter();
            this.BelegeTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeTableAdapter();
            this.propertiesTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter();
            this.klassenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KlassenTableAdapter();
            SachbearbeiterLabel = new System.Windows.Forms.Label();
            AdminLabel = new System.Windows.Forms.Label();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            this.TC_Administration.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).BeginInit();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).BeginInit();
            this.BindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).BeginInit();
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
            this.TabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNAV_Belege)).BeginInit();
            this.BNAV_Belege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klassenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassenDataGridView)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SachbearbeiterLabel.Location = new System.Drawing.Point(191, 6);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new System.Drawing.Size(82, 13);
            SachbearbeiterLabel.TabIndex = 25;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new System.Drawing.Point(191, 19);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new System.Drawing.Size(70, 13);
            AdminLabel.TabIndex = 27;
            AdminLabel.Text = "Administrator:";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this.AdminCheckBox);
            this.Panel2.Controls.Add(AdminLabel);
            this.Panel2.Controls.Add(this.SachbearbeiterLabel1);
            this.Panel2.Controls.Add(SachbearbeiterLabel);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(596, 48);
            this.Panel2.TabIndex = 25;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.SachbearbeiterBindingSource, "Admin", true));
            this.AdminCheckBox.Enabled = false;
            this.AdminCheckBox.Location = new System.Drawing.Point(267, 13);
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
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SachbearbeiterLabel1
            // 
            this.SachbearbeiterLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SachbearbeiterBindingSource, "Sachbearbeiter", true));
            this.SachbearbeiterLabel1.Location = new System.Drawing.Point(279, 5);
            this.SachbearbeiterLabel1.Name = "SachbearbeiterLabel1";
            this.SachbearbeiterLabel1.Size = new System.Drawing.Size(139, 14);
            this.SachbearbeiterLabel1.TabIndex = 26;
            this.SachbearbeiterLabel1.Text = "Vorname Name";
            this.SachbearbeiterLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(105, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Einstellungen";
            // 
            // _BTN_Alle
            // 
            this._BTN_Alle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Alle.Enabled = false;
            this._BTN_Alle.Location = new System.Drawing.Point(345, 6);
            this._BTN_Alle.Name = "_BTN_Alle";
            this._BTN_Alle.Size = new System.Drawing.Size(75, 23);
            this._BTN_Alle.TabIndex = 2;
            this._BTN_Alle.Text = "alle";
            this._BTN_Alle.UseVisualStyleBackColor = true;
            this._BTN_Alle.Click += new System.EventHandler(this.BTN_Alle_Click);
            // 
            // _BTN_Aktuell
            // 
            this._BTN_Aktuell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Aktuell.Enabled = false;
            this._BTN_Aktuell.Location = new System.Drawing.Point(426, 6);
            this._BTN_Aktuell.Name = "_BTN_Aktuell";
            this._BTN_Aktuell.Size = new System.Drawing.Size(156, 23);
            this._BTN_Aktuell.TabIndex = 1;
            this._BTN_Aktuell.Text = "Aktuellen Geschäftspartner";
            this._BTN_Aktuell.UseVisualStyleBackColor = true;
            this._BTN_Aktuell.Click += new System.EventHandler(this.BTN_Aktuell_Click);
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
            this.TC_Administration.Controls.Add(this.TabPage6);
            this.TC_Administration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_Administration.Location = new System.Drawing.Point(3, 35);
            this.TC_Administration.Multiline = true;
            this.TC_Administration.Name = "TC_Administration";
            this.TC_Administration.SelectedIndex = 0;
            this.TC_Administration.Size = new System.Drawing.Size(585, 340);
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
            this.TabPage1.Size = new System.Drawing.Size(577, 314);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Konfiguration";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = null;
            this.bindingNavigator4.BindingSource = this.propertiesBindingSource;
            this.bindingNavigator4.CountItem = null;
            this.bindingNavigator4.DeleteItem = null;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._BNAV_PropertiesSave});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 286);
            this.bindingNavigator4.MoveFirstItem = null;
            this.bindingNavigator4.MoveLastItem = null;
            this.bindingNavigator4.MoveNextItem = null;
            this.bindingNavigator4.MovePreviousItem = null;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = null;
            this.bindingNavigator4.Size = new System.Drawing.Size(571, 25);
            this.bindingNavigator4.TabIndex = 11;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "properties";
            this.propertiesBindingSource.DataSource = this._WSL_AdressenDataSet;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.propertiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.propertiesDataGridView.DataSource = this.propertiesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.propertiesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.propertiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.propertiesDataGridView.Name = "propertiesDataGridView";
            this.propertiesDataGridView.Size = new System.Drawing.Size(571, 308);
            this.propertiesDataGridView.TabIndex = 0;
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
            // TabPage2
            // 
            this.TabPage2.AutoScroll = true;
            this.TabPage2.Controls.Add(this.BindingNavigator1);
            this.TabPage2.Controls.Add(this.FirmenNameDataGridView);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(577, 314);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "FirmenName";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // BindingNavigator1
            // 
            this.BindingNavigator1.AddNewItem = this.ToolStripButton21;
            this.BindingNavigator1.BindingSource = this.FirmenNameBindingSource;
            this.BindingNavigator1.CountItem = this.ToolStripLabel4;
            this.BindingNavigator1.DeleteItem = null;
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
            this._BNAV_FirmenNameSave});
            this.BindingNavigator1.Location = new System.Drawing.Point(3, 286);
            this.BindingNavigator1.MoveFirstItem = this.ToolStripButton23;
            this.BindingNavigator1.MoveLastItem = this.ToolStripButton26;
            this.BindingNavigator1.MoveNextItem = this.ToolStripButton25;
            this.BindingNavigator1.MovePreviousItem = this.ToolStripButton24;
            this.BindingNavigator1.Name = "BindingNavigator1";
            this.BindingNavigator1.PositionItem = this.ToolStripTextBox4;
            this.BindingNavigator1.Size = new System.Drawing.Size(571, 25);
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
            // FirmenNameBindingSource
            // 
            this.FirmenNameBindingSource.DataMember = "FirmenName";
            this.FirmenNameBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // ToolStripLabel4
            // 
            this.ToolStripLabel4.Name = "ToolStripLabel4";
            this.ToolStripLabel4.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel4.Text = "von {0}";
            this.ToolStripLabel4.ToolTipText = "Die Gesamtanzahl der Elemente.";
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
            // FirmenNameDataGridView
            // 
            this.FirmenNameDataGridView.AutoGenerateColumns = false;
            this.FirmenNameDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FirmenNameDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FirmenNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FirmenNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.Login,
            this.changed,
            this.inaktiv});
            this.FirmenNameDataGridView.DataSource = this.FirmenNameBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FirmenNameDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.FirmenNameDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirmenNameDataGridView.Location = new System.Drawing.Point(3, 3);
            this.FirmenNameDataGridView.Name = "FirmenNameDataGridView";
            this.FirmenNameDataGridView.RowHeadersVisible = false;
            this.FirmenNameDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FirmenNameDataGridView.Size = new System.Drawing.Size(571, 308);
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
            this.TabPage3.Controls.Add(this.KontoDataGridView);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(577, 314);
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
            this.BindingNavigator2.Location = new System.Drawing.Point(3, 286);
            this.BindingNavigator2.MoveFirstItem = this.ToolStripButton16;
            this.BindingNavigator2.MoveLastItem = this.ToolStripButton19;
            this.BindingNavigator2.MoveNextItem = this.ToolStripButton18;
            this.BindingNavigator2.MovePreviousItem = this.ToolStripButton17;
            this.BindingNavigator2.Name = "BindingNavigator2";
            this.BindingNavigator2.PositionItem = this.ToolStripTextBox3;
            this.BindingNavigator2.Size = new System.Drawing.Size(571, 25);
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
            // KontoDataGridView
            // 
            this.KontoDataGridView.AutoGenerateColumns = false;
            this.KontoDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.KontoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.KontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.Datum});
            this.KontoDataGridView.DataSource = this.KontoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.KontoDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.KontoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KontoDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.KontoDataGridView.Location = new System.Drawing.Point(3, 3);
            this.KontoDataGridView.Name = "KontoDataGridView";
            this.KontoDataGridView.RowHeadersVisible = false;
            this.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KontoDataGridView.Size = new System.Drawing.Size(571, 308);
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
            this.TabPage4.Controls.Add(this.DataGridView1);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage4.Size = new System.Drawing.Size(577, 314);
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
            this.BindingNavigator3.Location = new System.Drawing.Point(3, 286);
            this.BindingNavigator3.MoveFirstItem = this.ToolStripButton9;
            this.BindingNavigator3.MoveLastItem = this.ToolStripButton12;
            this.BindingNavigator3.MoveNextItem = this.ToolStripButton11;
            this.BindingNavigator3.MovePreviousItem = this.ToolStripButton10;
            this.BindingNavigator3.Name = "BindingNavigator3";
            this.BindingNavigator3.PositionItem = this.ToolStripTextBox2;
            this.BindingNavigator3.Size = new System.Drawing.Size(571, 25);
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
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView1.Size = new System.Drawing.Size(571, 308);
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
            this.TabPage5.Controls.Add(this.DataGridView2);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(577, 314);
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
            this.SachbearbeiterBindingNavigator.Location = new System.Drawing.Point(3, 286);
            this.SachbearbeiterBindingNavigator.MoveFirstItem = this.ToolStripButton3;
            this.SachbearbeiterBindingNavigator.MoveLastItem = this.ToolStripButton6;
            this.SachbearbeiterBindingNavigator.MoveNextItem = this.ToolStripButton5;
            this.SachbearbeiterBindingNavigator.MovePreviousItem = this.ToolStripButton4;
            this.SachbearbeiterBindingNavigator.Name = "SachbearbeiterBindingNavigator";
            this.SachbearbeiterBindingNavigator.PositionItem = this.ToolStripTextBox1;
            this.SachbearbeiterBindingNavigator.Size = new System.Drawing.Size(571, 25);
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
            // DataGridView2
            // 
            this.DataGridView2.AutoGenerateColumns = false;
            this.DataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DataGridView2.Location = new System.Drawing.Point(3, 3);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridView2.Size = new System.Drawing.Size(571, 308);
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
            // TabPage6
            // 
            this.TabPage6.AutoScroll = true;
            this.TabPage6.Controls.Add(this.BNAV_Belege);
            this.TabPage6.Controls.Add(this.BelegeDataGridView);
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(577, 314);
            this.TabPage6.TabIndex = 5;
            this.TabPage6.Text = "Belege";
            this.TabPage6.UseVisualStyleBackColor = true;
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
            this.BNAV_Belege.Location = new System.Drawing.Point(3, 286);
            this.BNAV_Belege.MoveFirstItem = this.ToolStripButton30;
            this.BNAV_Belege.MoveLastItem = this.ToolStripButton33;
            this.BNAV_Belege.MoveNextItem = this.ToolStripButton32;
            this.BNAV_Belege.MovePreviousItem = this.ToolStripButton31;
            this.BNAV_Belege.Name = "BNAV_Belege";
            this.BNAV_Belege.PositionItem = this.ToolStripTextBox5;
            this.BNAV_Belege.Size = new System.Drawing.Size(571, 25);
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BelegeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BelegeDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.BelegeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.BelegeDataGridView.Name = "BelegeDataGridView";
            this.BelegeDataGridView.Size = new System.Drawing.Size(574, 283);
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Panel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(602, 510);
            this.tableLayoutPanel2.TabIndex = 32;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gray;
            this.Panel3.Controls.Add(this._BTN_Schliessen);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 464);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(596, 43);
            this.Panel3.TabIndex = 27;
            // 
            // _BTN_Schliessen
            // 
            this._BTN_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Schliessen.Image = ((System.Drawing.Image)(resources.GetObject("_BTN_Schliessen.Image")));
            this._BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Schliessen.Location = new System.Drawing.Point(512, 10);
            this._BTN_Schliessen.Name = "_BTN_Schliessen";
            this._BTN_Schliessen.Size = new System.Drawing.Size(80, 23);
            this._BTN_Schliessen.TabIndex = 16;
            this._BTN_Schliessen.Text = "Schließen";
            this._BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Schliessen.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(3, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 401);
            this.tabControl1.TabIndex = 28;
            // 
            // tabPage7
            // 
            this.tabPage7.AutoScroll = true;
            this.tabPage7.Controls.Add(this.bindingNavigator5);
            this.tabPage7.Controls.Add(this.klassenDataGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(588, 375);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "Einstellungen";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = null;
            this.bindingNavigator5.BindingSource = this.klassenBindingSource;
            this.bindingNavigator5.CountItem = this.toolStripLabel7;
            this.bindingNavigator5.DeleteItem = this.toolStripButton38;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton39,
            this.toolStripButton40,
            this.toolStripSeparator19,
            this.toolStripTextBox7,
            this.toolStripLabel7,
            this.toolStripSeparator20,
            this.toolStripButton41,
            this.toolStripButton42,
            this.toolStripSeparator21,
            this.toolStripButton38,
            this.BTNAV_SaveKlassen});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 347);
            this.bindingNavigator5.MoveFirstItem = this.toolStripButton39;
            this.bindingNavigator5.MoveLastItem = this.toolStripButton42;
            this.bindingNavigator5.MoveNextItem = this.toolStripButton41;
            this.bindingNavigator5.MovePreviousItem = this.toolStripButton40;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.toolStripTextBox7;
            this.bindingNavigator5.Size = new System.Drawing.Size(582, 25);
            this.bindingNavigator5.TabIndex = 12;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // klassenBindingSource
            // 
            this.klassenBindingSource.DataMember = "Klassen";
            this.klassenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel7.Text = "von {0}";
            this.toolStripLabel7.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // toolStripButton38
            // 
            this.toolStripButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton38.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton38.Image")));
            this.toolStripButton38.Name = "toolStripButton38";
            this.toolStripButton38.RightToLeftAutoMirrorImage = true;
            this.toolStripButton38.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton38.Text = "Löschen";
            // 
            // toolStripButton39
            // 
            this.toolStripButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton39.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton39.Image")));
            this.toolStripButton39.Name = "toolStripButton39";
            this.toolStripButton39.RightToLeftAutoMirrorImage = true;
            this.toolStripButton39.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton39.Text = "Erste verschieben";
            // 
            // toolStripButton40
            // 
            this.toolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton40.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton40.Image")));
            this.toolStripButton40.Name = "toolStripButton40";
            this.toolStripButton40.RightToLeftAutoMirrorImage = true;
            this.toolStripButton40.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton40.Text = "Vorherige verschieben";
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox7
            // 
            this.toolStripTextBox7.AccessibleName = "Position";
            this.toolStripTextBox7.AutoSize = false;
            this.toolStripTextBox7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.toolStripTextBox7.Name = "toolStripTextBox7";
            this.toolStripTextBox7.Size = new System.Drawing.Size(50, 25);
            this.toolStripTextBox7.Text = "0";
            this.toolStripTextBox7.ToolTipText = "Aktuelle Position";
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton41
            // 
            this.toolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton41.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton41.Image")));
            this.toolStripButton41.Name = "toolStripButton41";
            this.toolStripButton41.RightToLeftAutoMirrorImage = true;
            this.toolStripButton41.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton41.Text = "Nächste verschieben";
            // 
            // toolStripButton42
            // 
            this.toolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton42.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton42.Image")));
            this.toolStripButton42.Name = "toolStripButton42";
            this.toolStripButton42.RightToLeftAutoMirrorImage = true;
            this.toolStripButton42.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton42.Text = "Letzte verschieben";
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNAV_SaveKlassen
            // 
            this.BTNAV_SaveKlassen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BTNAV_SaveKlassen.Image = ((System.Drawing.Image)(resources.GetObject("BTNAV_SaveKlassen.Image")));
            this.BTNAV_SaveKlassen.Name = "BTNAV_SaveKlassen";
            this.BTNAV_SaveKlassen.Size = new System.Drawing.Size(23, 22);
            this.BTNAV_SaveKlassen.Text = "Daten speichern";
            this.BTNAV_SaveKlassen.Click += new System.EventHandler(this.BTNAV_SaveKlassen_Click);
            // 
            // klassenDataGridView
            // 
            this.klassenDataGridView.AutoGenerateColumns = false;
            this.klassenDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.klassenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.klassenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.klassenDataGridView.DataSource = this.klassenBindingSource;
            this.klassenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klassenDataGridView.Location = new System.Drawing.Point(3, 3);
            this.klassenDataGridView.Name = "klassenDataGridView";
            this.klassenDataGridView.RowHeadersVisible = false;
            this.klassenDataGridView.Size = new System.Drawing.Size(582, 369);
            this.klassenDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn24.HeaderText = "ID";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 50;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "KlassenName";
            this.dataGridViewTextBoxColumn25.HeaderText = "KlassenName";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 200;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.TC_Administration);
            this.tabPage8.Controls.Add(this._BTN_Alle);
            this.tabPage8.Controls.Add(this._BTN_Aktuell);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(588, 375);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "Administration";
            this.tabPage8.UseVisualStyleBackColor = true;
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
            this.TableAdapterManager.KlassenTableAdapter = null;
            this.TableAdapterManager.KlassifizierungTableAdapter = null;
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
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // klassenTableAdapter
            // 
            this.klassenTableAdapter.ClearBeforeFill = true;
            // 
            // Administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 514);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Administration";
            this.Text = "Administration";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            this.TC_Administration.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).EndInit();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigator1)).EndInit();
            this.BindingNavigator1.ResumeLayout(false);
            this.BindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).EndInit();
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
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BNAV_Belege)).EndInit();
            this.BNAV_Belege.ResumeLayout(false);
            this.BNAV_Belege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klassenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klassenDataGridView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }


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

        
        internal TabControl TC_Administration;
        internal TabPage TabPage1;
        internal TabPage TabPage2;
        internal TabPage TabPage3;
        internal TabPage TabPage4;
        internal TabPage TabPage5;
        internal BindingSource FirmenNameBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter FirmenNameTableAdapter;
        internal DataGridView FirmenNameDataGridView;
        internal BindingSource KontoBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontoTableAdapter KontoTableAdapter;
        internal DataGridView KontoDataGridView;
        internal BindingSource AdressenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter AdressenTableAdapter;
        internal DataGridView DataGridView1;
        internal DataGridView DataGridView2;
        internal BindingSource KontakteBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter KontakteTableAdapter;
        internal BindingNavigator BindingNavigator1;
        internal ToolStripButton ToolStripButton21;
        internal ToolStripLabel ToolStripLabel4;
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
        internal TabPage TabPage6;
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
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn Login;
        internal DataGridViewTextBoxColumn changed;
        internal DataGridViewCheckBoxColumn inaktiv;
        private BindingSource propertiesBindingSource;
        private _WSL_AdressenDataSetTableAdapters.propertiesTableAdapter propertiesTableAdapter;
        private DataGridView propertiesDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private TableLayoutPanel tableLayoutPanel2;
        internal Panel Panel3;
        private Button _BTN_Schliessen;
        private TabControl tabControl1;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private BindingSource klassenBindingSource;
        private _WSL_AdressenDataSetTableAdapters.KlassenTableAdapter klassenTableAdapter;
        internal BindingNavigator bindingNavigator5;
        internal ToolStripLabel toolStripLabel7;
        internal ToolStripButton toolStripButton38;
        internal ToolStripButton toolStripButton39;
        internal ToolStripButton toolStripButton40;
        internal ToolStripSeparator toolStripSeparator19;
        internal ToolStripTextBox toolStripTextBox7;
        internal ToolStripSeparator toolStripSeparator20;
        internal ToolStripButton toolStripButton41;
        internal ToolStripButton toolStripButton42;
        internal ToolStripSeparator toolStripSeparator21;
        private ToolStripButton BTNAV_SaveKlassen;
        private DataGridView klassenDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        internal BindingNavigator bindingNavigator4;
        private ToolStripButton _BNAV_PropertiesSave;
    }
}