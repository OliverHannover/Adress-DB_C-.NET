using System;

namespace Adress_DB
{
    public partial class Personensuche
    {
        public Personensuche()
        {
            InitializeComponent();
            _Button1.Name = "Button1";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LBL_IDKontakt.Text = string.Empty;
            // LBL_FirmenName.Text = String.Empty

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((LBL_IDKontakt.Text ?? "") != (string.Empty ?? ""))
            {
                My.MyProject.Forms.Hauptform.TB_FirmenName.Text = LBL_FirmenName.Text;
                My.MyProject.Forms.Hauptform.BTN_Suche.PerformClick();
                int foundIndex = My.MyProject.Forms.Hauptform.KontakteBindingSource.Find("IDKontakt", LBL_IDKontakt.Text);
                // MsgBox(foundIndex & " " & IDBeleg)
                My.MyProject.Forms.Hauptform.KontakteBindingSource.Position = foundIndex;
            }

            Close();
        }
    }
}