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

namespace CSMFrontDeskApplication.Windows.Guests
{
    /// <summary>
    /// Interaction logic for GuestLog.xaml
    /// </summary>
    public partial class GuestLog : Window
    {
        private long pageIndex = 1;
        private long pageCount = 0;
        public GuestLog()
        {
            InitializeComponent();
            ShowData();
        }
        private void ShowData()
        {
            var guestlogs = GuestLogBLL.Search((int)pageIndex, 1);
            dgGuestLogs.ItemsSource = guestlogs.Items;
            pageCount = guestlogs.PageCount;
            lblPage.Content = " Showing page " + pageIndex + " of " + pageCount;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;

            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            ShowData();
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            ShowData();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;

            if (pageIndex < 1)
            {
                pageIndex = 1;
            }

            ShowData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageCount;
            ShowData();
        }
    }
}
