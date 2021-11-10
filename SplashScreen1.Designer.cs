using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Adress_DB
{
    [DesignerGenerated()]
    public partial class SplashScreen1 : Form
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

        internal Label Version;
        internal Label Copyright;
        internal TableLayoutPanel MainLayoutPanel;
        internal TableLayoutPanel DetailsLayoutPanel;

        // Wird vom Windows Form-Designer benötigt.
        private System.ComponentModel.IContainer components;

        // Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
        // Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
        // Das Bearbeiten mit dem Code-Editor ist nicht möglich.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MainLayoutPanel = new TableLayoutPanel();
            DetailsLayoutPanel = new TableLayoutPanel();
            Version = new Label();
            Copyright = new Label();
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            SachbearbeiterBindingSource = new BindingSource(components);
            SachbearbeiterTableAdapter = new _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            MainLayoutPanel.SuspendLayout();
            DetailsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingSource).BeginInit();
            SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.BackgroundImage = My.Resources.Resources.SplashScreen;
            MainLayoutPanel.BackgroundImageLayout = ImageLayout.Stretch;
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243.0f));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100.0f));
            MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 2;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 218.0f));
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38.0f));
            MainLayoutPanel.Size = new Size(496, 303);
            MainLayoutPanel.TabIndex = 0;
            // 
            // DetailsLayoutPanel
            // 
            DetailsLayoutPanel.Anchor = AnchorStyles.None;
            DetailsLayoutPanel.BackColor = Color.Transparent;
            DetailsLayoutPanel.ColumnCount = 1;
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 247.0f));
            DetailsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 142.0f));
            DetailsLayoutPanel.Controls.Add(Version, 0, 0);
            DetailsLayoutPanel.Controls.Add(Copyright, 0, 1);
            DetailsLayoutPanel.Location = new Point(246, 221);
            DetailsLayoutPanel.Name = "DetailsLayoutPanel";
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0f));
            DetailsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0f));
            DetailsLayoutPanel.Size = new Size(247, 79);
            DetailsLayoutPanel.TabIndex = 1;
            // 
            // Version
            // 
            Version.Anchor = AnchorStyles.None;
            Version.BackColor = Color.Transparent;
            Version.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Version.ForeColor = SystemColors.ControlDarkDark;
            Version.Location = new Point(3, 9);
            Version.Name = "Version";
            Version.Size = new Size(241, 20);
            Version.TabIndex = 1;
            Version.Text = "Version {0}.{1:00}";
            // 
            // Copyright
            // 
            Copyright.Anchor = AnchorStyles.None;
            Copyright.BackColor = Color.Transparent;
            Copyright.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Copyright.ForeColor = SystemColors.ControlDarkDark;
            Copyright.Location = new Point(3, 39);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(241, 40);
            Copyright.TabIndex = 2;
            Copyright.Text = "Copyright";
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // SachbearbeiterBindingSource
            // 
            SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            SachbearbeiterBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // SachbearbeiterTableAdapter
            // 
            SachbearbeiterTableAdapter.ClearBeforeFill = true;
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
            TableAdapterManager.KonfigurationTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = null;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = SachbearbeiterTableAdapter;
            TableAdapterManager.StaatenTableAdapter = null;
            TableAdapterManager.UpdateOrder = _WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SplashScreen1
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(496, 303);
            ControlBox = false;
            Controls.Add(MainLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashScreen1";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            MainLayoutPanel.ResumeLayout(false);
            DetailsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterBindingSource).EndInit();
            Load += new EventHandler(SplashScreen1_Load);
            ResumeLayout(false);
        }

        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        internal BindingSource SachbearbeiterBindingSource;
        internal _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter SachbearbeiterTableAdapter;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
    }
}