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
    public partial class Umkreissuche : Form
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
            System.Windows.Forms.Label StaatLabel;
            System.Windows.Forms.Label PLZLabel;
            System.Windows.Forms.Label OrtLabel;
            System.Windows.Forms.Label BundeslandLabel;
            System.Windows.Forms.Label LandkreisLabel;
            System.Windows.Forms.Label LatitudeLabel;
            System.Windows.Forms.Label LongitudeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Umkreissuche));
            this._CB_Staat = new System.Windows.Forms.ComboBox();
            this.StaatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.BundeslandLabel1 = new System.Windows.Forms.Label();
            this.PLZ_GeodatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LandkreisLabel1 = new System.Windows.Forms.Label();
            this._TB_PLZ = new System.Windows.Forms.TextBox();
            this.CB_Ort = new System.Windows.Forms.ComboBox();
            this.LatitudeLabel1 = new System.Windows.Forms.Label();
            this.LongitudeLabel1 = new System.Windows.Forms.Label();
            this._TB_Entfernung = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this._Button1 = new System.Windows.Forms.Button();
            this.LBL_Countrycode = new System.Windows.Forms.Label();
            this.AdresseMitGeodatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.StaatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.StaatenTableAdapter();
            this.AdresseMitGeodatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.AdresseMitGeodatenTableAdapter();
            this.PLZ_GeodatenTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.PLZ_GeodatenTableAdapter();
            this.LBL_Treffer = new System.Windows.Forms.Label();
            this._Button2 = new System.Windows.Forms.Button();
            this._PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            this._PrintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.LBL_PLZungueltig = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lbl_IDFirmenName = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel3 = new System.Windows.Forms.Panel();
            this._Button3 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this._BTN_Schliessen = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.PrintDialog1 = new System.Windows.Forms.PrintDialog();
            this.PageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            StaatLabel = new System.Windows.Forms.Label();
            PLZLabel = new System.Windows.Forms.Label();
            OrtLabel = new System.Windows.Forms.Label();
            BundeslandLabel = new System.Windows.Forms.Label();
            LandkreisLabel = new System.Windows.Forms.Label();
            LatitudeLabel = new System.Windows.Forms.Label();
            LongitudeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLZ_GeodatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresseMitGeodatenBindingSource)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaatLabel
            // 
            StaatLabel.AutoSize = true;
            StaatLabel.Location = new System.Drawing.Point(3, 9);
            StaatLabel.Name = "StaatLabel";
            StaatLabel.Size = new System.Drawing.Size(35, 13);
            StaatLabel.TabIndex = 0;
            StaatLabel.Text = "Staat:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new System.Drawing.Point(8, 36);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new System.Drawing.Size(30, 13);
            PLZLabel.TabIndex = 4;
            PLZLabel.Text = "PLZ:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new System.Drawing.Point(13, 62);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new System.Drawing.Size(24, 13);
            OrtLabel.TabIndex = 6;
            OrtLabel.Text = "Ort:";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new System.Drawing.Point(15, 148);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new System.Drawing.Size(44, 13);
            BundeslandLabel.TabIndex = 8;
            BundeslandLabel.Text = "Region:";
            // 
            // LandkreisLabel
            // 
            LandkreisLabel.AutoSize = true;
            LandkreisLabel.Location = new System.Drawing.Point(3, 170);
            LandkreisLabel.Name = "LandkreisLabel";
            LandkreisLabel.Size = new System.Drawing.Size(56, 13);
            LandkreisLabel.TabIndex = 10;
            LandkreisLabel.Text = "Landkreis:";
            // 
            // LatitudeLabel
            // 
            LatitudeLabel.AutoSize = true;
            LatitudeLabel.Location = new System.Drawing.Point(15, 194);
            LatitudeLabel.Name = "LatitudeLabel";
            LatitudeLabel.Size = new System.Drawing.Size(44, 13);
            LatitudeLabel.TabIndex = 13;
            LatitudeLabel.Text = "latitude:";
            // 
            // LongitudeLabel
            // 
            LongitudeLabel.AutoSize = true;
            LongitudeLabel.Location = new System.Drawing.Point(6, 207);
            LongitudeLabel.Name = "LongitudeLabel";
            LongitudeLabel.Size = new System.Drawing.Size(53, 13);
            LongitudeLabel.TabIndex = 14;
            LongitudeLabel.Text = "longitude:";
            // 
            // _CB_Staat
            // 
            this._CB_Staat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this._CB_Staat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._CB_Staat.FormattingEnabled = true;
            this._CB_Staat.Location = new System.Drawing.Point(44, 6);
            this._CB_Staat.Name = "_CB_Staat";
            this._CB_Staat.Size = new System.Drawing.Size(120, 21);
            this._CB_Staat.TabIndex = 1;
            this._CB_Staat.SelectedIndexChanged += new System.EventHandler(this.CB_Staat_SelectedIndexChanged);
            // 
            // StaatenBindingSource
            // 
            this.StaatenBindingSource.DataMember = "Staaten";
            this.StaatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BundeslandLabel1
            // 
            this.BundeslandLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PLZ_GeodatenBindingSource, "Bundesland", true));
            this.BundeslandLabel1.Location = new System.Drawing.Point(79, 143);
            this.BundeslandLabel1.Name = "BundeslandLabel1";
            this.BundeslandLabel1.Size = new System.Drawing.Size(138, 23);
            this.BundeslandLabel1.TabIndex = 9;
            this.BundeslandLabel1.Text = "Region";
            this.BundeslandLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PLZ_GeodatenBindingSource
            // 
            this.PLZ_GeodatenBindingSource.DataMember = "PLZ_Geodaten";
            this.PLZ_GeodatenBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // LandkreisLabel1
            // 
            this.LandkreisLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PLZ_GeodatenBindingSource, "Landkreis", true));
            this.LandkreisLabel1.Location = new System.Drawing.Point(65, 166);
            this.LandkreisLabel1.Name = "LandkreisLabel1";
            this.LandkreisLabel1.Size = new System.Drawing.Size(138, 23);
            this.LandkreisLabel1.TabIndex = 11;
            this.LandkreisLabel1.Text = "landkreis";
            this.LandkreisLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _TB_PLZ
            // 
            this._TB_PLZ.Location = new System.Drawing.Point(44, 33);
            this._TB_PLZ.Name = "_TB_PLZ";
            this._TB_PLZ.Size = new System.Drawing.Size(74, 20);
            this._TB_PLZ.TabIndex = 12;
            this._TB_PLZ.TextChanged += new System.EventHandler(this.TB_PLZ_TextChanged);
            // 
            // CB_Ort
            // 
            this.CB_Ort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CB_Ort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CB_Ort.Cursor = System.Windows.Forms.Cursors.Default;
            this.CB_Ort.DataSource = this.PLZ_GeodatenBindingSource;
            this.CB_Ort.DisplayMember = "Ort";
            this.CB_Ort.FormattingEnabled = true;
            this.CB_Ort.Location = new System.Drawing.Point(44, 59);
            this.CB_Ort.Name = "CB_Ort";
            this.CB_Ort.Size = new System.Drawing.Size(159, 21);
            this.CB_Ort.TabIndex = 13;
            // 
            // LatitudeLabel1
            // 
            this.LatitudeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PLZ_GeodatenBindingSource, "latitude", true));
            this.LatitudeLabel1.Location = new System.Drawing.Point(66, 194);
            this.LatitudeLabel1.Name = "LatitudeLabel1";
            this.LatitudeLabel1.Size = new System.Drawing.Size(100, 13);
            this.LatitudeLabel1.TabIndex = 14;
            this.LatitudeLabel1.Text = "lat";
            // 
            // LongitudeLabel1
            // 
            this.LongitudeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PLZ_GeodatenBindingSource, "longitude", true));
            this.LongitudeLabel1.Location = new System.Drawing.Point(66, 207);
            this.LongitudeLabel1.Name = "LongitudeLabel1";
            this.LongitudeLabel1.Size = new System.Drawing.Size(100, 17);
            this.LongitudeLabel1.TabIndex = 15;
            this.LongitudeLabel1.Text = "long";
            // 
            // _TB_Entfernung
            // 
            this._TB_Entfernung.Location = new System.Drawing.Point(68, 94);
            this._TB_Entfernung.Name = "_TB_Entfernung";
            this._TB_Entfernung.Size = new System.Drawing.Size(41, 20);
            this._TB_Entfernung.TabIndex = 16;
            this._TB_Entfernung.Text = "10";
            this._TB_Entfernung.WordWrap = false;
            this._TB_Entfernung.TextChanged += new System.EventHandler(this.TB_Entfernung_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(233, 42);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(752, 407);
            this.dgv.TabIndex = 17;
            // 
            // _Button1
            // 
            this._Button1.BackColor = System.Drawing.Color.ForestGreen;
            this._Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Button1.ForeColor = System.Drawing.Color.White;
            this._Button1.Image = global::Adress_DB.My.Resources.Resources.Search_16x;
            this._Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Button1.Location = new System.Drawing.Point(44, 236);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(122, 31);
            this._Button1.TabIndex = 18;
            this._Button1.Text = "Umkreissuche";
            this._Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Button1.UseVisualStyleBackColor = false;
            this._Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LBL_Countrycode
            // 
            this.LBL_Countrycode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.StaatenBindingSource, "ISO2", true));
            this.LBL_Countrycode.Location = new System.Drawing.Point(170, 6);
            this.LBL_Countrycode.Name = "LBL_Countrycode";
            this.LBL_Countrycode.Size = new System.Drawing.Size(47, 23);
            this.LBL_Countrycode.TabIndex = 3;
            this.LBL_Countrycode.Text = "Code";
            this.LBL_Countrycode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdresseMitGeodatenBindingSource
            // 
            this.AdresseMitGeodatenBindingSource.DataMember = "AdresseMitGeodaten";
            this.AdresseMitGeodatenBindingSource.DataSource = this._WSL_AdressenDataSet;
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
            // StaatenTableAdapter
            // 
            this.StaatenTableAdapter.ClearBeforeFill = true;
            // 
            // AdresseMitGeodatenTableAdapter
            // 
            this.AdresseMitGeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // PLZ_GeodatenTableAdapter
            // 
            this.PLZ_GeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // LBL_Treffer
            // 
            this.LBL_Treffer.AutoSize = true;
            this.LBL_Treffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Treffer.ForeColor = System.Drawing.Color.White;
            this.LBL_Treffer.Location = new System.Drawing.Point(259, 12);
            this.LBL_Treffer.Name = "LBL_Treffer";
            this.LBL_Treffer.Size = new System.Drawing.Size(63, 20);
            this.LBL_Treffer.TabIndex = 19;
            this.LBL_Treffer.Text = "Treffer";
            // 
            // _Button2
            // 
            this._Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Button2.Image = global::Adress_DB.My.Resources.Resources.PrintDocument_16x;
            this._Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Button2.Location = new System.Drawing.Point(796, 10);
            this._Button2.Name = "_Button2";
            this._Button2.Size = new System.Drawing.Size(80, 23);
            this._Button2.TabIndex = 20;
            this._Button2.Text = "Drucken";
            this._Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Button2.UseVisualStyleBackColor = true;
            this._Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // _PrintDocument1
            // 
            this._PrintDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.PrintDocument1_BeginPrint);
            this._PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // _PrintPreviewDialog1
            // 
            this._PrintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this._PrintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this._PrintPreviewDialog1.Enabled = true;
            this._PrintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("_PrintPreviewDialog1.Icon")));
            this._PrintPreviewDialog1.Name = "_PrintPreviewDialog1";
            this._PrintPreviewDialog1.Visible = false;
            this._PrintPreviewDialog1.Shown += new System.EventHandler(this.GetControlsFromDialog);
            // 
            // LBL_PLZungueltig
            // 
            this.LBL_PLZungueltig.AutoSize = true;
            this.LBL_PLZungueltig.ForeColor = System.Drawing.Color.Red;
            this.LBL_PLZungueltig.Location = new System.Drawing.Point(133, 36);
            this.LBL_PLZungueltig.Name = "LBL_PLZungueltig";
            this.LBL_PLZungueltig.Size = new System.Drawing.Size(70, 13);
            this.LBL_PLZungueltig.TabIndex = 28;
            this.LBL_PLZungueltig.Text = "PLZ ungültig!";
            this.LBL_PLZungueltig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_PLZungueltig.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(11, 97);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "Umkreis:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(115, 97);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(67, 13);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "max. 200 km";
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel3, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.dgv, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(988, 498);
            this.TableLayoutPanel1.TabIndex = 32;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.TableLayoutPanel1.SetColumnSpan(this.Panel2, 2);
            this.Panel2.Controls.Add(this.lbl_IDFirmenName);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(982, 33);
            this.Panel2.TabIndex = 26;
            // 
            // lbl_IDFirmenName
            // 
            this.lbl_IDFirmenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.AdresseMitGeodatenBindingSource, "FirmenName", true));
            this.lbl_IDFirmenName.ForeColor = System.Drawing.Color.Gray;
            this.lbl_IDFirmenName.Location = new System.Drawing.Point(230, 6);
            this.lbl_IDFirmenName.Name = "lbl_IDFirmenName";
            this.lbl_IDFirmenName.Size = new System.Drawing.Size(407, 23);
            this.lbl_IDFirmenName.TabIndex = 33;
            this.lbl_IDFirmenName.Text = "FirmenName";
            this.lbl_IDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(180, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Umkreissuche (D-A-CH)";
            // 
            // Panel3
            // 
            this.Panel3.AutoScroll = true;
            this.Panel3.BackColor = System.Drawing.Color.Gray;
            this.TableLayoutPanel1.SetColumnSpan(this.Panel3, 2);
            this.Panel3.Controls.Add(this._Button3);
            this.Panel3.Controls.Add(this.Label4);
            this.Panel3.Controls.Add(this._Button2);
            this.Panel3.Controls.Add(this._BTN_Schliessen);
            this.Panel3.Controls.Add(this.LBL_Treffer);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 455);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(982, 40);
            this.Panel3.TabIndex = 28;
            // 
            // _Button3
            // 
            this._Button3.Image = global::Adress_DB.My.Resources.Resources.BackToResultList_16x;
            this._Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Button3.Location = new System.Drawing.Point(345, 10);
            this._Button3.Name = "_Button3";
            this._Button3.Size = new System.Drawing.Size(116, 23);
            this._Button3.TabIndex = 33;
            this._Button3.Text = "Auswahl anzeigen";
            this._Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Button3.UseVisualStyleBackColor = true;
            this._Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(185, 12);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 20);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "Treffer:";
            // 
            // _BTN_Schliessen
            // 
            this._BTN_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Schliessen.Image = global::Adress_DB.My.Resources.Resources.CloseSolution_16x;
            this._BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Schliessen.Location = new System.Drawing.Point(891, 10);
            this._BTN_Schliessen.Name = "_BTN_Schliessen";
            this._BTN_Schliessen.Size = new System.Drawing.Size(80, 22);
            this._BTN_Schliessen.TabIndex = 16;
            this._BTN_Schliessen.Text = "Schließen";
            this._BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Schliessen.UseVisualStyleBackColor = true;
            this._BTN_Schliessen.Click += new System.EventHandler(this.BTN_Schliessen_Click);
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.Controls.Add(this.Label5);
            this.Panel1.Controls.Add(StaatLabel);
            this.Panel1.Controls.Add(this._Button1);
            this.Panel1.Controls.Add(this._CB_Staat);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.LBL_Countrycode);
            this.Panel1.Controls.Add(this.LBL_PLZungueltig);
            this.Panel1.Controls.Add(PLZLabel);
            this.Panel1.Controls.Add(this._TB_PLZ);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this._TB_Entfernung);
            this.Panel1.Controls.Add(this.BundeslandLabel1);
            this.Panel1.Controls.Add(LandkreisLabel);
            this.Panel1.Controls.Add(this.LatitudeLabel1);
            this.Panel1.Controls.Add(this.LongitudeLabel1);
            this.Panel1.Controls.Add(this.LandkreisLabel1);
            this.Panel1.Controls.Add(LongitudeLabel);
            this.Panel1.Controls.Add(this.CB_Ort);
            this.Panel1.Controls.Add(LatitudeLabel);
            this.Panel1.Controls.Add(OrtLabel);
            this.Panel1.Controls.Add(BundeslandLabel);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 42);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(224, 407);
            this.Panel1.TabIndex = 29;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(13, 286);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(186, 91);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "Die berechneten Entfernungen\r\nbeziehen sich auf die Mitte\r\nder PLZ-Region!\r\n\r\nTre" +
    "ffer innerhalb der gleichen\r\nPLZ/Region, haben keine Entfernung\r\nzueinander.";
            // 
            // PrintDialog1
            // 
            this.PrintDialog1.UseEXDialog = true;
            // 
            // Umkreissuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 499);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Umkreissuche";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.Shown += new System.EventHandler(this.Umkreissuche_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.StaatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PLZ_GeodatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdresseMitGeodatenBindingSource)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        private ComboBox _CB_Staat;

        internal ComboBox CB_Staat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CB_Staat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CB_Staat != null)
                {
                    _CB_Staat.SelectedIndexChanged -= CB_Staat_SelectedIndexChanged;
                }

                _CB_Staat = value;
                if (_CB_Staat != null)
                {
                    _CB_Staat.SelectedIndexChanged += CB_Staat_SelectedIndexChanged;
                }
            }
        }

        internal Label BundeslandLabel1;
        internal Label LandkreisLabel1;
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

        internal ComboBox CB_Ort;
        internal BindingSource StaatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.StaatenTableAdapter StaatenTableAdapter;
        internal Label LatitudeLabel1;
        internal Label LongitudeLabel1;
        internal BindingSource AdresseMitGeodatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.AdresseMitGeodatenTableAdapter AdresseMitGeodatenTableAdapter;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal BindingSource PLZ_GeodatenBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.PLZ_GeodatenTableAdapter PLZ_GeodatenTableAdapter;
        private TextBox _TB_Entfernung;

        internal TextBox TB_Entfernung
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TB_Entfernung;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TB_Entfernung != null)
                {
                    _TB_Entfernung.TextChanged -= TB_Entfernung_TextChanged;
                }

                _TB_Entfernung = value;
                if (_TB_Entfernung != null)
                {
                    _TB_Entfernung.TextChanged += TB_Entfernung_TextChanged;
                }
            }
        }

        internal DataGridView dgv;
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

        internal Label LBL_Countrycode;
        internal Label LBL_Treffer;
        private Button _Button2;

        internal Button Button2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button2 != null)
                {
                    _Button2.Click -= Button2_Click;
                }

                _Button2 = value;
                if (_Button2 != null)
                {
                    _Button2.Click += Button2_Click;
                }
            }
        }

        private System.Drawing.Printing.PrintDocument _PrintDocument1;

        internal System.Drawing.Printing.PrintDocument PrintDocument1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrintDocument1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.PrintPage -= PrintDocument1_PrintPage;
                    _PrintDocument1.BeginPrint -= PrintDocument1_BeginPrint;
                }

                _PrintDocument1 = value;
                if (_PrintDocument1 != null)
                {
                    _PrintDocument1.PrintPage += PrintDocument1_PrintPage;
                    _PrintDocument1.BeginPrint += PrintDocument1_BeginPrint;
                }
            }
        }

        private PrintPreviewDialog _PrintPreviewDialog1;

        internal PrintPreviewDialog PrintPreviewDialog1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PrintPreviewDialog1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PrintPreviewDialog1 != null)
                {
                    _PrintPreviewDialog1.Shown -= GetControlsFromDialog;
                }

                _PrintPreviewDialog1 = value;
                if (_PrintPreviewDialog1 != null)
                {
                    _PrintPreviewDialog1.Shown += GetControlsFromDialog;
                }
            }
        }

        internal Label LBL_PLZungueltig;
        internal Label Label2;
        internal Label Label3;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Panel Panel2;
        internal Label Label1;
        internal Panel Panel3;
        internal Label Label4;
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

        internal Panel Panel1;
        internal Label Label5;
        internal Label lbl_IDFirmenName;
        private Button _Button3;

        internal Button Button3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button3 != null)
                {
                    _Button3.Click -= Button3_Click;
                }

                _Button3 = value;
                if (_Button3 != null)
                {
                    _Button3.Click += Button3_Click;
                }
            }
        }

        internal PrintDialog PrintDialog1;
        internal PageSetupDialog PageSetupDialog1;
    }
}