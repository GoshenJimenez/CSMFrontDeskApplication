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

namespace CSMFrontDeskApplication.Windows.StudentAssistants
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Window
    {
        private StudentAssistants.List listWindow;
        public Create(StudentAssistants.List parentWindow )
        {
            InitializeComponent();
            listWindow = parentWindow;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPersonName.Text))
            {
                MessageBox.Show("Please Enter A Person's Name for the Student Assistant Entry");
                return;
            };

            if (string.IsNullOrEmpty(txtCourse.Text))
            {
                MessageBox.Show("Please Enter a Course for the Student Assistant Entry");
                return;
            };

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please Enter a Username for the Student Assistant Entry");
                return;
            };

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Enter a Password for the Student Assistant Entry");
                return;
            };


            StudentAssistant assistant = new StudentAssistant();
            assistant.PersonName = txtPersonName.Text;
            assistant.Course = txtCourse.Text;
            assistant.Username = txtUsername.Text;
            assistant.Password = txtPassword.Text;
            assistant.Id = Guid.NewGuid();

            var op = StudentAssistantBLL.Create(assistant);

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
