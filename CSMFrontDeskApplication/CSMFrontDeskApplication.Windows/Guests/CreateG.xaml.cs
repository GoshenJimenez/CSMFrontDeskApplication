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
    /// Interaction logic for CreateG.xaml
    /// </summary>
    public partial class CreateG : Window
    {

        private Guests.List listWindow;
        public CreateG(Guests.List parentWindow)
        {
            InitializeComponent();
            cboGender.ItemsSource = new List<string>() { "Male", "Female" };
            listWindow = parentWindow;
        }

        public Guid Id { get; private set; }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPersonName.Text))
            {
                MessageBox.Show("Please enter a Person's Name for the Guest Entry.");
                return;
            };
            
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter a Address for the Guest Entry.");
                return;
            };

            if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("Please enter a Age for the Guest Entry.");
                return;
            };
            if (cboGender.SelectedItem == null)
            {
                MessageBox.Show("Please enter a Gender for the Guest Entry.");
                return;
            }
        }
    }
}
