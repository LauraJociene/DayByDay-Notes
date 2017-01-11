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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DayByDay_Notes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame. 
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();            
        }

        private void NotesButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ListsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyListsPage));
        }

        private void EventsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MyEventsPage));
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SettingsPage));
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SearchPage));
        }

       

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
                       
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            ChangeVisibilityState(textBox);

        }

        //method used to change element's visibility, accepts element's name as a parameter.
        public void ChangeVisibilityState(UIElement test)
        {
            if (test.Visibility == Visibility.Collapsed)
            {
                test.Visibility = Visibility.Visible;
            }
            else
            {
                test.Visibility = Visibility.Collapsed;
            }
        }
    }

}
