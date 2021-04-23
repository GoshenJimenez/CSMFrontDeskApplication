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
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private FAQEntries.List listWindow;
        private FAQEntry entry;
        public Update(FAQEntry faqentry, FAQEntries.List parentWindow)
        {
            InitializeComponent();
            listWindow = parentWindow;
            entry = faqentry;

            
            txtQuestion.Text = entry.Question;
            txtAnswer.Text = entry.Answer;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuestion.Text))
            {
                MessageBox.Show("Please Enter A Question for the FAQ Entry");
                return;
            };

            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                MessageBox.Show("Please Enter an Answer for the FAQ Entry");
                return;
            };

            entry.Question = txtQuestion.Text;
            entry.Answer = txtAnswer.Text;

            var op = FAQEntryBLL.Update(entry);

            if (op.Code.ToLower() == "ok")
            {
                listWindow.ShowData();
                MessageBox.Show(op.Message.FirstOrDefault());
                this.Close();
            }
            else
            {
                MessageBox.Show(op.Message.FirstOrDefault());
            }

        }
    }
}
