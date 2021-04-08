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

namespace CSMFrontDeskApplication.Windows.Birthdays
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        private Birthdays.List listWindow;

        public Create(Birthdays.List parentWindow)
        {
            InitializeComponent();
            listWindow = parentWindow;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonName.Text))
            {
                MessageBox.Show("Please enter a Person's Name for the Birthday Entry.");
                return;
            };

            DateTime bday;
            if (DateTime.TryParse(dtDate.Text, out bday))
            {
                Birthday dob = new Birthday();
                dob.PersonName = txtPersonName.Text;
                dob.Date = bday;
                dob.Id = Guid.NewGuid();

                var op = BirthdayBLL.Create(dob);

                if(op.Code.ToLower() == "ok")
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
            else
            {
                MessageBox.Show("Please enter a Valid Date for the Birthday Entry.");
                return;
            }
        }
    }
}
