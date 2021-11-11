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
            components = new System.ComponentModel.Container();
            Label StaatLabel;
            Label PLZLabel;
            Label OrtLabel;
            Label BundeslandLabel;
            Label LandkreisLabel;
            Label LatitudeLabel;
            Label LongitudeLabel;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Umkreissuche));
            _CB_Staat = new ComboBox();
            _CB_Staat.SelectedIndexChanged += new EventHandler(CB_Staat_SelectedIndexChanged);
            StaatenBindingSource = new BindingSource(components);
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            BundeslandLabel1 = new Label();
            PLZ_GeodatenBindingSource = new BindingSource(components);
            LandkreisLabel1 = new Label();
            _TB_PLZ = new TextBox();
            _TB_PLZ.TextChanged += new EventHandler(TB_PLZ_TextChanged);
            CB_Ort = new ComboBox();
            LatitudeLabel1 = new Label();
            LongitudeLabel1 = new Label();
            _TB_Entfernung = new TextBox();
            _TB_Entfernung.TextChanged += new EventHandler(TB_Entfernung_TextChanged);
            dgv = new DataGridView();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            LBL_Countrycode = new Label();
            AdresseMitGeodatenBindingSource = new BindingSource(components);
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            StaatenTableAdapter = new _WSL_AdressenDataSetTableAdapters.StaatenTableAdapter();
            AdresseMitGeodatenTableAdapter = new _WSL_AdressenDataSetTableAdapters.AdresseMitGeodatenTableAdapter();
            PLZ_GeodatenTableAdapter = new _WSL_AdressenDataSetTableAdapters.PLZ_GeodatenTableAdapter();
            LBL_Treffer = new Label();
            _Button2 = new Button();
            _Button2.Click += new EventHandler(Button2_Click);
            _PrintDocument1 = new System.Drawing.Printing.PrintDocument();
            _PrintDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(PrintDocument1_PrintPage);
            _PrintDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(PrintDocument1_BeginPrint);
            _PrintPreviewDialog1 = new PrintPreviewDialog();
            _PrintPreviewDialog1.Shown += new EventHandler(GetControlsFromDialog);
            LBL_PLZungueltig = new Label();
            Label2 = new Label();
            Label3 = new Label();
            TableLayoutPanel1 = new TableLayoutPanel();
            Panel2 = new Panel();
            lbl_IDFirmenName = new Label();
            Label1 = new Label();
            Panel3 = new Panel();
            _Button3 = new Button();
            _Button3.Click += new EventHandler(Button3_Click);
            Label4 = new Label();
            _BTN_Schliessen = new Button();
            _BTN_Schliessen.Click += new EventHandler(BTN_Schliessen_Click);
            Panel1 = new Panel();
            Label5 = new Label();
            PrintDialog1 = new PrintDialog();
            PageSetupDialog1 = new PageSetupDialog();
            StaatLabel = new Label();
            PLZLabel = new Label();
            OrtLabel = new Label();
            BundeslandLabel = new Label();
            LandkreisLabel = new Label();
            LatitudeLabel = new Label();
            LongitudeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)StaatenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLZ_GeodatenBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdresseMitGeodatenBindingSource).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            Panel2.SuspendLayout();
            Panel3.SuspendLayout();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // StaatLabel
            // 
            StaatLabel.AutoSize = true;
            StaatLabel.Location = new Point(3, 9);
            StaatLabel.Name = "StaatLabel";
            StaatLabel.Size = new Size(35, 13);
            StaatLabel.TabIndex = 0;
            StaatLabel.Text = "Staat:";
            // 
            // PLZLabel
            // 
            PLZLabel.AutoSize = true;
            PLZLabel.Location = new Point(8, 36);
            PLZLabel.Name = "PLZLabel";
            PLZLabel.Size = new Size(30, 13);
            PLZLabel.TabIndex = 4;
            PLZLabel.Text = "PLZ:";
            // 
            // OrtLabel
            // 
            OrtLabel.AutoSize = true;
            OrtLabel.Location = new Point(13, 62);
            OrtLabel.Name = "OrtLabel";
            OrtLabel.Size = new Size(24, 13);
            OrtLabel.TabIndex = 6;
            OrtLabel.Text = "Ort:";
            // 
            // BundeslandLabel
            // 
            BundeslandLabel.AutoSize = true;
            BundeslandLabel.Location = new Point(15, 148);
            BundeslandLabel.Name = "BundeslandLabel";
            BundeslandLabel.Size = new Size(44, 13);
            BundeslandLabel.TabIndex = 8;
            BundeslandLabel.Text = "Region:";
            // 
            // LandkreisLabel
            // 
            LandkreisLabel.AutoSize = true;
            LandkreisLabel.Location = new Point(3, 170);
            LandkreisLabel.Name = "LandkreisLabel";
            LandkreisLabel.Size = new Size(56, 13);
            LandkreisLabel.TabIndex = 10;
            LandkreisLabel.Text = "Landkreis:";
            // 
            // LatitudeLabel
            // 
            LatitudeLabel.AutoSize = true;
            LatitudeLabel.Location = new Point(15, 194);
            LatitudeLabel.Name = "LatitudeLabel";
            LatitudeLabel.Size = new Size(44, 13);
            LatitudeLabel.TabIndex = 13;
            LatitudeLabel.Text = "latitude:";
            // 
            // LongitudeLabel
            // 
            LongitudeLabel.AutoSize = true;
            LongitudeLabel.Location = new Point(6, 207);
            LongitudeLabel.Name = "LongitudeLabel";
            LongitudeLabel.Size = new Size(53, 13);
            LongitudeLabel.TabIndex = 14;
            LongitudeLabel.Text = "longitude:";
            // 
            // CB_Staat
            // 
            _CB_Staat.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _CB_Staat.AutoCompleteSource = AutoCompleteSource.ListItems;
            _CB_Staat.FormattingEnabled = true;
            _CB_Staat.Location = new Point(44, 6);
            _CB_Staat.Name = "_CB_Staat";
            _CB_Staat.Size = new Size(120, 21);
            _CB_Staat.TabIndex = 1;
            // 
            // StaatenBindingSource
            // 
            StaatenBindingSource.DataMember = "Staaten";
            StaatenBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // BundeslandLabel1
            // 
            BundeslandLabel1.DataBindings.Add(new Binding("Text", PLZ_GeodatenBindingSource, "Bundesland", true));
            BundeslandLabel1.Location = new Point(79, 143);
            BundeslandLabel1.Name = "BundeslandLabel1";
            BundeslandLabel1.Size = new Size(138, 23);
            BundeslandLabel1.TabIndex = 9;
            BundeslandLabel1.Text = "Region";
            BundeslandLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PLZ_GeodatenBindingSource
            // 
            PLZ_GeodatenBindingSource.DataMember = "PLZ_Geodaten";
            PLZ_GeodatenBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // LandkreisLabel1
            // 
            LandkreisLabel1.DataBindings.Add(new Binding("Text", PLZ_GeodatenBindingSource, "Landkreis", true));
            LandkreisLabel1.Location = new Point(65, 166);
            LandkreisLabel1.Name = "LandkreisLabel1";
            LandkreisLabel1.Size = new Size(138, 23);
            LandkreisLabel1.TabIndex = 11;
            LandkreisLabel1.Text = "landkreis";
            LandkreisLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TB_PLZ
            // 
            _TB_PLZ.Location = new Point(44, 33);
            _TB_PLZ.Name = "_TB_PLZ";
            _TB_PLZ.Size = new Size(74, 20);
            _TB_PLZ.TabIndex = 12;
            // 
            // CB_Ort
            // 
            CB_Ort.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CB_Ort.AutoCompleteSource = AutoCompleteSource.ListItems;
            CB_Ort.Cursor = Cursors.Default;
            CB_Ort.DataSource = PLZ_GeodatenBindingSource;
            CB_Ort.DisplayMember = "Ort";
            CB_Ort.FormattingEnabled = true;
            CB_Ort.Location = new Point(44, 59);
            CB_Ort.Name = "CB_Ort";
            CB_Ort.Size = new Size(159, 21);
            CB_Ort.TabIndex = 13;
            // 
            // LatitudeLabel1
            // 
            LatitudeLabel1.DataBindings.Add(new Binding("Text", PLZ_GeodatenBindingSource, "latitude", true));
            LatitudeLabel1.Location = new Point(66, 194);
            LatitudeLabel1.Name = "LatitudeLabel1";
            LatitudeLabel1.Size = new Size(100, 13);
            LatitudeLabel1.TabIndex = 14;
            LatitudeLabel1.Text = "lat";
            // 
            // LongitudeLabel1
            // 
            LongitudeLabel1.DataBindings.Add(new Binding("Text", PLZ_GeodatenBindingSource, "longitude", true));
            LongitudeLabel1.Location = new Point(66, 207);
            LongitudeLabel1.Name = "LongitudeLabel1";
            LongitudeLabel1.Size = new Size(100, 17);
            LongitudeLabel1.TabIndex = 15;
            LongitudeLabel1.Text = "long";
            // 
            // TB_Entfernung
            // 
            _TB_Entfernung.Location = new Point(68, 94);
            _TB_Entfernung.Name = "_TB_Entfernung";
            _TB_Entfernung.Size = new Size(41, 20);
            _TB_Entfernung.TabIndex = 16;
            _TB_Entfernung.Text = "10";
            _TB_Entfernung.WordWrap = false;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(233, 42);
            dgv.Name = "dgv";
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(752, 407);
            dgv.TabIndex = 17;
            // 
            // Button1
            // 
            _Button1.BackColor = Color.ForestGreen;
            _Button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _Button1.ForeColor = Color.White;
            _Button1.Image = My.Resources.Resources.Search_16x;
            _Button1.ImageAlign = ContentAlignment.MiddleRight;
            _Button1.Location = new Point(44, 236);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(122, 31);
            _Button1.TabIndex = 18;
            _Button1.Text = "Umkreissuche";
            _Button1.TextAlign = ContentAlignment.MiddleLeft;
            _Button1.UseVisualStyleBackColor = false;
            // 
            // LBL_Countrycode
            // 
            LBL_Countrycode.DataBindings.Add(new Binding("Text", StaatenBindingSource, "ISO2", true));
            LBL_Countrycode.Location = new Point(170, 6);
            LBL_Countrycode.Name = "LBL_Countrycode";
            LBL_Countrycode.Size = new Size(47, 23);
            LBL_Countrycode.TabIndex = 3;
            LBL_Countrycode.Text = "Code";
            LBL_Countrycode.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AdresseMitGeodatenBindingSource
            // 
            AdresseMitGeodatenBindingSource.DataMember = "AdresseMitGeodaten";
            AdresseMitGeodatenBindingSource.DataSource = _WSL_AdressenDataSet;
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
            // StaatenTableAdapter
            // 
            StaatenTableAdapter.ClearBeforeFill = true;
            // 
            // AdresseMitGeodatenTableAdapter
            // 
            AdresseMitGeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // PLZ_GeodatenTableAdapter
            // 
            PLZ_GeodatenTableAdapter.ClearBeforeFill = true;
            // 
            // LBL_Treffer
            // 
            LBL_Treffer.AutoSize = true;
            LBL_Treffer.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            LBL_Treffer.ForeColor = Color.White;
            LBL_Treffer.Location = new Point(259, 12);
            LBL_Treffer.Name = "LBL_Treffer";
            LBL_Treffer.Size = new Size(63, 20);
            LBL_Treffer.TabIndex = 19;
            LBL_Treffer.Text = "Treffer";
            // 
            // Button2
            // 
            _Button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _Button2.Image = My.Resources.Resources.PrintDocument_16x;
            _Button2.ImageAlign = ContentAlignment.MiddleRight;
            _Button2.Location = new Point(796, 10);
            _Button2.Name = "_Button2";
            _Button2.Size = new Size(80, 23);
            _Button2.TabIndex = 20;
            _Button2.Text = "Drucken";
            _Button2.TextAlign = ContentAlignment.MiddleLeft;
            _Button2.UseVisualStyleBackColor = true;
            // 
            // PrintDocument1
            // 
            // 
            // PrintPreviewDialog1
            // 
            _PrintPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            _PrintPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            _PrintPreviewDialog1.ClientSize = new Size(400, 300);
            _PrintPreviewDialog1.Enabled = true;
            _PrintPreviewDialog1.Icon = (Icon)resources.GetObject("PrintPreviewDialog1.Icon");
            _PrintPreviewDialog1.Name = "_PrintPreviewDialog1";
            _PrintPreviewDialog1.Visible = false;
            // 
            // LBL_PLZungueltig
            // 
            LBL_PLZungueltig.AutoSize = true;
            LBL_PLZungueltig.ForeColor = Color.Red;
            LBL_PLZungueltig.Location = new Point(133, 36);
            LBL_PLZungueltig.Name = "LBL_PLZungueltig";
            LBL_PLZungueltig.Size = new Size(70, 13);
            LBL_PLZungueltig.TabIndex = 28;
            LBL_PLZungueltig.Text = "PLZ ungültig!";
            LBL_PLZungueltig.TextAlign = ContentAlignment.MiddleCenter;
            LBL_PLZungueltig.Visible = false;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label2.Location = new Point(11, 97);
            Label2.Name = "Label2";
            Label2.Size = new Size(56, 13);
            Label2.TabIndex = 30;
            Label2.Text = "Umkreis:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(115, 97);
            Label3.Name = "Label3";
            Label3.Size = new Size(88, 13);
            Label3.TabIndex = 31;
            Label3.Text = "10 - max. 200 km";
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.Controls.Add(Panel2, 0, 0);
            TableLayoutPanel1.Controls.Add(Panel3, 0, 2);
            TableLayoutPanel1.Controls.Add(dgv, 1, 1);
            TableLayoutPanel1.Controls.Add(Panel1, 0, 1);
            TableLayoutPanel1.Location = new Point(0, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 3;
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46.0f));
            TableLayoutPanel1.Size = new Size(988, 498);
            TableLayoutPanel1.TabIndex = 32;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel2.BackColor = Color.Silver;
            TableLayoutPanel1.SetColumnSpan(Panel2, 2);
            Panel2.Controls.Add(lbl_IDFirmenName);
            Panel2.Controls.Add(Label1);
            Panel2.Location = new Point(3, 3);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(982, 33);
            Panel2.TabIndex = 26;
            // 
            // lbl_IDFirmenName
            // 
            lbl_IDFirmenName.DataBindings.Add(new Binding("Text", AdresseMitGeodatenBindingSource, "FirmenName", true));
            lbl_IDFirmenName.ForeColor = Color.Gray;
            lbl_IDFirmenName.Location = new Point(230, 6);
            lbl_IDFirmenName.Name = "lbl_IDFirmenName";
            lbl_IDFirmenName.Size = new Size(407, 23);
            lbl_IDFirmenName.TabIndex = 33;
            lbl_IDFirmenName.Text = "FirmenName";
            lbl_IDFirmenName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(180, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Umkreissuche (D-A-CH)";
            // 
            // Panel3
            // 
            Panel3.AutoScroll = true;
            Panel3.BackColor = Color.Gray;
            TableLayoutPanel1.SetColumnSpan(Panel3, 2);
            Panel3.Controls.Add(_Button3);
            Panel3.Controls.Add(Label4);
            Panel3.Controls.Add(_Button2);
            Panel3.Controls.Add(_BTN_Schliessen);
            Panel3.Controls.Add(LBL_Treffer);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(3, 455);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(982, 40);
            Panel3.TabIndex = 28;
            // 
            // Button3
            // 
            _Button3.Image = My.Resources.Resources.BackToResultList_16x;
            _Button3.ImageAlign = ContentAlignment.MiddleRight;
            _Button3.Location = new Point(345, 10);
            _Button3.Name = "_Button3";
            _Button3.Size = new Size(116, 23);
            _Button3.TabIndex = 33;
            _Button3.Text = "Auswahl anzeigen";
            _Button3.TextAlign = ContentAlignment.MiddleLeft;
            _Button3.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(185, 12);
            Label4.Name = "Label4";
            Label4.Size = new Size(68, 20);
            Label4.TabIndex = 32;
            Label4.Text = "Treffer:";
            // 
            // BTN_Schliessen
            // 
            _BTN_Schliessen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Schliessen.Image = My.Resources.Resources.CloseSolution_16x;
            _BTN_Schliessen.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Schliessen.Location = new Point(891, 10);
            _BTN_Schliessen.Name = "_BTN_Schliessen";
            _BTN_Schliessen.Size = new Size(80, 22);
            _BTN_Schliessen.TabIndex = 16;
            _BTN_Schliessen.Text = "Schließen";
            _BTN_Schliessen.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Schliessen.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.AutoScroll = true;
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(StaatLabel);
            Panel1.Controls.Add(_Button1);
            Panel1.Controls.Add(_CB_Staat);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(LBL_Countrycode);
            Panel1.Controls.Add(LBL_PLZungueltig);
            Panel1.Controls.Add(PLZLabel);
            Panel1.Controls.Add(_TB_PLZ);
            Panel1.Controls.Add(Label2);
            Panel1.Controls.Add(_TB_Entfernung);
            Panel1.Controls.Add(BundeslandLabel1);
            Panel1.Controls.Add(LandkreisLabel);
            Panel1.Controls.Add(LatitudeLabel1);
            Panel1.Controls.Add(LongitudeLabel1);
            Panel1.Controls.Add(LandkreisLabel1);
            Panel1.Controls.Add(LongitudeLabel);
            Panel1.Controls.Add(CB_Ort);
            Panel1.Controls.Add(LatitudeLabel);
            Panel1.Controls.Add(OrtLabel);
            Panel1.Controls.Add(BundeslandLabel);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(3, 42);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(224, 407);
            Panel1.TabIndex = 29;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)), Conversions.ToInteger(Conversions.ToByte(224)));
            Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label5.Location = new Point(13, 286);
            Label5.Name = "Label5";
            Label5.Size = new Size(186, 91);
            Label5.TabIndex = 32;
            Label5.Text = "Die berechneten Entfernungen" + '\r' + '\n' + "beziehen sich auf die Mitte" + '\r' + '\n' + "der PLZ-Region!" + '\r' + '\n' + '\r' + '\n' + "Tre" + "ffer innerhalb der gleichen" + '\r' + '\n' + "PLZ/Region, haben keine Entfernung" + '\r' + '\n' + "zueinander.";
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog = true;
            // 
            // Umkreissuche
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 499);
            Controls.Add(TableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Umkreissuche";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)StaatenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLZ_GeodatenBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdresseMitGeodatenBindingSource).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Load += new EventHandler(Form8_Load);
            Shown += new EventHandler(Umkreissuche_Shown);
            ResumeLayout(false);
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