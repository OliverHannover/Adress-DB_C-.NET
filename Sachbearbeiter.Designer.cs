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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label SachbearbeiterLabel;
            System.Windows.Forms.Label KuerzelLabel;
            System.Windows.Forms.Label DurchwahlLabel;
            System.Windows.Forms.Label EmailLabel;
            System.Windows.Forms.Label JobtitleLabel;
            System.Windows.Forms.Label EnglJobtitleLabel;
            System.Windows.Forms.Label AktivLabel;
            System.Windows.Forms.Label LoginLabel;
            System.Windows.Forms.Label AdminLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sachbearbeiter));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this._WSL_AdressenDataSet = new Adress_DB._WSL_AdressenDataSet();
            this._SachbearbeiterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SachbearbeiterTableAdapter = new Adress_DB._WSL_AdressenDataSetTableAdapters.SachbearbeiterTableAdapter();
            this.TableAdapterManager = new Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager();
            this.SachbearbeiterDataGridView = new System.Windows.Forms.DataGridView();
            this.IDSachbearbeiter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._BTN_Schliessen = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this._BTN_NeuerSachbearbeiter = new System.Windows.Forms.Button();
            this._BTN_Speichern = new System.Windows.Forms.Button();
            this.PNL_Edit = new System.Windows.Forms.Panel();
            this.lblBenutzerNeu = new System.Windows.Forms.Label();
            this.IDSachbearbeiterLabel1 = new System.Windows.Forms.Label();
            this.EnglJobtitleTextBox = new System.Windows.Forms.TextBox();
            this.PNL_Admin = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.LockedCheckBox = new System.Windows.Forms.CheckBox();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.SachbearbeiterTextBox = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.KuerzelTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.DurchwahlTextBox = new System.Windows.Forms.TextBox();
            this.AktivCheckBox = new System.Windows.Forms.CheckBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.JobtitleTextBox = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            SachbearbeiterLabel = new System.Windows.Forms.Label();
            KuerzelLabel = new System.Windows.Forms.Label();
            DurchwahlLabel = new System.Windows.Forms.Label();
            EmailLabel = new System.Windows.Forms.Label();
            JobtitleLabel = new System.Windows.Forms.Label();
            EnglJobtitleLabel = new System.Windows.Forms.Label();
            AktivLabel = new System.Windows.Forms.Label();
            LoginLabel = new System.Windows.Forms.Label();
            AdminLabel = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._SachbearbeiterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterDataGridView)).BeginInit();
            this.Panel2.SuspendLayout();
            this.PNL_Edit.SuspendLayout();
            this.PNL_Admin.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SachbearbeiterLabel
            // 
            SachbearbeiterLabel.AutoSize = true;
            SachbearbeiterLabel.Location = new System.Drawing.Point(14, 29);
            SachbearbeiterLabel.Name = "SachbearbeiterLabel";
            SachbearbeiterLabel.Size = new System.Drawing.Size(82, 13);
            SachbearbeiterLabel.TabIndex = 3;
            SachbearbeiterLabel.Text = "Sachbearbeiter:";
            // 
            // KuerzelLabel
            // 
            KuerzelLabel.AutoSize = true;
            KuerzelLabel.Location = new System.Drawing.Point(51, 55);
            KuerzelLabel.Name = "KuerzelLabel";
            KuerzelLabel.Size = new System.Drawing.Size(45, 13);
            KuerzelLabel.TabIndex = 5;
            KuerzelLabel.Text = "Kuerzel:";
            // 
            // DurchwahlLabel
            // 
            DurchwahlLabel.AutoSize = true;
            DurchwahlLabel.Location = new System.Drawing.Point(35, 107);
            DurchwahlLabel.Name = "DurchwahlLabel";
            DurchwahlLabel.Size = new System.Drawing.Size(61, 13);
            DurchwahlLabel.TabIndex = 7;
            DurchwahlLabel.Text = "Durchwahl:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new System.Drawing.Point(61, 133);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new System.Drawing.Size(35, 13);
            EmailLabel.TabIndex = 9;
            EmailLabel.Text = "Email:";
            // 
            // JobtitleLabel
            // 
            JobtitleLabel.AutoSize = true;
            JobtitleLabel.Location = new System.Drawing.Point(14, 156);
            JobtitleLabel.Name = "JobtitleLabel";
            JobtitleLabel.Size = new System.Drawing.Size(85, 13);
            JobtitleLabel.TabIndex = 11;
            JobtitleLabel.Text = "Jobtitel/Position:";
            // 
            // EnglJobtitleLabel
            // 
            EnglJobtitleLabel.AutoSize = true;
            EnglJobtitleLabel.Location = new System.Drawing.Point(14, 185);
            EnglJobtitleLabel.Name = "EnglJobtitleLabel";
            EnglJobtitleLabel.Size = new System.Drawing.Size(85, 13);
            EnglJobtitleLabel.TabIndex = 13;
            EnglJobtitleLabel.Text = "Jobtitel/Position:";
            // 
            // AktivLabel
            // 
            AktivLabel.AutoSize = true;
            AktivLabel.Location = new System.Drawing.Point(99, 217);
            AktivLabel.Name = "AktivLabel";
            AktivLabel.Size = new System.Drawing.Size(121, 13);
            AktivLabel.TabIndex = 15;
            AktivLabel.Text = "Sachbearbeiter ist aktiv:";
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new System.Drawing.Point(60, 81);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new System.Drawing.Size(36, 13);
            LoginLabel.TabIndex = 17;
            LoginLabel.Text = "Login:";
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Location = new System.Drawing.Point(3, 9);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new System.Drawing.Size(127, 13);
            AdminLabel.TabIndex = 19;
            AdminLabel.Text = "Sachbearbeiter ist Admin:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Location = new System.Drawing.Point(3, 3);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(635, 38);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(182, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Benutzerliste bearbeiten";
            // 
            // _WSL_AdressenDataSet
            // 
            this._WSL_AdressenDataSet.DataSetName = "_WSL_AdressenDataSet";
            this._WSL_AdressenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _SachbearbeiterBindingSource
            // 
            this._SachbearbeiterBindingSource.DataMember = "Sachbearbeiter";
            this._SachbearbeiterBindingSource.DataSource = this._WSL_AdressenDataSet;
            this._SachbearbeiterBindingSource.PositionChanged += new System.EventHandler(this.SachbearbeiterBindingSource_PositionChanged);
            // 
            // SachbearbeiterTableAdapter
            // 
            this.SachbearbeiterTableAdapter.ClearBeforeFill = true;
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
            this.TableAdapterManager.KontoTableAdapter = null;
            this.TableAdapterManager.LogTabelleTableAdapter = null;
            this.TableAdapterManager.PLZ_GeodatenTableAdapter = null;
            this.TableAdapterManager.propertiesTableAdapter = null;
            this.TableAdapterManager.SachbearbeiterTableAdapter = this.SachbearbeiterTableAdapter;
            this.TableAdapterManager.StaatenTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = Adress_DB._WSL_AdressenDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // SachbearbeiterDataGridView
            // 
            this.SachbearbeiterDataGridView.AllowUserToAddRows = false;
            this.SachbearbeiterDataGridView.AllowUserToDeleteRows = false;
            this.SachbearbeiterDataGridView.AutoGenerateColumns = false;
            this.SachbearbeiterDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SachbearbeiterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SachbearbeiterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDSachbearbeiter,
            this.DataGridViewTextBoxColumn2});
            this.SachbearbeiterDataGridView.DataSource = this._SachbearbeiterBindingSource;
            this.SachbearbeiterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SachbearbeiterDataGridView.GridColor = System.Drawing.Color.White;
            this.SachbearbeiterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.SachbearbeiterDataGridView.Name = "SachbearbeiterDataGridView";
            this.SachbearbeiterDataGridView.RowHeadersVisible = false;
            this.SachbearbeiterDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SachbearbeiterDataGridView.Size = new System.Drawing.Size(204, 354);
            this.SachbearbeiterDataGridView.TabIndex = 1;
            // 
            // IDSachbearbeiter
            // 
            this.IDSachbearbeiter.DataPropertyName = "IDSachbearbeiter";
            this.IDSachbearbeiter.HeaderText = "ID";
            this.IDSachbearbeiter.Name = "IDSachbearbeiter";
            this.IDSachbearbeiter.ReadOnly = true;
            this.IDSachbearbeiter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IDSachbearbeiter.Width = 30;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.DataPropertyName = "Sachbearbeiter";
            this.DataGridViewTextBoxColumn2.HeaderText = "Sachbearbeiter";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridViewTextBoxColumn2.Width = 170;
            // 
            // _BTN_Schliessen
            // 
            this._BTN_Schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Schliessen.Image = global::Adress_DB.My.Resources.Resources.Cancel_16x;
            this._BTN_Schliessen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Schliessen.Location = new System.Drawing.Point(542, 10);
            this._BTN_Schliessen.Name = "_BTN_Schliessen";
            this._BTN_Schliessen.Size = new System.Drawing.Size(82, 23);
            this._BTN_Schliessen.TabIndex = 9;
            this._BTN_Schliessen.Text = "Abbrechen";
            this._BTN_Schliessen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Schliessen.UseVisualStyleBackColor = true;
            this._BTN_Schliessen.Click += new System.EventHandler(this.BTN_Schliessen_Click);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.Gray;
            this.Panel2.Controls.Add(this._BTN_Schliessen);
            this.Panel2.Controls.Add(this._BTN_NeuerSachbearbeiter);
            this.Panel2.Controls.Add(this._BTN_Speichern);
            this.Panel2.Location = new System.Drawing.Point(3, 413);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(635, 43);
            this.Panel2.TabIndex = 24;
            // 
            // _BTN_NeuerSachbearbeiter
            // 
            this._BTN_NeuerSachbearbeiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_NeuerSachbearbeiter.Image = global::Adress_DB.My.Resources.Resources.AddUser_16x;
            this._BTN_NeuerSachbearbeiter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_NeuerSachbearbeiter.Location = new System.Drawing.Point(213, 10);
            this._BTN_NeuerSachbearbeiter.Name = "_BTN_NeuerSachbearbeiter";
            this._BTN_NeuerSachbearbeiter.Size = new System.Drawing.Size(106, 23);
            this._BTN_NeuerSachbearbeiter.TabIndex = 27;
            this._BTN_NeuerSachbearbeiter.Text = "Neuer Benutzer";
            this._BTN_NeuerSachbearbeiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_NeuerSachbearbeiter.UseVisualStyleBackColor = true;
            this._BTN_NeuerSachbearbeiter.Click += new System.EventHandler(this.BTN_NeuerSachbearbeiter_Click);
            // 
            // _BTN_Speichern
            // 
            this._BTN_Speichern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._BTN_Speichern.Image = global::Adress_DB.My.Resources.Resources.Save_16x;
            this._BTN_Speichern.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._BTN_Speichern.Location = new System.Drawing.Point(379, 10);
            this._BTN_Speichern.Name = "_BTN_Speichern";
            this._BTN_Speichern.Size = new System.Drawing.Size(106, 23);
            this._BTN_Speichern.TabIndex = 28;
            this._BTN_Speichern.Text = "speichern";
            this._BTN_Speichern.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._BTN_Speichern.UseVisualStyleBackColor = true;
            this._BTN_Speichern.Click += new System.EventHandler(this.BTN_Speichern_Click);
            // 
            // PNL_Edit
            // 
            this.PNL_Edit.Controls.Add(this.lblBenutzerNeu);
            this.PNL_Edit.Controls.Add(this.IDSachbearbeiterLabel1);
            this.PNL_Edit.Controls.Add(this.EnglJobtitleTextBox);
            this.PNL_Edit.Controls.Add(this.PNL_Admin);
            this.PNL_Edit.Controls.Add(this.SachbearbeiterTextBox);
            this.PNL_Edit.Controls.Add(this.Label3);
            this.PNL_Edit.Controls.Add(SachbearbeiterLabel);
            this.PNL_Edit.Controls.Add(this.Label2);
            this.PNL_Edit.Controls.Add(this.KuerzelTextBox);
            this.PNL_Edit.Controls.Add(LoginLabel);
            this.PNL_Edit.Controls.Add(KuerzelLabel);
            this.PNL_Edit.Controls.Add(this.LoginTextBox);
            this.PNL_Edit.Controls.Add(this.DurchwahlTextBox);
            this.PNL_Edit.Controls.Add(AktivLabel);
            this.PNL_Edit.Controls.Add(DurchwahlLabel);
            this.PNL_Edit.Controls.Add(this.AktivCheckBox);
            this.PNL_Edit.Controls.Add(this.EmailTextBox);
            this.PNL_Edit.Controls.Add(EnglJobtitleLabel);
            this.PNL_Edit.Controls.Add(EmailLabel);
            this.PNL_Edit.Controls.Add(this.JobtitleTextBox);
            this.PNL_Edit.Controls.Add(JobtitleLabel);
            this.PNL_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Edit.Location = new System.Drawing.Point(213, 3);
            this.PNL_Edit.Name = "PNL_Edit";
            this.PNL_Edit.Size = new System.Drawing.Size(419, 354);
            this.PNL_Edit.TabIndex = 26;
            // 
            // lblBenutzerNeu
            // 
            this.lblBenutzerNeu.AutoSize = true;
            this.lblBenutzerNeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzerNeu.ForeColor = System.Drawing.Color.Red;
            this.lblBenutzerNeu.Location = new System.Drawing.Point(99, 8);
            this.lblBenutzerNeu.Name = "lblBenutzerNeu";
            this.lblBenutzerNeu.Size = new System.Drawing.Size(33, 13);
            this.lblBenutzerNeu.TabIndex = 29;
            this.lblBenutzerNeu.Text = "NEU";
            this.lblBenutzerNeu.Visible = false;
            // 
            // IDSachbearbeiterLabel1
            // 
            this.IDSachbearbeiterLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "IDSachbearbeiter", true));
            this.IDSachbearbeiterLabel1.Location = new System.Drawing.Point(346, 29);
            this.IDSachbearbeiterLabel1.Name = "IDSachbearbeiterLabel1";
            this.IDSachbearbeiterLabel1.Size = new System.Drawing.Size(52, 17);
            this.IDSachbearbeiterLabel1.TabIndex = 26;
            this.IDSachbearbeiterLabel1.Text = "ID";
            // 
            // EnglJobtitleTextBox
            // 
            this.EnglJobtitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "EnglJobtitle", true));
            this.EnglJobtitleTextBox.Location = new System.Drawing.Point(102, 182);
            this.EnglJobtitleTextBox.Name = "EnglJobtitleTextBox";
            this.EnglJobtitleTextBox.Size = new System.Drawing.Size(238, 20);
            this.EnglJobtitleTextBox.TabIndex = 8;
            // 
            // PNL_Admin
            // 
            this.PNL_Admin.BackColor = System.Drawing.Color.MistyRose;
            this.PNL_Admin.Controls.Add(this.Label4);
            this.PNL_Admin.Controls.Add(this.LockedCheckBox);
            this.PNL_Admin.Controls.Add(AdminLabel);
            this.PNL_Admin.Controls.Add(this.AdminCheckBox);
            this.PNL_Admin.Enabled = false;
            this.PNL_Admin.Location = new System.Drawing.Point(102, 242);
            this.PNL_Admin.Name = "PNL_Admin";
            this.PNL_Admin.Size = new System.Drawing.Size(159, 52);
            this.PNL_Admin.TabIndex = 25;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(78, 33);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(50, 13);
            this.Label4.TabIndex = 27;
            this.Label4.Text = "blockiert:";
            // 
            // LockedCheckBox
            // 
            this.LockedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._SachbearbeiterBindingSource, "locked", true));
            this.LockedCheckBox.Location = new System.Drawing.Point(136, 31);
            this.LockedCheckBox.Name = "LockedCheckBox";
            this.LockedCheckBox.Size = new System.Drawing.Size(17, 18);
            this.LockedCheckBox.TabIndex = 26;
            this.LockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._SachbearbeiterBindingSource, "Admin", true));
            this.AdminCheckBox.Location = new System.Drawing.Point(136, 4);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(17, 24);
            this.AdminCheckBox.TabIndex = 20;
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // SachbearbeiterTextBox
            // 
            this.SachbearbeiterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Sachbearbeiter", true));
            this.SachbearbeiterTextBox.Location = new System.Drawing.Point(102, 26);
            this.SachbearbeiterTextBox.Name = "SachbearbeiterTextBox";
            this.SachbearbeiterTextBox.Size = new System.Drawing.Size(238, 20);
            this.SachbearbeiterTextBox.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(346, 185);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "(englisch)";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(346, 159);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 13);
            this.Label2.TabIndex = 21;
            this.Label2.Text = "(deutsch)";
            // 
            // KuerzelTextBox
            // 
            this.KuerzelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Kuerzel", true));
            this.KuerzelTextBox.Location = new System.Drawing.Point(102, 52);
            this.KuerzelTextBox.Name = "KuerzelTextBox";
            this.KuerzelTextBox.Size = new System.Drawing.Size(238, 20);
            this.KuerzelTextBox.TabIndex = 3;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Login", true));
            this.LoginTextBox.Location = new System.Drawing.Point(102, 78);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(238, 20);
            this.LoginTextBox.TabIndex = 4;
            // 
            // DurchwahlTextBox
            // 
            this.DurchwahlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Durchwahl", true));
            this.DurchwahlTextBox.Location = new System.Drawing.Point(102, 104);
            this.DurchwahlTextBox.Name = "DurchwahlTextBox";
            this.DurchwahlTextBox.Size = new System.Drawing.Size(238, 20);
            this.DurchwahlTextBox.TabIndex = 5;
            // 
            // AktivCheckBox
            // 
            this.AktivCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this._SachbearbeiterBindingSource, "Aktiv", true));
            this.AktivCheckBox.Location = new System.Drawing.Point(231, 212);
            this.AktivCheckBox.Name = "AktivCheckBox";
            this.AktivCheckBox.Size = new System.Drawing.Size(104, 24);
            this.AktivCheckBox.TabIndex = 16;
            this.AktivCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Email", true));
            this.EmailTextBox.Location = new System.Drawing.Point(102, 130);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(238, 20);
            this.EmailTextBox.TabIndex = 6;
            // 
            // JobtitleTextBox
            // 
            this.JobtitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._SachbearbeiterBindingSource, "Jobtitle", true));
            this.JobtitleTextBox.Location = new System.Drawing.Point(102, 156);
            this.JobtitleTextBox.Name = "JobtitleTextBox";
            this.JobtitleTextBox.Size = new System.Drawing.Size(238, 20);
            this.JobtitleTextBox.TabIndex = 7;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.TableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 3;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.29032F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.Size = new System.Drawing.Size(641, 459);
            this.TableLayoutPanel1.TabIndex = 27;
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.13679F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.8632F));
            this.TableLayoutPanel2.Controls.Add(this.PNL_Edit, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.SachbearbeiterDataGridView, 0, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 47);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(635, 360);
            this.TableLayoutPanel2.TabIndex = 25;
            // 
            // Sachbearbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 459);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sachbearbeiter";
            this.Text = "Benutzerliste";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._WSL_AdressenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._SachbearbeiterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SachbearbeiterDataGridView)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.PNL_Edit.ResumeLayout(false);
            this.PNL_Edit.PerformLayout();
            this.PNL_Admin.ResumeLayout(false);
            this.PNL_Admin.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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