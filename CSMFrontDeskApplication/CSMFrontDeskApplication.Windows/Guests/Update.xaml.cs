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
        public Update(Guests.List parentWindow)
        {
            InitializeComponent();
           
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
