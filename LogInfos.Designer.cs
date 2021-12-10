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
    public partial class Loginformationen : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginformationen));
            this.Panel2 = new System.Windows.Forms.Panel();
            this._BTN_Alle = new System.Windows.Forms.Button();
            this._BTN_Aktuell = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.Panel3 = new System.Windows.Forms.Panel();
            this._BTN_Schliessen = new System.Windows.Forms.Button();
            this.LogTabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogTabelleTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter();
            this.LogTabelleDataGridView = new System.Windows.Forms.DataGridView();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleDataGridView)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this._BTN_Alle);
            this.Panel2.Controls.Add(this._BTN_Aktuell);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(935, 33);
            this.Panel2.TabIndex = 26;
            // 
            // _BTN_Alle
            // 
            this._BTN_Alle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Alle.Location = new System.Drawing.Point(681, 6);
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
            this._BTN_Aktuell.Location = new System.Drawing.Point(768, 6);
            this._BTN_Aktuell.Name = "_BTN_Aktuell";
            this._BTN_Aktuell.Size = new System.Drawing.Size(156, 23);
            this._BTN_Aktuell.TabIndex = 1;
            this._BTN_Aktuell.Text = "aktuellen Geschäftspartner";
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
            this.Label1.Size = new System.Drawing.Size(133, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Loginformationen";
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.Gray;
            this.Panel3.Controls.Add(this._BTN_Schliessen);
            this.Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel3.Location = new System.Drawing.Point(3, 343);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(935, 40);
            this.Panel3.TabIndex = 28;
            // 
            // _BTN_Schliessen
            // 
            this._BTN_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Schliessen.Image = global::Adress_DB.My.Resources.Resources.CloseSolution_16x;
            this._BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Schliessen.Location = new System.Drawing.Point(844, 10);
            this._BTN_Schliessen.Name = "_BTN_Schliessen";
            this._BTN_Schliessen.Size = new System.Drawing.Size(80, 22);
            this._BTN_Schliessen.TabIndex = 16;
            this._BTN_Schliessen.Text = "Schließen";
            this._BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Schliessen.UseVisualStyleBackColor = true;
            this._BTN_Schliessen.Click += new System.EventHandler(this.BTN_Schliessen_Click);
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
            // LogTabelleDataGridView
            // 
            this.LogTabelleDataGridView.AutoGenerateColumns = false;
            this.LogTabelleDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.LogTabelleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogTabelleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.FirmenName,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn4,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6,
            this.DataGridViewTextBoxColumn7,
            this.DataGridViewTextBoxColumn8});
            this.LogTabelleDataGridView.DataSource = this.LogTabelleBindingSource;
            this.LogTabelleDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTabelleDataGridView.Location = new System.Drawing.Point(3, 42);
            this.LogTabelleDataGridView.Name = "LogTabelleDataGridView";
            this.LogTabelleDataGridView.RowHeadersVisible = false;
            this.LogTabelleDataGridView.Size = new System.Drawing.Size(935, 295);
            this.LogTabelleDataGridView.TabIndex = 29;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.LogTabelleDataGridView, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.Panel3, 0, 2);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.7489F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(941, 386);
            this.TableLayoutPanel1.TabIndex = 30;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.DataGridViewTextBoxColumn1.HeaderText = "ID";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 30;
            // 
            // FirmenName
            // 
            this.FirmenName.DataPropertyName = "FirmenName";
            this.FirmenName.HeaderText = "FirmenName";
            this.FirmenName.Name = "FirmenName";
            this.FirmenName.Width = 200;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Meldung";
            this.DataGridViewTextBoxColumn2.HeaderText = "Meldung";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.DataPropertyName = "Tabelle";
            this.DataGridViewTextBoxColumn3.HeaderText = "Tabelle";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.DataPropertyName = "IDInTabelle";
            this.DataGridViewTextBoxColumn4.HeaderText = "IDInTabelle";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.DataPropertyName = "Hinweis";
            this.DataGridViewTextBoxColumn5.HeaderText = "Hinweis";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // DataGridViewTextBoxColumn6
            // 
            this.DataGridViewTextBoxColumn6.DataPropertyName = "Login";
            this.DataGridViewTextBoxColumn6.HeaderText = "Login";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.DataPropertyName = "Datum";
            this.DataGridViewTextBoxColumn7.HeaderText = "Datum";
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName";
            this.DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            // 
            // Loginformationen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 386);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loginformationen";
            this.Text = "Log-Informationen";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            this.Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogTabelleDataGridView)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        internal Panel Panel2;
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

        internal Label Label1;
        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal Panel Panel3;
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

        internal BindingSource LogTabelleBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter LogTabelleTableAdapter;
        internal DataGridView LogTabelleDataGridView;
        internal TableLayoutPanel TableLayoutPanel1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn FirmenName;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
    }
}