using System;
using System.Collections.Generic;
using System.IO;
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
using PassportLogin.Models;
using PassportLogin.Utils;
using PassportLogin.AuthService;
using PassportLogin.Views;
using System.Data.SqlClient;
using System.Collections.ObjectModel;


// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace PassportLogin.Views
{

    public sealed partial class UserSelection : Page
    {
        public UserSelection()
        {
            InitializeComponent();
            Loaded += UserSelection_Loaded;
        }

        // Fetches the usernames of the registered users from the azure database
        public ObservableCollection<Account> GetUsers(string connectionString)
        {
            const string GetUsersQuery = "select [UserName] from [dbo].[AspNetUsers]";
            //const string GetUsersQuery = "select [email] from [dbo].[user]";


            // We use ObservableCollection<T> instead of List<T> to notify the ListView
            // when the values of its objects are changed 
            var users = new ObservableCollection<Account>();
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
                                    var user = new Account();
                                    // Get the only column value for each row
                                    user.Username = reader.GetString(0);
                                    users.Add(user);
                                }
                            }
                        }
                    }
                }
                return users;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;

        }


        private void UserSelection_Loaded(object sender, RoutedEventArgs e)
        {
            //List<UserAccount> accounts = AuthService.AuthService.Instance.GetUserAccountsForDevice(Helpers.GetDeviceId());
            ObservableCollection<Account> accounts = GetUsers((App.Current as App).ConnectionString);

            if (accounts.Any())
            {
                UserListView.ItemsSource = accounts;
                UserListView.SelectionChanged += UserSelectionChanged;
            }
            else
            {
                //If there are no accounts navigate to the LoginPage
                Frame.Navigate(typeof(Login));
            }
        }

        private void UserSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (((ListView)sender).SelectedValue != null)
            {
                UserAccount account = (UserAccount)((ListView)sender).SelectedValue;// ca merde ici
                // sauté passer dans login demander mdsp verifier 
                // et puis voila
               // if (account != null)
               // {
                    Debug.WriteLine("Account " + account.Username + " selected!");
               // }
                Frame.Navigate(typeof(Login), account);
            }
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private void Button_Restart_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserSelection));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Welcome));
        }

    }
}
