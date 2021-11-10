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
    public partial class KontoForm : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(KontoForm));
            rdbKundenNr = new RadioButton();
            Label1 = new Label();
            lblKontoNummer = new Label();
            rdbLieferantenNr = new RadioButton();
            _btnKontoSave = new Button();
            _btnKontoSave.Click += new EventHandler(btnKontoSave_Click);
            _WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            KontoBindingSource = new BindingSource(components);
            KontoTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            KontoDataGridView = new DataGridView();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            FirmenNameBindingSource = new BindingSource(components);
            FirmenNameTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            lblIDFirmenName = new Label();
            lblFirmenName = new Label();
            Label2 = new Label();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            Panel1 = new Panel();
            Panel2 = new Panel();
            PropertiesBindingSource = new BindingSource(components);
            PropertiesTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter();
            Panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontoDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirmenNameBindingSource).BeginInit();
            Panel1.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PropertiesBindingSource).BeginInit();
            Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // rdbKundenNr
            // 
            rdbKundenNr.AutoSize = true;
            rdbKundenNr.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rdbKundenNr.Location = new Point(27, 93);
            rdbKundenNr.Name = "rdbKundenNr";
            rdbKundenNr.Size = new Size(126, 21);
            rdbKundenNr.TabIndex = 0;
            rdbKundenNr.TabStop = true;
            rdbKundenNr.Text = "Kundennummer";
            rdbKundenNr.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.Location = new Point(13, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(166, 17);
            Label1.TabIndex = 1;
            Label1.Text = "Neue Konto-Nummer für:";
            // 
            // lblKontoNummer
            // 
            lblKontoNummer.AutoSize = true;
            lblKontoNummer.BackColor = Color.White;
            lblKontoNummer.Font = new Font("Microsoft Sans Serif", 18.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            lblKontoNummer.Location = new Point(9, 0);
            lblKontoNummer.Name = "lblKontoNummer";
            lblKontoNummer.Size = new Size(91, 29);
            lblKontoNummer.TabIndex = 2;
            lblKontoNummer.Text = "123456";
            lblKontoNummer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rdbLieferantenNr
            // 
            rdbLieferantenNr.AutoSize = true;
            rdbLieferantenNr.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            rdbLieferantenNr.Location = new Point(27, 120);
            rdbLieferantenNr.Name = "rdbLieferantenNr";
            rdbLieferantenNr.Size = new Size(149, 21);
            rdbLieferantenNr.TabIndex = 3;
            rdbLieferantenNr.TabStop = true;
            rdbLieferantenNr.Text = "Lieferantennummer";
            rdbLieferantenNr.UseVisualStyleBackColor = true;
            // 
            // btnKontoSave
            // 
            _btnKontoSave.Image = Adress_DB.My.Resources.Resources.Save_16x;
            _btnKontoSave.ImageAlign = ContentAlignment.MiddleRight;
            _btnKontoSave.Location = new Point(62, 8);
            _btnKontoSave.Name = "_btnKontoSave";
            _btnKontoSave.Size = new Size(151, 23);
            _btnKontoSave.TabIndex = 6;
            _btnKontoSave.Text = "Hinzufügen / Speichern";
            _btnKontoSave.TextAlign = ContentAlignment.MiddleLeft;
            _btnKontoSave.UseVisualStyleBackColor = true;
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // KontoBindingSource
            // 
            KontoBindingSource.DataMember = "Konto";
            KontoBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // KontoTableAdapter
            // 
            KontoTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            TableAdapterManager.AdressenTableAdapter = null;
            TableAdapterManager.AT_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.BackupDataSetBeforeUpdate = false;
            TableAdapterManager.BelegeTableAdapter = null;
            TableAdapterManager.CH_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.DE_PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.FirmenNameTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = KontoTableAdapter;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.propertiesTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = null;
            TableAdapterManager.StaatenTableAdapter = null;
            TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // KontoDataGridView
            // 
            KontoDataGridView.AllowUserToAddRows = false;
            KontoDataGridView.AllowUserToDeleteRows = false;
            KontoDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            KontoDataGridView.AutoGenerateColumns = false;
            KontoDataGridView.BackgroundColor = Color.White;
            KontoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KontoDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn4 });
            KontoDataGridView.DataSource = KontoBindingSource;
            KontoDataGridView.GridColor = SystemColors.AppWorkspace;
            KontoDataGridView.Location = new Point(275, 71);
            KontoDataGridView.MultiSelect = false;
            KontoDataGridView.Name = "KontoDataGridView";
            KontoDataGridView.ReadOnly = true;
            KontoDataGridView.RowHeadersVisible = false;
            KontoDataGridView.ScrollBars = ScrollBars.Vertical;
            KontoDataGridView.Size = new Size(233, 160);
            KontoDataGridView.TabIndex = 9;
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto";
            DataGridViewTextBoxColumn3.HeaderText = "IDKonto";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            DataGridViewTextBoxColumn3.ReadOnly = true;
            DataGridViewTextBoxColumn3.Width = 80;
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "KontoName";
            DataGridViewTextBoxColumn5.HeaderText = "KontoName";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            DataGridViewTextBoxColumn5.ReadOnly = true;
            DataGridViewTextBoxColumn5.Width = 150;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            DataGridViewTextBoxColumn4.ReadOnly = true;
            DataGridViewTextBoxColumn4.Visible = false;
            DataGridViewTextBoxColumn4.Width = 50;
            // 
            // FirmenNameBindingSource
            // 
            FirmenNameBindingSource.DataMember = "FirmenName";
            FirmenNameBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // FirmenNameTableAdapter
            // 
            FirmenNameTableAdapter.ClearBeforeFill = true;
            // 
            // lblIDFirmenName
            // 
            lblIDFirmenName.AutoSize = true;
            lblIDFirmenName.Font = new Font("Microsoft Sans Serif", 8.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblIDFirmenName.Location = new Point(391, 9);
            lblIDFirmenName.Name = "lblIDFirmenName";
            lblIDFirmenName.Size = new Size(102, 13);
            lblIDFirmenName.TabIndex = 10;
            lblIDFirmenName.Text = "lblIDFirmenName";
            lblIDFirmenName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirmenName
            // 
            lblFirmenName.DataBindings.Add(new Binding("Text", FirmenNameBindingSource, "FirmenName", true));
            lblFirmenName.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblFirmenName.Location = new Point(13, 35);
            lblFirmenName.Name = "lblFirmenName";
            lblFirmenName.Size = new Size(371, 24);
            lblFirmenName.TabIndex = 11;
            lblFirmenName.Text = "lblFirmenName";
            lblFirmenName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(24, 77);
            Label2.Name = "Label2";
            Label2.Size = new Size(213, 13);
            Label2.TabIndex = 12;
            Label2.Text = "Bitte wählen, welche Nummer benötigt wird:";
            // 
            // Button1
            // 
            _Button1.Image = Adress_DB.My.Resources.Resources.CloseSolution_16x;
            _Button1.ImageAlign = ContentAlignment.MiddleRight;
            _Button1.Location = new Point(426, 10);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(80, 23);
            _Button1.TabIndex = 13;
            _Button1.Text = "Schließen";
            _Button1.TextAlign = ContentAlignment.MiddleLeft;
            _Button1.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.Silver;
            Panel1.Controls.Add(Label1);
            Panel1.Controls.Add(lblFirmenName);
            Panel1.Controls.Add(lblIDFirmenName);
            Panel1.Location = new Point(-1, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(518, 65);
            Panel1.TabIndex = 14;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel2.BackColor = Color.Gray;
            Panel2.Controls.Add(_btnKontoSave);
            Panel2.Controls.Add(_Button1);
            Panel2.Location = new Point(-1, 238);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(518, 42);
            Panel2.TabIndex = 15;
            // 
            // PropertiesBindingSource
            // 
            PropertiesBindingSource.DataMember = "properties";
            PropertiesBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // PropertiesTableAdapter
            // 
            PropertiesTableAdapter.ClearBeforeFill = true;
            // 
            // Panel3
            // 
            Panel3.BackColor = Color.White;
            Panel3.BorderStyle = BorderStyle.FixedSingle;
            Panel3.Controls.Add(lblKontoNummer);
            Panel3.Location = new Point(85, 178);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(113, 31);
            Panel3.TabIndex = 16;
            // 
            // KontoForm
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 281);
            Controls.Add(Panel3);
            Controls.Add(Panel2);
            Controls.Add(Panel1);
            Controls.Add(Label2);
            Controls.Add(KontoDataGridView);
            Controls.Add(rdbLieferantenNr);
            Controls.Add(rdbKundenNr);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "KontoForm";
            Text = "Neues Konto anlegen";
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontoDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirmenNameBindingSource).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PropertiesBindingSource).EndInit();
            Panel3.ResumeLayout(false);
            Panel3.PerformLayout();
            Load += new EventHandler(KontoForm_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal RadioButton rdbKundenNr;
        internal Label Label1;
        internal Label lblKontoNummer;
        internal RadioButton rdbLieferantenNr;
        private Button _btnKontoSave;

        internal Button btnKontoSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnKontoSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnKontoSave != null)
                {
                    _btnKontoSave.Click -= btnKontoSave_Click;
                }

                _btnKontoSave = value;
                if (_btnKontoSave != null)
                {
                    _btnKontoSave.Click += btnKontoSave_Click;
                }
            }
        }

        internal Adress_DB._WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal BindingSource KontoBindingSource;
        internal Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter KontoTableAdapter;
        internal Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal DataGridView KontoDataGridView;
        internal BindingSource FirmenNameBindingSource;
        internal Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter FirmenNameTableAdapter;
        internal Label lblIDFirmenName;
        internal Label lblFirmenName;
        internal Label Label2;
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

        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal Panel Panel1;
        internal Panel Panel2;
        internal BindingSource PropertiesBindingSource;
        internal Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter PropertiesTableAdapter;
        internal Panel Panel3;
    }
}