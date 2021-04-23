using CSMFrontDeskApplication.Windows.BLL;
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
using System.Windows.Shapes;

namespace CSMFrontDeskApplication.Windows.FAQEntries
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class List : Window
    {
        private long pageIndex = 1;
        private long pageCount = 0;

        public List()
        {
            InitializeComponent();
            ShowData();
        }


        public void ShowData()
        {
            var faqentries = FAQEntryBLL.Search((int)pageIndex, 10, txtSearchKeyword.Text);
            dgFAQEntries.ItemsSource = faqentries.Items;
            pageCount = faqentries.PageCount;
            lblPage.Content = " Showing page " + pageIndex + " of " + pageCount;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            FAQEntry faqentry= ((FrameworkElement)sender).DataContext as FAQEntry;
            Update updateWindow = new Update(faqentry, this);
            updateWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            FAQEntry faqentry = ((FrameworkElement)sender).DataContext as FAQEntry;
            if (MessageBox.Show(" Do you want to Delete FAQ entry for" + faqentry.Question +
                            " in" + faqentry.Answer + " ?", " Are you Sure?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {

                var op = FAQEntryBLL.Delete(faqentry);

                if (op.Code.ToLower() == "ok")
                {
                    ShowData();
                    MessageBox.Show(op.Message.FirstOrDefault());
                    this.Close();
                }
                else
                {
                    MessageBox.Show(op.Message.FirstOrDefault());
                }
            }

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

        private void txtSearchKeyword_OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                ShowData();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
           FAQEntries.Create createWindow = new FAQEntries.Create(this);
            createWindow.Show();
        }
    }
}
