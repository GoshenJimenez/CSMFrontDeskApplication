using CSMFrontDeskApplication.Windows.BLL;
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
using System.Windows.Shapes;

namespace CSMFrontDeskApplication.Windows.Birthdays
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private int pageIndex = 1;

        public List()
        {
            InitializeComponent();
            var bdays = BirthdayBLL.Search(pageIndex, 1);
            dgBirthdays.ItemsSource = bdays.Items;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;
            var bdays = BirthdayBLL.Search(pageIndex, 1);
            dgBirthdays.ItemsSource = bdays.Items;
        }


    }
}
