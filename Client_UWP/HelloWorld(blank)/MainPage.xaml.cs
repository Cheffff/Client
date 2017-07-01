using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld_blank_
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // ici lancement de la procedure de connexion
            // ajouter le using correspondant
            // data.sqlClient;
            /*
             *   var test = new MessageDialog("id" + textBox.Text + " et mdps" + passwordBox.Password.ToString() + "Balek" );
                 await test.ShowAsync();
             */

            String id = textBox.Text;
            String mdps = passwordBox.Password.ToString();

            // ici lancez la connexion a la base de donnée
            // SqlConnection co = new SqlConnection();
            //SqlDataAdapter data = new SqlDataAdapter("Select * From Databases where Login=" + id);//requete sql

            // if pour comparer 

            //Home home = new Home();
            //await home.Show


            Frame.Navigate(typeof(Page1));


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(inscription));
        }
    }
}
