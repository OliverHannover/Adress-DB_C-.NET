using System;

namespace Adress_DB
{
    public sealed partial class SplashScreen1
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        // TODO: Dieses Formular kann einfach als Begrüßungsbildschirm für die Anwendung festgelegt werden, indem Sie zur Registerkarte "Anwendung"
        // des Projekt-Designers wechseln (Menü "Projekt", Option "Eigenschaften").


        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            // Richten Sie den Dialogtext zur Laufzeit gemäß den Assemblyinformationen der Anwendung ein.  

            // TODO: Die Assemblyinformationen der Anwendung im Bereich "Anwendung" des Dialogfelds für die 
            // Projekteigenschaften (im Menü "Projekt") anpassen.

            // Anwendungstitel
            // If My.Application.Info.Title <> "" Then
            // ApplicationTitle.Text = My.Application.Info.Title
            // Else
            // 'Wenn der Anwendungstitel fehlt, Anwendungsnamen ohne Erweiterung verwenden
            // ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            // End If

            // Verwenden Sie zum Formatieren der Versionsinformationen den Text, der zur Entwurfszeit in der Versionskontrolle festgelegt wurde, als
            // Formatierungszeichenfolge. Dies ermöglicht ggf. eine effektive Lokalisierung.
            // Build- und Revisionsinformationen können durch Verwendung des folgenden Codes und durch Ändern 
            // des Entwurfszeittexts der Versionskontrolle in "Version {0}.{1:00}.{2}.{3}" oder einen ähnlichen Text eingeschlossen werden.  Weitere Informationen erhalten Sie unter
            // String.Format() in der Hilfe.
            // 
            // Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

            Version.Text = string.Format(Version.Text, My.MyProject.Application.Info.Version.Major, My.MyProject.Application.Info.Version.Minor);

            // Copyrightinformationen
            Copyright.Text = My.MyProject.Application.Info.Copyright;
        }
    }
}