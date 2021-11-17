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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontoForm));
            this.rdbKundenNr = new System.Windows.Forms.RadioButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblKontoNummer = new System.Windows.Forms.Label();
            this.rdbLieferantenNr = new System.Windows.Forms.RadioButton();
            this._btnKontoSave = new System.Windows.Forms.Button();
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.KontoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KontoTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.KontoTableAdapter();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.KontoDataGridView = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmenNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirmenNameTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.FirmenNameTableAdapter();
            this.lblIDFirmenName = new System.Windows.Forms.Label();
            this.lblFirmenName = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._Button1 = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PropertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PropertiesTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.propertiesTableAdapter();
            this.Panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).BeginInit();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesBindingSource)).BeginInit();
            this.Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbKundenNr
            // 
            this.rdbKundenNr.AutoSize = true;
            this.rdbKundenNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbKundenNr.Location = new System.Drawing.Point(27, 93);
            this.rdbKundenNr.Name = "rdbKundenNr";
            this.rdbKundenNr.Size = new System.Drawing.Size(126, 21);
            this.rdbKundenNr.TabIndex = 0;
            this.rdbKundenNr.TabStop = true;
            this.rdbKundenNr.Text = "Kundennummer";
            this.rdbKundenNr.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(166, 17);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Neue Konto-Nummer für:";
            // 
            // lblKontoNummer
            // 
            this.lblKontoNummer.AutoSize = true;
            this.lblKontoNummer.BackColor = System.Drawing.Color.White;
            this.lblKontoNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKontoNummer.Location = new System.Drawing.Point(9, 0);
            this.lblKontoNummer.Name = "lblKontoNummer";
            this.lblKontoNummer.Size = new System.Drawing.Size(91, 29);
            this.lblKontoNummer.TabIndex = 2;
            this.lblKontoNummer.Text = "123456";
            this.lblKontoNummer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdbLieferantenNr
            // 
            this.rdbLieferantenNr.AutoSize = true;
            this.rdbLieferantenNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLieferantenNr.Location = new System.Drawing.Point(27, 120);
            this.rdbLieferantenNr.Name = "rdbLieferantenNr";
            this.rdbLieferantenNr.Size = new System.Drawing.Size(149, 21);
            this.rdbLieferantenNr.TabIndex = 3;
            this.rdbLieferantenNr.TabStop = true;
            this.rdbLieferantenNr.Text = "Lieferantennummer";
            this.rdbLieferantenNr.UseVisualStyleBackColor = true;
            // 
            // _btnKontoSave
            // 
            this._btnKontoSave.Image = global::Adress_DB.My.Resources.Resources.Save_16x;
            this._btnKontoSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnKontoSave.Location = new System.Drawing.Point(62, 8);
            this._btnKontoSave.Name = "_btnKontoSave";
            this._btnKontoSave.Size = new System.Drawing.Size(151, 23);
            this._btnKontoSave.TabIndex = 6;
            this._btnKontoSave.Text = "Hinzufügen / Speichern";
            this._btnKontoSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnKontoSave.UseVisualStyleBackColor = true;
            this._btnKontoSave.Click += new System.EventHandler(this.btnKontoSave_Click);
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // KontoBindingSource
            // 
            this.KontoBindingSource.DataMember = "Konto";
            this.KontoBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // KontoTableAdapter
            // 
            this.KontoTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.AdressenTableAdapter = null;
            this.TableAdapterManager.AT_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.BelegeTableAdapter = null;
            this.TableAdapterManager.CH_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.DE_PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.FirmenNameTableAdapter = null;
            this.TableAdapterManager.KontakteTableAdapter = null;
            this.TableAdapterManager.KontoTableAdapter = this.KontoTableAdapter;
            this.TableAdapterManager.LogTabelleTableAdapter = null;
            this.TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.propertiesTableAdapter = null;
            this.TableAdapterManager.SachbearbeiterTableAdapter = null;
            this.TableAdapterManager.StaatenTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn4});
            this.KontoDataGridView.DataSource = this.KontoBindingSource;
            this.KontoDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.KontoDataGridView.Location = new System.Drawing.Point(275, 71);
            this.KontoDataGridView.MultiSelect = false;
            this.KontoDataGridView.Name = "KontoDataGridView";
            this.KontoDataGridView.ReadOnly = true;
            this.KontoDataGridView.RowHeadersVisible = false;
            this.KontoDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KontoDataGridView.Size = new System.Drawing.Size(233, 160);
            this.KontoDataGridView.TabIndex = 9;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "IDKonto";
            this.DataGridViewTextBoxColumn3.HeaderText = "IDKonto";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 80;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "KontoName";
            this.DataGridViewTextBoxColumn5.HeaderText = "KontoName";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            this.DataGridViewTextBoxColumn5.Width = 150;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn4.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Visible = false;
            this.DataGridViewTextBoxColumn4.Width = 50;
            // 
            // FirmenNameBindingSource
            // 
            this.FirmenNameBindingSource.DataMember = "FirmenName";
            this.FirmenNameBindingSource.DataSource = this._WSL_AdressenDataSet;
            // 
            // FirmenNameTableAdapter
            // 
            this.FirmenNameTableAdapter.ClearBeforeFill = true;
            // 
            // lblIDFirmenName
            // 
            this.lblIDFirmenName.AutoSize = true;
            this.lblIDFirmenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDFirmenName.Location = new System.Drawing.Point(391, 9);
            this.lblIDFirmenName.Name = "lblIDFirmenName";
            this.lblIDFirmenName.Size = new System.Drawing.Size(102, 13);
            this.lblIDFirmenName.TabIndex = 10;
            this.lblIDFirmenName.Text = "lblIDFirmenName";
            this.lblIDFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirmenName
            // 
            this.lblFirmenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FirmenNameBindingSource, "FirmenName", true));
            this.lblFirmenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmenName.Location = new System.Drawing.Point(13, 35);
            this.lblFirmenName.Name = "lblFirmenName";
            this.lblFirmenName.Size = new System.Drawing.Size(371, 24);
            this.lblFirmenName.TabIndex = 11;
            this.lblFirmenName.Text = "lblFirmenName";
            this.lblFirmenName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 77);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(213, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Bitte wählen, welche Nummer benötigt wird:";
            // 
            // _Button1
            // 
            this._Button1.Image = global::Adress_DB.My.Resources.Resources.Cancel_16x;
            this._Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._Button1.Location = new System.Drawing.Point(426, 10);
            this._Button1.Name = "_Button1";
            this._Button1.Size = new System.Drawing.Size(80, 23);
            this._Button1.TabIndex = 13;
            this._Button1.Text = "Abbrechen";
            this._Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Button1.UseVisualStyleBackColor = true;
            this._Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.lblFirmenName);
            this.Panel1.Controls.Add(this.lblIDFirmenName);
            this.Panel1.Location = new System.Drawing.Point(-1, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(518, 65);
            this.Panel1.TabIndex = 14;
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Gray;
            this.Panel2.Controls.Add(this._btnKontoSave);
            this.Panel2.Controls.Add(this._Button1);
            this.Panel2.Location = new System.Drawing.Point(-1, 238);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(518, 42);
            this.Panel2.TabIndex = 15;
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
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.lblKontoNummer);
            this.Panel3.Location = new System.Drawing.Point(85, 178);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(113, 31);
            this.Panel3.TabIndex = 16;
            // 
            // KontoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 281);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.KontoDataGridView);
            this.Controls.Add(this.rdbLieferantenNr);
            this.Controls.Add(this.rdbKundenNr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KontoForm";
            this.Text = "Neues Konto anlegen";
            this.Load += new System.EventHandler(this.KontoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KontoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirmenNameBindingSource)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PropertiesBindingSource)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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