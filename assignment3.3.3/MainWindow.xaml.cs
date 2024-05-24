using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assignment3._3._3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> StudentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
            
        }


        private void addStudent_Click(object sender, RoutedEventArgs e)
        {
            var student = new Student();

            if (String.IsNullOrEmpty(this.studentId.Text))
            {
                MessageBox.Show("The student must have a student ID", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else 
            {
                student.StudentId = this.studentId.Text;
            }
            if (String.IsNullOrEmpty(this.firstName.Text))
            {
                MessageBox.Show("The student must have a first name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.FirstName = this.firstName.Text;
            }
            if (String.IsNullOrEmpty(this.lastName.Text))
            {
                MessageBox.Show("The student must have a last name", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.LastName = this.lastName.Text;
            }
            if (String.IsNullOrEmpty(this.address.Text))
            {
                MessageBox.Show("The student must have a address", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.Address = this.address.Text;
            }
            if (String.IsNullOrEmpty(this.monthOfAdmission.Text))
            {
                MessageBox.Show("The student must have a month of admission", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.MonthOfAdmission = this.monthOfAdmission.Text;
            }
            if (String.IsNullOrEmpty(this.GPA.Text))
            {
                MessageBox.Show("The student must have a GPA", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                student.GPA = Convert.ToDouble(this.GPA.Text);
            }

            StudentList.Add(student);
        }

        static void DeleteStudent() 
        {
        
        }

    }
}