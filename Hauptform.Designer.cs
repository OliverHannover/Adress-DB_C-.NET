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
    public partial class Hauptform : Form
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
            System.Windows.Forms.Label AdresstypLabel;
            System.Windows.Forms.Label StraßeLabel;
            System.Windows.Forms.Label PLZLabel;
            System.Windows.Forms.Label PostfachLabel;
            System.Windows.Forms.Label OrtLabel;
            System.Windows.Forms.Label BundeslandLabel;
            System.Windows.Forms.Label LandLabel;
            System.Windows.Forms.Label UStIdNrLabel;
            System.Windows.Forms.Label WebseiteLabel;
            System.Windows.Forms.Label AnredeLabel;
            System.Windows.Forms.Label NachnameLabel;
            System.Windows.Forms.Label VornameLabel;
            System.Windows.Forms.Label EmailAddresseLabel;
            System.Windows.Forms.Label PositionLabel;
            System.Windows.Forms.Label TelefonGeschaeftlichLabel;
            System.Windows.Forms.Label TelefonPrivatLabel;
            System.Windows.Forms.Label MobiltelefonLabel;
            System.Windows.Forms.Label FaxnummerLabel;
            System.Windows.Forms.Label AdresstypLabel1;
            System.Windows.Forms.Label StraßeLabel1;
            System.Windows.Forms.Label PostfachLabel1;
            System.Windows.Forms.Label PLZLabel1;
            System.Windows.Forms.Label OrtLabel1;
            System.Windows.Forms.Label BundeslandLabel1;
            System.Windows.Forms.Label UStIdNrLabel1;
            System.Windows.Forms.Label WebseiteLabel1;
            System.Windows.Forms.Label AnredeLabel1;
            System.Windows.Forms.Label VornameLabel1;
            System.Windows.Forms.Label NachnameLabel1;
            System.Windows.Forms.Label EmailAddresseLabel1;
            System.Windows.Forms.Label PositionLabel1;
            System.Windows.Forms.Label TelefonGeschaeftlichLabel1;
            System.Windows.Forms.Label TelefonPrivatLabel1;
            System.Windows.Forms.Label MobiltelefonLabel1;
            System.Windows.Forms.Label FaxnummerLabel1;
            System.Windows.Forms.Label IDAdresseLabel;
            System.Windows.Forms.Label IDKontoLabel;
            System.Windows.Forms.Label IDLKontoLabel2;
            System.Windows.Forms.Label DirekterKontaktLabel;
            System.Windows.Forms.Label WeitereKontakteLabel;
            System.Windows.Forms.Label DatumLabel;
            System.Windows.Forms.Label VonWemBesuchtLabel;
            System.Windows.Forms.Label WeitereBesucherLabel;
            System.Windows.Forms.Label ThemaLabel;
            System.Windows.Forms.Label PLZLabel2;
            System.Windows.Forms.Label FaxnummerLabel3;
            System.Windows.Forms.Label SachbearbeiterLabel;
            System.Windows.Forms.Label JobtitleLabel;
            System.Windows.Forms.Label DurchwahlLabel;
            System.Windows.Forms.Label EmailLabel;
            System.Windows.Forms.Label IDKontoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptform));
            this.StraßeLabel2 = new System.Windows.Forms.Label();
            this.OrtLabel2 = new System.Windows.Forms.Label();
            this.TB_FirmenName = new System.Windows.Forms.TextBox();
            this._BTN_Suche = new System.Windows.Forms.Button();
            this._LBL_IDFirmenName = new System.Windows.Forms.Label();
            this.FirmenNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.lblIDKonto = new System.Windows.Forms.Label();
            this.KontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CB_FirmenName = new System.Windows.Forms.ComboBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this._BTN_NachnameSuche = new System.Windows.Forms.Button();
            this.lblTrefferAnzahl = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this._Button1 = new System.Windows.Forms.Button();
            this.lblHinweisKeinTreffer = new System.Windows.Forms.Label();
            this.DocuwareCSVDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocuwareCSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._LBL_IDAdresse = new System.Windows.Forms.Label();
            this.AdressenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._btnNeueAdresse = new System.Windows.Forms.Button();
            this._btnNeuerKontakt = new System.Windows.Forms.Button();
            this._BTN_ZuOutlook = new System.Windows.Forms.Button();
            this._BTN_MapsSuche = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this._btnNeuesKonto = new System.Windows.Forms.Button();
            this.KontoDataGridView = new System.Windows.Forms.DataGridView();
            this.Label3 = new System.Windows.Forms.Label();
            this.BTN_Speichern = new System.Windows.Forms.Button();
            this._btnKontoZuAdresse = new System.Windows.Forms.Button();
            this.IDKontoTextBox = new System.Windows.Forms.TextBox();
            this.WebseiteTextBox = new System.Windows.Forms.TextBox();
            this.UStIdNrTextBox = new System.Windows.Forms.TextBox();
            this.TB_Bundesland = new System.Windows.Forms.TextBox();
            this.PostfachTextBox = new System.Windows.Forms.TextBox();
            this._TB_PLZ = new System.Windows.Forms.TextBox();
            this.StraßeTextBox = new System.Windows.Forms.TextBox();
            this.AdresstypTextBox = new System.Windows.Forms.TextBox();
            this.AdressenDataGridView = new System.Windows.Forms.DataGridView();
            this._EmailAddresseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.KontakteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._btnAdresseZuKontakt = new System.Windows.Forms.Button();
            this.IDAdresseTextBox = new System.Windows.Forms.TextBox();
            this.FaxnummerTextBox = new System.Windows.Forms.TextBox();
            this.MobiltelefonTextBox = new System.Windows.Forms.TextBox();
            this.TelefonPrivatTextBox = new System.Windows.Forms.TextBox();
            this.TelefonGeschaeftlichTextBox = new System.Windows.Forms.TextBox();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddresseTextBox = new System.Windows.Forms.TextBox();
            this.VornameTextBox = new System.Windows.Forms.TextBox();
            this.NachnameTextBox = new System.Windows.Forms.TextBox();
            this.AnredeComboBox = new System.Windows.Forms.ComboBox();
            this._LBL_IDKontakt = new System.Windows.Forms.Label();
            this.KontakteDataGridView = new System.Windows.Forms.DataGridView();
            this.IDKontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.lblKontaktHeader = new System.Windows.Forms.Label();
            this.TC_Beleg = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.CB_BBKuerzel = new System.Windows.Forms.ComboBox();
            this.SachbearbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TB_BBWeitereBesucher = new System.Windows.Forms.TextBox();
            this.TB_BBWeitereKontakte = new System.Windows.Forms.TextBox();
            this.LBL_BBRegion = new System.Windows.Forms.Label();
            this.LBL_BBIDKonto = new System.Windows.Forms.Label();
            this.LBL_BBBesuchterKontakt = new System.Windows.Forms.Label();
            this.LBL_BBLand = new System.Windows.Forms.Label();
            this.LBL_BBOrt = new System.Windows.Forms.Label();
            this.LBL_BBPLZ = new System.Windows.Forms.Label();
            this.LBL_BBStrasse = new System.Windows.Forms.Label();
            this.TB_BBThema = new System.Windows.Forms.TextBox();
            this.DTP_BBDatum = new System.Windows.Forms.DateTimePicker();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.LBL_DIVIDKonto = new System.Windows.Forms.Label();
            this.LBL_DIVEmail = new System.Windows.Forms.Label();
            this.LBL_DIVDurchwahl = new System.Windows.Forms.Label();
            this.LBL_DIVJobtitle = new System.Windows.Forms.Label();
            this.CB_DIVSachbearbeiter = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TB_DIVThema = new System.Windows.Forms.TextBox();
            this.DTP_Diverse = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_DIVAdresse = new System.Windows.Forms.Label();
            this.GB_Anrede = new System.Windows.Forms.GroupBox();
            this._RB_OhneAnrede = new System.Windows.Forms.RadioButton();
            this._RB_MitAnrede = new System.Windows.Forms.RadioButton();
            this.TB_DIVFaxnummer = new System.Windows.Forms.TextBox();
            this._LBL_Sprache = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._CB_Vorlagen = new System.Windows.Forms.ComboBox();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDBelegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KuerzelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelegnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BelegeMitAdresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Panel6 = new System.Windows.Forms.Panel();
            this._LBL_FirmenName = new System.Windows.Forms.Label();
            this._btnAbbrechen = new System.Windows.Forms.Button();
            this.TC_Adresse = new System.Windows.Forms.TabControl();
            this.TabAdresseInfo = new System.Windows.Forms.TabPage();
            this.LBL_CC = new System.Windows.Forms.Label();
            this.StaatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelLandAdressen = new System.Windows.Forms.Label();
            this.PNL_Geodaten = new System.Windows.Forms.Panel();
            this.LBL_Lat = new System.Windows.Forms.Label();
            this.LBL_Long = new System.Windows.Forms.Label();
            this.LBLLat = new System.Windows.Forms.Label();
            this.LBLLong = new System.Windows.Forms.Label();
            this.LBL_AdressHinweis = new System.Windows.Forms.Label();
            this._LBL_IDKontoZuAdresse = new System.Windows.Forms.Label();
            this._WebseiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.UStIdNrLabel2 = new System.Windows.Forms.Label();
            this.LBL_Land = new System.Windows.Forms.Label();
            this.BundeslandLabel2 = new System.Windows.Forms.Label();
            this.LBL_Ort = new System.Windows.Forms.Label();
            this.LBL_PLZ = new System.Windows.Forms.Label();
            this.PostfachLabel2 = new System.Windows.Forms.Label();
            this.LBL_Strasse = new System.Windows.Forms.Label();
            this.AdresstypLabel2 = new System.Windows.Forms.Label();
            this.Panel7 = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.TabAdresseBearbeiten = new System.Windows.Forms.TabPage();
            this.LBL_PLZungueltig = new System.Windows.Forms.Label();
            this.CB_Ort = new System.Windows.Forms.ComboBox();
            this.LBL_Countrycode = new System.Windows.Forms.Label();
            this.CB_Staat = new System.Windows.Forms.ComboBox();
            this.lblAdresseNeu = new System.Windows.Forms.Label();
            this.TC_Kontakt = new System.Windows.Forms.TabControl();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.OrtLabel3 = new System.Windows.Forms.Label();
            this.StraßeLabel3 = new System.Windows.Forms.Label();
            this._LBL_IDAdresseZuKontakt = new System.Windows.Forms.Label();
            this.FaxnummerLabel2 = new System.Windows.Forms.Label();
            this._MobiltelefonLinkLabel = new System.Windows.Forms.LinkLabel();
            this._TelefonPrivatLinkLabel = new System.Windows.Forms.LinkLabel();
            this._TelefonGeschaeftlichLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PositionLabel2 = new System.Windows.Forms.Label();
            this.LBL_Nachname = new System.Windows.Forms.Label();
            this.LBL_Vorname = new System.Windows.Forms.Label();
            this._LBL_Anrede = new System.Windows.Forms.Label();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this._BTN_DeleteUser = new System.Windows.Forms.Button();
            this.lblKontaktNeu = new System.Windows.Forms.Label();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DocuWareDateiManuellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SchließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._BenutzerlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Administration = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AktivitätslogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._InfoÜberAdressenDBToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._HilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.BTN_DocErzeugen = new System.Windows.Forms.Button();
            this.KontakteMitAdresseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirmenNameTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            this.KontoTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            this.AdressenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.AdressenTableAdapter();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.KontakteTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteTableAdapter();
            this.SachbearbeiterTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            this.KontakteMitAdresseTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter();
            this.DocuwareCSVTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.DocuwareCSVTableAdapter();
            this.BelegeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BelegeTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeTableAdapter();
            this.BelegeMitAdresseTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.BelegeMitAdresseTableAdapter();
            this.LogTabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogTabelleTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter();
            this.StaatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.StaatenTableAdapter();
            this.AT_PLZ_GeodatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AT_PLZ_GeodatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.AT_PLZ_GeodatenTableAdapter();
            this.CH_PLZ_GeodatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CH_PLZ_GeodatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.CH_PLZ_GeodatenTableAdapter();
            this.DE_PLZ_GeodatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DE_PLZ_GeodatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.DE_PLZ_GeodatenTableAdapter();
            this.PropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PropertiesTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter();
            this.Panel9 = new System.Windows.Forms.Panel();
            this.TLP_1 = new System.Windows.Forms.TableLayoutPanel();
            this.PNL_Klasse = new System.Windows.Forms.Panel();
            this.CB_Klassifizierung = new System.Windows.Forms.ComboBox();
            this.klassifizierungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.PNL_Konto = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.klassifizierungTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KlassifizierungTableAdapter();
            this.klassenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klassenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KlassenTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAdresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDKonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AdresstypLabel = new System.Windows.Forms.Label();
            StraßeLabel = new System.Windows.Forms.Label();
            PLZLabel = new System.Windows.Forms.Label();
            PostfachLabel = new System.Windows.Forms.Label();
            OrtLabel = new System.Windows.Forms.Label();
            BundeslandLabel = new System.Windows.Forms.Label();
            LandLabel = new System.Windows.Forms.Label();
            UStIdNrLabel = new System.Windows.Forms.Label();
            WebseiteLabel = new System.Windows.Forms.Label();
            AnredeLabel = new System.Windows.Forms.Label();
            NachnameLabel = new System.Windows.Forms.Label();
            VornameLabel = new System.Windows.Forms.Label();
            EmailAddresseLabel = new System.Windows.Forms.Label();
            PositionLabel = new System.Windows.Forms.Label();
            TelefonGeschaeftlichLabel = new System.Windows.Forms.Label();
            TelefonPrivatLabel = new System.Windows.Forms.Label();
            MobiltelefonLabel = new System.Windows.Forms.Label();
            FaxnummerLabel = new System.Windows.Forms.Label();
            AdresstypLabel1 = new System.Windows.Forms.Label();
            StraßeLabel1 = new System.Windows.Forms.Label();
            PostfachLabel1 = new System.Windows.Forms.Label();
            PLZLabel1 = new System.Windows.Forms.Label();
            OrtLabel1 = new System.Windows.Forms.Label();
            BundeslandLabel1 = new System.Windows.Forms.Label();
            UStIdNrLabel1 = new System.Windows.Forms.Label();
            WebseiteLabel1 = new System.Windows.Forms.Label();
            AnredeLabel1 = new System.Windows.Forms.Label();
            VornameLabel1 = new System.Windows.Forms.Label();
            NachnameLabel1 = new System.Windows.Forms.Label();
            EmailAddresseLabel1 = new System.Windows.Forms.Label();
            PositionLabel1 = new System.Windows.Forms.Label();
            TelefonGeschaeftlichLabel1 = new System.Windows.Forms.Label();
            TelefonPrivatLabel1 = new System.Windows.Forms.Label();
            MobiltelefonLabel1 = new System.Windows.Forms.Label();
            FaxnummerLabel1 = new System.Windows.Forms.Label();
            IDAdresseLabel = new System.Windows.Forms.Label();
            IDKontoLabel = new System.Windows.Forms.Label();
            IDLKontoLabel2 = new System.Windows.Forms.Label();
            DirekterKontaktLabel = new System.Windows.Forms.Label();
            WeitereKontakteLabel = new System.Windows.Forms.Label();
            DatumLabel = new System.Windows.Forms.Label();
            VonWemBesuchtLabel = new System.Windows.Forms.Label();
            WeitereBesucherLabel = new System.Windows.Forms.Label();
            ThemaLabel = new System.Windows.Forms.Label();
            PLZLabel2 = new System.Windows.Forms.Label();
            FaxnummerLabel3 = new System.Windows.Forms.Label();
            SachbearbeiterLabel = new System.Windows.Forms.Label();
            JobtitleLabel = new System.Windows.Forms.Label();
            DurchwahlLabel = new System.Windows.Forms.Label();
            EmailLabel = new System.Windows.Forms.Label();
            IDKontoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocuwareCSVDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocuwareCSVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenBindingSource)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteDataGridView)).BeginInit();
            this.Panel3.SuspendLayout();
            this.TC_Beleg.SuspendLayout();
            this.TabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).BeginInit();
            this.Panel5.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GB_Anrede.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeMitAdresseBindingSource)).BeginInit();
            this.Panel6.SuspendLayout();
            this.TC_Adresse.SuspendLayout();
            this.TabAdresseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaatenBindingSource)).BeginInit();
            this.PNL_Geodaten.SuspendLayout();
            this.Panel7.SuspendLayout();
            this.TabAdresseBearbeiten.SuspendLayout();
            this.TC_Kontakt.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteMitAdresseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_PLZ_GeodatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_PLZ_GeodatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_PLZ_GeodatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesBindingSource)).BeginInit();
            this.Panel9.SuspendLayout();
            this.TLP_1.SuspendLayout();
            this.PNL_Klasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klassifizierungBindingSource)).BeginInit();
            this.panel11.SuspendLayout();
            this.PNL_Konto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klassenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdresstypLabel
            // 
            AdresstypLabel.AutoSize = true;
            AdresstypLabel.Location = new System.Drawing.Point(13, 37);
            AdresstypLabel.Name = "AdresstypLabel";
            AdresstypLabel.Size = new System.Drawing.Size(56, 13);
            AdresstypLabel.TabIndex = 4;
            AdresstypLabel.Text = "Adresstyp:";
            // 
            // StraßeLabel
            // 
            StraßeLabel.AutoSize = true;
            StraßeLabel.Location = new System.Drawing.Point(25, 88);
            StraßeLabel.Name = "StraßeLabel";
            StraßeLabel.Size = new System.Drawing.Size(41, 13);
            StraßeLabel.TabIndex = 6;
            StraßeLabel.Text = "Straße:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new System.Drawing.Point(36, 140);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new System.Drawing.Size(30, 13);
            PLZLabel.TabIndex = 10;
            PLZLabel.Text = "PLZ:";
            // 
            // PostfachLabel
            // 
            PostfachLabel.AutoSize = true;
            PostfachLabel.Location = new System.Drawing.Point(14, 114);
            PostfachLabel.Name = "PostfachLabel";
            PostfachLabel.Size = new System.Drawing.Size(52, 13);
            PostfachLabel.TabIndex = 11;
            PostfachLabel.Text = "Postfach:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new System.Drawing.Point(42, 169);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new System.Drawing.Size(31, 13);
            OrtLabel.TabIndex = 12;
            OrtLabel.Text = "Ort: *";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new System.Drawing.Point(22, 196);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new System.Drawing.Size(44, 13);
            BundeslandLabel.TabIndex = 14;
            BundeslandLabel.Text = "Region:";
            // 
            // LandLabel
            // 
            LandLabel.AutoSize = true;
            LandLabel.Location = new System.Drawing.Point(32, 63);
            LandLabel.Name = "LandLabel";
            LandLabel.Size = new System.Drawing.Size(34, 13);
            LandLabel.TabIndex = 16;
            LandLabel.Text = "Land:";
            // 
            // UStIdNrLabel
            // 
            UStIdNrLabel.AutoSize = true;
            UStIdNrLabel.Location = new System.Drawing.Point(12, 218);
            UStIdNrLabel.Name = "UStIdNrLabel";
            UStIdNrLabel.Size = new System.Drawing.Size(54, 13);
            UStIdNrLabel.TabIndex = 18;
            UStIdNrLabel.Text = "USt Id Nr:";
            // 
            // WebseiteLabel
            // 
            WebseiteLabel.AutoSize = true;
            WebseiteLabel.Location = new System.Drawing.Point(14, 247);
            WebseiteLabel.Name = "WebseiteLabel";
            WebseiteLabel.Size = new System.Drawing.Size(55, 13);
            WebseiteLabel.TabIndex = 20;
            WebseiteLabel.Text = "Webseite:";
            // 
            // AnredeLabel
            // 
            AnredeLabel.AutoSize = true;
            AnredeLabel.Location = new System.Drawing.Point(49, 40);
            AnredeLabel.Name = "AnredeLabel";
            AnredeLabel.Size = new System.Drawing.Size(44, 13);
            AnredeLabel.TabIndex = 3;
            AnredeLabel.Text = "Anrede:";
            // 
            // NachnameLabel
            // 
            NachnameLabel.AutoSize = true;
            NachnameLabel.Location = new System.Drawing.Point(34, 63);
            NachnameLabel.Name = "NachnameLabel";
            NachnameLabel.Size = new System.Drawing.Size(69, 13);
            NachnameLabel.TabIndex = 5;
            NachnameLabel.Text = "Nachname: *";
            // 
            // VornameLabel
            // 
            VornameLabel.AutoSize = true;
            VornameLabel.Location = new System.Drawing.Point(46, 88);
            VornameLabel.Name = "VornameLabel";
            VornameLabel.Size = new System.Drawing.Size(52, 13);
            VornameLabel.TabIndex = 7;
            VornameLabel.Text = "Vorname:";
            // 
            // EmailAddresseLabel
            // 
            EmailAddresseLabel.AutoSize = true;
            EmailAddresseLabel.Location = new System.Drawing.Point(16, 114);
            EmailAddresseLabel.Name = "EmailAddresseLabel";
            EmailAddresseLabel.Size = new System.Drawing.Size(82, 13);
            EmailAddresseLabel.TabIndex = 9;
            EmailAddresseLabel.Text = "Email Addresse:";
            // 
            // PositionLabel
            // 
            PositionLabel.AutoSize = true;
            PositionLabel.Location = new System.Drawing.Point(51, 140);
            PositionLabel.Name = "PositionLabel";
            PositionLabel.Size = new System.Drawing.Size(47, 13);
            PositionLabel.TabIndex = 11;
            PositionLabel.Text = "Position:";
            // 
            // TelefonGeschaeftlichLabel
            // 
            TelefonGeschaeftlichLabel.AutoSize = true;
            TelefonGeschaeftlichLabel.Location = new System.Drawing.Point(11, 166);
            TelefonGeschaeftlichLabel.Name = "TelefonGeschaeftlichLabel";
            TelefonGeschaeftlichLabel.Size = new System.Drawing.Size(84, 13);
            TelefonGeschaeftlichLabel.TabIndex = 13;
            TelefonGeschaeftlichLabel.Text = "Telefon (gesch):";
            // 
            // TelefonPrivatLabel
            // 
            TelefonPrivatLabel.AutoSize = true;
            TelefonPrivatLabel.Location = new System.Drawing.Point(22, 192);
            TelefonPrivatLabel.Name = "TelefonPrivatLabel";
            TelefonPrivatLabel.Size = new System.Drawing.Size(81, 13);
            TelefonPrivatLabel.TabIndex = 15;
            TelefonPrivatLabel.Text = "Telefon (privat):";
            // 
            // MobiltelefonLabel
            // 
            MobiltelefonLabel.AutoSize = true;
            MobiltelefonLabel.Location = new System.Drawing.Point(31, 218);
            MobiltelefonLabel.Name = "MobiltelefonLabel";
            MobiltelefonLabel.Size = new System.Drawing.Size(67, 13);
            MobiltelefonLabel.TabIndex = 17;
            MobiltelefonLabel.Text = "Mobiltelefon:";
            // 
            // FaxnummerLabel
            // 
            FaxnummerLabel.AutoSize = true;
            FaxnummerLabel.Location = new System.Drawing.Point(34, 244);
            FaxnummerLabel.Name = "FaxnummerLabel";
            FaxnummerLabel.Size = new System.Drawing.Size(64, 13);
            FaxnummerLabel.TabIndex = 19;
            FaxnummerLabel.Text = "Faxnummer:";
            // 
            // AdresstypLabel1
            // 
            AdresstypLabel1.AutoSize = true;
            AdresstypLabel1.Location = new System.Drawing.Point(21, 40);
            AdresstypLabel1.Name = "AdresstypLabel1";
            AdresstypLabel1.Size = new System.Drawing.Size(56, 13);
            AdresstypLabel1.TabIndex = 1;
            AdresstypLabel1.Text = "Adresstyp:";
            // 
            // StraßeLabel1
            // 
            StraßeLabel1.AutoSize = true;
            StraßeLabel1.Location = new System.Drawing.Point(36, 76);
            StraßeLabel1.Name = "StraßeLabel1";
            StraßeLabel1.Size = new System.Drawing.Size(41, 13);
            StraßeLabel1.TabIndex = 3;
            StraßeLabel1.Text = "Straße:";
            // 
            // PostfachLabel1
            // 
            PostfachLabel1.AutoSize = true;
            PostfachLabel1.Location = new System.Drawing.Point(25, 91);
            PostfachLabel1.Name = "PostfachLabel1";
            PostfachLabel1.Size = new System.Drawing.Size(52, 13);
            PostfachLabel1.TabIndex = 5;
            PostfachLabel1.Text = "Postfach:";
            // 
            // PLZLabel1
            // 
            PLZLabel1.AutoSize = true;
            PLZLabel1.Location = new System.Drawing.Point(47, 106);
            PLZLabel1.Name = "PLZLabel1";
            PLZLabel1.Size = new System.Drawing.Size(30, 13);
            PLZLabel1.TabIndex = 7;
            PLZLabel1.Text = "PLZ:";
            // 
            // OrtLabel1
            // 
            OrtLabel1.AutoSize = true;
            OrtLabel1.Location = new System.Drawing.Point(53, 121);
            OrtLabel1.Name = "OrtLabel1";
            OrtLabel1.Size = new System.Drawing.Size(24, 13);
            OrtLabel1.TabIndex = 9;
            OrtLabel1.Text = "Ort:";
            // 
            // BundeslandLabel1
            // 
            BundeslandLabel1.AutoSize = true;
            BundeslandLabel1.Location = new System.Drawing.Point(33, 136);
            BundeslandLabel1.Name = "BundeslandLabel1";
            BundeslandLabel1.Size = new System.Drawing.Size(44, 13);
            BundeslandLabel1.TabIndex = 11;
            BundeslandLabel1.Text = "Region:";
            // 
            // UStIdNrLabel1
            // 
            UStIdNrLabel1.AutoSize = true;
            UStIdNrLabel1.Location = new System.Drawing.Point(23, 171);
            UStIdNrLabel1.Name = "UStIdNrLabel1";
            UStIdNrLabel1.Size = new System.Drawing.Size(54, 13);
            UStIdNrLabel1.TabIndex = 15;
            UStIdNrLabel1.Text = "USt Id Nr:";
            // 
            // WebseiteLabel1
            // 
            WebseiteLabel1.AutoSize = true;
            WebseiteLabel1.Location = new System.Drawing.Point(22, 191);
            WebseiteLabel1.Name = "WebseiteLabel1";
            WebseiteLabel1.Size = new System.Drawing.Size(55, 13);
            WebseiteLabel1.TabIndex = 17;
            WebseiteLabel1.Text = "Webseite:";
            // 
            // AnredeLabel1
            // 
            AnredeLabel1.AutoSize = true;
            AnredeLabel1.Location = new System.Drawing.Point(50, 40);
            AnredeLabel1.Name = "AnredeLabel1";
            AnredeLabel1.Size = new System.Drawing.Size(44, 13);
            AnredeLabel1.TabIndex = 26;
            AnredeLabel1.Text = "Anrede:";
            // 
            // VornameLabel1
            // 
            VornameLabel1.AutoSize = true;
            VornameLabel1.Location = new System.Drawing.Point(42, 70);
            VornameLabel1.Name = "VornameLabel1";
            VornameLabel1.Size = new System.Drawing.Size(52, 13);
            VornameLabel1.TabIndex = 27;
            VornameLabel1.Text = "Vorname:";
            // 
            // NachnameLabel1
            // 
            NachnameLabel1.AutoSize = true;
            NachnameLabel1.Location = new System.Drawing.Point(32, 55);
            NachnameLabel1.Name = "NachnameLabel1";
            NachnameLabel1.Size = new System.Drawing.Size(62, 13);
            NachnameLabel1.TabIndex = 28;
            NachnameLabel1.Text = "Nachname:";
            // 
            // EmailAddresseLabel1
            // 
            EmailAddresseLabel1.AutoSize = true;
            EmailAddresseLabel1.Location = new System.Drawing.Point(12, 105);
            EmailAddresseLabel1.Name = "EmailAddresseLabel1";
            EmailAddresseLabel1.Size = new System.Drawing.Size(82, 13);
            EmailAddresseLabel1.TabIndex = 29;
            EmailAddresseLabel1.Text = "Email Addresse:";
            // 
            // PositionLabel1
            // 
            PositionLabel1.AutoSize = true;
            PositionLabel1.Location = new System.Drawing.Point(47, 85);
            PositionLabel1.Name = "PositionLabel1";
            PositionLabel1.Size = new System.Drawing.Size(47, 13);
            PositionLabel1.TabIndex = 29;
            PositionLabel1.Text = "Position:";
            // 
            // TelefonGeschaeftlichLabel1
            // 
            TelefonGeschaeftlichLabel1.AutoSize = true;
            TelefonGeschaeftlichLabel1.Location = new System.Drawing.Point(10, 130);
            TelefonGeschaeftlichLabel1.Name = "TelefonGeschaeftlichLabel1";
            TelefonGeschaeftlichLabel1.Size = new System.Drawing.Size(84, 13);
            TelefonGeschaeftlichLabel1.TabIndex = 30;
            TelefonGeschaeftlichLabel1.Text = "Telefon (gesch):";
            // 
            // TelefonPrivatLabel1
            // 
            TelefonPrivatLabel1.AutoSize = true;
            TelefonPrivatLabel1.Location = new System.Drawing.Point(11, 155);
            TelefonPrivatLabel1.Name = "TelefonPrivatLabel1";
            TelefonPrivatLabel1.Size = new System.Drawing.Size(81, 13);
            TelefonPrivatLabel1.TabIndex = 31;
            TelefonPrivatLabel1.Text = "Telefon (privat):";
            // 
            // MobiltelefonLabel1
            // 
            MobiltelefonLabel1.AutoSize = true;
            MobiltelefonLabel1.Location = new System.Drawing.Point(27, 180);
            MobiltelefonLabel1.Name = "MobiltelefonLabel1";
            MobiltelefonLabel1.Size = new System.Drawing.Size(67, 13);
            MobiltelefonLabel1.TabIndex = 32;
            MobiltelefonLabel1.Text = "Mobiltelefon:";
            // 
            // FaxnummerLabel1
            // 
            FaxnummerLabel1.AutoSize = true;
            FaxnummerLabel1.Location = new System.Drawing.Point(30, 205);
            FaxnummerLabel1.Name = "FaxnummerLabel1";
            FaxnummerLabel1.Size = new System.Drawing.Size(64, 13);
            FaxnummerLabel1.TabIndex = 33;
            FaxnummerLabel1.Text = "Faxnummer:";
            // 
            // IDAdresseLabel
            // 
            IDAdresseLabel.AutoSize = true;
            IDAdresseLabel.Location = new System.Drawing.Point(35, 227);
            IDAdresseLabel.Name = "IDAdresseLabel";
            IDAdresseLabel.Size = new System.Drawing.Size(59, 13);
            IDAdresseLabel.TabIndex = 34;
            IDAdresseLabel.Text = "IDAdresse:";
            // 
            // IDKontoLabel
            // 
            IDKontoLabel.AutoSize = true;
            IDKontoLabel.Location = new System.Drawing.Point(29, 215);
            IDKontoLabel.Name = "IDKontoLabel";
            IDKontoLabel.Size = new System.Drawing.Size(49, 13);
            IDKontoLabel.TabIndex = 20;
            IDKontoLabel.Text = "IDKonto:";
            // 
            // IDLKontoLabel2
            // 
            IDLKontoLabel2.AutoSize = true;
            IDLKontoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            IDLKontoLabel2.Location = new System.Drawing.Point(5, 33);
            IDLKontoLabel2.Name = "IDLKontoLabel2";
            IDLKontoLabel2.Size = new System.Drawing.Size(52, 13);
            IDLKontoLabel2.TabIndex = 3;
            IDLKontoLabel2.Text = "ID-Konto:";
            // 
            // DirekterKontaktLabel
            // 
            DirekterKontaktLabel.AutoSize = true;
            DirekterKontaktLabel.Location = new System.Drawing.Point(6, 55);
            DirekterKontaktLabel.Name = "DirekterKontaktLabel";
            DirekterKontaktLabel.Size = new System.Drawing.Size(98, 13);
            DirekterKontaktLabel.TabIndex = 7;
            DirekterKontaktLabel.Text = "Besuchter Kontakt:";
            // 
            // WeitereKontakteLabel
            // 
            WeitereKontakteLabel.AutoSize = true;
            WeitereKontakteLabel.Location = new System.Drawing.Point(3, 98);
            WeitereKontakteLabel.Name = "WeitereKontakteLabel";
            WeitereKontakteLabel.Size = new System.Drawing.Size(245, 13);
            WeitereKontakteLabel.TabIndex = 9;
            WeitereKontakteLabel.Text = "Weitere Telnehmer des besuchten Unternehmens:";
            // 
            // DatumLabel
            // 
            DatumLabel.AutoSize = true;
            DatumLabel.Location = new System.Drawing.Point(5, 138);
            DatumLabel.Name = "DatumLabel";
            DatumLabel.Size = new System.Drawing.Size(105, 13);
            DatumLabel.TabIndex = 11;
            DatumLabel.Text = "Datum des Besuchs:";
            // 
            // VonWemBesuchtLabel
            // 
            VonWemBesuchtLabel.AutoSize = true;
            VonWemBesuchtLabel.Location = new System.Drawing.Point(5, 178);
            VonWemBesuchtLabel.Name = "VonWemBesuchtLabel";
            VonWemBesuchtLabel.Size = new System.Drawing.Size(99, 13);
            VonWemBesuchtLabel.TabIndex = 13;
            VonWemBesuchtLabel.Text = "Von Wem Besucht:";
            // 
            // WeitereBesucherLabel
            // 
            WeitereBesucherLabel.AutoSize = true;
            WeitereBesucherLabel.Location = new System.Drawing.Point(5, 217);
            WeitereBesucherLabel.Name = "WeitereBesucherLabel";
            WeitereBesucherLabel.Size = new System.Drawing.Size(181, 13);
            WeitereBesucherLabel.TabIndex = 15;
            WeitereBesucherLabel.Text = "Weitere Besucher von WSL (Kürzel):";
            // 
            // ThemaLabel
            // 
            ThemaLabel.AutoSize = true;
            ThemaLabel.Location = new System.Drawing.Point(6, 257);
            ThemaLabel.Name = "ThemaLabel";
            ThemaLabel.Size = new System.Drawing.Size(50, 13);
            ThemaLabel.TabIndex = 17;
            ThemaLabel.Text = "Thema *:";
            // 
            // PLZLabel2
            // 
            PLZLabel2.AutoSize = true;
            PLZLabel2.Location = new System.Drawing.Point(226, 154);
            PLZLabel2.Name = "PLZLabel2";
            PLZLabel2.Size = new System.Drawing.Size(48, 13);
            PLZLabel2.TabIndex = 20;
            PLZLabel2.Text = "Adresse:";
            // 
            // FaxnummerLabel3
            // 
            FaxnummerLabel3.AutoSize = true;
            FaxnummerLabel3.Location = new System.Drawing.Point(52, 91);
            FaxnummerLabel3.Name = "FaxnummerLabel3";
            FaxnummerLabel3.Size = new System.Drawing.Size(64, 13);
            FaxnummerLabel3.TabIndex = 3;
            FaxnummerLabel3.Text = "Faxnummer:";
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Location = new System.Drawing.Point(37, 312);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new System.Drawing.Size(82, 13);
            SachbearbeiterLabel.TabIndex = 13;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // JobtitleLabel
            // 
            JobtitleLabel.AutoSize = true;
            JobtitleLabel.Location = new System.Drawing.Point(72, 336);
            JobtitleLabel.Name = "JobtitleLabel";
            JobtitleLabel.Size = new System.Drawing.Size(47, 13);
            JobtitleLabel.TabIndex = 15;
            JobtitleLabel.Text = "Position:";
            // 
            // DurchwahlLabel
            // 
            DurchwahlLabel.AutoSize = true;
            DurchwahlLabel.Location = new System.Drawing.Point(55, 362);
            DurchwahlLabel.Name = "DurchwahlLabel";
            DurchwahlLabel.Size = new System.Drawing.Size(61, 13);
            DurchwahlLabel.TabIndex = 17;
            DurchwahlLabel.Text = "Durchwahl:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new System.Drawing.Point(81, 385);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(35, 13);
            EmailLabel.TabIndex = 19;
            EmailLabel.Text = "Email:";
            // 
            // IDKontoLabel1
            // 
            IDKontoLabel1.AutoSize = true;
            IDKontoLabel1.Location = new System.Drawing.Point(67, 117);
            IDKontoLabel1.Name = "IDKontoLabel1";
            IDKontoLabel1.Size = new System.Drawing.Size(49, 13);
            IDKontoLabel1.TabIndex = 21;
            IDKontoLabel1.Text = "IDKonto:";
            // 
            // StraßeLabel2
            // 
            this.StraßeLabel2.AutoSize = true;
            this.StraßeLabel2.Location = new System.Drawing.Point(55, 242);
            this.StraßeLabel2.Name = "StraßeLabel2";
            this.StraßeLabel2.Size = new System.Drawing.Size(41, 13);
            this.StraßeLabel2.TabIndex = 35;
            this.StraßeLabel2.Text = "Straße:";
            // 
            // OrtLabel2
            // 
            this.OrtLabel2.AutoSize = true;
            this.OrtLabel2.Location = new System.Drawing.Point(70, 257);
            this.OrtLabel2.Name = "OrtLabel2";
            this.OrtLabel2.Size = new System.Drawing.Size(24, 13);
            this.OrtLabel2.TabIndex = 36;
            this.OrtLabel2.Text = "Ort:";
            // 
            // TB_FirmenName
            // 
            this.TB_FirmenName.BackColor = System.Drawing.SystemColors.Window;
            this.TB_FirmenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_FirmenName.Location = new System.Drawing.Point(103, 8);
            this.TB_FirmenName.Name = "TB_FirmenName";
            this.TB_FirmenName.Size = new System.Drawing.Size(327, 22);
            this.TB_FirmenName.TabIndex = 1;
            // 
            // _BTN_Suche
            // 
            this._BTN_Suche.Image = global::Adress_DB.My.Resources.Resources.Search_16x;
            this._BTN_Suche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Suche.Location = new System.Drawing.Point(457, 8);
            this._BTN_Suche.Name = "_BTN_Suche";
            this._BTN_Suche.Size = new System.Drawing.Size(106, 23);
            this._BTN_Suche.TabIndex = 2;
            this._BTN_Suche.Text = "Geschäftspartner";
            this._BTN_Suche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Suche.UseVisualStyleBackColor = true;
            this._BTN_Suche.Click += new System.EventHandler(this.BTN_Suche_Click);
            // 
            // _LBL_IDFirmenName
            // 
            this._LBL_IDFirmenName.BackColor = System.Drawing.Color.Transparent;
            this._LBL_IDFirmenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "IDFirmenName", true));
            this._LBL_IDFirmenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LBL_IDFirmenName.ForeColor = System.Drawing.Color.White;
            this._LBL_IDFirmenName.Location = new System.Drawing.Point(3, 34);
            this._LBL_IDFirmenName.Name = "_LBL_IDFirmenName";
            this._LBL_IDFirmenName.Size = new System.Drawing.Size(94, 23);
            this._LBL_IDFirmenName.TabIndex = 8;
            this._LBL_IDFirmenName.Text = "IDFirmenName";
            this._LBL_IDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._LBL_IDFirmenName.TextChanged += new System.EventHandler(this.LBL_IDFirmenName_TextChanged);
            // 
            // FirmenNameBindingSource
            // 
            this.FirmenNameBindingSource.DataMember = "FirmenName";
            this.FirmenNameBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblIDKonto
            // 
            this.lblIDKonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontoBindingSource, "IDKonto", true));
            this.lblIDKonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDKonto.Location = new System.Drawing.Point(6, 86);
            this.lblIDKonto.Name = "lblIDKonto";
            this.lblIDKonto.Size = new System.Drawing.Size(109, 23);
            this.lblIDKonto.TabIndex = 10;
            this.lblIDKonto.Text = "IDKonto";
            this.lblIDKonto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KontoBindingSource
            // 
            this.KontoBindingSource.DataMember = "Konto";
            this.KontoBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _CB_FirmenName
            // 
            this._CB_FirmenName.DataSource = this.FirmenNameBindingSource;
            this._CB_FirmenName.DisplayMember = "FirmenName";
            this._CB_FirmenName.Enabled = false;
            this._CB_FirmenName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._CB_FirmenName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CB_FirmenName.FormattingEnabled = true;
            this._CB_FirmenName.Location = new System.Drawing.Point(103, 36);
            this._CB_FirmenName.Name = "_CB_FirmenName";
            this._CB_FirmenName.Size = new System.Drawing.Size(408, 27);
            this._CB_FirmenName.TabIndex = 3;
            this._CB_FirmenName.SelectedIndexChanged += new System.EventHandler(this.cbFirmenName_SelectedIndexChanged);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Gray;
            this.TLP_1.SetColumnSpan(this.Panel1, 3);
            this.Panel1.Controls.Add(this._BTN_NachnameSuche);
            this.Panel1.Controls.Add(this.lblTrefferAnzahl);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this._CB_FirmenName);
            this.Panel1.Controls.Add(this.TB_FirmenName);
            this.Panel1.Controls.Add(this._BTN_Suche);
            this.Panel1.Controls.Add(this._LBL_IDFirmenName);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(764, 69);
            this.Panel1.TabIndex = 12;
            // 
            // _BTN_NachnameSuche
            // 
            this._BTN_NachnameSuche.Image = global::Adress_DB.My.Resources.Resources.Search_16x;
            this._BTN_NachnameSuche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_NachnameSuche.Location = new System.Drawing.Point(604, 8);
            this._BTN_NachnameSuche.Name = "_BTN_NachnameSuche";
            this._BTN_NachnameSuche.Size = new System.Drawing.Size(106, 23);
            this._BTN_NachnameSuche.TabIndex = 20;
            this._BTN_NachnameSuche.Text = "Nachname";
            this._BTN_NachnameSuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_NachnameSuche.UseVisualStyleBackColor = true;
            this._BTN_NachnameSuche.Click += new System.EventHandler(this.BTN_NachnameSuche_Click);
            // 
            // lblTrefferAnzahl
            // 
            this.lblTrefferAnzahl.AutoSize = true;
            this.lblTrefferAnzahl.BackColor = System.Drawing.Color.White;
            this.lblTrefferAnzahl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrefferAnzahl.Location = new System.Drawing.Point(517, 40);
            this.lblTrefferAnzahl.Name = "lblTrefferAnzahl";
            this.lblTrefferAnzahl.Size = new System.Drawing.Size(106, 17);
            this.lblTrefferAnzahl.TabIndex = 19;
            this.lblTrefferAnzahl.Text = "Trefferanzahl";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(30, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(66, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Suchtext:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // _Button1
            // 
            this._Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._Button1.Location = new System.Drawing.Point(241, 20);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(147, 23);
            this._Button1.TabIndex = 21;
            this._Button1.Text = "Umkreissuche D-A-CH";
            this._Button1.UseVisualStyleBackColor = true;
            this._Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblHinweisKeinTreffer
            // 
            this.lblHinweisKeinTreffer.AutoSize = true;
            this.lblHinweisKeinTreffer.BackColor = System.Drawing.SystemColors.Control;
            this.lblHinweisKeinTreffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHinweisKeinTreffer.ForeColor = System.Drawing.Color.Red;
            this.lblHinweisKeinTreffer.Location = new System.Drawing.Point(545, 4);
            this.lblHinweisKeinTreffer.Name = "lblHinweisKeinTreffer";
            this.lblHinweisKeinTreffer.Size = new System.Drawing.Size(192, 26);
            this.lblHinweisKeinTreffer.TabIndex = 16;
            this.lblHinweisKeinTreffer.Text = "0 Treffer Hinweis";
            this.lblHinweisKeinTreffer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocuwareCSVDataGridView
            // 
            this.DocuwareCSVDataGridView.AllowUserToAddRows = false;
            this.DocuwareCSVDataGridView.AutoGenerateColumns = false;
            this.DocuwareCSVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocuwareCSVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn15,
            this.DataGridViewTextBoxColumn16,
            this.DataGridViewTextBoxColumn18,
            this.DataGridViewTextBoxColumn19});
            this.DocuwareCSVDataGridView.DataSource = this.DocuwareCSVBindingSource;
            this.DocuwareCSVDataGridView.Location = new System.Drawing.Point(34, 11);
            this.DocuwareCSVDataGridView.Name = "DocuwareCSVDataGridView";
            this.DocuwareCSVDataGridView.RowHeadersVisible = false;
            this.DocuwareCSVDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DocuwareCSVDataGridView.Size = new System.Drawing.Size(43, 46);
            this.DocuwareCSVDataGridView.TabIndex = 23;
            this.DocuwareCSVDataGridView.Visible = false;
            // 
            // DataGridViewTextBoxColumn15
            // 
            this.DataGridViewTextBoxColumn15.DataPropertyName = "IDKonto";
            this.DataGridViewTextBoxColumn15.HeaderText = "ID-Konto";
            this.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15";
            this.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DataGridViewTextBoxColumn16
            // 
            this.DataGridViewTextBoxColumn16.DataPropertyName = "FirmenName";
            this.DataGridViewTextBoxColumn16.HeaderText = "Adress-Name";
            this.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16";
            // 
            // DataGridViewTextBoxColumn18
            // 
            this.DataGridViewTextBoxColumn18.DataPropertyName = "KontoName";
            this.DataGridViewTextBoxColumn18.HeaderText = "Konto-Name";
            this.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18";
            // 
            // DataGridViewTextBoxColumn19
            // 
            this.DataGridViewTextBoxColumn19.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn19.HeaderText = "ID-Adress-Name";
            this.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19";
            // 
            // DocuwareCSVBindingSource
            // 
            this.DocuwareCSVBindingSource.DataMember = "DocuwareCSV";
            this.DocuwareCSVBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _LBL_IDAdresse
            // 
            this._LBL_IDAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._LBL_IDAdresse.BackColor = System.Drawing.Color.Transparent;
            this._LBL_IDAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDAdresse", true));
            this._LBL_IDAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LBL_IDAdresse.ForeColor = System.Drawing.Color.DarkGray;
            this._LBL_IDAdresse.Location = new System.Drawing.Point(203, 2);
            this._LBL_IDAdresse.Name = "_LBL_IDAdresse";
            this._LBL_IDAdresse.Size = new System.Drawing.Size(80, 23);
            this._LBL_IDAdresse.TabIndex = 3;
            this._LBL_IDAdresse.Text = "IDAdresse";
            this._LBL_IDAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._LBL_IDAdresse.TextChanged += new System.EventHandler(this.LBL_IDAdresse_TextChanged);
            // 
            // AdressenBindingSource
            // 
            this.AdressenBindingSource.DataMember = "Adressen";
            this.AdressenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _btnNeueAdresse
            // 
            this._btnNeueAdresse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNeueAdresse.BackColor = System.Drawing.Color.Green;
            this._btnNeueAdresse.ForeColor = System.Drawing.Color.White;
            this._btnNeueAdresse.Image = global::Adress_DB.My.Resources.Resources.AddressEditor_16x;
            this._btnNeueAdresse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnNeueAdresse.Location = new System.Drawing.Point(175, 5);
            this._btnNeueAdresse.Name = "_btnNeueAdresse";
            this._btnNeueAdresse.Size = new System.Drawing.Size(105, 23);
            this._btnNeueAdresse.TabIndex = 0;
            this._btnNeueAdresse.Text = "neue Adresse";
            this._btnNeueAdresse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnNeueAdresse.UseVisualStyleBackColor = false;
            this._btnNeueAdresse.Click += new System.EventHandler(this.btnNeueAdresse_Click);
            // 
            // _btnNeuerKontakt
            // 
            this._btnNeuerKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNeuerKontakt.BackColor = System.Drawing.Color.Green;
            this._btnNeuerKontakt.ForeColor = System.Drawing.Color.White;
            this._btnNeuerKontakt.Image = global::Adress_DB.My.Resources.Resources.AddUser_16x;
            this._btnNeuerKontakt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnNeuerKontakt.Location = new System.Drawing.Point(175, 5);
            this._btnNeuerKontakt.Name = "_btnNeuerKontakt";
            this._btnNeuerKontakt.Size = new System.Drawing.Size(105, 23);
            this._btnNeuerKontakt.TabIndex = 2;
            this._btnNeuerKontakt.Text = "neuer Kontakt";
            this._btnNeuerKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnNeuerKontakt.UseVisualStyleBackColor = false;
            this._btnNeuerKontakt.Click += new System.EventHandler(this.btnNeuerKontakt_Click);
            // 
            // _BTN_ZuOutlook
            // 
            this._BTN_ZuOutlook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_ZuOutlook.Image = ((System.Drawing.Image)(resources.GetObject("_BTN_ZuOutlook.Image")));
            this._BTN_ZuOutlook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_ZuOutlook.Location = new System.Drawing.Point(175, 282);
            this._BTN_ZuOutlook.Name = "_BTN_ZuOutlook";
            this._BTN_ZuOutlook.Size = new System.Drawing.Size(105, 28);
            this._BTN_ZuOutlook.TabIndex = 1;
            this._BTN_ZuOutlook.Text = "zu Outlook";
            this._BTN_ZuOutlook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_ZuOutlook.UseVisualStyleBackColor = true;
            this._BTN_ZuOutlook.Click += new System.EventHandler(this.BTN_ZuOutlook_Click);
            // 
            // _BTN_MapsSuche
            // 
            this._BTN_MapsSuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_MapsSuche.Image = ((System.Drawing.Image)(resources.GetObject("_BTN_MapsSuche.Image")));
            this._BTN_MapsSuche.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_MapsSuche.Location = new System.Drawing.Point(175, 281);
            this._BTN_MapsSuche.Name = "_BTN_MapsSuche";
            this._BTN_MapsSuche.Size = new System.Drawing.Size(105, 28);
            this._BTN_MapsSuche.TabIndex = 1;
            this._BTN_MapsSuche.Text = "GMaps Suche";
            this._BTN_MapsSuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_MapsSuche.UseVisualStyleBackColor = true;
            this._BTN_MapsSuche.Click += new System.EventHandler(this.btnMapsSuche_Click);
            // 
            // Panel4
            // 
            this.Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel4.BackColor = System.Drawing.Color.Silver;
            this.Panel4.Controls.Add(this.label12);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Location = new System.Drawing.Point(3, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(158, 27);
            this.Panel4.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(98, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "nur für\r\nGUS / DATEV";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(2, 2);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(59, 24);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Konto";
            // 
            // _btnNeuesKonto
            // 
            this._btnNeuesKonto.Image = global::Adress_DB.My.Resources.Resources.AccountGroup_16x;
            this._btnNeuesKonto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnNeuesKonto.Location = new System.Drawing.Point(6, 35);
            this._btnNeuesKonto.Name = "_btnNeuesKonto";
            this._btnNeuesKonto.Size = new System.Drawing.Size(100, 23);
            this._btnNeuesKonto.TabIndex = 4;
            this._btnNeuesKonto.Text = "Neues Konto";
            this._btnNeuesKonto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnNeuesKonto.UseVisualStyleBackColor = true;
            this._btnNeuesKonto.Click += new System.EventHandler(this.btnNeuesKonto_Click);
            // 
            // KontoDataGridView
            // 
            this.KontoDataGridView.AllowUserToAddRows = false;
            this.KontoDataGridView.AllowUserToDeleteRows = false;
            this.KontoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KontoDataGridView.AutoGenerateColumns = false;
            this.KontoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.KontoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn6});
            this.KontoDataGridView.DataSource = this.KontoBindingSource;
            this.KontoDataGridView.Location = new System.Drawing.Point(3, 112);
            this.KontoDataGridView.Name = "KontoDataGridView";
            this.KontoDataGridView.ReadOnly = true;
            this.KontoDataGridView.RowHeadersVisible = false;
            this.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KontoDataGridView.Size = new System.Drawing.Size(158, 194);
            this.KontoDataGridView.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 63);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 13);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "markiertes Konto:";
            // 
            // BTN_Speichern
            // 
            this.BTN_Speichern.Image = global::Adress_DB.My.Resources.Resources.Save_16x;
            this.BTN_Speichern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Speichern.Location = new System.Drawing.Point(639, 10);
            this.BTN_Speichern.Name = "BTN_Speichern";
            this.BTN_Speichern.Size = new System.Drawing.Size(80, 23);
            this.BTN_Speichern.TabIndex = 15;
            this.BTN_Speichern.Text = "Speichern";
            this.BTN_Speichern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Speichern.UseVisualStyleBackColor = true;
            this.BTN_Speichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // _btnKontoZuAdresse
            // 
            this._btnKontoZuAdresse.Location = new System.Drawing.Point(74, 270);
            this._btnKontoZuAdresse.Name = "_btnKontoZuAdresse";
            this._btnKontoZuAdresse.Size = new System.Drawing.Size(92, 23);
            this._btnKontoZuAdresse.TabIndex = 10;
            this._btnKontoZuAdresse.Text = "Konto zuord.";
            this._btnKontoZuAdresse.UseVisualStyleBackColor = true;
            this._btnKontoZuAdresse.Click += new System.EventHandler(this.btnKontoZuAdresse_Click);
            // 
            // IDKontoTextBox
            // 
            this.IDKontoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDKontoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDKonto", true));
            this.IDKontoTextBox.Enabled = false;
            this.IDKontoTextBox.Location = new System.Drawing.Point(172, 270);
            this.IDKontoTextBox.Name = "IDKontoTextBox";
            this.IDKontoTextBox.Size = new System.Drawing.Size(109, 20);
            this.IDKontoTextBox.TabIndex = 23;
            // 
            // WebseiteTextBox
            // 
            this.WebseiteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebseiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Webseite", true));
            this.WebseiteTextBox.Location = new System.Drawing.Point(74, 244);
            this.WebseiteTextBox.Name = "WebseiteTextBox";
            this.WebseiteTextBox.Size = new System.Drawing.Size(207, 20);
            this.WebseiteTextBox.TabIndex = 9;
            // 
            // UStIdNrTextBox
            // 
            this.UStIdNrTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UStIdNrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "UStIdNr", true));
            this.UStIdNrTextBox.Location = new System.Drawing.Point(74, 218);
            this.UStIdNrTextBox.Name = "UStIdNrTextBox";
            this.UStIdNrTextBox.Size = new System.Drawing.Size(207, 20);
            this.UStIdNrTextBox.TabIndex = 8;
            // 
            // TB_Bundesland
            // 
            this.TB_Bundesland.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Bundesland.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Bundesland", true));
            this.TB_Bundesland.Location = new System.Drawing.Point(74, 192);
            this.TB_Bundesland.Name = "TB_Bundesland";
            this.TB_Bundesland.Size = new System.Drawing.Size(207, 20);
            this.TB_Bundesland.TabIndex = 7;
            // 
            // PostfachTextBox
            // 
            this.PostfachTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PostfachTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Postfach", true));
            this.PostfachTextBox.Location = new System.Drawing.Point(74, 112);
            this.PostfachTextBox.Name = "PostfachTextBox";
            this.PostfachTextBox.Size = new System.Drawing.Size(207, 20);
            this.PostfachTextBox.TabIndex = 4;
            // 
            // _TB_PLZ
            // 
            this._TB_PLZ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "PLZ", true));
            this._TB_PLZ.Location = new System.Drawing.Point(74, 138);
            this._TB_PLZ.Name = "_TB_PLZ";
            this._TB_PLZ.Size = new System.Drawing.Size(92, 20);
            this._TB_PLZ.TabIndex = 5;
            this._TB_PLZ.TextChanged += new System.EventHandler(this.TB_PLZ_TextChanged);
            // 
            // StraßeTextBox
            // 
            this.StraßeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StraßeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Straße", true));
            this.StraßeTextBox.Location = new System.Drawing.Point(74, 86);
            this.StraßeTextBox.Name = "StraßeTextBox";
            this.StraßeTextBox.Size = new System.Drawing.Size(207, 20);
            this.StraßeTextBox.TabIndex = 3;
            // 
            // AdresstypTextBox
            // 
            this.AdresstypTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdresstypTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Adresstyp", true));
            this.AdresstypTextBox.Location = new System.Drawing.Point(74, 34);
            this.AdresstypTextBox.Name = "AdresstypTextBox";
            this.AdresstypTextBox.Size = new System.Drawing.Size(207, 20);
            this.AdresstypTextBox.TabIndex = 1;
            // 
            // AdressenDataGridView
            // 
            this.AdressenDataGridView.AllowUserToAddRows = false;
            this.AdressenDataGridView.AllowUserToDeleteRows = false;
            this.AdressenDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressenDataGridView.AutoGenerateColumns = false;
            this.AdressenDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AdressenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdressenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAdresse,
            this.IDKonto,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn10});
            this.AdressenDataGridView.DataSource = this.AdressenBindingSource;
            this.AdressenDataGridView.Location = new System.Drawing.Point(3, 316);
            this.AdressenDataGridView.Name = "AdressenDataGridView";
            this.AdressenDataGridView.RowHeadersVisible = false;
            this.AdressenDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AdressenDataGridView.Size = new System.Drawing.Size(280, 104);
            this.AdressenDataGridView.TabIndex = 6;
            // 
            // _EmailAddresseLinkLabel
            // 
            this._EmailAddresseLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "EmailAddresse", true));
            this._EmailAddresseLinkLabel.Location = new System.Drawing.Point(100, 105);
            this._EmailAddresseLinkLabel.Name = "_EmailAddresseLinkLabel";
            this._EmailAddresseLinkLabel.Size = new System.Drawing.Size(176, 15);
            this._EmailAddresseLinkLabel.TabIndex = 26;
            this._EmailAddresseLinkLabel.TabStop = true;
            this._EmailAddresseLinkLabel.Text = "Email";
            this._EmailAddresseLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._EmailAddresseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EmailAddresseLinkLabel_LinkClicked);
            // 
            // KontakteBindingSource
            // 
            this.KontakteBindingSource.DataMember = "Kontakte";
            this.KontakteBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _btnAdresseZuKontakt
            // 
            this._btnAdresseZuKontakt.Location = new System.Drawing.Point(102, 267);
            this._btnAdresseZuKontakt.Name = "_btnAdresseZuKontakt";
            this._btnAdresseZuKontakt.Size = new System.Drawing.Size(92, 23);
            this._btnAdresseZuKontakt.TabIndex = 25;
            this._btnAdresseZuKontakt.Text = "Adresse zuord.";
            this._btnAdresseZuKontakt.UseVisualStyleBackColor = true;
            this._btnAdresseZuKontakt.Click += new System.EventHandler(this.btnAdresseZuKontakt_Click);
            // 
            // IDAdresseTextBox
            // 
            this.IDAdresseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDAdresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDAdresse", true));
            this.IDAdresseTextBox.Enabled = false;
            this.IDAdresseTextBox.Location = new System.Drawing.Point(200, 267);
            this.IDAdresseTextBox.Name = "IDAdresseTextBox";
            this.IDAdresseTextBox.Size = new System.Drawing.Size(80, 20);
            this.IDAdresseTextBox.TabIndex = 22;
            // 
            // FaxnummerTextBox
            // 
            this.FaxnummerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FaxnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Faxnummer", true));
            this.FaxnummerTextBox.Location = new System.Drawing.Point(104, 241);
            this.FaxnummerTextBox.Name = "FaxnummerTextBox";
            this.FaxnummerTextBox.Size = new System.Drawing.Size(176, 20);
            this.FaxnummerTextBox.TabIndex = 20;
            // 
            // MobiltelefonTextBox
            // 
            this.MobiltelefonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MobiltelefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Mobiltelefon", true));
            this.MobiltelefonTextBox.Location = new System.Drawing.Point(104, 215);
            this.MobiltelefonTextBox.Name = "MobiltelefonTextBox";
            this.MobiltelefonTextBox.Size = new System.Drawing.Size(176, 20);
            this.MobiltelefonTextBox.TabIndex = 18;
            // 
            // TelefonPrivatTextBox
            // 
            this.TelefonPrivatTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonPrivatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonPrivat", true));
            this.TelefonPrivatTextBox.Location = new System.Drawing.Point(104, 189);
            this.TelefonPrivatTextBox.Name = "TelefonPrivatTextBox";
            this.TelefonPrivatTextBox.Size = new System.Drawing.Size(176, 20);
            this.TelefonPrivatTextBox.TabIndex = 16;
            // 
            // TelefonGeschaeftlichTextBox
            // 
            this.TelefonGeschaeftlichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonGeschaeftlichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonGeschaeftlich", true));
            this.TelefonGeschaeftlichTextBox.Location = new System.Drawing.Point(104, 163);
            this.TelefonGeschaeftlichTextBox.Name = "TelefonGeschaeftlichTextBox";
            this.TelefonGeschaeftlichTextBox.Size = new System.Drawing.Size(176, 20);
            this.TelefonGeschaeftlichTextBox.TabIndex = 14;
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Jobtitle", true));
            this.PositionTextBox.Location = new System.Drawing.Point(104, 137);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(176, 20);
            this.PositionTextBox.TabIndex = 12;
            // 
            // EmailAddresseTextBox
            // 
            this.EmailAddresseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailAddresseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "EmailAddresse", true));
            this.EmailAddresseTextBox.Location = new System.Drawing.Point(104, 111);
            this.EmailAddresseTextBox.Name = "EmailAddresseTextBox";
            this.EmailAddresseTextBox.Size = new System.Drawing.Size(176, 20);
            this.EmailAddresseTextBox.TabIndex = 10;
            // 
            // VornameTextBox
            // 
            this.VornameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Vorname", true));
            this.VornameTextBox.Location = new System.Drawing.Point(104, 87);
            this.VornameTextBox.Name = "VornameTextBox";
            this.VornameTextBox.Size = new System.Drawing.Size(176, 20);
            this.VornameTextBox.TabIndex = 8;
            // 
            // NachnameTextBox
            // 
            this.NachnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Nachname", true));
            this.NachnameTextBox.Location = new System.Drawing.Point(104, 62);
            this.NachnameTextBox.Name = "NachnameTextBox";
            this.NachnameTextBox.Size = new System.Drawing.Size(176, 20);
            this.NachnameTextBox.TabIndex = 6;
            // 
            // AnredeComboBox
            // 
            this.AnredeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnredeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Anrede", true));
            this.AnredeComboBox.FormattingEnabled = true;
            this.AnredeComboBox.Location = new System.Drawing.Point(104, 37);
            this.AnredeComboBox.Name = "AnredeComboBox";
            this.AnredeComboBox.Size = new System.Drawing.Size(176, 21);
            this.AnredeComboBox.TabIndex = 4;
            // 
            // _LBL_IDKontakt
            // 
            this._LBL_IDKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._LBL_IDKontakt.BackColor = System.Drawing.Color.Transparent;
            this._LBL_IDKontakt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDKontakt", true));
            this._LBL_IDKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LBL_IDKontakt.ForeColor = System.Drawing.Color.DarkGray;
            this._LBL_IDKontakt.Location = new System.Drawing.Point(186, 1);
            this._LBL_IDKontakt.Name = "_LBL_IDKontakt";
            this._LBL_IDKontakt.Size = new System.Drawing.Size(100, 23);
            this._LBL_IDKontakt.TabIndex = 3;
            this._LBL_IDKontakt.Text = "IDKontakt";
            this._LBL_IDKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._LBL_IDKontakt.TextChanged += new System.EventHandler(this.LBL_IDKontakt_TextChanged);
            // 
            // KontakteDataGridView
            // 
            this.KontakteDataGridView.AllowUserToAddRows = false;
            this.KontakteDataGridView.AllowUserToDeleteRows = false;
            this.KontakteDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KontakteDataGridView.AutoGenerateColumns = false;
            this.KontakteDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.KontakteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KontakteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDKontakt,
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn9});
            this.KontakteDataGridView.DataSource = this.KontakteBindingSource;
            this.KontakteDataGridView.Location = new System.Drawing.Point(3, 316);
            this.KontakteDataGridView.Name = "KontakteDataGridView";
            this.KontakteDataGridView.RowHeadersVisible = false;
            this.KontakteDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KontakteDataGridView.Size = new System.Drawing.Size(280, 104);
            this.KontakteDataGridView.TabIndex = 1;
            // 
            // IDKontakt
            // 
            this.IDKontakt.DataPropertyName = "IDKontakt";
            this.IDKontakt.HeaderText = "IDKontakt";
            this.IDKontakt.Name = "IDKontakt";
            this.IDKontakt.Visible = false;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.DataPropertyName = "Vorname";
            this.DataGridViewTextBoxColumn11.HeaderText = "Vorname";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.Width = 140;
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.DataPropertyName = "Nachname";
            this.DataGridViewTextBoxColumn9.HeaderText = "Nachname";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            this.DataGridViewTextBoxColumn9.Width = 140;
            // 
            // Panel3
            // 
            this.Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3.BackColor = System.Drawing.Color.Silver;
            this.Panel3.Controls.Add(this.lblKontaktHeader);
            this.Panel3.Controls.Add(this._LBL_IDKontakt);
            this.Panel3.Location = new System.Drawing.Point(0, 0);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(286, 27);
            this.Panel3.TabIndex = 1;
            // 
            // lblKontaktHeader
            // 
            this.lblKontaktHeader.AutoSize = true;
            this.lblKontaktHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontaktHeader.Location = new System.Drawing.Point(2, 2);
            this.lblKontaktHeader.Name = "lblKontaktHeader";
            this.lblKontaktHeader.Size = new System.Drawing.Size(71, 24);
            this.lblKontaktHeader.TabIndex = 0;
            this.lblKontaktHeader.Text = "Kontakt";
            // 
            // TC_Beleg
            // 
            this.TC_Beleg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Beleg.Controls.Add(this.TabPage1);
            this.TC_Beleg.Controls.Add(this.TabPage2);
            this.TC_Beleg.Controls.Add(this.TabPage3);
            this.TC_Beleg.Location = new System.Drawing.Point(773, 78);
            this.TC_Beleg.Name = "TC_Beleg";
            this.TLP_1.SetRowSpan(this.TC_Beleg, 2);
            this.TC_Beleg.SelectedIndex = 0;
            this.TC_Beleg.Size = new System.Drawing.Size(401, 449);
            this.TC_Beleg.TabIndex = 19;
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.White;
            this.TabPage1.Controls.Add(this.CB_BBKuerzel);
            this.TabPage1.Controls.Add(this.TB_BBWeitereBesucher);
            this.TabPage1.Controls.Add(this.TB_BBWeitereKontakte);
            this.TabPage1.Controls.Add(this.LBL_BBRegion);
            this.TabPage1.Controls.Add(this.LBL_BBIDKonto);
            this.TabPage1.Controls.Add(this.LBL_BBBesuchterKontakt);
            this.TabPage1.Controls.Add(this.LBL_BBLand);
            this.TabPage1.Controls.Add(this.LBL_BBOrt);
            this.TabPage1.Controls.Add(PLZLabel2);
            this.TabPage1.Controls.Add(this.LBL_BBPLZ);
            this.TabPage1.Controls.Add(this.LBL_BBStrasse);
            this.TabPage1.Controls.Add(ThemaLabel);
            this.TabPage1.Controls.Add(this.TB_BBThema);
            this.TabPage1.Controls.Add(WeitereBesucherLabel);
            this.TabPage1.Controls.Add(VonWemBesuchtLabel);
            this.TabPage1.Controls.Add(DatumLabel);
            this.TabPage1.Controls.Add(this.DTP_BBDatum);
            this.TabPage1.Controls.Add(WeitereKontakteLabel);
            this.TabPage1.Controls.Add(DirekterKontaktLabel);
            this.TabPage1.Controls.Add(IDLKontoLabel2);
            this.TabPage1.Controls.Add(this.Panel5);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(393, 423);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Besuchsbericht";
            // 
            // CB_BBKuerzel
            // 
            this.CB_BBKuerzel.DataSource = this.SachbearbeiterBindingSource;
            this.CB_BBKuerzel.DisplayMember = "Kuerzel";
            this.CB_BBKuerzel.FormattingEnabled = true;
            this.CB_BBKuerzel.Location = new System.Drawing.Point(5, 194);
            this.CB_BBKuerzel.Name = "CB_BBKuerzel";
            this.CB_BBKuerzel.Size = new System.Drawing.Size(181, 21);
            this.CB_BBKuerzel.TabIndex = 33;
            // 
            // SachbearbeiterBindingSource
            // 
            this.SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            this.SachbearbeiterBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // TB_BBWeitereBesucher
            // 
            this.TB_BBWeitereBesucher.Location = new System.Drawing.Point(6, 234);
            this.TB_BBWeitereBesucher.Name = "TB_BBWeitereBesucher";
            this.TB_BBWeitereBesucher.Size = new System.Drawing.Size(180, 20);
            this.TB_BBWeitereBesucher.TabIndex = 32;
            // 
            // TB_BBWeitereKontakte
            // 
            this.TB_BBWeitereKontakte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_BBWeitereKontakte.Location = new System.Drawing.Point(6, 114);
            this.TB_BBWeitereKontakte.Name = "TB_BBWeitereKontakte";
            this.TB_BBWeitereKontakte.Size = new System.Drawing.Size(378, 20);
            this.TB_BBWeitereKontakte.TabIndex = 31;
            // 
            // LBL_BBRegion
            // 
            this.LBL_BBRegion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Bundesland", true));
            this.LBL_BBRegion.Location = new System.Drawing.Point(226, 207);
            this.LBL_BBRegion.Name = "LBL_BBRegion";
            this.LBL_BBRegion.Size = new System.Drawing.Size(158, 16);
            this.LBL_BBRegion.TabIndex = 30;
            this.LBL_BBRegion.Text = "Bundesland";
            // 
            // LBL_BBIDKonto
            // 
            this.LBL_BBIDKonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDKonto", true));
            this.LBL_BBIDKonto.ForeColor = System.Drawing.Color.Gray;
            this.LBL_BBIDKonto.Location = new System.Drawing.Point(61, 33);
            this.LBL_BBIDKonto.Name = "LBL_BBIDKonto";
            this.LBL_BBIDKonto.Size = new System.Drawing.Size(49, 13);
            this.LBL_BBIDKonto.TabIndex = 29;
            this.LBL_BBIDKonto.Text = "IDKonto";
            this.LBL_BBIDKonto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_BBBesuchterKontakt
            // 
            this.LBL_BBBesuchterKontakt.BackColor = System.Drawing.Color.Transparent;
            this.LBL_BBBesuchterKontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BBBesuchterKontakt.Location = new System.Drawing.Point(6, 71);
            this.LBL_BBBesuchterKontakt.Name = "LBL_BBBesuchterKontakt";
            this.LBL_BBBesuchterKontakt.Size = new System.Drawing.Size(381, 23);
            this.LBL_BBBesuchterKontakt.TabIndex = 28;
            this.LBL_BBBesuchterKontakt.Text = "Thomas Müller";
            this.LBL_BBBesuchterKontakt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_BBLand
            // 
            this.LBL_BBLand.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Land", true));
            this.LBL_BBLand.Location = new System.Drawing.Point(226, 222);
            this.LBL_BBLand.Name = "LBL_BBLand";
            this.LBL_BBLand.Size = new System.Drawing.Size(158, 13);
            this.LBL_BBLand.TabIndex = 24;
            this.LBL_BBLand.Text = "Deutschland";
            // 
            // LBL_BBOrt
            // 
            this.LBL_BBOrt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Ort", true));
            this.LBL_BBOrt.Location = new System.Drawing.Point(271, 192);
            this.LBL_BBOrt.Name = "LBL_BBOrt";
            this.LBL_BBOrt.Size = new System.Drawing.Size(113, 15);
            this.LBL_BBOrt.TabIndex = 23;
            this.LBL_BBOrt.Text = "Hannover";
            // 
            // LBL_BBPLZ
            // 
            this.LBL_BBPLZ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "PLZ", true));
            this.LBL_BBPLZ.Location = new System.Drawing.Point(226, 192);
            this.LBL_BBPLZ.Name = "LBL_BBPLZ";
            this.LBL_BBPLZ.Size = new System.Drawing.Size(48, 14);
            this.LBL_BBPLZ.TabIndex = 21;
            this.LBL_BBPLZ.Text = "30419";
            // 
            // LBL_BBStrasse
            // 
            this.LBL_BBStrasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Straße", true));
            this.LBL_BBStrasse.Location = new System.Drawing.Point(226, 177);
            this.LBL_BBStrasse.Name = "LBL_BBStrasse";
            this.LBL_BBStrasse.Size = new System.Drawing.Size(158, 15);
            this.LBL_BBStrasse.TabIndex = 20;
            this.LBL_BBStrasse.Text = "Strasse 24";
            // 
            // TB_BBThema
            // 
            this.TB_BBThema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_BBThema.Location = new System.Drawing.Point(6, 272);
            this.TB_BBThema.Name = "TB_BBThema";
            this.TB_BBThema.Size = new System.Drawing.Size(378, 20);
            this.TB_BBThema.TabIndex = 18;
            // 
            // DTP_BBDatum
            // 
            this.DTP_BBDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_BBDatum.Location = new System.Drawing.Point(5, 154);
            this.DTP_BBDatum.Name = "DTP_BBDatum";
            this.DTP_BBDatum.Size = new System.Drawing.Size(181, 20);
            this.DTP_BBDatum.TabIndex = 12;
            this.DTP_BBDatum.Value = new System.DateTime(2021, 10, 11, 0, 0, 0, 0);
            // 
            // Panel5
            // 
            this.Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel5.BackColor = System.Drawing.Color.Silver;
            this.Panel5.Controls.Add(this.Label7);
            this.Panel5.Location = new System.Drawing.Point(0, 0);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(401, 26);
            this.Panel5.TabIndex = 1;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(2, 2);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(140, 24);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "Besuchsbericht";
            // 
            // TabPage2
            // 
            this.TabPage2.AutoScroll = true;
            this.TabPage2.Controls.Add(IDKontoLabel1);
            this.TabPage2.Controls.Add(this.LBL_DIVIDKonto);
            this.TabPage2.Controls.Add(EmailLabel);
            this.TabPage2.Controls.Add(this.LBL_DIVEmail);
            this.TabPage2.Controls.Add(DurchwahlLabel);
            this.TabPage2.Controls.Add(this.LBL_DIVDurchwahl);
            this.TabPage2.Controls.Add(JobtitleLabel);
            this.TabPage2.Controls.Add(this.LBL_DIVJobtitle);
            this.TabPage2.Controls.Add(SachbearbeiterLabel);
            this.TabPage2.Controls.Add(this.CB_DIVSachbearbeiter);
            this.TabPage2.Controls.Add(this.Label10);
            this.TabPage2.Controls.Add(this.Label9);
            this.TabPage2.Controls.Add(this.TB_DIVThema);
            this.TabPage2.Controls.Add(this.DTP_Diverse);
            this.TabPage2.Controls.Add(this.GroupBox2);
            this.TabPage2.Controls.Add(this.GB_Anrede);
            this.TabPage2.Controls.Add(this.TB_DIVFaxnummer);
            this.TabPage2.Controls.Add(this._LBL_Sprache);
            this.TabPage2.Controls.Add(this.Label8);
            this.TabPage2.Controls.Add(FaxnummerLabel3);
            this.TabPage2.Controls.Add(this.Panel2);
            this.TabPage2.Controls.Add(this.Label2);
            this.TabPage2.Controls.Add(this._CB_Vorlagen);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(393, 423);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Brief / Fax / TN / diverse";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // LBL_DIVIDKonto
            // 
            this.LBL_DIVIDKonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDKonto", true));
            this.LBL_DIVIDKonto.Location = new System.Drawing.Point(122, 117);
            this.LBL_DIVIDKonto.Name = "LBL_DIVIDKonto";
            this.LBL_DIVIDKonto.Size = new System.Drawing.Size(100, 15);
            this.LBL_DIVIDKonto.TabIndex = 22;
            this.LBL_DIVIDKonto.Text = "IDKonto";
            // 
            // LBL_DIVEmail
            // 
            this.LBL_DIVEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SachbearbeiterBindingSource, "Email", true));
            this.LBL_DIVEmail.Location = new System.Drawing.Point(122, 385);
            this.LBL_DIVEmail.Name = "LBL_DIVEmail";
            this.LBL_DIVEmail.Size = new System.Drawing.Size(255, 23);
            this.LBL_DIVEmail.TabIndex = 20;
            this.LBL_DIVEmail.Text = "Email";
            // 
            // LBL_DIVDurchwahl
            // 
            this.LBL_DIVDurchwahl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SachbearbeiterBindingSource, "Durchwahl", true));
            this.LBL_DIVDurchwahl.Location = new System.Drawing.Point(122, 362);
            this.LBL_DIVDurchwahl.Name = "LBL_DIVDurchwahl";
            this.LBL_DIVDurchwahl.Size = new System.Drawing.Size(59, 23);
            this.LBL_DIVDurchwahl.TabIndex = 18;
            this.LBL_DIVDurchwahl.Text = "-DW";
            // 
            // LBL_DIVJobtitle
            // 
            this.LBL_DIVJobtitle.Location = new System.Drawing.Point(122, 336);
            this.LBL_DIVJobtitle.Name = "LBL_DIVJobtitle";
            this.LBL_DIVJobtitle.Size = new System.Drawing.Size(255, 23);
            this.LBL_DIVJobtitle.TabIndex = 16;
            this.LBL_DIVJobtitle.Text = "Position";
            // 
            // CB_DIVSachbearbeiter
            // 
            this.CB_DIVSachbearbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_DIVSachbearbeiter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.SachbearbeiterBindingSource, "Sachbearbeiter", true));
            this.CB_DIVSachbearbeiter.DataSource = this.SachbearbeiterBindingSource;
            this.CB_DIVSachbearbeiter.DisplayMember = "Sachbearbeiter";
            this.CB_DIVSachbearbeiter.FormattingEnabled = true;
            this.CB_DIVSachbearbeiter.Location = new System.Drawing.Point(125, 309);
            this.CB_DIVSachbearbeiter.Name = "CB_DIVSachbearbeiter";
            this.CB_DIVSachbearbeiter.Size = new System.Drawing.Size(254, 21);
            this.CB_DIVSachbearbeiter.TabIndex = 14;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(70, 263);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(41, 13);
            this.Label10.TabIndex = 13;
            this.Label10.Text = "Datum:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(2, 286);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(121, 13);
            this.Label9.TabIndex = 12;
            this.Label9.Text = "Betreff / Thema / Info *:";
            // 
            // TB_DIVThema
            // 
            this.TB_DIVThema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_DIVThema.Location = new System.Drawing.Point(125, 283);
            this.TB_DIVThema.Name = "TB_DIVThema";
            this.TB_DIVThema.Size = new System.Drawing.Size(254, 20);
            this.TB_DIVThema.TabIndex = 11;
            // 
            // DTP_Diverse
            // 
            this.DTP_Diverse.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Diverse.Location = new System.Drawing.Point(125, 257);
            this.DTP_Diverse.Name = "DTP_Diverse";
            this.DTP_Diverse.Size = new System.Drawing.Size(233, 20);
            this.DTP_Diverse.TabIndex = 10;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.LBL_DIVAdresse);
            this.GroupBox2.Location = new System.Drawing.Point(125, 136);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(233, 115);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Adresse";
            // 
            // LBL_DIVAdresse
            // 
            this.LBL_DIVAdresse.AutoSize = true;
            this.LBL_DIVAdresse.Location = new System.Drawing.Point(11, 20);
            this.LBL_DIVAdresse.Name = "LBL_DIVAdresse";
            this.LBL_DIVAdresse.Size = new System.Drawing.Size(45, 13);
            this.LBL_DIVAdresse.TabIndex = 0;
            this.LBL_DIVAdresse.Text = "Adresse";
            // 
            // GB_Anrede
            // 
            this.GB_Anrede.Controls.Add(this._RB_OhneAnrede);
            this.GB_Anrede.Controls.Add(this._RB_MitAnrede);
            this.GB_Anrede.Location = new System.Drawing.Point(19, 136);
            this.GB_Anrede.Name = "GB_Anrede";
            this.GB_Anrede.Size = new System.Drawing.Size(100, 68);
            this.GB_Anrede.TabIndex = 8;
            this.GB_Anrede.TabStop = false;
            this.GB_Anrede.Text = "Anrede";
            // 
            // _RB_OhneAnrede
            // 
            this._RB_OhneAnrede.AutoSize = true;
            this._RB_OhneAnrede.Location = new System.Drawing.Point(6, 41);
            this._RB_OhneAnrede.Name = "_RB_OhneAnrede";
            this._RB_OhneAnrede.Size = new System.Drawing.Size(86, 17);
            this._RB_OhneAnrede.TabIndex = 1;
            this._RB_OhneAnrede.Text = "ohne Anrede";
            this._RB_OhneAnrede.UseVisualStyleBackColor = true;
            this._RB_OhneAnrede.CheckedChanged += new System.EventHandler(this.RB_OhneAnrede_CheckedChanged);
            // 
            // _RB_MitAnrede
            // 
            this._RB_MitAnrede.AutoSize = true;
            this._RB_MitAnrede.Checked = true;
            this._RB_MitAnrede.Location = new System.Drawing.Point(6, 18);
            this._RB_MitAnrede.Name = "_RB_MitAnrede";
            this._RB_MitAnrede.Size = new System.Drawing.Size(75, 17);
            this._RB_MitAnrede.TabIndex = 0;
            this._RB_MitAnrede.TabStop = true;
            this._RB_MitAnrede.Text = "mit Anrede";
            this._RB_MitAnrede.UseVisualStyleBackColor = true;
            this._RB_MitAnrede.CheckedChanged += new System.EventHandler(this.RB_MitAnrede_CheckedChanged);
            // 
            // TB_DIVFaxnummer
            // 
            this.TB_DIVFaxnummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_DIVFaxnummer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Faxnummer", true));
            this.TB_DIVFaxnummer.Location = new System.Drawing.Point(123, 89);
            this.TB_DIVFaxnummer.Name = "TB_DIVFaxnummer";
            this.TB_DIVFaxnummer.Size = new System.Drawing.Size(256, 20);
            this.TB_DIVFaxnummer.TabIndex = 7;
            // 
            // _LBL_Sprache
            // 
            this._LBL_Sprache.AutoSize = true;
            this._LBL_Sprache.Location = new System.Drawing.Point(122, 63);
            this._LBL_Sprache.Name = "_LBL_Sprache";
            this._LBL_Sprache.Size = new System.Drawing.Size(45, 13);
            this._LBL_Sprache.TabIndex = 6;
            this._LBL_Sprache.Text = "deutsch";
            this._LBL_Sprache.TextChanged += new System.EventHandler(this.LBL_Sprache_TextChanged);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(64, 63);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(50, 13);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Sprache:";
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this.Label5);
            this.Panel2.Location = new System.Drawing.Point(0, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(483, 27);
            this.Panel2.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(2, 2);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(186, 24);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Brief / FAX / TN / div.";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(14, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Vorlage auswählen:";
            // 
            // _CB_Vorlagen
            // 
            this._CB_Vorlagen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._CB_Vorlagen.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._CB_Vorlagen.FormattingEnabled = true;
            this._CB_Vorlagen.Location = new System.Drawing.Point(123, 34);
            this._CB_Vorlagen.Name = "_CB_Vorlagen";
            this._CB_Vorlagen.Size = new System.Drawing.Size(256, 23);
            this._CB_Vorlagen.TabIndex = 0;
            this._CB_Vorlagen.SelectedIndexChanged += new System.EventHandler(this.CB_Vorlagen_SelectedIndexChanged);
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.DataGridView1);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage3.Size = new System.Drawing.Size(393, 423);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Historie";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBelegDataGridViewTextBoxColumn,
            this.DatumDataGridViewTextBoxColumn,
            this.KuerzelDataGridViewTextBoxColumn,
            this.KontaktDataGridViewTextBoxColumn,
            this.ThemaDataGridViewTextBoxColumn,
            this.OrtDataGridViewTextBoxColumn,
            this.BelegnameDataGridViewTextBoxColumn});
            this.DataGridView1.DataSource = this.BelegeMitAdresseBindingSource;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(3, 3);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.Size = new System.Drawing.Size(387, 417);
            this.DataGridView1.TabIndex = 0;
            // 
            // IDBelegDataGridViewTextBoxColumn
            // 
            this.IDBelegDataGridViewTextBoxColumn.DataPropertyName = "IDBeleg";
            this.IDBelegDataGridViewTextBoxColumn.HeaderText = "ID";
            this.IDBelegDataGridViewTextBoxColumn.Name = "IDBelegDataGridViewTextBoxColumn";
            this.IDBelegDataGridViewTextBoxColumn.Width = 30;
            // 
            // DatumDataGridViewTextBoxColumn
            // 
            this.DatumDataGridViewTextBoxColumn.DataPropertyName = "Datum";
            this.DatumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.DatumDataGridViewTextBoxColumn.Name = "DatumDataGridViewTextBoxColumn";
            this.DatumDataGridViewTextBoxColumn.Width = 70;
            // 
            // KuerzelDataGridViewTextBoxColumn
            // 
            this.KuerzelDataGridViewTextBoxColumn.DataPropertyName = "Kuerzel";
            this.KuerzelDataGridViewTextBoxColumn.HeaderText = "Bearbeiter";
            this.KuerzelDataGridViewTextBoxColumn.Name = "KuerzelDataGridViewTextBoxColumn";
            // 
            // KontaktDataGridViewTextBoxColumn
            // 
            this.KontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.KontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.KontaktDataGridViewTextBoxColumn.Name = "KontaktDataGridViewTextBoxColumn";
            // 
            // ThemaDataGridViewTextBoxColumn
            // 
            this.ThemaDataGridViewTextBoxColumn.DataPropertyName = "Thema";
            this.ThemaDataGridViewTextBoxColumn.HeaderText = "Thema";
            this.ThemaDataGridViewTextBoxColumn.Name = "ThemaDataGridViewTextBoxColumn";
            // 
            // OrtDataGridViewTextBoxColumn
            // 
            this.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort";
            this.OrtDataGridViewTextBoxColumn.HeaderText = "Ort";
            this.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn";
            // 
            // BelegnameDataGridViewTextBoxColumn
            // 
            this.BelegnameDataGridViewTextBoxColumn.DataPropertyName = "Belegname";
            this.BelegnameDataGridViewTextBoxColumn.HeaderText = "Belegname";
            this.BelegnameDataGridViewTextBoxColumn.Name = "BelegnameDataGridViewTextBoxColumn";
            // 
            // BelegeMitAdresseBindingSource
            // 
            this.BelegeMitAdresseBindingSource.DataMember = "BelegeMitAdresse";
            this.BelegeMitAdresseBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // Panel6
            // 
            this.Panel6.BackColor = System.Drawing.Color.Gray;
            this.TLP_1.SetColumnSpan(this.Panel6, 3);
            this.Panel6.Controls.Add(this._LBL_FirmenName);
            this.Panel6.Controls.Add(this._btnAbbrechen);
            this.Panel6.Controls.Add(this.BTN_Speichern);
            this.Panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel6.Location = new System.Drawing.Point(3, 533);
            this.Panel6.Name = "Panel6";
            this.Panel6.Size = new System.Drawing.Size(764, 45);
            this.Panel6.TabIndex = 20;
            // 
            // _LBL_FirmenName
            // 
            this._LBL_FirmenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "FirmenName", true));
            this._LBL_FirmenName.ForeColor = System.Drawing.Color.White;
            this._LBL_FirmenName.Location = new System.Drawing.Point(9, 6);
            this._LBL_FirmenName.Name = "_LBL_FirmenName";
            this._LBL_FirmenName.Size = new System.Drawing.Size(447, 16);
            this._LBL_FirmenName.TabIndex = 17;
            this._LBL_FirmenName.Text = "FirmenName";
            this._LBL_FirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._LBL_FirmenName.TextChanged += new System.EventHandler(this.LBL_FirmenName_TextChanged);
            // 
            // _btnAbbrechen
            // 
            this._btnAbbrechen.Image = global::Adress_DB.My.Resources.Resources.Cancel_16x;
            this._btnAbbrechen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnAbbrechen.Location = new System.Drawing.Point(480, 10);
            this._btnAbbrechen.Name = "_btnAbbrechen";
            this._btnAbbrechen.Size = new System.Drawing.Size(80, 23);
            this._btnAbbrechen.TabIndex = 16;
            this._btnAbbrechen.Text = "Abbrechen";
            this._btnAbbrechen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnAbbrechen.UseVisualStyleBackColor = true;
            this._btnAbbrechen.Click += new System.EventHandler(this.btnAbbrechen_Click);
            // 
            // TC_Adresse
            // 
            this.TC_Adresse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Adresse.Controls.Add(this.TabAdresseInfo);
            this.TC_Adresse.Controls.Add(this.TabAdresseBearbeiten);
            this.TC_Adresse.Location = new System.Drawing.Point(173, 78);
            this.TC_Adresse.Name = "TC_Adresse";
            this.TLP_1.SetRowSpan(this.TC_Adresse, 2);
            this.TC_Adresse.SelectedIndex = 0;
            this.TC_Adresse.Size = new System.Drawing.Size(294, 449);
            this.TC_Adresse.TabIndex = 21;
            // 
            // TabAdresseInfo
            // 
            this.TabAdresseInfo.AutoScroll = true;
            this.TabAdresseInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TabAdresseInfo.Controls.Add(this.LBL_CC);
            this.TabAdresseInfo.Controls.Add(this.LabelLandAdressen);
            this.TabAdresseInfo.Controls.Add(this.PNL_Geodaten);
            this.TabAdresseInfo.Controls.Add(this.LBL_AdressHinweis);
            this.TabAdresseInfo.Controls.Add(IDKontoLabel);
            this.TabAdresseInfo.Controls.Add(this._LBL_IDKontoZuAdresse);
            this.TabAdresseInfo.Controls.Add(WebseiteLabel1);
            this.TabAdresseInfo.Controls.Add(this.AdressenDataGridView);
            this.TabAdresseInfo.Controls.Add(this._WebseiteLinkLabel);
            this.TabAdresseInfo.Controls.Add(UStIdNrLabel1);
            this.TabAdresseInfo.Controls.Add(this._BTN_MapsSuche);
            this.TabAdresseInfo.Controls.Add(this.UStIdNrLabel2);
            this.TabAdresseInfo.Controls.Add(this.LBL_Land);
            this.TabAdresseInfo.Controls.Add(BundeslandLabel1);
            this.TabAdresseInfo.Controls.Add(this.BundeslandLabel2);
            this.TabAdresseInfo.Controls.Add(OrtLabel1);
            this.TabAdresseInfo.Controls.Add(this.LBL_Ort);
            this.TabAdresseInfo.Controls.Add(PLZLabel1);
            this.TabAdresseInfo.Controls.Add(this.LBL_PLZ);
            this.TabAdresseInfo.Controls.Add(PostfachLabel1);
            this.TabAdresseInfo.Controls.Add(this.PostfachLabel2);
            this.TabAdresseInfo.Controls.Add(StraßeLabel1);
            this.TabAdresseInfo.Controls.Add(this.LBL_Strasse);
            this.TabAdresseInfo.Controls.Add(AdresstypLabel1);
            this.TabAdresseInfo.Controls.Add(this.AdresstypLabel2);
            this.TabAdresseInfo.Controls.Add(this.Panel7);
            this.TabAdresseInfo.Location = new System.Drawing.Point(4, 22);
            this.TabAdresseInfo.Name = "TabAdresseInfo";
            this.TabAdresseInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdresseInfo.Size = new System.Drawing.Size(286, 423);
            this.TabAdresseInfo.TabIndex = 0;
            this.TabAdresseInfo.Text = "Info";
            // 
            // LBL_CC
            // 
            this.LBL_CC.AutoSize = true;
            this.LBL_CC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaatenBindingSource, "ISO2", true));
            this.LBL_CC.Location = new System.Drawing.Point(251, 62);
            this.LBL_CC.Name = "LBL_CC";
            this.LBL_CC.Size = new System.Drawing.Size(22, 13);
            this.LBL_CC.TabIndex = 29;
            this.LBL_CC.Text = "DE";
            this.LBL_CC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StaatenBindingSource
            // 
            this.StaatenBindingSource.DataMember = "Staaten";
            this.StaatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // LabelLandAdressen
            // 
            this.LabelLandAdressen.AutoSize = true;
            this.LabelLandAdressen.Location = new System.Drawing.Point(43, 62);
            this.LabelLandAdressen.Name = "LabelLandAdressen";
            this.LabelLandAdressen.Size = new System.Drawing.Size(34, 13);
            this.LabelLandAdressen.TabIndex = 28;
            this.LabelLandAdressen.Text = "Land:";
            // 
            // PNL_Geodaten
            // 
            this.PNL_Geodaten.Controls.Add(this.LBL_Lat);
            this.PNL_Geodaten.Controls.Add(this.LBL_Long);
            this.PNL_Geodaten.Controls.Add(this.LBLLat);
            this.PNL_Geodaten.Controls.Add(this.LBLLong);
            this.PNL_Geodaten.Location = new System.Drawing.Point(6, 278);
            this.PNL_Geodaten.Name = "PNL_Geodaten";
            this.PNL_Geodaten.Size = new System.Drawing.Size(147, 38);
            this.PNL_Geodaten.TabIndex = 27;
            // 
            // LBL_Lat
            // 
            this.LBL_Lat.AutoSize = true;
            this.LBL_Lat.ForeColor = System.Drawing.Color.Gray;
            this.LBL_Lat.Location = new System.Drawing.Point(56, 3);
            this.LBL_Lat.Name = "LBL_Lat";
            this.LBL_Lat.Size = new System.Drawing.Size(47, 13);
            this.LBL_Lat.TabIndex = 25;
            this.LBL_Lat.Text = "LBL_Lat";
            // 
            // LBL_Long
            // 
            this.LBL_Long.AutoSize = true;
            this.LBL_Long.ForeColor = System.Drawing.Color.Gray;
            this.LBL_Long.Location = new System.Drawing.Point(56, 16);
            this.LBL_Long.Name = "LBL_Long";
            this.LBL_Long.Size = new System.Drawing.Size(56, 13);
            this.LBL_Long.TabIndex = 26;
            this.LBL_Long.Text = "LBL_Long";
            // 
            // LBLLat
            // 
            this.LBLLat.AutoSize = true;
            this.LBLLat.ForeColor = System.Drawing.Color.Gray;
            this.LBLLat.Location = new System.Drawing.Point(6, 3);
            this.LBLLat.Name = "LBLLat";
            this.LBLLat.Size = new System.Drawing.Size(48, 13);
            this.LBLLat.TabIndex = 23;
            this.LBLLat.Text = "Latitude:";
            // 
            // LBLLong
            // 
            this.LBLLong.AutoSize = true;
            this.LBLLong.ForeColor = System.Drawing.Color.Gray;
            this.LBLLong.Location = new System.Drawing.Point(3, 16);
            this.LBLLong.Name = "LBLLong";
            this.LBLLong.Size = new System.Drawing.Size(51, 13);
            this.LBLLong.TabIndex = 24;
            this.LBLLong.Text = "Logitude:";
            // 
            // LBL_AdressHinweis
            // 
            this.LBL_AdressHinweis.AutoSize = true;
            this.LBL_AdressHinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_AdressHinweis.ForeColor = System.Drawing.Color.Red;
            this.LBL_AdressHinweis.Location = new System.Drawing.Point(73, 237);
            this.LBL_AdressHinweis.Name = "LBL_AdressHinweis";
            this.LBL_AdressHinweis.Size = new System.Drawing.Size(123, 26);
            this.LBL_AdressHinweis.TabIndex = 22;
            this.LBL_AdressHinweis.Text = "Adresse prüfen!\r\nPLZ oder Ort unklar.";
            this.LBL_AdressHinweis.Visible = false;
            // 
            // _LBL_IDKontoZuAdresse
            // 
            this._LBL_IDKontoZuAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "IDKonto", true));
            this._LBL_IDKontoZuAdresse.Location = new System.Drawing.Point(83, 215);
            this._LBL_IDKontoZuAdresse.Name = "_LBL_IDKontoZuAdresse";
            this._LBL_IDKontoZuAdresse.Size = new System.Drawing.Size(190, 15);
            this._LBL_IDKontoZuAdresse.TabIndex = 21;
            this._LBL_IDKontoZuAdresse.Text = "800000";
            this._LBL_IDKontoZuAdresse.TextChanged += new System.EventHandler(this.LBL_IDKontoZuAdresse_TextChanged);
            // 
            // _WebseiteLinkLabel
            // 
            this._WebseiteLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Webseite", true));
            this._WebseiteLinkLabel.Location = new System.Drawing.Point(83, 191);
            this._WebseiteLinkLabel.Name = "_WebseiteLinkLabel";
            this._WebseiteLinkLabel.Size = new System.Drawing.Size(190, 15);
            this._WebseiteLinkLabel.TabIndex = 18;
            this._WebseiteLinkLabel.TabStop = true;
            this._WebseiteLinkLabel.Text = "www.weserland.de";
            this._WebseiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebseiteLinkLabel_LinkClicked);
            // 
            // UStIdNrLabel2
            // 
            this.UStIdNrLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "UStIdNr", true));
            this.UStIdNrLabel2.Location = new System.Drawing.Point(83, 171);
            this.UStIdNrLabel2.Name = "UStIdNrLabel2";
            this.UStIdNrLabel2.Size = new System.Drawing.Size(190, 15);
            this.UStIdNrLabel2.TabIndex = 16;
            this.UStIdNrLabel2.Text = "12-12345-698";
            // 
            // LBL_Land
            // 
            this.LBL_Land.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Land", true));
            this.LBL_Land.Location = new System.Drawing.Point(83, 62);
            this.LBL_Land.Name = "LBL_Land";
            this.LBL_Land.Size = new System.Drawing.Size(190, 15);
            this.LBL_Land.TabIndex = 14;
            this.LBL_Land.Text = "Deutschland";
            // 
            // BundeslandLabel2
            // 
            this.BundeslandLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Bundesland", true));
            this.BundeslandLabel2.Location = new System.Drawing.Point(83, 136);
            this.BundeslandLabel2.Name = "BundeslandLabel2";
            this.BundeslandLabel2.Size = new System.Drawing.Size(190, 15);
            this.BundeslandLabel2.TabIndex = 12;
            this.BundeslandLabel2.Text = "Niedersachsen";
            // 
            // LBL_Ort
            // 
            this.LBL_Ort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Ort", true));
            this.LBL_Ort.Location = new System.Drawing.Point(83, 121);
            this.LBL_Ort.Name = "LBL_Ort";
            this.LBL_Ort.Size = new System.Drawing.Size(190, 15);
            this.LBL_Ort.TabIndex = 10;
            this.LBL_Ort.Text = "Hannover";
            // 
            // LBL_PLZ
            // 
            this.LBL_PLZ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "PLZ", true));
            this.LBL_PLZ.Location = new System.Drawing.Point(83, 106);
            this.LBL_PLZ.Name = "LBL_PLZ";
            this.LBL_PLZ.Size = new System.Drawing.Size(190, 15);
            this.LBL_PLZ.TabIndex = 8;
            this.LBL_PLZ.Text = "30419";
            // 
            // PostfachLabel2
            // 
            this.PostfachLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Postfach", true));
            this.PostfachLabel2.Location = new System.Drawing.Point(83, 91);
            this.PostfachLabel2.Name = "PostfachLabel2";
            this.PostfachLabel2.Size = new System.Drawing.Size(190, 15);
            this.PostfachLabel2.TabIndex = 6;
            this.PostfachLabel2.Text = "12345";
            // 
            // LBL_Strasse
            // 
            this.LBL_Strasse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Straße", true));
            this.LBL_Strasse.Location = new System.Drawing.Point(83, 76);
            this.LBL_Strasse.Name = "LBL_Strasse";
            this.LBL_Strasse.Size = new System.Drawing.Size(190, 15);
            this.LBL_Strasse.TabIndex = 4;
            this.LBL_Strasse.Text = "Strasse 10";
            // 
            // AdresstypLabel2
            // 
            this.AdresstypLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Adresstyp", true));
            this.AdresstypLabel2.Location = new System.Drawing.Point(83, 40);
            this.AdresstypLabel2.Name = "AdresstypLabel2";
            this.AdresstypLabel2.Size = new System.Drawing.Size(190, 15);
            this.AdresstypLabel2.TabIndex = 2;
            this.AdresstypLabel2.Text = "Rechnungsadresse";
            // 
            // Panel7
            // 
            this.Panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel7.BackColor = System.Drawing.Color.Silver;
            this.Panel7.Controls.Add(this.Label4);
            this.Panel7.Controls.Add(this._LBL_IDAdresse);
            this.Panel7.Location = new System.Drawing.Point(0, 0);
            this.Panel7.Name = "Panel7";
            this.Panel7.Size = new System.Drawing.Size(302, 27);
            this.Panel7.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(2, 2);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 24);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Adresse";
            // 
            // TabAdresseBearbeiten
            // 
            this.TabAdresseBearbeiten.AutoScroll = true;
            this.TabAdresseBearbeiten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TabAdresseBearbeiten.Controls.Add(this.LBL_PLZungueltig);
            this.TabAdresseBearbeiten.Controls.Add(this.CB_Ort);
            this.TabAdresseBearbeiten.Controls.Add(this.LBL_Countrycode);
            this.TabAdresseBearbeiten.Controls.Add(this.CB_Staat);
            this.TabAdresseBearbeiten.Controls.Add(this.lblAdresseNeu);
            this.TabAdresseBearbeiten.Controls.Add(this._btnNeueAdresse);
            this.TabAdresseBearbeiten.Controls.Add(this._btnKontoZuAdresse);
            this.TabAdresseBearbeiten.Controls.Add(this.IDKontoTextBox);
            this.TabAdresseBearbeiten.Controls.Add(this.AdresstypTextBox);
            this.TabAdresseBearbeiten.Controls.Add(WebseiteLabel);
            this.TabAdresseBearbeiten.Controls.Add(AdresstypLabel);
            this.TabAdresseBearbeiten.Controls.Add(this.WebseiteTextBox);
            this.TabAdresseBearbeiten.Controls.Add(this.StraßeTextBox);
            this.TabAdresseBearbeiten.Controls.Add(UStIdNrLabel);
            this.TabAdresseBearbeiten.Controls.Add(StraßeLabel);
            this.TabAdresseBearbeiten.Controls.Add(this.UStIdNrTextBox);
            this.TabAdresseBearbeiten.Controls.Add(this._TB_PLZ);
            this.TabAdresseBearbeiten.Controls.Add(LandLabel);
            this.TabAdresseBearbeiten.Controls.Add(PLZLabel);
            this.TabAdresseBearbeiten.Controls.Add(this.PostfachTextBox);
            this.TabAdresseBearbeiten.Controls.Add(BundeslandLabel);
            this.TabAdresseBearbeiten.Controls.Add(PostfachLabel);
            this.TabAdresseBearbeiten.Controls.Add(this.TB_Bundesland);
            this.TabAdresseBearbeiten.Controls.Add(OrtLabel);
            this.TabAdresseBearbeiten.Location = new System.Drawing.Point(4, 22);
            this.TabAdresseBearbeiten.Name = "TabAdresseBearbeiten";
            this.TabAdresseBearbeiten.Padding = new System.Windows.Forms.Padding(3);
            this.TabAdresseBearbeiten.Size = new System.Drawing.Size(286, 423);
            this.TabAdresseBearbeiten.TabIndex = 1;
            this.TabAdresseBearbeiten.Text = "Bearbeiten / NEU";
            // 
            // LBL_PLZungueltig
            // 
            this.LBL_PLZungueltig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_PLZungueltig.AutoSize = true;
            this.LBL_PLZungueltig.ForeColor = System.Drawing.Color.Red;
            this.LBL_PLZungueltig.Location = new System.Drawing.Point(203, 141);
            this.LBL_PLZungueltig.Name = "LBL_PLZungueltig";
            this.LBL_PLZungueltig.Size = new System.Drawing.Size(70, 13);
            this.LBL_PLZungueltig.TabIndex = 27;
            this.LBL_PLZungueltig.Text = "PLZ ungültig!";
            this.LBL_PLZungueltig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_PLZungueltig.Visible = false;
            // 
            // CB_Ort
            // 
            this.CB_Ort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Ort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Ort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Ort.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdressenBindingSource, "Ort", true));
            this.CB_Ort.DataSource = this.AdressenBindingSource;
            this.CB_Ort.DisplayMember = "Ort";
            this.CB_Ort.FormattingEnabled = true;
            this.CB_Ort.Location = new System.Drawing.Point(74, 164);
            this.CB_Ort.Name = "CB_Ort";
            this.CB_Ort.Size = new System.Drawing.Size(207, 21);
            this.CB_Ort.TabIndex = 6;
            // 
            // LBL_Countrycode
            // 
            this.LBL_Countrycode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LBL_Countrycode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaatenBindingSource, "ISO2", true));
            this.LBL_Countrycode.Location = new System.Drawing.Point(259, 57);
            this.LBL_Countrycode.Name = "LBL_Countrycode";
            this.LBL_Countrycode.Size = new System.Drawing.Size(22, 23);
            this.LBL_Countrycode.TabIndex = 25;
            this.LBL_Countrycode.Text = "DE";
            this.LBL_Countrycode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CB_Staat
            // 
            this.CB_Staat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_Staat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Staat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Staat.DataSource = this.StaatenBindingSource;
            this.CB_Staat.DisplayMember = "Staat";
            this.CB_Staat.FormattingEnabled = true;
            this.CB_Staat.Location = new System.Drawing.Point(74, 59);
            this.CB_Staat.Name = "CB_Staat";
            this.CB_Staat.Size = new System.Drawing.Size(179, 21);
            this.CB_Staat.TabIndex = 2;
            // 
            // lblAdresseNeu
            // 
            this.lblAdresseNeu.AutoSize = true;
            this.lblAdresseNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresseNeu.ForeColor = System.Drawing.Color.Red;
            this.lblAdresseNeu.Location = new System.Drawing.Point(71, 10);
            this.lblAdresseNeu.Name = "lblAdresseNeu";
            this.lblAdresseNeu.Size = new System.Drawing.Size(33, 13);
            this.lblAdresseNeu.TabIndex = 3;
            this.lblAdresseNeu.Text = "NEU";
            this.lblAdresseNeu.Visible = false;
            // 
            // TC_Kontakt
            // 
            this.TC_Kontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TC_Kontakt.Controls.Add(this.TabPage5);
            this.TC_Kontakt.Controls.Add(this.TabPage6);
            this.TC_Kontakt.Location = new System.Drawing.Point(473, 78);
            this.TC_Kontakt.Name = "TC_Kontakt";
            this.TLP_1.SetRowSpan(this.TC_Kontakt, 2);
            this.TC_Kontakt.SelectedIndex = 0;
            this.TC_Kontakt.Size = new System.Drawing.Size(294, 449);
            this.TC_Kontakt.TabIndex = 22;
            // 
            // TabPage5
            // 
            this.TabPage5.AutoScroll = true;
            this.TabPage5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TabPage5.Controls.Add(this.OrtLabel2);
            this.TabPage5.Controls.Add(this.OrtLabel3);
            this.TabPage5.Controls.Add(this.StraßeLabel2);
            this.TabPage5.Controls.Add(this.StraßeLabel3);
            this.TabPage5.Controls.Add(IDAdresseLabel);
            this.TabPage5.Controls.Add(this._BTN_ZuOutlook);
            this.TabPage5.Controls.Add(this._LBL_IDAdresseZuKontakt);
            this.TabPage5.Controls.Add(this.KontakteDataGridView);
            this.TabPage5.Controls.Add(FaxnummerLabel1);
            this.TabPage5.Controls.Add(this.FaxnummerLabel2);
            this.TabPage5.Controls.Add(MobiltelefonLabel1);
            this.TabPage5.Controls.Add(this._MobiltelefonLinkLabel);
            this.TabPage5.Controls.Add(TelefonPrivatLabel1);
            this.TabPage5.Controls.Add(this._TelefonPrivatLinkLabel);
            this.TabPage5.Controls.Add(TelefonGeschaeftlichLabel1);
            this.TabPage5.Controls.Add(this._TelefonGeschaeftlichLinkLabel);
            this.TabPage5.Controls.Add(PositionLabel1);
            this.TabPage5.Controls.Add(this.PositionLabel2);
            this.TabPage5.Controls.Add(EmailAddresseLabel1);
            this.TabPage5.Controls.Add(NachnameLabel1);
            this.TabPage5.Controls.Add(this.LBL_Nachname);
            this.TabPage5.Controls.Add(VornameLabel1);
            this.TabPage5.Controls.Add(this.LBL_Vorname);
            this.TabPage5.Controls.Add(AnredeLabel1);
            this.TabPage5.Controls.Add(this._LBL_Anrede);
            this.TabPage5.Controls.Add(this._EmailAddresseLinkLabel);
            this.TabPage5.Controls.Add(this.Panel3);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage5.Size = new System.Drawing.Size(286, 423);
            this.TabPage5.TabIndex = 0;
            this.TabPage5.Text = "Info";
            // 
            // OrtLabel3
            // 
            this.OrtLabel3.Location = new System.Drawing.Point(100, 257);
            this.OrtLabel3.Name = "OrtLabel3";
            this.OrtLabel3.Size = new System.Drawing.Size(176, 15);
            this.OrtLabel3.TabIndex = 37;
            this.OrtLabel3.Text = "---";
            // 
            // StraßeLabel3
            // 
            this.StraßeLabel3.Location = new System.Drawing.Point(100, 242);
            this.StraßeLabel3.Name = "StraßeLabel3";
            this.StraßeLabel3.Size = new System.Drawing.Size(174, 15);
            this.StraßeLabel3.TabIndex = 36;
            this.StraßeLabel3.Text = "---";
            // 
            // _LBL_IDAdresseZuKontakt
            // 
            this._LBL_IDAdresseZuKontakt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "IDAdresse", true));
            this._LBL_IDAdresseZuKontakt.Location = new System.Drawing.Point(100, 227);
            this._LBL_IDAdresseZuKontakt.Name = "_LBL_IDAdresseZuKontakt";
            this._LBL_IDAdresseZuKontakt.Size = new System.Drawing.Size(176, 15);
            this._LBL_IDAdresseZuKontakt.TabIndex = 35;
            this._LBL_IDAdresseZuKontakt.Text = "IDAdresse";
            this._LBL_IDAdresseZuKontakt.TextChanged += new System.EventHandler(this.LBL_IDAdresseZuKontakt_TextChanged);
            // 
            // FaxnummerLabel2
            // 
            this.FaxnummerLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Faxnummer", true));
            this.FaxnummerLabel2.Location = new System.Drawing.Point(100, 205);
            this.FaxnummerLabel2.Name = "FaxnummerLabel2";
            this.FaxnummerLabel2.Size = new System.Drawing.Size(176, 15);
            this.FaxnummerLabel2.TabIndex = 34;
            this.FaxnummerLabel2.Text = "123456789";
            // 
            // _MobiltelefonLinkLabel
            // 
            this._MobiltelefonLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Mobiltelefon", true));
            this._MobiltelefonLinkLabel.Location = new System.Drawing.Point(100, 181);
            this._MobiltelefonLinkLabel.Name = "_MobiltelefonLinkLabel";
            this._MobiltelefonLinkLabel.Size = new System.Drawing.Size(176, 15);
            this._MobiltelefonLinkLabel.TabIndex = 33;
            this._MobiltelefonLinkLabel.TabStop = true;
            this._MobiltelefonLinkLabel.Text = "LinkLabel1";
            this._MobiltelefonLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MobiltelefonLinkLabel_LinkClicked);
            // 
            // _TelefonPrivatLinkLabel
            // 
            this._TelefonPrivatLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonPrivat", true));
            this._TelefonPrivatLinkLabel.Location = new System.Drawing.Point(100, 155);
            this._TelefonPrivatLinkLabel.Name = "_TelefonPrivatLinkLabel";
            this._TelefonPrivatLinkLabel.Size = new System.Drawing.Size(176, 15);
            this._TelefonPrivatLinkLabel.TabIndex = 32;
            this._TelefonPrivatLinkLabel.TabStop = true;
            this._TelefonPrivatLinkLabel.Text = "LinkLabel1";
            this._TelefonPrivatLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelefonPrivatLinkLabel_LinkClicked);
            // 
            // _TelefonGeschaeftlichLinkLabel
            // 
            this._TelefonGeschaeftlichLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "TelefonGeschaeftlich", true));
            this._TelefonGeschaeftlichLinkLabel.Location = new System.Drawing.Point(100, 130);
            this._TelefonGeschaeftlichLinkLabel.Name = "_TelefonGeschaeftlichLinkLabel";
            this._TelefonGeschaeftlichLinkLabel.Size = new System.Drawing.Size(176, 15);
            this._TelefonGeschaeftlichLinkLabel.TabIndex = 31;
            this._TelefonGeschaeftlichLinkLabel.TabStop = true;
            this._TelefonGeschaeftlichLinkLabel.Text = "LinkLabel1";
            this._TelefonGeschaeftlichLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TelefonGeschaeftlichLinkLabel_LinkClicked);
            // 
            // PositionLabel2
            // 
            this.PositionLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Jobtitle", true));
            this.PositionLabel2.Location = new System.Drawing.Point(100, 85);
            this.PositionLabel2.Name = "PositionLabel2";
            this.PositionLabel2.Size = new System.Drawing.Size(176, 15);
            this.PositionLabel2.TabIndex = 30;
            this.PositionLabel2.Text = "Macher";
            // 
            // LBL_Nachname
            // 
            this.LBL_Nachname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Nachname", true));
            this.LBL_Nachname.Location = new System.Drawing.Point(100, 55);
            this.LBL_Nachname.Name = "LBL_Nachname";
            this.LBL_Nachname.Size = new System.Drawing.Size(176, 15);
            this.LBL_Nachname.TabIndex = 29;
            this.LBL_Nachname.Text = "Müller";
            // 
            // LBL_Vorname
            // 
            this.LBL_Vorname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Vorname", true));
            this.LBL_Vorname.Location = new System.Drawing.Point(100, 70);
            this.LBL_Vorname.Name = "LBL_Vorname";
            this.LBL_Vorname.Size = new System.Drawing.Size(176, 15);
            this.LBL_Vorname.TabIndex = 28;
            this.LBL_Vorname.Text = "Klaus Wilhelm";
            // 
            // _LBL_Anrede
            // 
            this._LBL_Anrede.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.KontakteBindingSource, "Anrede", true));
            this._LBL_Anrede.Location = new System.Drawing.Point(100, 40);
            this._LBL_Anrede.Name = "_LBL_Anrede";
            this._LBL_Anrede.Size = new System.Drawing.Size(176, 15);
            this._LBL_Anrede.TabIndex = 27;
            this._LBL_Anrede.Text = "Herr";
            this._LBL_Anrede.TextChanged += new System.EventHandler(this.LBL_Anrede_TextChanged);
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TabPage6.Controls.Add(this._BTN_DeleteUser);
            this.TabPage6.Controls.Add(this.lblKontaktNeu);
            this.TabPage6.Controls.Add(this._btnAdresseZuKontakt);
            this.TabPage6.Controls.Add(this._btnNeuerKontakt);
            this.TabPage6.Controls.Add(this.IDAdresseTextBox);
            this.TabPage6.Controls.Add(FaxnummerLabel);
            this.TabPage6.Controls.Add(this.FaxnummerTextBox);
            this.TabPage6.Controls.Add(this.AnredeComboBox);
            this.TabPage6.Controls.Add(MobiltelefonLabel);
            this.TabPage6.Controls.Add(AnredeLabel);
            this.TabPage6.Controls.Add(this.MobiltelefonTextBox);
            this.TabPage6.Controls.Add(this.NachnameTextBox);
            this.TabPage6.Controls.Add(TelefonPrivatLabel);
            this.TabPage6.Controls.Add(NachnameLabel);
            this.TabPage6.Controls.Add(this.TelefonPrivatTextBox);
            this.TabPage6.Controls.Add(this.VornameTextBox);
            this.TabPage6.Controls.Add(TelefonGeschaeftlichLabel);
            this.TabPage6.Controls.Add(VornameLabel);
            this.TabPage6.Controls.Add(this.TelefonGeschaeftlichTextBox);
            this.TabPage6.Controls.Add(this.EmailAddresseTextBox);
            this.TabPage6.Controls.Add(PositionLabel);
            this.TabPage6.Controls.Add(EmailAddresseLabel);
            this.TabPage6.Controls.Add(this.PositionTextBox);
            this.TabPage6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPage6.Location = new System.Drawing.Point(4, 22);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage6.Size = new System.Drawing.Size(286, 423);
            this.TabPage6.TabIndex = 1;
            this.TabPage6.Text = "Bearbeiten / NEU";
            // 
            // _BTN_DeleteUser
            // 
            this._BTN_DeleteUser.BackColor = System.Drawing.Color.Red;
            this._BTN_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BTN_DeleteUser.ForeColor = System.Drawing.Color.White;
            this._BTN_DeleteUser.Image = global::Adress_DB.My.Resources.Resources.DeleteUser_16x;
            this._BTN_DeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_DeleteUser.Location = new System.Drawing.Point(6, 315);
            this._BTN_DeleteUser.Name = "_BTN_DeleteUser";
            this._BTN_DeleteUser.Size = new System.Drawing.Size(75, 23);
            this._BTN_DeleteUser.TabIndex = 27;
            this._BTN_DeleteUser.Text = "löschen";
            this._BTN_DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_DeleteUser.UseVisualStyleBackColor = false;
            this._BTN_DeleteUser.Click += new System.EventHandler(this.BTN_DeleteUser_Click);
            // 
            // lblKontaktNeu
            // 
            this.lblKontaktNeu.AutoSize = true;
            this.lblKontaktNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontaktNeu.ForeColor = System.Drawing.Color.Red;
            this.lblKontaktNeu.Location = new System.Drawing.Point(101, 10);
            this.lblKontaktNeu.Name = "lblKontaktNeu";
            this.lblKontaktNeu.Size = new System.Drawing.Size(33, 13);
            this.lblKontaktNeu.TabIndex = 26;
            this.lblKontaktNeu.Text = "NEU";
            this.lblKontaktNeu.Visible = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateiToolStripMenuItem,
            this.ToolStripMenuItem1,
            this.InfoToolStripMenuItem});
            this.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1177, 24);
            this.MenuStrip1.TabIndex = 23;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // DateiToolStripMenuItem
            // 
            this.DateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._DocuWareDateiManuellToolStripMenuItem,
            this._SchließenToolStripMenuItem});
            this.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem";
            this.DateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.DateiToolStripMenuItem.Text = "Datei";
            // 
            // _DocuWareDateiManuellToolStripMenuItem
            // 
            this._DocuWareDateiManuellToolStripMenuItem.Image = global::Adress_DB.My.Resources.Resources.DocuWare_Logo;
            this._DocuWareDateiManuellToolStripMenuItem.Name = "_DocuWareDateiManuellToolStripMenuItem";
            this._DocuWareDateiManuellToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this._DocuWareDateiManuellToolStripMenuItem.Text = "DocuWare-Datei manuell";
            this._DocuWareDateiManuellToolStripMenuItem.Click += new System.EventHandler(this.DocuWareDateiManuellToolStripMenuItem_Click);
            // 
            // _SchließenToolStripMenuItem
            // 
            this._SchließenToolStripMenuItem.Image = global::Adress_DB.My.Resources.Resources.CloseSolution_16x;
            this._SchließenToolStripMenuItem.Name = "_SchließenToolStripMenuItem";
            this._SchließenToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this._SchließenToolStripMenuItem.Text = "Schließen";
            this._SchließenToolStripMenuItem.Click += new System.EventHandler(this.SchließenToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._BenutzerlisteToolStripMenuItem,
            this.MI_Administration});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.ToolStripMenuItem1.Text = "Einstellungen";
            // 
            // _BenutzerlisteToolStripMenuItem
            // 
            this._BenutzerlisteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_BenutzerlisteToolStripMenuItem.Image")));
            this._BenutzerlisteToolStripMenuItem.Name = "_BenutzerlisteToolStripMenuItem";
            this._BenutzerlisteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this._BenutzerlisteToolStripMenuItem.Text = "Benutzerliste";
            this._BenutzerlisteToolStripMenuItem.Click += new System.EventHandler(this.BenutzerlisteToolStripMenuItem_Click);
            // 
            // MI_Administration
            // 
            this.MI_Administration.Image = ((System.Drawing.Image)(resources.GetObject("MI_Administration.Image")));
            this.MI_Administration.Name = "MI_Administration";
            this.MI_Administration.Size = new System.Drawing.Size(145, 22);
            this.MI_Administration.Text = "Einstellungen";
            this.MI_Administration.Click += new System.EventHandler(this.EinstellungenToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AktivitätslogToolStripMenuItem,
            this._InfoÜberAdressenDBToolStripMenuItem1,
            this._HilfeToolStripMenuItem});
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.InfoToolStripMenuItem.Text = "Info";
            // 
            // _AktivitätslogToolStripMenuItem
            // 
            this._AktivitätslogToolStripMenuItem.Image = global::Adress_DB.My.Resources.Resources.EnableLog_16x;
            this._AktivitätslogToolStripMenuItem.Name = "_AktivitätslogToolStripMenuItem";
            this._AktivitätslogToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this._AktivitätslogToolStripMenuItem.Text = "Aktivitätslog";
            this._AktivitätslogToolStripMenuItem.Click += new System.EventHandler(this.AktivitätslogToolStripMenuItem_Click);
            // 
            // _InfoÜberAdressenDBToolStripMenuItem1
            // 
            this._InfoÜberAdressenDBToolStripMenuItem1.Image = global::Adress_DB.My.Resources.Resources.StatusInformation_16x;
            this._InfoÜberAdressenDBToolStripMenuItem1.Name = "_InfoÜberAdressenDBToolStripMenuItem1";
            this._InfoÜberAdressenDBToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this._InfoÜberAdressenDBToolStripMenuItem1.Text = "Info über Adressen-DB";
            this._InfoÜberAdressenDBToolStripMenuItem1.Click += new System.EventHandler(this.InfoÜberAdressenDBToolStripMenuItem1_Click);
            // 
            // _HilfeToolStripMenuItem
            // 
            this._HilfeToolStripMenuItem.Image = global::Adress_DB.My.Resources.Resources.F1Help_16x;
            this._HilfeToolStripMenuItem.Name = "_HilfeToolStripMenuItem";
            this._HilfeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this._HilfeToolStripMenuItem.Text = "Hilfe";
            this._HilfeToolStripMenuItem.Click += new System.EventHandler(this.HilfeToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(785, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(392, 25);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "Sachbearbeiter";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.Silver;
            this.Panel8.Controls.Add(this.BTN_DocErzeugen);
            this.Panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel8.Location = new System.Drawing.Point(773, 533);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(401, 45);
            this.Panel8.TabIndex = 24;
            // 
            // BTN_DocErzeugen
            // 
            this.BTN_DocErzeugen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_DocErzeugen.Image = global::Adress_DB.My.Resources.Resources.Document_16x;
            this.BTN_DocErzeugen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_DocErzeugen.Location = new System.Drawing.Point(264, 10);
            this.BTN_DocErzeugen.Name = "BTN_DocErzeugen";
            this.BTN_DocErzeugen.Size = new System.Drawing.Size(124, 24);
            this.BTN_DocErzeugen.TabIndex = 18;
            this.BTN_DocErzeugen.Text = "Document erzeugen";
            this.BTN_DocErzeugen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_DocErzeugen.UseVisualStyleBackColor = true;
            this.BTN_DocErzeugen.Click += new System.EventHandler(this.BTN_DocErzeugen_Click);
            // 
            // KontakteMitAdresseBindingSource
            // 
            this.KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse";
            this.KontakteMitAdresseBindingSource.DataSource = this._WSL_AdressenDataSet;
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
            // TableAdapterManager
            // 
            this.TableAdapterManager.AdressenTableAdapter = null;
            this.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.BelegeTableAdapter = null;
            this.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.FirmenNameTableAdapter = this.FirmenNameTableAdapter;
            this.TableAdapterManager.KlassenTableAdapter = null;
            this.TableAdapterManager.KlassifizierungTableAdapter = null;
            this.TableAdapterManager.KontakteTableAdapter = null;
            this.TableAdapterManager.KontoTableAdapter = null;
            this.TableAdapterManager.LogTabelleTableAdapter = null;
            this.TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.propertiesTableAdapter = null;
            this.TableAdapterManager.SachbearbeiterTableAdapter = null;
            this.TableAdapterManager.StaatenTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.UpdateInsertDelete;
            // 
            // KontakteTableAdapter
            // 
            this.KontakteTableAdapter.ClearBeforeFill = true;
            // 
            // SachbearbeiterTableAdapter
            // 
            this.SachbearbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // KontakteMitAdresseTableAdapter
            // 
            this.KontakteMitAdresseTableAdapter.ClearBeforeFill = true;
            // 
            // DocuwareCSVTableAdapter
            // 
            this.DocuwareCSVTableAdapter.ClearBeforeFill = true;
            // 
            // BelegeBindingSource
            // 
            this.BelegeBindingSource.DataMember = "Belege";
            this.BelegeBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // BelegeTableAdapter
            // 
            this.BelegeTableAdapter.ClearBeforeFill = true;
            // 
            // BelegeMitAdresseTableAdapter
            // 
            this.BelegeMitAdresseTableAdapter.ClearBeforeFill = true;
            // 
            // LogTabelleBindingSource
            // 
            this.LogTabelleBindingSource.DataMember = "LogTabelle";
            this.LogTabelleBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // LogTabelleTableAdapter
            // 
            this.LogTabelleTableAdapter.ClearBeforeFill = true;
            // 
            // StaatenTableAdapter
            // 
            this.StaatenTableAdapter.ClearBeforeFill = true;
            // 
            // AT_PLZ_GeodatenBindingSource
            // 
            this.AT_PLZ_GeodatenBindingSource.DataMember = "AT_PLZ_Geodaten";
            this.AT_PLZ_GeodatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // AT_PLZ_GeodatenTableAdapter
            // 
            this.AT_PLZ_GeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // CH_PLZ_GeodatenBindingSource
            // 
            this.CH_PLZ_GeodatenBindingSource.DataMember = "CH_PLZ_Geodaten";
            this.CH_PLZ_GeodatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // CH_PLZ_GeodatenTableAdapter
            // 
            this.CH_PLZ_GeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // DE_PLZ_GeodatenBindingSource
            // 
            this.DE_PLZ_GeodatenBindingSource.DataMember = "DE_PLZ_Geodaten";
            this.DE_PLZ_GeodatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // DE_PLZ_GeodatenTableAdapter
            // 
            this.DE_PLZ_GeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // PropertiesBindingSource
            // 
            this.PropertiesBindingSource.DataMember = "properties";
            this.PropertiesBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // PropertiesTableAdapter
            // 
            this.PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // Panel9
            // 
            this.Panel9.BackColor = System.Drawing.Color.Silver;
            this.Panel9.Controls.Add(this.DocuwareCSVDataGridView);
            this.Panel9.Controls.Add(this._Button1);
            this.Panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel9.Location = new System.Drawing.Point(773, 3);
            this.Panel9.Name = "Panel9";
            this.Panel9.Size = new System.Drawing.Size(401, 69);
            this.Panel9.TabIndex = 26;
            // 
            // TLP_1
            // 
            this.TLP_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TLP_1.ColumnCount = 4;
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.TLP_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_1.Controls.Add(this.Panel9, 3, 0);
            this.TLP_1.Controls.Add(this.TC_Beleg, 3, 1);
            this.TLP_1.Controls.Add(this.Panel1, 0, 0);
            this.TLP_1.Controls.Add(this.TC_Adresse, 1, 1);
            this.TLP_1.Controls.Add(this.Panel6, 0, 3);
            this.TLP_1.Controls.Add(this.PNL_Klasse, 0, 1);
            this.TLP_1.Controls.Add(this.Panel8, 3, 3);
            this.TLP_1.Controls.Add(this.TC_Kontakt, 2, 1);
            this.TLP_1.Controls.Add(this.PNL_Konto, 0, 2);
            this.TLP_1.Location = new System.Drawing.Point(0, 25);
            this.TLP_1.Name = "TLP_1";
            this.TLP_1.RowCount = 4;
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLP_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TLP_1.Size = new System.Drawing.Size(1177, 581);
            this.TLP_1.TabIndex = 27;
            // 
            // PNL_Klasse
            // 
            this.PNL_Klasse.AutoScroll = true;
            this.PNL_Klasse.BackColor = System.Drawing.Color.White;
            this.PNL_Klasse.Controls.Add(this.CB_Klassifizierung);
            this.PNL_Klasse.Controls.Add(this.panel11);
            this.PNL_Klasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Klasse.Location = new System.Drawing.Point(3, 78);
            this.PNL_Klasse.Name = "PNL_Klasse";
            this.PNL_Klasse.Size = new System.Drawing.Size(164, 130);
            this.PNL_Klasse.TabIndex = 29;
            // 
            // CB_Klassifizierung
            // 
            this.CB_Klassifizierung.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klassifizierungBindingSource, "Klassifizierung", true));
            this.CB_Klassifizierung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Klassifizierung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Klassifizierung.FormattingEnabled = true;
            this.CB_Klassifizierung.Location = new System.Drawing.Point(3, 36);
            this.CB_Klassifizierung.Name = "CB_Klassifizierung";
            this.CB_Klassifizierung.Size = new System.Drawing.Size(158, 24);
            this.CB_Klassifizierung.TabIndex = 20;
            // 
            // klassifizierungBindingSource
            // 
            this.klassifizierungBindingSource.DataMember = "Klassifizierung";
            this.klassifizierungBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Controls.Add(this.label11);
            this.panel11.Location = new System.Drawing.Point(3, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(158, 27);
            this.panel11.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Klassifizierung";
            // 
            // PNL_Konto
            // 
            this.PNL_Konto.BackColor = System.Drawing.Color.White;
            this.PNL_Konto.Controls.Add(this.pictureBox2);
            this.PNL_Konto.Controls.Add(this.KontoDataGridView);
            this.PNL_Konto.Controls.Add(this._btnNeuesKonto);
            this.PNL_Konto.Controls.Add(this.pictureBox1);
            this.PNL_Konto.Controls.Add(this.lblIDKonto);
            this.PNL_Konto.Controls.Add(this.Label3);
            this.PNL_Konto.Controls.Add(this.Panel4);
            this.PNL_Konto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Konto.Location = new System.Drawing.Point(3, 214);
            this.PNL_Konto.Name = "PNL_Konto";
            this.PNL_Konto.Size = new System.Drawing.Size(164, 313);
            this.PNL_Konto.TabIndex = 28;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripProgressBar1,
            this.ToolStripStatusLabel1});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 608);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1177, 22);
            this.StatusStrip1.TabIndex = 28;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripProgressBar1
            // 
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            this.ToolStripProgressBar1.Size = new System.Drawing.Size(300, 16);
            this.ToolStripProgressBar1.Visible = false;
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(192, 17);
            this.ToolStripStatusLabel1.Text = "DocuWare-Datei erfolgreich erstellt";
            this.ToolStripStatusLabel1.Visible = false;
            // 
            // klassifizierungTableAdapter
            // 
            this.klassifizierungTableAdapter.ClearBeforeFill = true;
            // 
            // klassenBindingSource
            // 
            this.klassenBindingSource.DataMember = "Klassen";
            this.klassenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // klassenTableAdapter
            // 
            this.klassenTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "IDKonto";
            this.DataGridViewTextBoxColumn4.HeaderText = "Konto";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 58;
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "KontoName";
            this.DataGridViewTextBoxColumn6.HeaderText = "Konto-Name";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // IDAdresse
            // 
            this.IDAdresse.DataPropertyName = "IDAdresse";
            this.IDAdresse.HeaderText = "IDAdresse";
            this.IDAdresse.Name = "IDAdresse";
            this.IDAdresse.Visible = false;
            // 
            // IDKonto
            // 
            this.IDKonto.DataPropertyName = "IDKonto";
            this.IDKonto.HeaderText = "Konto";
            this.IDKonto.Name = "IDKonto";
            this.IDKonto.Width = 47;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "Straße";
            this.DataGridViewTextBoxColumn7.HeaderText = "Straße";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.Width = 110;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.DataPropertyName = "Ort";
            this.DataGridViewTextBoxColumn10.HeaderText = "Ort";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.Width = 120;
            // 
            // Hauptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1177, 630);
            this.Controls.Add(this.lblHinweisKeinTreffer);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TLP_1);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hauptform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adress-Datenbank";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Hauptform_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocuwareCSVDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocuwareCSVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenBindingSource)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdressenDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontakteDataGridView)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.TC_Beleg.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterBindingSource)).EndInit();
            this.Panel5.ResumeLayout(false);
            this.Panel5.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GB_Anrede.ResumeLayout(false);
            this.GB_Anrede.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeMitAdresseBindingSource)).EndInit();
            this.Panel6.ResumeLayout(false);
            this.TC_Adresse.ResumeLayout(false);
            this.TabAdresseInfo.ResumeLayout(false);
            this.TabAdresseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaatenBindingSource)).EndInit();
            this.PNL_Geodaten.ResumeLayout(false);
            this.PNL_Geodaten.PerformLayout();
            this.Panel7.ResumeLayout(false);
            this.Panel7.PerformLayout();
            this.TabAdresseBearbeiten.ResumeLayout(false);
            this.TabAdresseBearbeiten.PerformLayout();
            this.TC_Kontakt.ResumeLayout(false);
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.Panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KontakteMitAdresseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BelegeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AT_PLZ_GeodatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH_PLZ_GeodatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DE_PLZ_GeodatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesBindingSource)).EndInit();
            this.Panel9.ResumeLayout(false);
            this.TLP_1.ResumeLayout(false);
            this.PNL_Klasse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.klassifizierungBindingSource)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.PNL_Konto.ResumeLayout(false);
            this.PNL_Konto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klassenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal BindingSource FirmenNameBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter FirmenNameTableAdapter;
        internal TextBox TB_FirmenName;
        private Button _BTN_Suche;

        internal Button BTN_Suche
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Suche;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Suche != null)
                {
                    _BTN_Suche.Click -= BTN_Suche_Click;
                }

                _BTN_Suche = value;
                if (_BTN_Suche != null)
                {
                    _BTN_Suche.Click += BTN_Suche_Click;
                }
            }
        }

        private Label _LBL_IDFirmenName;

        internal Label LBL_IDFirmenName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_IDFirmenName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_IDFirmenName != null)
                {
                    _LBL_IDFirmenName.TextChanged -= LBL_IDFirmenName_TextChanged;
                }

                _LBL_IDFirmenName = value;
                if (_LBL_IDFirmenName != null)
                {
                    _LBL_IDFirmenName.TextChanged += LBL_IDFirmenName_TextChanged;
                }
            }
        }

        internal BindingSource KontoBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontoTableAdapter KontoTableAdapter;
        internal Label lblIDKonto;
        private ComboBox _CB_FirmenName;

        internal ComboBox CB_FirmenName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CB_FirmenName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CB_FirmenName != null)
                {
                    _CB_FirmenName.SelectedIndexChanged -= cbFirmenName_SelectedIndexChanged;
                }

                _CB_FirmenName = value;
                if (_CB_FirmenName != null)
                {
                    _CB_FirmenName.SelectedIndexChanged += cbFirmenName_SelectedIndexChanged;
                }
            }
        }

        internal Label Label1;
        private Button _btnNeuesKonto;

        internal Button btnNeuesKonto
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNeuesKonto;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNeuesKonto != null)
                {
                    _btnNeuesKonto.Click -= btnNeuesKonto_Click;
                }

                _btnNeuesKonto = value;
                if (_btnNeuesKonto != null)
                {
                    _btnNeuesKonto.Click += btnNeuesKonto_Click;
                }
            }
        }

        internal Label Label3;
        internal Label lblHinweisKeinTreffer;
        internal Button BTN_Speichern;

        internal Button btnSpeichern
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return BTN_Speichern;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (BTN_Speichern != null)
                {
                    BTN_Speichern.Click -= btnSpeichern_Click;
                }

                BTN_Speichern = value;
                if (BTN_Speichern != null)
                {
                    BTN_Speichern.Click += btnSpeichern_Click;
                }
            }
        }

        internal BindingSource AdressenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.AdressenTableAdapter AdressenTableAdapter;
        internal DataGridView AdressenDataGridView;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        private TextBox _TB_PLZ;

        internal TextBox TB_PLZ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TB_PLZ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TB_PLZ != null)
                {
                    _TB_PLZ.TextChanged -= TB_PLZ_TextChanged;
                }

                _TB_PLZ = value;
                if (_TB_PLZ != null)
                {
                    _TB_PLZ.TextChanged += TB_PLZ_TextChanged;
                }
            }
        }

        internal TextBox StraßeTextBox;
        internal TextBox AdresstypTextBox;
        private Label _LBL_IDAdresse;

        internal Label LBL_IDAdresse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_IDAdresse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_IDAdresse != null)
                {
                    _LBL_IDAdresse.TextChanged -= LBL_IDAdresse_TextChanged;
                }

                _LBL_IDAdresse = value;
                if (_LBL_IDAdresse != null)
                {
                    _LBL_IDAdresse.TextChanged += LBL_IDAdresse_TextChanged;
                }
            }
        }

        internal TextBox PostfachTextBox;
        private Button _btnKontoZuAdresse;

        internal Button btnKontoZuAdresse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnKontoZuAdresse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnKontoZuAdresse != null)
                {
                    _btnKontoZuAdresse.Click -= btnKontoZuAdresse_Click;
                }

                _btnKontoZuAdresse = value;
                if (_btnKontoZuAdresse != null)
                {
                    _btnKontoZuAdresse.Click += btnKontoZuAdresse_Click;
                }
            }
        }

        internal TextBox IDKontoTextBox;
        internal TextBox WebseiteTextBox;
        internal TextBox UStIdNrTextBox;
        internal TextBox TB_Bundesland;
        private Button _btnNeueAdresse;

        internal Button btnNeueAdresse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNeueAdresse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNeueAdresse != null)
                {
                    _btnNeueAdresse.Click -= btnNeueAdresse_Click;
                }

                _btnNeueAdresse = value;
                if (_btnNeueAdresse != null)
                {
                    _btnNeueAdresse.Click += btnNeueAdresse_Click;
                }
            }
        }

        private Button _BTN_MapsSuche;

        internal Button BTN_MapsSuche
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_MapsSuche;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_MapsSuche != null)
                {
                    _BTN_MapsSuche.Click -= btnMapsSuche_Click;
                }

                _BTN_MapsSuche = value;
                if (_BTN_MapsSuche != null)
                {
                    _BTN_MapsSuche.Click += btnMapsSuche_Click;
                }
            }
        }

        internal Label lblTrefferAnzahl;
        internal DataGridView KontoDataGridView;
        internal Panel Panel3;
        private Button _btnNeuerKontakt;

        internal Button btnNeuerKontakt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnNeuerKontakt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnNeuerKontakt != null)
                {
                    _btnNeuerKontakt.Click -= btnNeuerKontakt_Click;
                }

                _btnNeuerKontakt = value;
                if (_btnNeuerKontakt != null)
                {
                    _btnNeuerKontakt.Click += btnNeuerKontakt_Click;
                }
            }
        }

        private Button _BTN_ZuOutlook;

        internal Button BTN_ZuOutlook
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_ZuOutlook;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_ZuOutlook != null)
                {
                    _BTN_ZuOutlook.Click -= BTN_ZuOutlook_Click;
                }

                _BTN_ZuOutlook = value;
                if (_BTN_ZuOutlook != null)
                {
                    _BTN_ZuOutlook.Click += BTN_ZuOutlook_Click;
                }
            }
        }

        internal Label lblKontaktHeader;
        internal BindingSource KontakteBindingSource;
        internal DataGridView KontakteDataGridView;
        private Button _btnAdresseZuKontakt;

        internal Button btnAdresseZuKontakt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAdresseZuKontakt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAdresseZuKontakt != null)
                {
                    _btnAdresseZuKontakt.Click -= btnAdresseZuKontakt_Click;
                }

                _btnAdresseZuKontakt = value;
                if (_btnAdresseZuKontakt != null)
                {
                    _btnAdresseZuKontakt.Click += btnAdresseZuKontakt_Click;
                }
            }
        }

        internal TextBox IDAdresseTextBox;
        internal TextBox FaxnummerTextBox;
        internal TextBox MobiltelefonTextBox;
        internal TextBox TelefonPrivatTextBox;
        internal TextBox TelefonGeschaeftlichTextBox;
        internal TextBox PositionTextBox;
        internal TextBox EmailAddresseTextBox;
        internal TextBox VornameTextBox;
        internal TextBox NachnameTextBox;
        internal ComboBox AnredeComboBox;
        private Label _LBL_IDKontakt;

        internal Label LBL_IDKontakt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_IDKontakt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_IDKontakt != null)
                {
                    _LBL_IDKontakt.TextChanged -= LBL_IDKontakt_TextChanged;
                }

                _LBL_IDKontakt = value;
                if (_LBL_IDKontakt != null)
                {
                    _LBL_IDKontakt.TextChanged += LBL_IDKontakt_TextChanged;
                }
            }
        }

        internal _WSL_AdressenDataSetTableAdapters.KontakteTableAdapter KontakteTableAdapter;
        internal Panel Panel4;
        internal Label Label6;
        internal TabControl TC_Beleg;
        internal TabPage TabPage1;
        internal Panel Panel5;
        internal Label Label7;
        internal TabPage TabPage2;
        internal Panel Panel6;
        private LinkLabel _EmailAddresseLinkLabel;

        internal LinkLabel EmailAddresseLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EmailAddresseLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EmailAddresseLinkLabel != null)
                {
                    _EmailAddresseLinkLabel.LinkClicked -= EmailAddresseLinkLabel_LinkClicked;
                }

                _EmailAddresseLinkLabel = value;
                if (_EmailAddresseLinkLabel != null)
                {
                    _EmailAddresseLinkLabel.LinkClicked += EmailAddresseLinkLabel_LinkClicked;
                }
            }
        }

        internal TabControl TC_Adresse;
        internal TabPage TabAdresseInfo;
        private LinkLabel _WebseiteLinkLabel;

        internal LinkLabel WebseiteLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WebseiteLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WebseiteLinkLabel != null)
                {
                    _WebseiteLinkLabel.LinkClicked -= WebseiteLinkLabel_LinkClicked;
                }

                _WebseiteLinkLabel = value;
                if (_WebseiteLinkLabel != null)
                {
                    _WebseiteLinkLabel.LinkClicked += WebseiteLinkLabel_LinkClicked;
                }
            }
        }

        internal Label UStIdNrLabel2;
        internal Label LBL_Land;
        internal Label BundeslandLabel2;
        internal Label LBL_Ort;
        internal Label LBL_PLZ;
        internal Label PostfachLabel2;
        internal Label LBL_Strasse;
        internal Label AdresstypLabel2;
        internal Panel Panel7;
        internal Label Label4;
        internal TabPage TabAdresseBearbeiten;
        private Label _LBL_IDKontoZuAdresse;

        internal Label LBL_IDKontoZuAdresse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_IDKontoZuAdresse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_IDKontoZuAdresse != null)
                {
                    _LBL_IDKontoZuAdresse.TextChanged -= LBL_IDKontoZuAdresse_TextChanged;
                }

                _LBL_IDKontoZuAdresse = value;
                if (_LBL_IDKontoZuAdresse != null)
                {
                    _LBL_IDKontoZuAdresse.TextChanged += LBL_IDKontoZuAdresse_TextChanged;
                }
            }
        }

        internal TabControl TC_Kontakt;
        internal TabPage TabPage5;
        private Label _LBL_IDAdresseZuKontakt;

        internal Label LBL_IDAdresseZuKontakt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_IDAdresseZuKontakt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_IDAdresseZuKontakt != null)
                {
                    _LBL_IDAdresseZuKontakt.TextChanged -= LBL_IDAdresseZuKontakt_TextChanged;
                }

                _LBL_IDAdresseZuKontakt = value;
                if (_LBL_IDAdresseZuKontakt != null)
                {
                    _LBL_IDAdresseZuKontakt.TextChanged += LBL_IDAdresseZuKontakt_TextChanged;
                }
            }
        }

        internal Label FaxnummerLabel2;
        private LinkLabel _MobiltelefonLinkLabel;

        internal LinkLabel MobiltelefonLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MobiltelefonLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MobiltelefonLinkLabel != null)
                {
                    _MobiltelefonLinkLabel.LinkClicked -= MobiltelefonLinkLabel_LinkClicked;
                }

                _MobiltelefonLinkLabel = value;
                if (_MobiltelefonLinkLabel != null)
                {
                    _MobiltelefonLinkLabel.LinkClicked += MobiltelefonLinkLabel_LinkClicked;
                }
            }
        }

        private LinkLabel _TelefonPrivatLinkLabel;

        internal LinkLabel TelefonPrivatLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TelefonPrivatLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TelefonPrivatLinkLabel != null)
                {
                    _TelefonPrivatLinkLabel.LinkClicked -= TelefonPrivatLinkLabel_LinkClicked;
                }

                _TelefonPrivatLinkLabel = value;
                if (_TelefonPrivatLinkLabel != null)
                {
                    _TelefonPrivatLinkLabel.LinkClicked += TelefonPrivatLinkLabel_LinkClicked;
                }
            }
        }

        private LinkLabel _TelefonGeschaeftlichLinkLabel;

        internal LinkLabel TelefonGeschaeftlichLinkLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TelefonGeschaeftlichLinkLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TelefonGeschaeftlichLinkLabel != null)
                {
                    _TelefonGeschaeftlichLinkLabel.LinkClicked -= TelefonGeschaeftlichLinkLabel_LinkClicked;
                }

                _TelefonGeschaeftlichLinkLabel = value;
                if (_TelefonGeschaeftlichLinkLabel != null)
                {
                    _TelefonGeschaeftlichLinkLabel.LinkClicked += TelefonGeschaeftlichLinkLabel_LinkClicked;
                }
            }
        }

        internal Label PositionLabel2;
        internal Label LBL_Nachname;
        internal Label LBL_Vorname;
        private Label _LBL_Anrede;

        internal Label LBL_Anrede
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_Anrede;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_Anrede != null)
                {
                    _LBL_Anrede.TextChanged -= LBL_Anrede_TextChanged;
                }

                _LBL_Anrede = value;
                if (_LBL_Anrede != null)
                {
                    _LBL_Anrede.TextChanged += LBL_Anrede_TextChanged;
                }
            }
        }

        internal TabPage TabPage6;
        internal DataGridViewTextBoxColumn IDKontakt;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private Button _btnAbbrechen;

        internal Button btnAbbrechen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAbbrechen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAbbrechen != null)
                {
                    _btnAbbrechen.Click -= btnAbbrechen_Click;
                }

                _btnAbbrechen = value;
                if (_btnAbbrechen != null)
                {
                    _btnAbbrechen.Click += btnAbbrechen_Click;
                }
            }
        }

        internal Label lblAdresseNeu;
        internal Label lblKontaktNeu;
        private Label _LBL_FirmenName;

        internal Label LBL_FirmenName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_FirmenName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_FirmenName != null)
                {
                    _LBL_FirmenName.TextChanged -= LBL_FirmenName_TextChanged;
                }

                _LBL_FirmenName = value;
                if (_LBL_FirmenName != null)
                {
                    _LBL_FirmenName.TextChanged += LBL_FirmenName_TextChanged;
                }
            }
        }

        internal Label OrtLabel3;
        internal Label StraßeLabel3;
        internal Label StraßeLabel2;
        internal Label OrtLabel2;
        internal DateTimePicker DTP_BBDatum;
        internal Label LBL_BBLand;
        internal Label LBL_BBOrt;
        internal Label LBL_BBPLZ;
        internal Label LBL_BBStrasse;
        internal TextBox TB_BBThema;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal BindingSource SachbearbeiterBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter SachbearbeiterTableAdapter;
        internal Label LBL_BBBesuchterKontakt;
        

        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem MI_Administration;

        internal ToolStripMenuItem EinstellungenToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return MI_Administration;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (MI_Administration != null)
                {
                    MI_Administration.Click -= EinstellungenToolStripMenuItem_Click;
                }

                MI_Administration = value;
                if (MI_Administration != null)
                {
                    MI_Administration.Click += EinstellungenToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _BenutzerlisteToolStripMenuItem;

        internal ToolStripMenuItem BenutzerlisteToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BenutzerlisteToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BenutzerlisteToolStripMenuItem != null)
                {
                    _BenutzerlisteToolStripMenuItem.Click -= BenutzerlisteToolStripMenuItem_Click;
                }

                _BenutzerlisteToolStripMenuItem = value;
                if (_BenutzerlisteToolStripMenuItem != null)
                {
                    _BenutzerlisteToolStripMenuItem.Click += BenutzerlisteToolStripMenuItem_Click;
                }
            }
        }

        internal Label LBL_BBIDKonto;
        internal Label LBL_BBRegion;
        internal Label lblUser;
        internal BindingSource KontakteMitAdresseBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter KontakteMitAdresseTableAdapter;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn14;
        internal BindingSource DocuwareCSVBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.DocuwareCSVTableAdapter DocuwareCSVTableAdapter;
        internal DataGridView DocuwareCSVDataGridView;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn15;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn16;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn18;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn19;
        internal Panel Panel1;
        internal Label Label2;
        private ComboBox _CB_Vorlagen;

        internal ComboBox CB_Vorlagen
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CB_Vorlagen;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CB_Vorlagen != null)
                {
                    _CB_Vorlagen.SelectedIndexChanged -= CB_Vorlagen_SelectedIndexChanged;
                }

                _CB_Vorlagen = value;
                if (_CB_Vorlagen != null)
                {
                    _CB_Vorlagen.SelectedIndexChanged += CB_Vorlagen_SelectedIndexChanged;
                }
            }
        }

        private Label _LBL_Sprache;

        internal Label LBL_Sprache
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LBL_Sprache;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LBL_Sprache != null)
                {
                    _LBL_Sprache.TextChanged -= LBL_Sprache_TextChanged;
                }

                _LBL_Sprache = value;
                if (_LBL_Sprache != null)
                {
                    _LBL_Sprache.TextChanged += LBL_Sprache_TextChanged;
                }
            }
        }

        internal Label Label8;
        internal Panel Panel2;
        internal Label Label5;
        internal GroupBox GB_Anrede;
        internal TextBox TB_DIVFaxnummer;
        internal GroupBox GroupBox2;
        private RadioButton _RB_OhneAnrede;

        internal RadioButton RB_OhneAnrede
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RB_OhneAnrede;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RB_OhneAnrede != null)
                {
                    _RB_OhneAnrede.CheckedChanged -= RB_OhneAnrede_CheckedChanged;
                }

                _RB_OhneAnrede = value;
                if (_RB_OhneAnrede != null)
                {
                    _RB_OhneAnrede.CheckedChanged += RB_OhneAnrede_CheckedChanged;
                }
            }
        }

        private RadioButton _RB_MitAnrede;

        internal RadioButton RB_MitAnrede
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RB_MitAnrede;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RB_MitAnrede != null)
                {
                    _RB_MitAnrede.CheckedChanged -= RB_MitAnrede_CheckedChanged;
                }

                _RB_MitAnrede = value;
                if (_RB_MitAnrede != null)
                {
                    _RB_MitAnrede.CheckedChanged += RB_MitAnrede_CheckedChanged;
                }
            }
        }

        internal Label LBL_DIVAdresse;
        internal DateTimePicker DTP_Diverse;
        internal Label LBL_DIVEmail;
        internal Label LBL_DIVDurchwahl;
        internal Label LBL_DIVJobtitle;
        internal ComboBox CB_DIVSachbearbeiter;
        internal Label Label10;
        internal Label Label9;
        internal TextBox TB_DIVThema;
        internal ToolStripMenuItem InfoToolStripMenuItem;
        private ToolStripMenuItem _InfoÜberAdressenDBToolStripMenuItem1;

        internal ToolStripMenuItem InfoÜberAdressenDBToolStripMenuItem1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InfoÜberAdressenDBToolStripMenuItem1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InfoÜberAdressenDBToolStripMenuItem1 != null)
                {
                    _InfoÜberAdressenDBToolStripMenuItem1.Click -= InfoÜberAdressenDBToolStripMenuItem1_Click;
                }

                _InfoÜberAdressenDBToolStripMenuItem1 = value;
                if (_InfoÜberAdressenDBToolStripMenuItem1 != null)
                {
                    _InfoÜberAdressenDBToolStripMenuItem1.Click += InfoÜberAdressenDBToolStripMenuItem1_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        internal TextBox TB_BBWeitereBesucher;
        internal TextBox TB_BBWeitereKontakte;
        internal ComboBox CB_BBKuerzel;
        internal Panel Panel8;
        internal Label LBL_DIVIDKonto;
        internal TabPage TabPage3;
        internal DataGridView DataGridView1;
        internal BindingSource BelegeBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.BelegeTableAdapter BelegeTableAdapter;
        internal BindingSource BelegeMitAdresseBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.BelegeMitAdresseTableAdapter BelegeMitAdresseTableAdapter;
        internal ToolStripMenuItem DateiToolStripMenuItem;
        private ToolStripMenuItem _DocuWareDateiManuellToolStripMenuItem;

        internal ToolStripMenuItem DocuWareDateiManuellToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DocuWareDateiManuellToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DocuWareDateiManuellToolStripMenuItem != null)
                {
                    _DocuWareDateiManuellToolStripMenuItem.Click -= DocuWareDateiManuellToolStripMenuItem_Click;
                }

                _DocuWareDateiManuellToolStripMenuItem = value;
                if (_DocuWareDateiManuellToolStripMenuItem != null)
                {
                    _DocuWareDateiManuellToolStripMenuItem.Click += DocuWareDateiManuellToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AktivitätslogToolStripMenuItem;

        internal ToolStripMenuItem AktivitätslogToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AktivitätslogToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AktivitätslogToolStripMenuItem != null)
                {
                    _AktivitätslogToolStripMenuItem.Click -= AktivitätslogToolStripMenuItem_Click;
                }

                _AktivitätslogToolStripMenuItem = value;
                if (_AktivitätslogToolStripMenuItem != null)
                {
                    _AktivitätslogToolStripMenuItem.Click += AktivitätslogToolStripMenuItem_Click;
                }
            }
        }

        internal DataGridViewTextBoxColumn IDBelegDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn DatumDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn KuerzelDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn KontaktDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn ThemaDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn OrtDataGridViewTextBoxColumn;
        internal DataGridViewTextBoxColumn BelegnameDataGridViewTextBoxColumn;
        private ToolStripMenuItem _SchließenToolStripMenuItem;

        internal ToolStripMenuItem SchließenToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SchließenToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SchließenToolStripMenuItem != null)
                {
                    _SchließenToolStripMenuItem.Click -= SchließenToolStripMenuItem_Click;
                }

                _SchließenToolStripMenuItem = value;
                if (_SchließenToolStripMenuItem != null)
                {
                    _SchließenToolStripMenuItem.Click += SchließenToolStripMenuItem_Click;
                }
            }
        }

        private Button _BTN_DeleteUser;

        internal Button BTN_DeleteUser
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_DeleteUser;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_DeleteUser != null)
                {
                    _BTN_DeleteUser.Click -= BTN_DeleteUser_Click;
                }

                _BTN_DeleteUser = value;
                if (_BTN_DeleteUser != null)
                {
                    _BTN_DeleteUser.Click += BTN_DeleteUser_Click;
                }
            }
        }

        internal BindingSource LogTabelleBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter LogTabelleTableAdapter;
        private ToolStripMenuItem _HilfeToolStripMenuItem;

        internal ToolStripMenuItem HilfeToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HilfeToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HilfeToolStripMenuItem != null)
                {
                    _HilfeToolStripMenuItem.Click -= HilfeToolStripMenuItem_Click;
                }

                _HilfeToolStripMenuItem = value;
                if (_HilfeToolStripMenuItem != null)
                {
                    _HilfeToolStripMenuItem.Click += HilfeToolStripMenuItem_Click;
                }
            }
        }

        private Button _BTN_NachnameSuche;

        internal Button BTN_NachnameSuche
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_NachnameSuche;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_NachnameSuche != null)
                {
                    _BTN_NachnameSuche.Click -= BTN_NachnameSuche_Click;
                }

                _BTN_NachnameSuche = value;
                if (_BTN_NachnameSuche != null)
                {
                    _BTN_NachnameSuche.Click += BTN_NachnameSuche_Click;
                }
            }
        }

        internal Label LBL_Countrycode;
        internal ComboBox CB_Ort;
        internal ComboBox CB_Staat;
        internal BindingSource StaatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.StaatenTableAdapter StaatenTableAdapter;
        internal Label LBL_PLZungueltig;
        internal BindingSource AT_PLZ_GeodatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.AT_PLZ_GeodatenTableAdapter AT_PLZ_GeodatenTableAdapter;
        internal BindingSource CH_PLZ_GeodatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.CH_PLZ_GeodatenTableAdapter CH_PLZ_GeodatenTableAdapter;
        internal BindingSource DE_PLZ_GeodatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.DE_PLZ_GeodatenTableAdapter DE_PLZ_GeodatenTableAdapter;
        internal Label LBL_AdressHinweis;
        internal Label LBL_Long;
        internal Label LBL_Lat;
        internal Label LBLLong;
        internal Label LBLLat;
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
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }

        internal Panel PNL_Geodaten;
        internal Label LabelLandAdressen;
        internal Label LBL_CC;
        internal BindingSource PropertiesBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.propertiesTableAdapter PropertiesTableAdapter;
        internal Panel Panel9;
        internal TableLayoutPanel TLP_1;
        internal Panel PNL_Konto;
        internal Panel PNL_Klasse;
        internal StatusStrip StatusStrip1;
        internal ToolStripProgressBar ToolStripProgressBar1;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal Button BTN_DocErzeugen;
        internal Panel panel11;
        internal Label label11;
        private PictureBox pictureBox1;
        private BindingSource klassifizierungBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KlassifizierungTableAdapter klassifizierungTableAdapter;
        private BindingSource klassenBindingSource;
        private _WSL_AdressenDataSetTableAdapters.KlassenTableAdapter klassenTableAdapter;
        private PictureBox pictureBox2;
        internal ComboBox CB_Klassifizierung;
        private ToolTip toolTip1;
        private Label label12;
        private DataGridViewTextBoxColumn IDAdresse;
        private DataGridViewTextBoxColumn IDKonto;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
    }
}