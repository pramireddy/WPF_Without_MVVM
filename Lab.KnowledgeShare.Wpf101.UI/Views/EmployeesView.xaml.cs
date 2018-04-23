using Lab.KnowledgeShare.Wpf101.Model;
using Lab.KnowledgeShare.Wpf101.UI.Extensions;
using Lab.KnowledgeShare.Wpf101.UI.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Lab.KnowledgeShare.Wpf101.UI.Views
{
    /// <summary>
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : Window
    {
        //private List<Employee> employees;
        private ObservableCollection<Employee> employees;
        private Employee selectedEmployee;

        public EmployeesView()
        {
            InitializeComponent();
            LoadData();
            
        }

        private void LoadData()
        {
            IEmployeeService employeeService = new EmployeeService();
            employees = employeeService.GetEmployees().ToObservableCollection();
            EmployeeView.ItemsSource = employees;
        
        }


        private void EmployeeView_SelectionChanged(object sender, SelectionChangedEventArgs e) => selectedEmployee = e.AddedItems[0] as Employee;

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            
            if (selectedEmployee != null)
            {
                EmployeeDetailsView employeeDetails = new EmployeeDetailsView
                {
                    SelectedEmployee = selectedEmployee
                };
                employeeDetails.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an Employee");
            }
            
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            Employee addEmployee = new Employee
            {
                Id = 119,
                FirstName = "QQQQ",
                LastName = "RRRR",
                Position = "Director",
                Salary = 130000,
                ImageId = 1
            };
            employees.Add(addEmployee);
        }
    }
}
