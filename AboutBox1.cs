using System;

namespace Adress_DB
{
    public sealed partial class AboutBox1
    {
        public AboutBox1()
        {
            InitializeComponent();
            _OKButton.Name = "OKButton";
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            // Legen Sie den Titel des Formulars fest.
            string ApplicationTitle;
            if (!string.IsNullOrEmpty(My.MyProject.Application.Info.Title))
            {
                ApplicationTitle = My.MyProject.Application.Info.Title;
            }
            else
            {
                ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.MyProject.Application.Info.AssemblyName);
            }

            Text = string.Format("Info {0}", ApplicationTitle);
            // Initialisieren Sie den gesamten Text, der im Infofeld angezeigt wird.
            // TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
            // Projekteigenschaften (im Menü "Projekt") anpassen.
            LabelProductName.Text = My.MyProject.Application.Info.ProductName;
            LabelVersion.Text = string.Format("Version {0}", My.MyProject.Application.Info.Version.ToString());
            LabelCopyright.Text = My.MyProject.Application.Info.Copyright;
            LabelCompanyName.Text = My.MyProject.Application.Info.CompanyName;
            TextBoxDescription.Text = My.MyProject.Application.Info.Description;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}