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
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private Birthdays.List listWindow;
        private Birthday dob;
        public Update(Birthday birthday, Birthdays.List parentWindow)
        {
            InitializeComponent();
            listWindow = parentWindow;
            dob = birthday;

            txtPersonName.Text = dob.PersonName;
            dtDate.Text = dob.Date.ToString("dd/MM/yyyy");
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
                dob.PersonName = txtPersonName.Text;
                dob.Date = bday;

                var op = BirthdayBLL.Update(dob);

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
            else
            {
                MessageBox.Show("Please enter a Valid Date for the Birthday Entry.");
                return;
            }

            
        }
    }
}
