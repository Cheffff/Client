using System;
using System.Collections.Generic;
using System.IO;
using PassportLogin;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;
using PassportLogin.Views;
using System.Data.SqlClient;
using Windows.UI.Popups;
using System.Collections.ObjectModel;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=234238

namespace PassportLogin.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class List_game : Page
    {


        public class Student
        {
            public int Id { get; set; }
            public string email { get; set; }
            public string Age { get; set; }
        }



        public List<Student> Getgame(string connectionString)
        {
            const string GetUsersQuery = "select [id_game], [name], [description] from [dbo].[games]";

            List<Student> gamelist = new List<Student>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open connection
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetUsersQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                // read through all rows
                                while (reader.Read())
                                {
                                    var user = new Student();
                                    // Get the only column value for each row
                                    user.Id = reader.GetInt32(0);
                                    user.email = reader.GetString(1);
                                    user.Age = reader.GetString(2);
                                    gamelist.Add(user);
                                }
                            }
                        }
                    }
                }
                    return gamelist;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
                return null;
        }


        private List<Student> listOfStudents = new List<Student>();
        public List_game()
        {
            //this.InitializeComponent();
            this.InitializeComponent();
            //Loaded += MainPage_Loaded;


            List<Student> list = new List<Student>();

            list = Getgame((App.Current as App).ConnectionString);
            StudentsList.ItemsSource = list;

        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void MenuButton1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Menu));
        }

        private void MenuButton2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Welcome));
        }

        private void Button_Click21(object sender, RoutedEventArgs e)
        {

            int id = (int)((Button)sender).Tag;

            String id_test = id.ToString();
            Frame.Navigate(typeof(Game_detail), id_test);

            //int id = int.Parse(((Button)sender).Tag);
            /*
            switch (id)
            {
                default: Frame.Navigate(typeof(Jeu));
                    break;

                case 1:
                    Frame.Navigate(typeof(DL_chess));
                    break;

                case 2: Frame.Navigate(typeof(DL_card));
                    break;
            }
            */
           // Frame.Navigate(typeof(Jeu));
        }

        //RECHERCHE

            /*
             * rehcerche box
             * 
             */


        private ObservableCollection<String> suggestions;


        public ObservableCollection<String> Getsuggest(string connectionString)
        {
            const string GetUsersQuery = "select [name] from [dbo].[games]";


            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Open connection
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetUsersQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                // read through all rows
                                while (reader.Read())
                                {
                                    string nom;
                                    // Get the only column value for each row
                                    nom = reader.GetString(0);

                                    suggestions.Add(nom);
                                }
                            }
                        }
                    }
                }
                return suggestions;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }


        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing, 
            // otherwise assume the value got filled in by TextMemberPath 
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //Set the ItemsSource to be your filtered dataset
                //sender.ItemsSource = dataset;

                // suggestions = Getsuggest((App.Current as App).ConnectionString);
                suggestions.Add(sender.Text + "1");
                suggestions.Add(sender.Text + "2");
                suggestions.Add(sender.Text + "toto");

                sender.ItemsSource = suggestions;


            }
        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)

        {

            if (args.ChosenSuggestion != null)

                txtAutoSuggestBox.Text = args.ChosenSuggestion.ToString();

            else

                txtAutoSuggestBox.Text = sender.Text;

        }

        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.

            txtAutoSuggestBox.Text = "Choosen";

        }


    }

}