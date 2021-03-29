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
    /// Interaction logic for StudentAssistant.xaml
    /// </summary>
    public partial class StudentAssistant : Window
    {
        public StudentAssistant()
        {
            InitializeComponent();

            var studentassistants = StudentAssistantBLL.Search();
            dgStudentAssistants.ItemsSource = studentassistants.Items;
        }

       
    }
}
