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
using DayByDay_Notes.Models;
using System.Collections.ObjectModel;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DayByDay_Notes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MyEventsPage : Page
    {
        private ObservableCollection<Event> Events;

        //public List<Event> Events;

        public MyEventsPage()
        {
            this.InitializeComponent();
            //Events = EventManager.GetEvents();
            Events = new ObservableCollection<Event>();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeVisibilityState(listView);

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

        private void AddEvent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EventsCalendarView_SelectedDateChanged(CalendarView sender, CalendarViewSelectedDatesChangedEventArgs args)
        {

        }

        private void AddNewEventButton_Clicked(object sender, RoutedEventArgs e)
        {

            Events.Add(new Models.Event
            {
                Content = NewEventInputTextBox.Text,
                Date = NewEventCalendarDatePicker.DateFormat
            });

            NewEventInputTextBox.Text = "";
            NewEventCalendarDatePicker.DateFormat = "";
        }
    }
}

