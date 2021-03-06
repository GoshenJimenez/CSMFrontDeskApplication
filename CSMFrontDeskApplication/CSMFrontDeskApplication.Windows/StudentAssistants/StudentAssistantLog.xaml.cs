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

namespace CSMFrontDeskApplication.Windows.StudentAssistants
{
    /// <summary>
    /// Interaction logic for StudentAssistantLog.xaml
    /// </summary>
    public partial class StudentAssistantLog : Window
    {
        private long pageIndex = 1;
        private long pageCount = 0;
        public StudentAssistantLog()
        {
            InitializeComponent();
            ShowData();
        }
        private void ShowData()
        {
            var studentassistantlogs = StudentAssistantLogBLL.Search((int)pageIndex, 1, txtSearchKeyword.Text);
            dgStudentAssistantLogs.ItemsSource = studentassistantlogs.Items;
            pageCount = studentassistantlogs.PageCount;
            lblPage.Content = " Showing page " + pageIndex + " of " + pageCount;
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

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;

            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            ShowData();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageCount;
            ShowData();
        }

        private void txtSearchKeyword_OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ShowData();
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            StudentAssistants.Login loginWindow = new StudentAssistants.Login(this);
            loginWindow.Show();
        }
    }
}
