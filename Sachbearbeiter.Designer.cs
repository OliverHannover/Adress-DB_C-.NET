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
    public partial class Sachbearbeiter : Form
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
            Label SachbearbeiterLabel;
            Label KuerzelLabel;
            Label DurchwahlLabel;
            Label EmailLabel;
            Label JobtitleLabel;
            Label EnglJobtitleLabel;
            Label AktivLabel;
            Label LoginLabel;
            Label AdminLabel;
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Sachbearbeiter));
            Panel1 = new Panel();
            Label1 = new Label();
            _WSL_AdressenDataSet = new _WSL_AdressenDataSet();
            _SachbearbeiterBindingSource = new BindingSource(components);
            _SachbearbeiterBindingSource.PositionChanged += new EventHandler(SachbearbeiterBindingSource_PositionChanged);
            SachbearbeiterTableAdapter = new _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            TableAdapterManager = new _WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            SachbearbeiterDataGridView = new DataGridView();
            IDSachbearbeiter = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            _BTN_Schliessen = new Button();
            _BTN_Schliessen.Click += new EventHandler(BTN_Schliessen_Click);
            Panel2 = new Panel();
            _BTN_NeuerSachbearbeiter = new Button();
            _BTN_NeuerSachbearbeiter.Click += new EventHandler(BTN_NeuerSachbearbeiter_Click);
            _BTN_Speichern = new Button();
            _BTN_Speichern.Click += new EventHandler(BTN_Speichern_Click);
            PNL_Edit = new Panel();
            lblBenutzerNeu = new Label();
            IDSachbearbeiterLabel1 = new Label();
            EnglJobtitleTextBox = new TextBox();
            PNL_Admin = new Panel();
            Label4 = new Label();
            LockedCheckBox = new CheckBox();
            AdminCheckBox = new CheckBox();
            SachbearbeiterTextBox = new TextBox();
            Label3 = new Label();
            Label2 = new Label();
            KuerzelTextBox = new TextBox();
            LoginTextBox = new TextBox();
            DurchwahlTextBox = new TextBox();
            AktivCheckBox = new CheckBox();
            EmailTextBox = new TextBox();
            JobtitleTextBox = new TextBox();
            TableLayoutPanel1 = new TableLayoutPanel();
            TableLayoutPanel2 = new TableLayoutPanel();
            SachbearbeiterLabel = new Label();
            KuerzelLabel = new Label();
            DurchwahlLabel = new Label();
            EmailLabel = new Label();
            JobtitleLabel = new Label();
            EnglJobtitleLabel = new Label();
            AktivLabel = new Label();
            LoginLabel = new Label();
            AdminLabel = new Label();
            Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_SachbearbeiterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterDataGridView).BeginInit();
            Panel2.SuspendLayout();
            PNL_Edit.SuspendLayout();
            PNL_Admin.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            TableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Location = new Point(14, 29);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new Size(82, 13);
            SachbearbeiterLabel.TabIndex = 3;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // KuerzelLabel
            // 
            KuerzelLabel.AutoSize = true;
            KuerzelLabel.Location = new Point(51, 55);
            KuerzelLabel.Name = "KuerzelLabel";
            KuerzelLabel.Size = new Size(45, 13);
            KuerzelLabel.TabIndex = 5;
            KuerzelLabel.Text = "Kuerzel:";
            // 
            // DurchwahlLabel
            // 
            DurchwahlLabel.AutoSize = true;
            DurchwahlLabel.Location = new Point(35, 107);
            DurchwahlLabel.Name = "DurchwahlLabel";
            DurchwahlLabel.Size = new Size(61, 13);
            DurchwahlLabel.TabIndex = 7;
            DurchwahlLabel.Text = "Durchwahl:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(61, 133);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(35, 13);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email:";
            // 
            // JobtitleLabel
            // 
            JobtitleLabel.AutoSize = true;
            JobtitleLabel.Location = new Point(14, 156);
            JobtitleLabel.Name = "JobtitleLabel";
            JobtitleLabel.Size = new Size(85, 13);
            JobtitleLabel.TabIndex = 11;
            JobtitleLabel.Text = "Jobtitel/Position:";
            // 
            // EnglJobtitleLabel
            // 
            EnglJobtitleLabel.AutoSize = true;
            EnglJobtitleLabel.Location = new Point(14, 185);
            EnglJobtitleLabel.Name = "EnglJobtitleLabel";
            EnglJobtitleLabel.Size = new Size(85, 13);
            EnglJobtitleLabel.TabIndex = 13;
            EnglJobtitleLabel.Text = "Jobtitel/Position:";
            // 
            // AktivLabel
            // 
            AktivLabel.AutoSize = true;
            AktivLabel.Location = new Point(99, 217);
            AktivLabel.Name = "AktivLabel";
            AktivLabel.Size = new Size(121, 13);
            AktivLabel.TabIndex = 15;
            AktivLabel.Text = "Sachbearbeiter ist aktiv:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(60, 81);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(36, 13);
            LoginLabel.TabIndex = 17;
            LoginLabel.Text = "Login:";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new Point(3, 9);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(127, 13);
            AdminLabel.TabIndex = 19;
            AdminLabel.Text = "Sachbearbeiter ist Admin:";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Silver;
            Panel1.Controls.Add(Label1);
            Panel1.Dock = DockStyle.Fill;
            Panel1.Location = new Point(3, 3);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(635, 38);
            Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            Label1.ForeColor = Color.Black;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(182, 20);
            Label1.TabIndex = 1;
            Label1.Text = "Benutzerliste bearbeiten";
            // 
            // _WSL_AdressenDataSet
            // 
            _WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            _WSL_AdressenDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // SachbearbeiterBindingSource
            // 
            _SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            _SachbearbeiterBindingSource.DataSource = _WSL_AdressenDataSet;
            // 
            // SachbearbeiterTableAdapter
            // 
            SachbearbeiterTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            TableAdapterManager.AdressenTableAdapter = null;
            TableAdapterManager.BackupDataSetBeforeUpdate = false;
            TableAdapterManager.BelegeTableAdapter = null;
            TableAdapterManager.FirmenNameTableAdapter = null;
            TableAdapterManager.KontakteTableAdapter = null;
            TableAdapterManager.KontoTableAdapter = null;
            TableAdapterManager.LogTabelleTableAdapter = null;
            TableAdapterManager.SachbearbeiterTableAdapter = SachbearbeiterTableAdapter;
            TableAdapterManager.UpdateOrder = _WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SachbearbeiterDataGridView
            // 
            SachbearbeiterDataGridView.AllowUserToAddRows = false;
            SachbearbeiterDataGridView.AllowUserToDeleteRows = false;
            SachbearbeiterDataGridView.AutoGenerateColumns = false;
            SachbearbeiterDataGridView.BackgroundColor = Color.White;
            SachbearbeiterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SachbearbeiterDataGridView.Columns.AddRange(new DataGridViewColumn[] { IDSachbearbeiter, DataGridViewTextBoxColumn2 });
            SachbearbeiterDataGridView.DataSource = _SachbearbeiterBindingSource;
            SachbearbeiterDataGridView.Dock = DockStyle.Fill;
            SachbearbeiterDataGridView.GridColor = Color.White;
            SachbearbeiterDataGridView.Location = new Point(3, 3);
            SachbearbeiterDataGridView.Name = "SachbearbeiterDataGridView";
            SachbearbeiterDataGridView.RowHeadersVisible = false;
            SachbearbeiterDataGridView.ScrollBars = ScrollBars.Vertical;
            SachbearbeiterDataGridView.Size = new Size(204, 354);
            SachbearbeiterDataGridView.TabIndex = 1;
            // 
            // IDSachbearbeiter
            // 
            IDSachbearbeiter.DataPropertyName = "IDSachbearbeiter";
            IDSachbearbeiter.HeaderText = "ID";
            IDSachbearbeiter.Name = "IDSachbearbeiter";
            IDSachbearbeiter.ReadOnly = true;
            IDSachbearbeiter.SortMode = DataGridViewColumnSortMode.NotSortable;
            IDSachbearbeiter.Width = 30;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.DataPropertyName = "Sachbearbeiter";
            DataGridViewTextBoxColumn2.HeaderText = "Sachbearbeiter";
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            DataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewTextBoxColumn2.Width = 170;
            // 
            // BTN_Schliessen
            // 
            _BTN_Schliessen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Schliessen.Image = My.Resources.Resources.CloseSolution_16x;
            _BTN_Schliessen.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Schliessen.Location = new Point(549, 10);
            _BTN_Schliessen.Name = "_BTN_Schliessen";
            _BTN_Schliessen.Size = new Size(75, 23);
            _BTN_Schliessen.TabIndex = 9;
            _BTN_Schliessen.Text = "schließen";
            _BTN_Schliessen.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Schliessen.UseVisualStyleBackColor = true;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Panel2.BackColor = Color.Gray;
            Panel2.Controls.Add(_BTN_Schliessen);
            Panel2.Controls.Add(_BTN_NeuerSachbearbeiter);
            Panel2.Controls.Add(_BTN_Speichern);
            Panel2.Location = new Point(3, 413);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(635, 43);
            Panel2.TabIndex = 24;
            // 
            // BTN_NeuerSachbearbeiter
            // 
            _BTN_NeuerSachbearbeiter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_NeuerSachbearbeiter.Image = My.Resources.Resources.AddUser_16x;
            _BTN_NeuerSachbearbeiter.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_NeuerSachbearbeiter.Location = new Point(213, 10);
            _BTN_NeuerSachbearbeiter.Name = "_BTN_NeuerSachbearbeiter";
            _BTN_NeuerSachbearbeiter.Size = new Size(106, 23);
            _BTN_NeuerSachbearbeiter.TabIndex = 27;
            _BTN_NeuerSachbearbeiter.Text = "Neuer Benutzer";
            _BTN_NeuerSachbearbeiter.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_NeuerSachbearbeiter.UseVisualStyleBackColor = true;
            // 
            // BTN_Speichern
            // 
            _BTN_Speichern.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _BTN_Speichern.Image = My.Resources.Resources.Save_16x;
            _BTN_Speichern.ImageAlign = ContentAlignment.MiddleRight;
            _BTN_Speichern.Location = new Point(379, 10);
            _BTN_Speichern.Name = "_BTN_Speichern";
            _BTN_Speichern.Size = new Size(106, 23);
            _BTN_Speichern.TabIndex = 28;
            _BTN_Speichern.Text = "speichern";
            _BTN_Speichern.TextAlign = ContentAlignment.MiddleLeft;
            _BTN_Speichern.UseVisualStyleBackColor = true;
            // 
            // PNL_Edit
            // 
            PNL_Edit.Controls.Add(lblBenutzerNeu);
            PNL_Edit.Controls.Add(IDSachbearbeiterLabel1);
            PNL_Edit.Controls.Add(EnglJobtitleTextBox);
            PNL_Edit.Controls.Add(PNL_Admin);
            PNL_Edit.Controls.Add(SachbearbeiterTextBox);
            PNL_Edit.Controls.Add(Label3);
            PNL_Edit.Controls.Add(SachbearbeiterLabel);
            PNL_Edit.Controls.Add(Label2);
            PNL_Edit.Controls.Add(KuerzelTextBox);
            PNL_Edit.Controls.Add(LoginLabel);
            PNL_Edit.Controls.Add(KuerzelLabel);
            PNL_Edit.Controls.Add(LoginTextBox);
            PNL_Edit.Controls.Add(DurchwahlTextBox);
            PNL_Edit.Controls.Add(AktivLabel);
            PNL_Edit.Controls.Add(DurchwahlLabel);
            PNL_Edit.Controls.Add(AktivCheckBox);
            PNL_Edit.Controls.Add(EmailTextBox);
            PNL_Edit.Controls.Add(EnglJobtitleLabel);
            PNL_Edit.Controls.Add(EmailLabel);
            PNL_Edit.Controls.Add(JobtitleTextBox);
            PNL_Edit.Controls.Add(JobtitleLabel);
            PNL_Edit.Dock = DockStyle.Fill;
            PNL_Edit.Location = new Point(213, 3);
            PNL_Edit.Name = "PNL_Edit";
            PNL_Edit.Size = new Size(419, 354);
            PNL_Edit.TabIndex = 26;
            // 
            // lblBenutzerNeu
            // 
            lblBenutzerNeu.AutoSize = true;
            lblBenutzerNeu.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lblBenutzerNeu.ForeColor = Color.Red;
            lblBenutzerNeu.Location = new Point(99, 8);
            lblBenutzerNeu.Name = "lblBenutzerNeu";
            lblBenutzerNeu.Size = new Size(33, 13);
            lblBenutzerNeu.TabIndex = 29;
            lblBenutzerNeu.Text = "NEU";
            lblBenutzerNeu.Visible = false;
            // 
            // IDSachbearbeiterLabel1
            // 
            IDSachbearbeiterLabel1.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "IDSachbearbeiter", true));
            IDSachbearbeiterLabel1.Location = new Point(346, 29);
            IDSachbearbeiterLabel1.Name = "IDSachbearbeiterLabel1";
            IDSachbearbeiterLabel1.Size = new Size(52, 17);
            IDSachbearbeiterLabel1.TabIndex = 26;
            IDSachbearbeiterLabel1.Text = "ID";
            // 
            // EnglJobtitleTextBox
            // 
            EnglJobtitleTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "EnglJobtitle", true));
            EnglJobtitleTextBox.Location = new Point(102, 182);
            EnglJobtitleTextBox.Name = "EnglJobtitleTextBox";
            EnglJobtitleTextBox.Size = new Size(238, 20);
            EnglJobtitleTextBox.TabIndex = 8;
            // 
            // PNL_Admin
            // 
            PNL_Admin.BackColor = Color.MistyRose;
            PNL_Admin.Controls.Add(Label4);
            PNL_Admin.Controls.Add(LockedCheckBox);
            PNL_Admin.Controls.Add(AdminLabel);
            PNL_Admin.Controls.Add(AdminCheckBox);
            PNL_Admin.Enabled = false;
            PNL_Admin.Location = new Point(102, 242);
            PNL_Admin.Name = "PNL_Admin";
            PNL_Admin.Size = new Size(159, 52);
            PNL_Admin.TabIndex = 25;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(78, 33);
            Label4.Name = "Label4";
            Label4.Size = new Size(50, 13);
            Label4.TabIndex = 27;
            Label4.Text = "blockiert:";
            // 
            // LockedCheckBox
            // 
            LockedCheckBox.DataBindings.Add(new Binding("CheckState", _SachbearbeiterBindingSource, "locked", true));
            LockedCheckBox.Location = new Point(136, 31);
            LockedCheckBox.Name = "LockedCheckBox";
            LockedCheckBox.Size = new Size(17, 18);
            LockedCheckBox.TabIndex = 26;
            LockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckBox
            // 
            AdminCheckBox.DataBindings.Add(new Binding("CheckState", _SachbearbeiterBindingSource, "Admin", true));
            AdminCheckBox.Location = new Point(136, 4);
            AdminCheckBox.Name = "AdminCheckBox";
            AdminCheckBox.Size = new Size(17, 24);
            AdminCheckBox.TabIndex = 20;
            AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterTextBox
            // 
            SachbearbeiterTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Sachbearbeiter", true));
            SachbearbeiterTextBox.Location = new Point(102, 26);
            SachbearbeiterTextBox.Name = "SachbearbeiterTextBox";
            SachbearbeiterTextBox.Size = new Size(238, 20);
            SachbearbeiterTextBox.TabIndex = 2;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(346, 185);
            Label3.Name = "Label3";
            Label3.Size = new Size(52, 13);
            Label3.TabIndex = 22;
            Label3.Text = "(englisch)";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(346, 159);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 13);
            Label2.TabIndex = 21;
            Label2.Text = "(deutsch)";
            // 
            // KuerzelTextBox
            // 
            KuerzelTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Kuerzel", true));
            KuerzelTextBox.Location = new Point(102, 52);
            KuerzelTextBox.Name = "KuerzelTextBox";
            KuerzelTextBox.Size = new Size(238, 20);
            KuerzelTextBox.TabIndex = 3;
            // 
            // LoginTextBox
            // 
            LoginTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Login", true));
            LoginTextBox.Location = new Point(102, 78);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(238, 20);
            LoginTextBox.TabIndex = 4;
            // 
            // DurchwahlTextBox
            // 
            DurchwahlTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Durchwahl", true));
            DurchwahlTextBox.Location = new Point(102, 104);
            DurchwahlTextBox.Name = "DurchwahlTextBox";
            DurchwahlTextBox.Size = new Size(238, 20);
            DurchwahlTextBox.TabIndex = 5;
            // 
            // AktivCheckBox
            // 
            AktivCheckBox.DataBindings.Add(new Binding("CheckState", _SachbearbeiterBindingSource, "Aktiv", true));
            AktivCheckBox.Location = new Point(231, 212);
            AktivCheckBox.Name = "AktivCheckBox";
            AktivCheckBox.Size = new Size(104, 24);
            AktivCheckBox.TabIndex = 16;
            AktivCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            EmailTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Email", true));
            EmailTextBox.Location = new Point(102, 130);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(238, 20);
            EmailTextBox.TabIndex = 6;
            // 
            // JobtitleTextBox
            // 
            JobtitleTextBox.DataBindings.Add(new Binding("Text", _SachbearbeiterBindingSource, "Jobtitle", true));
            JobtitleTextBox.Location = new Point(102, 156);
            JobtitleTextBox.Name = "JobtitleTextBox";
            JobtitleTextBox.Size = new Size(238, 20);
            JobtitleTextBox.TabIndex = 7;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 38.0f));
            TableLayoutPanel1.Controls.Add(Panel1, 0, 0);
            TableLayoutPanel1.Controls.Add(Panel2, 0, 2);
            TableLayoutPanel1.Controls.Add(TableLayoutPanel2, 0, 1);
            TableLayoutPanel1.Location = new Point(1, 1);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 3;
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 61.29032f));
            TableLayoutPanel1.RowStyles.Add(new RowStyle());
            TableLayoutPanel1.Size = new Size(641, 459);
            TableLayoutPanel1.TabIndex = 27;
            // 
            // TableLayoutPanel2
            // 
            TableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TableLayoutPanel2.ColumnCount = 2;
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.13679f));
            TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.8632f));
            TableLayoutPanel2.Controls.Add(PNL_Edit, 1, 0);
            TableLayoutPanel2.Controls.Add(SachbearbeiterDataGridView, 0, 0);
            TableLayoutPanel2.Location = new Point(3, 47);
            TableLayoutPanel2.Name = "TableLayoutPanel2";
            TableLayoutPanel2.RowCount = 1;
            TableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel2.Size = new Size(635, 360);
            TableLayoutPanel2.TabIndex = 25;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 459);
            Controls.Add(TableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Benutzerliste";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_WSL_AdressenDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)_SachbearbeiterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SachbearbeiterDataGridView).EndInit();
            Panel2.ResumeLayout(false);
            PNL_Edit.ResumeLayout(false);
            PNL_Edit.PerformLayout();
            PNL_Admin.ResumeLayout(false);
            PNL_Admin.PerformLayout();
            TableLayoutPanel1.ResumeLayout(false);
            TableLayoutPanel2.ResumeLayout(false);
            Load += new EventHandler(Form5_Load);
            ResumeLayout(false);
        }

        internal Panel Panel1;
        internal Label Label1;
        internal _WSL_AdressenDataSet _WSL_AdressenDataSet;
        private BindingSource _SachbearbeiterBindingSource;

        internal BindingSource SachbearbeiterBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SachbearbeiterBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SachbearbeiterBindingSource != null)
                {
                    _SachbearbeiterBindingSource.PositionChanged -= SachbearbeiterBindingSource_PositionChanged;
                }

                _SachbearbeiterBindingSource = value;
                if (_SachbearbeiterBindingSource != null)
                {
                    _SachbearbeiterBindingSource.PositionChanged += SachbearbeiterBindingSource_PositionChanged;
                }
            }
        }

        internal _WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter SachbearbeiterTableAdapter;
        internal _WSL_AdressenDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal DataGridView SachbearbeiterDataGridView;
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

        internal Panel Panel2;
        internal Panel PNL_Edit;
        internal TextBox EnglJobtitleTextBox;
        internal Panel PNL_Admin;
        internal CheckBox AdminCheckBox;
        internal TextBox SachbearbeiterTextBox;
        internal Label Label3;
        internal Label Label2;
        internal TextBox KuerzelTextBox;
        internal TextBox LoginTextBox;
        internal TextBox DurchwahlTextBox;
        internal CheckBox AktivCheckBox;
        internal TextBox EmailTextBox;
        internal TextBox JobtitleTextBox;
        internal Label Label4;
        internal CheckBox LockedCheckBox;
        internal Label IDSachbearbeiterLabel1;
        internal DataGridViewTextBoxColumn IDSachbearbeiter;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal TableLayoutPanel TableLayoutPanel1;
        internal TableLayoutPanel TableLayoutPanel2;
        private Button _BTN_NeuerSachbearbeiter;

        internal Button BTN_NeuerSachbearbeiter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_NeuerSachbearbeiter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_NeuerSachbearbeiter != null)
                {
                    _BTN_NeuerSachbearbeiter.Click -= BTN_NeuerSachbearbeiter_Click;
                }

                _BTN_NeuerSachbearbeiter = value;
                if (_BTN_NeuerSachbearbeiter != null)
                {
                    _BTN_NeuerSachbearbeiter.Click += BTN_NeuerSachbearbeiter_Click;
                }
            }
        }

        private Button _BTN_Speichern;

        internal Button BTN_Speichern
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BTN_Speichern;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BTN_Speichern != null)
                {
                    _BTN_Speichern.Click -= BTN_Speichern_Click;
                }

                _BTN_Speichern = value;
                if (_BTN_Speichern != null)
                {
                    _BTN_Speichern.Click += BTN_Speichern_Click;
                }
            }
        }

        internal Label lblBenutzerNeu;
    }
}