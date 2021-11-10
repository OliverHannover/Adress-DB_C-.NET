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
    public partial class Personensuche : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Personensuche));
            Panel1 = new Panel();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            KontakteMitAdresseBindingSource = new BindingSource(components);
            KontakteMitAdresseTableAdapter = new _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter();
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            KontakteMitAdresseDataGridView = new DataGridView();
            DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            LBL_FirmenName = new Label();
            LBL_IDKontakt = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Panel1.BackColor = Color.Gray;
            Panel1.Controls.Add(LBL_IDKontakt);
            Panel1.Controls.Add(LBL_FirmenName);
            Panel1.Controls.Add(_Button1);
            Panel1.Location = new Point(0, 278);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(888, 43);
            Panel1.TabIndex = 0;
            // 
            // Button1
            // 
            _Button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _Button1.Image = My.Resources.Resources.ContactCard_16x;
            _Button1.ImageAlign = ContentAlignment.MiddleRight;
            _Button1.Location = new Point(794, 9);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(80, 23);
            _Button1.TabIndex = 0;
            _Button1.Text = "Anzeigen";
            _Button1.TextAlign = ContentAlignment.MiddleLeft;
            _Button1.UseVisualStyleBackColor = true;
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // KontakteMitAdresseBindingSource
            // 
            KontakteMitAdresseBindingSource.DataMember = "KontakteMitAdresse";
            KontakteMitAdresseBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // KontakteMitAdresseTableAdapter
            // 
            KontakteMitAdresseTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            TableAdapterManager.AdressenTableAdapter = null;
            TableAdapterManager.BackupDataSetBeforeUpdate = false;
            TableAdapterManager.BelegeTableAdapter = null;
            TableAdapterManager.Connection = null;
            TableAdapterManager.FirmenNameTableAdapter = null;
            TableAdapterManager.KonfigurationTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = null;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = null;
            TableAdapterManager.UpdateOrder = _WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // KontakteMitAdresseDataGridView
            // 
            KontakteMitAdresseDataGridView.AllowUserToAddRows = false;
            KontakteMitAdresseDataGridView.AllowUserToDeleteRows = false;
            KontakteMitAdresseDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            KontakteMitAdresseDataGridView.AutoGenerateColumns = false;
            KontakteMitAdresseDataGridView.BackgroundColor = Color.White;
            KontakteMitAdresseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            KontakteMitAdresseDataGridView.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn11, DataGridViewTextBoxColumn12, DataGridViewTextBoxColumn13, DataGridViewTextBoxColumn20, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5 });
            KontakteMitAdresseDataGridView.DataSource = KontakteMitAdresseBindingSource;
            KontakteMitAdresseDataGridView.Location = new Point(1, 5);
            KontakteMitAdresseDataGridView.Name = "KontakteMitAdresseDataGridView";
            KontakteMitAdresseDataGridView.RowHeadersVisible = false;
            KontakteMitAdresseDataGridView.Size = new Size(885, 271);
            KontakteMitAdresseDataGridView.TabIndex = 2;
            // 
            // DataGridViewTextBoxColumn1
            // 
            DataGridViewTextBoxColumn1.DataPropertyName = "IDKontakt";
            DataGridViewTextBoxColumn1.HeaderText = "IDKontakt";
            DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            DataGridViewTextBoxColumn1.Width = 60;
            // 
            // DataGridViewTextBoxColumn11
            // 
            DataGridViewTextBoxColumn11.DataPropertyName = "Nachname";
            DataGridViewTextBoxColumn11.HeaderText = "Nachname";
            DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            // 
            // DataGridViewTextBoxColumn12
            // 
            DataGridViewTextBoxColumn12.DataPropertyName = "Vorname";
            DataGridViewTextBoxColumn12.HeaderText = "Vorname";
            DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            // 
            // DataGridViewTextBoxColumn13
            // 
            DataGridViewTextBoxColumn13.DataPropertyName = "EmailAddresse";
            DataGridViewTextBoxColumn13.HeaderText = "EmailAddresse";
            DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            DataGridViewTextBoxColumn13.Width = 120;
            // 
            // DataGridViewTextBoxColumn20
            // 
            DataGridViewTextBoxColumn20.DataPropertyName = "FirmenName";
            DataGridViewTextBoxColumn20.HeaderText = "FirmenName";
            DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20";
            DataGridViewTextBoxColumn20.Width = 300;
            // 
            // DataGridViewTextBoxColumn4
            // 
            DataGridViewTextBoxColumn4.DataPropertyName = "Straße";
            DataGridViewTextBoxColumn4.HeaderText = "Straße";
            DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            // 
            // DataGridViewTextBoxColumn5
            // 
            DataGridViewTextBoxColumn5.DataPropertyName = "Ort";
            DataGridViewTextBoxColumn5.HeaderText = "Ort";
            DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            // 
            // LBL_FirmenName
            // 
            LBL_FirmenName.AutoSize = true;
            LBL_FirmenName.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "FirmenName", true));
            LBL_FirmenName.Location = new Point(81, 14);
            LBL_FirmenName.Name = "LBL_FirmenName";
            LBL_FirmenName.Size = new Size(66, 13);
            LBL_FirmenName.TabIndex = 1;
            LBL_FirmenName.Text = "FirmenName";
            // 
            // LBL_IDKontakt
            // 
            LBL_IDKontakt.AutoSize = true;
            LBL_IDKontakt.DataBindings.Add(new Binding("Text", KontakteMitAdresseBindingSource, "IDKontakt", true));
            LBL_IDKontakt.Location = new Point(3, 14);
            LBL_IDKontakt.Name = "LBL_IDKontakt";
            LBL_IDKontakt.Size = new Size(55, 13);
            LBL_IDKontakt.TabIndex = 2;
            LBL_IDKontakt.Text = "IDKontakt";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 322);
            Controls.Add(KontakteMitAdresseDataGridView);
            Controls.Add(Panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form7";
            Text = "Personensuche";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)KontakteMitAdresseDataGridView).EndInit();
            Load += new EventHandler(Form7_Load);
            ResumeLayout(false);
        }

        internal Panel Panel1;
        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal BindingSource KontakteMitAdresseBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.KontakteMitAdresseTableAdapter KontakteMitAdresseTableAdapter;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal DataGridView KontakteMitAdresseDataGridView;
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

        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn20;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        internal Label LBL_FirmenName;
        internal Label LBL_IDKontakt;
    }
}