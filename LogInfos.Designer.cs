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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginformationen));
            Panel2 = new Panel();
            _BTN_Alle = new Button();
            _BTN_Alle.Click += new EventHandler(BTN_Alle_Click);
            _BTN_Aktuell = new Button();
            _BTN_Aktuell.Click += new EventHandler(BTN_Aktuell_Click);
            Label1 = new Label();
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            Panel3 = new Panel();
            _BTN_Schliessen = new Button();
            _BTN_Schliessen.Click += new EventHandler(BTN_Schliessen_Click);
            LogTabelleBindingSource = new BindingSource(components);
            LogTabelleTableAdapter = new _WSL_AdressenDataSetTableAdapters.LogTabelleTableAdapter();
            LogTabelleDataGridView = new DataGridView();
            TableLayoutPanel1 = new TableLayoutPanel();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FirmenName = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogTabelleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogTabelleDataGridView).BeginInit();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel2.BackColor = Color.Silver;
            Panel2.Controls.Add(_BTN_Alle);
            Panel2.Controls.Add(_BTN_Aktuell);
            Panel2.Controls.Add(Label1);
            Panel2.Location = new Point(3, 3);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(935, 33);
            Panel2.TabIndex = 26;
            // 
            // BTN_Alle
            // 
            _BTN_Alle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Alle.Location = new Point(681, 6);
            _BTN_Alle.Name = "_BTN_Alle";
            _BTN_Alle.Size = new Size(75, 23);
            _BTN_Alle.TabIndex = 2;
            _BTN_Alle.Text = "alle";
            _BTN_Alle.UseVisualStyleBackColor = true;
            // 
            // BTN_Aktuell
            // 
            _BTN_Aktuell.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Aktuell.Location = new Point(768, 6);
            _BTN_Aktuell.Name = "_BTN_Aktuell";
            _BTN_Aktuell.Size = new Size(156, 23);
            _BTN_Aktuell.TabIndex = 1;
            _BTN_Aktuell.Text = "aktuellen Geschäftspartner";
            _BTN_Aktuell.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(133, 20);
            Label1.TabIndex = 0;
            Label1.Text = "Loginformationen";
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            // Panel3
            // 
            Panel3.BackColor = Color.Gray;
            Panel3.Controls.Add(_BTN_Schliessen);
            Panel3.Dock = DockStyle.Fill;
            Panel3.Location = new Point(3, 343);
            Panel3.Name = "Panel3";
            Panel3.Size = new Size(935, 40);
            Panel3.TabIndex = 28;
            // 
            // BTN_Schliessen
            // 
            _BTN_Schliessen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Schliessen.Image = My.Resources.Resources.CloseSolution_16x;
            _BTN_Schliessen.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Schliessen.Location = new Point(844, 10);
            _BTN_Schliessen.Name = "_BTN_Schliessen";
            _BTN_Schliessen.Size = new Size(80, 22);
            _BTN_Schliessen.TabIndex = 16;
            _BTN_Schliessen.Text = "Schließen";
            _BTN_Schliessen.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Schliessen.UseVisualStyleBackColor = true;
            // 
            // LogTabelleBindingSource
            // 
            LogTabelleBindingSource.DataMember = "LogTabelle";
            LogTabelleBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // LogTabelleTableAdapter
            // 
            LogTabelleTableAdapter.ClearBeforeFill = true;
            // 
            // LogTabelleDataGridView
            // 
            LogTabelleDataGridView.AutoGenerateColumns = false;
            LogTabelleDataGridView.BackgroundColor = Color.White;
            LogTabelleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LogTabelleDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, FirmenName, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8 });
            LogTabelleDataGridView.DataSource = LogTabelleBindingSource;
            LogTabelleDataGridView.Dock = DockStyle.Fill;
            LogTabelleDataGridView.Location = new Point(3, 42);
            LogTabelleDataGridView.Name = "LogTabelleDataGridView";
            LogTabelleDataGridView.RowHeadersVisible = false;
            LogTabelleDataGridView.Size = new Size(935, 295);
            LogTabelleDataGridView.TabIndex = 29;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(Panel2, 0, 0);
            TableLayoutPanel1.Controls.Add(LogTabelleDataGridView, 0, 1);
            TableLayoutPanel1.Controls.Add(Panel3, 0, 2);
            TableLayoutPanel1.Location = new Point(1, 0);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 3;
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.7489f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46.0f));
            TableLayoutPanel1.Size = new Size(941, 386);
            TableLayoutPanel1.TabIndex = 30;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "ID";
            DataGridViewTextBoxColumn1.HeaderText = "ID";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.ReadOnly = true;
            DataGridViewTextBoxColumn1.Width = 30;
            // 
            // FirmenName
            // 
            FirmenName.DataPropertyName = "FirmenName";
            FirmenName.HeaderText = "FirmenName";
            FirmenName.Name = "FirmenName";
            FirmenName.Width = 200;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "Meldung";
            DataGridViewTextBoxColumn2.HeaderText = "Meldung";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            // 
            // DataGridViewTextBoxColumn3
            // 
            DataGridViewTextBoxColumn3.DataPropertyName = "Tabelle";
            DataGridViewTextBoxColumn3.HeaderText = "Tabelle";
            DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "IDInTabelle";
            DataGridViewTextBoxColumn4.HeaderText = "IDInTabelle";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "Hinweis";
            DataGridViewTextBoxColumn5.HeaderText = "Hinweis";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // DataGridViewTextBoxColumn6
            // 
            DataGridViewTextBoxColumn6.DataPropertyName = "Login";
            DataGridViewTextBoxColumn6.HeaderText = "Login";
            DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            // 
            // DataGridViewTextBoxColumn7
            // 
            DataGridViewTextBoxColumn7.DataPropertyName = "Datum";
            DataGridViewTextBoxColumn7.HeaderText = "Datum";
            DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            // 
            // DataGridViewTextBoxColumn8
            // 
            DataGridViewTextBoxColumn8.DataPropertyName = "IDFirmenName";
            DataGridViewTextBoxColumn8.HeaderText = "IDFirmenName";
            DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            // 
            // Loginformationen
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 386);
            Controls.Add(TableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Loginformationen";
            Text = "Log-Informationen";
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LogTabelleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogTabelleDataGridView).EndInit();
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(Form6_Load);
            ResumeLayout(false);
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
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn FirmenName;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
    }
}