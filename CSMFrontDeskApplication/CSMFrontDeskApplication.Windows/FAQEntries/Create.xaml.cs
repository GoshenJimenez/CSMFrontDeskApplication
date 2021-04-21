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
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        private FAQEntries.List listWindow;
        public Create(FAQEntries.List parentWindow)
        {
            InitializeComponent();
            listWindow = parentWindow;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {


            if (string.IsNullOrEmpty(txtQuestion.Text))
            {
                MessageBox.Show("Please Enter a Question for the FAQ Entry");
                return;
            };

            if (string.IsNullOrEmpty(txtAnswer.Text))
            {
                MessageBox.Show("Please Enter an Answer for the FAQ Entry");
                return;
            };


            FAQEntry entry = new FAQEntry();
            entry.Question = txtQuestion.Text;
            entry.Answer = txtAnswer.Text;
            entry.Id = Guid.NewGuid();

            var op = FAQEntryBLL.Create(entry);

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
