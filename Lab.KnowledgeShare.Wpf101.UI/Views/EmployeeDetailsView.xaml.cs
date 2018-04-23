using Lab.KnowledgeShare.Wpf101.Model;
using System.Windows;

namespace Lab.KnowledgeShare.Wpf101.UI.Views
{
    /// <summary>
    /// Interaction logic for EmployeeDetailsView.xaml
    /// </summary>
    public partial class EmployeeDetailsView : Window
    {
        public Employee SelectedEmployee { get; set; }

        public EmployeeDetailsView()
        {
            InitializeComponent();
            this.Loaded += EmployeeDetails_Loaded;
        }

        private void EmployeeDetails_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = SelectedEmployee;
        }
    }
}
