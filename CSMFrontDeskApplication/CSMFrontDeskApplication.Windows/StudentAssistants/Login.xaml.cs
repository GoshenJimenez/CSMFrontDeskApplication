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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private StudentAssistants.StudentAssistantLog listWindow;

        public Login(StudentAssistants.StudentAssistantLog parentWindow = null)
        {
            InitializeComponent();
            listWindow = parentWindow;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var op = StudentAssistantBLL.Login(txtUserName.Text, txtPassword.Password);

            if (op.Code.ToLower() == "ok")
            {
                if (listWindow != null)
                {
                    //listWindow.ShowData();
                }
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
