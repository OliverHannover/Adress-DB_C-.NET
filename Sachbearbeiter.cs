using System;
using System.Drawing;
using System.Windows.Forms;

namespace Adress_DB
{
    public partial class Sachbearbeiter
    {
        public Sachbearbeiter()
        {
            InitializeComponent();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "_WSL_AdressenDataSet.Sachbearbeiter". Sie können sie bei Bedarf verschieben oder entfernen.
            SachbearbeiterTableAdapter.Fill(_WSL_AdressenDataSet.Sachbearbeiter);
            int foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            SachbearbeiterBindingSource.Position = foundIndex;
            if (AdminCheckBox.Checked == true)
            {
                PNL_Admin.Enabled = true;
            }

            lblBenutzerNeu.Visible = false;
        }

        private void BTN_Schliessen_Click(object sender, EventArgs e)
        {
            int foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            // MsgBox(foundIndex)
            if (foundIndex != -1)
            {
                // Tabelle ist noch mit ALLEN Usern gefüllt!...
                My.MyProject.Forms.Hauptform.SachbearbeiterBindingSource.Position = My.MyProject.Forms.Hauptform.SachbearbeiterBindingSource.Find("Login", Environment.UserName);
                My.MyProject.Forms.Hauptform.lblUser.ForeColor = Color.Black;
                My.MyProject.Forms.Hauptform.lblUser.Text = SachbearbeiterTableAdapter.ScalarSachbearbeiter(foundIndex + 1);

                // anschließend Tabelle mit aktiven Usern füllen und den gefundenen markieren:
                My.MyProject.Forms.Hauptform.SachbearbeiterTableAdapter.FillByAktive(My.MyProject.Forms.Hauptform._WSL_AdressenDataSet.Sachbearbeiter);
                My.MyProject.Forms.Hauptform.SachbearbeiterBindingSource.Position = My.MyProject.Forms.Hauptform.SachbearbeiterBindingSource.Find("Login", Environment.UserName);
                My.MyProject.Forms.Hauptform.BTN_Speichern.Visible = true;
                My.MyProject.Forms.Hauptform.BTN_DocErzeugen.Visible = true;
            }
            else
            {
                MessageBox.Show("Ihr Login wurde nicht erkannt. Bitte Ihre Benutzerdaten prüfen/korrigieren oder ergänzen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.Hauptform.lblUser.Text = "Sachbearbeiter nicht erkannt";
                My.MyProject.Forms.Hauptform.lblUser.ForeColor = Color.Red;
                My.MyProject.Forms.Hauptform.BTN_Speichern.Visible = false;
                My.MyProject.Forms.Hauptform.BTN_DocErzeugen.Visible = false;
              
            }

            Close();
        }

        private void SachbearbeiterBindingSource_PositionChanged(object sender, EventArgs e)
        {
            // MsgBox(SachbearbeiterBindingSource.Position)
            switch (SachbearbeiterBindingSource.Position)
            {
                case var @case when 0 <= @case && @case <= 1:
                    {
                        PNL_Edit.Enabled = false;
                        break;
                    }

                default:
                    {
                        PNL_Edit.Enabled = Enabled;
                        break;
                    }
            }
        }

        private void BTN_NeuerSachbearbeiter_Click(object sender, EventArgs e)
        {
            lblBenutzerNeu.Visible = true;
            {
                var withBlock = SachbearbeiterTextBox;
                withBlock.DataBindings.Clear();
                withBlock.Text = string.Empty;
            }

            {
                var withBlock1 = KuerzelTextBox;
                withBlock1.DataBindings.Clear();
                withBlock1.Text = string.Empty;
            }

            {
                var withBlock2 = LoginTextBox;
                withBlock2.DataBindings.Clear();
                withBlock2.Text = Environment.UserName;
            }

            {
                var withBlock3 = DurchwahlTextBox;
                withBlock3.DataBindings.Clear();
                withBlock3.Text = string.Empty;
            }

            {
                var withBlock4 = EmailTextBox;
                withBlock4.DataBindings.Clear();
                withBlock4.Text = string.Empty;
            }

            {
                var withBlock5 = JobtitleTextBox;
                withBlock5.DataBindings.Clear();
                withBlock5.Text = string.Empty;
            }

            {
                var withBlock6 = EnglJobtitleTextBox;
                withBlock6.DataBindings.Clear();
                withBlock6.Text = string.Empty;
            }
        }

        private void BTN_Speichern_Click(object sender, EventArgs e)
        {

            // Prüfen, ob alle Felder ausgefüllt wurden
            foreach (Control ctrl in PNL_Edit.Controls)
            {
                if (ctrl is TextBox & (ctrl.Text  == string.Empty ))
                {
                    MessageBox.Show("Bitte alle Felder ausfüllen!");
                    return;
                }
            }

            if (lblBenutzerNeu.Visible == true)
            {
                SachbearbeiterTableAdapter.Insert(SachbearbeiterTextBox.Text, LoginTextBox.Text, KuerzelTextBox.Text, Convert.ToDouble(DurchwahlTextBox.Text), EmailTextBox.Text, JobtitleTextBox.Text, EnglJobtitleTextBox.Text, AktivCheckBox.Checked, false, false);
            }
            // MessageBox.Show("insert")
            else if (lblBenutzerNeu.Visible == false)
            {
                try
                {
                    Validate();
                    SachbearbeiterBindingSource.EndEdit();
                    SachbearbeiterTableAdapter.Update(_WSL_AdressenDataSet.Sachbearbeiter);
                }

                // MsgBox("update " & CInt(IDSachbearbeiterLabel1.Text))
                catch (Exception ex)
                {
                    MessageBox.Show("Update des Sachbearbeiters fehlgeschlagen", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(ex.Message);
                }
            }

            SachbearbeiterTableAdapter.Fill(_WSL_AdressenDataSet.Sachbearbeiter);
            {
                var withBlock = SachbearbeiterTextBox;
                withBlock.DataBindings.Clear();
                withBlock.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Sachbearbeiter", true));
            }

            {
                var withBlock1 = KuerzelTextBox;
                withBlock1.DataBindings.Clear();
                withBlock1.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Kuerzel", true));
            }

            {
                var withBlock2 = LoginTextBox;
                withBlock2.DataBindings.Clear();
                withBlock2.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Login", true));
            }

            {
                var withBlock3 = DurchwahlTextBox;
                withBlock3.DataBindings.Clear();
                withBlock3.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Durchwahl", true));
            }

            {
                var withBlock4 = EmailTextBox;
                withBlock4.DataBindings.Clear();
                withBlock4.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Email", true));
            }

            {
                var withBlock5 = JobtitleTextBox;
                withBlock5.DataBindings.Clear();
                withBlock5.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "Jobtitle", true));
            }

            {
                var withBlock6 = EnglJobtitleTextBox;
                withBlock6.DataBindings.Clear();
                withBlock6.DataBindings.Add(new Binding("Text", SachbearbeiterBindingSource, "EnglJobtitle", true));
            }

            int foundIndex = SachbearbeiterBindingSource.Find("Login", Environment.UserName);
            SachbearbeiterBindingSource.Position = foundIndex;
            lblBenutzerNeu.Visible = false;
        }
    }
}