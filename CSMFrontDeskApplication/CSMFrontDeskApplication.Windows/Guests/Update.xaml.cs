using CSMFrontDeskApplication.Windows.BLL;
using CSMFrontDeskApplication.Windows.Models;
using CSMFrontDeskApplication.Windows.Models.Enums;
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
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private Guests.List listWindow;
        private Guest log;
        public Update(Guest guest, Guests.List parentWindow)
        {
            InitializeComponent();
            cboGender.ItemsSource = new List<string>() { "Male", "Female" };
            listWindow = parentWindow;
            log = guest;

            txtPersonName.Text = log.PersonName;
            txtAddress.Text = log.Address;
            txtAge.Text = log.Age.ToString();
            cboGender.SelectedValue = log.Gender.ToString();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonName.Text))
            {
                MessageBox.Show("Please Enter A Person's Name for the Guest Entry");
                return;
            };
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please Enter A Address for the Guest Entry");
                return;
            };


            Gender gender = (Gender)Enum.Parse(typeof(Gender), cboGender.SelectedItem.ToString(), true);


            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Please enter only numbers.");
                return;
            }

            log.PersonName = txtPersonName.Text;
            log.Address = txtAddress.Text;
            log.Gender = gender;
            log.Age = age;

            var op = GuestBLL.Update(log);

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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
