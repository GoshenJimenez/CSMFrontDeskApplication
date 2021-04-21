using CSMFrontDeskApplication.Windows.BLL;
using CSMFrontDeskApplication.Windows.DAL;
using CSMFrontDeskApplication.Windows.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSMFrontDeskApplication.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowBirthdays();
        }

        private void ShowBirthdays()
        {
            var birthdays = BirthdayBLL.CelebrantsToday();
            
            foreach(var birthday in birthdays.Items)
            {
                lstBirthdays.Items.Add(birthday.PersonName);
            }            
        }

        private void btnBirthdays_Click(object sender, RoutedEventArgs e)
        {
            Birthdays.List birthdayWindow = new Birthdays.List();
            birthdayWindow.Show();
        }

        private void btnStudentAssistants_Click(object sender, RoutedEventArgs e)
        {
            StudentAssistants.List studentassistantWindow = new StudentAssistants.List();
            studentassistantWindow.Show();
        }

        private void btnStudentAssistantLogs_Click(object sender, RoutedEventArgs e)
        {
            StudentAssistants.StudentAssistantLog studentassistantlogWindow = new StudentAssistants.StudentAssistantLog();
            studentassistantlogWindow.Show();
        }
        private void btnGuestLog_Click(object sender, RoutedEventArgs e)
        {
            Guests.GuestLog guestlogWindow = new Guests.GuestLog();
            guestlogWindow.Show();
        }

        private void btnGuest_Click(object sender, RoutedEventArgs e)
        {
            Guests.List guestWindow = new Guests.List();
            guestWindow.Show();
        }

        private void btnFAQEntries_Click(object sender, RoutedEventArgs e)
        {
            FAQEntries.List faqentryWindow = new FAQEntries.List();
            faqentryWindow.Show();
        }

        private void btnSALogin_Click(object sender, RoutedEventArgs e)
        {
            StudentAssistants.Login loginWindow = new StudentAssistants.Login();
            loginWindow.Show();
        }
    }
}
