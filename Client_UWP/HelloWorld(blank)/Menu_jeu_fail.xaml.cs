using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Windows.UI.Popups;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace HelloWorld_blank_
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Menu_jeu_fail : Page
    {
        public Menu_jeu_fail()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //handle first game
            //   C:\Users\Nabil\Desktop\Correction\Builds\Windows\Chessaken.exe

            //DefaultLaunch();
            
        }

        
        async void DefaultLaunch()
        {
            // Path to the file in the app package to launch
            //string exeFile = @"C:\Users\Nabil\Desktop\Correction\Builds\Windows\Chessaken.exe";

            string exeFile = @"C:\Users\Nabil\Desktop\Correction\Builds\Windows\diag.png";

            var file = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFileAsync(exeFile);


            
            if (file != null)
            {
                // Launch the retrieved file
                var success = await Windows.System.Launcher.LaunchFileAsync(file);



                if (success)
                {
                    // File launched
                    var dialog = new MessageDialog("Lancement");
                    await dialog.ShowAsync();
                }
                else
                {
                    // File launch failed
                    var dialog = new MessageDialog("Fail");
                    await dialog.ShowAsync();
                }
            }
            else
            {
                // Could not find file
                var dialog = new MessageDialog("Marche pas");
                await dialog.ShowAsync();
            }
            

        }

    }
}

