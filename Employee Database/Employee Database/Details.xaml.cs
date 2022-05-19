using System.Windows;

namespace Employee_Database
{
    /// <summary>
    /// Interaction logic for Details.xaml
    /// </summary>
    public partial class Details : Window
    {
        readonly VM vm;
        public Details()
        {
            InitializeComponent();
            vm = VM.Instance;
            DataContext = vm;
        }

        private void Close_Details(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
